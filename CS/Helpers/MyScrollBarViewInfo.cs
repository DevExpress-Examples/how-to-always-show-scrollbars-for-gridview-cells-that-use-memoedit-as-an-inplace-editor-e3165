using DevExpress.XtraEditors;
using DevExpress.XtraEditors.ViewInfo;
using System;
using System.Drawing;

namespace WindowsApplication1
{
    public class MyScrollBarViewInfo : ScrollBarViewInfo
    {
        private Point _ScrollBarOffset;
        public Point ScrollBarOffset
        {
            get
            {
                return _ScrollBarOffset;
            }
            set
            {
                _ScrollBarOffset = value;
            }
        }
        public MyScrollBarViewInfo(IScrollBar scrollBar)
            : base(scrollBar)
        {
        }
        protected override Rectangle CalcThumbButtonBounds
        {
            get
            {
                Rectangle bounds = base.CalcThumbButtonBounds;
                bounds.Offset(ScrollBarOffset);
                return bounds;
            }
        }
        public override Rectangle VisibleDecButtonBounds
        {
            get
            {
                Rectangle rect = base.VisibleDecButtonBounds;
                rect.Offset(ScrollBarOffset);
                return rect;
            }
        }
        public override Rectangle VisibleIncButtonBounds
        {
            get
            {
                Rectangle rect = base.VisibleIncButtonBounds;
                rect.Offset(ScrollBarOffset);
                return rect;
            }
        }
    }
}
