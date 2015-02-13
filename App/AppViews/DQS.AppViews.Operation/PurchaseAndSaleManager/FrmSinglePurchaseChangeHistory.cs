using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using DevExpress.XtraGrid.Views.Grid;
using DQS.Common;
using DQS.Controls;
using DQS.Module.Entities;
using ORMSCore;

namespace DQS.AppViews.Operation.PurchaseAndSaleManager
{
    public partial class FrmSinglePurchaseChangeHistory : DevExpress.XtraEditors.XtraForm
    {

        private int m_id;
        public FrmSinglePurchaseChangeHistory()
        {
            InitializeComponent();
        }

        private void BindHistories()
        {
            EntityCollection<BUSBillChangeHistoryEntity> changes = new EntityCollection<BUSBillChangeHistoryEntity>();
            changes.Fetch(BUSBillChangeHistoryEntityFields.BillID == m_id);
            if (changes.Count > 0)
            {
                List<BUSBillChangeHistoryEntity> list = changes.Cast<BUSBillChangeHistoryEntity>().OrderByDescending(p => p.VersionNumber).ToList();
                foreach (BUSBillChangeHistoryEntity change in list)
                {
                    this.lbcHistories.Items.Add(new ListEntityItem(change,
                        string.Format("版本 {0} - {1} 于 {2} 修改,修改原因：{3}", change.VersionNumber, change.ChangeUserName,
                            change.ChangeDate.ToString("yyyy-MM-dd HH:mm:ss"),change.Reservation4)));
                }
            }
        }
        private void FrmSinglePurchaseChangeHistory_Load(object sender, EventArgs e)
        {
            this.cbxDeliveryType.InitSource();
            this.cbxPaymentType.InitSource();
            this.popupGrid.InitGrid();
            (this.popupGrid.MainView as GridView).OptionsBehavior.Editable = false;

            this.popupGrid.RemoveRowCellClickEvent();
            if (this.Tag != null)
            {
                this.m_id = Convert.ToInt32(this.Tag);
                BindHistories();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 非文本框取值
        /// </summary>
        /// <param name="entity">实体</param>
        protected virtual void CustomGetEntity(BUSBillChangeHistoryEntity entity)
        {
            this.ftPanel.SetEntity(entity);
            if (!entity.IsNullField("DealerName"))
            {
                this.txtDealerName.Text = entity.DealerName;
            }
            else
            {
                txtDealerName.Text = "";
            }

            if (!entity.IsNullField("BusinessPerson"))
            {
                this.txtBusinessPerson.Text = entity.BusinessPerson;
            }
            else
            {
                txtBusinessPerson.Text = "";
            }

            if (!entity.IsNullField("Operator"))
            {
                this.txtOperator.Text = entity.Operator;
            }
            else
            {
                txtOperator.Text = "";
            }

            if (!entity.IsNullField("DeliveryTypeID"))
            {
                this.cbxDeliveryType.SelectedValue = entity.DeliveryTypeID;
            }
            else
            {
                cbxDeliveryType.Text = "";
            }

            if (!entity.IsNullField("PaymentTypeID"))
            {
                this.cbxPaymentType.SelectedValue = entity.PaymentTypeID;
            }
            else
            {
                cbxPaymentType.Text = "";
            }

            if (!entity.IsNullField("BillStyle"))
            {
                var index = rdgBillStyle.Properties.Items.GetItemIndexByValue(entity.BillStyle);
                rdgBillStyle.SelectedIndex = index;
            }
            else
            {
                rdgBillStyle.SelectedIndex = 0;
            }

            if (!entity.IsNullField("BillHistoryID"))
            {
                BindDetails(entity.BillHistoryID);
            }
        }

        private void BindDetails(Guid billHistoryId)
        {
            var gridView = (popupGrid.MainView as GridView);
            string querySql = @"
SELECT 
    s.BillID AS [采购单ID],
    s.ProductID AS [药品ID],
    p.ProductCode AS [药品编号],
    p.ProductName AS [药品名称],
    p.ProducerName AS [生产厂商],
    p.ProductSpec AS [规格],
    p.PackageSpec AS [包装规格],
    p.PackagingProportion AS [包装比例],
    p.AuthorizedNo AS [批准文号],
    p.StockCondition AS [贮藏条件],
    p.PhysicType AS [剂型],
    p.ProductStyle AS [药品类别],
    p.ProductUnit AS [单位],
    s.UnitPrice AS [单价],
    s.Amount AS [数量],
    s.TotalPrice AS [金额],
    s.DetailID AS [明细ID]
FROM dbo.BUS_BillDetailChangeHistory s
INNER JOIN BFI_Product p
    ON s.ProductID = p.ProductID
INNER JOIN dbo.BUS_BillChangeHistory b
    ON s.BillHistoryID = b.BillHistoryID
    AND s.BillID=b.BillID
WHERE IsBillIn = 1 
    AND BillTypeID = 1
    AND s.BillHistoryID='{0}'
";
            string sql = string.Format(querySql, billHistoryId);
            using (DataSet dataSet = new DataSet())
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(sql, GlobalItem.g_DbConnectStrings))
                {
                    adapter.Fill(dataSet);
                }
                DataTable data = dataSet.Tables[0];

                popupGrid.ClearGrid();

                for (int i = 0; i < data.Rows.Count; i++)
                {
                    foreach (DataColumn col in data.Columns)
                    {
                        gridView.SetRowCellValue(i, col.ColumnName, data.Rows[i][col]);
                    }
                }
            }
            gridView.BestFitColumns();
        }

        private void lbcHistories_SelectedIndexChanged(object sender, EventArgs e)
        {
            CustomGetEntity(new BUSBillChangeHistoryEntity());
            if (lbcHistories.SelectedItem != null)
            {
                BUSBillChangeHistoryEntity selectChange = (lbcHistories.SelectedItem as ListEntityItem).Key as BUSBillChangeHistoryEntity;
                CustomGetEntity(selectChange);

            }
        }

    }
}