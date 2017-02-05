namespace Restaurant.Data.Models
{
    using System.Collections.Generic;
    using Enums;

    public class Ingredient : Entry
    {
        public decimal Price { get; set; }

        public float Amount { get; set; }

        public MeasurementType MeasurementType { get; set; }

        public virtual ICollection<AllergenType> Type { get; set; }
    }
}