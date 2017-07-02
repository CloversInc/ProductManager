namespace RestaurantManager.BindingViewModels.ViewModels
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using DataBase;
    using Mapper;

    public class MenuItemFullViewModel : IMapFrom<MenuItem>
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Името е задължително")]
        public string Name { get; set; }

        [Required]
        [Range(1, 1000,ErrorMessage = "Цената трябва да е над 0")]
        public decimal Price { get; set; }

        [Range(1, 1000, ErrorMessage = "Количеството трябва да е над 0")]
        public string UnitTypeAmount { get; set; }

        [Required(ErrorMessage = "Категорията е задължителна")]
        public string MenuItemTypeName { get; set; }

        public IEnumerable<MenuItemTypeViewModel> MenuItemTypesViewModel { get; set; }

        [Required(ErrorMessage = "Мерната единица е задължително")]
        public string UnitTypeName { get; set; }

        public IEnumerable<UnitTypesViewModel> UnitTypesViewModel { get; set; }
    }
}