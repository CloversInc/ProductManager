namespace ProductManager.Web.Controllers
{
    using System.Collections.Generic;
    using System.Web.Mvc;
    using ProductManager.ViewModels;
    using Services.Interfaces;

    public class HomeController : Controller
    {
        private IProductService productService;

        public HomeController(IProductService productService)
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