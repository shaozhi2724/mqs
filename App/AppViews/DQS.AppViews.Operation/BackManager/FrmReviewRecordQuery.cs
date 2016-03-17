﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DQS.Common;

namespace DQS.AppViews.Operation.BackManager
{
    public partial class FrmReviewRecordQuery : DevExpress.XtraEditors.XtraForm
    {
        /// <summary>
        /// 编辑的行
        /// </summary>
        public DataRow EditRow
        {
            get;
            set;
        }
        /// <summary>
        /// 编辑的行
        /// </summary>
        public DataRow[] EditRows
        {
            get;
            set;
        }
        

        /// <summary>
        /// 编辑的行
        /// </summary>
        //public DataRow EditRow { get; set; }
        private string _groupColumn;
        [Description("分组字段名称")]
        public string GroupColumn
        {
            get
            {
                return _groupColumn;
            }
            set
            {
                _groupColumn = value;
            }
        }

        /// <summary>
        /// 销售单号
        /// </summary>
        public string SaleBillCode { get; set; }

        /// <summary>
        /// 出库复核单号
        /// </summary>
        public string ReviewCode { get; set; }

        public int DealerID { get; set; }

        public string DealerName { get; set; }

        public FrmReviewRecordQuery()
        {
            InitializeComponent();
        }

        public FrmReviewRecordQuery(int dealerID, string dealerName)
        {
            InitializeComponent();
            this.txtDealerName.Tag = dealerID;
            this.txtDealerName.Text = dealerName;

            DealerID = dealerID;
            DealerName = dealerName;
        }

        private void FrmReviewRecordQuery_Load(object sender, EventArgs e)
        {
            this.gvBill.GridViewData.FocusedRowChanged += GridViewData_FocusedRowChanged;
        }

        public void GridViewData_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            ChangeFocusedReview(e);
        }

        private void ChangeFocusedReview(FocusedRowChangedEventArgs e)
        {
            object reviewCode = this.gvBill.GridViewData.GetRowCellValue(e.FocusedRowHandle, "复核单号");
            object saleBillCode = this.gvBill.GridViewData.GetRowCellValue(e.FocusedRowHandle, "销售单号");
            int dealerId = int.Parse(this.gvBill.GridViewData.GetRowCellValue(e.FocusedRowHandle, "往来单位ID").ToString());
            string dealerName = this.gvBill.GridViewData.GetRowCellValue(e.FocusedRowHandle, "往来单位名称").ToString();
            if (DealerID != dealerId)
            {
                DealerID = dealerId;
                txtDealerName.Tag = dealerId;
            }
            if (DealerName != dealerName)
            {
                DealerName = dealerName;
                txtDealerName.Text = dealerName;
            }

            if (reviewCode != null && reviewCode != DBNull.Value)
            {
                if (saleBillCode != null && saleBillCode != DBNull.Value)
                {
                    this.SaleBillCode = saleBillCode.ToString();
                }
                this.ReviewCode = reviewCode.ToString();

                DataTable data = GlobalMethod.GetReviewDetialByProduct(reviewCode.ToString());
                this.gvDetails.DataSource = data;
                var gridView = gvDetails.MainView as GridView;
                gridView.Columns["产品ID"].VisibleIndex = -1;
                gridView.BestFitColumns();
            }
        }

        private void gvDetails_DoubleClick(object sender, EventArgs e)
        {
            this.EditRow = (gvDetails.MainView as GridView).GetFocusedDataRow();

            if (this.EditRow != null)
            {
                this.EditRows[0] = EditRow;
                this.DialogResult = DialogResult.OK;
            }
        }

