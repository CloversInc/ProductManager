using System.Collections.Generic;
using System.Web.Mvc;
using RestaurantManager.Services.Implementations;
using RestaurantManager.ViewModels;

namespace RestaurantManager.WebApp.Controllers
{
    public class HomeController : Controller
    {
        private ProductService productService;

        public HomeController(ProductService productService)
        {
            this.productService = productService;
        }


        public ActionResult Index()
        {
            IEnumerable<ProductViewModel> models = this.productService.GetAll();

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}