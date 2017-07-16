namespace RestaurantManager.ViewAndBindingModels.ViewModels
{
    using DataBase;
    using Mapper;
    public class UnitTypesViewModel : IMapFrom<UnitType>
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}