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
using DQS.Common;
using DevExpress.XtraGrid.Views.Grid;
using System.Data.SqlClient;
using System.IO;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;

namespace DQS.AppViews.StoreAndCuring.StockManager
{
    public partial class FrmSingleBeginInventory : XtraForm
    {

        List<BeginInventoryEntityModel> Inventorylist = new List<BeginInventoryEntityModel>();
        public FrmSingleBeginInventory()
        {
            InitializeComponent();
        }

        private void FrmSingleBeginInventory_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateNewRecord())
            {
                return;
            }
            var productId = int.Parse(txtProductCode.Tag.ToString());
            var productName = txtProductCode.Text.Trim();
            var batchNo = txtBatchNo.Text.Trim();
            var produceDate = deProduceDate.Text.Trim();
            var validateDate = deValidateDate.Text.Trim();
            var sterilizationBatchNo = txtSterilizationBatchNo.Text.Trim();
            var sterilizationDate = deSterilizationDate.Text.Trim();
            var amount = Convert.ToInt32(txtAmount.Text.Trim());
            var unitPrice = Convert.ToDecimal(txtUnitPrice.Value);
            if (!Inventorylist.Exists(p => p.ProductID == productId
                                     && p.BatchNo == batchNo
                                     && p.SterilizationBatchNo == sterilizationBatchNo
                                     && p.UnitPrice == unitPrice))
            {
                Inventorylist.Add(new BeginInventoryEntityModel
                {
                    ProductID = productId,
                    ProductName = productName,
                    BatchNo = batchNo,
                    ProduceDate = produceDate,
                    ValidateDate = validateDate,
                    SterilizationBatchNo = sterilizationBatchNo,
                    SterilizationDate = sterilizationDate,
                    Amount = amount,
                    UnitPrice = unitPrice
                });
            }
            else
            {
                XtraMessageBox.Show("要添加的产品记录已经存在！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            grdInventoryList.DataSource = Inventorylist;
            gvInventoryList.BestFitColumns();
            grdInventoryList.Refresh();
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (null == gvInventoryList.GetFocusedRow())
            {
                XtraMessageBox.Show("请选择删除的数据！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dr = XtraMessageBox.Show("确定要删除此行数据吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                int productId = Convert.ToInt32(gvInventoryList.GetFocusedRowCellValue("ProductID"));
                string batchNo = gvInventoryList.GetFocusedRowCellValue("BatchNo").ToString();
                string sterilizationBatchNo = gvInventoryList.GetFocusedRowCellValue("SterilizationBatchNo").ToString();
                decimal unitPrice = Convert.ToDecimal(gvInventoryList.GetFocusedRowCellValue("UnitPrice"));
                var dealerPrice = Inventorylist.FirstOrDefault(p => p.ProductID == productId
                                     && p.BatchNo == batchNo
                                     && p.SterilizationBatchNo == sterilizationBatchNo
                                     && p.UnitPrice == unitPrice);
                if (null != dealerPrice)
                {
                    Inventorylist.Remove(dealerPrice);
                }
                grdInventoryList.DataSource = Inventorylist;
                gvInventoryList.BestFitColumns();
                grdInventoryList.Refresh();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult dr = XtraMessageBox.Show("是否确认？确认后不可更改。", "系统提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                for (int i = 0; i < Inventorylist.Count; i++)
                {
                    BUSBeginInventoryEntity beginInventory = new BUSBeginInventoryEntity();
                    int productID = Inventorylist[i].ProductID;
                    string productName = Inventorylist[i].ProductName;
                    string batchNo = Inventorylist[i].BatchNo;
                    DateTime produceDate = Convert.ToDateTime(Inventorylist[i].ProduceDate);
                    if (Inventorylist[i].ValidateDate.Trim() != "")
                    {
                        beginInventory.ValidateDate = Convert.ToDateTime(Inventorylist[i].ValidateDate);
                    }
                    string sterilizationBatchNo = Inventorylist[i].SterilizationBatchNo;
                    if (Inventorylist[i].SterilizationDate.Trim() != "")
                    {
                        beginInventory.SterilizationDate = Convert.ToDateTime(Inventorylist[i].SterilizationDate);
                    }
                    int amount = Inventorylist[i].Amount;
                    decimal unitPrice = Inventorylist[i].UnitPrice;
                    beginInventory.ProductID = productID;
                    beginInventory.ProductName = productName;
                    beginInventory.BatchNo = batchNo;
                    beginInventory.ProduceDate = produceDate;
                    beginInventory.SterilizationBatchNo = sterilizationBatchNo;
                    beginInventory.Amount = amount;
                    beginInventory.UnitPrice = unitPrice;
                    beginInventory.DepartmentID = Inventorylist[i].DepartmentID;
                    beginInventory.DepartmentName = Inventorylist[i].DepartmentName;
                    beginInventory.Save();
                }
                InsertNew();
                this.DialogResult = DialogResult.OK;
            }
        }

        private void InsertNew()
        {
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
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

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
                this.txtBatchNo.Text = "";
                this.deProduceDate.Text = "";
                this.deValidateDate.Text = "";
                this.txtSterilizationBatchNo.Text = "";
                this.deSterilizationDate.Text = "";
                this.txtAmount.Text = "";
                this.txtUnitPrice.Text = "";
            }
        }

        private void gvInventoryList_CustomDrawEmptyForeground(object sender, DevExpress.XtraGrid.Views.Base.CustomDrawEventArgs e)
        {
            GridView view = sender as GridView;

            if (view.RowCount != 0)
                return;//有记录，返回

            using (StringFormat drawFormat = new StringFormat())
            {
                drawFormat.Alignment = drawFormat.LineAlignment = StringAlignment.Center;
                e.Graphics.DrawString("暂无记录.", e.Appearance.Font, SystemBrushes.ControlDark, new RectangleF(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height), drawFormat);
            }
        }

        private void gvInventoryList_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator)
            {
                if (e.RowHandle >= 0)
                {
                    e.Info.DisplayText = (e.RowHandle + 1).ToString();
                }
            }
        }

