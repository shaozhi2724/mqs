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
    public partial class FrmHost : DevExpress.XtraEditors.XtraForm
    {
        public FrmHost()
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

        private void gvData_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
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
            data.Columns.Add("登录用户", Type.GetType("System.String"));
            data.Columns.Add("IP地址", Type.GetType("System.String"));
            data.Columns.Add("端口号", Type.GetType("System.String"));
            data.Columns.Add("注册号", Type.GetType("System.String"));

            DataRow row = data.NewRow();
            row["计算机名称"] = "PC-20130728928";
            row["登录用户"] = "张三";
            row["IP地址"] = "192.168.1.108";
            row["端口号"] = "52317";
            row["注册号"] = "B78DD03B3B3934623C0E750DC1779373";
            data.Rows.Add(row);

            row = data.NewRow();
            row["计算机名称"] = "John-PC";
            row["登录用户"] = "李四";
            row["IP地址"] = "192.168.1.65";
            row["端口号"] = "90761";
            row["注册号"] = "B511E7D9C0092A21427860D7ED59756D";
            data.Rows.Add(row);


            row = data.NewRow();
            row["计算机名称"] = "YANGTIANDI";
            row["登录用户"] = "杨天帝";
            row["IP地址"] = "192.168.1.21";
            row["端口号"] = "12306";
            row["注册号"] = "88524D781055119EBD144EBE7117FBD0";
            data.Rows.Add(row);


            row = data.NewRow();
            row["计算机名称"] = "T-MINGHUANG";
            row["登录用户"] = "唐明皇";
            row["IP地址"] = "192.168.1.232";
            row["端口号"] = "7981";
            row["注册号"] = "AEC96811C5A582EE2389B706F0128168";
            data.Rows.Add(row);


            row = data.NewRow();
            row["计算机名称"] = "ZHAO-SIX";
            row["登录用户"] = "赵六";
            row["IP地址"] = "192.168.1.191";
            row["端口号"] = "32901";
            row["注册号"] = "CFCC949AFE0479AD82F36C77D1FE0983";
            data.Rows.Add(row);

            return data;
        }

        private void FrmHost_Load(object sender, EventArgs e)
        {
            this.gvControl.DataSource = this.GetRegisterData();
            this.gvData.Columns["注册号"].Width = 180;
        }

        private void bbiDbSetting_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (FrmDbSetting frmDbSetting = new FrmDbSetting())
            {
                frmDbSetting.ShowDialog(this);
            }
        }

        private void bbiDbBack_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (FrmDbBack frmDbBack = new FrmDbBack())
            {
                frmDbBack.ShowDialog(this);
            }
        }

        private void bbiFunctionLog_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (FrmFunctionLogs frmFunctionLogs = new FrmFunctionLogs())
            {
                frmFunctionLogs.ShowDialog(this);
            }
        }

        private void bbiRegister_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (FrmRegisterManager frmRegisterManager = new FrmRegisterManager())
            {
                frmRegisterManager.ShowDialog(this);
            }
        }
    }
}