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
    public partial class FrmSingleAdverseReaction : DevExpress.XtraEditors.XtraForm
    {
        private int? m_id;

        public FrmSingleAdverseReaction()
        {
            InitializeComponent();
        }

        private void FrmSingleAdverseReaction_Load(object sender, EventArgs e)
        {
            if (this.Tag != null)
            {
                this.m_id = Convert.ToInt32(this.Tag);

                BUSAdverseReactionEntity entity = new BUSAdverseReactionEntity { ReactionID = m_id.Value };
                entity.Fetch();

                this.ftPanel.SetEntity(entity);

                this.txtReactionCode.Enabled = false;

                this.CustomGetEntity(entity);
            }
            else
            {
                this.txtReactionCode.Text = "BLFY" + DateTime.Now.ToString("yyyyMMddHHmmss");
                this.txtReactionCode.Select(this.txtReactionCode.Text.Length, 0);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ftPanel.ValidateIsNullFields()) return;

            BUSAdverseReactionEntity entity = this.ftPanel.GetEntity() as BUSAdverseReactionEntity;
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
                    XtraMessageBox.Show("记录编号已存在。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
        protected virtual void CustomGetEntity(BUSAdverseReactionEntity entity)
        {
            if (!entity.IsNullField("ProductID"))
            {
                this.txtPopupProduct.SetMemberValue(entity.ProductID);
            }

            if (!entity.IsNullField("UseDate"))
            {
                this.dteUseDate.DateTime = entity.UseDate;
            }

            if (!entity.IsNullField("HappenedDate"))
            {
                this.dteHappenedDate.DateTime = entity.HappenedDate;
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
        protected virtual void CustomSetEntity(BUSAdverseReactionEntity entity)
        {
            if (this.txtPopupProduct.SelectedValue != null)
            {
                entity.ProductID = Convert.ToInt32(this.txtPopupProduct.SelectedValue);
            }

            if (this.dteUseDate.Text.Trim().Length > 0)
            {
                entity.UseDate = this.dteUseDate.DateTime;
            }

            if (this.dteHappenedDate.Text.Trim().Length > 0)
            {
                entity.HappenedDate = this.dteHappenedDate.DateTime;
            }

            if (this.dteDealDate.Text.Trim().Length > 0)
            {
                entity.DealDate = this.dteDealDate.DateTime;
            }
        }

    }
}