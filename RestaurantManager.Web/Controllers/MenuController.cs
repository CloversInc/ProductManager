
namespace RestaurantManager.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    using RestaurantManager.Services.Interfaces;
    using RestaurantManager.Web.Presenters;

    public class MenuController : Controller
    {
        private IMenuItemService menuItemService;

        public MenuController(IMenuItemService menuItemService)
        {
            this.menuItemService = menuItemService;
        }

        public IActionResult MenuLunch()
        {
            var model = MenuItemPresenter.GetPdfViewModel(this.menuItemService.GetAll());
            return this.View(model);
        }
    }
}