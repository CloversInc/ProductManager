namespace ProductManager.ProductSevice
{
    using System.Collections.Generic;
    using Data;

    public interface IProductService
    {
        IEnumerable<Product> GetAll();
    }
}
