using System.Collections.Generic;
using RestaurantManager.ViewModels;

namespace RestaurantManager.Services.Interfaces
{
    public interface IMenuItemService
    {
        IEnumerable<MenuItemViewModel> GetAll();
        MenuItemPdfViewModel GetPdfViewModel();
    }
}
