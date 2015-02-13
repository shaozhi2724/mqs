using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace DQS.SvrHost
{
    public partial class UcDbBackWeek : DevExpress.XtraEditors.XtraUserControl
    {
        public event PlanChangedDelegate PlanChanged;

        public UcDbBackWeek()
        {
            InitializeComponent();
        }

        private void UcDbBackWeek_ParentChanged(object sender, EventArgs e)
        {
            if (this.Parent != null)
            {
                //被主窗体显示后
                if (this.PlanChanged != null)
                {
                    PlanArgs args = new PlanArgs();
                    args.PlanType = "周";
                    args.WeekInterval = "1";
                    args.Weeks = new string[] { "星期日" };
                    args.PlanString = "每周 星期日";
                    this.PlanChanged(this, args);
                }
            }
        }

        private void chkWeek_CheckedChanged(object sender, EventArgs e)
        {
            bool isCheckOne = false;
            foreach (Control chk in this.Controls)
            {
                if (chk is CheckEdit)
                {
                    CheckEdit c = chk as CheckEdit;
                    if (c.Checked)
                    {
                        isCheckOne = true;
                    }
                }
            }

            if (!isCheckOne)
            {

                if (sender is CheckEdit)
                {
                    //判定必须最少有一个选中
                    XtraMessageBox.Show("必须至少选中一天", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    (sender as CheckEdit).Checked = true;
                }
            }

            if (this.PlanChanged != null)
            {
                PlanArgs args = new PlanArgs();
                args.PlanType = "周";
                args.WeekInterval = speWeek.Value.ToString();

                List<string> weeks = new List<string>();
                foreach (Control chk in this.Controls)
                {
                    if (chk is CheckEdit)
                    {
                        CheckEdit c = chk as CheckEdit;
                        if (c.Checked)
                        {
                            weeks.Add(c.Text);
                        }
                    }
                }
                args.Weeks = weeks.ToArray();
                args.PlanString = String.Format("每{0}周 {1}", speWeek.Value == 1 ? "" : " " + speWeek.Value + " ", string.Join(" ", args.Weeks));
                this.PlanChanged(this, args);
            }
        }
    }
}
