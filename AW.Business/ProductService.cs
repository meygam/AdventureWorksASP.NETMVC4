using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AW.EnityModel;

namespace AW.Business
{
    public class ProductService
    {
        public IEnumerable<Product> GetProducts()
        {
            var context = new AWEntities();
            var query = from product in context.Products select product;
            return query.ToList();
        }

        public IEnumerable<Product> GetProductsBySubCategory(int productSubCategoryID)
        {
            var context = new AWEntities();
            var query = from product in context.Products
                        where product.ProductSubcategoryID == productSubCategoryID
                        select product;
            return query.ToList();
        }
    }
}
