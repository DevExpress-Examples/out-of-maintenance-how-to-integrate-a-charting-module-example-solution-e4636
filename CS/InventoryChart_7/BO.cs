using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InventoryChart
{
    public class BO
    {
        NorthwindEntities db = new NorthwindEntities();

        private List<CategoryItem> categoryItems;
        public List<CategoryItem> CategoryItems
        {
            get
            {
                if (categoryItems == null)
                {
                    categoryItems = (from c in db.Categories
                                     select new CategoryItem()
                                     {
                                         CategoryID = c.Category_ID,
                                         CategoryName = c.Category_Name,
                                         CategorySum = c.Products.Sum(p => p.Units_In_Stock)
                                     }
                        ).ToList<CategoryItem>();
                }
                return categoryItems;
            }

            set
            {
                categoryItems = value;
            }
        }

        private List<ProductItem> productItems;
        public List<ProductItem> ProductItems
        {
            get
            {
                if (productItems == null)
                {
                    productItems = (from p in db.Products
                                     select new ProductItem()
                                     {
                                         ProductID = p.Product_ID,
                                         CategoryID = p.Category_ID,
                                         ProductName = p.Product_Name,
                                         ProductQty = p.Units_In_Stock,
                                         ProductPrice = p.Unit_Price
                                     }
                        ).ToList<ProductItem>();
                }
                return productItems;
            }

            set
            {
                productItems = value;
            }
        }

        public class CategoryItem
        {
            public int CategoryID { get; set; }
            public string CategoryName { get; set; }
            public int? CategorySum { get; set; }
        }

        public class ProductItem
        {
            public int ProductID { get; set; }
            public int? CategoryID { get; set; }
            public string ProductName { get; set; }
            public int? ProductQty { get; set; }
            public decimal? ProductPrice { get; set; }
        }
    }
}
