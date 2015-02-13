using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;

namespace DQS.SvrHost
{
    public partial class FrmRegisterManager : DevExpress.XtraEditors.XtraForm
    {
        public FrmRegisterManager()
        {
            InitializeComponent();
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

        private DataTable GetRegisterData()
        {
            DataTable data = new DataTable();
            data.Columns.Add("计算机名称", Type.GetType("System.String"));
            data.Columns.Add("注册号", Type.GetType("System.String"));

            DataRow row = data.NewRow();
            row["计算机名称"] = "PC-20130728928";
            row["注册号"] = "B78DD03B3B3934623C0E750DC1779373";
            data.Rows.Add(row);

            row = data.NewRow();
            row["计算机名称"] = "John-PC";
            row["注册号"] = "B511E7D9C0092A21427860D7ED59756D";
            data.Rows.Add(row);


            row = data.NewRow();
            row["计算机名称"] = "YANGTIANDI";
            row["注册号"] = "88524D781055119EBD144EBE7117FBD0";
            data.Rows.Add(row);


            row = data.NewRow();
            row["计算机名称"] = "T-MINGHUANG";
            row["注册号"] = "AEC96811C5A582EE2389B706F0128168";
            data.Rows.Add(row);


            row = data.NewRow();
            row["计算机名称"] = "LIU-NJ";
            row["注册号"] = "CFCC949AFE0479AD82F36C77D1FE0983";
            data.Rows.Add(row);

            row = data.NewRow();
            row["计算机名称"] = "WORK20382612";
            row["注册号"] = "88524D781055119EBD144EBE7117FBD0";
            data.Rows.Add(row);


            row = data.NewRow();
            row["计算机名称"] = "XM-8732678121";
            row["注册号"] = "AEC96811C5A582EE2389B706F0128168";
            data.Rows.Add(row);


            row = data.NewRow();
            row["计算机名称"] = "AUTODELL";
            row["注册号"] = "CFCC949AFE0479AD82F36C77D1FE0983";
            data.Rows.Add(row);

            return data;
        }

        private void FrmRegisterManager_Load(object sender, EventArgs e)
        {
            this.gvControl.DataSource = this.GetRegisterData();
        }
    }
}