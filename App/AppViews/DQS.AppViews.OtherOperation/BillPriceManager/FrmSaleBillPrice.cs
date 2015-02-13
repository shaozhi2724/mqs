using System;
using DQS.Controls;

namespace DQS.AppViews.OtherOperation.BillPriceManager
{
    public partial class FrmSaleBillPrice : StandardForm
    {
        public FrmSaleBillPrice()
        {
            InitializeComponent();
        }

        private void FrmSaleBillPrice_Load(object sender, EventArgs e)
        {
            this.pageNavigator.SortField = "调价单号";
            this.pageNavigator.SortType = "DESC";
            base.InitPage();
        }

    }
}