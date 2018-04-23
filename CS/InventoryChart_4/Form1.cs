using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraCharts;


namespace InventoryChart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
            this.bOBindingSource.DataSource = new BO();
        }

        private void inventoryChart_ObjectSelected(object sender, DevExpress.XtraCharts.HotTrackEventArgs e)
        {
            if (e.HitInfo.InSeries && e.AdditionalObject is SeriesPoint)
            {
                SeriesPoint currentPoint = (SeriesPoint)e.AdditionalObject;
                if (currentPoint.Tag.GetType() == typeof(InventoryChart.BO.CategoryItem))
                {
                    InventoryChart.BO.CategoryItem currentCategory = (InventoryChart.BO.CategoryItem)currentPoint.Tag;
                    int categoryID = currentCategory.CategoryID;
                    DataFilter currentCategoryFilter = new DataFilter("ProductItems.CategoryID", "System.Int32", DataFilterCondition.Equal, categoryID);
                    this.inventoryChart.Series["ProductUnits"].DataFilters.Clear();
                    this.inventoryChart.Series["ProductUnits"].DataFilters.Add(currentCategoryFilter);
                    this.inventoryChart.Series["CategoryUnits"].Visible = false;
                    this.inventoryChart.Series["ProductUnits"].Visible = true;
                    this.inventoryChart.Legend.AlignmentHorizontal = LegendAlignmentHorizontal.RightOutside;
                    this.inventoryChart.Legend.AlignmentVertical = LegendAlignmentVertical.Center;
                }
            }

        }

    }
}
