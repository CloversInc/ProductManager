using System.Collections.Generic;
using AutoMapper;
using RestaurantManager.Data;
using RestaurantManager.DataBase;
using RestaurantManager.Services.Interfaces;
using RestaurantManager.ViewModels;

namespace RestaurantManager.Services.Implementations
{
    public class ProductService : BaseService, IProductService
    {
        public ProductService(IRestaurantManagerData data)
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
