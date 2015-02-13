using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace DQS.SvrHost
{
    public partial class FrmDbSetting : DevExpress.XtraEditors.XtraForm
    {
        public FrmDbSetting()
        {
            InitializeComponent();
        }

        private void FrmDbSetting_Load(object sender, EventArgs e)
        {
            this.lblUserID.Enabled = false;
            this.txtUserID.Enabled = false;

            this.lblPassword.Enabled = false;
            this.txtPassword.Enabled = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}