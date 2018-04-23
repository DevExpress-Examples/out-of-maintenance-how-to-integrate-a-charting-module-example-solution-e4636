Imports Microsoft.VisualBasic
Imports System
Namespace InventoryChart
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim TextAnnotation1 As DevExpress.XtraCharts.TextAnnotation = New DevExpress.XtraCharts.TextAnnotation()
            Dim ChartAnchorPoint1 As DevExpress.XtraCharts.ChartAnchorPoint = New DevExpress.XtraCharts.ChartAnchorPoint()
            Dim FreePosition1 As DevExpress.XtraCharts.FreePosition = New DevExpress.XtraCharts.FreePosition()
            Dim XyDiagram1 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
            Dim Series1 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
            Dim SideBySideBarSeriesLabel1 As DevExpress.XtraCharts.SideBySideBarSeriesLabel = New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
            Dim Series2 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
            Dim PieSeriesLabel1 As DevExpress.XtraCharts.PieSeriesLabel = New DevExpress.XtraCharts.PieSeriesLabel()
            Dim PiePointOptions1 As DevExpress.XtraCharts.PiePointOptions = New DevExpress.XtraCharts.PiePointOptions()
            Dim PieSeriesView1 As DevExpress.XtraCharts.PieSeriesView = New DevExpress.XtraCharts.PieSeriesView()
            Dim SeriesTitle1 As DevExpress.XtraCharts.SeriesTitle = New DevExpress.XtraCharts.SeriesTitle()
            Dim SideBySideBarSeriesLabel2 As DevExpress.XtraCharts.SideBySideBarSeriesLabel = New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
            Me.inventoryChart = New DevExpress.XtraCharts.ChartControl()
            Me.bOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            CType(Me.inventoryChart, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(TextAnnotation1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(XyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Series1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(SideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Series2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(PieSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(PieSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(SideBySideBarSeriesLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.bOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'inventoryChart
            '
            ChartAnchorPoint1.X = 0
            ChartAnchorPoint1.Y = 43
            TextAnnotation1.AnchorPoint = ChartAnchorPoint1
            TextAnnotation1.BackColor = System.Drawing.Color.SlateBlue
            TextAnnotation1.ConnectorStyle = DevExpress.XtraCharts.AnnotationConnectorStyle.None
            TextAnnotation1.Name = "CategoriesLink"
            FreePosition1.InnerIndents.Left = 0
            FreePosition1.InnerIndents.Top = 0
            TextAnnotation1.ShapePosition = FreePosition1
            TextAnnotation1.Text = "Back to categories..."
            TextAnnotation1.TextColor = System.Drawing.Color.White
            TextAnnotation1.Visible = False
            Me.inventoryChart.AnnotationRepository.AddRange(New DevExpress.XtraCharts.Annotation() {TextAnnotation1})
            Me.inventoryChart.DataSource = Me.bOBindingSource
            XyDiagram1.AxisX.Range.AlwaysShowZeroLevel = True
            XyDiagram1.AxisX.Range.ScrollingRange.SideMarginsEnabled = True
            XyDiagram1.AxisX.Range.SideMarginsEnabled = True
            XyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
            XyDiagram1.AxisY.Range.AlwaysShowZeroLevel = True
            XyDiagram1.AxisY.Range.ScrollingRange.SideMarginsEnabled = True
            XyDiagram1.AxisY.Range.SideMarginsEnabled = True
            XyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
            Me.inventoryChart.Diagram = XyDiagram1
            Me.inventoryChart.Dock = System.Windows.Forms.DockStyle.Fill
            Me.inventoryChart.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Center
            Me.inventoryChart.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.TopOutside
            Me.inventoryChart.Location = New System.Drawing.Point(0, 0)
            Me.inventoryChart.Name = "inventoryChart"
            Series1.ArgumentDataMember = "CategoryItems.CategoryName"
            Series1.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Qualitative
            SideBySideBarSeriesLabel1.LineVisible = True
            Series1.Label = SideBySideBarSeriesLabel1
            Series1.LegendText = "Categories - Units in stock"
            Series1.Name = "CategoryUnits"
            Series1.ValueDataMembersSerializable = "CategoryItems.CategorySum"
            Series2.ArgumentDataMember = "ProductItems.ProductName"
            PieSeriesLabel1.LineVisible = True
            PiePointOptions1.PercentOptions.ValueAsPercent = False
            PiePointOptions1.PointView = DevExpress.XtraCharts.PointView.ArgumentAndValues
            PiePointOptions1.ValueNumericOptions.Format = DevExpress.XtraCharts.NumericFormat.Number
            PiePointOptions1.ValueNumericOptions.Precision = 0
            PieSeriesLabel1.PointOptions = PiePointOptions1
            Series2.Label = PieSeriesLabel1
            Series2.Name = "ProductUnits"
            Series2.ValueDataMembersSerializable = "ProductItems.ProductQty"
            PieSeriesView1.RuntimeExploding = False
            PieSeriesView1.Titles.AddRange(New DevExpress.XtraCharts.SeriesTitle() {SeriesTitle1})
            Series2.View = PieSeriesView1
            Me.inventoryChart.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series1, Series2}
            SideBySideBarSeriesLabel2.LineVisible = True
            Me.inventoryChart.SeriesTemplate.Label = SideBySideBarSeriesLabel2
            Me.inventoryChart.Size = New System.Drawing.Size(686, 441)
            Me.inventoryChart.TabIndex = 0
            '
            'bOBindingSource
            '
            Me.bOBindingSource.DataSource = GetType(InventoryChart.BO)
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(686, 441)
            Me.Controls.Add(Me.inventoryChart)
            Me.Name = "Form1"
            Me.Text = "Inventory Chart"
            CType(TextAnnotation1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(XyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(SideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Series1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(PieSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(PieSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Series2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(SideBySideBarSeriesLabel2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.inventoryChart, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.bOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

		#End Region

		Private WithEvents inventoryChart As DevExpress.XtraCharts.ChartControl
		Private bOBindingSource As System.Windows.Forms.BindingSource
	End Class
End Namespace

