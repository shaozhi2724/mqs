﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DQS.Controls;

namespace DQS.AppViews.QualityControl.PrintDesignerManager
{
    public partial class FrmPurchaseBackDesigner : DesignerForm
    {
        public FrmPurchaseBackDesigner()
        {
            InitializeComponent();
        }

        private void FrmPurchaseBackDesigner_Load(object sender, EventArgs e)
        {
            base.InitPage();
        }
    }
}