namespace RestaurantManager.BindingViewModels
{
    using DataBase;
    using Mapper;

    public class ProductViewModel : IMapFrom<Product>
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public string Description { get; set; }
    }
}
