using DevExpress.XtraGrid;
using DQS.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DQS.AppViews.QualityDocument.ProductManager
{
    public partial class FrmPriceOfDealer : StandardForm
    {
        public FrmPriceOfDealer()
        {
            InitializeComponent();
        }

        private void FrmPriceOfDealer_Load(object sender, EventArgs e)
        {
            this.pageNavigator.SortField = "创建日期";
            this.pageNavigator.SortType = "DESC";

            base.InitPage();

            #region 未审批结束高亮显示
            /*
            StyleFormatCondition sfcApprove = new StyleFormatCondition();
            sfcApprove.Appearance.BackColor = Color.Red;
            sfcApprove.Appearance.Options.UseBackColor = true;
            sfcApprove.ApplyToRow = true;
            sfcApprove.Column = this.gvData.Columns["审批状态"];
            sfcApprove.Condition = FormatConditionEnum.Equal;
            sfcApprove.Value1 = "未审批结束";
            this.gvData.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] { sfcApprove });
            */
            #endregion
        }
    }
}
