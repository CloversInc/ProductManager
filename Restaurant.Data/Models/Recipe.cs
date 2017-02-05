namespace Restaurant.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using Enums;

    public class Recipe : Entry
    {
        public virtual ICollection<Ingredient> Ingredients { get; set; }

        [Required]
        public decimal Price { get; set; }

        public float PromotionPercent { get; set; }

        public DateTime Created { get; set; }

        public TimeSpan PreparationTime { get; set; }

        public TimeSpan CookTime { get; set; }

        public string CookMethod { get; set; }

        public ICollection<Nutrition> Nutritions { get; set; }
        
        public Recipe(string name, decimal price, TimeSpan preparationTime, TimeSpan cookTime, string cookMethod)
            : base(name)
        {
            this.Price = price;
            this.Created = DateTime.Now;
            this.PreparationTime = preparationTime;
            this.CookTime = cookTime;
            this.CookMethod = cookMethod;

            this.Ingredients = new List<Ingredient>();
            InitNutritionsTable();
        }

        private void InitNutritionsTable()
        {
            this.Nutritions = new List<Nutrition>
            {
                new Nutrition(NutritionType.Calories, default(float)),
                new Nutrition(NutritionType.Fat, default(float)),
                new Nutrition(NutritionType.Saturates, default(float)),
                new Nutrition(NutritionType.Protein, default(float)),
                new Nutrition(NutritionType.Carbs, default(float)),
                new Nutrition(NutritionType.Sugar, default(float)),
                new Nutrition(NutritionType.Salt, default(float)),
                new Nutrition(NutritionType.Fibre, default(float))
            };
        }
    }
}