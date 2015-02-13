using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DQS.Controls;

namespace DQS.AppViews.StatReport.StatManager
{
    public partial class FrmSummaryStockOut : StandardForm
    {
        public FrmSummaryStockOut()
        {
            InitializeComponent();
        }

        private void FrmSummaryStockOut_Load(object sender, EventArgs e)
        {
            base.InitPage();
        }
    }
}