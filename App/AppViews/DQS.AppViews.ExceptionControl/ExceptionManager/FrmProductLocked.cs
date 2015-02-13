using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DQS.Controls;

namespace DQS.AppViews.ExceptionControl.ExceptionManager
{
    public partial class FrmProductLocked : StandardForm
    {
        public FrmProductLocked()
        {
            InitializeComponent();
        }

        private void FrmProductLocked_Load(object sender, EventArgs e)
        {
            base.InitPage();
        }
    }
}