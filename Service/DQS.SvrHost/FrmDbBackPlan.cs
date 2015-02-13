using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace DQS.SvrHost
{
    public partial class FrmDbBackPlan : DevExpress.XtraEditors.XtraForm
    {
        private UcDbBackDay m_UcDbBackDay;
        private UcDbBackWeek m_UcDbBackWeek;
        private UcDbBackMonth m_UcDbBackMonth;

        private PlanArgs m_PlanArgs;

        public FrmDbBackPlan()
        {
            InitializeComponent();

            m_UcDbBackDay = new UcDbBackDay();
            m_UcDbBackDay.PlanChanged += UcDbBack_PlanChanged;
            m_UcDbBackWeek = new UcDbBackWeek();
            m_UcDbBackWeek.PlanChanged += UcDbBack_PlanChanged;
            m_UcDbBackMonth = new UcDbBackMonth();
            m_UcDbBackMonth.PlanChanged += UcDbBack_PlanChanged;
        }

        private void UcDbBack_PlanChanged(object sender, PlanArgs e)
        {
            this.m_PlanArgs = e;
            this.lblRemark.Text = String.Format("在 {0} 的 {1} 执行。将从 {2} 开始使用计划。", e.PlanString, tmeTime.Text, dtStart.Text);
        }

        private void cbbPlanType_SelectedIndexChanged(object sender, EventArgs e)
        {
            gpcPlanType.Controls.Clear();
            switch (cbbPlanType.SelectedIndex)
            {
                case 0:
                    gpcPlanType.Controls.Add(m_UcDbBackDay);
                    break;
                case 1:
                    gpcPlanType.Controls.Add(m_UcDbBackWeek);
                    break;
                case 2:
                    gpcPlanType.Controls.Add(m_UcDbBackMonth);
                    break;
                default:
                    gpcPlanType.Controls.Add(m_UcDbBackDay);
                    break;
            }

            gpcPlanType.Controls[0].Dock = DockStyle.Fill;
        }

        private void FrmDbBackPlan_Load(object sender, EventArgs e)
        {
            gpcPlanType.Controls.Clear();
            gpcPlanType.Controls.Add(m_UcDbBackWeek);
            gpcPlanType.Controls[0].Dock = DockStyle.Fill;

            this.dtStart.DateTime = DateTime.Now;
            this.dtEnd.DateTime = DateTime.Now.AddYears(5);
            this.dtEnd.Enabled = false;
            this.rdgEnd.SelectedIndex = 1;

            this.lblRemark.Text = String.Format("在 每周 星期日 的 {0} 执行。将从 {1} 开始使用计划。",  tmeTime.Text, dtStart.Text);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void rdgEnd_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rdgEnd.SelectedIndex == 0)
            {
                this.dtEnd.Enabled = true;
                this.lblRemark.Text = String.Format("在 {0} 的 {1} 执行。将从 {2} 开始使用计划。{3} 结束。", this.m_PlanArgs.PlanString, tmeTime.Text, dtStart.Text, dtEnd.Text);
            }
            else
            {
                this.dtEnd.Enabled = false;
                this.lblRemark.Text = String.Format("在 {0} 的 {1} 执行。将从 {2} 开始使用计划。", this.m_PlanArgs.PlanString, tmeTime.Text, dtStart.Text);
            }
        }

        private void tmeTime_EditValueChanged(object sender, EventArgs e)
        {
            this.lblRemark.Text = String.Format("在 {0} 的 {1} 执行。将从 {2} 开始使用计划。", this.m_PlanArgs.PlanString, tmeTime.Text, dtStart.Text);
        }

        private void dtStart_EditValueChanged(object sender, EventArgs e)
        {
            this.lblRemark.Text = String.Format("在 {0} 的 {1} 执行。将从 {2} 开始使用计划。", this.m_PlanArgs.PlanString, tmeTime.Text, dtStart.Text);
        }

        private void dtEnd_EditValueChanged(object sender, EventArgs e)
        {
            this.lblRemark.Text = String.Format("在 {0} 的 {1} 执行。将从 {2} 开始使用计划。{3} 结束。", this.m_PlanArgs.PlanString, tmeTime.Text, dtStart.Text, dtEnd.Text);
        }
    }
}