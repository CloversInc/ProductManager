namespace ProductManager.Database
{
    using System.Data.Entity;
    using Database;
    using Database.ProductManager;

    public partial class ProductManagerDbContext : IProductManagerDbContext
    {
        IDbSet<Product> IProductManagerDbContext.Products { get; }
        IDbSet<ProductType> IProductManagerDbContext.ProductTypes { get; }
        IDbSet<Set> IProductManagerDbContext.Sets { get; set; }
        IDbSet<SetType> IProductManagerDbContext.SetTypes { get; }
        IDbSet<Storage> IProductManagerDbContext.Storages { get; }
        IDbSet<UnitType> IProductManagerDbContext.UnitTypes { get; }

        public int SaveChanges()
        {
            return base.SaveChanges();
        }
    }
}