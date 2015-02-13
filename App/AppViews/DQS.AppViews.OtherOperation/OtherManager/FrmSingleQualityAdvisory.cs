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

namespace DQS.AppViews.OtherOperation.OtherManager
{
    public partial class FrmSingleQualityAdvisory : DevExpress.XtraEditors.XtraForm
    {
        private int? m_id;

        public FrmSingleQualityAdvisory()
        {
            InitializeComponent();
        }

        private void FrmSingleQualityAdvisory_Load(object sender, EventArgs e)
        {
            if (this.Tag != null)
            {
                this.m_id = Convert.ToInt32(this.Tag);

                BUSQualityAdvisoryEntity entity = new BUSQualityAdvisoryEntity { AdvisoryID = m_id.Value };
                entity.Fetch();

                this.ftPanel.SetEntity(entity);

                this.txtAdvisoryCode.Enabled = false;

                this.CustomGetEntity(entity);
            }
            else
            {
                this.txtAdvisoryCode.Text = "ZXJL" + DateTime.Now.ToString("yyyyMMddHHmmss");
                this.txtAdvisoryCode.Select(this.txtAdvisoryCode.Text.Length, 0);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ftPanel.ValidateIsNullFields()) return;

            BUSQualityAdvisoryEntity entity = this.ftPanel.GetEntity() as BUSQualityAdvisoryEntity;
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
                    XtraMessageBox.Show("咨询编号已存在。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
        protected virtual void CustomGetEntity(BUSQualityAdvisoryEntity entity)
        {
            if (!entity.IsNullField("ConsultantType"))
            {
                this.cbxConsultantType.Text = entity.ConsultantType;
            }

            if (!entity.IsNullField("AdvisoryDate"))
            {
                this.dteAdvisoryDate.DateTime = entity.AdvisoryDate;
            }

            if (!entity.IsNullField("ReplyDate"))
            {
                this.dteReplyDate.DateTime = entity.ReplyDate;
            }
        }

        /// <summary>
        /// 非文本框赋值
        /// </summary>
        /// <param name="entity">实体</param>
        protected virtual void CustomSetEntity(BUSQualityAdvisoryEntity entity)
        {
            if (this.cbxConsultantType.Text.Trim().Length > 0)
            {
                entity.ConsultantType = this.cbxConsultantType.Text.Trim();
            }

            if (this.dteAdvisoryDate.Text.Trim().Length > 0)
            {
                entity.AdvisoryDate = this.dteAdvisoryDate.DateTime;
            }

            if (this.dteReplyDate.Text.Trim().Length > 0)
            {
                entity.ReplyDate = this.dteReplyDate.DateTime;
            }
        }
    }
}