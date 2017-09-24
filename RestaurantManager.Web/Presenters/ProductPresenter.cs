namespace RestaurantManager.Web.Presenters
{
    using System.Collections.Generic;
    using System.Linq;

    using RestaurantManager.DataLayer.Models;
    using RestaurantManager.Web.Models;

    public class ProductPresenter
    {
        public static IEnumerable<ProductViewModel> PresentProducts(IEnumerable<Product> rawProducts)
        {
            return rawProducts.
                Select(rawProduct => new ProductViewModel
                                         {
                                             Id = rawProduct.Id, 
                                             Description = rawProduct.Description, 
                                             Name = rawProduct.Name, 
                                             Price = rawProduct.Price,
                                         })
                .ToList();
        }
    }
}