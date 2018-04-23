using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace LargeRibbonButton
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void radioGroupImageSize_EditValueChanged(object sender, EventArgs e)
        {
            customRibbonControlMain.Hide();
            customRibbonControlMain.LargeImageSize = (CustomRibbonControl.LargeImageSizeCollection)radioGroupImageSize.EditValue;
            customRibbonControlMain.Show();            
        }
    }
}
