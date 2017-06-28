namespace RestaurantManager.WebApp.Controllers
{
    using System.Web.Mvc;
    using Services.Interfaces;

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