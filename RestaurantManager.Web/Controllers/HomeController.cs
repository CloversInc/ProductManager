namespace RestaurantManager.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using RestaurantManager.Web.Models;
    using RestaurantManager.Services.Interfaces;
    using RestaurantManager.Web.Presenters;

    public class HomeController : Controller
    {
        private readonly IProductService productService;

        public HomeController(IProductService productService)
        {
            this.productService = productService;
        }
        
        public IActionResult Index()
        {
            return this.View();
        }
        
        public IActionResult Products()
        {
            var products = this.productService.GetAll();
            var viewProducts = ProductPresenter.PresentProducts(products);
//            return new JsonResult(viewProducts);
            return this.View(viewProducts);
        }

        public IActionResult About()
        {
            this.ViewData["Message"] = "Your application description page.";

            return this.View();

        }

        public IActionResult Contact()
        {
            this.ViewData["Message"] = "Your contact page.";

            return this.View();
        }

        public IActionResult Error()
        {
            return this.View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? this.HttpContext.TraceIdentifier });
        }
    }
}