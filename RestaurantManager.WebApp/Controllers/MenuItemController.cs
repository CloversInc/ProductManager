using System.Web.Mvc;

namespace RestaurantManager.WebApp.Controllers
{
    using BindingViewModels.ViewModels;
    using Services.Interfaces;

    public class MenuItemController : Controller
    {
        private IMenuItemService menuItemService;

        public MenuItemController(IMenuItemService menuItemService)
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

            return this.PartialView("CrudActionView", model);
        }

        // POST: MenuItem/Create
        [HttpPost]
        public ActionResult CreateOrEdit(MenuItemFullViewModel model)
        {
            if (!this.ModelState.IsValid)
            {
                return View("Index");
            }

            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View("Index");
            }
        }

        // GET: MenuItem/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MenuItem/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
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

        // GET: MenuItem/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MenuItem/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
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
