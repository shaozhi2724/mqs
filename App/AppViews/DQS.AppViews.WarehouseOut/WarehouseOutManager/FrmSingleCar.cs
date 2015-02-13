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

namespace DQS.AppViews.WarehouseOut.WarehouseOutManager
{
    public partial class FrmSingleCar : DevExpress.XtraEditors.XtraForm
    {
        private int? m_id;

        public FrmSingleCar()
        {
            InitializeComponent();
        }

        private void FrmSingleCar_Load(object sender, EventArgs e)
        {
            if (this.Tag != null)
            {
                this.m_id = Convert.ToInt32(this.Tag);

                BUSTransportCarEntity entity = new BUSTransportCarEntity { CarID = m_id.Value };
                entity.Fetch();

                this.ftPanel.SetEntity(entity);

                this.txtCarCode.Enabled = false;

                this.CustomGetEntity(entity);
            }

        }

        //保存
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ftPanel.ValidateIsNullFields()) return;

            BUSTransportCarEntity entity = this.ftPanel.GetEntity() as BUSTransportCarEntity;

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
                    XtraMessageBox.Show("车辆编号已存在。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }

            this.DialogResult = DialogResult.OK;
        }
        //取消
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 非文本框取值
        /// </summary>
        /// <param name="entity">实体</param>
        protected virtual void CustomGetEntity(BUSTransportCarEntity entity)
        {
            if (!entity.IsNullField("BuyDate"))
            {
                dateBuyDate.DateTime = entity.BuyDate;
            }
        }

        /// <summary>
        /// 非文本框赋值
        /// </summary>
        /// <param name="entity">实体</param>
        protected virtual void CustomSetEntity(BUSTransportCarEntity entity)
        {
            if (!string.IsNullOrEmpty(dateBuyDate.Text.Trim()))
            {
                entity.BuyDate = dateBuyDate.DateTime;
            }
        }
        
    }
}