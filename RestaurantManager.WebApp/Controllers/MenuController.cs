using System.Collections.Generic;
using System.Web.Mvc;
using RestaurantManager.Services.Interfaces;
using RestaurantManager.ViewModels;

namespace RestaurantManager.WebApp.Controllers
{
    public class MenuController : Controller
    {
        private IRecipeService recipeService;

        public MenuController(IRecipeService recipeService)
        {
            this.recipeService = recipeService;
        }

        public ActionResult LunchMenu()
        {
            IEnumerable<MenuItemViewModel> model = this.recipeService.GetAll();
            return this.View(model);
        }
    }
}