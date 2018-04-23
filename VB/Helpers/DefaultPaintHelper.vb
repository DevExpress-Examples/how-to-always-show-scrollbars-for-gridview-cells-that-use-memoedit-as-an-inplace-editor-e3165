Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Utils.Drawing
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraGrid

Namespace WindowsApplication1
	Public Class DefaultPaintHelper
		Private _ContainerHelper As GridEditorContainerHelper
		Public Sub New(ByVal gc As GridControl)
			_ContainerHelper = New GridEditorContainerHelper(gc)
		End Sub
		Public Sub DefaultDrawContent(ByVal e As RowCellCustomDrawEventArgs)
			Dim cellInfo As GridCellInfo = TryCast(e.Cell, GridCellInfo)
			_ContainerHelper.DrawCellEdit(New GraphicsInfoArgs(e.Cache, e.Bounds), cellInfo.Editor, cellInfo.ViewInfo, e.Appearance, cellInfo.CellValueRect.Location)
		End Sub
	End Class
End Namespace
