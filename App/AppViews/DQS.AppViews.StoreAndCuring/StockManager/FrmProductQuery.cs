using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DQS.Common;
using DQS.Controls;
using DQS.Module.Entities;
using ORMSCore;

namespace DQS.AppViews.StoreAndCuring.StockManager
{
    public partial class FrmProductQuery : StandardForm
    {
        public FrmProductQuery()
        {
            InitializeComponent();
        }

        private void FrmProductQuery_Load(object sender, EventArgs e)
        {
            //SetGrantedProductFilter();
            base.InitPage();

            #region 过期高亮显示
            StyleFormatCondition sfcValidDateWarning = new StyleFormatCondition();
            sfcValidDateWarning.Appearance.BackColor = Color.Red;
            sfcValidDateWarning.Appearance.Options.UseBackColor = true;
            sfcValidDateWarning.ApplyToRow = true;
            sfcValidDateWarning.Column = this.gvData.Columns["状态"];
            sfcValidDateWarning.Condition = FormatConditionEnum.Equal;
            sfcValidDateWarning.Value1 = "已过期";

            this.gvData.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] { sfcValidDateWarning });

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
    }
}