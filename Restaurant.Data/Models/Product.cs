namespace Restourant.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using Restaurant.Data.Enums;
    using Restaurant.Data.Models;

    public class Product : Entry
    {
        [Required]
        public decimal Price { get; set; }

        [Required]
        public float Amount { get; set; }

        [Required]
        public MeasurementType MeasurementType { get; set; }

        public virtual ICollection<AllergenType> Allergens { get; set; }

        public int? StorageId { get; set; }

        public virtual Storage Storage { get; set; }

        public Product(string name) 
            : base(name)
        {
            this.Allergens = new List<AllergenType>();
        }
    }
}
