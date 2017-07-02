namespace RestaurantManager.Services.Interfaces
{
    using System.Collections.Generic;
    using BindingViewModels.ViewModels;

    public interface IMenuItemService
    {
        IEnumerable<MenuItemViewModel> GetAll();
        MenuItemPdfViewModel GetPdfViewModel();
        MenuItemFullViewModel GetById(int id);
        IEnumerable<MenuItemTypeViewModel> MenuItemTypes();
        IEnumerable<UnitTypesViewModel> UnitItemTypes();
    }
}
