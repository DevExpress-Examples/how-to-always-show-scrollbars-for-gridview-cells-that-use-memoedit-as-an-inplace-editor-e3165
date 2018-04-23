Imports Microsoft.VisualBasic
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.ViewInfo
Imports DevExpress.LookAndFeel
Imports DevExpress.Utils.Drawing
Imports DevExpress.Utils
Imports System
Imports System.Drawing
Namespace WindowsApplication1
	Public NotInheritable Class MyScrollBarPaintHelper
		Private Shared _ScrollBar As VScrollBar = New MyScrollBar()
		Private Shared _Painter As ScrollBarPainterBase
	   Private Sub New()
	   End Sub
	   Shared Sub New()
			CreatePainter()
			AddHandler UserLookAndFeel.Default.StyleChanged, AddressOf Default_StyleChanged
	   End Sub
		Private Shared Sub Default_StyleChanged(ByVal sender As Object, ByVal e As EventArgs)
			CreatePainter()
		End Sub
		Private Shared Sub CreatePainter()
			_Painter = LookAndFeelScrollBarPainter.GetPainter(UserLookAndFeel.Default)
		End Sub
		Public Shared Sub DrawScrollBar(ByVal cache As GraphicsCache, ByVal bounds As Rectangle)
			bounds.X = bounds.Right - _ScrollBar.Width - 1
			bounds.Width = _ScrollBar.Width
			_ScrollBar.Height = bounds.Height
			Dim args As New ScrollBarInfoArgs(cache, bounds, AppearanceObject.ControlAppearance, AppearanceObject.ControlAppearance, _ScrollBar)
			TryCast(args.ViewInfo, MyScrollBarViewInfo).Reset()
			TryCast(args.ViewInfo, MyScrollBarViewInfo).ScrollBarOffset = bounds.Location
			_Painter.DrawObject(args)
		End Sub
	End Class


End Namespace