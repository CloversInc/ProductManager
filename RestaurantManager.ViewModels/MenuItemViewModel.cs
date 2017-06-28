using RestaurantManager.DataBase;

namespace RestaurantManager.ViewModels
{
    public class MenuItemViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string UnitTypeAmount { get; set; }

        public virtual UnitType UnitType { get; set; }
    }
}
