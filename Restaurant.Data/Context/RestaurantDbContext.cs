namespace Restaurant.Data
{
    using System.Data.Entity;
    using Models;

    public class RestaurantDbContext : DbContext, IRestaurantDbContext
    {
        public IDbSet<Ingredient> Ingredients { get; set; }

        public IDbSet<Recipe> Recipes { get; set; }

        public IDbSet<Nutrition> Nutritions { get; set; }

        public IDbSet<Storage> Storages { get; set; }

        public new IDbSet<TEntity> Set<TEntity>() where TEntity : class
        {
            return base.Set<TEntity>();
        }
    }
}
