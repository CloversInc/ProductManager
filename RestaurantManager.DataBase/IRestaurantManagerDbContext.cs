namespace RestaurantManager.DataBase
{
    using System.Data.Entity;

    public interface IRestaurantManagerDbContext
    {
        IDbSet<Product> Products { get; }
        IDbSet<ProductType> ProductTypes { get; }
        IDbSet<MenuItem> MenuItem { get; }
        IDbSet<MenuItemType> MenuItemTypes { get; }
        IDbSet<UnitType> UnitTypes { get; }

        int SaveChanges();
        void Dispose();
    }
}