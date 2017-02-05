namespace Restaurant.Data.Models
{
    using Restourant.Data.Models;

    public class Ingredient : Product
    {
        public int RecipeId { get; set; }

        public virtual Recipe Recipe { get; set; }

        public Ingredient(string name) 
            : base(name)
        {
        }
    }
}