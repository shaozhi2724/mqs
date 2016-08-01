using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Xml;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DQS.Controls.CommonCode;
using DQS.Module.Entities;
using ORMSCore;
using System.Reflection;
using DQS.Common;
using DQS.Controls.Properties;

namespace DQS.Controls
{
    public class PopupGrid : GridControl
    {
        public delegate void OnPopupClosedEventHandler(object sender, PopupFormClosedArgs e);

        [Description("弹出窗体关闭后的验证事件")]
        public event OnPopupClosedEventHandler PopupClosed;

        public delegate void OnTotalPriceChangedEventHandler(object sender, TotalPriceChangedArgs e);

        [Description("总价变动事件")]
        public event OnTotalPriceChangedEventHandler TotalPriceChanged;

        [Description("调价总价变动事件")]
        public event OnTotalPriceChangedEventHandler NewTotalPriceChanged;

        [Description("直调销售总价变动事件")]
        public event OnTotalPriceChangedEventHandler NewOnlySaleTotalPriceChanged;

        public delegate void OnBeforePopupFormShowEventHandler(object sender, BeforePopupFormShowArgs e);

        [Description("窗体弹出之前出发的事件")]
        public event OnBeforePopupFormShowEventHandler BeforePopupFormShow;

        private XmlDocument m_Document;
        private GridView gridPopupView;
        private DataTable m_EmptySource;


        //销售界面传参
        public int DealerID;
        public int EmployeeID;
        public int DepartmentID;
        public string AcceptCode;

        //采退界面传参
        public bool IsQualified;


        /// <summary>
        /// OperationSettings 配置文件中的 OperationName
        /// </summary>
        [Description("OperationSettings 配置文件中的 OperationName")]
        public string OperationName { get; set; }

        /// <summary>
        /// 是否计算价格，如果有
        /// </summary>
        [Description("是否计算价格，如果有")]
        public bool IsCalculatePrice { get; set; }

        /// <summary>
        /// 表格
        /// </summary>
        [Description("表格")]
        [Browsable(false)]
        public GridView PopupView
        {
            get
            {
                return gridPopupView;
            }
        }

        /// <summary>
        /// 表格空数据
        /// </summary>
        [Description("表格空数据")]
        [Browsable(false)]
        public DataTable EmptySource
        {
            get
            {
                return m_EmptySource;
            }
        }

        public PopupGrid()
        {
            this.InitializeComponent();

            m_Document = new XmlDocument();
        }

