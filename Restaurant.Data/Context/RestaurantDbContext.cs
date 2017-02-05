namespace Restaurant.Data
{
    using System.Data.Entity;
    using Models;
    using Restourant.Data.Migrations;
    using Restourant.Data.Models;

    public class RestaurantDbContext : DbContext, IRestaurantDbContext
    {
        public RestaurantDbContext()
            : base("RestaurantDb")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<RestaurantDbContext, Configuration>());
        }

        public IDbSet<Product> Products { get; set; }

        public IDbSet<Ingredient> Ingredients { get; set; }

        public IDbSet<Drink> Drinks { get; set; }

        public IDbSet<Recipe> Recipes { get; set; }

        public IDbSet<Nutrition> Nutritions { get; set; }

        public IDbSet<Storage> Storages { get; set; }

        public new IDbSet<TEntity> Set<TEntity>() where TEntity : class
        {
            return base.Set<TEntity>();

        }
    }
}
