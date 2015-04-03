using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DQS.Common;

namespace DQS.AppViews.Operation.BackManager
{
    public partial class FrmReviewRecordQuery : DevExpress.XtraEditors.XtraForm
    {
        /// <summary>
        /// 编辑的行
        /// </summary>
        public DataRow EditRow { get; set; }

        /// <summary>
        /// 销售单号
        /// </summary>
        public string SaleBillCode { get; set; }

        /// <summary>
        /// 出库复核单号
        /// </summary>
        public string ReviewCode { get; set; }

        public FrmReviewRecordQuery()
        {
            InitializeComponent();
        }

        public FrmReviewRecordQuery(object dealerID, object dealerName, object productID, object productName, object productSpec, object packageSpec, object producerName, object batchNo, object validateDate, object produceDate)
        {
            InitializeComponent();
            this.txtDealerName.Tag = Convert.ToInt32(dealerID);
            this.txtDealerName.Text = dealerName.ToString();
            this.txtProductName.Tag = Convert.ToInt32(productID);
            this.txtProductName.Text = productName.ToString();
            //this.txtProductSpec.Text = productSpec.ToString();
            //this.txtPackageSpec.Text = packageSpec.ToString();
            //this.txtProducerName.Text = producerName.ToString();
            this.txtBatchNo.Text = batchNo.ToString();
            //this.txtValidateDate.Text = validateDate.ToString();
            //this.txtProduceDate.Text = produceDate.ToString();
        }

        private void FrmReviewRecordQuery_Load(object sender, EventArgs e)
        {
            this.gvBill.GridViewData.FocusedRowChanged += GridViewData_FocusedRowChanged;
            //string dealerName = this.txtDealerName.Text;
            //int dealerID = (int)this.txtDealerName.Tag;
            //int productID = (int)this.txtProductName.Tag;
            //string productName = this.txtProductName.Text;
            //string batchNo = this.txtBatchNo.Text;
            //DataTable data = GlobalMethod.GetReviewByProduct(productID, batchNo, dealerID);
            //this.gvBill.DataSource = data;


        }

        public void GridViewData_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            object reviewCode = this.gvBill.GridViewData.GetRowCellValue(e.FocusedRowHandle, "复核单号");
            object saleBillCode = this.gvBill.GridViewData.GetRowCellValue(e.FocusedRowHandle, "销售单号");
            if (reviewCode != null && reviewCode != DBNull.Value)
            {
                if (saleBillCode != null && saleBillCode != DBNull.Value)
                {
                    this.SaleBillCode = saleBillCode.ToString();
                }
                this.ReviewCode = reviewCode.ToString();

                DataTable data = GlobalMethod.GetReviewDetialByProduct(reviewCode.ToString());
                this.gvDetails.DataSource = data;
            }
        }

        private void gvDetails_DoubleClick(object sender, EventArgs e)
        {
            this.EditRow = gvDetails.GridViewData.GetFocusedDataRow();

            if (this.EditRow != null)
            {
                var selectedProductName = EditRow["药品名称"].ToString();
                var selectedBatchNo = EditRow["批号"].ToString();
                var selectedPackageSpec = EditRow["包装规格"].ToString();

                //if (selectedProductName != txtProductName.Text.Trim())
                //{
                //    XtraMessageBox.Show("药品名称不匹配，请选择: " + txtProductName.Text.Trim(), "错误", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //    return;
                //}
                //if (selectedBatchNo != txtBatchNo.Text.Trim())
                //{
                //    XtraMessageBox.Show("批号不匹配，请选择: " + txtBatchNo.Text.Trim(), "错误", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //    return;
                //}
                //if (selectedPackageSpec != txtPackageSpec.Text.Trim())
                //{
                //    XtraMessageBox.Show("包装规格不匹配，请选择: " + txtPackageSpec.Text.Trim(), "错误", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //    return;
                //}
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}