        private void InitializeComponent()
        {
            this.gridPopupView = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridPopupView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // gridPopupView
            // 
            this.gridPopupView.Appearance.EvenRow.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gridPopupView.Appearance.EvenRow.Options.UseBackColor = true;
            this.gridPopupView.Appearance.FocusedCell.BackColor = System.Drawing.Color.Aqua;
            this.gridPopupView.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gridPopupView.Appearance.FocusedRow.BackColor = System.Drawing.Color.Beige;
            this.gridPopupView.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black;
            this.gridPopupView.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridPopupView.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridPopupView.GridControl = this;
            this.gridPopupView.IndicatorWidth = 40;
            this.gridPopupView.Name = "gridPopupView";
            this.gridPopupView.OptionsView.ColumnAutoWidth = false;
            this.gridPopupView.OptionsView.EnableAppearanceEvenRow = true;
            this.gridPopupView.OptionsView.ShowGroupPanel = false;
            this.gridPopupView.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridView_CustomDrawRowIndicator);
            this.gridPopupView.CustomDrawEmptyForeground += new DevExpress.XtraGrid.Views.Base.CustomDrawEventHandler(this.gridView_CustomDrawEmptyForeground);
            // 
            // PopupGrid
            // 
            this.MainView = this.gridPopupView;
            this.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridPopupView});
            ((System.ComponentModel.ISupportInitialize)(this.gridPopupView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        private void gridView_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator)
            {
                if (e.RowHandle >= 0)
                {
                    e.Info.DisplayText = (e.RowHandle + 1).ToString();
                }
            }
        }

        private void gridView_CustomDrawEmptyForeground(object sender, DevExpress.XtraGrid.Views.Base.CustomDrawEventArgs e)
        {
            GridView view = sender as GridView;

            if (view.RowCount != 0) return;//有记录，返回

            using (StringFormat drawFormat = new StringFormat())
            {
                drawFormat.Alignment = drawFormat.LineAlignment = StringAlignment.Center;
                e.Graphics.DrawString("暂无记录.", e.Appearance.Font, SystemBrushes.ControlDark, new RectangleF(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height), drawFormat);
            }
        }

        protected void gridView_RowCellClick(object sender, RowCellClickEventArgs e)
        {
            if (e.Clicks == 2 && e.Button == MouseButtons.Left)
            {
                if (gridPopupView.FocusedColumn.FieldName == "件数" || gridPopupView.FocusedColumn.FieldName == "金额")
                {
                    return;
                }
                else
                {
                    if (e.Column.Tag != null)
                    {
                        if (this.BeforePopupFormShow != null)
                        {
                            BeforePopupFormShowArgs args = new BeforePopupFormShowArgs(e.Column,
                                e.Column.Tag as OperationGridColumn);
                            this.BeforePopupFormShow(this, args);
                            if (args.Cancel)
                            {
                                //若事件关闭后处理结果为true，则直接退出
                                return;
                            }
                        }
                        this.SetPopupForm(e.Column, true);
                    }
                }
            }
        }

        private void gridView_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (gridPopupView.FocusedColumn.FieldName == "件数" || gridPopupView.FocusedColumn.FieldName == "金额")
                {
                    SendKeys.Send("{TAB}");
                }
                else
                {

                    if (gridPopupView.FocusedColumn.Tag != null)
                    {
                        var args = new BeforePopupFormShowArgs(gridPopupView.FocusedColumn,
                            gridPopupView.FocusedColumn.Tag as OperationGridColumn);
                        if (this.BeforePopupFormShow != null)
                        {
                            this.BeforePopupFormShow(this, args);
                        }
                        if (args.Cancel)
                        {
                            //若事件关闭后处理结果为true，则直接退出
                            return;
                        }
                        this.SetPopupForm(gridPopupView.FocusedColumn, true);
                    }
                }
            }
        }

        //设置弹出窗体
        private void SetPopupForm(GridColumn gridColumn, bool isPopupClosed)
        {
            OperationGridColumn col = gridColumn.Tag as OperationGridColumn;

            if (col.PopupForm != null)
            {
                if (col.PopupForm.AllowMultipleSelection)
                {

                    if (this.OperationName == "Sale" && (col.PopupForm.ViewName == "vw_BusinessStoreDetailForSale" || col.PopupForm.ViewName == "vw_BusinessStoreDetailForOutSale"))
                    {
                        //ShowMultipleProductSelectionPopupQuery(isPopupClosed, col);
                        ShowMultipleSelectionPopupQuery(isPopupClosed, col);
                    }
                    else
                    {
                        ShowMultipleSelectionPopupQuery(isPopupClosed, col);
                    }
                }
                else
                {
                    if (this.OperationName == "Sale" && (col.PopupForm.ViewName == "vw_BusinessStoreDetailForSale" || col.PopupForm.ViewName == "vw_BusinessStoreDetailForOutSale"))
                    {
                        //if (!Settings.Default.IsNewStoreDetail)
                        //{
                        //    ShowSingleProductSelectionPopupQuery(isPopupClosed, col);
                        //}
                        //else
                        //{
                            //新库存
                            ShowSingleProductSelectionNew(isPopupClosed, col);
                        //}
                    }
                    else
                    {
                        //if (this.OperationName == "PurchaseBack" && Settings.Default.IsNewStoreDetail)
                        if (this.OperationName == "PurchaseBack")
                        {
                            if (IsQualified)
                            {
                                //新库存
                                ShowSingleProductSelectionNew(isPopupClosed, col);
                            }
                            else
                            {
                                ShowSingleSelectionPopupQuery(isPopupClosed, col);
                            }
                        }
                        else
                        {
                            ShowSingleSelectionPopupQuery(isPopupClosed, col);
                        }
                    }
                }
            }
        }

        private void ShowSingleProductSelectionNew(bool isPopupClosed, OperationGridColumn col)
        {
            using (FrmNewStoreDetail frmnsd = new FrmNewStoreDetail())
            {
                DepartmentID = 0;
                frmnsd.EmployeeID = EmployeeID;
                frmnsd.Department = DepartmentID;
                frmnsd.Tag = this.Tag;
                if (frmnsd.ShowDialog() == DialogResult.OK)
                {
                    DataRow row = frmnsd.EditRow;

                    if (isPopupClosed) //双击开启的窗体有验证，可编辑的回车无验证
                    {
                        #region 窗体关闭后验证事件

                        if (this.PopupClosed != null)
                        {
                            PopupFormClosedArgs args = new PopupFormClosedArgs(row);
                            this.PopupClosed(this, args);
                            if (args.Cancel)
                            {
                                //若事件关闭后处理结果为true，则直接退出
                                return;
                            }
                        }

                        #endregion
                    }

                    foreach (GridColumn gc in gridPopupView.Columns)
                    {
                        if (gc.Tag != null)
                        {
                            OperationGridColumn col2 = gc.Tag as OperationGridColumn;

                            //使用相同窗体的赋值
                            if (col2.PopupFormString == col.PopupFormString)
                            {
                                if (row[col2.PopupField] != null || row[col2.PopupField] != DBNull.Value)
                                {
                                    this.gridPopupView.SetFocusedRowCellValue(col2.ColumnName, row[col2.PopupField]);
                                }
                            }
                        }

                        if (gc.Caption == "数量")
                        {
                            //this.gridPopupView.SetFocusedRowCellValue(gc, row["零售价"]);
                            gridPopupView.FocusedColumn = gc;
                            gridPopupView.SelectCell(gc.ColumnHandle, gc);

                        }

                    }

                    gridPopupView.BestFitColumns();
                }
            }
        }

        private void ShowSingleProductSelectionPopupQuery(bool isPopupClosed, OperationGridColumn col)
        {
            string viewName = col.PopupForm.ViewName;
            if (viewName == "vw_BusinessStoreDetailForSale")
            {
                ATCUserEntity user = new ATCUserEntity { UserID = GlobalItem.g_CurrentUser.UserID };
                user.Fetch();
                if (null != user && !user.UseInternalProductPrice)
                {
                    viewName = "vw_BusinessStoreDetailForOutSale";
                }
            }
            using (FrmProductPopupQuery frmPopupQuery = new FrmProductPopupQuery(col.PopupForm.FormatQueryString,
                viewName,
                col.PopupForm.PrimaryField,
                col.PopupForm.Fields,
                col.PopupForm.Filter,
                col.PopupForm.PageSize))
            {
                frmPopupQuery.Tag = this.Tag;
                if (frmPopupQuery.ShowDialog() == DialogResult.OK)
                {
                    DataRow row = frmPopupQuery.EditRow;

                    if (isPopupClosed) //双击开启的窗体有验证，可编辑的回车无验证
                    {
                        #region 窗体关闭后验证事件

                        if (this.PopupClosed != null)
                        {
                            PopupFormClosedArgs args = new PopupFormClosedArgs(row);
                            this.PopupClosed(this, args);
                            if (args.Cancel)
                            {
                                //若事件关闭后处理结果为true，则直接退出
                                return;
                            }
                        }

                        #endregion
                    }

                    foreach (GridColumn gc in gridPopupView.Columns)
                    {
                        if (gc.Tag != null)
                        {
                            OperationGridColumn col2 = gc.Tag as OperationGridColumn;

                            //使用相同窗体的赋值
                            if (col2.PopupFormString == col.PopupFormString)
                            {
                                if (row[col2.PopupField] != null || row[col2.PopupField] != DBNull.Value)
                                {
                                    this.gridPopupView.SetFocusedRowCellValue(col2.ColumnName, row[col2.PopupField]);
                                }
                            }
                        }

                        if(gc.Caption == "数量")
                        {
                            //this.gridPopupView.SetFocusedRowCellValue(gc, row["零售价"]);
                            gridPopupView.FocusedColumn = gc;
                            gridPopupView.SelectCell(gc.ColumnHandle, gc);

                        }

                    }

                    gridPopupView.BestFitColumns();
                }
            }
        }


        private void ShowSingleSelectionPopupQuery(bool isPopupClosed, OperationGridColumn col)
        {
            if (col.PopupForm.ViewName == "vw_ProductForDealer")
            {
                col.PopupForm.Filter = "([状态] is  null or [状态] = '正常') and [单位ID] = " + DealerID;
            }

            if (this.OperationName == "PurchaseBack" && !IsQualified)
            {
                col.PopupForm.ViewName = "vw_ProductForUnQualified";
            }

            if (this.OperationName == "Accept")
            {
                col.PopupForm.ViewName = "vw_ProductForAccept";
                col.PopupForm.Filter = "单号 = '" + AcceptCode + "'";
            }

            using (FrmPopupQuery frmPopupQuery = new FrmPopupQuery(col.PopupForm.FormatQueryString,
                col.PopupForm.ViewName,
                col.PopupForm.PrimaryField,
                col.PopupForm.Fields,
                col.PopupForm.Filter,
                col.PopupForm.PageSize))
            {
                frmPopupQuery._OperationName = this.OperationName;
                frmPopupQuery.Tag = this.Tag;
                if (frmPopupQuery.ShowDialog() == DialogResult.OK)
                {
                    DataRow row = frmPopupQuery.EditRow;

                    if (isPopupClosed) //双击开启的窗体有验证，可编辑的回车无验证
                    {
                        #region 窗体关闭后验证事件

                        if (this.PopupClosed != null)
                        {
                            PopupFormClosedArgs args = new PopupFormClosedArgs(row);
                            this.PopupClosed(this, args);
                            if (args.Cancel)
                            {
                                //若事件关闭后处理结果为true，则直接退出
                                return;
                            }
                        }

                        #endregion
                    }

                    foreach (GridColumn gc in gridPopupView.Columns)
                    {
                        if (gc.Tag != null)
                        {
                            OperationGridColumn col2 = gc.Tag as OperationGridColumn;

                            //使用相同窗体的赋值
                            if (col2.PopupFormString == col.PopupFormString)
                            {
                                if (row[col2.PopupField] != null || row[col2.PopupField] != DBNull.Value)
                                {
                                    this.gridPopupView.SetFocusedRowCellValue(col2.ColumnName, row[col2.PopupField]);
                                }
                            }
                        }
                    }
                    gridPopupView.BestFitColumns();
                }
            }
        }

        private void ShowMultipleSelectionPopupQuery(bool isPopupClosed, OperationGridColumn col)
        {
            using (FrmPopupQueryMultiple frmPopupQuery = new FrmPopupQueryMultiple(col.PopupForm.FormatQueryString,
                col.PopupForm.ViewName,
                col.PopupForm.PrimaryField,
                col.PopupForm.Fields,
                col.PopupForm.Filter,
                col.PopupForm.PageSize,
                col.PopupForm.GroupFieldName))
            {
                frmPopupQuery.Tag = this.Tag;
                if (frmPopupQuery.ShowDialog() == DialogResult.OK)
                {
                    DataRow[] rows = frmPopupQuery.EditRows;
                    frmPopupQuery.PageSize = rows.Length;
                    if (isPopupClosed) //双击开启的窗体有验证，可编辑的回车无验证
                    {
                        #region 窗体关闭后验证事件

                        if (this.PopupClosed != null)
                        {
                            PopupFormClosedArgs args = new PopupFormClosedArgs(rows);
                            this.PopupClosed(this, args);
                            if (args.Cancel)
                            {
                                //若事件关闭后处理结果为true，则直接退出
                                return;
                            }
                        }

                        #endregion
                    }

                    foreach (DataRow row in rows)
                    {
                        foreach (GridColumn gc in gridPopupView.Columns)
                        {
                            if (gc.Tag != null)
                            {
                                OperationGridColumn col2 = gc.Tag as OperationGridColumn;

                                //使用相同窗体的赋值
                                if (col2.PopupFormString == col.PopupFormString)
                                {
                                    if (row[col2.PopupField] != null || row[col2.PopupField] != DBNull.Value)
                                    {
                                        this.gridPopupView.SetFocusedRowCellValue(col2.ColumnName, row[col2.PopupField]);
                                    }
                                }
                            }
                        }
                        gridPopupView.AddNewRow();
                        gridPopupView.FocusedRowHandle = GridControl.NewItemRowHandle;
                    }

                    gridPopupView.BestFitColumns();
                }
            }
        }

        /// <summary>
        /// 初始化表格
        /// </summary>
        public void InitGrid()
        {
            if (!string.IsNullOrEmpty(this.OperationName))
            {
                List<OperationGridColumn> columns = OperationGridSetting.GetColumns(this.OperationName);

                //根据窗体属性设置对应事件

                List<OperationGridColumn> forms = columns.FindAll(g => g.PopupForm != null);
                bool isDoubleClickForm = forms.Exists(g => g.PopupForm.PopStyle == "DoubleClick");
                if (isDoubleClickForm)
                {
                    this.gridPopupView.RowCellClick += this.gridView_RowCellClick;
                }

                bool isEnterKeyForm = forms.Exists(g => g.PopupForm.PopStyle == "EnterKey");
                if (isEnterKeyForm)
                {
                    this.gridPopupView.KeyPress += this.gridView_KeyPress;
                }

                if (this.IsCalculatePrice)
                {
                    this.gridPopupView.CellValueChanging += this.gridPopupView_CellValueChanging;
                }

                int visibleCount = columns.FindAll(g => g.Visible == false).Count;

                for (int i = 0; i < columns.Count; i++)
                {
                    GridColumn colField = new GridColumn
                    {
                        Caption = columns[i].ColumnName,
                        FieldName = columns[i].ColumnName,
                        Name = "col" + columns[i].ColumnName,
                        Tag = columns[i]
                    };

                    if (colField.Caption.Length > 4)//设置列宽
                    {
                        colField.Width = 16 * colField.Caption.Length;
                    }
                    colField.OptionsColumn.AllowEdit = columns[i].AllowEdit;
/*
                    if (!columns[i].Visible)//设置隐藏列
                    {
                        colField.Visible = false;
                        colField.VisibleIndex = -1;
                    }
                    else
                    {
                        colField.Visible = columns[i].Visible;
                        colField.VisibleIndex = i - visibleCount;
                    }*/

                    colField.Visible = columns[i].Visible;
                    colField.VisibleIndex = !columns[i].Visible ? -1 : i;
                    this.gridPopupView.Columns.Add(colField);
                }

                DataTable emptyData = OperationGridSetting.GetEmptyData(this.OperationName);
                this.m_EmptySource = emptyData;
                this.DataSource = emptyData;

                gridPopupView.BestFitColumns();
            }
        }

        //计算金额
        private void gridPopupView_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (this.IsCalculatePrice)
            {
                if (e.Column.Caption == "单价")
                {
                    double price = 0.0;
                    try
                    {
                        if (e.Value.ToString().Trim() != "")
                        {
                            price = Convert.ToDouble(e.Value);
                        }
                    }
                    catch
                    {
                        XtraMessageBox.Show("单价输入格式错误.", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }

                    object amount = this.gridPopupView.GetFocusedRowCellValue("数量");
                    if (amount != null && amount != DBNull.Value)
                    {
                        try
                        {
                            double changedPrice = price * Convert.ToDouble(amount);
                            this.gridPopupView.SetFocusedRowCellValue("金额", changedPrice);

                            //触发事件
                            if (this.TotalPriceChanged != null)
                            {
                                this.TotalPriceChanged(this, new TotalPriceChangedArgs(this.GetSummaryPrice()));
                            }
                        }
                        catch
                        {
                            XtraMessageBox.Show("计算金额发生错误.", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            this.gridPopupView.SetFocusedRowCellValue("金额", 0);
                        }
                    }
                }
                if (e.Column.Caption == "调整单价")
                {
                    double price = 0.0D;
                    try
                    {
                        if (e.Value.ToString().Trim() != "")
                        {
                            price = Convert.ToDouble(e.Value);
                        }
                    }
                    catch
                    {
                        XtraMessageBox.Show("单价输入格式错误.", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }

                    object amount = this.gridPopupView.GetFocusedRowCellValue("数量");
                    if (amount != null && amount != DBNull.Value)
                    {
                        try
                        {
                            double oldUnitPrice = Convert.ToDouble(gridPopupView.GetFocusedRowCellValue("单价"));
                            double oldTotalPrice = Convert.ToDouble(gridPopupView.GetFocusedRowCellValue("金额"));
                            double changedPrice = price * Convert.ToDouble(amount);
                            this.gridPopupView.SetFocusedRowCellValue("调价后金额", changedPrice);

                            this.gridPopupView.SetFocusedRowCellValue("差价", (double)((decimal)price - (decimal)oldUnitPrice));
                            this.gridPopupView.SetFocusedRowCellValue("差价金额", (double)((decimal)changedPrice - (decimal)oldTotalPrice));

                            //触发事件
                            if (this.NewTotalPriceChanged != null)
                            {
                                this.NewTotalPriceChanged(this, new TotalPriceChangedArgs(this.GetNewSummaryPrice()));
                            }
                        }
                        catch
                        {
                            XtraMessageBox.Show("计算金额发生错误.", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            this.gridPopupView.SetFocusedRowCellValue("调价后金额", 0);
                        }
                    }
                }
                if (e.Column.Caption == "销售单价")
                {
                    double price = 0.0D;
                    try
                    {
                        if (e.Value.ToString().Trim() != "")
                        {
                            price = Convert.ToDouble(e.Value);
                        }
                    }
                    catch
                    {
                        XtraMessageBox.Show("单价输入格式错误.", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }

                    object amount = this.gridPopupView.GetFocusedRowCellValue("数量");
                    if (amount != null && amount != DBNull.Value)
                    {
                        try
                        {
                            double changedPrice = price * Convert.ToDouble(amount);
                            this.gridPopupView.SetFocusedRowCellValue("销售金额", changedPrice);


                            //触发事件
                            if (this.NewOnlySaleTotalPriceChanged != null)
                            {
                                this.NewOnlySaleTotalPriceChanged(this, new TotalPriceChangedArgs(this.GetOnlySummaryPrice()));
                            }
                        }
                        catch
                        {
                            XtraMessageBox.Show("计算金额发生错误.", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            this.gridPopupView.SetFocusedRowCellValue("销售金额", 0);
                        }
                    }
                }

                if (e.Column.Caption == "数量")
                {
                    int amount = 0;
                    try
                    {
                        if (e.Value.ToString().Trim() != "")
                        {
                            amount = Convert.ToInt32(e.Value);
                        }
                    }
                    catch
                    {
                        XtraMessageBox.Show("数量输入格式错误.", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }

                    object price = this.gridPopupView.GetFocusedRowCellValue("单价");
                    if (price != null || price != DBNull.Value)
                    {
                        try
                        {
                            double changedPrice = Convert.ToDouble(price) * Convert.ToDouble(amount);
                            this.gridPopupView.SetFocusedRowCellValue("金额", changedPrice);

                            //触发事件
                            if (this.TotalPriceChanged != null)
                            {
                                this.TotalPriceChanged(this, new TotalPriceChangedArgs(this.GetSummaryPrice()));
                            }
                        }
                        catch
                        {
                            XtraMessageBox.Show("计算金额发生错误.", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            this.gridPopupView.SetFocusedRowCellValue("金额", 0);
                        }
                    }

                    object packagingAmount = this.gridPopupView.GetFocusedRowCellValue("包装比例");
                    if (packagingAmount != null || packagingAmount != DBNull.Value)
                    {
                        try
                        {
                            int package = 0;
                            if (int.TryParse(packagingAmount.ToString(), out package))
                            {
                                if (package > 0)
                                {
                                    double packageCount = Convert.ToDouble(amount / package);
                                    this.gridPopupView.SetFocusedRowCellValue("件数", packageCount);
                                }
                            }
                        }
                        catch
                        {
                            XtraMessageBox.Show("计算件数发生错误.", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            this.gridPopupView.SetFocusedRowCellValue("件数", 0);
                        }
                    }
                }
            }
        }

        //获取表格中的总额
        public double GetSummaryPrice()
        {
            double totalPrice = 0.0;
            for (int i = 0; i < this.gridPopupView.RowCount; i++)
            {
                object price = this.gridPopupView.GetRowCellValue(i, "金额");
                if (price != null && price != DBNull.Value)
                {
                    totalPrice += Convert.ToDouble(price);
                }
            }
            return totalPrice;
        }

        //获取表格中的总额
        public double GetNewSummaryPrice()
        {
            double totalPrice = 0.0;
            for (int i = 0; i < this.gridPopupView.RowCount; i++)
            {
                object price = this.gridPopupView.GetRowCellValue(i, "调价后金额");
                if (price != null && price != DBNull.Value)
                {
                    totalPrice += Convert.ToDouble(price);
                }
            }
            return totalPrice;
        }
        public double GetOnlySummaryPrice()
        {
            double totalPrice = 0.0;
            for (int i = 0; i < this.gridPopupView.RowCount; i++)
            {
                object price = this.gridPopupView.GetRowCellValue(i, "销售金额");
                if (price != null && price != DBNull.Value)
                {
                    totalPrice += Convert.ToDouble(price);
                }
            }
            return totalPrice;
        }

        /// <summary>
        /// 获取表格中的实体集合
        /// </summary>
        /// <returns>实体集合</returns>
        public List<EntityBase> GetEntities(bool validation = true)
        {
            try
            {
                string entityName = OperationGridSetting.GetEntityNameByOpName(this.OperationName);

                if (string.IsNullOrEmpty(entityName)) throw new Exception("未配置对应实体名称。");

                List<EntityBase> entities = new List<EntityBase>();

                for (int i = 0; i < this.gridPopupView.RowCount; i++)
                {
                    //根据第一个列的值判断本行是否需要加载实体
                    object fieldValue = this.gridPopupView.GetRowCellValue(i, this.gridPopupView.Columns[0]);
                    if (fieldValue == null || fieldValue == DBNull.Value)
                    {
                        continue;
                    }

                    EntityBase entity = Activator.CreateInstance(Type.GetType(entityName)) as EntityBase;

                    this.GetEntityFromRow(entity, i, validation);

                    entities.Add(entity);
                }

                if (entities.Count == 0)
                {
                    throw new Exception("列表不能为空。");
                }
                return entities;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 从每行数据中设置实体的各属性的值
        /// </summary>
        /// <param name="entity">实体</param>
        /// <param name="rowHandle">行标识</param>
        private void GetEntityFromRow(EntityBase entity, int rowHandle, bool validation = true)
        {
            foreach (GridColumn gridColumn in this.gridPopupView.Columns)
            {
                if (gridColumn.Tag != null)
                {
                    OperationGridColumn col = gridColumn.Tag as OperationGridColumn;
                    if (!string.IsNullOrEmpty(col.EntityField))
                    {
                        //查找实体有无属性
                        PropertyInfo property = entity.GetType().GetProperty(col.EntityField);
                        if (property == null)
                        {
                            throw new Exception(String.Format("配置有误，未在实体“{0}”找到名称为“{1}”的属性。", entity.GetType().Name, col.EntityField));
                        }

                        //判断值是否为空
                        object fieldValue = this.gridPopupView.GetRowCellValue(rowHandle, gridColumn);
                        if (fieldValue == null || fieldValue == DBNull.Value)
                        {
                            if (validation && !col.Nullable)//若不可为空,错误警告
                            {
                                this.gridPopupView.FocusedColumn = gridColumn;
                                this.gridPopupView.FocusedRowHandle = rowHandle;

                                throw new Exception(String.Format("列表中第“{0}”行的“{1}”不能为空。", rowHandle + 1, col.ColumnName));
                            }
                        }
                        else
                        {
                            if (validation && string.IsNullOrEmpty(fieldValue.ToString()) && !col.Nullable)//空字符串判断
                            {
                                this.gridPopupView.FocusedColumn = gridColumn;
                                this.gridPopupView.FocusedRowHandle = rowHandle;
                                throw new Exception(String.Format("列表中第“{0}”行的“{1}”不能为空。", rowHandle + 1, col.ColumnName));
                            }

                            //判断类型是否统一可转换
                            try
                            {
                                fieldValue = Convert.ChangeType(fieldValue, property.PropertyType);
                            }
                            catch
                            {

                                throw new Exception(String.Format("列表中第“{0}”行的“{1}”类型转换出错。", rowHandle + 1, col.ColumnName));
                            }

                            property.SetValue(entity, fieldValue, null);
                        }

                    }
                }
            }
        }

        /// <summary>
        /// 设置表格的数据
        /// </summary>
        /// <param name="keyValue">标识</param>
        public void SetGridData(object keyValue)
        {
            #region 已注销//

            //string[] viewParams = OperationGridSetting.GetGridViewParams(this.OperationName);

            //if (viewParams == null) return;

            //if (string.IsNullOrEmpty(viewParams[0]) || string.IsNullOrEmpty(viewParams[1])) return;

            //DataTable data = GlobalMethod.GetViewData(viewParams[0], viewParams[1], keyValue);

            //for (int i = 0; i < data.Rows.Count; i++)
            //{
            //    foreach (DataColumn col in data.Columns)
            //    {
            //        this.gridPopupView.SetRowCellValue(i, col.ColumnName, data.Rows[i][col]);
            //    }
            //}

            #endregion

            this.SetGridData(keyValue, false);
        }

        /// <summary>
        /// 设置表格的数据
        /// </summary>
        /// <param name="keyValue">标识</param>
        public void SetGridData(object keyValue, bool rowCountNew)
        {
            string[] viewParams = OperationGridSetting.GetGridViewParams(this.OperationName);

            if (viewParams == null) return;

            if (string.IsNullOrEmpty(viewParams[0]) || string.IsNullOrEmpty(viewParams[1])) return;

            #region 已注销//

            //DataTable data = GlobalMethod.GetViewData(viewParams[0], viewParams[1], keyValue);

            //if (rowCountNew)
            //{
            //    this.EmptySource.Clear();
            //    for (int i = 0; i < data.Rows.Count; i++)
            //    {
            //        DataRow row = this.EmptySource.NewRow();
            //        this.EmptySource.Rows.Add(row);
            //    }
            //}
            //else
            //{
            //    this.ClearGrid();
            //}

            //for (int i = 0; i < data.Rows.Count; i++)
            //{
            //    foreach (DataColumn col in data.Columns)
            //    {
            //        this.gridPopupView.SetRowCellValue(i, col.ColumnName, data.Rows[i][col]);
            //    }
            //}

            #endregion

            this.SetGridData(viewParams[0], viewParams[1], keyValue, rowCountNew);
        }

        /// <summary>
        /// 设置表格的数据
        /// </summary>
        /// <param name="viewName">视图名称</param>
        /// <param name="keyField">标识字段</param>
        /// <param name="keyValue">标识字段值</param>
        public void SetGridData(string viewName, string keyField, object keyValue, bool rowCountNew)
        {
            DataTable data = GlobalMethod.GetViewData(viewName, keyField, keyValue);

            if (rowCountNew)
            {
                this.EmptySource.Clear();
                for (int i = 0; i < data.Rows.Count; i++)
                {
                    DataRow row = this.EmptySource.NewRow();
                    this.EmptySource.Rows.Add(row);
                }
            }
            else
            {
                this.ClearGrid();
            }

            for (int i = 0; i < data.Rows.Count; i++)
            {
                foreach (DataColumn col in data.Columns)
                {
                    this.gridPopupView.SetRowCellValue(i, col.ColumnName, data.Rows[i][col]);
                }
            }
            gridPopupView.BestFitColumns();
        }

        /// <summary>
        /// 设置表格的数据
        /// </summary>
        public void SetGridData(string viewName, string filter, bool rowCountNew)
        {
            DataTable data = GlobalMethod.GetViewData(viewName, filter);

            if (rowCountNew)
            {
                this.EmptySource.Clear();
                for (int i = 0; i < data.Rows.Count; i++)
                {
                    DataRow row = this.EmptySource.NewRow();
                    this.EmptySource.Rows.Add(row);
                }
            }
            else
            {
                this.ClearGrid();
            }

            for (int i = 0; i < data.Rows.Count; i++)
            {
                foreach (DataColumn col in data.Columns)
                {
                    this.gridPopupView.SetRowCellValue(i, col.ColumnName, data.Rows[i][col]);
                }
            }
            gridPopupView.BestFitColumns();
        }

        /// <summary>
        /// 清除表格数据
        /// </summary>
        public void ClearGrid()
        {
            int emptyRows = this.EmptySource.Rows.Count;

            this.EmptySource.Clear();

            for (int i = 0; i < emptyRows; i++)
            {
                DataRow row = this.EmptySource.NewRow();

                this.EmptySource.Rows.Add(row);
            }

            this.DataSource = this.EmptySource;

            gridPopupView.BestFitColumns();
        }

        /// <summary>
        /// 清除表格数据
        /// </summary>
        /// <param name="rowHandle">行序号</param>
        public void ClearGrid(int rowHandle)
        {
            DataRow row = this.EmptySource.NewRow();
            foreach (DataColumn col in this.EmptySource.Columns)
            {
                this.gridPopupView.SetRowCellValue(rowHandle, col.ColumnName, row[col]);
            }

            gridPopupView.BestFitColumns();
        }

        public void RemoveRowCellClickEvent()
        {
            gridPopupView.RowCellClick -= gridView_RowCellClick;
        }
    }
}
