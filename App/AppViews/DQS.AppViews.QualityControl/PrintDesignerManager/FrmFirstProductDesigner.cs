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
    public partial class FrmFirstProductDesigner : DesignerForm
    {
        public FrmFirstProductDesigner()
        {
            InitializeComponent();
        }

        private void FrmFirstProductDesigner_Load(object sender, EventArgs e)
        {
            base.InitPage();
        }
    }
}