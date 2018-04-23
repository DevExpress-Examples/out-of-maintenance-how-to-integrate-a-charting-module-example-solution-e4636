Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Collections

Namespace InventoryChart
    Public Class BO
        Private db As New NorthwindEntities()

        Private m_categoryItems As List(Of CategoryItem)
        Public Property CategoryItems() As List(Of CategoryItem)
            Get
                If m_categoryItems Is Nothing Then
                    CategoryItems = ( _
                      From c In db.Categories _
                      Select New CategoryItem() With {.CategoryID = c.Category_ID,
                                                      .CategoryName = c.Category_Name,
                                                      .CategorySum = c.Products.Sum(Function(p) p.Units_In_Stock)}).ToList()
                End If
                Return m_categoryItems
            End Get
            Set(value As List(Of CategoryItem))
                m_categoryItems = value
            End Set
        End Property

        Public Class CategoryItem
            Public Property CategoryID() As Integer
                Get
                    Return m_CategoryID
                End Get
                Set(value As Integer)
                    m_CategoryID = value
                End Set
            End Property
            Private m_CategoryID As Integer
            Public Property CategoryName() As String
                Get
                    Return m_CategoryName
                End Get
                Set(value As String)
                    m_CategoryName = value
                End Set
            End Property
            Private m_CategoryName As String
            Public Property CategorySum() As System.Nullable(Of Integer)
                Get
                    Return m_CategorySum
                End Get
                Set(value As System.Nullable(Of Integer))
                    m_CategorySum = value
                End Set
            End Property
            Private m_CategorySum As System.Nullable(Of Integer)
        End Class
    End Class
End Namespace