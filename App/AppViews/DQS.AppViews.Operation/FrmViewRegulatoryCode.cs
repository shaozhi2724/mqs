using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DQS.Module.Entities;
using DevExpress.XtraEditors;

namespace DQS.AppViews.Operation
{
    public partial class FrmViewRegulatoryCode : XtraForm
    {

        public string _Code;

        public FrmViewRegulatoryCode()
        {
            InitializeComponent();
        }

        private void FrmViewRegulatoryCode_Load(object sender, EventArgs e)
        {
            txtCode.Text = _Code;
            LoadRegulatoryCode();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadRegulatoryCode();
        }

        private void LoadRegulatoryCode()
        {
            string code = txtCode.Text.Trim();
            BUSBillEntity bill = new BUSBillEntity { BillCode = code };
            bill.Fetch();
            if (bill.IsNullField("BillID"))
            {
                XtraMessageBox.Show("单号不正确，请重新输入。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                WMSRegulatoryCodeEntity rc = new WMSRegulatoryCodeEntity { ReviewCode = bill.BillCode };
                rc.Fetch();
                if (rc.IsNullField("Code"))
                {
                    XtraMessageBox.Show("该单号无流通监管码。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (code == _Code)
                    {
                        this.DialogResult = DialogResult.Cancel;
                    }
                    return;
                }
                else
                {
                    txtRegulatoryCode.Text = rc.Code;
                }
            }
        }
    }
}
