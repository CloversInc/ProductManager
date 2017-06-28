using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using RestaurantManager.Data;
using RestaurantManager.DataBase;
using RestaurantManager.Services.Interfaces;
using RestaurantManager.ViewModels;

namespace RestaurantManager.Services.Implementations
{
    public class MenuItemService : BaseService, IMenuItemService
    {
        public MenuItemService(IRestaurantManagerData data)
            : base(data)
        {
        }

        public IEnumerable<MenuItemViewModel> GetAll()
        {
            IEnumerable<MenuItem> menuItems = this.Data.MenuItems.GetAll();
            IEnumerable<MenuItemViewModel> result = Mapper.Map<IEnumerable<MenuItem>, IEnumerable<MenuItemViewModel>>(menuItems);

            return result;
        }

        public MenuItemPdfViewModel GetPdfViewModel()
        {
            IEnumerable<MenuItem> menuItems = this.Data.MenuItems.GetAll();
            MenuItemPdfViewModel model = new MenuItemPdfViewModel();

            foreach (var menuItem in menuItems)
            {
                if (!model.MenuItemViewModels.ContainsKey(menuItem.MenuItemTypeId))
                {
                    model.MenuItemViewModels.Add(menuItem.MenuItemType.OrderId, new List<MenuItemViewModel>());
                }

                MenuItemViewModel value = Mapper.Map<MenuItem, MenuItemViewModel>(menuItem);
                model.MenuItemViewModels[menuItem.MenuItemTypeId].Add(value);
            }

            return model;
        }
    }
}