using System.Linq;

namespace RestaurantManager.Data.Interfaces
{
    public interface IRepository<T>
    {
        IQueryable<T> GetAll();

        T GetById(object id);

        void Add(T entity);

        void Update(T entity);

        void Delete(T entity);

        int SaveChanges();
    }
}