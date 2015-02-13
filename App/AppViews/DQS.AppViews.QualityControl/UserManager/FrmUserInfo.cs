using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DQS.Controls;

namespace DQS.AppViews.QualityControl.UserManager
{
    public partial class FrmUserInfo : StandardForm
    {
        public FrmUserInfo()
        {
            InitializeComponent();
        }

        private void FrmUserInfo_Load(object sender, EventArgs e)
        {
            base.InitPage();
        }
    }
}