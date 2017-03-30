namespace ProductManager.Services.Implementation
{
    using System.Collections.Generic;
    using System.Linq;
    using Data;
    using Database;
    using Interfaces;

    public class ProductService : BaseService, IProductService
    {
        public ProductService(IProductManagerData data)
            : base(data)
        {
        }

        public IEnumerable<Product> GetAll()
        {
            IEnumerable<Product> result = this.Data.Products.GetAll().ToList();

            return result;
        }
    }
}