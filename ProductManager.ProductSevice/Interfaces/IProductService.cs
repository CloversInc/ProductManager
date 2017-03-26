namespace ProductManager.ProductSevice
{
    using System.Collections.Generic;
    using Data;
    using Models;

    public interface IProductService
    {
        IEnumerable<Product> GetAll();
    }
}
