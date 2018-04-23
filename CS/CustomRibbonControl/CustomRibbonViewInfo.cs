using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraBars.Ribbon.ViewInfo;
using DevExpress.XtraBars.Ribbon;
using System.Drawing;

namespace LargeRibbonButton.CustomRibbonControl
{
    class CustomRibbonViewInfo : RibbonViewInfo
    {
        // constructor
        public CustomRibbonViewInfo(RibbonControl ribbon) : base(ribbon) { }

        protected override RibbonItemViewInfoCalculator CreateItemCalculator()
        {
            return new CustomRibbonItemViewInfoCalculator(this);
        }

        protected internal new RibbonControlStyle GetRibbonStyle() 
        {
            return base.GetRibbonStyle();
        }

        public new Size LargeImageSize
        {
            get
            {
                CustomRibbonControl currentControl = Ribbon as CustomRibbonControl;
                int iScaleCoeff = (int)currentControl.LargeImageSize;
                int imSize = 16 * iScaleCoeff;
                if (Manager.GetController().PropertiesRibbon.ScaleIcons)
                    imSize = (int)(imSize * (Manager as CustomRibbonBarManager).DrawParameters.RibbonImageScaleFactor);
                return new Size(imSize, imSize);
            }
        }
    }
}
