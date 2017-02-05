namespace Restaurant.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    public abstract class Entry
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        protected Entry()
        {
        }

        protected Entry(string name)
        {
            this.Name = name;
        }
    }
}