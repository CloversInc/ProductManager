namespace RestaurantManager.Service.Dummy
{
    using System;
    using System.Collections.Generic;
    using RestaurantManager.DataLayer.Models;
    using RestaurantManager.Services.Interfaces;
    
    public class DummyProductService : IProductService
    {
        private DummyStorage storage;

        public DummyProductService()
        {
            this.storage = DummyStorage.GetInstance();
        }
       
        public IEnumerable<Product> GetAll()
        {
            return this.storage.Products.Values;
        }
    }
}