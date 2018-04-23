using DevExpress.XtraEditors;
using DevExpress.XtraEditors.ViewInfo;
using System;
using System.Drawing;

namespace WindowsApplication1
{
    [System.ComponentModel.DesignerCategory("")]
    public class MyScrollBar : VScrollBar
    {
        public MyScrollBar()
        {
        }
        protected override ScrollBarViewInfo CreateScrollBarViewInfo()
        {
            return new MyScrollBarViewInfo(this);
        }
    }
}