using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DQS.Module.Entities;

namespace DQS.AppViews.StoreAndCuring.StockManager
{
    public partial class FrmAddInventory : XtraForm
    {

        public int InventoryID;

        public FrmAddInventory()
        {
            InitializeComponent();
        }

        private void FrmAddInventory_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(!ValidateNewRecord()) return;
            NewLoad();
            this.DialogResult = DialogResult.Yes;
        }

        private void NewLoad()
        {
            BUSInventoryDetailEntity inventoryDetail = new BUSInventoryDetailEntity();

            var productId = int.Parse(txtProductCode.Tag.ToString());
            var productName = txtProductCode.Text.Trim();
            var batchNo = txtBatchNo.Text.Trim();
            var produceDate = deProduceDate.Text.Trim();
            var sterilizationBatchNo = txtSterilizationBatchNo.Text.Trim();
            var amount = Convert.ToInt32(txtAmount.Text.Trim());
            var unitPrice = Convert.ToDecimal(txtUnitPrice.Value);

            inventoryDetail.InventoryID = InventoryID;
            inventoryDetail.ProductID = productId;
            inventoryDetail.BatchNo = batchNo;
            inventoryDetail.ProduceDate = Convert.ToDateTime(produceDate);
            if (deValidateDate.Text.Trim() != "")
            {
                var validateDate = deValidateDate.Text.Trim();
                inventoryDetail.ValidateDate = Convert.ToDateTime(validateDate);
            }
            inventoryDetail.SterilizationBatchNo = sterilizationBatchNo;
            if (deSterilizationDate.Text.Trim() != "")
            {
                var sterilizationDate = deSterilizationDate.Text.Trim();
                inventoryDetail.SterilizationDate = Convert.ToDateTime(sterilizationDate);
            }
            inventoryDetail.Amount = 0;
            inventoryDetail.InventoryAmount = amount;
            inventoryDetail.DifferenceAmount = amount;
            inventoryDetail.InventoryResult = "盘盈";
            inventoryDetail.IsLocationRight = true;
            inventoryDetail.Reservation1 = unitPrice.ToString();
            inventoryDetail.Save();

            #region 作废
            /*
            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                conn.Open(); //连接数据库
                //必须为SqlCommand指定数据库连接和登记的事务
                try
                {
                    string sql = "EXEC sp_InsertNewStoreDetailForInventory";
                    sql = String.Format(sql);
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                }
            }
            */
            #endregion
        }

        private bool ValidateNewRecord()
        {
            if (string.IsNullOrWhiteSpace(txtProductCode.Text))
            {
                XtraMessageBox.Show("请选择产品名称！", "系统数据校验提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtBatchNo.Text))
            {
                XtraMessageBox.Show("批号不能为空！", "系统数据校验提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(deProduceDate.Text))
            {
                XtraMessageBox.Show("生产日期不能为空！", "系统数据校验提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtAmount.Text))
            {
                XtraMessageBox.Show("数量不能为空！", "系统数据校验提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtUnitPrice.Text))
            {
                XtraMessageBox.Show("进货价不能为空！", "系统数据校验提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void txtProductCode_PopupClosing(object sender, EventArgs e)
        {
            if (this.txtProductCode.EditData != null)
            {
                this.txtProductCode.Tag = (this.txtProductCode.EditData as DataRow)["产品ID"].ToString();
                this.txtProductSpec.Text = (this.txtProductCode.EditData as DataRow)["规格型号"].ToString();
                this.txtPackageSpec.Text = (this.txtProductCode.EditData as DataRow)["包装规格型号"].ToString();
                this.txtAuthorizedNo.Text = (this.txtProductCode.EditData as DataRow)["注册证号"].ToString();
                this.txtProducerName.Text = (this.txtProductCode.EditData as DataRow)["生产厂商"].ToString();
                this.txtProductStyle.Text = (this.txtProductCode.EditData as DataRow)["产品类别"].ToString();
            }
        }
    }
}
