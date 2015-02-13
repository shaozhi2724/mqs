using System;
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
    public partial class FrmSaleDesigner : DesignerForm
    {
        public FrmSaleDesigner()
        {
            InitializeComponent();
        }

        private void FrmSaleDesigner_Load(object sender, EventArgs e)
        {
            base.InitPage();
        }
    }
}