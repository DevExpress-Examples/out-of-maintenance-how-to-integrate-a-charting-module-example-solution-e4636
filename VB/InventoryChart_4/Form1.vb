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
				End If
			End If

		End Sub

	End Class
End Namespace
