Imports Microsoft.VisualBasic
Imports System.Windows.Input
Imports DevExpress.Xpf.Gauges
Imports System.Windows.Controls
Imports System.Windows
Imports System.Windows.Controls.Primitives

Namespace DXGauges_Show_Tooltips
	Partial Public Class MainPage
		Inherits UserControl
		Public Sub New()

			InitializeComponent()
		End Sub

		Private Sub circularGaugeControl1_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs)
			Dim position As Point = e.GetPosition(circularGaugeControl1)

			Dim hitInfo As CircularGaugeHitInfo = circularGaugeControl1.CalcHitInfo(position)

			If hitInfo.InNeedle Then
				tooltip_text.Text = "Value: " & hitInfo.Needle.Value.ToString("n2")
				tooltip.HorizontalOffset = position.X
				tooltip.VerticalOffset = position.Y

				tooltip.IsOpen = True
			Else
				tooltip.IsOpen = False
			End If

		End Sub

		Private Sub circularGaugeControl1_MouseLeave(ByVal sender As Object, ByVal e As MouseEventArgs)
			tooltip.IsOpen = False
		End Sub

	End Class
End Namespace


