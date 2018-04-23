Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text

Namespace InventoryChart
	Public Class BO
		Private db As New NorthwindEntities()

        Private m_categoryItems As List(Of CategoryItem)
        Public Property CategoryItems() As List(Of CategoryItem)
            Get
                If m_categoryItems Is Nothing Then
                    CategoryItems = ( _
                      From c In db.Categories _
                      Select New CategoryItem() With {.CategoryID = c.Category_ID, .CategoryName = c.Category_Name, .CategorySum = c.Products.Sum(Function(p) p.Units_In_Stock)}).ToList()
                End If
                Return m_categoryItems
            End Get
            Set(value As List(Of CategoryItem))
                m_categoryItems = value
            End Set
        End Property

		 Private m_productItems As List(Of ProductItem)
        Public Property ProductItems() As List(Of ProductItem)
            Get
                If m_productItems Is Nothing Then
                    m_productItems = (From p In db.Products _
                                            Select New ProductItem() With {.ProductID = p.Product_ID,
                                                                            .ProductName = p.Product_Name,
                                                                           .ProductQty = p.Units_In_Stock,
                                                                           .CategoryID = p.Category_ID}).ToList()
                End If
                Return m_productItems
            End Get

            Set(ByVal value As List(Of ProductItem))
                m_productItems = value
            End Set
        End Property

		Public Class CategoryItem
			Private privateCategoryID As Integer
			Public Property CategoryID() As Integer
				Get
					Return privateCategoryID
				End Get
				Set(ByVal value As Integer)
					privateCategoryID = value
				End Set
			End Property
			Private privateCategoryName As String
			Public Property CategoryName() As String
				Get
					Return privateCategoryName
				End Get
				Set(ByVal value As String)
					privateCategoryName = value
				End Set
			End Property
			Private privateCategorySum As Nullable(Of Integer)
			Public Property CategorySum() As Nullable(Of Integer)
				Get
					Return privateCategorySum
				End Get
				Set(ByVal value As Nullable(Of Integer))
					privateCategorySum = value
				End Set
			End Property
		End Class

		Public Class ProductItem
			Private privateProductID As Integer
			Public Property ProductID() As Integer
				Get
					Return privateProductID
				End Get
				Set(ByVal value As Integer)
					privateProductID = value
				End Set
			End Property
			Private privateCategoryID As Nullable(Of Integer)
			Public Property CategoryID() As Nullable(Of Integer)
				Get
					Return privateCategoryID
				End Get
				Set(ByVal value As Nullable(Of Integer))
					privateCategoryID = value
				End Set
			End Property
			Private privateProductName As String
			Public Property ProductName() As String
				Get
					Return privateProductName
				End Get
				Set(ByVal value As String)
					privateProductName = value
				End Set
			End Property
			Private privateProductQty As Nullable(Of Integer)
			Public Property ProductQty() As Nullable(Of Integer)
				Get
					Return privateProductQty
				End Get
				Set(ByVal value As Nullable(Of Integer))
					privateProductQty = value
				End Set
			End Property
			Private privateProductPrice As Nullable(Of Decimal)
			Public Property ProductPrice() As Nullable(Of Decimal)
				Get
					Return privateProductPrice
				End Get
				Set(ByVal value As Nullable(Of Decimal))
					privateProductPrice = value
				End Set
			End Property
		End Class
	End Class
End Namespace
