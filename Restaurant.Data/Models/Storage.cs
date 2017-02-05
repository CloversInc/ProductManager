namespace Restaurant.Data.Models
{
    using System.Collections.Generic;

    public class Storage : Entry
    {
        public virtual ICollection<Ingredient> Ingredients { get; set; }
    }
}