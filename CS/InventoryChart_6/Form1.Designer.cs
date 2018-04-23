namespace InventoryChart
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraCharts.TextAnnotation textAnnotation1 = new DevExpress.XtraCharts.TextAnnotation();
            DevExpress.XtraCharts.ChartAnchorPoint chartAnchorPoint1 = new DevExpress.XtraCharts.ChartAnchorPoint();
            DevExpress.XtraCharts.FreePosition freePosition1 = new DevExpress.XtraCharts.FreePosition();
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.SideBySideBarSeriesLabel sideBySideBarSeriesLabel1 = new DevExpress.XtraCharts.SideBySideBarSeriesLabel();
            DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.PieSeriesLabel pieSeriesLabel1 = new DevExpress.XtraCharts.PieSeriesLabel();
            DevExpress.XtraCharts.PiePointOptions piePointOptions1 = new DevExpress.XtraCharts.PiePointOptions();
            DevExpress.XtraCharts.PieSeriesView pieSeriesView1 = new DevExpress.XtraCharts.PieSeriesView();
            DevExpress.XtraCharts.SeriesTitle seriesTitle1 = new DevExpress.XtraCharts.SeriesTitle();
            DevExpress.XtraCharts.SideBySideBarSeriesLabel sideBySideBarSeriesLabel2 = new DevExpress.XtraCharts.SideBySideBarSeriesLabel();
            this.inventoryChart = new DevExpress.XtraCharts.ChartControl();
            this.bOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.inventoryChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(textAnnotation1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // inventoryChart
            // 
            chartAnchorPoint1.X = 0;
            chartAnchorPoint1.Y = 43;
            textAnnotation1.AnchorPoint = chartAnchorPoint1;
            textAnnotation1.BackColor = System.Drawing.Color.SlateBlue;
            textAnnotation1.ConnectorStyle = DevExpress.XtraCharts.AnnotationConnectorStyle.None;
            textAnnotation1.Name = "CategoriesLink";
            freePosition1.InnerIndents.Left = 0;
            freePosition1.InnerIndents.Top = 0;
            textAnnotation1.ShapePosition = freePosition1;
            textAnnotation1.Text = "Back to categories...";
            textAnnotation1.TextColor = System.Drawing.Color.White;
            textAnnotation1.Visible = false;
            this.inventoryChart.AnnotationRepository.AddRange(new DevExpress.XtraCharts.Annotation[] {
            textAnnotation1});
            this.inventoryChart.DataSource = this.bOBindingSource;
            xyDiagram1.AxisX.Range.AlwaysShowZeroLevel = true;
            xyDiagram1.AxisX.Range.ScrollingRange.SideMarginsEnabled = true;
            xyDiagram1.AxisX.Range.SideMarginsEnabled = true;
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.Range.AlwaysShowZeroLevel = true;
            xyDiagram1.AxisY.Range.ScrollingRange.SideMarginsEnabled = true;
            xyDiagram1.AxisY.Range.SideMarginsEnabled = true;
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.inventoryChart.Diagram = xyDiagram1;
            this.inventoryChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inventoryChart.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Center;
            this.inventoryChart.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.TopOutside;
            this.inventoryChart.Location = new System.Drawing.Point(0, 0);
            this.inventoryChart.Name = "inventoryChart";
            series1.ArgumentDataMember = "CategoryItems.CategoryName";
            sideBySideBarSeriesLabel1.LineVisible = true;
            series1.Label = sideBySideBarSeriesLabel1;
            series1.LegendText = "Categories - Units in stock";
            series1.Name = "CategoryUnits";
            series1.ValueDataMembersSerializable = "CategoryItems.CategorySum";
            series2.ArgumentDataMember = "ProductItems.ProductName";
            pieSeriesLabel1.LineVisible = true;
            piePointOptions1.PercentOptions.ValueAsPercent = false;
            piePointOptions1.PointView = DevExpress.XtraCharts.PointView.ArgumentAndValues;
            piePointOptions1.ValueNumericOptions.Format = DevExpress.XtraCharts.NumericFormat.Number;
            piePointOptions1.ValueNumericOptions.Precision = 0;
            pieSeriesLabel1.PointOptions = piePointOptions1;
            series2.Label = pieSeriesLabel1;
            series2.Name = "ProductUnits";
            series2.ToolTipEnabled = DevExpress.Utils.DefaultBoolean.True;
            series2.ToolTipPointPattern = "{A} - {V} units ({VP:P2} of total)";
            series2.ValueDataMembersSerializable = "ProductItems.ProductQty";
            pieSeriesView1.RuntimeExploding = false;
            pieSeriesView1.Titles.AddRange(new DevExpress.XtraCharts.SeriesTitle[] {
            seriesTitle1});
            series2.View = pieSeriesView1;
            series2.Visible = false;
            this.inventoryChart.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1,
        series2};
            sideBySideBarSeriesLabel2.LineVisible = true;
            this.inventoryChart.SeriesTemplate.Label = sideBySideBarSeriesLabel2;
            this.inventoryChart.Size = new System.Drawing.Size(686, 441);
            this.inventoryChart.TabIndex = 0;
            this.inventoryChart.ObjectSelected += new DevExpress.XtraCharts.HotTrackEventHandler(this.inventoryChart_ObjectSelected);
            this.inventoryChart.ObjectHotTracked += new DevExpress.XtraCharts.HotTrackEventHandler(this.inventoryChart_ObjectHotTracked);
            this.inventoryChart.CustomDrawCrosshair += new DevExpress.XtraCharts.CustomDrawCrosshairEventHandler(this.inventoryChart_CustomDrawCrosshair);
            // 
            // bOBindingSource
            // 
            this.bOBindingSource.DataSource = typeof(InventoryChart.BO);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 441);
            this.Controls.Add(this.inventoryChart);
            this.Name = "Form1";
            this.Text = "Inventory Chart";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(textAnnotation1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraCharts.ChartControl inventoryChart;
        private System.Windows.Forms.BindingSource bOBindingSource;
    }
}

