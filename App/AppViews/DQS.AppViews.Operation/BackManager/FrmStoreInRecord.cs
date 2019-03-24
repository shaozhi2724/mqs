using DevExpress.XtraEditors;
using DQS.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DQS.AppViews.Operation.BackManager
{
    public partial class FrmStoreInRecord : DevExpress.XtraEditors.XtraForm
    {
        /// <summary>
        /// 编辑的行
        /// </summary>
        public DataRow EditRow { get; set; }
        /// <summary>
        /// 编辑的行的单据
        /// </summary>
        public DataRow EditBillRow { get; set; }
        
        public FrmStoreInRecord()
        {
            InitializeComponent();
        }
        int productID;
        string productName;
        string batchNo;
        int instoreid;
        public FrmStoreInRecord(int _productID,string _productName,string _batchNo,int _instoreid)
        {
            InitializeComponent();
            productID = _productID;
            productName = _productName;
            batchNo = _batchNo;
            instoreid = _instoreid;
        }
        private void FrmStoreInRecord_Load(object sender, EventArgs e)
        {
            this.gvBill.GridViewData.FocusedRowChanged += GridViewData_FocusedRowChanged;
            DataTable data = GlobalMethod.GetStoreInByProduct(productID, batchNo, instoreid);
            this.gvBill.DataSource = data;
        }
        public void GridViewData_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            object storeID = (int)this.gvBill.GridViewData.GetRowCellValue(e.FocusedRowHandle, "入库单ID");
            if (storeID != null && storeID != DBNull.Value)
            {
                DataTable data = GlobalMethod.GetStoreInByProduct((int)storeID);
                this.gvDetails.DataSource = data;
            }
        }
        private void gvDetails_DoubleClick(object sender, EventArgs e)
        {
            this.EditRow = gvDetails.GridViewData.GetFocusedDataRow();
            this.EditBillRow = gvBill.GridViewData.GetFocusedDataRow();

            if (this.EditRow != null)
            {
                int selectedProductID = (int)EditRow["产品ID"];
                string selectedProductName = EditRow["产品名称"].ToString();
                string selectedBatchNo = EditRow["批号"].ToString();
                var selectedPackageSpec = EditRow["包装规格型号"].ToString();

                if (selectedProductID != productID)
                {
                    XtraMessageBox.Show("产品名称不匹配，请选择: " + productName, "错误", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (selectedBatchNo != batchNo)
                {
                    XtraMessageBox.Show("批号不匹配，请选择: " +batchNo, "错误", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
