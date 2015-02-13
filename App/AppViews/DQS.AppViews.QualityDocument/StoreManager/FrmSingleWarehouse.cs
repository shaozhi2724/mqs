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
using DQS.Common;

namespace DQS.AppViews.QualityDocument.StoreManager
{
    public partial class FrmSingleWarehouse : DevExpress.XtraEditors.XtraForm
    {
        private int? m_id;

        public FrmSingleWarehouse()
        {
            InitializeComponent();
        }

        private void FrmSingleWarehouse_Load(object sender, EventArgs e)
        {
            this.cbxWarehouseType.InitSource();
            if (this.Tag != null)
            {
                this.m_id = Convert.ToInt32(this.Tag);

                BFIWarehouseEntity entity = new BFIWarehouseEntity { WarehouseID = m_id.Value };
                entity.Fetch();

                this.ftPanel.SetEntity(entity);

                this.txtWarehouseCode.Enabled = false;

                this.CustomGetEntity(entity);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ftPanel.ValidateIsNullFields()) return;

            BFIWarehouseEntity entity = this.ftPanel.GetEntity() as BFIWarehouseEntity;
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
                    XtraMessageBox.Show("仓库编号已存在。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
        protected virtual void CustomGetEntity(BFIWarehouseEntity entity)
        {
            if (!entity.IsNullField("IsAnotherPlace"))
            {
                this.rgpIsAnotherPlace.SelectedIndex = entity.IsAnotherPlace == "否" ? 0 : 1;
            }

            if (!entity.IsNullField("WarehouseType"))
            {
                this.cbxWarehouseType.Text = entity.WarehouseType;
            }
        }

        /// <summary>
        /// 非文本框赋值
        /// </summary>
        /// <param name="entity">实体</param>
        protected virtual void CustomSetEntity(BFIWarehouseEntity entity)
        {
            if (this.cbxWarehouseType.Text.Trim().Length > 0)
            {
                entity.WarehouseType = this.cbxWarehouseType.Text.Trim();
            }

            if (this.rgpIsAnotherPlace.SelectedIndex >= 0)
            {
                entity.IsAnotherPlace = this.rgpIsAnotherPlace.EditValue.ToString();
            }
        }

    }
}