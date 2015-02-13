using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DQS.Module;

namespace DQS.Controls
{
    public class PageSimpleNavigator : PanelControl
    {
        private LabelControl m_LblPageSet;
        private SimpleButton m_BtnFirst;
        private SimpleButton m_BtnPrevious;
        private SimpleButton m_BtnNext;
        private SimpleButton m_BtnLast;

        private string m_Fields = "*";

        private string m_SortField = "";

        private string m_SortType = "";

        private string m_ViewName = "";

        private string m_Filter = "";

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

            m_LblPageSet = new LabelControl();
            m_LblPageSet.Appearance.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));

            m_BtnFirst = new SimpleButton();
            m_BtnFirst.Appearance.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));

            m_BtnPrevious = new SimpleButton();
            m_BtnPrevious.Appearance.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));

            m_BtnNext = new SimpleButton();
            m_BtnNext.Appearance.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));

            m_BtnLast = new SimpleButton();
            m_BtnLast.Appearance.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));

            this.Controls.Add(m_LblPageSet);
            this.Controls.Add(m_BtnFirst);
            this.Controls.Add(m_BtnPrevious);
            this.Controls.Add(m_BtnNext);
            this.Controls.Add(m_BtnLast);

            m_BtnFirst.Text = "首页(&F)";
            m_BtnFirst.Location = new Point(3, 9);
            m_BtnFirst.Size = new Size(75, 23);
            m_BtnFirst.TabIndex = 5;
            m_BtnFirst.Click += new EventHandler(BtnFirst_Click);

            m_BtnPrevious.Text = "上一页(&P)";
            m_BtnPrevious.Location = new Point(80, 9);
            m_BtnPrevious.Size = new Size(75, 23);
            m_BtnPrevious.TabIndex = 6;
            m_BtnPrevious.Click += new EventHandler(BtnPrevious_Click);

            m_BtnNext.Text = "下一页(&N)";
            m_BtnNext.Location = new Point(157, 9);
            m_BtnNext.Size = new Size(75, 23);
            m_BtnNext.TabIndex = 7;
            m_BtnNext.Click += new EventHandler(BtnNext_Click);

            m_BtnLast.Text = "末页(&L)";
            m_BtnLast.Location = new Point(234, 9);
            m_BtnLast.Size = new Size(75, 23);
            m_BtnLast.TabIndex = 8;
            m_BtnLast.Click += new EventHandler(BtnLast_Click);

            m_LblPageSet.Location = new Point(312, 11);
            m_LblPageSet.Name = "m_LblPageSet";
            m_LblPageSet.Text = string.Format("共[{0}/{1}][{2}]条记录.", 0, 0, 0);
            m_LblPageSet.TabIndex = 1;

            this.Size = new Size(320, 40);
            this.MinimumSize = new Size(320, 40);
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

        public PageSimpleNavigator()
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
                DataSet data = Procedures.Pagination(this.Fields, this.ViewName, this.PrimaryField, this.SortField, this.SortType, this.PageSize, this.PageIndex, this.Filter, ref pPageCount, ref pRecordCount);
                this.PageCount = pPageCount;
                this.RecordCount = pRecordCount;

                this.m_LblPageSet.Text = string.Format("共[{0}/{1}][{2}]条记录.", this.PageIndex + 1, pPageCount, pRecordCount);

                if (this.GridControl != null)
                {

                    this.EmptySource = data.Tables[0].Clone();

                    this.PopulateGridColumns();

                    this.GridControl.DataSource = data.Tables[0];
                    GridView view = this.GridControl.Views[0] as GridView;
                    if (view != null)
                    {
                        view.BestFitColumns();
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
                    if (col.FieldName.Contains("ID"))
                    {
                        col.Visible = false;
                    }

                    //不显示简拼
                    if (col.FieldName.Contains("Spell"))
                    {
                        col.Visible = false;
                    }
                }
                view.BestFitColumns();
            }
        }

    }
}

