namespace ProductManager.Services.Implementation
{
    using System.Collections.Generic;
    using System.Linq;
    using AutoMapper;
    using Data;
    using Database;
    using Interfaces;
    using ViewModels;

    public class ProductService : BaseService, IProductService
    {
        public ProductService(IProductManagerData data)
            : base(data)
        {
        }

        public IEnumerable<ProductViewModel> GetAll()
        {
            //Custom mapping example
            //Mapper.Initialize(cfg => cfg.CreateMap<Product, ProductViewModel>()
            //    .ForMember(d => d.Description, opt => opt.ResolveUsing(res => res.Name)));

            Mapper.Initialize(cfg => cfg.CreateMap<Product, ProductViewModel>());

            IEnumerable<Product> dbProducts = this.Data.Products.GetAll();
            IEnumerable<ProductViewModel> result = Mapper.Map<IEnumerable<Product>, IEnumerable<ProductViewModel>>(dbProducts);

            return result;
        }
    }
}