using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace DQS.AppViews.OtherOperation.Code
{
    public partial class FrmCorpCodeSetting : XtraForm
    {
        string _file = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "CorpCode.dat");
        public FrmCorpCodeSetting()
        {
            InitializeComponent();
        }

        private void FrmCorpCodeSetting_Load(object sender, EventArgs e)
        {
            if (!File.Exists(_file))
            {
                File.AppendAllText(_file, "");
            }
            var corpCode = File.ReadAllText(_file);
            txtCorpCode.Text = corpCode;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var corpCode = txtCorpCode.Text.Trim();
            File.WriteAllText(_file, corpCode);
            XtraMessageBox.Show("企业编码保存成功！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
