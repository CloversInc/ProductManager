
namespace RestaurantManager.DataLayer.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class MenuItemType : IModel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MenuItemType()
        {
            this.MenuItems = new HashSet<MenuItem>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public int OrderId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MenuItem> MenuItems { get; set; }
    }
}
