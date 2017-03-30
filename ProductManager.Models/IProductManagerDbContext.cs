namespace ProductManager.Database.ProductManager
{
    using System.Data.Entity;

    public interface IProductManagerDbContext
    {
        IDbSet<Product> Products { get; }
        IDbSet<ProductType> ProductTypes { get; }
        IDbSet<Set> Sets { get; set; }
        IDbSet<SetType> SetTypes { get; }
        IDbSet<Storage> Storages { get; }
        IDbSet<UnitType> UnitTypes { get; }

        int SaveChanges();
        void Dispose();
    }
}