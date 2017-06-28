using System.Collections.Generic;
using AutoMapper;
using RestaurantManager.Data;
using RestaurantManager.DataBase;
using RestaurantManager.Services.Interfaces;
using RestaurantManager.ViewModels;

namespace RestaurantManager.Services.Implementations
{
    public class RecipeService : BaseService, IRecipeService
    {
        public RecipeService(IRestaurantManagerData data)
            : base(data)
        {
        }

        public IEnumerable<MenuItemViewModel> GetAll()
        {
            //Custom mapping example
            //Mapper.Initialize(cfg => cfg.CreateMap<Product, ProductViewModel>()
            //    .ForMember(d => d.Description, opt => opt.ResolveUsing(res => res.Name)));

            IEnumerable<MenuItem> dbProducts = this.Data.Recipes.GetAll();
            IEnumerable<MenuItemViewModel> result = Mapper.Map<IEnumerable<MenuItem>, IEnumerable<MenuItemViewModel>>(dbProducts);

            return result;
        }
    }
}