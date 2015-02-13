using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DQS.Module.Entities;
using ORMSCore;
using DevExpress.XtraEditors.Controls;
using DQS.Common;

namespace DQS.Controls
{
    public partial class FrmSingleQualification : DevExpress.XtraEditors.XtraForm
    {
        private int? m_id;

        private int m_QualificationId;
        private string m_TableName;
        private string m_FieldName;
        private string m_CertificateCategory;

        public FrmSingleQualification()
        {
            InitializeComponent();
        }

        public FrmSingleQualification(int id, string tableName, string fieldName, string certificateCategory)
        {
            InitializeComponent();

            this.m_QualificationId = id;
            this.m_TableName = tableName;
            this.m_FieldName = fieldName;
            this.m_CertificateCategory = certificateCategory;

            if (this.m_TableName == "BFI_Product")
            {
                this.txtQualificationCode.Text = "PT" + DateTime.Now.ToString("yyyyMMddHHmmss");
            }
            else if (this.m_TableName == "BFI_Dealer")
            {
                this.txtQualificationCode.Text = "DR" + DateTime.Now.ToString("yyyyMMddHHmmss");
            }
            else if (this.m_TableName == "BFI_Employee")
            {
                this.txtQualificationCode.Text = "EE" + DateTime.Now.ToString("yyyyMMddHHmmss");
            }
            else if (this.m_TableName == "BFI_Salesman")
            {
                this.txtQualificationCode.Text = "SN" + DateTime.Now.ToString("yyyyMMddHHmmss");
            }
            else
            {
                this.txtQualificationCode.Text = "XX" + DateTime.Now.ToString("yyyyMMddHHmmss");
            }
            this.cbxCertificateStyle.CategoryCode = this.m_CertificateCategory;
            this.cbxCertificateStyle.InitSource();
        }

        private void FrmSingleQualification_Load(object sender, EventArgs e)
        {
            chkNoEndDate.Checked = false;
            if (this.Tag != null && this.Tag != DBNull.Value)
            {
                this.m_id = Convert.ToInt32(this.Tag);
                this.txtQualificationCode.Enabled = false;
                BFIQualificationEntity entity = new BFIQualificationEntity { QualificationID = m_id.Value };
                entity.Fetch();

                this.ftPanel.SetEntity(entity);

                this.CustomGetEntity(entity);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ftPanel.ValidateIsNullFields()) return;
            if (this.cbxCertificateStyle.Text.Trim().Length <= 0)
            {
                XtraMessageBox.Show("证书类型不能为空.", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            //if (this.dteValidateDate.Text.Trim().Length <= 0)
            //{
            //    XtraMessageBox.Show("到期日期不能为空.", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    return;
            //}

            BFIQualificationEntity entity = this.ftPanel.GetEntity() as BFIQualificationEntity;

            this.CustomSetEntity(entity);

            if (this.m_id != null)
            {
                if (entity.IsNullField("CreateUserID"))
                {
                    entity.CreateDate = DateTime.Now;
                    entity.CreateUserID = GlobalItem.g_CurrentUser.UserID;
                }
                else
                {
                    entity.LastModifyDate = DateTime.Now;
                    entity.LastModifyUserID = GlobalItem.g_CurrentUser.UserID;
                }
                entity.Update();
            }
            else
            {
                if (entity.IsNew())
                {
                    entity.QualificationBelong = this.m_TableName;
                    entity.BelongID = this.m_QualificationId;
                    entity.BelongTable = this.m_TableName;
                    entity.BelongFieldName = this.m_FieldName;
                    entity.CreateDate = DateTime.Now;
                    entity.CreateUserID = GlobalItem.g_CurrentUser.UserID;
                    entity.Save();
                }
                else
                {
                    XtraMessageBox.Show("档案编号已存在。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
        /// 非文本框赋值
        /// </summary>
        /// <param name="entity">实体</param>
        protected virtual void CustomSetEntity(BFIQualificationEntity entity)
        {
            BFIQualificationEntity oldentity = null;
            if (this.m_id != null)
            {
                oldentity = new BFIQualificationEntity { QualificationID = m_id.Value };
                oldentity.Fetch();
            }
            if (null != oldentity)
            {
                if (!oldentity.IsNullField("CreateUserID"))
                {
                    entity.CreateUserID = oldentity.CreateUserID;
                }
                if (!oldentity.IsNullField("CreateDate"))
                {
                    entity.CreateDate = oldentity.CreateDate;
                }
            }
            entity.CertificateStyle = this.cbxCertificateStyle.Text.Trim();

            if (this.dteIssuingDate.Text.Trim().Length > 0)
            {
                entity.IssuingDate = this.dteIssuingDate.DateTime;
            }

            if (this.dteValidateDate.Text.Trim().Length > 0)
            {
                entity.ValidateDate = this.dteValidateDate.DateTime;
            }
        }

        /// <summary>
        /// 非文本框取值
        /// </summary>
        /// <param name="entity">实体</param>
        protected virtual void CustomGetEntity(BFIQualificationEntity entity)
        {

            if (!entity.IsNullField("CertificateStyle"))
            {
                this.cbxCertificateStyle.Text = entity.CertificateStyle;
            }

            if (!entity.IsNullField("IssuingDate"))
            {
                this.dteIssuingDate.DateTime = entity.IssuingDate;
            }

            if (!entity.IsNullField("ValidateDate"))
            {
                this.dteValidateDate.DateTime = entity.ValidateDate;
                chkNoEndDate.Checked = entity.ValidateDate == DateTime.MaxValue;
            }
        }

        private void cbxCertificateStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cbxCertificateStyle.Text.Trim() != "")
            {
                this.txtQualificationName.Text = this.cbxCertificateStyle.Text;
            }
        }

        public void RemoveQuatificationTypes(List<string> quatificateNames)
        {
            foreach (var quatificateName in quatificateNames)
            {
                cbxCertificateStyle.Properties.Items.Remove(quatificateName);
            }
        }

        private void chkNoEndDate_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNoEndDate.Checked)
            {
                dteValidateDate.DateTime = DateTime.MaxValue;
            }
            else
            {
                dteValidateDate.EditValue = dteValidateDate.OldEditValue;
            }
        }
    }
}