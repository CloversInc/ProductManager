using RestaurantManager.DataLayer.Repositories;
using RestaurantManager.DataLayer.Models;

namespace RestaurantManager.DataLayer
{
    public interface IRestaurantManagerData
    {
//        IRestaurantManagerDbContext Context { get; }

        IRepository<Product> Products { get; }
        IRepository<ProductType> ProductTypes { get; }
        IRepository<MenuItem> MenuItems { get; }
        IRepository<MenuItemType> MenuItemsTypes { get; }
        IRepository<UnitType> UnitTypes { get; }

        int SaveChanges();
    }
}
