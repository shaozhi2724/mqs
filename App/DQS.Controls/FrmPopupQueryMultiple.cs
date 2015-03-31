using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;

namespace DQS.Controls
{
    public partial class FrmPopupQueryMultiple : DevExpress.XtraEditors.XtraForm
    {
        private TextBoxPopupMultipleEx m_PopupBox;

        public int PageSize
        {
            set
            {
                this.pageNavigator.PageSize = value == 0 ? 100 : value;
            }
        }
        /// <summary>
        /// 编辑的行
        /// </summary>
        public DataRow[] EditRows { get; set; }

        /// <summary>
        /// 编辑的行
        /// </summary>
        //public DataRow EditRow { get; set; }
        private string _groupColumn;
        [Description("分组字段名称")]
        public string GroupColumn
        {
            get { return _groupColumn; }
            set { _groupColumn = value; }
        }
        public FrmPopupQueryMultiple()
        {
            InitializeComponent();
        }

        public FrmPopupQueryMultiple(TextBoxPopupMultipleEx popupBox)
        {
            InitializeComponent();

            this.m_PopupBox = popupBox;

            this.txtQuery.FormatQueryString = popupBox.FormatQueryString;

            this.pageNavigator.PrimaryField = popupBox.PrimaryField;
            this.pageNavigator.ViewName = popupBox.ViewName;
            this.pageNavigator.Fields = string.IsNullOrEmpty(popupBox.Fields) ? "*" : popupBox.Fields;
            this.pageNavigator.Filter = string.IsNullOrEmpty(popupBox.Filter) ? "" : popupBox.Filter;
            this.pageNavigator.PageSize = popupBox.PageSize == 0 ? 100 : popupBox.PageSize;
            if(!string.IsNullOrWhiteSpace(GroupColumn))
            {
                _groupColumn = GroupColumn;
            }
            else
            {
                _groupColumn = string.Empty;
            }
        }

        public FrmPopupQueryMultiple(string formatQueryString, string viewName, string primaryField, string fields, string filter, int pageSize, string groupColumn)
        {
            InitializeComponent();

            this.txtQuery.FormatQueryString = formatQueryString;

            this.pageNavigator.PrimaryField = primaryField;
            this.pageNavigator.ViewName = viewName;
            this.pageNavigator.Fields = string.IsNullOrEmpty(fields) ? "*" : fields;
            this.pageNavigator.Filter = string.IsNullOrEmpty(filter) ? "" : filter;
            this.pageNavigator.PageSize = pageSize == 0 ? 100 : pageSize;
            if (!string.IsNullOrWhiteSpace(groupColumn))
            {
                _groupColumn = groupColumn;
            }
            else
            {
                _groupColumn = string.Empty;
            }
        }

        private void FrmPopupQueryMultiple_Load(object sender, EventArgs e)
        {
            this.pageNavigator.ShowData();
            ShowGroup();
            this.btnSelect.Enabled = (this.pageNavigator.GridControl.Views[0] as GridView).DataRowCount > 0;
        }

        private void ShowGroup()
        {
            if (!string.IsNullOrWhiteSpace(_groupColumn))
            {
                GridView gridView = this.pageNavigator.GridControl.Views[0] as GridView;
                gridView.OptionsView.RowAutoHeight = true;
                gridView.OptionsView.ShowGroupPanel = true;
                gridView.OptionsView.ShowGroupedColumns = true;
                gridView.Columns[_groupColumn].GroupIndex = 0;
                gridView.ExpandAllGroups();
                gridView.BestFitColumns();
            }
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            if (this.txtQuery.Text.Trim().Length > 0)
            {
                this.pageNavigator.Filter = "";
                if (!string.IsNullOrEmpty(this.pageNavigator.Filter))
                {
                    this.pageNavigator.Filter += " AND " + string.Format(this.txtQuery.FormatQueryString, this.txtQuery.Text.Trim());
                }
                else
                {
                    this.pageNavigator.Filter = string.Format(this.txtQuery.FormatQueryString, this.txtQuery.Text.Trim());
                }
                this.pageNavigator.ShowData();
            }
            else
            {
                if (this.pageNavigator.ViewName != "vw_AllWarehouseInBill" && this.pageNavigator.ViewName != "vw_AllWarehouseOutBill")
                {
                    this.pageNavigator.Filter = "";
                }

                this.pageNavigator.ShowData();
            }
            ShowGroup();
            this.btnSelect.Enabled = (this.pageNavigator.GridControl.Views[0] as GridView).DataRowCount > 0;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gvData_DoubleClick(object sender, EventArgs e)
        {
            List<DataRow> rows = new List<DataRow>();
            rows.Add(gvData.GetFocusedDataRow());
            this.EditRows = rows.ToArray();
            if (this.m_PopupBox != null)
            {
                this.m_PopupBox.EditData = EditRows;
                if (!string.IsNullOrEmpty(this.m_PopupBox.MemberText) && !string.IsNullOrEmpty(this.m_PopupBox.MemberValue))
                {
                    this.m_PopupBox.EditValue2 = new object[]{gvData.GetFocusedRowCellValue(this.m_PopupBox.MemberValue)};
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

        private void btnSelect_Click(object sender, EventArgs e)
        {
            var rowIndexes = gvData.GetSelectedRows().Where(p => p >= 0).ToArray();

            List<DataRow> rows = new List<DataRow>();
            foreach (var rowIndex in rowIndexes)
            {
                rows.Add(gvData.GetDataRow(rowIndex));
            }
            this.EditRows = rows.ToArray();
            if (this.m_PopupBox != null)
            {
                this.m_PopupBox.EditData = EditRows;
                //if (!string.IsNullOrEmpty(this.m_PopupBox.MemberText) && !string.IsNullOrEmpty(this.m_PopupBox.MemberValue))
                //{
                //    this.m_PopupBox.EditValue2 = gvData.GetFocusedRowCellValue(this.m_PopupBox.MemberValue);
                //    if (gvData.GetFocusedRowCellValue(this.m_PopupBox.MemberText) != null)
                //    {
                //        this.m_PopupBox.Text = gvData.GetFocusedRowCellValue(this.m_PopupBox.MemberText).ToString();
                //        this.m_PopupBox.Select(this.m_PopupBox.Text.Length, 0);
                //    }
                //}
            }

            this.DialogResult = DialogResult.OK;
        }
    }
}