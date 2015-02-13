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

namespace DQS.AppViews.QualityDocument.DealerManager
{
    public partial class FrmSingleSalesman : DevExpress.XtraEditors.XtraForm
    {
        private int? m_id;

        public FrmSingleSalesman()
        {
            InitializeComponent();
        }

        private void FrmSingleSalesman_Load(object sender, EventArgs e)
        {
            this.cbxSalesmanJob.InitSource();

            if (this.Tag != null)
            {
                this.m_id = Convert.ToInt32(this.Tag);

                BFISalesmanEntity entity = new BFISalesmanEntity { SalesmanID = m_id.Value };
                entity.Fetch();

                this.ftPanel.SetEntity(entity);

                this.txtSalesmanCode.Enabled = false;

                this.CustomGetEntity(entity);
            }
            else
            {
                this.txtSalesmanCode.Text = "GYXSRY" + DateTime.Now.ToString("yyyyMMddHHmmss");
                this.txtSalesmanCode.Select(this.txtSalesmanCode.Text.Length, 0);
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ftPanel.ValidateIsNullFields()) return;

            BFISalesmanEntity entity = this.ftPanel.GetEntity() as BFISalesmanEntity;
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
                    XtraMessageBox.Show("人员编号已存在。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
        protected virtual void CustomGetEntity(BFISalesmanEntity entity)
        {
            if (!entity.IsNullField("DealerID"))
            {
                this.txtPopupDealer.SetMemberValue(entity.DealerID);
            }

            if (!entity.IsNullField("Sex"))
            {
                this.rgpSex.EditValue = entity.Sex;
            }

            if (!entity.IsNullField("Birthday"))
            {
                this.dteBirthday.DateTime = entity.Birthday;
            }

            if (!entity.IsNullField("FinishSchoolDate"))
            {
                this.dteFinishSchoolDate.DateTime = entity.FinishSchoolDate;
            }

            if (!entity.IsNullField("SalesJobID"))
            {
                this.cbxSalesmanJob.SelectedValue = entity.SalesJobID;
            }
        }

        /// <summary>
        /// 非文本框赋值
        /// </summary>
        /// <param name="entity">实体</param>
        protected virtual void CustomSetEntity(BFISalesmanEntity entity)
        {
            if (this.txtPopupDealer.SelectedValue != null)
            {
                entity.DealerID = Convert.ToInt32(this.txtPopupDealer.SelectedValue);
                entity.DealerName = this.txtPopupDealer.Text.Trim();
                entity.DealerSpell = GlobalMethod.GetAlphabetic(entity.DealerName);
            }

            if (this.rgpSex.EditValue != null)
            {
                entity.Sex = this.rgpSex.EditValue.ToString();
            }

            if (this.dteBirthday.Text.Trim().Length > 0)
            {
                entity.Birthday = this.dteBirthday.DateTime;
            }

            if (this.dteFinishSchoolDate.Text.Trim().Length > 0)
            {
                entity.FinishSchoolDate = this.dteFinishSchoolDate.DateTime;
            }

            if (this.cbxSalesmanJob.SelectedValue != null)
            {
                entity.SalesJobID = Convert.ToInt32(this.cbxSalesmanJob.SelectedValue);
                entity.SalesJobName = this.cbxSalesmanJob.Text.Trim();
            }
        }


    }
}