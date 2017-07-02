namespace RestaurantManager.Services.Implementations
{
    using System.Collections.Generic;
    using BindingViewModels;
    using BindingViewModels.Mapper;
    using Data;
    using DataBase;
    using Interfaces;

    public class ProductService : BaseService, IProductService
    {
        public ProductService(IRestaurantManagerData data, IMappingService mappingService)
            : base(data, mappingService)
        {
        }

        public IEnumerable<ProductViewModel> GetAll()
        {
            //Custom mapping example
            //Mapper.Initialize(cfg => cfg.CreateMap<Product, ProductViewModel>()
            //    .ForMember(d => d.Description, opt => opt.ResolveUsing(res => res.Name)));

            IEnumerable<Product> dbProducts = this.Data.Products.GetAll();

            IEnumerable<ProductViewModel> result = this.MappingService.Map<IEnumerable<ProductViewModel>>(dbProducts);

            return result;
        }
    }
}
