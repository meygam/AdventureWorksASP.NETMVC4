using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AW.EnityModel;
using AW.Business;

namespace AW.Web.Api.Controllers
{
    public class ProductController : ApiController
    {
        public IEnumerable<Product> GetProducts()
        {
            ProductService productService = new ProductService();
            return productService.GetProducts();
        }

        public IEnumerable<Product> GetProducts(int productSubCategoryID)
        {
            ProductService productService = new ProductService();
            return productService.GetProductsBySubCategory(productSubCategoryID);
        }
    }
}
