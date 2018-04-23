namespace LargeRibbonButton
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.customRibbonControlMain = new LargeRibbonButton.CustomRibbonControl.CustomRibbonControl();
            this.barButtonItemSmall = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemLarge = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageExample = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroupButtons = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.radioGroupImageSize = new DevExpress.XtraEditors.RadioGroup();
            ((System.ComponentModel.ISupportInitialize)(this.customRibbonControlMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroupImageSize.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
            // 
            // customRibbonControlMain
            // 
            this.customRibbonControlMain.ApplicationButtonText = null;
            // 
            // 
            // 
            this.customRibbonControlMain.ExpandCollapseItem.Id = 0;
            this.customRibbonControlMain.ExpandCollapseItem.Name = "";
            this.customRibbonControlMain.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.customRibbonControlMain.ExpandCollapseItem,
            this.barButtonItemSmall,
            this.barButtonItemLarge});
            this.customRibbonControlMain.LargeImageSize = LargeRibbonButton.CustomRibbonControl.LargeImageSizeCollection.Image32x32;
            this.customRibbonControlMain.Location = new System.Drawing.Point(0, 0);
            this.customRibbonControlMain.MaxItemId = 9;
            this.customRibbonControlMain.Name = "customRibbonControlMain";
            this.customRibbonControlMain.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPageExample});
            this.customRibbonControlMain.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.customRibbonControlMain.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            this.customRibbonControlMain.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Show;
            this.customRibbonControlMain.Size = new System.Drawing.Size(472, 145);
            // 
            // barButtonItemSmall
            // 
            this.barButtonItemSmall.Caption = "Small";
            this.barButtonItemSmall.Glyph = global::LargeRibbonButton.Properties.Resources.IMG_1445;
            this.barButtonItemSmall.Id = 1;
            this.barButtonItemSmall.Name = "barButtonItemSmall";
            // 
            // barButtonItemLarge
            // 
            this.barButtonItemLarge.Caption = "Large";
            this.barButtonItemLarge.Glyph = global::LargeRibbonButton.Properties.Resources.IMG_1407;
            this.barButtonItemLarge.Id = 2;
            this.barButtonItemLarge.LargeGlyph = global::LargeRibbonButton.Properties.Resources.IMG_1445;
            this.barButtonItemLarge.Name = "barButtonItemLarge";
            this.barButtonItemLarge.Tag = 32;
            // 
            // ribbonPageExample
            // 
            this.ribbonPageExample.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroupButtons});
            this.ribbonPageExample.Name = "ribbonPageExample";
            this.ribbonPageExample.Text = "Example";
            // 
            // ribbonPageGroupButtons
            // 
            this.ribbonPageGroupButtons.ItemLinks.Add(this.barButtonItemLarge);
            this.ribbonPageGroupButtons.ItemLinks.Add(this.barButtonItemSmall);
            this.ribbonPageGroupButtons.Name = "ribbonPageGroupButtons";
            this.ribbonPageGroupButtons.Text = "Buttons example";
            // 
            // radioGroupImageSize
            // 
            this.radioGroupImageSize.Location = new System.Drawing.Point(0, 179);
            this.radioGroupImageSize.MenuManager = this.customRibbonControlMain;
            this.radioGroupImageSize.Name = "radioGroupImageSize";
            this.radioGroupImageSize.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(2, "Image (32x32)"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(3, "Image (48x48)"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(4, "Image (64x64)")});
            this.radioGroupImageSize.Size = new System.Drawing.Size(349, 27);
            this.radioGroupImageSize.TabIndex = 1;
            this.radioGroupImageSize.EditValueChanged += new System.EventHandler(this.radioGroupImageSize_EditValueChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 213);
            this.Controls.Add(this.radioGroupImageSize);
            this.Controls.Add(this.customRibbonControlMain);
            this.Name = "MainForm";
            this.Text = "Example main form";
            ((System.ComponentModel.ISupportInitialize)(this.customRibbonControlMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroupImageSize.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private LargeRibbonButton.CustomRibbonControl.CustomRibbonControl customRibbonControlMain;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageExample;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupButtons;
        private DevExpress.XtraBars.BarButtonItem barButtonItemSmall;
        private DevExpress.XtraBars.BarButtonItem barButtonItemLarge;
        private DevExpress.XtraEditors.RadioGroup radioGroupImageSize;



    }
}

