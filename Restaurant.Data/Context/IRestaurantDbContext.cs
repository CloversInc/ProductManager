namespace Restaurant.Data
{
    using System.Data.Entity;
    using Models;
    using System.Data.Entity.Infrastructure;

    public interface IRestaurantDbContext
    {
        IDbSet<Ingredient> Ingredients { get; set; }

        IDbSet<Recipe> Recipes { get; set; }

        IDbSet<Nutrition> Nutritions { get; set; }

        IDbSet<Storage> Storages { get; set; }

        IDbSet<TEntity> Set<TEntity>() where TEntity : class;

        DbEntityEntry Entry(object entity);

        int SaveChanges();

        void Dispose();
    }
}