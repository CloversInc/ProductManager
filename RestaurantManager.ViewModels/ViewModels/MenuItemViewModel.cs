namespace RestaurantManager.ViewAndBindingModels.ViewModels
{
    using DataBase;
    using Mapper;

    public class MenuItemViewModel : IMapFrom<MenuItem>
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string UnitTypeAmount { get; set; }

        public string MenuItemTypeName { get; set; }

        public string UnitTypeName { get; set; }

        public decimal Price { get; set; }
    }
}