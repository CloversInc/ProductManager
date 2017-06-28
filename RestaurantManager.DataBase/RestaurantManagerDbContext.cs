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

        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductType> ProductTypes { get; set; }
        public virtual DbSet<MenuItem> Recipes { get; set; }
        public virtual DbSet<MenuItemType> RecipeTypes { get; set; }
        public virtual DbSet<UnitType> UnitTypes { get; set; }

        IDbSet<Product> IRestaurantManagerDbContext.Products { get; }
        IDbSet<ProductType> IRestaurantManagerDbContext.ProductTypes { get; }
        IDbSet<MenuItem> IRestaurantManagerDbContext.Recipes { get; }
        IDbSet<MenuItemType> IRestaurantManagerDbContext.RecipeTypes { get; }
        IDbSet<UnitType> IRestaurantManagerDbContext.UnitTypes { get; }

        public int SaveChanges()
        {
            return base.SaveChanges();
        }
    }
}