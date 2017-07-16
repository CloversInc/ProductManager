namespace RestaurantManager.Services.Interfaces
{
    using System.Collections.Generic;
    using ViewAndBindingModels;

    public interface IProductService
    {
        IEnumerable<ProductViewModel> GetAll();
    }
}
