Imports Microsoft.VisualBasic
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.ViewInfo
Imports System
Imports System.Drawing

Namespace WindowsApplication1
	Public Class MyScrollBarViewInfo
		Inherits ScrollBarViewInfo
		Private _ScrollBarOffset As Point
		Public Property ScrollBarOffset() As Point
			Get
				Return _ScrollBarOffset
			End Get
			Set(ByVal value As Point)
				_ScrollBarOffset = value
			End Set
		End Property
		Public Sub New(ByVal scrollBar As IScrollBar)
			MyBase.New(scrollBar)
		End Sub
		Protected Overrides ReadOnly Property CalcThumbButtonBounds() As Rectangle
			Get
				Dim bounds As Rectangle = MyBase.CalcThumbButtonBounds
				bounds.Offset(ScrollBarOffset)
				Return bounds
			End Get
		End Property
		Public Overrides ReadOnly Property VisibleDecButtonBounds() As Rectangle
			Get
				Dim rect As Rectangle = MyBase.VisibleDecButtonBounds
				rect.Offset(ScrollBarOffset)
				Return rect
			End Get
		End Property
		Public Overrides ReadOnly Property VisibleIncButtonBounds() As Rectangle
			Get
				Dim rect As Rectangle = MyBase.VisibleIncButtonBounds
				rect.Offset(ScrollBarOffset)
				Return rect
			End Get
		End Property
	End Class
End Namespace
