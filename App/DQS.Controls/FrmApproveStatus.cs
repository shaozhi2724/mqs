using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DQS.Module.Entities;
using ORMSCore;
using DQS.Module.Views;
using DevExpress.XtraGrid.Views.Grid;

namespace DQS.Controls
{
    public partial class FrmApproveStatus : DevExpress.XtraEditors.XtraForm
    {
        private string m_DocumentCode;
        private string m_BillCode;

        public FrmApproveStatus()
        {
            InitializeComponent();
        }

        public FrmApproveStatus(string documentCode, string billCode)
        {
            InitializeComponent();
            this.m_DocumentCode = documentCode;
            this.m_BillCode = billCode;
        }

        private void FrmApproveStatus_Load(object sender, EventArgs e)
        {
            ViewCollection<AllApproveView> approves = new ViewCollection<AllApproveView>();
            PredicateExpression pe = new PredicateExpression();
            pe.Add(AllApproveViewFields.DocumentCode == this.m_DocumentCode);
            pe.Add(AllApproveViewFields.BillCode == m_BillCode);
            approves.Fetch(pe);

            if (approves.Count <= 0)
            {
                XtraMessageBox.Show("未找到相应审批状态信息，数据可能出现错误。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            AllApproveView approveInfo = approves[0] as AllApproveView;
            //多人全部审批通过
            if (approveInfo.IsWhole)
            {
                approveInfo = approves[approves.Count-1] as AllApproveView;
                this.txtIsPass.Text = approveInfo.状态;
            }
            else
            {
                if (approves.Cast<AllApproveView>().Any(p => p.状态 == "已审核通过"))
                {
                    this.txtIsPass.Text = "已审核通过";
                }
                else
                {
                    this.txtIsPass.Text = approveInfo.状态;
                }
            }

            this.txtApproveCode.Text = approveInfo.编号;
            this.txtApproveTitle.Text = approveInfo.标题;
            this.txtApprovalContent.Text = approveInfo.内容;
            this.txtCreateUser.Text = approveInfo.申请人;
            this.txtCreateDate.Text = approveInfo.申请时间.ToString("yyyy-MM-dd HH:mm:ss");
            this.txtIsWhole.Text = approveInfo.审批类型;

            this.gvControl.DataSource = approves;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
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