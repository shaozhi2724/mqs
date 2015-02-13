using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DQS.Controls;

namespace DQS.AppViews.StoreAndCuring.CuringManager
{
    public partial class FrmCuringPlan : StandardForm
    {
        public FrmCuringPlan()
        {
            InitializeComponent();
        }

        private void FrmCuringPlan_Load(object sender, EventArgs e)
        {
            base.InitPage();
        }

        protected override void CustomModify(bool isView)
        {
            object productID = this.gvData.GetFocusedRowCellValue("药品ID");
            object productCode = this.gvData.GetFocusedRowCellValue("药品编号");
            object productName = this.gvData.GetFocusedRowCellValue("药品名称");
            object productSpec = this.gvData.GetFocusedRowCellValue("规格");
            object productUnit = this.gvData.GetFocusedRowCellValue("单位");
            object packageSpec = this.gvData.GetFocusedRowCellValue("包装规格");
            object physicType = this.gvData.GetFocusedRowCellValue("剂型");
            object productStyle = this.gvData.GetFocusedRowCellValue("药品类别");
            object authorizedNo = this.gvData.GetFocusedRowCellValue("批准文号");
            object producerName = this.gvData.GetFocusedRowCellValue("生产厂商");


            object batchNo = this.gvData.GetFocusedRowCellValue("批号");
            object amount = this.gvData.GetFocusedRowCellValue("库存数量");
            object produceDate = this.gvData.GetFocusedRowCellValue("生产日期");
            object validateDate = this.gvData.GetFocusedRowCellValue("有效期至");
            using (FrmSingleCuringRecord frmSingleCuringRecord = new FrmSingleCuringRecord(productID))
            {
                if (productCode != null && productCode != DBNull.Value)
                {
                    frmSingleCuringRecord.txtProductCode.Text = productCode.ToString();
                }

                if (productName != null && productName != DBNull.Value)
                {
                    frmSingleCuringRecord.txtProductName.Text = productName.ToString();
                }

                if (productSpec != null && productSpec != DBNull.Value)
                {
                    frmSingleCuringRecord.txtProductSpec.Text = productSpec.ToString();
                }

                if (productUnit != null && productUnit != DBNull.Value)
                {
                    frmSingleCuringRecord.txtProductUnit.Text = productUnit.ToString();
                }

                if (packageSpec != null && packageSpec != DBNull.Value)
                {
                    frmSingleCuringRecord.txtPackageSpec.Text = packageSpec.ToString();
                }

                if (physicType != null && physicType != DBNull.Value)
                {
                    frmSingleCuringRecord.txtPhysicType.Text = physicType.ToString();
                }

                if (productStyle != null && productStyle != DBNull.Value)
                {
                    frmSingleCuringRecord.txtProductStyle.Text = productStyle.ToString();
                }

                if (authorizedNo != null && authorizedNo != DBNull.Value)
                {
                    frmSingleCuringRecord.txtAuthorizedNo.Text = authorizedNo.ToString();
                }

                if (producerName != null && producerName != DBNull.Value)
                {
                    frmSingleCuringRecord.txtProducerName.Text = producerName.ToString();
                }

                if (batchNo != null && batchNo != DBNull.Value)
                {
                    frmSingleCuringRecord.txtBatchNo.Text = batchNo.ToString();
                }

                if (amount != null && amount != DBNull.Value)
                {
                    frmSingleCuringRecord.txtAmount.Text = amount.ToString();
                }

                if (produceDate != null && produceDate != DBNull.Value)
                {
                    frmSingleCuringRecord.txtProduceDate.Text = Convert.ToDateTime(produceDate).ToString("yyyy-MM-dd");
                }

                if (validateDate != null && validateDate != DBNull.Value)
                {
                    frmSingleCuringRecord.txtValidateDate.Text = Convert.ToDateTime(validateDate).ToString("yyyy-MM-dd");
                }
                if (isView)
                {
                    foreach (Control control in frmSingleCuringRecord.Controls.Find("btnSave", true))
                    {
                        control.Enabled = false;
                    }
                }
                DialogResult result = frmSingleCuringRecord.ShowDialog();
                if (result == DialogResult.OK)
                {
                    this.pageNavigator.ShowData();
                }
            }
        }

