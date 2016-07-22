using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid;
using DQS.Module.Entities;

namespace DQS.Controls
{
    public partial class FrmPopupQuery : DevExpress.XtraEditors.XtraForm
    {
        private TextBoxPopupEx m_PopupBox;

        /// <summary>
        /// 编辑的行
        /// </summary>
        public DataRow EditRow { get; set; }

        private string _defaultFilter;
        public string GroupColumn { get; set; }

        public string _OperationName;

        bool vw = false;
        public FrmPopupQuery()
        {
            InitializeComponent();
        }

        public FrmPopupQuery(TextBoxPopupEx popupBox)
        {
            InitializeComponent();

            this.m_PopupBox = popupBox;

            this.txtQuery.FormatQueryString = popupBox.FormatQueryString;

            this.pageNavigator.PrimaryField = popupBox.PrimaryField;
            this.pageNavigator.ViewName = popupBox.ViewName;
            this.pageNavigator.Fields = string.IsNullOrEmpty(popupBox.Fields) ? "*" : popupBox.Fields;
            this.pageNavigator.Filter = string.IsNullOrEmpty(popupBox.Filter) ? "" : popupBox.Filter;
            this.pageNavigator.PageSize = popupBox.PageSize == 0 ? 100 : popupBox.PageSize;

            _defaultFilter = pageNavigator.Filter;
            if (this.pageNavigator.ViewName == "vw_AllDealer" || this.pageNavigator.ViewName == "vw_AllProvider")
            {
                vw = true;
            }
        }

        public FrmPopupQuery(string formatQueryString, string viewName, string primaryField, string fields, string filter, int pageSize)
        {
            InitializeComponent();

            this.txtQuery.FormatQueryString = formatQueryString;

            this.pageNavigator.PrimaryField = primaryField;
            this.pageNavigator.ViewName = viewName;
            this.pageNavigator.Fields = string.IsNullOrEmpty(fields) ? "*" : fields;
            this.pageNavigator.Filter = string.IsNullOrEmpty(filter) ? "" : filter;
            this.pageNavigator.PageSize = pageSize == 0 ? 100 : pageSize;
            _defaultFilter = pageNavigator.Filter;

            if (viewName == "vw_AllDealer" || viewName == "vw_AllProvider")
            {
                vw = true;
            }
        }

        private void FrmPopupQuery_Load(object sender, EventArgs e)
        {
            if (pageNavigator.ViewName == "vw_ProductDealer")
            {
                string DealerName = this.Tag.ToString();
                pageNavigator.Filter = "(" + pageNavigator.Filter + ")";
                pageNavigator.DefaultFilter = "([供应商] = '" + DealerName + "')";
            }
            this.pageNavigator.ShowData();
            ShowGroup();

            if (vw)
            {

            #region 过期高亮显示

                GridView grid = this.pageNavigator.GridControl.Views[0] as GridView;
                StyleFormatCondition sfcBatchWarning = new StyleFormatCondition();
                sfcBatchWarning.Appearance.BackColor = Color.Yellow;
                sfcBatchWarning.Appearance.Options.UseBackColor = true;
                sfcBatchWarning.ApplyToRow = true;
                sfcBatchWarning.Column = grid.Columns["过期状态"];
                sfcBatchWarning.Condition = FormatConditionEnum.Equal;
                sfcBatchWarning.Value1 = "即将过期";

                StyleFormatCondition sfcBatchLose = new StyleFormatCondition();
                sfcBatchLose.Appearance.BackColor = Color.Red;
                sfcBatchLose.Appearance.Options.UseBackColor = true;
                sfcBatchLose.ApplyToRow = true;
                sfcBatchLose.Column = grid.Columns["过期状态"];
                sfcBatchLose.Condition = FormatConditionEnum.Equal;
                sfcBatchLose.Value1 = "已过期";

                grid.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] { sfcBatchWarning, sfcBatchLose });
            #endregion

            }
        }


        private void ShowGroup()
        {
            if (!string.IsNullOrWhiteSpace(GroupColumn))
            {
                GridView gridView = this.pageNavigator.GridControl.Views[0] as GridView;
                gridView.OptionsView.RowAutoHeight = true;
                gridView.OptionsView.ShowGroupPanel = true;
                gridView.OptionsView.ShowGroupedColumns = true;
                gridView.Columns[GroupColumn].GroupIndex = 0;
                gridView.ExpandAllGroups();
                gridView.BestFitColumns();
            }
        }
        private void btnQuery_Click(object sender, EventArgs e)
        {
            if (this.txtQuery.Text.Trim().Length > 0)
            {
                if (!string.IsNullOrEmpty(this.pageNavigator.Filter))
                {
                    this.pageNavigator.Filter = "";
                    if (!string.IsNullOrWhiteSpace(_defaultFilter))
                    { 
                        this.pageNavigator.Filter = "("+_defaultFilter+") AND (" + string.Format(this.txtQuery.FormatQueryString, this.txtQuery.Text.Trim())+")";
                    }
                    else
                    {
                        if (!string.IsNullOrWhiteSpace(this.pageNavigator.Filter))
                        {
                            this.pageNavigator.Filter += " AND (" + string.Format(this.txtQuery.FormatQueryString, this.txtQuery.Text.Trim()) + ")";
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
                if (this.pageNavigator.ViewName != "vw_AllWarehouseInBill" && this.pageNavigator.ViewName != "vw_AllWarehouseOutBill")
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
                this.btnQuery_Click(null, null);
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

        private void txtQuery_TextChanged(object sender, EventArgs e)
        {
            this.btnQuery_Click(null, null);
        }

        private void gvData_RowClick(object sender, RowClickEventArgs e)
        {
            if (_OperationName == "Purchase")
            {
                if (e.Clicks == 1 && e.Button == MouseButtons.Right)
                {
                    DataRow selectRow = gvData.GetFocusedDataRow();
                    if (selectRow != null)
                    {
                        var selectedProductID = int.Parse(selectRow["产品ID"].ToString());
                        using (FrmPurchasePrice frm = new FrmPurchasePrice())
                        {
                            frm.GridLoad(selectedProductID);
                            frm.ShowDialog();
                        }
                    }
                }
            }
        }
    }
}