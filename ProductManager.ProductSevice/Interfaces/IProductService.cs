namespace ProductManager.ProductSevice
{
    using System.Collections.Generic;
    using Database;

    public interface IProductService
    {
        IEnumerable<Product> GetAll();
    }
}
