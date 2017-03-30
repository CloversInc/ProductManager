namespace ProductManager.Services.Interfaces
{
    using System.Collections.Generic;
    using Database;
    using ViewModels;

    public interface IProductService
    {
        IEnumerable<ProductViewModel> GetAll();
    }
}
