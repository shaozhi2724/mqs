using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DQS.Common;
using DQS.Controls;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DQS.Module.Entities;
using ORMSCore;

namespace DQS.AppViews.StoreAndCuring.StockManager
{
    public partial class FrmStockDetail : StandardForm
    {
        public FrmStockDetail()
        {
            InitializeComponent();
        }

        private void FrmStockDetail_Load(object sender, EventArgs e)
        {
            //SetGrantedProductFilter();
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

        private void SetGrantedProductFilter()
        {
            ATCUserEntity user = GlobalItem.g_CurrentUser;

            if (null != user)
            {
                Guid userID = user.UserID;
                EntityCollection<ATCUserProductEntity> userProducts = new EntityCollection<ATCUserProductEntity>();
                userProducts.Fetch(ATCUserProductEntityFields.UserID == userID);
                List<int> productIDs = new List<int>();
                foreach (var userProduct in userProducts)
                {
                    productIDs.Add(((ATCUserProductEntity)userProduct).ProductID);
                }
                if (productIDs.Any())
                {
                    string productFilter = string.Join(",", productIDs);
                    pageNavigator.DefaultFilter = string.Format("[产品ID] IN ({0})", productFilter);
                }
                else
                {
                    pageNavigator.DefaultFilter = "[产品ID]=0";
                }
            }
        }

        protected override void CustomModify()
        {
            using (FrmSingleStoreDetail fa = new FrmSingleStoreDetail())
            {
                DialogResult dr = fa.ShowDialog();
                if (dr == DialogResult.Yes)
                {
                    this.pageNavigator.ShowData();
                }
            }
        }
    }
}