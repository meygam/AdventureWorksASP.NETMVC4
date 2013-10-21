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
    public class ProductSubCategoryController : ApiController
    {
        public IEnumerable<ProductSubcategory> GetProductSubcategory(int productCategoryId)
        {
            ProductSubCategoryService productSubCategoryService = new ProductSubCategoryService();
            return productSubCategoryService.GetProductSubCategory(productCategoryId);
        }
    }
}
