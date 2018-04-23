Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraCharts


Namespace InventoryChart
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub


		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			Me.bOBindingSource.DataSource = New BO()
		End Sub

		Private Sub inventoryChart_ObjectSelected(ByVal sender As Object, ByVal e As DevExpress.XtraCharts.HotTrackEventArgs) Handles inventoryChart.ObjectSelected
			If e.HitInfo.InSeries AndAlso TypeOf e.AdditionalObject Is SeriesPoint Then
				Dim currentPoint As SeriesPoint = CType(e.AdditionalObject, SeriesPoint)
				If currentPoint.Tag.GetType() Is GetType(InventoryChart.BO.CategoryItem) Then
					Dim currentCategory As InventoryChart.BO.CategoryItem = CType(currentPoint.Tag, InventoryChart.BO.CategoryItem)
					Dim categoryID As Integer = currentCategory.CategoryID
					Dim currentCategoryFilter As New DataFilter("ProductItems.CategoryID", "System.Int32", DataFilterCondition.Equal, categoryID)
					Me.inventoryChart.Series("ProductUnits").DataFilters.Clear()
					Me.inventoryChart.Series("ProductUnits").DataFilters.Add(currentCategoryFilter)
					Me.inventoryChart.Series("CategoryUnits").Visible = False
					Me.inventoryChart.Series("ProductUnits").Visible = True
					Me.inventoryChart.Legend.AlignmentHorizontal = LegendAlignmentHorizontal.RightOutside
					Me.inventoryChart.Legend.AlignmentVertical = LegendAlignmentVertical.Center
					Me.inventoryChart.Annotations(0).Visible = True
					Dim view As PieSeriesView = CType(Me.inventoryChart.Series("ProductUnits").View, PieSeriesView)
					view.Titles(0).Text = currentCategory.CategoryName
				End If
			ElseIf e.HitInfo.InAnnotation AndAlso TypeOf e.Object Is TextAnnotation Then
				Me.inventoryChart.Annotations(0).Visible = False
				Me.inventoryChart.Series("CategoryUnits").Visible = True
				Me.inventoryChart.Series("ProductUnits").Visible = False
				Me.inventoryChart.Legend.AlignmentHorizontal = LegendAlignmentHorizontal.Center
				Me.inventoryChart.Legend.AlignmentVertical = LegendAlignmentVertical.TopOutside
			End If
		End Sub

		Private Sub inventoryChart_ObjectHotTracked(ByVal sender As Object, ByVal e As HotTrackEventArgs) Handles inventoryChart.ObjectHotTracked
			If e.HitInfo.InAnnotation AndAlso TypeOf e.Object Is TextAnnotation Then
				Cursor.Current = Cursors.Hand
			Else
				Cursor.Current = Cursors.Default
			End If
		End Sub

		Private Sub inventoryChart_CustomDrawCrosshair(ByVal sender As Object, ByVal e As CustomDrawCrosshairEventArgs) Handles inventoryChart.CustomDrawCrosshair

			For Each element As CrosshairElement In e.CrosshairElements
				Dim currentPoint As SeriesPoint = element.SeriesPoint
				If currentPoint.Tag.GetType() Is GetType(InventoryChart.BO.CategoryItem) Then
					Dim currentCategory As InventoryChart.BO.CategoryItem = CType(currentPoint.Tag, InventoryChart.BO.CategoryItem)
					Dim productItems As List(Of InventoryChart.BO.ProductItem) = (CType(Me.bOBindingSource.DataSource, BO)).ProductItems
					Dim mostExpensiveProduct As InventoryChart.BO.ProductItem = TryCast(productItems.Where(Function(p) p.CategoryID = currentCategory.CategoryID).OrderByDescending(Function(p) p.ProductPrice).First(), InventoryChart.BO.ProductItem)
					element.LabelElement.Text += String.Format(Constants.vbLf & "Most expensive product:" & Constants.vbLf & "{0} : {1:c}", mostExpensiveProduct.ProductName, mostExpensiveProduct.ProductPrice)
				End If
			Next element
		End Sub


	End Class
End Namespace
