using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DQS.App
{
    public partial class FrmProduct : XtraForm
    {
        public FrmProduct()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            using (FrmProductCheck frm = new FrmProductCheck())
            {
                frm.ShowDialog();
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            using (FrmCreateXml frm = new FrmCreateXml())
            {
                frm.ShowDialog();
            }
        }
    }
}
