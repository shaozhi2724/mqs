using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraEditors;
using System.ComponentModel;
using DevExpress.XtraGrid;
using System.Drawing;
using DQS.Module;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;

namespace DQS.Controls
{
    public class PageNavigator : PanelControl
    {
        private LabelControl m_LblPageSize;
        private LabelControl m_LblPageCount;
        private LabelControl m_LblJump;
        private TextEdit m_TxtJump;
        private SimpleButton m_BtnJump;
        private SimpleButton m_BtnFirst;
        private SimpleButton m_BtnPrevious;
        private SimpleButton m_BtnNext;
        private SimpleButton m_BtnLast;

        private string m_Fields = "*";

        private string m_SortField = "";

        private string m_SortType = "";

        private string m_ViewName = "";

        private string m_Filter = "";

        private string m_DefaultFilter = "";

        /// <summary>
        /// 每页大小
        /// </summary>
        [Description("每页大小")]
        public int PageSize { get; set; }

        /// <summary>
        /// 总记录数
        /// </summary>
        [Description("总记录数")]
        public int RecordCount { get; set; }

        /// <summary>
        /// 总页数
        /// </summary>
        [Description("总页数")]
        public int PageCount { get; set; }

        /// <summary>
        /// 当前页
        /// </summary>
        [Description("当前页")]
        public int PageIndex { get; set; }

        /// <summary>
        /// 要显示的字段，以','号分隔，可由'*'号代替
        /// </summary>
        [Description("要显示的字段，以','号分隔，可由'*'号代替")]
        public string Fields
        {
            get { return m_Fields; }
            set { m_Fields = value; }
        }

        /// <summary>
        /// 视图中的主键，ROW_NUMBER分页使用
        /// </summary>
        [Description("视图中的主键，ROW_NUMBER分页使用")]
        public string PrimaryField { get; set; }

        /// <summary>
        /// 排序字段
        /// </summary>
        [Description("排序字段")]
        public string SortField
        {
            get { return m_SortField; }
            set { m_SortField = value; }
        }

        /// <summary>
        /// 排序类型,'ASC'或'DESC'
        /// </summary>
        [Description("排序类型,'ASC'或'DESC'")]
        public string SortType
        {
            get { return m_SortType; }
            set { m_SortType = value; }
        }

        /// <summary>
        /// 视图名称
        /// </summary>
        [Description("视图名称")]
        public string ViewName
        {
            get { return m_ViewName; }
            set { m_ViewName = value; }
        }

        /// <summary>
        /// 查询条件,以'AND'分隔
        /// </summary>
        [Description("查询条件,以'AND'分隔")]
        public string Filter
        {
            get { return m_Filter; }
            set { m_Filter = value; }
        }

        /// <summary>
        /// 查询条件,以'AND'分隔
        /// </summary>
        [Description("默认查询条件,以'AND'分隔")]
        public string DefaultFilter
        {
            get { return m_DefaultFilter; }
            set { m_DefaultFilter = value; }
        }

        /// <summary>
        /// 当前的数据库源
        /// </summary>
        [Browsable(false)]
        public DataTable EmptySource { get; set; }

        /// <summary>
        /// 要绑定的GridControl
        /// </summary>
        [Description("要绑定的GridControl")]
        public GridControl GridControl { get; set; }


