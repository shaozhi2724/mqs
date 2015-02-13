using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraGrid;
using System.ComponentModel;
using DevExpress.XtraEditors;
using System.Windows.Forms;
using System.Data;
using DevExpress.XtraGrid.Views.Grid;
using DQS.Common;

namespace DQS.Controls
{
    public class StandardGrid : GridControl
    {
        private StandardGridView standardGridView;

        /// <summary>
        /// 要显示的视图名称
        /// </summary>
        [Description("要显示的视图名称")]
        public string ViewName { get; set; }

        /// <summary>
        /// 查询条件
        /// </summary>
        [Description("查询条件")]
        public string Filter { get; set; }

        /// <summary>
        /// GridView
        /// </summary>
        [Browsable(false)]
        public StandardGridView GridViewData
        {
            get
            {
                return standardGridView;
            }
        }

        public StandardGrid()
        {
            this.InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.standardGridView = new StandardGridView();
            ((System.ComponentModel.ISupportInitialize)(this.standardGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // gridView1
            // 
            this.standardGridView.GridControl = this;
            this.standardGridView.Name = "standardGridView";
            // 
            // StandardGrid
            // 
            this.MainView = this.standardGridView;
            this.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.standardGridView});
            ((System.ComponentModel.ISupportInitialize)(this.standardGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
        }

        //刷新
        public void RefreshGrid()
        {
            try
            {
                if (!string.IsNullOrEmpty(this.ViewName))
                {
                    DataTable data = GlobalMethod.GetViewData(this.ViewName, this.Filter);

                    this.DataSource = data;
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "获取数据发生错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            (this.MainView as GridView).BestFitColumns();
        }

        //初始化
        public void InitGrid()
        {
            try
            {
                if (!string.IsNullOrEmpty(this.ViewName))
                {
                    DataTable data = GlobalMethod.GetViewData(this.ViewName, this.Filter);

                    this.PopulateGridColumns(data);

                    this.DataSource = data;
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "获取数据发生错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            (this.MainView as GridView).BestFitColumns();
        }

        public void PopulateGridColumns(DataTable data)
        {
            this.standardGridView.PopulateColumns(data);

            //大于8列不自动填充宽度，滚动条可见
            if (this.standardGridView.Columns.Count > 8)
            {
                this.standardGridView.OptionsView.ColumnAutoWidth = false;
            }
            else
            {
                this.standardGridView.OptionsView.ColumnAutoWidth = true;
            }

            //设置列宽度，使标题全部显示
            foreach (DevExpress.XtraGrid.Columns.GridColumn col in this.standardGridView.Columns)
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

        }
    }
}
