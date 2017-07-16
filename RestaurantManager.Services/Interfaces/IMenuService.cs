namespace RestaurantManager.Services.Interfaces
{
    using Rotativa;
    using System.Collections.Generic;
    using ViewAndBindingModels.ViewModels;

    public interface IMenuService
    {
        IEnumerable<MenuItemViewModel> GetAll();

        MenuItemPdfViewModel GetPdfViewModel();

        MenuItemFullViewModel GetById(int id);

        IEnumerable<MenuItemTypeViewModel> MenuItemTypes();

        IEnumerable<UnitTypesViewModel> UnitItemTypes();

        PartialViewAsPdf CreatePdf(MenuItemPdfViewModel model);
    }
}
