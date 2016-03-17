using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DQS.Module.Entities;
using ORMSCore;

namespace DQS.Controls
{
    public partial class FrmProductPopupQuery : DevExpress.XtraEditors.XtraForm
    {
        private TextBoxPopupEx m_PopupBox;

        /// <summary>
        /// 编辑的行
        /// </summary>
        public DataRow EditRow { get; set; }

        private string _defaultFilter;
        public FrmProductPopupQuery()
        {
            InitializeComponent();
        }

        public FrmProductPopupQuery(TextBoxPopupEx popupBox) : this()
        {
            //InitializeComponent();

            this.m_PopupBox = popupBox;

            this.txtQuery.FormatQueryString = popupBox.FormatQueryString;

            this.pageNavigator.PrimaryField = popupBox.PrimaryField;
            this.pageNavigator.ViewName = popupBox.ViewName;
            this.pageNavigator.Fields = string.IsNullOrEmpty(popupBox.Fields) ? "*" : popupBox.Fields;
            this.pageNavigator.Filter = string.IsNullOrEmpty(popupBox.Filter) ? "" : popupBox.Filter;
            this.pageNavigator.PageSize = popupBox.PageSize == 0 ? 100 : popupBox.PageSize;

            _defaultFilter = pageNavigator.Filter;
        }

        public FrmProductPopupQuery(string formatQueryString, string viewName, string primaryField, string fields, string filter, int pageSize)
            : this()
        {
            //InitializeComponent();
            this.txtQuery.FormatQueryString = formatQueryString;

            this.pageNavigator.PrimaryField = primaryField;
            this.pageNavigator.ViewName = viewName;
            this.pageNavigator.Fields = string.IsNullOrEmpty(fields) ? "*" : fields;
            this.pageNavigator.Filter = string.IsNullOrEmpty(filter) ? "" : filter;
            this.pageNavigator.PageSize = pageSize == 0 ? 100 : pageSize;
            _defaultFilter = pageNavigator.Filter;
        }

        private void FrmProductPopupQuery_Load(object sender, EventArgs e)
        {
            if (this.Tag != null)
            {
                gpcBottom.Text += string.Format(" / {0}", this.Tag.ToString().Split('$')[1]);
            }
            this.pageNavigator.ShowData();

            DevExpress.XtraGrid.Columns.GridColumn gc = gvData.Columns[1];

            gvData.FocusedColumn = gc;
            gvData.SelectCell(1, gc);
            txtQuery.Focus();
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            SearchProducts();
        }

