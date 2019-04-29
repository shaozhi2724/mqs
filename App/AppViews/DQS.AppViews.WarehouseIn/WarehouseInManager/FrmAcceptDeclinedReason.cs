using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DQS.AppViews.WarehouseIn.WarehouseInManager
{
    public partial class FrmAcceptDeclinedReason : XtraForm
    {
        public FrmAcceptDeclinedReason()
        {
            InitializeComponent();
        }

        public String reason;
        public String handle;

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtreason.Text == "")
            {
                MessageBox.Show("拒收原因不能为空.");
                return;
            }
            reason = txtreason.Text;
            handle = txthandle.Text;
            this.DialogResult = DialogResult.OK;
        }
    }
}