        private void gvInventoryList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                DialogResult dr = XtraMessageBox.Show("确定要删除此行数据吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {
                    int productId = Convert.ToInt32(gvInventoryList.GetFocusedRowCellValue("ProductID"));
                    string batchNo = gvInventoryList.GetFocusedRowCellValue("BatchNo").ToString();
                    string sterilizationBatchNo = gvInventoryList.GetFocusedRowCellValue("SterilizationBatchNo").ToString();
                    decimal unitPrice = Convert.ToDecimal(gvInventoryList.GetFocusedRowCellValue("UnitPrice"));
                    var dealerPrice = Inventorylist.FirstOrDefault(p => p.ProductID == productId
                                         && p.BatchNo == batchNo
                                         && p.SterilizationBatchNo == sterilizationBatchNo
                                         && p.UnitPrice == unitPrice);
                    if (null != dealerPrice)
                    {
                        Inventorylist.Remove(dealerPrice);
                    }
                    grdInventoryList.DataSource = Inventorylist;
                    gvInventoryList.BestFitColumns();
                    grdInventoryList.Refresh();
                }
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.FileName = "期初产品表导出";

            saveFileDialog.Title = "导出Excel";

            saveFileDialog.Filter = "Excel文件(*.xls)|*.xls";

            DialogResult dialogResult = saveFileDialog.ShowDialog(this);

            if (dialogResult == DialogResult.OK)
            {

                DevExpress.XtraPrinting.XlsExportOptions options = new DevExpress.XtraPrinting.XlsExportOptions();

                //gridControl1.ExportToXls(saveFileDialog.FileName, options);  

                //gridControl.ExportToExcelOld(saveFileDialog.FileName);
                grdInventoryList.ExportToXls(saveFileDialog.FileName);

                DevExpress.XtraEditors.XtraMessageBox.Show("保存成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }  
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog(this);
        }

        private void openFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            var file = openFileDialog.FileName;
            //txtFile.Text = file;

            LoadExcelData(file);
            grdInventoryList.DataSource = Inventorylist;
            gvInventoryList.BestFitColumns();
            grdInventoryList.RefreshDataSource();
        }

        private void LoadExcelData(string filename)
        {
            DataTable table = new DataTable();

            try
            {
                using (FileStream file = new FileStream(filename, FileMode.Open, FileAccess.Read))
                {
                    HSSFWorkbook hssfworkbook = new HSSFWorkbook(file);
                    ISheet sheet1 = hssfworkbook.GetSheet("Sheet1");
                    int rowCount = (sheet1 as HSSFSheet).LastRowNum;

                    //获取sheet的首行
                    HSSFRow headerRow = (sheet1.GetRow(0) as HSSFRow);

                    //一行最后一个方格的编号 即总的列数
                    int cellCount = headerRow.LastCellNum;

                    //for (int i = headerRow.FirstCellNum; i < cellCount; i++)
                    //{
                    //    DataColumn column = new DataColumn(headerRow.GetCell(i).StringCellValue);
                    //    table.Columns.Add(column);
                    //}

                    for (int i = (sheet1.FirstRowNum + 1); i <= rowCount; i++)
                    {
                        HSSFRow row = (sheet1.GetRow(i) as HSSFRow);
                        BeginInventoryEntityModel dataRow = new BeginInventoryEntityModel();
                        string ProductID = row.GetCell(0).ToString();
                        string BatchNo = row.GetCell(1).ToString();
                        string ProductName = row.GetCell(2).ToString();
                        string ProduceDate = row.GetCell(3).ToString();
                        string ValidateDate = row.GetCell(4).ToString();
                        string SterilizationBatchNo = row.GetCell(5).ToString();
                        string SterilizationDate = row.GetCell(6).ToString();
                        string Amount = row.GetCell(7).ToString();
                        string UnitPrice = row.GetCell(8).ToString();
                        string DepartmentID = row.GetCell(9).ToString();
                        string DepartmentName = row.GetCell(10).ToString();
                        dataRow.ProductID = Convert.ToInt32(ProductID);
                        dataRow.BatchNo = BatchNo;
                        dataRow.ProductName = ProductName;
                        dataRow.ProduceDate = ProduceDate;
                        dataRow.ValidateDate = ValidateDate;
                        dataRow.SterilizationBatchNo = SterilizationBatchNo;
                        dataRow.SterilizationDate = SterilizationDate;
                        dataRow.Amount = Convert.ToInt32(Amount);
                        dataRow.UnitPrice = Convert.ToDecimal(UnitPrice);
                        dataRow.DepartmentID = Convert.ToInt32(DepartmentID);
                        dataRow.DepartmentName = DepartmentName;
                        Inventorylist.Add((BeginInventoryEntityModel) dataRow);
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }
    }
    public class BeginInventoryEntityModel
    {
        public int ProductID { get; set; }
        public string BatchNo { get; set; }
        public string ProductName { get; set; }
        public string ProduceDate { get; set; }
        public string ValidateDate { get; set; }
        public string SterilizationBatchNo { get; set; }
        public string SterilizationDate { get; set; }
        public int Amount { get; set; }
        public decimal UnitPrice { get; set; }
        public int DepartmentID { get; set; }
        public string DepartmentName { get; set; }
    }
}
