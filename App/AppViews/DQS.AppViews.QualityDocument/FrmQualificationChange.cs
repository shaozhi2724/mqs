using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DQS.Module.Entities;
using KellermanSoftware.CompareNetObjects;
using ORMSCore;
using DevExpress.XtraEditors.Controls;
using DQS.Common;

namespace DQS.AppViews.QualityDocument
{
    public partial class FrmQualificationChange : DevExpress.XtraEditors.XtraForm
    {
        private int? m_id;

        private int m_QualificationId;
        private string m_TableName;
        private string m_FieldName;
        private string m_CertificateCategory;
        private Guid _antiApproveID;
        private int m_belongID;

        private ATCAntiApproveQualificationDetailEntity entityChange;

        public FrmQualificationChange()
        {
            InitializeComponent();
        }

        public FrmQualificationChange(Guid antiApproveID, int id, string tableName, string fieldName, string certificateCategory)
        {
            InitializeComponent();
            _antiApproveID = antiApproveID;
            m_belongID = id;
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

        private void FrmQualificationChange_Load(object sender, EventArgs e)
        {
            chkNoEndDate.Checked = false;
            if (this.Tag != null && this.Tag != DBNull.Value)
            {
                this.m_id = Convert.ToInt32(this.Tag);
                this.txtQualificationCode.Enabled = false;

                EntityCollection<ATCAntiApproveQualificationDetailEntity> entities = new EntityCollection<ATCAntiApproveQualificationDetailEntity>();
                entities.Fetch(ATCAntiApproveQualificationDetailEntityFields.AntiApproveID == _antiApproveID
                    & ATCAntiApproveQualificationDetailEntityFields.QualificationID == m_id.Value);
                if (entities.Count > 0)
                {
                    entityChange = entities[0] as ATCAntiApproveQualificationDetailEntity;
                }

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

            if (this.dteValidateDate.Text.Trim().Length <= 0)
            {
                XtraMessageBox.Show("到期日期不能为空，如不确定，可勾选无限期.", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            BFIQualificationEntity entity = this.ftPanel.GetEntity() as BFIQualificationEntity;

            this.CustomSetEntity(entity);

            if (this.m_id != null)
            {
                if (null != entityChange)
                {
                    if (entityChange.IsNullField("CreateUserID"))
                    {
                        entityChange.CreateDate = DateTime.Now;
                        entityChange.CreateUserID = GlobalItem.g_CurrentUser.UserID;
                    }
                    else
                    {
                        entityChange.LastModifyDate = DateTime.Now;
                        entityChange.LastModifyUserID = GlobalItem.g_CurrentUser.UserID;
                    }
                }

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
                BFIQualificationEntity oldentity = new BFIQualificationEntity{ QualificationID = m_id.Value};
                oldentity.Fetch();

                if (oldentity.IsNullField("CertificateNo"))
                {
                    oldentity.CertificateNo = "";
                }

                if (oldentity.IsNullField("IssuingAuthority"))
                {
                    oldentity.IssuingAuthority = "";
                }

                if (oldentity.IsNullField("QualificationRemark"))
                {
                    oldentity.QualificationRemark = "";
                }

                bool isChanged = oldentity.CertificateNo != entity.CertificateNo
                               || oldentity.IssuingAuthority != entity.IssuingAuthority
                               || oldentity.QualificationRemark != entity.QualificationRemark;
                if ((!oldentity.IsNullField("IssuingDate") && entity.IsNullField("IssuingDate"))
                    ||(!oldentity.IsNullField("ValidateDate") && entity.IsNullField("ValidateDate"))
                    ||(oldentity.IsNullField("ValidateDate") && !entity.IsNullField("ValidateDate"))
                    ||(oldentity.IsNullField("ValidateDate") && !entity.IsNullField("ValidateDate")))
                {
                    isChanged = true;
                }
                if (!oldentity.IsNullField("IssuingDate") && !entity.IsNullField("IssuingDate"))
                {
                    if (oldentity.IssuingDate != entity.IssuingDate)
                    {
                        isChanged = true;
                    }
                }
                if (!oldentity.IsNullField("ValidateDate") && !entity.IsNullField("ValidateDate"))
                {
                    if (oldentity.ValidateDate != entity.ValidateDate)
                    {
                        isChanged = true;
                    }
                }

                if (isChanged)
                {
                    entityChange.LastModifyDate = DateTime.Now;
                    entityChange.LastModifyUserID = GlobalItem.g_CurrentUser.UserID;
                    entityChange.Update();
/*
                    ATCAntiApproveQualificationActionEntity actionEntity = new ATCAntiApproveQualificationActionEntity();
                    actionEntity.ActionID = Guid.NewGuid();
                    actionEntity.AntiApproveID = _antiApproveID;
                    actionEntity.BelongID = m_belongID;
                    actionEntity.QualificationBelong = m_TableName;
                    actionEntity.QualificationID = m_id.Value;
                    actionEntity.QualificationName = txtQualificationName.Text.Trim();
                    actionEntity.QualificationCode = txtQualificationCode.Text.Trim();
                    actionEntity.Action = 2;
                    actionEntity.ActionRemark = string.Format("修改电子档案: {0}(编号: {1})", txtQualificationName.Text.Trim(), txtQualificationCode.Text.Trim());
                    actionEntity.CreateUserID = GlobalItem.g_CurrentUser.UserID;
                    actionEntity.CreateDate = DateTime.Now;
                    actionEntity.Save();
*/
                }
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
                    entity.Fetch();

                    ATCAntiApproveQualificationActionEntity actionEntity = new ATCAntiApproveQualificationActionEntity();
                    actionEntity.ActionID = Guid.NewGuid();
                    actionEntity.AntiApproveID = _antiApproveID;
                    actionEntity.BelongID = m_belongID;
                    actionEntity.QualificationBelong = m_TableName;
                    actionEntity.QualificationID = entity.QualificationID;
                    actionEntity.QualificationName = txtQualificationName.Text.Trim();
                    actionEntity.QualificationCode = txtQualificationCode.Text.Trim();
                    actionEntity.Action = 1;
                    actionEntity.ActionRemark = string.Format("新建电子档案: {0}(编号: {1})", txtQualificationName.Text.Trim(), txtQualificationCode.Text.Trim());
                    actionEntity.CreateUserID = GlobalItem.g_CurrentUser.UserID;
                    actionEntity.CreateDate = DateTime.Now;
                    actionEntity.Save();
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
            entity.CertificateStyle = this.cbxCertificateStyle.Text.Trim();

            if (this.dteIssuingDate.Text.Trim().Length > 0)
            {
                entity.IssuingDate = this.dteIssuingDate.DateTime;
            }

            if (this.dteValidateDate.Text.Trim().Length > 0)
            {
                entity.ValidateDate = this.dteValidateDate.DateTime;
            }

            if (null != entityChange)
            {
                entityChange.CertificateStyle = this.cbxCertificateStyle.Text.Trim();
                entityChange.CertificateNo = txtCertificateNo.Text.Trim();
                entityChange.IssuingAuthority = txtIssuingAuthority.Text.Trim();
                entityChange.QualificationRemark = txtQualificationRemark.Text.Trim();
                if (this.dteIssuingDate.Text.Trim().Length > 0)
                {
                    entityChange.IssuingDate = this.dteIssuingDate.DateTime;
                }

                if (this.dteValidateDate.Text.Trim().Length > 0)
                {
                    entityChange.ValidateDate = this.dteValidateDate.DateTime;
                }
            }
        }

        /// <summary>
        /// 非文本框取值
        /// </summary>
        /// <param name="entity">实体</param>
        protected virtual void CustomGetEntity(BFIQualificationEntity entity)
        {
            if (null != entityChange)
            {
                if (!entityChange.IsNullField("CertificateStyle"))
                {
                    this.cbxCertificateStyle.Text = entityChange.CertificateStyle;
                }
                if (!entityChange.IsNullField("QualificationRemark"))
                {
                    txtQualificationRemark.Text = entityChange.QualificationRemark;
                }

                if (!entityChange.IsNullField("IssuingDate"))
                {
                    this.dteIssuingDate.DateTime = entityChange.IssuingDate;
                }

                if (!entityChange.IsNullField("ValidateDate"))
                {
                    this.dteValidateDate.DateTime = entityChange.ValidateDate;
                    chkNoEndDate.Checked = entityChange.ValidateDate == DateTime.MaxValue;
                }
            }
            else
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
                if (!entity.IsNullField("QualificationRemark"))
                {
                    txtQualificationRemark.Text = entity.QualificationRemark;
                }
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