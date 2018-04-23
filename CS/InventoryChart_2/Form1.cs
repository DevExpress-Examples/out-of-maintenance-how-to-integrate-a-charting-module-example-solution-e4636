using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace InventoryChart
{
    public partial class Form1 : Form
    {
        NorthwindEntities db = new NorthwindEntities();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var categorySales = (from c in db.Categories
                                 select new
                                 {
                                     CategoryID = c.Category_ID,
                                     CategoryName = c.Category_Name,
                                     CategorySum = c.Products.Sum(p => p.Units_In_Stock)
                                 }
                     ).ToList();
            this.inventoryChart.Series["CategoryUnits"].DataSource = categorySales;
            this.inventoryChart.Series["CategoryUnits"].ArgumentDataMember = "CategoryName";
            this.inventoryChart.Series["CategoryUnits"].ValueDataMembers.AddRange(new string[] { "CategorySum" });

        }

    }
}
