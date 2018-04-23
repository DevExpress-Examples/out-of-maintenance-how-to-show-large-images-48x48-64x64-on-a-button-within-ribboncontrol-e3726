Namespace LargeRibbonButton
    Partial Public Class MainForm
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.ribbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
            Me.customRibbonControlMain = New LargeRibbonButton.CustomRibbonControl.CustomRibbonControl()
            Me.barButtonItemSmall = New DevExpress.XtraBars.BarButtonItem()
            Me.barButtonItemLarge = New DevExpress.XtraBars.BarButtonItem()
            Me.ribbonPageExample = New DevExpress.XtraBars.Ribbon.RibbonPage()
            Me.ribbonPageGroupButtons = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.radioGroupImageSize = New DevExpress.XtraEditors.RadioGroup()
            CType(Me.customRibbonControlMain, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radioGroupImageSize.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' ribbonPage1
            ' 
            Me.ribbonPage1.Name = "ribbonPage1"
            Me.ribbonPage1.Text = "ribbonPage1"
            ' 
            ' customRibbonControlMain
            ' 
            Me.customRibbonControlMain.ApplicationButtonText = Nothing
            ' 
            ' 
            ' 
            Me.customRibbonControlMain.ExpandCollapseItem.Id = 0
            Me.customRibbonControlMain.ExpandCollapseItem.Name = ""
            Me.customRibbonControlMain.Items.AddRange(New DevExpress.XtraBars.BarItem() { Me.customRibbonControlMain.ExpandCollapseItem, Me.barButtonItemSmall, Me.barButtonItemLarge})
            Me.customRibbonControlMain.LargeImageSize = LargeRibbonButton.CustomRibbonControl.LargeImageSizeCollection.Image32x32
            Me.customRibbonControlMain.Location = New System.Drawing.Point(0, 0)
            Me.customRibbonControlMain.MaxItemId = 9
            Me.customRibbonControlMain.Name = "customRibbonControlMain"
            Me.customRibbonControlMain.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() { Me.ribbonPageExample})
            Me.customRibbonControlMain.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False
            Me.customRibbonControlMain.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False
            Me.customRibbonControlMain.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Show
            Me.customRibbonControlMain.Size = New System.Drawing.Size(472, 145)
            ' 
            ' barButtonItemSmall
            ' 
            Me.barButtonItemSmall.Caption = "Small"
            Me.barButtonItemSmall.Glyph = My.Resources.IMG_1445
            Me.barButtonItemSmall.Id = 1
            Me.barButtonItemSmall.Name = "barButtonItemSmall"
            ' 
            ' barButtonItemLarge
            ' 
            Me.barButtonItemLarge.Caption = "Large"
            Me.barButtonItemLarge.Glyph = My.Resources.IMG_1407
            Me.barButtonItemLarge.Id = 2
            Me.barButtonItemLarge.LargeGlyph = My.Resources.IMG_1445
            Me.barButtonItemLarge.Name = "barButtonItemLarge"
            Me.barButtonItemLarge.Tag = 32
            ' 
            ' ribbonPageExample
            ' 
            Me.ribbonPageExample.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.ribbonPageGroupButtons})
            Me.ribbonPageExample.Name = "ribbonPageExample"
            Me.ribbonPageExample.Text = "Example"
            ' 
            ' ribbonPageGroupButtons
            ' 
            Me.ribbonPageGroupButtons.ItemLinks.Add(Me.barButtonItemLarge)
            Me.ribbonPageGroupButtons.ItemLinks.Add(Me.barButtonItemSmall)
            Me.ribbonPageGroupButtons.Name = "ribbonPageGroupButtons"
            Me.ribbonPageGroupButtons.Text = "Buttons example"
            ' 
            ' radioGroupImageSize
            ' 
            Me.radioGroupImageSize.Location = New System.Drawing.Point(0, 179)
            Me.radioGroupImageSize.MenuManager = Me.customRibbonControlMain
            Me.radioGroupImageSize.Name = "radioGroupImageSize"
            Me.radioGroupImageSize.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() { _
                New DevExpress.XtraEditors.Controls.RadioGroupItem(2, "Image (32x32)"), _
                New DevExpress.XtraEditors.Controls.RadioGroupItem(3, "Image (48x48)"), _
                New DevExpress.XtraEditors.Controls.RadioGroupItem(4, "Image (64x64)") _
            })
            Me.radioGroupImageSize.Size = New System.Drawing.Size(349, 27)
            Me.radioGroupImageSize.TabIndex = 1
            ' 
            ' MainForm
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(472, 213)
            Me.Controls.Add(Me.radioGroupImageSize)
            Me.Controls.Add(Me.customRibbonControlMain)
            Me.Name = "MainForm"
            Me.Text = "Example main form"
            CType(Me.customRibbonControlMain, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radioGroupImageSize.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private ribbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
        Private customRibbonControlMain As LargeRibbonButton.CustomRibbonControl.CustomRibbonControl
        Private ribbonPageExample As DevExpress.XtraBars.Ribbon.RibbonPage
        Private ribbonPageGroupButtons As DevExpress.XtraBars.Ribbon.RibbonPageGroup
        Private barButtonItemSmall As DevExpress.XtraBars.BarButtonItem
        Private barButtonItemLarge As DevExpress.XtraBars.BarButtonItem
        Private WithEvents radioGroupImageSize As DevExpress.XtraEditors.RadioGroup



    End Class
End Namespace

