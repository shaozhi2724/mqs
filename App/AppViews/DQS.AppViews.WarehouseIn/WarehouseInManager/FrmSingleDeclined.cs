using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DQS.Module.Entities;
using ORMSCore;
using DQS.Common;
using DQS.Controls;

namespace DQS.AppViews.WarehouseIn.WarehouseInManager
{
    public partial class FrmSingleDeclined : DevExpress.XtraEditors.XtraForm
    {
        private int? m_id;

        public FrmSingleDeclined()
        {
            InitializeComponent();
            ftPanel.TypeOfEntity = DQS.Module.EntityType2.BUSDeclinedEntity;
        }

        private void FrmSingleDeclined_Load(object sender, EventArgs e)
        {
            this.popupGrid.InitGrid();

            if (this.Tag != null)
            {
                this.m_id = Convert.ToInt32(this.Tag);

                BUSDeclinedEntity entity = new BUSDeclinedEntity { DeclinedID = m_id.Value };
                entity.Fetch();

                this.ftPanel.SetEntity(entity);

                this.CustomGetEntity(entity);

                this.popupGrid.SetGridData(m_id.Value, true);
            }
            this.btnSave.Enabled = true;
            txtDeclinedReason.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.ftPanel.ValidateIsNullFields()) return;

                BUSDeclinedEntity entity = this.ftPanel.GetEntity() as BUSDeclinedEntity;

                if (this.m_id != null)
                {
                    entity.LastModifyDate = DateTime.Now;
                    entity.LastModifyUserID = GlobalItem.g_CurrentUser.UserID;
                    entity.Reservation1 = txtDeclinedReason.Text.Trim();
                    entity.Update();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
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
        protected virtual void CustomGetEntity(BUSDeclinedEntity entity)
        {
            if (!entity.IsNullField("BillCode"))
            {
                this.txtBillCode.Text = entity.BillCode;
            }

            if (!entity.IsNullField("DealerID"))
            {
                this.txtDealerName.Tag = entity.DealerID;
            }

            if (!entity.IsNullField("DeclinedPerson"))
            {
                this.txtDeclinedPerson.Text = entity.DeclinedPerson;
            }

            if (!entity.IsNullField("Reservation1"))
            {
                this.txtDeclinedReason.Text = entity.Reservation1;
            }

        }

    }
}