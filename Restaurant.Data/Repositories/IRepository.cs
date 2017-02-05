using System.Linq;

namespace Restaurant.Data.Repositories
{
    interface IRepository<T>
    {
        IQueryable<T> GetAll();

        T GetById(object id);

        void Add(T entity);

        void Update(T entity);

        void Delete(T entity);

        int SaveChanges();
    }
}
