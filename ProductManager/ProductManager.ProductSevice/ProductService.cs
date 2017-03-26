namespace ProductManager.ProductSevice
{
    using System.Collections.Generic;
    using System.Linq;
    using Data;
    using Data.Repositories;
    using Models;

    public class ProductService : IProductService
    {
        private readonly IRepository<Product> productRepository;

        public ProductService(IRepository<Product> productRepository)
        {
            this.productRepository = productRepository;
        }

        public IEnumerable<Product> GetAll()
        {
            return this.productRepository.GetAll().ToList();
        }
    }
}