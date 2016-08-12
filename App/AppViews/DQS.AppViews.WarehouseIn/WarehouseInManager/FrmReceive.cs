using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DQS.Controls;
using DQS.Module.Entities;
using System.IO;

namespace DQS.AppViews.WarehouseIn.WarehouseInManager
{
    public partial class FrmReceive : StandardForm
    {
        public FrmReceive()
        {
            InitializeComponent();
        }

        private void FrmReceive_Load(object sender, EventArgs e)
        {
            this.pageNavigator.SortField = "创建日期";
            this.pageNavigator.SortType = "DESC";
            base.InitPage();
        }

        protected override void CustomReCheck()
        {
            object id = this.gvData.GetFocusedRowCellValue("收货单ID");
            if (id != null)
            {
                BUSReceiveEntity receive = new BUSReceiveEntity { ReceiveID = Convert.ToInt32(id) };
                receive.Fetch();
                BUSBillEntity bill = new BUSBillEntity { BillID = receive.BillID };
                bill.Fetch();
                if (bill.BillStatusName == "收货复查")
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
                    receive.Reservation8 = reason;
                    receive.Update();

                    bill.BillStatus = int.Parse(receive.Reservation5);
                    bill.BillStatusName = receive.Reservation6;
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

        protected override void CustomPrint()
        {
            object id = this.gvData.GetFocusedRowCellValue("收货单ID");
            if (id != null)
            {
                BUSReceiveEntity receive = new BUSReceiveEntity { ReceiveID = Convert.ToInt32(id) };
                receive.Fetch();
                BUSBillEntity bill = new BUSBillEntity { BillID = receive.BillID };
                bill.Fetch();
                if (bill.BillStatusName == "收货复查")
                {
                    string fileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory + "收货报告单.mrt");
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
    }
}