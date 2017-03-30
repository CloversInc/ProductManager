namespace ProductManager.Data
{
    using System;
    using System.Collections.Generic;
    using Database;
    using Database.ProductManager;
    using Database.Repositories;
    using Interfaces;

    public class ProductManagerData : IProductManagerData
    {
        private IProductManagerDbContext context;
        private readonly Dictionary<Type, object> repositories = new Dictionary<Type, object>();

        public ProductManagerData(IProductManagerDbContext context)
        {
            this.context = context;
        }

        public IProductManagerDbContext Context { get { return this.context; } }
        public IRepository<Product> Products { get { return this.GetRepository<Product>(); } }
        public IRepository<ProductType> ProductTypes { get { return this.GetRepository<ProductType>(); } }
        public IRepository<Set> Sets { get { return this.GetRepository<Set>(); } }
        public IRepository<SetType> SetTypes { get { return this.GetRepository<SetType>(); } }
        public IRepository<Storage> Storages { get { return this.GetRepository<Storage>(); } }
        public IRepository<UnitType> UnitTypes { get { return this.GetRepository<UnitType>(); } }

        public int SaveChanges()
        {
            return this.context.SaveChanges();
        }

        public void Dispose()
        {
            this.Dispose(true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (!disposing)
            {
                return;
            }

            if (this.context != null)
            {
                this.context.Dispose();
            }
        }

        private IRepository<T> GetRepository<T>() where T : class
        {
            Type type = typeof(T);
            if (!repositories.ContainsKey(type))
            {
                Type repositoryType = typeof(GenericRepository<T>);
                object instance = Activator.CreateInstance(repositoryType, this.context);
                repositories.Add(type, instance);
            }

            return (IRepository<T>)repositories[type];
        }
    }
}