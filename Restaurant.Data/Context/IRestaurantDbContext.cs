namespace Restaurant.Data
{
    using System.Data.Entity;
    using Models;
    using System.Data.Entity.Infrastructure;
    using Restourant.Data.Models;

    public interface IRestaurantDbContext
    {
        IDbSet<Product> Products { get; set; }

        IDbSet<Ingredient> Ingredients { get; set; }

        IDbSet<Drink> Drinks { get; set; }

        IDbSet<Recipe> Recipes { get; set; }
        
        IDbSet<Nutrition> Nutritions { get; set; }

        IDbSet<Storage> Storages { get; set; }
        
        IDbSet<TEntity> Set<TEntity>() where TEntity : class;

        DbEntityEntry Entry(object entity);

        int SaveChanges();

        void Dispose();
    }
}