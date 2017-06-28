using RestaurantManager.Data.Interfaces;
using RestaurantManager.DataBase;

namespace RestaurantManager.Data
{
    public interface IRestaurantManagerData
    {
        IRestaurantManagerDbContext Context { get; }

        IRepository<Product> Products { get; }
        IRepository<ProductType> ProductTypes { get; }
        IRepository<MenuItem> Recipes { get; }
        IRepository<MenuItemType> RecipeTypes { get; }
        IRepository<UnitType> UnitTypes { get; }

        int SaveChanges();
    }
}
