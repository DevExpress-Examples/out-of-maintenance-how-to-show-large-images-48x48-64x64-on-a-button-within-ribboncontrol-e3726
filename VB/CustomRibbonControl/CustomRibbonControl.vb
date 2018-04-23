Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports DevExpress.XtraBars.Ribbon
Imports System.ComponentModel

Namespace LargeRibbonButton.CustomRibbonControl
	Public Enum LargeImageSizeCollection
		Image32x32 = 2
		Image48x48 = 3
		Image64x64 = 4
	End Enum

	Friend Class CustomRibbonControl
		Inherits RibbonControl
		' constructor
		Public Sub New()
			MyBase.New()
		LargeImageSize = LargeImageSizeCollection.Image32x32
		End Sub

		Private privateLargeImageSize As LargeImageSizeCollection
		<Browsable(True), Description("Gets or sets large image size in the button area")> _
		Public Property LargeImageSize() As LargeImageSizeCollection
			Get
				Return privateLargeImageSize
			End Get
			Set(ByVal value As LargeImageSizeCollection)
				privateLargeImageSize = value
			End Set
		End Property

		Protected Overrides Function CreateViewInfo() As DevExpress.XtraBars.Ribbon.ViewInfo.RibbonViewInfo
			Return New CustomRibbonViewInfo(Me)
		End Function

		Protected Overrides Function CreateBarManager() As RibbonBarManager
			Return New CustomRibbonBarManager(Me)
		End Function

	End Class
End Namespace
