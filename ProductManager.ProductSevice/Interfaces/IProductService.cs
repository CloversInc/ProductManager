namespace ProductManager.Services.Interfaces
{
    using System.Collections.Generic;
    using Database;

    public interface IProductService
    {
        IEnumerable<Product> GetAll();
    }
}
