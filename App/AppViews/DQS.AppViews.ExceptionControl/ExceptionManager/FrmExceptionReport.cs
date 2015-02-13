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
    public partial class FrmExceptionReport : StandardForm
    {
        public FrmExceptionReport()
        {
            InitializeComponent();
        }

        private void FrmExceptionReport_Load(object sender, EventArgs e)
        {
            base.InitPage();
        }
    }
}