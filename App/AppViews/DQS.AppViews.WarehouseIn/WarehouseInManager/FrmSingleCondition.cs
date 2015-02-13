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

namespace DQS.AppViews.WarehouseIn.WarehouseInManager
{
    public partial class FrmSingleCondition : DevExpress.XtraEditors.XtraForm
    {
        private int? m_id;

        public FrmSingleCondition()
        {
            InitializeComponent();
        }

        private void FrmSingleCondition_Load(object sender, EventArgs e)
        {
            if (this.Tag != null)
            {
                this.m_id = Convert.ToInt32(this.Tag);

                BUSReceiveAcceptConditionEntity entity = new BUSReceiveAcceptConditionEntity { ConditionID = m_id.Value };
                entity.Fetch();

                this.ftPanel.SetEntity(entity);

                this.txtConditionCode.Enabled = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (!this.ftPanel.ValidateIsNullFields()) return;

            BUSReceiveAcceptConditionEntity entity = this.ftPanel.GetEntity() as BUSReceiveAcceptConditionEntity;
            
            if (this.m_id != null)
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
                    XtraMessageBox.Show("检查编号已存在。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.txtConditionCode.Focus();
                    this.txtConditionCode.Select(this.txtConditionCode.Text.Length, 0);
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