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
        public virtual DbSet<Recipe> Recipes { get; set; }
        public virtual DbSet<RecipeType> RecipeTypes { get; set; }
        public virtual DbSet<UnitType> UnitTypes { get; set; }

        IDbSet<Product> IRestaurantManagerDbContext.Products { get; }
        IDbSet<ProductType> IRestaurantManagerDbContext.ProductTypes { get; }
        IDbSet<Recipe> IRestaurantManagerDbContext.Recipes { get; }
        IDbSet<RecipeType> IRestaurantManagerDbContext.RecipeTypes { get; }
        IDbSet<UnitType> IRestaurantManagerDbContext.UnitTypes { get; }

        public int SaveChanges()
        {
            return base.SaveChanges();
        }
    }
}