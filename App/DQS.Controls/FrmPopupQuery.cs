﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;

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
        }

        private void FrmPopupQuery_Load(object sender, EventArgs e)
        {
            this.pageNavigator.ShowData();
            ShowGroup();
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
    }
}