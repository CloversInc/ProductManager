namespace Restaurant.Data.Models
{
    using System;
    using System.Collections.Generic;

    public class Recipe : Entry
    {
        public virtual ICollection<Ingredient> Ingridients { get; set; }

        public decimal Price { get; set; }

        public float PromotionPercent { get; set; }

        public DateTime Created { get; set; }

        public TimeSpan PreparationTime { get; set; }

        public TimeSpan CookTime { get; set; }

        public string CookMethod { get; set; }

        public virtual ICollection<Nutrition> Nutritions { get; set; }
    }
}