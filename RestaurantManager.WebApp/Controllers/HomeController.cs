using System.Collections.Generic;
using System.Web.Mvc;
using RestaurantManager.Services.Implementations;
using RestaurantManager.Services.Interfaces;

namespace RestaurantManager.WebApp.Controllers
{
    public class HomeController : Controller
    {
        private IProductService productService;

        public HomeController(IProductService productService)
        {
            this.productService = productService;
        }

        public ActionResult Index()
        {
            var model = this.productService.GetAll();
            return View(model);
        }

        public ActionResult CreateWindow()
        {
            throw new System.NotImplementedException();
        }
    }
}