        private void SearchProducts()
        {
            if (this.txtQuery.Text.Trim().Length > 0)
            {
                if (!string.IsNullOrEmpty(this.pageNavigator.Filter))
                {
                    this.pageNavigator.Filter = "";
                    if (!string.IsNullOrWhiteSpace(_defaultFilter))
                    {
                        this.pageNavigator.Filter = "(" + _defaultFilter + ") AND (" +
                                                    string.Format(this.txtQuery.FormatQueryString, this.txtQuery.Text.Trim()) +
                                                    ")";
                    }
                    else
                    {
                        if (!string.IsNullOrWhiteSpace(this.pageNavigator.Filter))
                        {
                            this.pageNavigator.Filter += " AND (" +
                                                         string.Format(this.txtQuery.FormatQueryString,
                                                             this.txtQuery.Text.Trim()) + ")";
                        }
                        else
                        {
                            this.pageNavigator.Filter = string.Format(this.txtQuery.FormatQueryString, this.txtQuery.Text.Trim());
                        }
                    }
                }
                else
                {
                    if (!string.IsNullOrWhiteSpace(_defaultFilter))
                    {
                        this.pageNavigator.Filter = _defaultFilter;
                    }
                    else
                    {
                        this.pageNavigator.Filter = string.Format(this.txtQuery.FormatQueryString, this.txtQuery.Text.Trim());
                    }
                }
                this.pageNavigator.ShowData();
            }
            else
            {
                if (this.pageNavigator.ViewName != "vw_AllWarehouseInBill" &&
                    this.pageNavigator.ViewName != "vw_AllWarehouseOutBill")
                {
                    if (!string.IsNullOrWhiteSpace(_defaultFilter))
                    {
                        this.pageNavigator.Filter = _defaultFilter;
                    }
                    else
                    {
                        this.pageNavigator.Filter = "";
                    }
                }

                this.pageNavigator.ShowData();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gvData_DoubleClick(object sender, EventArgs e)
        {
            SelectProduct();
        }

        private void SelectProduct()
        {
            this.EditRow = gvData.GetFocusedDataRow();

            if (this.m_PopupBox != null)
            {
                this.m_PopupBox.EditData = gvData.GetFocusedDataRow();
                if (!string.IsNullOrEmpty(this.m_PopupBox.MemberText) && !string.IsNullOrEmpty(this.m_PopupBox.MemberValue))
                {
                    this.m_PopupBox.EditValue2 = gvData.GetFocusedRowCellValue(this.m_PopupBox.MemberValue);
                    if (gvData.GetFocusedRowCellValue(this.m_PopupBox.MemberText) != null)
                    {
                        this.m_PopupBox.Text = gvData.GetFocusedRowCellValue(this.m_PopupBox.MemberText).ToString();
                        this.m_PopupBox.Select(this.m_PopupBox.Text.Length, 0);
                    }
                }
            }

            this.DialogResult = DialogResult.OK;
        }

        private void txtQuery_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                //SendKeys.Send("{TAB}");
                DevExpress.XtraGrid.Columns.GridColumn gc = gvData.Columns[1];
                gvData.FocusedColumn = gc;
                gvData.SelectCell(1, gc);
                gvData.SelectRow(0);
                gvData.Focus();
            }
        }

        private void gvData_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator)
            {
                if (e.RowHandle >= 0)
                {
                    e.Info.DisplayText = (e.RowHandle + 1).ToString();
                }
            }
        }

        private void gvData_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (e.FocusedRowHandle != e.PrevFocusedRowHandle)
            {
                object productID = this.gvData.GetRowCellValue(e.FocusedRowHandle, "产品ID");
                object productName = this.gvData.GetRowCellValue(e.FocusedRowHandle, "产品名称");
                object batchNo = this.gvData.GetRowCellValue(e.FocusedRowHandle, "批号");
                if (null != productID && null != batchNo)
                {
                    gpcBottom.Text = string.Format("历史销售价格 / {0} / {1} : {2}",
                        this.Tag.ToString().Split('$')[1],
                        productName.ToString(),
                        batchNo.ToString());

                    ShowProductSalePriceHistories((int) productID, batchNo.ToString());
                }
            }
        }

        private void ShowProductSalePriceHistories(int productId, string batchNo)
        {
            int dealerID = int.Parse(this.Tag.ToString().Split('$')[0]);
            EntityCollection<BUSProductSalePriceEntity> salePrices = new EntityCollection<BUSProductSalePriceEntity>();
            //salePrices.Fetch(BUSProductSalePriceEntityFields.DealerID == dealerID & BUSProductSalePriceEntityFields.ProductID == productId & BUSProductSalePriceEntityFields.BatchNo == batchNo);
            salePrices.Fetch(BUSProductSalePriceEntityFields.DealerID == dealerID & BUSProductSalePriceEntityFields.ProductID == productId);
            gridControl1.DataSource = salePrices.Cast<BUSProductSalePriceEntity>().AsQueryable().OrderByDescending(p => p.ProductSalePriceID).ToList();
            gridView1.BestFitColumns();
        }

        private void txtQuery_TextChanged(object sender, EventArgs e)
        {
            SearchProducts();
        }

        private void gvControl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char) 13)
            {
                SelectProduct();
            }
        }
    }
}