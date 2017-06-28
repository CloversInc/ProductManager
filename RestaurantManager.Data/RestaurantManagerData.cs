using System;
using System.Collections.Generic;
using RestaurantManager.Data.Interfaces;
using RestaurantManager.Data.Repositories;
using RestaurantManager.DataBase;

namespace RestaurantManager.Data
{
    public class RestaurantManagerData : IRestaurantManagerData
    {
        private IRestaurantManagerDbContext context;
        private readonly Dictionary<Type, object> repositories = new Dictionary<Type, object>();

        public RestaurantManagerData(IRestaurantManagerDbContext context)
        {
            this.context = context;
        }

        public IRestaurantManagerDbContext Context { get { return this.context; } }
        public IRepository<Product> Products { get { return this.GetRepository<Product>(); } }
        public IRepository<ProductType> ProductTypes { get { return this.GetRepository<ProductType>(); } }
        public IRepository<MenuItem> MenuItems { get { return this.GetRepository<MenuItem>(); } }
        public IRepository<MenuItemType> MenuItemsTypes { get { return this.GetRepository<MenuItemType>(); } }
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