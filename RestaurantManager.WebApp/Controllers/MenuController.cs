namespace RestaurantManager.WebApp.Controllers
{
    using System.Web.Mvc;
    using Services.Interfaces;
    using RestaurantManager.ViewAndBindingModels.ViewModels;
    using System.Collections.Generic;

    public class MenuController : Controller
    {
        private IMenuService menuService;

        public MenuController(IMenuService menuService)
        {
            this.menuService = menuService;
        }

        [HttpGet]
        public ActionResult MenuLunch()
        {
            var model = this.menuService.GetPdfViewModel();

            return this.View(model);
        }

        [HttpPost]
        public ActionResult GenerateMenuLunchPdf(SortedDictionary<int, ICollection<MenuItemViewModel>> models)
        {
             var model = new MenuItemPdfViewModel
            {
                MenuItemViewModels = models
            };

            var pdf = this.menuService.CreatePdf(model);
            var pdfByteArr = pdf.BuildPdf(this.ControllerContext);

            //this.Response.ClearContent();
            //this.Response.ContentType = "application/pdf";
            //this.Response.AddHeader("Content-Disposition", "inline");
            //this.Response.AddHeader("Content-Length", pdfByteArr.Length.ToString());
            //this.Response.BinaryWrite(pdfByteArr);
            //this.Response.End();

            return this.File(pdfByteArr, "application/pdf");
        }
    }
}