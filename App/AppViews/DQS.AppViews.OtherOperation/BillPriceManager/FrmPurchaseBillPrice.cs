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

    }
}