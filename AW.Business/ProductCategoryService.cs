using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AW.EnityModel;

namespace AW.Business
{
    public class ProductCategoryService
    {
        public IEnumerable<ProductCategory> GetProductCategory()
        {
            var context = new AWEntities();
            var query = from productCategories in context.ProductCategories select productCategories;
            return query.ToList();
        }
    }
}
