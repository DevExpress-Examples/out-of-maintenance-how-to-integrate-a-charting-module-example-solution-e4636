using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

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

        public class CategoryItem
        {
            public int CategoryID { get; set; }
            public string CategoryName { get; set; }
            public int? CategorySum { get; set; }
        }
    }
}
