namespace RestaurantManager.Service.Dummy
{
    using System;

    using RestaurantManager.DataLayer.Models;
    using System.Collections.Generic;

    public class DummyStorage
    {
        private static DummyStorage instance;
        public static DummyStorage GetInstance()
        {
            return instance ?? (instance = new DummyStorage());
        }
        
        public Dictionary<int, MenuItem> MenuItems = new Dictionary<int, MenuItem>();
        public Dictionary<int, MenuItemType> MenuItemTypes = new Dictionary<int, MenuItemType>();
        public Dictionary<int, UnitType> UnitTypes = new Dictionary<int, UnitType>();
        
        public Dictionary<int, Product> Products = new Dictionary<int, Product>();
        public Dictionary<int, ProductType> ProductTypes = new Dictionary<int, ProductType>();

        private DummyStorage()
        {
            var productType1 = new ProductType
                                   {
                                      Id = 1,
                                      Name = "ProductTypeName1"
                                   };
            this.ProductTypes.Add(productType1.Id, productType1);
            
            var product1 = new Product
                               {
                                   Id = 1,
                                   Name = "Product1",
                                   Description = "Descr.",
                                   Price = 10M,
                                   CreatedOn = new DateTime(),
                               };
            this.Products.Add(product1.Id, product1);
        }
        
    }
}