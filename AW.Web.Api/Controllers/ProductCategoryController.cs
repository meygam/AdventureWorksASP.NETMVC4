using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AW.Business;
using AW.EnityModel;

namespace AW.Web.Api.Controllers
{
    public class ProductCategoryController : ApiController
    {
        public IEnumerable<ProductCategory> GetProductCategory()
        {
            
            ProductCategoryService productCategoryService = new ProductCategoryService();
            return productCategoryService.GetProductCategory();
        }
    }
}
