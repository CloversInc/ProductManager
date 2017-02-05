namespace Restaurant.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using Enums;

    public class Nutrition : Entry
    {
        public NutritionType Type { get; set; }

        [Range(0, 100)]
        public float Amount { get; set; }

        [Range(0, 100)]
        public byte Percent { get; set; }

        public int? RecipeId { get; set; }

        public virtual Recipe Recipe { get; set; }

        public Nutrition(NutritionType type, float amount, byte percent = default(byte))
            : base(type.ToString())
        {
            this.Type = type;
            this.Amount = amount;
            this.Percent = percent;
        }
    }
}