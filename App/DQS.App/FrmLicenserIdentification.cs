using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DQS.App.Licenser;

namespace DQS.App
{
    public partial class FrmLicenserIdentification : XtraForm
    {
        public FrmLicenserIdentification()
        {
            InitializeComponent();
        }

        private void FrmLicenserIdentification_Load(object sender, EventArgs e)
        {
            txtComputerID.Text = DQSLicenseManager.GetComputerId();
        }

        private void btnBrowser_Click(object sender, EventArgs e)
        {
            fdgLicenseFile.ShowDialog(this);
        }

        private void fdgLicenseFile_FileOk(object sender, CancelEventArgs e)
        {
            txtLicenseFile.Text = fdgLicenseFile.FileName;
            btnRegister.Enabled = true;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string licFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DQS.lic");
            if (File.Exists(licFile))
            {
                if (DialogResult.Yes !=
                    XtraMessageBox.Show("确定覆盖以前的注册信息？", "系统提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    return;
                }
            }
            File.Copy(fdgLicenseFile.FileName, licFile, true);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtComputerID.Text);
        }
    }
}
