namespace ProductManager.ProductSevice
{
    using System.Collections.Generic;
    using System.Linq;
    using Database;
    using Database.Repositories;

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