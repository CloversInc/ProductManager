namespace RestaurantManager.ViewAndBindingModels.ViewModels
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using DataBase;
    using Mapper;

    public class MenuItemFullViewModel : IMapFrom<MenuItem>
    {
        public MenuItemFullViewModel()
        {
            IsNew = true;
        }

        public int Id { get; set; }

        [Required(ErrorMessage = "Името е задължително")]
        public string Name { get; set; }

        [Required]
        [Range(1, 100000, ErrorMessage = "Невалидна цена")]
        public decimal Price { get; set; }

        [Range(1, 100000, ErrorMessage = "Невалидно количество")]
        public string UnitTypeAmount { get; set; }

        [Required(ErrorMessage = "Категорията е задължителна")]
        public string MenuItemTypeName { get; set; }

        [Required(ErrorMessage = "Мерната единица е задължителнa")]
        public string UnitTypeName { get; set; }

        public bool IsNew { get; set; }

        public IEnumerable<MenuItemTypeViewModel> MenuItemTypesViewModel { get; set; }

        public IEnumerable<UnitTypesViewModel> UnitTypesViewModel { get; set; }
    }
}