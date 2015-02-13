using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DQS.Common;

namespace DQS.App
{
    public partial class FrmWarningMessage : DevExpress.XtraEditors.XtraForm
    {
        private DataSet m_DataSet;

        public FrmWarningMessage(DataSet ds)
        {
            InitializeComponent();
            this.m_DataSet = ds;
        }

        private void FrmWarningMessage_Load(object sender, EventArgs e)
        {
            int x = Screen.PrimaryScreen.WorkingArea.Size.Width - this.Width - 10;
            int y = Screen.PrimaryScreen.WorkingArea.Size.Height - this.Height - 10;
            this.SetDesktopLocation(x, y);

            Win32API.SetWindowPos(this.Handle, 100, Screen.PrimaryScreen.Bounds.Width - this.Width, Screen.PrimaryScreen.Bounds.Height - this.Height - 30, 50, 50, 1);
            Win32API.AnimateWindow(this.Handle, 500, Win32API.AW_VER_NEGATIVE);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            //设置最前
            this.TopMost = false;
            this.BringToFront();
            this.TopMost = true;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void hleWarning_OpenLink(object sender, DevExpress.XtraEditors.Controls.OpenLinkEventArgs e)
        {
            using (FrmWarningShow frmWarningShow = new FrmWarningShow(this.m_DataSet))
            {
                this.Visible = false;
                frmWarningShow.ShowDialog();
            }
            this.Close();
        }
    }
}