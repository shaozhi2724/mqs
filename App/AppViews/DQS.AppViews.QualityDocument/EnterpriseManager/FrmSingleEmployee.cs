using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ORMSCore;
using DQS.Module.Entities;
using DQS.Common;

namespace DQS.AppViews.QualityDocument.EnterpriseManager
{
    public partial class FrmSingleEmployee : DevExpress.XtraEditors.XtraForm
    {
        private int? m_id;

        public FrmSingleEmployee()
        {
            InitializeComponent();
        }

        private void FrmSingleEmployee_Load(object sender, EventArgs e)
        {
            this.cbxDepartment.InitSource();
            this.cbxPostName.InitSource();

            if (this.Tag != null)
            {
                this.m_id = Convert.ToInt32(this.Tag);

                BFIEmployeeEntity entity = new BFIEmployeeEntity { EmployeeID = m_id.Value };
                entity.Fetch();

                this.ftPanel.SetEntity(entity);

                this.txtEmployeeCode.Enabled = false;

                this.CustomGetEntity(entity);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ftPanel.ValidateIsNullFields()) return;

            BFIEmployeeEntity entity = this.ftPanel.GetEntity() as BFIEmployeeEntity;

            this.CustomSetEntity(entity);

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
                    XtraMessageBox.Show("员工编号已存在。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }

            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 非文本框取值
        /// </summary>
        /// <param name="entity">实体</param>
        protected virtual void CustomGetEntity(BFIEmployeeEntity entity)
        {
            rgpSex.SelectedIndex = entity.Sex.Trim() == "男" ? 0 : 1;

            if (!entity.IsNullField("Birthday"))
            {
                dteBirthday.DateTime = entity.Birthday;
            }

            if (!entity.IsNullField("EntryDate"))
            {
                dteEntryDate.DateTime = entity.EntryDate;
            }

            if (!entity.IsNullField("FinishSchoolDate"))
            {
                dteFinishSchoolDate.DateTime = entity.FinishSchoolDate;
            }

            if (!entity.IsNullField("DepartmentID"))
            {
                this.cbxDepartment.SelectedValue = entity.DepartmentID;
            }

            if (!entity.IsNullField("MaritalStatus"))
            {
                this.cbxMaritalStatus.Text = entity.MaritalStatus;
            }

            if (!entity.IsNullField("PostName"))
            {
                this.cbxPostName.Text = entity.PostName;
            }
        }

        /// <summary>
        /// 非文本框赋值
        /// </summary>
        /// <param name="entity">实体</param>
        protected virtual void CustomSetEntity(BFIEmployeeEntity entity)
        {
            entity.Sex = rgpSex.Text;

            if (!string.IsNullOrEmpty(dteBirthday.Text.Trim()))
            {
                entity.Birthday = dteBirthday.DateTime;
            }

            if (!string.IsNullOrEmpty(dteEntryDate.Text.Trim()))
            {
                entity.EntryDate = dteEntryDate.DateTime;
            }

            if (!string.IsNullOrEmpty(dteFinishSchoolDate.Text.Trim()))
            {
                entity.FinishSchoolDate = dteFinishSchoolDate.DateTime;
            }

            if (this.cbxDepartment.SelectedValue != null)
            {
                entity.DepartmentID = Convert.ToInt32(this.cbxDepartment.SelectedValue);
            }

            if (this.cbxPostName.SelectedValue != null)
            {
                entity.PostName = this.cbxPostName.Text;
            }

            entity.MaritalStatus = this.cbxMaritalStatus.Text.Trim();
        }

        
    }
}