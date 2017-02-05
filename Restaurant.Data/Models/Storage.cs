namespace Restaurant.Data.Models
{
    using System.Collections.Generic;
    using Restourant.Data.Models;

    public class Storage : Entry
    {
        public virtual ICollection<Product> Products { get; set; }

        public Storage(string name) 
            : base(name)
        {
            this.Products = new List<Product>();
        }
    }
}