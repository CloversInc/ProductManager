using System.Collections.Generic;
using RestaurantManager.ViewModels;

namespace RestaurantManager.Services.Interfaces
{
    public interface IProductService
    {
        IEnumerable<ProductViewModel> GetAll();
    }
}
