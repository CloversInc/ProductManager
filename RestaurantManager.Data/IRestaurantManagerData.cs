using RestaurantManager.Data.Interfaces;
using RestaurantManager.DataBase;

namespace RestaurantManager.Data
{
    public interface IRestaurantManagerData
    {
        IRestaurantManagerDbContext Context { get; }

        IRepository<Product> Products { get; }
        IRepository<ProductType> ProductTypes { get; }
        IRepository<Recipe> Sets { get; }
        IRepository<RecipeType> SetTypes { get; }
        IRepository<UnitType> UnitTypes { get; }

        int SaveChanges();
    }
}
