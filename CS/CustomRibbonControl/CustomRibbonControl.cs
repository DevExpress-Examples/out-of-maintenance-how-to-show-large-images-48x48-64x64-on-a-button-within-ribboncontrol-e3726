using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraBars.Ribbon;
using System.ComponentModel;

namespace LargeRibbonButton.CustomRibbonControl
{
    public enum LargeImageSizeCollection
    {
        Image32x32 = 2, Image48x48 = 3, Image64x64 = 4    
    }

    class CustomRibbonControl : RibbonControl
    {
        // constructor
        public CustomRibbonControl() : base() { LargeImageSize = LargeImageSizeCollection.Image32x32; }

        [Browsable(true), Description("Gets or sets large image size in the button area")]
        public LargeImageSizeCollection LargeImageSize { get; set; }

        protected override DevExpress.XtraBars.Ribbon.ViewInfo.RibbonViewInfo CreateViewInfo()
        {
            return new CustomRibbonViewInfo(this);
        }

        protected override RibbonBarManager CreateBarManager()
        {
            return new CustomRibbonBarManager(this);
        }

    }
}
