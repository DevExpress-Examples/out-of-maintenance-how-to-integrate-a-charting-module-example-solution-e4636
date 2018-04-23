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
                    this.inventoryChart.Annotations[0].Visible = true;
                    PieSeriesView view = (PieSeriesView)this.inventoryChart.Series["ProductUnits"].View;
                    view.Titles[0].Text = currentCategory.CategoryName;
                }
            }
            else if (e.HitInfo.InAnnotation && e.Object is TextAnnotation)
            {
                this.inventoryChart.Annotations[0].Visible = false;
                this.inventoryChart.Series["CategoryUnits"].Visible = true;
                this.inventoryChart.Series["ProductUnits"].Visible = false;
                this.inventoryChart.Legend.AlignmentHorizontal = LegendAlignmentHorizontal.Center;
                this.inventoryChart.Legend.AlignmentVertical = LegendAlignmentVertical.TopOutside;
            }
        }

        private void inventoryChart_ObjectHotTracked(object sender, HotTrackEventArgs e)
        {
            if (e.HitInfo.InAnnotation && e.Object is TextAnnotation)
                Cursor.Current = Cursors.Hand;
            else Cursor.Current = Cursors.Default;
        }

        private void inventoryChart_CustomDrawCrosshair(object sender, CustomDrawCrosshairEventArgs e)
        {

            foreach (CrosshairElement element in e.CrosshairElements)
            {
                SeriesPoint currentPoint = element.SeriesPoint;
                if (currentPoint.Tag.GetType() == typeof(InventoryChart.BO.CategoryItem))
                {
                    InventoryChart.BO.CategoryItem currentCategory = (InventoryChart.BO.CategoryItem)currentPoint.Tag;
                    List<InventoryChart.BO.ProductItem> productItems = ((BO)this.bOBindingSource.DataSource).ProductItems;
                    InventoryChart.BO.ProductItem mostExpensiveProduct = productItems.Where(p => p.CategoryID == currentCategory.CategoryID).OrderByDescending(p => p.ProductPrice).First() as InventoryChart.BO.ProductItem;
                    element.LabelElement.Text += string.Format("\nMost expensive product:\n{0} : {1:c}",
                                                            mostExpensiveProduct.ProductName,
                                                            mostExpensiveProduct.ProductPrice);
                }
            }
        }


    }
}