        private void txtBillCode_BeforePopupShow(object sender, Controls.CommonCode.BeforePopupShowArgs e)
        {
            if(this.txtDealerName.Text.Trim() != "")
            {
                this.txtBillCode.Filter = String.Format("往来单位名称 = '{0}'", this.txtDealerName.Text.Trim());
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string reviewCode = txtBillCode.Text;
            if(!string.IsNullOrWhiteSpace(reviewCode))
            {
                int reviewID = Convert.ToInt32((this.txtBillCode.EditData as DataRow)["复核ID"]);

                string querySql = String.Format("SELECT [复核ID],[复核单号],[复核日期],[复核人员],[销售单号],[往来单位名称],[备注] FROM [dbo].[vw_AllReview] WHERE 复核ID = '{0}'", reviewID);
                using(DataSet dataSet = new DataSet())
                {
                    using(SqlDataAdapter adapter = new SqlDataAdapter(querySql, GlobalItem.g_DbConnectStrings))
                    {
                        adapter.Fill(dataSet);
                    }
                    gvBill.DataSource = dataSet.Tables[0];
                    var gridView = gvBill.MainView as GridView;
                    gridView.Columns["复核ID"].VisibleIndex = -1;
                    gridView.BestFitColumns();
                }
            }
        }

        private void txtBillCode_PopupClosing(object sender, EventArgs e)
        {
            if(this.txtBillCode.EditData != null)
            {
                var dataRow = this.txtBillCode.EditData as DataRow;
                int reviewID = Convert.ToInt32(dataRow["复核ID"]);
                this.txtBillCode.Tag = reviewID;

                string querySql = String.Format("SELECT [复核ID],[复核单号],[复核日期],[复核人员],[销售单号],[往来单位ID],[往来单位名称],[备注] FROM [dbo].[vw_AllReview] WHERE 复核ID = '{0}'", reviewID);
                using(DataSet dataSet = new DataSet())
                {
                    using(SqlDataAdapter adapter = new SqlDataAdapter(querySql, GlobalItem.g_DbConnectStrings))
                    {
                        adapter.Fill(dataSet);
                    }
                    gvBill.DataSource = dataSet.Tables[0];
                    var gridView = gvBill.MainView as GridView;
                    gridView.Columns["复核ID"].VisibleIndex = -1;
                    gridView.Columns["往来单位ID"].VisibleIndex = -1;
                    gridView.BestFitColumns();
                    ChangeFocusedReview(new FocusedRowChangedEventArgs(-1, 0));
                }
            }
        }

        private void txtDealerName_PopupClosing(object sender, EventArgs e)
        {
            if(null != txtDealerName.OldEditValue && txtDealerName.OldEditValue != txtDealerName.EditValue)
            {
                if(DialogResult.Yes == XtraMessageBox.Show("确定要更改退回单的往来单位?", "错误", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    if(this.txtDealerName.EditData != null)
                    {
                        var dataRow = this.txtDealerName.EditData as DataRow;
                        DealerID = int.Parse(dataRow["单位ID"].ToString());
                        DealerName = dataRow["单位名称"].ToString();
                        txtDealerName.Text = DealerName;
                        this.txtDealerName.Tag = DealerID;
                    }
                    if(!string.IsNullOrWhiteSpace(txtBillCode.Text))
                    {
                        txtBillCode.Text = "";
                        txtBillCode.Tag = null;
                        txtBillCode.EditData = null;
                    }
                    if(!string.IsNullOrWhiteSpace(txtProductName.Text))
                    {
                        txtProductName.Text = "";
                        txtProductName.Tag = null;
                        //txtProductName.EditData = null;
                    }
                    if(!string.IsNullOrWhiteSpace(txtBatchNo.Text))
                    {
                        txtBatchNo.Text = "";
                        txtBatchNo.Tag = null;
                    }
                    gvBill.DataSource = null;
                    gvDetails.DataSource = null;
                    gvDetails.RefreshDataSource();
                }
                else
                {
                    return;
                }
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {

            var rowIndexes = gvData.GetSelectedRows().Where(p => p >= 0).ToArray();
            if(rowIndexes.Length == 0)
            {
                XtraMessageBox.Show("请选择要退回的产品明细！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            List<DataRow> rows = new List<DataRow>();
            foreach(var rowIndex in rowIndexes)
            {
                var dataRow = gvData.GetDataRow(rowIndex);
                dataRow.SetAdded();
                rows.Add(dataRow);
            }
            this.EditRows = rows.ToArray();
            this.DialogResult = DialogResult.OK;
        }
    }
}