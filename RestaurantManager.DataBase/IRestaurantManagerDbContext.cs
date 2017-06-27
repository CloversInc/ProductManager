namespace RestaurantManager.DataBase
{
    using System.Data.Entity;

    public interface IRestaurantManagerDbContext
    {
        IDbSet<Product> Products { get; }
        IDbSet<ProductType> ProductTypes { get; }
        IDbSet<Recipe> Recipes { get; }
        IDbSet<RecipeType> RecipeTypes { get; }
        IDbSet<UnitType> UnitTypes { get; }

        int SaveChanges();
        void Dispose();
    }
}