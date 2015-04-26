using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DQS.Controls;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;

namespace DQS.AppViews.StoreAndCuring.StockManager
{
    public partial class FrmUnStockDetail : StandardForm
    {
        public FrmUnStockDetail()
        {
            InitializeComponent();
        }

        private void FrmStockDetail_Load(object sender, EventArgs e)
        {
            base.InitPage();

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
}
