namespace ProductManager.Data
{
    using Database;
    using Database.ProductManager;
    using Interfaces;

    public interface IProductManagerData
    {
        IProductManagerDbContext Context { get; }

        IRepository<Product> Products { get; }
        IRepository<ProductType> ProductTypes { get; }
        IRepository<Set> Sets { get; }
        IRepository<SetType> SetTypes { get; }
        IRepository<Storage> Storages { get; }
        IRepository<UnitType> UnitTypes { get; }

        int SaveChanges();
    }
}
