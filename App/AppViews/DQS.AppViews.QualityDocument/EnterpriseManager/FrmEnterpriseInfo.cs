using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DQS.Controls;
using DevExpress.XtraGrid;

namespace DQS.AppViews.QualityDocument.EnterpriseManager
{
    public partial class FrmEnterpriseInfo : StandardForm
    {
        public FrmEnterpriseInfo()
        {
            InitializeComponent();
        }

        private void FrmEnterpriseInfo_Load(object sender, EventArgs e)
        {
            this.pageNavigator.SortField = "最后修改时间";
            this.pageNavigator.SortType = "DESC";
            base.InitPage();
            this.pageNavigator.Visible = false;
            this.gpcQuery.Visible = false;
        }
    }
}