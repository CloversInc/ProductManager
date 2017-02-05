namespace Restourant.Data.Models
{
    public class Drink : Product
    {
        public float? Promille { get; set; }

        public bool isCarbonated { get; set; }

        public Drink(string name) 
            : base(name)
        {
        }
    }
}
