using System.Web.Mvc;

namespace RestaurantManager.WebApp.Controllers
{
    using ViewAndBindingModels.ViewModels;
    using Services.Interfaces;

    public class MenuItemController : Controller
    {
        private IMenuService menuItemService;

        public MenuItemController(IMenuService menuItemService)
        {
            this.menuItemService = menuItemService;
        }
        
        // GET: MenuItem
        public ActionResult Index()
        {
            MenuItemIndexViewModel model = new MenuItemIndexViewModel
            {
                ItemPdfViewModel = this.menuItemService.GetPdfViewModel()
            };

            model.PostMenuItemModel.MenuItemTypesViewModel = this.menuItemService.MenuItemTypes();
            model.PostMenuItemModel.UnitTypesViewModel = this.menuItemService.UnitItemTypes();

            return this.View(model);
        }

        // GET: MenuItem/Details/5
        public ActionResult Details(int id)
        {
            MenuItemFullViewModel model = this.menuItemService.GetById(id);
            model.MenuItemTypesViewModel = this.menuItemService.MenuItemTypes();
            model.UnitTypesViewModel = this.menuItemService.UnitItemTypes();

            return this.PartialView("_CrudActionView", model);
        }

        [HttpPost]
        public ActionResult Create(MenuItemFullViewModel model)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View("CrudActionView", model);
            }

            // TODO: Add insert logic here

            return View("Index");

        }

        [HttpPost]
        public ActionResult Edit(MenuItemFullViewModel model)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        [HttpPost]
        public ActionResult Delete(MenuItemFullViewModel model)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
