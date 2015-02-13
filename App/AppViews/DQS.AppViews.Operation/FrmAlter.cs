﻿using DevExpress.XtraEditors;
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
    public partial class FrmAlter : XtraForm
    {
        public FrmAlter()
        {
            InitializeComponent();
        }

        FrmSinglePurchase fsp;
        FrmSingleSale fss;
        FrmSinglePurchaseBack fspb;
        FrmSingleSaleBack fssb;
        int i = 0;
        public FrmAlter(FrmSinglePurchase _fsp)
        {
            InitializeComponent();
            fsp = _fsp;
            i = 1;
        }
        public FrmAlter(FrmSingleSale _fss)
        {
            InitializeComponent();
            fss = _fss;
            i = 2;
        }
        public FrmAlter(FrmSinglePurchaseBack _fspb)
        {
            InitializeComponent();
            fspb = _fspb;
            i = 3;
        }
        public FrmAlter(FrmSingleSaleBack _fssb)
        {
            InitializeComponent();
            fssb = _fssb;
            i = 4;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

            this.DialogResult = System.Windows.Forms.DialogResult.No;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (this.meAlter.Text.Trim() == "")
            {
                XtraMessageBox.Show("请填写修改原因！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (i == 1)
            {
                fsp.alter = this.meAlter.Text;
                this.DialogResult = System.Windows.Forms.DialogResult.Yes;
            }
            else if (i == 2)
            {
                fss.alter = this.meAlter.Text;
                this.DialogResult = System.Windows.Forms.DialogResult.Yes;
            }
            else if (i == 3)
            {
                fspb.alter = this.meAlter.Text;
                this.DialogResult = System.Windows.Forms.DialogResult.Yes;
            }
            else if (i == 4)
            {
                fssb.alter = this.meAlter.Text;
                this.DialogResult = System.Windows.Forms.DialogResult.Yes;
            }
        }
    }
}
