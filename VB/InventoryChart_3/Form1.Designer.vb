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
            Dim XyDiagram1 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
            Dim Series1 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
            Dim SideBySideBarSeriesLabel1 As DevExpress.XtraCharts.SideBySideBarSeriesLabel = New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
            Dim Series2 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
            Dim SideBySideBarSeriesLabel2 As DevExpress.XtraCharts.SideBySideBarSeriesLabel = New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
            Dim SideBySideBarSeriesLabel3 As DevExpress.XtraCharts.SideBySideBarSeriesLabel = New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
            Me.inventoryChart = New DevExpress.XtraCharts.ChartControl()
            Me.bOBindingSource = New System.Windows.Forms.BindingSource()
            CType(Me.inventoryChart, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(XyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Series1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(SideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Series2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(SideBySideBarSeriesLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(SideBySideBarSeriesLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.bOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'inventoryChart
            '
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
            SideBySideBarSeriesLabel1.LineVisible = True
            Series1.Label = SideBySideBarSeriesLabel1
            Series1.LegendText = "Categories - Units in stock"
            Series1.Name = "CategoryUnits"
            SideBySideBarSeriesLabel2.LineVisible = True
            Series2.Label = SideBySideBarSeriesLabel2
            Series2.Name = "Series 2"
            Series2.Visible = False
            Me.inventoryChart.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series1, Series2}
            SideBySideBarSeriesLabel3.LineVisible = True
            Me.inventoryChart.SeriesTemplate.Label = SideBySideBarSeriesLabel3
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
            CType(XyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(SideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Series1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(SideBySideBarSeriesLabel2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Series2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(SideBySideBarSeriesLabel3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.inventoryChart, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.bOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

		#End Region

		Private inventoryChart As DevExpress.XtraCharts.ChartControl
		Private bOBindingSource As System.Windows.Forms.BindingSource
	End Class
End Namespace

