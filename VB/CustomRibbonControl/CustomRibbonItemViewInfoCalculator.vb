Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports DevExpress.XtraBars.Ribbon.ViewInfo
Imports System.Drawing
Imports DevExpress.Utils.Drawing
Imports DevExpress.Skins
Imports DevExpress.XtraBars.Ribbon

Namespace LargeRibbonButton.CustomRibbonControl
	Friend Class CustomRibbonItemViewInfoCalculator
		Inherits RibbonItemViewInfoCalculator
		Public Sub New(ByVal viewInfo As CustomRibbonViewInfo)
			MyBase.New(viewInfo)
		End Sub

		Public Overrides Sub CalcLargeButtonViewInfo(ByVal graphics As Graphics, ByVal item As RibbonItemViewInfo)
			graphics = GInfo.AddGraphics(graphics)
			Try
				Dim glyph As Rectangle, bounds As Rectangle = item.Bounds
				Dim info As SkinElementInfo = GetLargeButtonElementInfo(item)
				info.Bounds = bounds
				Dim client As Rectangle = ObjectPainter.GetObjectClientRectangle(graphics, SkinElementPainter.Default, info)
				glyph = client
				glyph.Size = (TryCast(ViewInfo, CustomRibbonViewInfo)).LargeImageSize
				glyph.X += (client.Width - glyph.Width) / 2
				item.GlyphBounds = glyph
				Dim groupInfo As IRibbonGroupInfo = TryCast(item.Owner, IRibbonGroupInfo)
				Dim caption As Rectangle = client
				caption.Height = GetLargeButtonTextHeight(groupInfo IsNot Nothing AndAlso groupInfo.IsSingleLineLargeButton)
				caption.Y = client.Bottom - caption.Height
				item.CaptionBounds = caption
			Finally
				GInfo.ReleaseGraphics()
			End Try
		End Sub

		Protected Overrides Function CalcLargeButtonSizeCore(ByVal graphics As System.Drawing.Graphics, ByVal item As RibbonItemViewInfo, ByVal drawArrow As Boolean) As Size
			graphics = CheckGraphics(graphics)
			Dim client As Size = (TryCast(ViewInfo, CustomRibbonViewInfo)).LargeImageSize
			Dim width As Integer = GetButtonWidthByLevel(item)
			Dim arrowWidth As Integer = (If(drawArrow, ArrowIndent + ViewInfo.ButtonArrowSize.Width, 0))
			If width <> 0 Then
				item.ShouldWrapText = ShouldWrapLargeButtonText(graphics, item, drawArrow, GetLargeButtonElementInfo(item))
				Return New Size(width, ViewInfo.LargeButtonHeight)
			Else
				item.ShouldWrapText = ShouldWrapItemText(item)
			End If
			Dim text() As String = WrapText(item)
			Dim textWidth As Integer = Math.Max(CalcLineTextSize(graphics, item.Appearance, text(0)).Width, CalcLineTextSize(graphics, item.Appearance, text(1)).Width + (If((TryCast(item.ViewInfo, CustomRibbonViewInfo)).GetRibbonStyle() = RibbonControlStyle.MacOffice, 0, arrowWidth)))
			client.Width = Math.Max(textWidth, client.Width)
			Dim res As Size = ObjectPainter.CalcBoundsByClientRectangle(graphics, SkinElementPainter.Default, GetLargeButtonElementInfo(item), New Rectangle(Point.Empty, client)).Size
			res.Width = Math.Max(ViewInfo.LargeButtonMinWidth, res.Width)
			res.Width += arrowWidth
			Dim groupInfo As IRibbonGroupInfo = TryCast(item.Owner, IRibbonGroupInfo)
			res.Height = If(groupInfo IsNot Nothing, groupInfo.LargeRibbonButtonHeight, ViewInfo.LargeButtonHeight)
			If width <> 0 Then
				res.Width = width
			End If
			Return res
		End Function

		Protected Overrides Function CalcLargeButtonHeightCore(ByVal graphics As Graphics, ByVal singleLine As Boolean) As Integer
			graphics = CheckGraphics(graphics)
			Dim client As Size = (TryCast(ViewInfo, CustomRibbonViewInfo)).LargeImageSize
			Dim textHeight As Integer = GetLargeButtonTextHeight(singleLine)
			client.Height = client.Height + textHeight + CaptionVGlyphIndent
			Return ObjectPainter.CalcBoundsByClientRectangle(graphics, SkinElementPainter.Default, GetLargeButtonElementInfo(Nothing), New Rectangle(Point.Empty, client)).Height
		End Function

		Public Overrides Function CalcLargeSplitButtonHeight(ByVal graphics As Graphics) As Integer
			graphics = CheckGraphics(graphics)
			Dim client As Size = (TryCast(ViewInfo, CustomRibbonViewInfo)).LargeImageSize
			Dim textHeight As Integer = GetLargeButtonTextHeight()
			Dim height As Integer = ObjectPainter.CalcBoundsByClientRectangle(graphics, SkinElementPainter.Default, GetLargeSplitButtonElementInfo(Nothing), New Rectangle(Point.Empty, client)).Height
			height += ObjectPainter.CalcBoundsByClientRectangle(graphics, SkinElementPainter.Default, GetLargeSplitButtonElementInfo2(Nothing), New Rectangle(Point.Empty, New Size(16, textHeight))).Height
			Return height
		End Function
	End Class
End Namespace
