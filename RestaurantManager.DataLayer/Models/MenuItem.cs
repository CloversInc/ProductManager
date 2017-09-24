
namespace RestaurantManager.DataLayer.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class MenuItem : IModel
    {
        public MenuItem()
        {
            this.Products = new HashSet<Product>();
            this.MenuTypes = new HashSet<MenuType>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public int UnitTypeId { get; set; }
        public int UnitTypeAmount { get; set; }
        public int MenuItemTypeId { get; set; }
    
        public virtual UnitType UnitType { get; set; }
        public virtual MenuItemType MenuItemType { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<MenuType> MenuTypes { get; set; }
    }
}
