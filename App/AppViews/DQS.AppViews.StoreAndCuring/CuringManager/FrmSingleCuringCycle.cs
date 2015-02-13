using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DQS.Module.Entities;
using DQS.Common;

namespace DQS.AppViews.StoreAndCuring.CuringManager
{
    public partial class FrmSingleCuringCycle : DevExpress.XtraEditors.XtraForm
    {
        private object m_CycleCode;
        private object m_ProductID;

        public FrmSingleCuringCycle()
        {
            InitializeComponent();
        }

        public FrmSingleCuringCycle(object cycleCode, object productID)
        {
            InitializeComponent();

            this.m_CycleCode = cycleCode;
            this.m_ProductID = productID;
        }

        private void FrmSingleCuringCycle_Load(object sender, EventArgs e)
        {
            if (this.m_CycleCode != null && this.m_CycleCode != DBNull.Value)
            {
                this.txtCycleCode.Properties.ReadOnly = true;
                this.txtCycleCode.Text = this.m_CycleCode.ToString();

                BUSCuringCycleEntity entity = new BUSCuringCycleEntity { CycleCode = this.m_CycleCode.ToString() };
                entity.Fetch();

                this.speCycleDays.Value = Convert.ToDecimal(entity.CycleDays);
                if (!entity.IsNullField("CycleRemrk"))
                {
                    this.txtCycleRemrk.Text = entity.CycleRemrk;
                }
            }
            else
            {
                this.txtCycleCode.Text = "YHZQ" + DateTime.Now.ToString("yyyyMMddHHmmss");
                this.txtCycleCode.Select(this.txtCycleCode.Text.Length, 0);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            BUSCuringCycleEntity entity = this.ftPanel.GetEntity() as BUSCuringCycleEntity;
            
            //if (this.speCycleDays.Value < 30)
            //{
            //    XtraMessageBox.Show("养护周期设定至少30天以上。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    return;
            //}
            entity.CycleDays = Convert.ToInt32(this.speCycleDays.Value);
            entity.ProductID = Convert.ToInt32(this.m_ProductID);


            if (this.m_CycleCode != null && this.m_CycleCode != DBNull.Value)
            {
                entity.LastModifyDate = DateTime.Now;
                entity.LastModifyUserID = GlobalItem.g_CurrentUser.UserID;
                entity.Update();
            }
            else
            {
                if (entity.IsNew())
                {
                    entity.CreateDate = DateTime.Now;
                    entity.LastModifyDate = DateTime.Now;
                    entity.CreateUserID = GlobalItem.g_CurrentUser.UserID;
                    entity.LastModifyUserID = GlobalItem.g_CurrentUser.UserID;
                    entity.Save();
                }
                else
                {
                    XtraMessageBox.Show("养护编号已存在。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }

            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}