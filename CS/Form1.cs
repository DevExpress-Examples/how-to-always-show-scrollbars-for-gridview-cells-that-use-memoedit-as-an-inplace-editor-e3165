

using System.Windows.Forms;
using System.Data;
using System;
using DevExpress.XtraEditors.ViewInfo;
using DevExpress.LookAndFeel;
using DevExpress.Utils;
using DevExpress.Utils.Drawing;
using System.Drawing;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraGrid;
namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
        private DefaultPaintHelper _DefaultPaintHelper;
             
        private DataTable CreateTable(int RowCount)
        {
            DataTable tbl = new DataTable();
            tbl.Columns.Add("Name", typeof(string));
            tbl.Columns.Add("ID", typeof(int));
            tbl.Columns.Add("Number", typeof(int));
            tbl.Columns.Add("Date", typeof(DateTime));
            for (int i = 0; i < RowCount; i++)
                tbl.Rows.Add(new object[] { String.Format("Name{0}{1}{0}{1}{0}", i, Environment.NewLine), i, 3 - i, DateTime.Now.AddDays(i) });
            return tbl;
        }


        public Form1()
        {
            InitializeComponent();
            gridView1.CustomDrawCell += gridView1_CustomDrawCell;
            gridControl1.DataSource = CreateTable(20);
            gridView1.RowHeight = 40;
            gridView1.Columns[0].ColumnEdit = new RepositoryItemMemoEdit();
            _DefaultPaintHelper = new DefaultPaintHelper(gridControl1);
        }

        void gridView1_CustomDrawCell(object sender, RowCellCustomDrawEventArgs e)
        {
            if (!(e.Column.ColumnEdit is RepositoryItemMemoEdit))
                return;
            e.Handled = true;
            _DefaultPaintHelper.DefaultDrawContent(e);
            MyScrollBarPaintHelper.DrawScrollBar(e.Cache, e.Bounds);
        }

  
    }
}