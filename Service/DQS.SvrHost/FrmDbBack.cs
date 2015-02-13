using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ORMSCore;
using DQS.Module.Views;
using DevExpress.XtraGrid.Views.Grid;

namespace DQS.SvrHost
{
    public partial class FrmDbBack : DevExpress.XtraEditors.XtraForm
    {
        public FrmDbBack()
        {
            InitializeComponent();
        }

        private void bbiDbBackPlan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (FrmDbBackPlan frmDbBackPlan = new FrmDbBackPlan())
            {
                frmDbBackPlan.ShowDialog(this);
            }
        }

        private void FrmDbBack_Load(object sender, EventArgs e)
        {
            this.dtStart.DateTime = DateTime.Now.AddDays(-7);
            this.dtEnd.DateTime = DateTime.Now;
            this.bsiPlan.Caption = String.Format("摘要：下次系统自动备份将在 {0:yyyy-MM-dd} 0:00:00 进行。", DateTime.Now.AddMonths(1));

            ViewCollection<AllDbBackupsView> backups = new ViewCollection<AllDbBackupsView>();
            DataTable data = backups.FetchTable();
            this.gvControl.DataSource = data;

            //设置列宽度，使标题全部显示
            foreach (DevExpress.XtraGrid.Columns.GridColumn col in gvData.Columns)
            {
                if (col.FieldName.Length > 4)
                {
                    col.Width = 16 * col.FieldName.Length;
                }
            }
        }

        private void gvData_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator)
            {
                if (e.RowHandle >= 0)
                {
                    e.Info.DisplayText = (e.RowHandle + 1).ToString();
                }
            }
        }

        private void gvData_CustomDrawEmptyForeground(object sender, DevExpress.XtraGrid.Views.Base.CustomDrawEventArgs e)
        {
            GridView view = sender as GridView;

            if (view.RowCount != 0) return;//有记录，返回

            using (StringFormat drawFormat = new StringFormat())
            {
                drawFormat.Alignment = drawFormat.LineAlignment = StringAlignment.Center;
                e.Graphics.DrawString("暂无记录", e.Appearance.Font, SystemBrushes.ControlDark, new RectangleF(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height), drawFormat);
            }
        }
    }
}