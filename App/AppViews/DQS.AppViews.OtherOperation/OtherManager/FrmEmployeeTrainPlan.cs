using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DQS.Controls;

namespace DQS.AppViews.OtherOperation.OtherManager
{
    public partial class FrmEmployeeTrainPlan : StandardForm
    {
        public FrmEmployeeTrainPlan()
        {
            InitializeComponent();
        }

        private void FrmEmployeeTrainPlan_Load(object sender, EventArgs e)
        {
            base.InitPage();
        }

        protected override void CustomPlanDocument()
        {
            this.SaveDataLog("培训档案");
            object id = gvData.GetFocusedRowCellValue("培训ID");
            if (id != null)
            {
                using (FrmEmployeeTrainPlanDocument frm = new FrmEmployeeTrainPlanDocument(int.Parse(id.ToString())))
                {
                    frm.ShowDialog();
                }
            }
        }
    }
}