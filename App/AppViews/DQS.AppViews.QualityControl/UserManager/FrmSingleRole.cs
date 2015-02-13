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
using DevExpress.XtraEditors.Controls;
using DQS.Common;

namespace DQS.AppViews.QualityControl.UserManager
{
    public partial class FrmSingleRole : DevExpress.XtraEditors.XtraForm
    {
        private Guid? m_id;

        public FrmSingleRole()
        {
            InitializeComponent();
        }

        private void FrmSingleRole_Load(object sender, EventArgs e)
        {
            this.InitCategory();

            if (this.Tag != null)
            {
                this.m_id = new Guid(this.Tag.ToString());

                ATCRoleEntity entity = new ATCRoleEntity { RoleID = m_id.Value };
                entity.Fetch();

                this.ftPanel.SetEntity(entity);

                this.txtRoleCode.Enabled = false;

                this.CustomGetEntity(entity);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ftPanel.ValidateIsNullFields()) return;

            ATCRoleEntity entity = this.ftPanel.GetEntity() as ATCRoleEntity;

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
                    entity.RoleID = Guid.NewGuid();
                    entity.CreateDate = DateTime.Now;
                    entity.LastModifyDate = DateTime.Now;
                    entity.CreateUserID = GlobalItem.g_CurrentUser.UserID;
                    entity.LastModifyUserID = GlobalItem.g_CurrentUser.UserID;
                    entity.Save();
                }
                else
                {
                    XtraMessageBox.Show("角色编号已存在。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InitCategory()
        {
            EntityCollection<SYSCategoryEntity> categories = new EntityCollection<SYSCategoryEntity>();
            categories.Fetch(SYSCategoryEntityFields.CategoryCode == "RoleStatus");
            foreach (SYSCategoryEntity category in categories)
            {
                RadioGroupItem item = new RadioGroupItem
                {
                    Description = category.ItemName,
                    Value = category.ItemID
                };
                this.rgpStatus.Properties.Items.Add(item);
            }

            if (rgpStatus.Properties.Items.Count > 0)
            {
                rgpStatus.SelectedIndex = 0;
            }
        }

        /// <summary>
        /// 非文本框赋值
        /// </summary>
        /// <param name="entity">实体</param>
        protected virtual void CustomSetEntity(ATCRoleEntity entity)
        {
            entity.RoleStatus = Convert.ToInt32(rgpStatus.EditValue);
        }

        /// <summary>
        /// 非文本框取值
        /// </summary>
        /// <param name="entity">实体</param>
        protected virtual void CustomGetEntity(ATCRoleEntity entity)
        {
            rgpStatus.EditValue = entity.RoleStatus;
        }
    }
}