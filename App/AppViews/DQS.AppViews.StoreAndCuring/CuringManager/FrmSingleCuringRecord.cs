using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
            BindCheckItems();
            BindQualityCondition();
            BindCuringMeasure();
            BindCuringResult();
        }

        private void BindCuringResult()
        {
            EntityCollection<BUSCuringRecordEntity> records = new EntityCollection<BUSCuringRecordEntity>();
            records.Fetch();

            List<string> curingResults = records.Cast<BUSCuringRecordEntity>()
                                                .AsQueryable<BUSCuringRecordEntity>()
                                                .Select(p => p.CuringResult)
                                                .Distinct()
                                                .ToList();

            List<string> results = curingResults.Distinct().OrderBy(p => p).ToList();
            foreach (var result in results)
            {
                txtCuringResult.Properties.Items.Add(result);
            }
        }

        private void BindCuringMeasure()
        {
            EntityCollection<BUSCuringRecordEntity> records = new EntityCollection<BUSCuringRecordEntity>();
            records.Fetch();

            List<string> curingMeasures = records.Cast<BUSCuringRecordEntity>()
                                                .AsQueryable<BUSCuringRecordEntity>()
                                                .Select(p => p.CuringMeasure)
                                                .Distinct()
                                                .ToList();

            List<string> measure = curingMeasures.Distinct().OrderBy(p => p).ToList();
            foreach(var result in measure)
            {
                txtCuringMeasure.Properties.Items.Add(result);
            }
        }

        private void BindQualityCondition()
        {
            EntityCollection<BUSCuringRecordEntity> records = new EntityCollection<BUSCuringRecordEntity>();
            records.Fetch();

            List<string> qualityConditions = records.Cast<BUSCuringRecordEntity>()
                                                .AsQueryable<BUSCuringRecordEntity>()
                                                .Select(p => p.QualityCondition)
                                                .Distinct()
                                                .ToList();

            List<string> conditions = qualityConditions.Distinct().OrderBy(p => p).ToList();
            foreach(var result in conditions)
            {
                txtQualityCondition.Properties.Items.Add(result);
            }
        }

        private void BindCheckItems()
        {
            EntityCollection<BUSCuringRecordEntity> records = new EntityCollection<BUSCuringRecordEntity>();
            records.Fetch();

            List<string> checkItems = records.Cast<BUSCuringRecordEntity>()
                                                .AsQueryable<BUSCuringRecordEntity>()
                                                .Select(p => p.CheckItem)
                                                .Distinct()
                                                .ToList();

            List<string> items = checkItems.Distinct().OrderBy(p => p).ToList();
            foreach(var result in items)
            {
                txtCheckItem.Properties.Items.Add(result);
            }
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

            if (txtCheckItem.Text == "")
            {
                XtraMessageBox.Show("检查项目不能为空。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCheckItem.Focus();
                return;
            }
            if (txtQualityCondition.Text == "")
            {
                XtraMessageBox.Show("质量状况不能为空。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtQualityCondition.Focus();
                return;
            }
            if (txtCuringMeasure.Text == "")
            {
                XtraMessageBox.Show("养护措施不能为空。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCuringMeasure.Focus();
                return;
            }
            if (txtCuringResult.Text == "")
            {
                XtraMessageBox.Show("处理结果不能为空。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCuringResult.Focus();
                return;
            }

            entity.ProductID = Convert.ToInt32(this.m_ProductID);
            entity.BatchNo = txtBatchNo.Text.Trim();
            entity.CheckDate = DateTime.Now;
            if (entity.IsNew())
            {
                entity.CreateDate = DateTime.Now;
                entity.LastModifyDate = DateTime.Now;
                entity.CreateUserID = GlobalItem.g_CurrentUser.UserID;
                entity.LastModifyUserID = GlobalItem.g_CurrentUser.UserID;
                entity.CheckItem = txtCheckItem.Text;
                entity.CuringResult = txtCuringResult.Text;
                entity.CuringMeasure = txtCuringMeasure.Text;
                entity.QualityCondition = txtQualityCondition.Text;
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

            BUSInStoreDetailEntity InStoreDetails = new BUSInStoreDetailEntity
            {
                InStoreID = curingRecord.InStoreID
            };
            InStoreDetails.Fetch();

            InStoreDetails.CuringDate = DateTime.Now;

            InStoreDetails.Update();

        }
    }
}