        /// <summary>
        /// 初始化控件
        /// </summary>
        private void InitializeComponent()
        {
            this.m_LblPageSize = new DevExpress.XtraEditors.LabelControl();
            this.m_LblPageCount = new DevExpress.XtraEditors.LabelControl();
            this.m_LblJump = new DevExpress.XtraEditors.LabelControl();
            this.m_TxtJump = new DevExpress.XtraEditors.TextEdit();
            this.m_BtnJump = new DevExpress.XtraEditors.SimpleButton();
            this.m_BtnFirst = new DevExpress.XtraEditors.SimpleButton();
            this.m_BtnPrevious = new DevExpress.XtraEditors.SimpleButton();
            this.m_BtnNext = new DevExpress.XtraEditors.SimpleButton();
            this.m_BtnLast = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.m_TxtJump.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // m_LblPageSize
            // 
            this.m_LblPageSize.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_LblPageSize.Appearance.Options.UseFont = true;
            this.m_LblPageSize.Location = new System.Drawing.Point(5, 11);
            this.m_LblPageSize.Name = "m_LblPageSize";
            this.m_LblPageSize.Size = new System.Drawing.Size(161, 18);
            this.m_LblPageSize.TabIndex = 0;
            this.m_LblPageSize.Text = "共0条记录,每页显示0条.";
            // 
            // m_LblPageCount
            // 
            this.m_LblPageCount.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_LblPageCount.Appearance.Options.UseFont = true;
            this.m_LblPageCount.Location = new System.Drawing.Point(221, 11);
            this.m_LblPageCount.Name = "m_LblPageCount";
            this.m_LblPageCount.Size = new System.Drawing.Size(116, 18);
            this.m_LblPageCount.TabIndex = 1;
            this.m_LblPageCount.Text = "当前第0页,共0页.";
            // 
            // m_LblJump
            // 
            this.m_LblJump.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_LblJump.Appearance.Options.UseFont = true;
            this.m_LblJump.Location = new System.Drawing.Point(382, 11);
            this.m_LblJump.Name = "m_LblJump";
            this.m_LblJump.Size = new System.Drawing.Size(75, 18);
            this.m_LblJump.TabIndex = 3;
            this.m_LblJump.Text = "跳转";
            // 
            // m_TxtJump
            // 
            this.m_TxtJump.Location = new System.Drawing.Point(415, 10);
            this.m_TxtJump.Name = "m_TxtJump";
            this.m_TxtJump.Size = new System.Drawing.Size(43, 25);
            this.m_TxtJump.TabIndex = 2;
            // 
            // m_BtnJump
            // 
            this.m_BtnJump.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_BtnJump.Appearance.Options.UseFont = true;
            this.m_BtnJump.Location = new System.Drawing.Point(460, 9);
            this.m_BtnJump.Name = "m_BtnJump";
            this.m_BtnJump.Size = new System.Drawing.Size(33, 23);
            this.m_BtnJump.TabIndex = 4;
            this.m_BtnJump.Text = "GO";
            this.m_BtnJump.Click += new System.EventHandler(this.BtnJump_Click);
            // 
            // m_BtnFirst
            // 
            this.m_BtnFirst.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_BtnFirst.Appearance.Options.UseFont = true;
            this.m_BtnFirst.Location = new System.Drawing.Point(495, 9);
            this.m_BtnFirst.Name = "m_BtnFirst";
            this.m_BtnFirst.Size = new System.Drawing.Size(75, 23);
            this.m_BtnFirst.TabIndex = 5;
            this.m_BtnFirst.Text = "首页(&F)";
            this.m_BtnFirst.Click += new System.EventHandler(this.BtnFirst_Click);
            // 
            // m_BtnPrevious
            // 
            this.m_BtnPrevious.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_BtnPrevious.Appearance.Options.UseFont = true;
            this.m_BtnPrevious.Location = new System.Drawing.Point(570, 9);
            this.m_BtnPrevious.Name = "m_BtnPrevious";
            this.m_BtnPrevious.Size = new System.Drawing.Size(75, 23);
            this.m_BtnPrevious.TabIndex = 6;
            this.m_BtnPrevious.Text = "上一页(&P)";
            this.m_BtnPrevious.Click += new System.EventHandler(this.BtnPrevious_Click);
            // 
            // m_BtnNext
            // 
            this.m_BtnNext.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_BtnNext.Appearance.Options.UseFont = true;
            this.m_BtnNext.Location = new System.Drawing.Point(645, 9);
            this.m_BtnNext.Name = "m_BtnNext";
            this.m_BtnNext.Size = new System.Drawing.Size(75, 23);
            this.m_BtnNext.TabIndex = 7;
            this.m_BtnNext.Text = "下一页(&N)";
            this.m_BtnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // m_BtnLast
            // 
            this.m_BtnLast.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_BtnLast.Appearance.Options.UseFont = true;
            this.m_BtnLast.Location = new System.Drawing.Point(720, 9);
            this.m_BtnLast.Name = "m_BtnLast";
            this.m_BtnLast.Size = new System.Drawing.Size(75, 23);
            this.m_BtnLast.TabIndex = 8;
            this.m_BtnLast.Text = "末页(&L)";
            this.m_BtnLast.Click += new System.EventHandler(this.BtnLast_Click);
            // 
            // PageNavigator
            // 
            this.Controls.Add(this.m_LblPageSize);
            this.Controls.Add(this.m_LblPageCount);
            this.Controls.Add(this.m_TxtJump);
            this.Controls.Add(this.m_LblJump);
            this.Controls.Add(this.m_BtnJump);
            this.Controls.Add(this.m_BtnFirst);
            this.Controls.Add(this.m_BtnPrevious);
            this.Controls.Add(this.m_BtnNext);
            this.Controls.Add(this.m_BtnLast);
            this.MinimumSize = new System.Drawing.Size(800, 40);
            this.Size = new System.Drawing.Size(800, 40);
            ((System.ComponentModel.ISupportInitialize)(this.m_TxtJump.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void BtnLast_Click(object sender, EventArgs e)
        {
            this.PageIndex = this.PageCount - 1;
            this.ShowData();
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            this.PageIndex++;
            if (this.PageIndex >= this.PageCount - 1)
            {
                this.PageIndex = this.PageCount - 1;
            }
            this.ShowData();

        }

        private void BtnPrevious_Click(object sender, EventArgs e)
        {
            this.PageIndex--;
            if (this.PageIndex <= 0)
            {
                this.PageIndex = 0;
            }
            this.ShowData();
        }

        private void BtnFirst_Click(object sender, EventArgs e)
        {
            this.PageIndex = 0;
            this.ShowData();
        }

        private void BtnJump_Click(object sender, EventArgs e)
        {
            int pageIndex = 0;
            if (int.TryParse(this.m_TxtJump.Text.Trim(), out pageIndex))
            {
                if (pageIndex > this.PageCount)
                {
                    pageIndex = 0;
                    m_TxtJump.Text = "1";
                }
                else if (pageIndex > 0 && pageIndex <= this.PageCount)
                {
                    pageIndex = pageIndex - 1;
                }
            }
            else
            {
                m_TxtJump.Text = "1";
            }

            this.PageIndex = pageIndex;
            this.ShowData();

        }

        public PageNavigator()
        {
            InitializeComponent();
            this.PageSize = 50;
            this.Filter = "";

        }

        /// <summary>
        /// 显示数据
        /// </summary>
        public void ShowData()
        {

            int pPageCount = 0;
            int pRecordCount = 0;

            try
            {
                string filter = this.Filter;
                if (!string.IsNullOrWhiteSpace(this.DefaultFilter))
                {
                    if (!string.IsNullOrWhiteSpace(Filter))
                    {
                        filter = string.Join(" AND ", Filter, DefaultFilter);
                    }
                    else
                    {
                        filter = DefaultFilter;
                    }
                }
                DataSet data = Procedures.Pagination(this.Fields, this.ViewName, this.PrimaryField, this.SortField, this.SortType, this.PageSize, this.PageIndex, filter, ref pPageCount, ref pRecordCount);
                this.PageCount = pPageCount;
                this.RecordCount = pRecordCount;

                this.m_LblPageSize.Text = string.Format("共{0}条记录,每页显示{1}条.", pRecordCount, this.PageSize);
                this.m_LblPageCount.Text = string.Format("当前第{0}页,共{1}页.", this.PageIndex + 1, pPageCount);

                if (this.GridControl != null)
                {
                    
                    this.EmptySource = data.Tables[0].Clone();

                    this.PopulateGridColumns();
                    this.GridControl.DataSource = data.Tables[0];

                    #region 设定时间显示格式

                    GridView view = this.GridControl.Views[0] as GridView;
                    foreach (GridColumn item in view.Columns)
                    {
                        if (item.ColumnType.Name == "DateTime")
                        {
                            if (item.FieldName.IndexOf("时间") >= 0)
                            {
                                item.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
                                item.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm:ss";
                            }
                            else
                            {
                                item.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
                                item.DisplayFormat.FormatString = "yyyy-MM-dd";
                            }
                        }
                        // TODO:完善统计
                        //if (item.FieldName == "Price")
                        //{
                        //    //小计列添加汇总
                        //    view.OptionsView.ShowFooter = true;     //显示表格页脚
                        //    view.Columns["Price"].SummaryItem.FieldName = "Price";
                        //    view.Columns["Price"].SummaryItem.DisplayFormat = "{0:f2}";
                        //    view.Columns["Price"].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
                        //}
                    }
                    view.BestFitColumns();
                    #endregion


                    if (ViewName == "vw_StoreDetail" || ViewName == "vw_BusinessStoreDetail" || ViewName == "vw_BusinessStoreDetailForSale")
                    {
                        #region 过期高亮显示

                        StyleFormatCondition sfcBatchWarning = new StyleFormatCondition();
                        sfcBatchWarning.Appearance.BackColor = Color.Yellow;
                        sfcBatchWarning.Appearance.Options.UseBackColor = true;
                        sfcBatchWarning.ApplyToRow = true;
                        sfcBatchWarning.Column = view.Columns["过期状态"];
                        sfcBatchWarning.Condition = FormatConditionEnum.Equal;
                        sfcBatchWarning.Value1 = "即将过期";

                        StyleFormatCondition sfcBatchLose = new StyleFormatCondition();
                        sfcBatchLose.Appearance.BackColor = Color.Red;
                        sfcBatchLose.Appearance.Options.UseBackColor = true;
                        sfcBatchLose.ApplyToRow = true;
                        sfcBatchLose.Column = view.Columns["过期状态"];
                        sfcBatchLose.Condition = FormatConditionEnum.Equal;
                        sfcBatchLose.Value1 = "已过期";

                        StyleFormatCondition sfcProductLocked = new StyleFormatCondition();
                        sfcProductLocked.Appearance.BackColor = Color.Red;
                        sfcProductLocked.Appearance.Options.UseBackColor = true;
                        sfcProductLocked.ApplyToRow = true;
                        sfcProductLocked.Column = view.Columns["锁定状态"];
                        sfcProductLocked.Condition = FormatConditionEnum.Equal;
                        sfcProductLocked.Value1 = "已锁定";

                        view.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] { sfcBatchWarning, sfcBatchLose, sfcProductLocked });

                        #endregion
                    }

                    if (ViewName == "vw_AllSale" || ViewName == "vw_AllSaleBack" || ViewName == "vw_AllPurchase" || ViewName == "vw_AllPurchaseBack")
                    {
                        #region 已删除的高亮显示

                        StyleFormatCondition sfcDeleted = new StyleFormatCondition();
                        sfcDeleted.Appearance.BackColor = Color.Red;
                        sfcDeleted.Appearance.Options.UseBackColor = true;
                        sfcDeleted.ApplyToRow = true;
                        sfcDeleted.Column = view.Columns["状态"];
                        sfcDeleted.Condition = FormatConditionEnum.Equal;
                        sfcDeleted.Value1 = "已删除";

                        view.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] { sfcDeleted });

                        #endregion
                    }
                    if (ViewName == "vw_AllSale" || ViewName == "vw_AllSaleBack" || ViewName == "vw_AllPurchase" || ViewName == "vw_AllPurchaseBack")
                    {
                        #region 未批准的高亮显示

                        StyleFormatCondition sfcDeleted = new StyleFormatCondition();
                        sfcDeleted.Appearance.BackColor = Color.Red;
                        sfcDeleted.Appearance.Options.UseBackColor = true;
                        sfcDeleted.ApplyToRow = true;
                        sfcDeleted.Column = view.Columns["状态"];
                        sfcDeleted.Condition = FormatConditionEnum.Equal;
                        sfcDeleted.Value1 = "未批准";

                        view.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] { sfcDeleted });

                        #endregion
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "获取数据发生错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PopulateGridColumns()
        {
            //(this.GridControl.Views[0] as GridView).Columns.Clear();

            //GridControl.Views[0].RefreshData();

            //m_GridControl.Views[0].PopulateColumns();//此方法只能初次生效

            if (this.EmptySource != null)
            {
                GridView view = this.GridControl.Views[0] as GridView;
                view.PopulateColumns(this.EmptySource);

                //大于8列不自动填充宽度，滚动条可见
                if (view.Columns.Count > 8)
                {
                    view.OptionsView.ColumnAutoWidth = false;
                }
                else
                {
                    view.OptionsView.ColumnAutoWidth = true;
                }

                //设置列宽度，使标题全部显示
                foreach (DevExpress.XtraGrid.Columns.GridColumn col in view.Columns)
                {
                    if (col.FieldName.Length > 4)
                    {
                        col.Width = 16 * col.FieldName.Length;
                    }

                    //不显示ID
                    if (col.FieldName.ToUpper().Contains("ID"))
                    {
                        col.Visible = false;
                    }

                    //不显示简拼
                    if (col.FieldName.ToUpper().Contains("SPELL"))
                    {
                        col.Visible = false;
                    }
                }
                view.BestFitColumns();
            }
        }

    }
}
