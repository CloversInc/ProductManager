using AutoMapper;
using RestaurantManager.DataBase;
using RestaurantManager.ViewModels;

namespace RestaurantManager.Services.Configurations
{
    public static class MapperConfig
    {
        public static void Initilize()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<Product, ProductViewModel>();
                cfg.CreateMap<MenuItem, MenuItemViewModel>();
            });
        }
    }
}