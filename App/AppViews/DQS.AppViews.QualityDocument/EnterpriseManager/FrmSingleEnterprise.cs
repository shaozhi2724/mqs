using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DQS.Controls;
using DQS.Module.Entities;
using DQS.Common;
using ORMSCore;

namespace DQS.AppViews.QualityDocument.EnterpriseManager
{
    public partial class FrmSingleEnterprise : DevExpress.XtraEditors.XtraForm
    {
        private int? m_id;

        public FrmSingleEnterprise()
        {
            InitializeComponent();
        }

        private void FrmSingleEnterprise_Load(object sender, EventArgs e)
        {
            this.cbxEnterpriseLevel.InitSource();
            this.cbxEnterpriseType.InitSource();
            this.cbxEnterpriseStyle.InitSource();
            //this.cbxIndustryStyle.InitSource();
            cbxIndustryStyle.Properties.Items.Add("批发");
            cbxIndustryStyle.Properties.Items.Add("零售");
            
            if (this.Tag != null)
            {
                this.m_id = Convert.ToInt32(this.Tag);

                BFIEnterpriseEntity entity = new BFIEnterpriseEntity { EnterpriseID = m_id.Value };
                entity.Fetch();

                this.ftPanel.SetEntity(entity);

                this.CustomGetEntity(entity);
            }
            RenderRequiredFields();
        }

