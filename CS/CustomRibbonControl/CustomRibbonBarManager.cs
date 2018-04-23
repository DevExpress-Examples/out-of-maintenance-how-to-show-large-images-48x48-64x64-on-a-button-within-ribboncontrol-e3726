using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars.ViewInfo;
using DevExpress.XtraBars.Ribbon.ViewInfo;
using DevExpress.XtraBars;

namespace LargeRibbonButton.CustomRibbonControl
{
    class CustomRibbonBarManager : RibbonBarManager
    {
        public CustomRibbonBarManager(RibbonControl ribbon) : base(ribbon) { }
        protected internal new BarDrawParameters DrawParameters { get { return PaintStyle.DrawParameters; } }
    }
}
