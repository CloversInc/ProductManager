namespace RestaurantManager.Service.Dummy
{
    using System.Collections.Generic;

    using RestaurantManager.DataLayer.Models;
    using RestaurantManager.Services.Interfaces;
    public class DummyMenuItemService : IMenuItemService
    {
        private DummyStorage storage;

        public DummyMenuItemService()
        {
            this.storage = DummyStorage.GetInstance();
        }
        
        public IEnumerable<MenuItem> GetAll()
        {
            return this.storage.MenuItems.Values;
        }

        public MenuItem GetPdfViewModel()
        {
            throw new System.NotImplementedException();
        }

        public MenuItem GetById(int id)
        {
            return this.storage.MenuItems[id];
        }

        public IEnumerable<MenuItemType> MenuItemTypes()
        {
            return this.storage.MenuItemTypes.Values;
        }

        public IEnumerable<UnitType> UnitItemTypes()
        {
            return this.storage.UnitTypes.Values;
        }
    }
}