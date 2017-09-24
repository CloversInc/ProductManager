
namespace RestaurantManager.DataLayer.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Product : IModel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            this.MenuItems = new HashSet<MenuItem>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public int ProductTypeId { get; set; }
        public int UnitTypeAmount { get; set; }
        public int UnitTypeId { get; set; }
    
        public virtual ProductType ProductType { get; set; }
        public virtual UnitType UnitType { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MenuItem> MenuItems { get; set; }
    }
}
