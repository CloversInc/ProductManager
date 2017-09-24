namespace RestaurantManager.Services.Interfaces
{
    using System.Collections.Generic;
    using RestaurantManager.DataLayer.Models;
    
    public interface IMenuItemService
    {
        IEnumerable<MenuItem> GetAll();
        MenuItem GetPdfViewModel();
        MenuItem GetById(int id);
        IEnumerable<MenuItemType> MenuItemTypes();
        IEnumerable<UnitType> UnitItemTypes();
    }
}