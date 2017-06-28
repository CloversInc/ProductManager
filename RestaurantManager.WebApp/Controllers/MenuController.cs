using System.Collections.Generic;
using System.Web.Mvc;
using RestaurantManager.Services.Interfaces;
using RestaurantManager.ViewModels;

namespace RestaurantManager.WebApp.Controllers
{
    public class MenuController : Controller
    {
        private IMenuItemService menuItemService;

        public MenuController(IMenuItemService menuItemService)
        {
            this.menuItemService = menuItemService;
        }

        public ActionResult MenuLunch()
        {
            var model = this.menuItemService.GetPdfViewModel();

            return this.View(model);
        }
    }
}