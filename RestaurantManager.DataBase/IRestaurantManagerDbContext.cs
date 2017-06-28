namespace RestaurantManager.DataBase
{
    using System.Data.Entity;

    public interface IRestaurantManagerDbContext
    {
        IDbSet<Product> Products { get; }
        IDbSet<ProductType> ProductTypes { get; }
        IDbSet<MenuItem> Recipes { get; }
        IDbSet<MenuItemType> RecipeTypes { get; }
        IDbSet<UnitType> UnitTypes { get; }

        int SaveChanges();
        void Dispose();
    }
}