//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RestaurantManager.DataBase
{
    using System;
    using System.Collections.Generic;
    
    public partial class MenuItem
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
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
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Product> Products { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MenuType> MenuTypes { get; set; }
    }
}
