namespace RestaurantManager.Services.Interfaces
{
    using System.Collections.Generic;
    using BindingViewModels;

    public interface IProductService
    {
        IEnumerable<ProductViewModel> GetAll();
    }
}
