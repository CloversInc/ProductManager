namespace RestaurantManager.Web.Presenters
{
    using System.Collections.Generic;
    using System.Linq;

    using RestaurantManager.DataLayer.Models;
    using RestaurantManager.Web.Models;

    public class MenuItemPresenter
    {
        public static MenuItemPdfViewModel GetPdfViewModel(IEnumerable<MenuItem> menuItems)
        {
            var model = new MenuItemPdfViewModel();

            foreach (var menuItem in menuItems)
            {
                if (!model.MenuItemViewModels.ContainsKey(menuItem.MenuItemTypeId))
                {
                    model.MenuItemViewModels.Add(menuItem.MenuItemType.OrderId, new List<MenuItemViewModel>());
                }

                var value = new MenuItemViewModel
                                              {
                                                  Id = menuItem.Id,
                                                  MenuItemTypeName = menuItem.MenuItemType.Name,
                                                  Name = menuItem.Name,
                                                  UnitTypeAmount = menuItem.UnitTypeAmount.ToString(),
                                                  UnitTypeName = menuItem.UnitType.Name,
                                              };
                model.MenuItemViewModels[menuItem.MenuItemTypeId].Add(value);
            }

            return model;
        }

        public static MenuItemFullViewModel PresentFullMenuItem(MenuItem menuItem)
        {
            return new MenuItemFullViewModel
                       {
                           Id = menuItem.Id,
                           Name = menuItem.Name,
                           Price = menuItem.Price,
                           UnitTypeAmount = menuItem.UnitTypeAmount.ToString(),
                       };
        }

        public static IEnumerable<MenuItemTypeViewModel> MenuItemTypes(IEnumerable<MenuItemType> menuItemTypes)
        {
            return menuItemTypes.
                Select(rawProduct => new MenuItemTypeViewModel
                                         {
                                             Id = rawProduct.Id, 
                                             Name = rawProduct.Name, 
                                         })
                .ToList();
        }
        
        public static IEnumerable<UnitTypesViewModel> UnitItemTypes(IEnumerable<UnitType> unitTypes)
        {
            return unitTypes.
                Select(rawProduct => new UnitTypesViewModel
                                         {
                                             Id = rawProduct.Id, 
                                             Name = rawProduct.Name, 
                                         })
                .ToList();
        }
    }
}