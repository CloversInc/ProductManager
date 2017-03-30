using System.Web.Mvc;

namespace ProductManager.Web.Controllers
{
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
            this.productService.GetAll();
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