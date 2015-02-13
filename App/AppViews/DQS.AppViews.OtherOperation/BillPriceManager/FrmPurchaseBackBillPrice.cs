using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DQS.Common;
using DQS.Controls;
using DQS.Module.Entities;
using ORMSCore;

namespace DQS.AppViews.OtherOperation.BillPriceManager
{
    public partial class FrmPurchaseBackBillPrice : StandardForm
    {
        public FrmPurchaseBackBillPrice()
        {
            InitializeComponent();
        }

        private void FrmPurchaseBackBillPrice_Load(object sender, EventArgs e)
        {
            this.pageNavigator.SortField = "调价单号";
            this.pageNavigator.SortType = "DESC";
            base.InitPage();
        }
    }
}