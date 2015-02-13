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
    public partial class FrmPayable : StandardForm
    {
        public FrmPayable()
        {
            InitializeComponent();
        }

        private void FrmPayable_Load(object sender, EventArgs e)
        {
            base.InitPage();
            CustomGroup();
        }
        private void CustomGroup()
        {
            base.gvData.OptionsView.ShowGroupPanel = true;
            base.gvData.OptionsView.ShowGroupedColumns = true;
            base.gvData.Columns["订单号"].GroupIndex = 0;
            base.gvData.ExpandAllGroups();
            base.gvData.BestFitColumns();
        }
    }
}