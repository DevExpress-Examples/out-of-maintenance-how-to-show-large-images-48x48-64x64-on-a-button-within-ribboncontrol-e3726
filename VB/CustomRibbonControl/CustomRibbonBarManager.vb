Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraBars.ViewInfo
Imports DevExpress.XtraBars.Ribbon.ViewInfo
Imports DevExpress.XtraBars

Namespace LargeRibbonButton.CustomRibbonControl
    Friend Class CustomRibbonBarManager
        Inherits RibbonBarManager

        Public Sub New(ByVal ribbon As RibbonControl)
            MyBase.New(ribbon)
        End Sub
        Protected Friend Shadows ReadOnly Property DrawParameters() As BarDrawParameters
            Get
                Return PaintStyle.DrawParameters
            End Get
        End Property
    End Class
End Namespace