        private void RenderRequiredFields()
        {
            foreach (Control control in layControl.Controls)
            {
                if (control is TextBoxEx)
                {
                    TextBoxEx ctl = ((TextBoxEx)control);
                    if (ctl.IsNullValidate)
                    {
                        layControl.GetItemByControl(ctl).AppearanceItemCaption.ForeColor = Color.Red;
                    }
                }
                if (control is ComboBoxEdit)
                {
                    var ctl = ((ComboBoxEdit)control);
                    if (ctl.Properties.AllowNullInput == DefaultBoolean.False)
                    {
                        layControl.GetItemByControl(ctl).AppearanceItemCaption.ForeColor = Color.Red;
                    }
                }
                if (control is DateEdit)
                {
                    var ctl = ((DateEdit)control);
                    if (ctl.Properties.AllowNullInput == DefaultBoolean.False)
                    {
                        layControl.GetItemByControl(ctl).AppearanceItemCaption.ForeColor = Color.Red;
                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ftPanel.ValidateIsNullFields()) return;
            if (string.IsNullOrWhiteSpace(datLicenseValidateDate.Text))
            {
                XtraMessageBox.Show(datLicenseValidateDate.Properties.NullValuePrompt, "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                datLicenseValidateDate.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(datBusinessValidateDate.Text))
            {
                XtraMessageBox.Show(datBusinessValidateDate.Properties.NullValuePrompt, "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                datBusinessValidateDate.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(datGSPValidateDate.Text))
            {
                XtraMessageBox.Show(datGSPValidateDate.Properties.NullValuePrompt, "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                datGSPValidateDate.Focus();
                return;
            }
            //if (null == cbxEnterpriseType.SelectedValue)
            //{
            //    XtraMessageBox.Show(cbxEnterpriseType.Properties.NullValuePrompt, "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    cbxEnterpriseType.Focus();
            //    return;
            //}
            //if (null == cbxIndustryStyle.SelectedValue)
            //{
            //    XtraMessageBox.Show(cbxIndustryStyle.Properties.NullValuePrompt, "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    cbxIndustryStyle.Focus();
            //    return;
            //}
            if (null == cbxEnterpriseStyle.SelectedValue)
            {
                XtraMessageBox.Show(cbxEnterpriseStyle.Properties.NullValuePrompt, "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cbxEnterpriseStyle.Focus();
                return;
            }
            if (null == cbxEnterpriseLevel.SelectedValue)
            {
                XtraMessageBox.Show(cbxEnterpriseLevel.Properties.NullValuePrompt, "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cbxEnterpriseLevel.Focus();
                return;
            }
            BFIEnterpriseEntity entity = this.ftPanel.GetEntity() as BFIEnterpriseEntity;
            this.CustomSetEntity(entity);

            if (this.m_id != null)
            {

                string sqlString = @"
INSERT INTO dbo.BFI_EnterpriseChangeHistory 
(
    EnterpriseID,
    EnterpriseCode,
    EnterpriseName,
    EnterpriseSpell,
    EnterpriseAddress,
    EnterprisePhone,
    EnterprisePostalCode,
    EnterpriseFaxNo,
    EnterpriseMail,
    EnterpriseWebSiteUrl,
    ContactPerson,
    ContactPersonSpell,
    ContactPhone,
    LegalPerson,
    LegalSpell,
    LegalPhone,
    OrganizationCode,
    RegisterAddress,
    RegisterData,
    RegisterCapital,
    RegisterLicenseNo,
    LicenseValidateDate,
    TradeLicenseValidateDate,
    RegisterTaxNo,
    TaxValidateDate,
    AccountBankName,
    AccountNo,
    AccountBankCode,
    BusinessRange,
    IndustryStyle,
    EnterpriseLevel,
    EnterpriseStyle,
    EnterpriseType,
    EmployeeNum,
    ParentEnterpriseID,
    CreateUserID,
    CreateDate,
    LastModifyUserID,
    LastModifyDate,
    EnterpriseRemark,
    Reservation1,
    Reservation2,
    Reservation3,
    Reservation4,
    Reservation5,
    Reservation6,
    Reservation7,
    Reservation8,
    Reservation9,
    Reservation10,
    ChangeUserName,
    ChangeDate,
GSPValidateDate
)
SELECT
    EnterpriseID,
    EnterpriseCode,
    EnterpriseName,
    EnterpriseSpell,
    EnterpriseAddress,
    EnterprisePhone,
    EnterprisePostalCode,
    EnterpriseFaxNo,
    EnterpriseMail,
    EnterpriseWebSiteUrl,
    ContactPerson,
    ContactPersonSpell,
    ContactPhone,
    LegalPerson,
    LegalSpell,
    LegalPhone,
    OrganizationCode,
    RegisterAddress,
    RegisterData,
    RegisterCapital,
    RegisterLicenseNo,
    LicenseValidateDate,
    TradeLicenseValidateDate,
    RegisterTaxNo,
    TaxValidateDate,
    AccountBankName,
    AccountNo,
    AccountBankCode,
    BusinessRange,
    IndustryStyle,
    EnterpriseLevel,
    EnterpriseStyle,
    EnterpriseType,
    EmployeeNum,
    ParentEnterpriseID,
    CreateUserID,
    CreateDate,
    LastModifyUserID,
    LastModifyDate,
    EnterpriseRemark,
    Reservation1,
    Reservation2,
    Reservation3,
    Reservation4,
    Reservation5,
    Reservation6,
    Reservation7,
    Reservation8,
    Reservation9,
    Reservation10,
    '{1}',
    GETDATE(),
GSPValidateDate
FROM dbo.BFI_Enterprise
WHERE EnterpriseID={0}
";
                string changeUserName = null == GlobalItem.g_CurrentEmployee
                    ? GlobalItem.g_CurrentUser.UserName
                    : GlobalItem.g_CurrentEmployee.EmployeeName;
                string sql = string.Format(sqlString, m_id.Value, changeUserName);
                SqlCommand command = new SqlConnection(GlobalItem.g_DbConnectStrings).CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = sql;
                using (command.Connection)
                {
                    try
                    {
                        command.Connection.Open();
                        command.ExecuteNonQuery();
                        command.Dispose();
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                    finally
                    {
                        if (command.Connection.State != ConnectionState.Closed)
                        {
                            command.Connection.Close();
                        }
                    }
                }
                BFIEnterpriseEntity oldEntity = new BFIEnterpriseEntity { EnterpriseID = m_id.Value };
                oldEntity.Fetch();

                #region 营业执照到期日修改
                DateTime oldLicenseValidateDate = oldEntity.LicenseValidateDate;

                if (entity.LicenseValidateDate != oldLicenseValidateDate)
                {
                    //解锁
                    if (entity.LicenseValidateDate > DateTime.Today)
                    {
                        BFIEnterpriseLicenseLockHistoryEntity lockHistory = new BFIEnterpriseLicenseLockHistoryEntity();
                        lockHistory.ActionName = "解锁";
                        lockHistory.ActionDate = DateTime.Today;
                        lockHistory.OldLicenseValidateDate = oldLicenseValidateDate;
                        lockHistory.NewLicenseValidateDate = entity.LicenseValidateDate;
                        lockHistory.LockDate = oldLicenseValidateDate;
                        lockHistory.UnLockDate = DateTime.Today;
                        lockHistory.CreateUserName = GlobalItem.g_CurrentEmployee == null
                            ? GlobalItem.g_CurrentUser.UserName
                            : GlobalItem.g_CurrentEmployee.EmployeeName;
                        lockHistory.Save();
                    }
                    //锁定
                    if (entity.LicenseValidateDate < DateTime.Today)
                    {
                        BFIEnterpriseLicenseLockHistoryEntity lockHistory = new BFIEnterpriseLicenseLockHistoryEntity();
                        lockHistory.ActionName = "锁定";
                        lockHistory.ActionDate = DateTime.Today;
                        lockHistory.OldLicenseValidateDate = oldLicenseValidateDate;
                        lockHistory.NewLicenseValidateDate = entity.LicenseValidateDate;
                        lockHistory.LockDate = entity.LicenseValidateDate;
                        lockHistory.CreateUserName = GlobalItem.g_CurrentEmployee == null
                            ? GlobalItem.g_CurrentUser.UserName
                            : GlobalItem.g_CurrentEmployee.EmployeeName;
                        lockHistory.Save();
                    }
                }
                #endregion

                #region 经营许可证到期日修改
                DateTime oldTradeLicenseValidateDate = oldEntity.TradeLicenseValidateDate;

                if (entity.TradeLicenseValidateDate != oldTradeLicenseValidateDate)
                {
                    //解锁
                    if (entity.TradeLicenseValidateDate > DateTime.Today)
                    {
                        BFIEnterpriseTradeLicenseLockHistoryEntity lockHistory = new BFIEnterpriseTradeLicenseLockHistoryEntity();
                        lockHistory.ActionName = "解锁";
                        lockHistory.ActionDate = DateTime.Today;
                        lockHistory.OldLicenseValidateDate = oldTradeLicenseValidateDate;
                        lockHistory.NewLicenseValidateDate = entity.TradeLicenseValidateDate;
                        lockHistory.LockDate = oldTradeLicenseValidateDate;
                        lockHistory.UnLockDate = DateTime.Today;
                        lockHistory.CreateUserName = GlobalItem.g_CurrentEmployee == null
                            ? GlobalItem.g_CurrentUser.UserName
                            : GlobalItem.g_CurrentEmployee.EmployeeName;
                        lockHistory.Save();
                    }
                    //锁定
                    if (entity.TradeLicenseValidateDate < DateTime.Today)
                    {
                        BFIEnterpriseTradeLicenseLockHistoryEntity lockHistory = new BFIEnterpriseTradeLicenseLockHistoryEntity();
                        lockHistory.ActionName = "锁定";
                        lockHistory.ActionDate = DateTime.Today;
                        lockHistory.OldLicenseValidateDate = oldTradeLicenseValidateDate;
                        lockHistory.NewLicenseValidateDate = entity.TradeLicenseValidateDate;
                        lockHistory.LockDate = entity.TradeLicenseValidateDate;
                        lockHistory.CreateUserName = GlobalItem.g_CurrentEmployee == null
                            ? GlobalItem.g_CurrentUser.UserName
                            : GlobalItem.g_CurrentEmployee.EmployeeName;
                        lockHistory.Save();
                    }
                }
                #endregion

                #region GSP证书到期日修改
                DateTime oldGSPValidateDate = oldEntity.GSPValidateDate;

                if (entity.GSPValidateDate != oldGSPValidateDate)
                {
                    //解锁
                    if (entity.GSPValidateDate > DateTime.Today)
                    {
                        BFIEnterpriseGSPLockHistoryEntity lockHistory = new BFIEnterpriseGSPLockHistoryEntity();
                        lockHistory.ActionName = "解锁";
                        lockHistory.ActionDate = DateTime.Today;
                        lockHistory.OldLicenseValidateDate = oldTradeLicenseValidateDate;
                        lockHistory.NewLicenseValidateDate = entity.TradeLicenseValidateDate;
                        lockHistory.LockDate = oldTradeLicenseValidateDate;
                        lockHistory.UnLockDate = DateTime.Today;
                        lockHistory.CreateUserName = GlobalItem.g_CurrentEmployee == null
                            ? GlobalItem.g_CurrentUser.UserName
                            : GlobalItem.g_CurrentEmployee.EmployeeName;
                        lockHistory.Save();
                    }
                    //锁定
                    if (entity.GSPValidateDate < DateTime.Today)
                    {
                        BFIEnterpriseGSPLockHistoryEntity lockHistory = new BFIEnterpriseGSPLockHistoryEntity();
                        lockHistory.ActionName = "锁定";
                        lockHistory.ActionDate = DateTime.Today;
                        lockHistory.OldLicenseValidateDate = oldTradeLicenseValidateDate;
                        lockHistory.NewLicenseValidateDate = entity.TradeLicenseValidateDate;
                        lockHistory.LockDate = entity.TradeLicenseValidateDate;
                        lockHistory.CreateUserName = GlobalItem.g_CurrentEmployee == null
                            ? GlobalItem.g_CurrentUser.UserName
                            : GlobalItem.g_CurrentEmployee.EmployeeName;
                        lockHistory.Save();
                    }
                }
                #endregion
                entity.LastModifyDate = DateTime.Now;
                entity.LastModifyUserID = GlobalItem.g_CurrentUser.UserID;
                entity.Update();
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
        protected virtual void CustomGetEntity(BFIEnterpriseEntity entity)
        {
            if (!entity.IsNullField("EnterpriseType"))
            {
                this.cbxEnterpriseType.Text = entity.EnterpriseType;
            }

            if (!entity.IsNullField("EnterpriseStyle"))
            {
                this.cbxEnterpriseStyle.Text = entity.EnterpriseStyle;
            }

            if (!entity.IsNullField("EnterpriseLevel"))
            {
                this.cbxEnterpriseLevel.Text = entity.EnterpriseLevel;
            }

            if (!entity.IsNullField("IndustryStyle"))
            {
                this.cbxIndustryStyle.Text = entity.IndustryStyle;
            }

            if (!entity.IsNullField("RegisterData"))
            {
                this.dteRegisterData.DateTime = entity.RegisterData;
            }

            if (!entity.IsNullField("TaxValidateDate"))
            {
                this.datTaxValidateDate.DateTime = entity.TaxValidateDate;
            }

            if (!entity.IsNullField("LicenseValidateDate"))
            {
                this.datLicenseValidateDate.DateTime = entity.LicenseValidateDate;
            }

            if (!entity.IsNullField("TradeLicenseValidateDate"))
            {
                this.datBusinessValidateDate.DateTime = entity.TradeLicenseValidateDate;
            }

            if (!entity.IsNullField("GSPValidateDate"))
            {
                this.datGSPValidateDate.DateTime = entity.GSPValidateDate;
            }

        }

        /// <summary>
        /// 非文本框赋值
        /// </summary>
        /// <param name="entity">实体</param>
        protected virtual void CustomSetEntity(BFIEnterpriseEntity entity)
        {
            if (this.cbxEnterpriseLevel.Text.Trim().Length > 0)
            {
                entity.EnterpriseLevel = this.cbxEnterpriseLevel.Text.Trim();
            }

            if (this.cbxEnterpriseType.Text.Trim().Length > 0)
            {
                entity.EnterpriseType = this.cbxEnterpriseType.Text.Trim();
            }

            if (this.cbxEnterpriseStyle.SelectedIndex >= 0)
            {
                entity.EnterpriseStyle = this.cbxEnterpriseStyle.Text.Trim();
            }

            if (this.cbxIndustryStyle.SelectedIndex >= 0)
            {
                entity.IndustryStyle = this.cbxIndustryStyle.Text.Trim();
            }

            if (this.dteRegisterData.Text.Trim().Length > 0)
            {
                entity.RegisterData = this.dteRegisterData.DateTime;
            }

            if (this.datTaxValidateDate.Text.Trim().Length > 0)
            {
                entity.TaxValidateDate = this.datTaxValidateDate.DateTime;
            }

            if (this.datLicenseValidateDate.Text.Trim().Length > 0)
            {
                entity.LicenseValidateDate = this.datLicenseValidateDate.DateTime;
            }

            if (this.datBusinessValidateDate.Text.Trim().Length > 0)
            {
                entity.TradeLicenseValidateDate = this.datBusinessValidateDate.DateTime;
            }

            if (this.datGSPValidateDate.Text.Trim().Length > 0)
            {
                entity.GSPValidateDate = this.datGSPValidateDate.DateTime;
            }
        }

        private void btnViewHistory_Click(object sender, EventArgs e)
        {
            FrmSingleEnterpriseChangeHistory doc = new FrmSingleEnterpriseChangeHistory();
            doc.Show(this);
        }

        private void btnEnterprisePic_Click(object sender, EventArgs e)
        {
            if (this.m_id != null)
            {
                using (FrmEnterpriseAttachment frmEnterpriseAttachment = new FrmEnterpriseAttachment(m_id.Value))
                {
                    frmEnterpriseAttachment.ShowDialog();
                }
            }
        }
    }
}