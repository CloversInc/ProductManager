using RestaurantManager.Data.Interfaces;
using RestaurantManager.DataBase;

namespace RestaurantManager.Data
{
    public interface IRestaurantManagerData
    {
        IRestaurantManagerDbContext Context { get; }

        IRepository<Product> Products { get; }
        IRepository<ProductType> ProductTypes { get; }
        IRepository<MenuItem> MenuItems { get; }
        IRepository<MenuItemType> MenuItemsTypes { get; }
        IRepository<UnitType> UnitTypes { get; }

        int SaveChanges();
    }
}
