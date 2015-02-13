using DevExpress.XtraEditors;
using DQS.AppViews.Operation.PurchaseAndSaleManager;
using DQS.AppViews.Operation.BackManager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DQS.AppViews.Operation
{
    public partial class FrmReason : XtraForm
    {
        public FrmReason()
        {
            InitializeComponent();
        }

        FrmPurchase fp;
        FrmSale fs;
        FrmPurchaseBack fpb;
        FrmSaleBack fsb;
        int i = 0;
        public FrmReason(FrmPurchase _fp)
        {
            InitializeComponent();
            fp = _fp;
            i = 1;
        }
        public FrmReason(FrmSale _fs)
        {
            InitializeComponent();
            fs = _fs;
            i = 2;
        }
        public FrmReason(FrmPurchaseBack _fpb)
        {
            InitializeComponent();
            fpb = _fpb;
            i = 3;
        }
        public FrmReason(FrmSaleBack _fsb)
        {
            InitializeComponent();
            fsb = _fsb;
            i = 4;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.No;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (this.meReason.Text.Trim() == "")
            {
                XtraMessageBox.Show("请填写删除原因！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (i == 1)
            {
                fp.reason = this.meReason.Text;
                this.DialogResult = System.Windows.Forms.DialogResult.Yes;
            }
            else if (i == 2)
            {
                fs.reason = this.meReason.Text;
                this.DialogResult = System.Windows.Forms.DialogResult.Yes;
            }
            else if (i == 3)
            {
                fpb.reason = this.meReason.Text;
                this.DialogResult = System.Windows.Forms.DialogResult.Yes;
            }
            else if (i == 4)
            {
                fsb.reason = this.meReason.Text;
                this.DialogResult = System.Windows.Forms.DialogResult.Yes;
            }
        }
    }
}
