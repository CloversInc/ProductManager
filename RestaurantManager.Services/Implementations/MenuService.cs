namespace RestaurantManager.Services.Implementations
{

    using Rotativa;
    using Rotativa.Options;
    using System.Collections.Generic;
    using AutoMapper;
    using ViewAndBindingModels.Mapper;
    using ViewAndBindingModels.ViewModels;
    using Data;
    using DataBase;
    using Interfaces;

    public class MenuService : BaseService, IMenuService
    {
        public MenuService(IRestaurantManagerData data, IMappingService mappingService)
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

        public PartialViewAsPdf CreatePdf(MenuItemPdfViewModel model)
        {
            var pdf = new PartialViewAsPdf("_MenuLunchPdf", model)
            {
                FileName = "test.pdf",
                CustomSwitches = "--disable-smart-shrinking --load-error-handling ignore",
                PageSize = Size.A4,
                PageMargins = new Margins(0, 0, 0, 0),
                PageOrientation = Orientation.Landscape
            };

            return pdf;
        }
    }
}