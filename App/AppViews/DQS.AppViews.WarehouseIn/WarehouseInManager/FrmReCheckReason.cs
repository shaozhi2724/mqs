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
    public partial class FrmReCheckReason : Form
    {

        public string reason;

        public FrmReCheckReason()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            reason = txtReason.Text.Trim();
            this.DialogResult = DialogResult.Yes;
        }
    }
}
