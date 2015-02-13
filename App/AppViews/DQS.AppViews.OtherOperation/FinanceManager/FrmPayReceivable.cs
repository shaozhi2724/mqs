using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DQS.Controls;

namespace DQS.AppViews.OtherOperation.FinanceManager
{
    public partial class FrmPayReceivable : StandardForm
    {
        public FrmPayReceivable()
        {
            InitializeComponent();
        }

        private void FrmPayReceivable_Load(object sender, EventArgs e)
        {
            base.InitPage();
        }

        protected override void CustomGroup()
        {
            base.gvData.OptionsView.ShowGroupPanel = true;
            base.gvData.OptionsView.ShowGroupedColumns = true;
            base.gvData.Columns["订单号"].GroupIndex = 0;
            base.gvData.ExpandAllGroups();
            base.gvData.BestFitColumns();
        }
    }
}