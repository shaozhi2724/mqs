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
    public partial class UcDbBackMonth : DevExpress.XtraEditors.XtraUserControl
    {
        public event PlanChangedDelegate PlanChanged;

        public UcDbBackMonth()
        {
            InitializeComponent();
        }

        private void UcDbBackMonth_ParentChanged(object sender, EventArgs e)
        {
            if (this.Parent != null)
            {
                //被主窗体显示后
                if (this.PlanChanged != null)
                {
                    PlanArgs args = new PlanArgs();
                    args.PlanType = "月";
                    args.DayInterval = "1";
                    args.MonthInterval = "1";
                    args.PlanString = "每个月 第 1 天";
                    this.PlanChanged(this, args);
                }
            }
        }

        private void speInterval_EditValueChanged(object sender, EventArgs e)
        {
            if (this.PlanChanged != null)
            {
                PlanArgs args = new PlanArgs();
                args.PlanType = "月";
                args.DayInterval = speDays.Value.ToString();
                args.MonthInterval = speMonth.Value.ToString();
                args.PlanString = String.Format("每 {0} 个月 第 {1} 天", speMonth.Value == 1 ? "" : speMonth.Value.ToString(), speDays.Value);
                this.PlanChanged(this, args);
            }
        }
    }
}
