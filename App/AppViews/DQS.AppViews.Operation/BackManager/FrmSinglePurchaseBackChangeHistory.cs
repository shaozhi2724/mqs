using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DQS.Controls;
using DQS.Module.Entities;
using ORMSCore;
using DQS.Common;

namespace DQS.AppViews.Operation.BackManager
{
    public partial class FrmSinglePurchaseBackChangeHistory : DevExpress.XtraEditors.XtraForm
    {
        private int m_id;

        public FrmSinglePurchaseBackChangeHistory()
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
                        string.Format("版本 {0} - {1} 于 {2} 修改，修改原因：{3}", change.VersionNumber, change.ChangeUserName,
                            change.ChangeDate.ToString("yyyy-MM-dd HH:mm:ss"),change.Reservation4)));
                }
            }
        }
        private void FrmSinglePurchaseBackChangeHistory_Load(object sender, EventArgs e)
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


            if (!entity.IsNullField("DealerAddress"))
            {
                this.txtDealerAddress.Text = entity.DealerAddress;
            }
            else
            {
                txtDealerAddress.Text = "";
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
    s.BillID AS [采购退货单ID],
    s.ProductID AS [产品ID],
    p.ProductCode AS [产品编号],
    p.ProductName AS [产品名称],
    p.ProducerName AS [生产厂商],
    p.ProductSpec AS [规格],
    p.PackageSpec AS [包装规格],
    p.PackagingProportion AS [包装比例],
    p.AuthorizedNo AS [注册证号],
    p.StockCondition AS [贮藏条件],
    p.PhysicType AS [剂型],
    p.ProductStyle AS [产品类别],
    p.ProductUnit AS [单位],
    s.BatchNo AS [批号],
    s.ProduceDate AS [生产日期],
    s.ValidateDate AS [有效期至],
    d.Amount AS [库存数量],
    s.UnitPrice AS [单价],
    s.Amount AS [数量],
    s.TotalPrice AS [金额],
    s.DetailID AS [明细ID],
    CONVERT(NVARCHAR(100), b.CreateDate, 23) AS [创建日期]
FROM dbo.BUS_BillDetailChangeHistory s
INNER JOIN BFI_Product p
    ON s.ProductID = p.ProductID
INNER JOIN dbo.BUS_BillChangeHistory b
    ON s.BillHistoryID=b.BillHistoryID
    AND s.BillID = b.BillID
INNER JOIN BUS_StoreDetail d
    ON s.ProductID = d.ProductID 
    AND s.BatchNo = d.BatchNo AND s.Amount>0
WHERE IsBillIn = 0
    AND BillTypeID = 2
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