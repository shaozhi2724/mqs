using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DQS.Controls;
using DQS.Module.Entities;

namespace DQS.AppViews.OtherOperation.BillPriceManager
{
    public partial class FrmPurchaseBillPrice : StandardForm
    {
        public FrmPurchaseBillPrice()
        {
            InitializeComponent();
        }

        private void FrmPurchaseBillPrice_Load(object sender, EventArgs e)
        {
            this.pageNavigator.SortField = "调价单号";
            this.pageNavigator.SortType = "DESC";
            base.InitPage();
        }

        protected override void CustomApprove()
        {
            object id = this.gvData.GetFocusedRowCellValue("调价单ID");
            if (id != null && id != DBNull.Value)
            {
                DialogResult dr = base.BaseApprove();
                if (dr == DialogResult.Yes)
                {
                    //更新采购单状态
                    BUSBillPriceHistoryEntity entity = new BUSBillPriceHistoryEntity { BillPriceHistoryID = (int)id };
                    entity.Fetch();
                    if (entity.BillStatus == 1)
                    {
                        entity.BillStatus = 2;
                        entity.BillStatusName = "已审核";
                        entity.Update();
                    }
                    this.pageNavigator.ShowData();
                }
            }
        }
    }
}