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
    public partial class FrmSingleQualityComplaint : DevExpress.XtraEditors.XtraForm
    {
        private int? m_id;

        public FrmSingleQualityComplaint()
        {
            InitializeComponent();
        }

        private void FrmSingleQualityComplaint_Load(object sender, EventArgs e)
        {

            if (this.Tag != null)
            {
                this.m_id = Convert.ToInt32(this.Tag);

                BUSQualityComplaintEntity entity = new BUSQualityComplaintEntity { ComplaintID = m_id.Value };
                entity.Fetch();

                this.ftPanel.SetEntity(entity);

                this.txtComplaintCode.Enabled = false;

                this.CustomGetEntity(entity);
            }
            else
            {
                this.txtComplaintCode.Text = "TSJL" + DateTime.Now.ToString("yyyyMMddHHmmss");
                this.txtComplaintCode.Select(this.txtComplaintCode.Text.Length, 0);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ftPanel.ValidateIsNullFields()) return;

            BUSQualityComplaintEntity entity = this.ftPanel.GetEntity() as BUSQualityComplaintEntity;
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
                    XtraMessageBox.Show("投诉编号已存在。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
        protected virtual void CustomGetEntity(BUSQualityComplaintEntity entity)
        {
            if (!entity.IsNullField("ProductID"))
            {
                this.txtPopupProduct.SetMemberValue(entity.ProductID);
            }

            if (!entity.IsNullField("ComplaintType"))
            {
                this.cbxComplaintType.Text = entity.ComplaintType;
            }

            if (!entity.IsNullField("ComplaintDate"))
            {
                this.dteComplaintDate.DateTime = entity.ComplaintDate;
            }

            if (!entity.IsNullField("DealDate"))
            {
                this.dteDealDate.DateTime = entity.DealDate;
            }
        }

        /// <summary>
        /// 非文本框赋值
        /// </summary>
        /// <param name="entity">实体</param>
        protected virtual void CustomSetEntity(BUSQualityComplaintEntity entity)
        {
            if (this.txtPopupProduct.SelectedValue != null)
            {
                entity.ProductID = Convert.ToInt32(this.txtPopupProduct.SelectedValue);
            }

            if (this.cbxComplaintType.Text.Trim().Length > 0)
            {
                entity.ComplaintType = this.cbxComplaintType.Text.Trim();
            }

            if (this.dteComplaintDate.Text.Trim().Length > 0)
            {
                entity.ComplaintDate = this.dteComplaintDate.DateTime;
            }

            if (this.dteDealDate.Text.Trim().Length > 0)
            {
                entity.DealDate = this.dteDealDate.DateTime;
            }
        }
        
    }
}