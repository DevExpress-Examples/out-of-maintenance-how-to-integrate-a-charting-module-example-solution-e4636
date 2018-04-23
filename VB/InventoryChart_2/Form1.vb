Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms

Namespace InventoryChart
	Partial Public Class Form1
		Inherits Form
		Private db As New NorthwindEntities()

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			Dim categorySales = (From c In db.Categories _
			                     Select New With {Key .CategoryID = c.Category_ID, Key .CategoryName = c.Category_Name, Key .CategorySum = c.Products.Sum(Function(p) p.Units_In_Stock)}).ToList()
			Me.inventoryChart.Series("CategoryUnits").DataSource = categorySales
			Me.inventoryChart.Series("CategoryUnits").ArgumentDataMember = "CategoryName"
			Me.inventoryChart.Series("CategoryUnits").ValueDataMembers.AddRange(New String() { "CategorySum" })

		End Sub

	End Class
End Namespace
