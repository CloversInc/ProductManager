using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace RestaurantManager.DataBase
{
    public class RestaurantManagerDbContext : DbContext, IRestaurantManagerDbContext
    {
        public RestaurantManagerDbContext()
            : base("name=RestaurantManagerEntities")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }

        public IDbSet<Product> Products { get; }
        public IDbSet<ProductType> ProductTypes { get; }
        public IDbSet<MenuItem> MenuItem { get; }
        public IDbSet<MenuItemType> MenuItemTypes { get; }
        public IDbSet<UnitType> UnitTypes { get; }

        public int SaveChanges()
        {
            return base.SaveChanges();
        }
    }
}