﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DQS.Controls;

namespace DQS.AppViews.WarehouseIn.WarehouseInManager
{
    public partial class FrmDeclined : StandardForm
    {
        public FrmDeclined()
        {
            InitializeComponent();
        }

        private void FrmDeclined_Load(object sender, EventArgs e)
        {
            this.pageNavigator.SortField = "创建日期";
            this.pageNavigator.SortType = "DESC";
            base.InitPage();
        }
    }
}