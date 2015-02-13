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
using ORMSCore;

namespace DQS.AppViews.StoreAndCuring.CuringManager
{
    public partial class FrmSingleCuringRecord : DevExpress.XtraEditors.XtraForm
    {
        private object m_ProductID;

        public FrmSingleCuringRecord()
        {
            InitializeComponent();
        }

        public FrmSingleCuringRecord(object productID)
        {
            InitializeComponent();
            this.m_ProductID = productID;
        }

        private void FrmSingleCuringRecord_Load(object sender, EventArgs e)
        {
            if (this.m_ProductID != null && this.m_ProductID != DBNull.Value)
            {
                this.txtCuringCode.Text = "YHJL" + DateTime.Now.ToString("yyyyMMddHHmmss");
                this.txtCuringCode.Select(this.txtCuringCode.Text.Length, 0);
                this.txtQualifiedAmount.Text = this.txtAmount.Text;
                this.txtUnqualifiedAmount.Text = 0+"";
            }
            if (GlobalItem.g_CurrentEmployee != null)
            {
                this.txtCuringMan.Text = GlobalItem.g_CurrentEmployee.EmployeeName;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ftPanel.ValidateIsNullFields()) return;
            BUSCuringRecordEntity entity = this.ftPanel.GetEntity() as BUSCuringRecordEntity;

            entity.ProductID = Convert.ToInt32(this.m_ProductID);
            entity.BatchNo = txtBatchNo.Text.Trim();
            entity.CheckDate = DateTime.Now;
            if (entity.IsNew())
            {
                entity.CreateDate = DateTime.Now;
                entity.LastModifyDate = DateTime.Now;
                entity.CreateUserID = GlobalItem.g_CurrentUser.UserID;
                entity.LastModifyUserID = GlobalItem.g_CurrentUser.UserID;
                entity.Save();

                //更新养护时间
                UpdateStoreDetail(entity);
            }
            else
            {
                XtraMessageBox.Show("记录编号已存在。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtQualifiedAmount_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            int amount = Convert.ToInt32(this.txtAmount.Text.Trim());

            int qualifiedAmount = this.txtQualifiedAmount.Text.Trim() == "" ? 0 : Convert.ToInt32(this.txtQualifiedAmount.Text.Trim());

            if (qualifiedAmount > amount)
            {
                XtraMessageBox.Show("合格数量不能大于库存数量。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Cancel = true;
                return;
            }

            if (qualifiedAmount <= amount)
            {
                this.txtUnqualifiedAmount.Text = (amount - qualifiedAmount) + "";
            }
        }

        public static void UpdateStoreDetail(BUSCuringRecordEntity curingRecord)
        {
            EntityCollection<BUSStoreDetailEntity> entities = new EntityCollection<BUSStoreDetailEntity>();
            entities.Fetch(BUSStoreDetailEntityFields.ProductID == curingRecord.ProductID & BUSStoreDetailEntityFields.BatchNo == curingRecord.BatchNo);

            foreach (BUSStoreDetailEntity entity in entities)
            {

                entity.LastCuringDate = DateTime.Now;

                entity.Update();
            }

        }
    }
}