using DevExpress.XtraEditors;
using DevExpress.XtraEditors.ViewInfo;
using DevExpress.LookAndFeel;
using DevExpress.Utils.Drawing;
using DevExpress.Utils;
using System;
using System.Drawing;
namespace WindowsApplication1
{
    public static class MyScrollBarPaintHelper
    {
        private static VScrollBar _ScrollBar = new MyScrollBar();
        private static  ScrollBarPainterBase _Painter;
       static MyScrollBarPaintHelper()
        {
            CreatePainter();
            UserLookAndFeel.Default.StyleChanged += Default_StyleChanged;
        }
        static  void Default_StyleChanged(object sender, EventArgs e)
        {
            CreatePainter();
        }
        private static void CreatePainter()
        {
            _Painter = LookAndFeelScrollBarPainter.GetPainter(UserLookAndFeel.Default);
        }
        public static  void DrawScrollBar(GraphicsCache cache, Rectangle bounds)
        {
            bounds.X = bounds.Right - _ScrollBar.Width - 1;
            bounds.Width = _ScrollBar.Width;
            _ScrollBar.Height = bounds.Height;
            ScrollBarInfoArgs args = new ScrollBarInfoArgs(cache, bounds, AppearanceObject.ControlAppearance, AppearanceObject.ControlAppearance, _ScrollBar);
            (args.ViewInfo as MyScrollBarViewInfo).Reset();
            (args.ViewInfo as MyScrollBarViewInfo).ScrollBarOffset = bounds.Location;
            _Painter.DrawObject(args);
        }
    }


}