        protected override void CustomModify()
        {
            object productID = this.gvData.GetFocusedRowCellValue("药品ID");
            object productCode = this.gvData.GetFocusedRowCellValue("药品编号");
            object productName = this.gvData.GetFocusedRowCellValue("药品名称");
            object productSpec = this.gvData.GetFocusedRowCellValue("规格");
            object productUnit = this.gvData.GetFocusedRowCellValue("单位");
            object packageSpec = this.gvData.GetFocusedRowCellValue("包装规格");
            object physicType = this.gvData.GetFocusedRowCellValue("剂型");
            object productStyle = this.gvData.GetFocusedRowCellValue("药品类别");
            object authorizedNo = this.gvData.GetFocusedRowCellValue("批准文号");
            object producerName = this.gvData.GetFocusedRowCellValue("生产厂商");


            object batchNo = this.gvData.GetFocusedRowCellValue("批号");
            object amount = this.gvData.GetFocusedRowCellValue("库存数量");
            object produceDate = this.gvData.GetFocusedRowCellValue("生产日期");
            object validateDate = this.gvData.GetFocusedRowCellValue("有效期至");
            using (FrmSingleCuringRecord frmSingleCuringRecord = new FrmSingleCuringRecord(productID))
            {
                if (productCode != null && productCode != DBNull.Value)
                {
                    frmSingleCuringRecord.txtProductCode.Text = productCode.ToString();
                }

                if (productName != null && productName != DBNull.Value)
                {
                    frmSingleCuringRecord.txtProductName.Text = productName.ToString();
                }

                if (productSpec != null && productSpec != DBNull.Value)
                {
                    frmSingleCuringRecord.txtProductSpec.Text = productSpec.ToString();
                }

                if (productUnit != null && productUnit != DBNull.Value)
                {
                    frmSingleCuringRecord.txtProductUnit.Text = productUnit.ToString();
                }

                if (packageSpec != null && packageSpec != DBNull.Value)
                {
                    frmSingleCuringRecord.txtPackageSpec.Text = packageSpec.ToString();
                }

                if (physicType != null && physicType != DBNull.Value)
                {
                    frmSingleCuringRecord.txtPhysicType.Text = physicType.ToString();
                }

                if (productStyle != null && productStyle != DBNull.Value)
                {
                    frmSingleCuringRecord.txtProductStyle.Text = productStyle.ToString();
                }

                if (authorizedNo != null && authorizedNo != DBNull.Value)
                {
                    frmSingleCuringRecord.txtAuthorizedNo.Text = authorizedNo.ToString();
                }

                if (producerName != null && producerName != DBNull.Value)
                {
                    frmSingleCuringRecord.txtProducerName.Text = producerName.ToString();
                }

                if (batchNo != null && batchNo != DBNull.Value)
                {
                    frmSingleCuringRecord.txtBatchNo.Text = batchNo.ToString();
                }

                if (amount != null && amount != DBNull.Value)
                {
                    frmSingleCuringRecord.txtAmount.Text = amount.ToString();
                }

                if (produceDate != null && produceDate != DBNull.Value)
                {
                    frmSingleCuringRecord.txtProduceDate.Text = Convert.ToDateTime(produceDate).ToString("yyyy-MM-dd");
                }

                if (validateDate != null && validateDate != DBNull.Value)
                {
                    frmSingleCuringRecord.txtValidateDate.Text = Convert.ToDateTime(validateDate).ToString("yyyy-MM-dd");
                }

                DialogResult result = frmSingleCuringRecord.ShowDialog();
                if (result == DialogResult.OK)
                {
                    this.pageNavigator.ShowData();
                }
            }
        }
    }
}