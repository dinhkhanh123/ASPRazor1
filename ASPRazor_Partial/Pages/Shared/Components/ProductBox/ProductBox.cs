using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace ASPRazor_Partial
{
    // [ViewComponent]
    public class ProductBox : ViewComponent
    {
        /*
        Invoke => string(IViewComponentResult)
        [ViewComponent]
        -dat ten class co hau to ViewComponent
        *Ke thua ViewComponent
        */
        ProductListService productService;
        public ProductBox(ProductListService _products)
        {
            productService = _products;
        }

        public IViewComponentResult Invoke(bool sapxeptang = true)
        {
            //     var products = new List<Product>(){
            // new Product(){Name = "San pham 1",Description = "Mo ta san pham 1",Price = 420},
            // new Product(){Name = "San pham 2",Description = "Mo ta san pham 2",Price = 123},
            // };

            List<Product> _products = null;
            if (sapxeptang)
            {
                _products = productService.products.OrderBy(p => p.Price).ToList();
            }
            else
            {
                _products = productService.products.OrderByDescending(p => p.Price).ToList();
            }
            // return View("Default1"); //default.cshtml
            return View<List<Product>>(_products);
        }
    }
}