using System.Collections.Generic;

namespace ASPRazor_Partial
{
    public class ProductListService
    {
        public List<Product> products { set; get; } = new List<Product>(){
        new Product(){Name = "San pham 1",Description = "Mo ta san pham 1",Price = 123},
        new Product(){Name = "San pham 2",Description = "Mo ta san pham 2",Price = 456},
        new Product(){Name = "San pham 3",Description = "Mo ta san pham 3",Price = 789},
        new Product(){Name = "San pham 4",Description = "Mo ta san pham 4",Price = 542},
        };
    }
}