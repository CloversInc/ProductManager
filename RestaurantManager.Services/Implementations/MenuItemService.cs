namespace RestaurantManager.Services.Implementations
{
    using System.Collections.Generic;
    using AutoMapper;
    using BindingViewModels.Mapper;
    using BindingViewModels.ViewModels;
    using Data;
    using DataBase;
    using Interfaces;

    public class MenuItemService : BaseService, IMenuItemService
    {
        public MenuItemService(IRestaurantManagerData data, IMappingService mappingService)
            : base(data, mappingService)
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

                MenuItemViewModel value = this.MappingService.Map<MenuItemViewModel>(menuItem);
                model.MenuItemViewModels[menuItem.MenuItemTypeId].Add(value);
            }

            return model;
        }

        public MenuItemFullViewModel GetById(int id)
        {
            return this.MappingService.Map<MenuItemFullViewModel>(this.Data.MenuItems.GetById(id));
        }

        public IEnumerable<MenuItemTypeViewModel> MenuItemTypes()
        {
            return this.MappingService.Map<IEnumerable<MenuItemTypeViewModel>>(this.Data.MenuItemsTypes.GetAll());
        }

        public IEnumerable<UnitTypesViewModel> UnitItemTypes()
        {
            return this.MappingService.Map<IEnumerable<UnitTypesViewModel>>(this.Data.UnitTypes.GetAll());
        }
    }
}