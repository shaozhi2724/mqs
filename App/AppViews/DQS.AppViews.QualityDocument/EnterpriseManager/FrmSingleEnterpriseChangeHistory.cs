using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DQS.Controls;
using DQS.Module.Entities;
using ORMSCore;

namespace DQS.AppViews.QualityDocument.EnterpriseManager
{
    public partial class FrmSingleEnterpriseChangeHistory : DevExpress.XtraEditors.XtraForm
    {
        public FrmSingleEnterpriseChangeHistory()
        {
            InitializeComponent();

        }

        private void FrmSingleEnterpriseChangeHistory_Load(object sender, EventArgs e)
        {
            BindHistories();
            this.cbxEnterpriseLevel.InitSource();
            this.cbxEnterpriseType.InitSource();
            this.cbxEnterpriseStyle.InitSource();
            this.cbxIndustryStyle.InitSource();

            RenderRequiredFields();
        }

        private void BindHistories()
        {
            EntityCollection<BFIEnterpriseChangeHistoryEntity> changes = new EntityCollection<BFIEnterpriseChangeHistoryEntity>();
            changes.Fetch();
            if (changes.Count > 0)
            {
                List<BFIEnterpriseChangeHistoryEntity> list = changes.Cast<BFIEnterpriseChangeHistoryEntity>().OrderByDescending(p => p.VersionNumber).ToList();
                foreach (BFIEnterpriseChangeHistoryEntity change in list)
                {
                    this.lbcHistories.Items.Add(new ListEntityItem(change,
                        string.Format("版本 {0} - {1} 于 {2} 修改", change.VersionNumber, change.ChangeUserName,
                            change.ChangeDate.ToString("yyyy-MM-dd HH:mm:ss"))));
                }
            }
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 非文本框取值
        /// </summary>
        /// <param name="entity">实体</param>
        protected virtual void CustomGetEntity(BFIEnterpriseChangeHistoryEntity entity)
        {
            this.ftPanel.SetEntity(entity);
            if (!entity.IsNullField("EnterpriseType"))
            {
                this.cbxEnterpriseType.Text = entity.EnterpriseType;
            }
            else
            {
                cbxEnterpriseType.Text = "";

            }

            if (!entity.IsNullField("EnterpriseStyle"))
            {
                this.cbxEnterpriseStyle.Text = entity.EnterpriseStyle;
            }
            else
            {
                cbxEnterpriseStyle.Text = "";
            }

            if (!entity.IsNullField("EnterpriseLevel"))
            {
                this.cbxEnterpriseLevel.Text = entity.EnterpriseLevel;
            }
            else
            {
                cbxEnterpriseLevel.Text = "";
            }

            if (!entity.IsNullField("IndustryStyle"))
            {
                this.cbxIndustryStyle.Text = entity.IndustryStyle;
            }
            else
            {
                cbxIndustryStyle.Text = "";
            }

            if (!entity.IsNullField("RegisterData"))
            {
                this.dteRegisterData.DateTime = entity.RegisterData;
            }
            else
            {
                dteRegisterData.Text = "";
            }

            if (!entity.IsNullField("TaxValidateDate"))
            {
                this.datTaxValidateDate.DateTime = entity.TaxValidateDate;
            }
            else
            {
                datTaxValidateDate.Text = "";
            }

            if (!entity.IsNullField("LicenseValidateDate"))
            {
                this.datLicenseValidateDate.DateTime = entity.LicenseValidateDate;
            }
            else
            {
                datLicenseValidateDate.Text = "";
            }

            if (!entity.IsNullField("TradeLicenseValidateDate"))
            {
                this.datBusinessValidateDate.DateTime = entity.TradeLicenseValidateDate;
            }
            else
            {
                datBusinessValidateDate.Text = "";
            }
        }
        private void lbcHistories_SelectedIndexChanged(object sender, EventArgs e)
        {
            CustomGetEntity(new BFIEnterpriseChangeHistoryEntity());
            if (lbcHistories.SelectedItem != null)
            {
                BFIEnterpriseChangeHistoryEntity selectChange = (lbcHistories.SelectedItem as ListEntityItem).Key as BFIEnterpriseChangeHistoryEntity;
                CustomGetEntity(selectChange);
                
            }
        }
    }
}