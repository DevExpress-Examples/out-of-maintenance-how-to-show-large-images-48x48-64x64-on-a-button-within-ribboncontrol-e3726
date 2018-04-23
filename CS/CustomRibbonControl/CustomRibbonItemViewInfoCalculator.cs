using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraBars.Ribbon.ViewInfo;
using System.Drawing;
using DevExpress.Utils.Drawing;
using DevExpress.Skins;
using DevExpress.XtraBars.Ribbon;

namespace LargeRibbonButton.CustomRibbonControl {
    class CustomRibbonItemViewInfoCalculator : RibbonItemViewInfoCalculator {
        public CustomRibbonItemViewInfoCalculator(CustomRibbonViewInfo viewInfo) : base(viewInfo) { }

        public override void CalcLargeButtonViewInfo(GraphicsCache cache, RibbonItemViewInfo item) {
            Rectangle glyph, bounds = item.Bounds;
            SkinElementInfo info = GetLargeButtonElementInfo(item);
            info.Bounds = bounds;
            Rectangle client = ObjectPainter.GetObjectClientRectangle(cache, SkinElementPainter.Default, info);
            glyph = client;
            glyph.Size = (ViewInfo as CustomRibbonViewInfo).LargeImageSize;
            glyph.X += (client.Width - glyph.Width) / 2;
            item.GlyphBounds = glyph;
            IRibbonGroupInfo groupInfo = item.Owner as IRibbonGroupInfo;
            Rectangle caption = client;
            caption.Height = GetLargeButtonTextHeight(groupInfo != null && groupInfo.IsSingleLineLargeButton);
            caption.Y = client.Bottom - caption.Height;
            item.CaptionBounds = caption;
        }

        protected override Size CalcLargeButtonSizeCore(GraphicsCache cache, RibbonItemViewInfo item, bool drawArrow) {
            Size client = (ViewInfo as CustomRibbonViewInfo).LargeImageSize;
            int width = GetButtonWidthByLevel(item);
            int arrowWidth = (drawArrow ? ArrowIndent + ViewInfo.ButtonArrowSize.Width : 0);
            if (width != 0) {
                item.ShouldWrapText = ShouldWrapLargeButtonText(cache, item, drawArrow, GetLargeButtonElementInfo(item));
                return new Size(width, ViewInfo.LargeButtonHeight);
            }
            else {
                item.ShouldWrapText = ShouldWrapItemText(item);
            }
            string[] text = WrapText(item);
            int textWidth = Math.Max(CalcLineTextSize(cache, item.Appearance, text[0]).Width,
                CalcLineTextSize(cache, item.Appearance, text[1]).Width + ((item.ViewInfo as CustomRibbonViewInfo).GetRibbonStyle() == RibbonControlStyle.MacOffice ? 0 : arrowWidth));
            client.Width = Math.Max(textWidth, client.Width);
            Size res = ObjectPainter.CalcBoundsByClientRectangle(cache, SkinElementPainter.Default, GetLargeButtonElementInfo(item), new Rectangle(Point.Empty, client)).Size;
            res.Width = Math.Max(ViewInfo.LargeButtonMinWidth, res.Width);
            res.Width += arrowWidth;
            IRibbonGroupInfo groupInfo = item.Owner as IRibbonGroupInfo;
            res.Height = groupInfo != null ? groupInfo.LargeRibbonButtonHeight : ViewInfo.LargeButtonHeight;
            if (width != 0) res.Width = width;
            return res;
        }

        
        protected override int CalcLargeButtonHeightCore(GraphicsCache cache, bool singleLine) {
            Size client = (ViewInfo as CustomRibbonViewInfo).LargeImageSize;
            int textHeight = GetLargeButtonTextHeight(singleLine);
            client.Height = client.Height + textHeight + CaptionVGlyphIndent;
            return ObjectPainter.CalcBoundsByClientRectangle(cache, SkinElementPainter.Default, GetLargeButtonElementInfo(null), new Rectangle(Point.Empty, client)).Height;
        }

        public override int CalcLargeSplitButtonHeight(GraphicsCache cache) {
            Size client = (ViewInfo as CustomRibbonViewInfo).LargeImageSize;
            int textHeight = GetLargeButtonTextHeight();
            int height = ObjectPainter.CalcBoundsByClientRectangle(cache, SkinElementPainter.Default, GetLargeSplitButtonElementInfo(null), new Rectangle(Point.Empty, client)).Height;
            height += ObjectPainter.CalcBoundsByClientRectangle(cache, SkinElementPainter.Default, GetLargeSplitButtonElementInfo2(null), new Rectangle(Point.Empty, new Size(16, textHeight))).Height;
            return height;
        }
    }
}
