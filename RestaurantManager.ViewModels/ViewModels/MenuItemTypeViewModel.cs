namespace RestaurantManager.ViewAndBindingModels.ViewModels
{
    using DataBase;
    using Mapper;
    public class MenuItemTypeViewModel : IMapFrom<MenuItemType>
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
