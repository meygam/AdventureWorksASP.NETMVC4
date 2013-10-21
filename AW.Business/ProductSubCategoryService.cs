using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AW.EnityModel;

namespace AW.Business
{
    public class ProductSubCategoryService
    {
        public IEnumerable<ProductSubcategory> GetProductSubCategory(int productCategoryId)
        {
            var context = new AWEntities();
            var query = from productSubCategories in context.ProductSubcategories where productSubCategories.ProductCategoryID == productCategoryId
                        select productSubCategories;
            return query.ToList();
        }
    }
}
