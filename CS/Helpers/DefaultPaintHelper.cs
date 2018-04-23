using System;
using DevExpress.Utils.Drawing;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraGrid;

namespace WindowsApplication1
{
    public class DefaultPaintHelper
    {
        private GridEditorContainerHelper _ContainerHelper;
        public DefaultPaintHelper(GridControl gc)
        {
            _ContainerHelper = new GridEditorContainerHelper(gc);
        }
        public void DefaultDrawContent(RowCellCustomDrawEventArgs e)
        {
            GridCellInfo cellInfo = e.Cell as GridCellInfo;
            _ContainerHelper.DrawCellEdit(new GraphicsInfoArgs(e.Cache, e.Bounds), cellInfo.Editor, cellInfo.ViewInfo, e.Appearance, cellInfo.CellValueRect.Location);
        }
    }
}
