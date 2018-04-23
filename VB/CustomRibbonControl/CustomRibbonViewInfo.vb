Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports DevExpress.XtraBars.Ribbon.ViewInfo
Imports DevExpress.XtraBars.Ribbon
Imports System.Drawing

Namespace LargeRibbonButton.CustomRibbonControl
    Friend Class CustomRibbonViewInfo
        Inherits RibbonViewInfo

        ' constructor
        Public Sub New(ByVal ribbon As RibbonControl)
            MyBase.New(ribbon)
        End Sub

        Protected Overrides Function CreateItemCalculator() As RibbonItemViewInfoCalculator
            Return New CustomRibbonItemViewInfoCalculator(Me)
        End Function

        Protected Friend Shadows Function GetRibbonStyle() As RibbonControlStyle
            Return MyBase.GetRibbonStyle()
        End Function

        Public Shadows ReadOnly Property LargeImageSize() As Size
            Get
                Dim currentControl As CustomRibbonControl = TryCast(Ribbon, CustomRibbonControl)
                Dim iScaleCoeff As Integer = CInt(currentControl.LargeImageSize)
                Dim imSize As Integer = 16 * iScaleCoeff
                If Manager.GetController().PropertiesRibbon.ScaleIcons Then
                    imSize = CInt((imSize * (TryCast(Manager, CustomRibbonBarManager)).DrawParameters.RibbonImageScaleFactor))
                End If
                Return New Size(imSize, imSize)
            End Get
        End Property
    End Class
End Namespace
