namespace RestaurantManager.Web.Controllers
{
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;
    using RestaurantManager.Services.Interfaces;
    using RestaurantManager.Web.Models;
    using RestaurantManager.Web.Presenters;

    public class MenuItemController : Controller
    {
        private IMenuItemService menuItemService;

        public MenuItemController(IMenuItemService menuItemService)
        {
            this.menuItemService = menuItemService;
        }
        
        public IActionResult Index()
        {
            MenuItemIndexViewModel model = new MenuItemIndexViewModel
                                               {
                                                   ItemPdfViewModel = MenuItemPresenter.GetPdfViewModel(this.menuItemService.GetAll())
                                               };

            model.PostMenuItemModel.MenuItemTypesViewModel =  MenuItemPresenter.MenuItemTypes(this.menuItemService.MenuItemTypes());
            model.PostMenuItemModel.UnitTypesViewModel = MenuItemPresenter.UnitItemTypes(this.menuItemService.UnitItemTypes());

            return this.View(model);
        }
        
        public IActionResult Details(int id)
        {
            MenuItemFullViewModel model = MenuItemPresenter.PresentFullMenuItem(this.menuItemService.GetById(id));
            model.MenuItemTypesViewModel =  MenuItemPresenter.MenuItemTypes(this.menuItemService.MenuItemTypes());
            model.UnitTypesViewModel = MenuItemPresenter.UnitItemTypes(this.menuItemService.UnitItemTypes());

            return this.PartialView("CrudActionView", model);
        }
        
        [HttpPost]
        public IActionResult CreateOrEdit(MenuItemFullViewModel model)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View("Index");
            }

            try
            {
                // TODO: Add insert logic here

                return this.RedirectToAction("Index");
            }
            catch
            {
                return this.View("Index");
            }
        }
        
        public ActionResult Edit(int id)
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return this.RedirectToAction("Index");
            }
            catch
            {
                return this.View();
            }
        }
        
        // GET: MenuItem/Delete/5
        public ActionResult Delete(int id)
        {
            return this.View();
        }

        // POST: MenuItem/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return this.RedirectToAction("Index");
            }
            catch
            {
                return this.View();
            }
        }
    }
}