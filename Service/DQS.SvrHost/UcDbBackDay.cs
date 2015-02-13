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
    public class PlanArgs : EventArgs
    {
        public string PlanType { get; set; }

        public string WeekInterval { get; set; }

        public string[] Weeks { get; set; }

        public string MonthInterval { get; set; }

        public string DayInterval { get; set; }

        public string PlanString { get; set; }
    }

    public delegate void PlanChangedDelegate(object sender, PlanArgs e);

    public partial class UcDbBackDay : DevExpress.XtraEditors.XtraUserControl
    {
        public event PlanChangedDelegate PlanChanged;

        public UcDbBackDay()
        {
            InitializeComponent();
        }

        private void UcDbBackDay_ParentChanged(object sender, EventArgs e)
        {
            if (this.Parent != null)
            {
                //被主窗体显示后
                if (this.PlanChanged != null)
                {
                    PlanArgs args = new PlanArgs();
                    args.PlanType = "天";
                    args.DayInterval = "1";
                    args.PlanString = "每天";
                    this.PlanChanged(this, args);
                }
            }
        }

        private void speDays_EditValueChanged(object sender, EventArgs e)
        {
            if (this.PlanChanged != null)
            {
                PlanArgs args = new PlanArgs();
                args.PlanType = "天";
                args.DayInterval = speDays.Value.ToString();
                args.PlanString = String.Format("每{0}天", speDays.Value == 1 ? "" : " " + speDays.Value + " ");
                this.PlanChanged(this, args);
            }
        }
    }
}
