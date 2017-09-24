namespace RestaurantManager.Services.Interfaces
{
    using System.Collections.Generic;
    using DataLayer.Models;

    public interface IProductService
    {
        IEnumerable<Product> GetAll();
    }
}