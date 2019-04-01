using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DQS.AppViews.QualityDocument
{
    public partial class FrmAlter : XtraForm
    {
        public FrmAlter()
        {
            InitializeComponent();
        }

        public string Reason = "";

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
            Reason = meAlter.Text.Trim();
            this.DialogResult = System.Windows.Forms.DialogResult.Yes;
        }
    }
}
