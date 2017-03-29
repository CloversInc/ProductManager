namespace ProductManager.Database
{
    using System;
    using System.Data.Entity;
    using Database;

    public partial class ProductManagerDbContext : IProductManagerDbContext
    {
        IDbSet<Product> IProductManagerDbContext.Products { get; set; }
        IDbSet<ProductType> IProductManagerDbContext.ProductTypes { get; set; }
        IDbSet<Set> IProductManagerDbContext.Sets { get; set; }
        IDbSet<SetType> IProductManagerDbContext.SetTypes { get; set; }
        IDbSet<Storage> IProductManagerDbContext.Storages { get; set; }
        IDbSet<UnitType> IProductManagerDbContext.UnitTypes { get; set; }
    }

    public interface IProductManagerDbContext
    {
        IDbSet<Product> Products { get; set; }
        IDbSet<ProductType> ProductTypes { get; set; }
        IDbSet<Set> Sets { get; set; }
        IDbSet<SetType> SetTypes { get; set; }
        IDbSet<Storage> Storages { get; set; }
        IDbSet<UnitType> UnitTypes { get; set; }
    }
}
