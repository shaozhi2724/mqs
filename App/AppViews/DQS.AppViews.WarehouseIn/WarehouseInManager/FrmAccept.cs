using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DQS.Controls;
using System.IO;
using DQS.Module.Entities;

namespace DQS.AppViews.WarehouseIn.WarehouseInManager
{
    public partial class FrmAccept : StandardForm
    {
        public FrmAccept()
        {
            InitializeComponent();
        }

        private void FrmAccept_Load(object sender, EventArgs e)
        {
            this.pageNavigator.SortField = "创建日期";
            this.pageNavigator.SortType = "DESC";
            base.InitPage();
        }

        protected override void CustomPrint()
        {
            this.SaveDataLog("打印");
            object id = this.gvData.GetFocusedRowCellValue("验收单ID");
            if (id != null)
            {
                BUSAcceptEntity accept = new BUSAcceptEntity { AcceptID = Convert.ToInt32(id) };
                accept.Fetch();
                if (!accept.IsNullField("Reservation10") && accept.Reservation10 == "复查单据")
                {
                    string fileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory + "验收报告单.mrt");
                    if (File.Exists(fileName))
                    {
                        PrintPreviewForm printPreview = new PrintPreviewForm(fileName, Convert.ToInt32(id));
                        printPreview.ShowDialog(this);
                    }
                    else
                    {
                        XtraMessageBox.Show("找不到文件。", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    XtraMessageBox.Show("该打印按钮为打印复查通知单按钮，该单不是复查单据。请重新选择。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
        }

        protected override void CustomReCheck()
        {
            this.SaveDataLog("复查");
            object id = this.gvData.GetFocusedRowCellValue("验收单ID");
            if (id != null)
            {
                BUSAcceptEntity accept = new BUSAcceptEntity { AcceptID = Convert.ToInt32(id) };
                accept.Fetch();
                BUSBillEntity bill = new BUSBillEntity { BillID = accept.BillID };
                bill.Fetch();
                if (bill.BillStatusName == "验收复查")
                {
                    string reason;
                    using (FrmReCheckReason frm = new FrmReCheckReason())
                    {
                        frm.Text = "填写复查结论";
                        DialogResult drs = frm.ShowDialog();
                        if (drs == DialogResult.Yes)
                        {
                            reason = frm.reason;
                        }
                        else
                        {
                            return;
                        }
                    }
                    accept.Reservation2 = reason;
                    accept.Update();

                    bill.BillStatus = int.Parse(accept.Reservation3);
                    bill.BillStatusName = accept.Reservation4;
                    bill.Update();
                }
                else
                {
                    XtraMessageBox.Show("该单不是复查单据，请重新选择。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            base.CustomReCheck();
            this.pageNavigator.ShowData();
        }

        protected override void CustomApprove()
        {
            this.SaveDataLog("审批");
            object id = this.gvData.GetFocusedRowCellValue("验收单ID");
            if (id != null && id != DBNull.Value)
            {
                BUSAcceptEntity accept = new BUSAcceptEntity { AcceptID = Convert.ToInt32(id) };
                accept.Fetch();

                //string statusName = gvData.GetFocusedRowCellValue("状态").ToString();
                //if (statusName == "未批准")
                //{
                //    XtraMessageBox.Show("该单据已作废，不允许再次审批", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    return;
                //}
                DialogResult dr = base.BaseApprove();
                if (dr == DialogResult.Yes)
                {
                    //更新销售单状态
                    BUSBillEntity entity = new BUSBillEntity { BillID = accept.BillID };
                    entity.Fetch();
                    if (entity.BillStatus == 7)
                    {
                        entity.BillStatus = int.Parse(accept.Reservation3);
                        entity.BillStatusName = accept.Reservation4;
                        entity.Update();
                    }
                    this.pageNavigator.ShowData();
                }
            }
        }
    }
}