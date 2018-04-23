Imports Microsoft.VisualBasic
Imports System.Windows.Forms
Imports System.Data
Imports System
Imports DevExpress.XtraEditors.ViewInfo
Imports DevExpress.LookAndFeel
Imports DevExpress.Utils
Imports DevExpress.Utils.Drawing
Imports System.Drawing
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraGrid
Namespace WindowsApplication1
	Partial Public Class Form1
		Inherits Form
		Private _DefaultPaintHelper As DefaultPaintHelper

		Private Function CreateTable(ByVal RowCount As Integer) As DataTable
			Dim tbl As New DataTable()
			tbl.Columns.Add("Name", GetType(String))
			tbl.Columns.Add("ID", GetType(Integer))
			tbl.Columns.Add("Number", GetType(Integer))
			tbl.Columns.Add("Date", GetType(DateTime))
			For i As Integer = 0 To RowCount - 1
				tbl.Rows.Add(New Object() { String.Format("Name{0}{1}{0}{1}{0}", i, Environment.NewLine), i, 3 - i, DateTime.Now.AddDays(i) })
			Next i
			Return tbl
		End Function


		Public Sub New()
			InitializeComponent()
			AddHandler gridView1.CustomDrawCell, AddressOf gridView1_CustomDrawCell
			gridControl1.DataSource = CreateTable(20)
			gridView1.RowHeight = 40
			gridView1.Columns(0).ColumnEdit = New RepositoryItemMemoEdit()
			_DefaultPaintHelper = New DefaultPaintHelper(gridControl1)
		End Sub

		Private Sub gridView1_CustomDrawCell(ByVal sender As Object, ByVal e As RowCellCustomDrawEventArgs)
			If Not(TypeOf e.Column.ColumnEdit Is RepositoryItemMemoEdit) Then
				Return
			End If
			e.Handled = True
			_DefaultPaintHelper.DefaultDrawContent(e)
			MyScrollBarPaintHelper.DrawScrollBar(e.Cache, e.Bounds)
		End Sub


	End Class
End Namespace