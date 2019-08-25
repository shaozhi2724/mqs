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
    public partial class FrmAcceptDeatils : StandardForm
    {
        public FrmAcceptDeatils()
        {
            InitializeComponent();
        }

        private void FrmAcceptDeatils_Load(object sender, EventArgs e)
        {
            base.InitPage();
        }
        protected override void CustomPrint()
        {
            this.SaveDataLog("打印");
            //base.SinglePrint("验收记录查询", 0);
            base.CustomPrint();
        }
    }
}