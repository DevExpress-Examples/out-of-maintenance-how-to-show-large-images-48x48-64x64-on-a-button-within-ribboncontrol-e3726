Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraBars

Namespace LargeRibbonButton
    Partial Public Class MainForm
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub radioGroupImageSize_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles radioGroupImageSize.EditValueChanged
            customRibbonControlMain.Hide()
            customRibbonControlMain.LargeImageSize = CType(radioGroupImageSize.EditValue, CustomRibbonControl.LargeImageSizeCollection)
            customRibbonControlMain.Show()
        End Sub
    End Class
End Namespace
