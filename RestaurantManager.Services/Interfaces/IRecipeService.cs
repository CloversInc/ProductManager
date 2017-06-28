using System.Collections.Generic;
using RestaurantManager.ViewModels;

namespace RestaurantManager.Services.Interfaces
{
    public interface IRecipeService
    {
        IEnumerable<MenuItemViewModel> GetAll();
    }
}
