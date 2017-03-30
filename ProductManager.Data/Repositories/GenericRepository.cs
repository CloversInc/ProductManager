namespace ProductManager.Database.Repositories
{
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Linq;
    using Data.Interfaces;

    public class GenericRepository<T> : IRepository<T> where T : class
    {
        private readonly ProductManagerDbContext context;
        private readonly IDbSet<T> set;

        public GenericRepository(ProductManagerDbContext context)
        {
            this.context = context;
            this.set = this.context.Set<T>();
        }

        public IQueryable<T> GetAll()
        {
            return this.set.AsQueryable();
        }

        public T GetById(object id)
        {
            return this.set.Find(id);
        }

        public void Add(T entity)
        {
            DbEntityEntry entry = this.context.Entry(entity);
            if (entry.State != EntityState.Detached)
            {
                entry.State = EntityState.Added;
            }
            else
            {
                this.set.Add(entity);
            }
        }

        public void Update(T entity)
        {
            DbEntityEntry entry = this.context.Entry(entity);
            if (entry.State != EntityState.Detached)
            {
                this.set.Attach(entity);
            }

            entry.State = EntityState.Modified;
        }

        public void Delete(T entity)
        {
            DbEntityEntry entry = this.context.Entry(entity);
            if (entry.State != EntityState.Deleted)
            {
                entry.State = EntityState.Deleted;
            }
            else
            {
                this.set.Attach(entity);
                this.set.Remove(entity);
            }
        }

        public int SaveChanges()
        {
            return this.context.SaveChanges();
        }
    }
}
