Imports Microsoft.VisualBasic
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.ViewInfo
Imports System
Imports System.Drawing

Namespace WindowsApplication1
	<System.ComponentModel.DesignerCategory("")> _
	Public Class MyScrollBar
		Inherits VScrollBar
		Public Sub New()
		End Sub
		Protected Overrides Function CreateScrollBarViewInfo() As ScrollBarViewInfo
			Return New MyScrollBarViewInfo(Me)
		End Function
	End Class
End Namespace