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

namespace DQS.AppViews.QualityDocument.EnterpriseManager
{
    public partial class FrmSingleDepartment : XtraForm
    {
        private int? m_id;

        public FrmSingleDepartment()
        {
            InitializeComponent();
        }
        
        private void FrmSingleDepartment_Load(object sender, EventArgs e)
        {
            if (this.Tag != null)
            {
                this.m_id = Convert.ToInt32(this.Tag);

                BFIDepartmentEntity entity = new BFIDepartmentEntity { DepartmentID = m_id.Value };
                entity.Fetch();

                this.ftPanel.SetEntity(entity);

                this.txtDepartmentCode.Enabled = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ftPanel.ValidateIsNullFields()) return;
            
            BFIDepartmentEntity entity = this.ftPanel.GetEntity() as BFIDepartmentEntity;
            
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
                    XtraMessageBox.Show("部门编号已存在。","警告",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
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