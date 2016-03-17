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
using DevExpress.XtraGrid;
using DevExpress.XtraPrinting;
using DQS.Module.Entities;
using DQS.Common;
using DQS.Module.Views;
using LinqToExcel;
using LinqToExcel.Extensions;
using ORMSCore;

namespace DQS.AppViews.StoreAndCuring.StockManager
{
    public partial class FrmSingleInventory : DevExpress.XtraEditors.XtraForm
    {
        private int? m_id;

        public FrmSingleInventory()
        {
            InitializeComponent();
        }

        private void FrmSingleInventory_Load(object sender, EventArgs e)
        {
            this.popupGrid.InitGrid();
            this.popupGrid.PopupView.KeyDown += PopupView_KeyDown;
            this.popupGrid.PopupView.CellValueChanged += PopupView_CellValueChanged;


            if (this.Tag != null)
            {
                this.m_id = Convert.ToInt32(this.Tag);
                btnImport.Enabled = true;
                BUSInventoryEntity entity = new BUSInventoryEntity { InventoryID = m_id.Value };
                entity.Fetch();

                this.ftPanel.SetEntity(entity);

                this.popupGrid.SetGridData(m_id.Value, true);
                btnOneKeyFinish.Enabled = false;

            }
            else
            {
                btnAddNew.Enabled = false;
                btnImport.Enabled = false;
                this.txtInventoryCode.Text = "PD" + DateTime.Now.ToString("yyyyMMddHHmmss");
                this.txtInventoryCode.Select(this.txtInventoryCode.Text.Length, 0);

                if (GlobalItem.g_CurrentEmployee != null)
                {
                    this.txtInventoryPerson.Text = GlobalItem.g_CurrentEmployee.EmployeeName;
                }
                else
                {
                    this.txtInventoryPerson.Text = GlobalItem.g_CurrentUser.UserName;
                }
            }
        }

        private void PopupView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.Caption == "盘点数量")
            {
                object amount = this.popupGrid.PopupView.GetRowCellValue(e.RowHandle, "库存数量");
                if (amount != null && amount != DBNull.Value && e.Value != null && e.Value != DBNull.Value)
                {
                    if (Convert.ToInt32(e.Value) > Convert.ToInt32(amount))
                    {
                        this.popupGrid.PopupView.SetRowCellValue(e.RowHandle, "差异数量", Convert.ToInt32(e.Value) - Convert.ToInt32(amount));
                        this.popupGrid.PopupView.SetRowCellValue(e.RowHandle, "盘点结果", "盘盈");
                    }

                    if (Convert.ToInt32(e.Value) == Convert.ToInt32(amount))
                    {
                        this.popupGrid.PopupView.SetRowCellValue(e.RowHandle, "差异数量", 0);
                        this.popupGrid.PopupView.SetRowCellValue(e.RowHandle, "盘点结果", "无损");
                    }

                    if (Convert.ToInt32(e.Value) < Convert.ToInt32(amount))
                    {
                        this.popupGrid.PopupView.SetRowCellValue(e.RowHandle, "差异数量", Convert.ToInt32(e.Value) - Convert.ToInt32(amount));
                        this.popupGrid.PopupView.SetRowCellValue(e.RowHandle, "盘点结果", "盘亏");
                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (SaveInventoryRecords())
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                
                this.DialogResult = DialogResult.None;
            }

        }

        private bool SaveInventoryRecords()
        {
            try
            {
                if (!this.ftPanel.ValidateIsNullFields()) return false;

                BUSInventoryEntity entity = this.ftPanel.GetEntity() as BUSInventoryEntity;

                this.CustomSetEntity(entity);

                if (this.m_id != null)
                {
                    #region 修改

                    entity.LastModifyDate = DateTime.Now;
                    entity.LastModifyUserID = GlobalItem.g_CurrentUser.UserID;
                    entity.Update();

                    #endregion
                }
                else
                {
                    if (entity.IsNew(BUSInventoryEntityFields.InventoryCode == entity.InventoryCode))
                    {
                        #region 新建

                        entity.InventoryDate = DateTime.Now;

                        List<EntityBase> children = this.popupGrid.GetEntities();

                        entity.CreateDate = DateTime.Now;
                        entity.LastModifyDate = DateTime.Now;
                        entity.CreateUserID = GlobalItem.g_CurrentUser.UserID;
                        entity.LastModifyUserID = GlobalItem.g_CurrentUser.UserID;

                        entity.StatusID = 1;
                        entity.StatusName = "已盘点";
                        entity.StatusSpell = "ypd";
                        entity.Save();


                        //查询出其ID
                        entity.Fetch();
                        m_id = entity.InventoryID;

                        foreach (EntityBase childEntity in children)
                        {
                            BUSInventoryDetailEntity child = childEntity as BUSInventoryDetailEntity;
                            child.InventoryID = entity.InventoryID;
                            child.Save();
                            UpdateLastCuringDate(child.InStoreID);
                        }

                        #endregion
                    }
                    else
                    {
                        XtraMessageBox.Show("盘点单号已存在。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return false;
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
        }
        private bool SaveInventoryRecordsForImportResult()
        {
            try
            {
                BUSInventoryEntity entity = this.ftPanel.GetEntity() as BUSInventoryEntity;

                this.CustomSetEntity(entity);

                if (this.m_id != null)
                {
                    #region 修改

                    entity.LastModifyDate = DateTime.Now;
                    entity.LastModifyUserID = GlobalItem.g_CurrentUser.UserID;
                    entity.Update();

                    #endregion
                }
                else
                {
                    if (entity.IsNew(BUSInventoryEntityFields.InventoryCode == entity.InventoryCode))
                    {
                        #region 新建

                        entity.InventoryDate = DateTime.Now;

                        List<EntityBase> children = this.popupGrid.GetEntities(false);

                        entity.CreateDate = DateTime.Now;
                        entity.LastModifyDate = DateTime.Now;
                        entity.CreateUserID = GlobalItem.g_CurrentUser.UserID;
                        entity.LastModifyUserID = GlobalItem.g_CurrentUser.UserID;

                        entity.StatusID = 0;
                        entity.StatusName = "等待导入盘点数据";
                        entity.StatusSpell = "dddrpdsj";
                        entity.Save();


                        //查询出其ID
                        entity.Fetch();
                        m_id = entity.InventoryID;

                        foreach (EntityBase childEntity in children)
                        {
                            BUSInventoryDetailEntity child = childEntity as BUSInventoryDetailEntity;
                            child.InventoryID = entity.InventoryID;
                            child.Save();
                            //UpdateLastCuringDate(child);
                        }

                        #endregion
                    }
                    else
                    {
                        XtraMessageBox.Show("盘点单号已存在。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return false;
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        /// <summary>
        /// 非文本框赋值
        /// </summary>
        /// <param name="entity">实体</param>
        protected virtual void CustomSetEntity(BUSInventoryEntity entity)
        {
            entity.InventoryTypeID = 1;
            entity.InventoryTypeName = "明盘";
            entity.InventoryTypeSpell = "mp";
        }

        private void PopupView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                DialogResult dr = XtraMessageBox.Show("确定要删除此行数据吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {
                    this.popupGrid.ClearGrid(this.popupGrid.PopupView.FocusedRowHandle);
                }
            }
        }

        private void btnOneKeyFinish_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.popupGrid.PopupView.RowCount; i++)
            {
                object amount = this.popupGrid.PopupView.GetRowCellValue(i, "库存数量");
                if (amount != null)
                {
                    if (!string.IsNullOrEmpty(amount.ToString()))
                    {
                        object newAmount = popupGrid.PopupView.GetRowCellValue(i, "盘点数量");
                        if (null == newAmount || string.IsNullOrWhiteSpace(newAmount.ToString()))
                        {
                            this.popupGrid.PopupView.SetRowCellValue(i, "盘点数量", amount);
                            this.popupGrid.PopupView.SetRowCellValue(i, "差异数量", 0);
                            this.popupGrid.PopupView.SetRowCellValue(i, "盘点结果", "无损");
                        }
                    }
                }
            }
        }
        private void btnUpdateStoreAmount_Click(object sender, EventArgs e)
        {
            if (SaveInventoryRecords())
            {
                BUSInventoryEntity entity = new BUSInventoryEntity {InventoryID = m_id.Value};

                entity.StatusID = 2;
                entity.StatusName = "已处理";
                entity.StatusSpell = "ycl";
                entity.Update();
                List<EntityBase> children = this.popupGrid.GetEntities();

                BUSInventoryDetailEntity childToDelete = new BUSInventoryDetailEntity { InventoryID = m_id.Value };
                childToDelete.DeleteByCommonly();
                foreach (EntityBase childEntity in children)
                {
                    BUSInventoryDetailEntity child = childEntity as BUSInventoryDetailEntity;
                    child.InventoryID = entity.InventoryID;
                    child.Save();
                    UpdateLastCuringDate(child.InStoreID);
                }
                UpdateStoreAmount(entity.InventoryID);

                this.DialogResult = DialogResult.OK;
            }
            else
            {
                this.DialogResult = DialogResult.None;
            }
        }

        private void popupGrid_PopupClosed(object sender, DQS.Controls.CommonCode.PopupFormClosedArgs e)
        {
            string fieldName = "产品ID";
            string fieldName2 = "批号";
            for (int i = 0; i < e.PopupRows.Length; i++)
            {
                object fieldValue = this.popupGrid.PopupView.GetRowCellValue(i, "产品ID");
                object productName = this.popupGrid.PopupView.GetRowCellValue(i, "产品名称");
                object fieldValue2 = this.popupGrid.PopupView.GetRowCellValue(i, fieldName2);
                if (fieldValue != null && fieldValue != DBNull.Value)
                {
                    if (e.PopupRows.Any(p => p[fieldName] != null && p[fieldName] != DBNull.Value
                                                  && fieldValue.ToString().Trim() == p[fieldName].ToString().Trim()
                                                  && p[fieldName2] != null && p[fieldName2] != DBNull.Value
                                                  && fieldValue2.ToString().Trim() == p[fieldName2].ToString().Trim()))
                    {
                        XtraMessageBox.Show(string.Format("产品{0}(批号:{1})已存在。", productName, fieldValue2), "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        this.popupGrid.PopupView.FocusedRowHandle = i;
                        e.Cancel = true;
                    }
                }
            }
        }

        public static void UpdateLastCuringDate(int inStoreID)
        {
            if (inStoreID > 0)
            {
                EntityCollection<BUSInStoreDetailEntity> inStoreDetail = new EntityCollection<BUSInStoreDetailEntity>();
                inStoreDetail.Fetch(BUSInStoreDetailEntityFields.InStoreID == inStoreID);
                foreach (BUSInStoreDetailEntity instore in inStoreDetail)
                {
                    instore.CuringDate = DateTime.Now;
                    instore.Update();
                }
            }
        }
        public void UpdateStoreAmount(int InventoryID)
        {
            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                conn.Open(); //连接数据库
                //必须为SqlCommand指定数据库连接和登记的事务
                try
                {
                    string sql = "EXEC sp_InsertNewStoreDetailForInventoryDetail " + InventoryID;
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

            #region 作废
            /*
            EntityCollection<BUSStoreDetailEntity> entities = new EntityCollection<BUSStoreDetailEntity>();
            entities.Fetch(BUSStoreDetailEntityFields.ProductID == inventoryDetail.ProductID & BUSStoreDetailEntityFields.BatchNo == inventoryDetail.BatchNo);

            foreach (BUSStoreDetailEntity entity in entities)
            {
                DateTime lastCuringDate = DateTime.Now;

                string sqlString = @"
INSERT INTO dbo.BUS_StoreDetailChangeHistory
(
    StoreDetailID,
    ProductID,
    BatchNo,
    ProduceDate,
    ValidateDate,
    Amount,
    CreateStoreID,
    CreateStoreCode,
    LastStoreID,
    LastStoreCode,
    LastCuringDate,
    CreateUserID,
    CreateDate,
    LastModifyUserID,
    LastModifyDate,
    DetailRemark,
    DepartmentID,
    NewProductID,
    NewBatchNo,
    NewProduceDate,
    NewValidateDate,
    NewAmount,
    NewLastCuringDate,
    NewDetailRemark,
    NewDepartmentID,
    VersionNumber,
    ActionName,
    ChangeUserName,
    ChangeDate
)
SELECT
    StoreDetailID,
    ProductID,
    BatchNo,
    ProduceDate,
    ValidateDate,
    Amount,
    CreateStoreID,
    CreateStoreCode,
    LastStoreID,
    LastStoreCode,
    LastCuringDate,
    CreateUserID,
    CreateDate,
    LastModifyUserID,
    LastModifyDate,
    DetailRemark,
    DepartmentID,
    '{2}',
    '{3}',
    '{4}',
    '{5}',
    '{6}',
    '{7}',
    DetailRemark,
    DepartmentID,
    (SELECT ISNULL((SELECT TOP 1 ISNULL(VersionNumber, 0) FROM dbo.BUS_StoreDetailChangeHistory WHERE StoreDetailID={0} ORDER BY ChangeDate DESC),0)+1),
    '盘点修改 - DQS盘点管理',
    '{1}',
    GETDATE()
FROM dbo.BUS_StoreDetail
WHERE StoreDetailID={0}
";
                string changeUserName = null == GlobalItem.g_CurrentEmployee
                    ? GlobalItem.g_CurrentUser.UserName
                    : GlobalItem.g_CurrentEmployee.EmployeeName;
                string sql = string.Format(sqlString, entity.StoreDetailID, changeUserName,
                    entity.ProductID, entity.BatchNo, entity.ProduceDate, entity.ValidateDate,
                    inventoryDetail.InventoryAmount, lastCuringDate.ToString("yyyy-MM-dd HH:mm:ss"));
                SqlCommand command = new SqlConnection(GlobalItem.g_DbConnectStrings).CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = sql;
                using (command.Connection)
                {
                    try
                    {
                        command.Connection.Open();
                        command.ExecuteNonQuery();
                        command.Dispose();
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                    finally
                    {
                        if (command.Connection.State != ConnectionState.Closed)
                        {
                            command.Connection.Close();
                        }
                    }
                }
                entity.LastCuringDate = lastCuringDate;
                entity.Amount = inventoryDetail.InventoryAmount;

                entity.Update();
            }

            //无业务库存，可能来自盘点导入的期初，需要新建业务库存
            if (entities.Count == 0)
            {
                BUSStoreDetailEntity storeDetail = new BUSStoreDetailEntity();

                //新建库存
                storeDetail.ProductID = inventoryDetail.ProductID;
                storeDetail.BatchNo = inventoryDetail.BatchNo;
                storeDetail.DepartmentID = 0;
                storeDetail.ProduceDate = inventoryDetail.ProduceDate;
                storeDetail.ValidateDate = inventoryDetail.ValidateDate;
                storeDetail.Amount = inventoryDetail.Amount;
                storeDetail.CreateDate = DateTime.Now;
                storeDetail.LastModifyDate = DateTime.Now;
                storeDetail.LastModifyUserID = GlobalItem.g_CurrentUser.UserID;
                storeDetail.LastCuringDate = DateTime.Now;
                var userName = GlobalItem.g_CurrentEmployee == null
                    ? GlobalItem.g_CurrentUser.UserName
                    : GlobalItem.g_CurrentEmployee.EmployeeName;
                storeDetail.DetailRemark = string.Format("{0}于{1}通过盘点单：{2}进行期初,期初数据 - 批号:{3},数量:{4}", userName, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), txtInventoryCode.Text.Trim(), inventoryDetail.BatchNo,inventoryDetail.Amount);
                storeDetail.Save();
            }
            */
            #endregion
        }

        private void popupGrid_BeforePopupFormShow(object sender, Controls.CommonCode.BeforePopupFormShowArgs e)
        {
            string fieldName = "产品ID";
            string fieldName2 = "批号";
            List<string> filters = new List<string>();
            for (int i = 0; i < this.popupGrid.PopupView.RowCount; i++)
            {
                object fieldValue = this.popupGrid.PopupView.GetRowCellValue(i, fieldName);
                object fieldValue2 = this.popupGrid.PopupView.GetRowCellValue(i, fieldName2);
                if (fieldValue != null && fieldValue != DBNull.Value)
                {
                    string item = string.Format("([产品ID]={0} AND [批号]='{1}')", fieldValue, fieldValue2);
                    if (!filters.Contains(item))
                    {
                        filters.Add(item);
                    }
                }
            }
            if (filters.Any())
            {
                string productsFilter = string.Join(" OR ", filters);

                e.ActiveOperationColumn.PopupForm.Filter = string.Format("NOT ({0})",productsFilter);
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            DialogResult result = XtraMessageBox.Show("确定要保存并导出盘点单吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                if (SaveInventoryRecordsForImportResult())
                {
                    using (SaveFileDialog fileDialog = new SaveFileDialog())
                    {
                        fileDialog.FileName = string.Format("盘点单-{0}", txtInventoryCode.Text.Trim());

                        fileDialog.Filter = "Excel文件(*.xls)|*.xls";
                        fileDialog.Title = "选择要导出盘点数据的文件位置";
                        fileDialog.InitialDirectory = "桌面";

                        if (fileDialog.ShowDialog(this) == DialogResult.OK)
                        {
                            for (int i = 0; i < this.popupGrid.PopupView.RowCount; i++)
                            {
                                object productCode = this.popupGrid.PopupView.GetRowCellValue(i, "产品编号");
                                object productName = this.popupGrid.PopupView.GetRowCellValue(i, "产品名称");
                                object batchNumber = this.popupGrid.PopupView.GetRowCellValue(i, "批号");
                                //object fieldValue2 = this.popupGrid.PopupView.GetRowCellValue(i, "规格型号");
                                //object fieldValue2 = this.popupGrid.PopupView.GetRowCellValue(i, "剂型");
                                object amount = this.popupGrid.PopupView.GetRowCellValue(i, "库存数量");
                                if (productCode != null
                                    && productCode != DBNull.Value
                                    && productName != null
                                    && productName != DBNull.Value
                                    && batchNumber != null
                                    && batchNumber != DBNull.Value
                                    && (amount == null
                                        || amount == DBNull.Value))
                                {
                                    this.popupGrid.PopupView.SetRowCellValue(i, "盘点数量", "-1");
                                }
                            }
                            this.popupGrid.ExportToXls(fileDialog.FileName);

                            for (int i = 0; i < this.popupGrid.PopupView.RowCount; i++)
                            {
                                object productCode = this.popupGrid.PopupView.GetRowCellValue(i, "产品编号");
                                object productName = this.popupGrid.PopupView.GetRowCellValue(i, "产品名称");
                                object batchNumber = this.popupGrid.PopupView.GetRowCellValue(i, "批号");
                                //object fieldValue2 = this.popupGrid.PopupView.GetRowCellValue(i, "规格型号");
                                //object fieldValue2 = this.popupGrid.PopupView.GetRowCellValue(i, "剂型");
                                object amount = this.popupGrid.PopupView.GetRowCellValue(i, "库存数量");
                                if (productCode != null
                                    && productCode != DBNull.Value
                                    && productName != null
                                    && productName != DBNull.Value
                                    && batchNumber != null
                                    && batchNumber != DBNull.Value
                                    && amount != null
                                    && amount != DBNull.Value
                                    && amount.ToString() == "-1")
                                {
                                    this.popupGrid.PopupView.SetRowCellValue(i, "盘点数量", "");
                                }
                            }
                        }
                    }
                    this.DialogResult = DialogResult.OK;
                }
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            DialogResult result = XtraMessageBox.Show("确定要导入盘点结果吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                btnSave.Enabled = false;
                using (OpenFileDialog fileDialog = new OpenFileDialog())
                {
                    //fileDialog.FileName = string.Format("盘点单-{0}", txtInventoryCode.Text.Trim());

                    fileDialog.Filter = "Excel文件(*.xls)|*.xls";
                    fileDialog.Title = "选择要导入盘点结果文件的位置";
                    fileDialog.InitialDirectory = "桌面";

                    if (fileDialog.ShowDialog(this) == DialogResult.OK)
                    {
                        string errorMessage = string.Empty;
                        if (!fileDialog.FileName.Contains(txtInventoryCode.Text.Trim()))
                        {
                            XtraMessageBox.Show(string.Format("盘点单号不一致，请导入单号为 {0} 的盘点结果文件！", txtInventoryCode.Text.Trim()), "错误", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                            return;
                        }
                        List<InventoryDetail> importedInventoryDetails = ProcessFile(fileDialog.FileName, ref errorMessage);
                        if (!string.IsNullOrWhiteSpace(errorMessage))
                        {
                            XtraMessageBox.Show(errorMessage, "错误", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                            return;
                        }

                        if (!importedInventoryDetails.Any())
                        {
                            XtraMessageBox.Show("盘点结果文件未导入任何结果", "错误", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                            return;
                        }

                        EntityCollection<BFIProductEntity> productEntities = new EntityCollection<BFIProductEntity>();
                        productEntities.Fetch();

                        var products = productEntities.Cast<BFIProductEntity>().AsQueryable().ToList();

                        popupGrid.InitGrid();
                        foreach (var inventoryDetail in importedInventoryDetails)
                        {
                            var product = products.SingleOrDefault(p => p.ProductCode == inventoryDetail.产品编号);
                            if (null != product)
                            {
                                this.popupGrid.PopupView.SetFocusedRowCellValue("产品ID", product.ProductID);
                                this.popupGrid.PopupView.SetFocusedRowCellValue("产品编号", inventoryDetail.产品编号);
                                this.popupGrid.PopupView.SetFocusedRowCellValue("产品名称", inventoryDetail.产品名称);
                                this.popupGrid.PopupView.SetFocusedRowCellValue("批号", inventoryDetail.批号);
                                this.popupGrid.PopupView.SetFocusedRowCellValue("生产厂商", inventoryDetail.生产厂商);
                                this.popupGrid.PopupView.SetFocusedRowCellValue("生产日期", inventoryDetail.生产日期);
                                this.popupGrid.PopupView.SetFocusedRowCellValue("有效期至", inventoryDetail.有效期至);
                                this.popupGrid.PopupView.SetFocusedRowCellValue("规格型号", inventoryDetail.规格型号);
                                this.popupGrid.PopupView.SetFocusedRowCellValue("剂型", inventoryDetail.剂型);
                                this.popupGrid.PopupView.SetFocusedRowCellValue("单位", inventoryDetail.单位);
                                this.popupGrid.PopupView.SetFocusedRowCellValue("包装规格型号", inventoryDetail.包装规格);
                                this.popupGrid.PopupView.SetFocusedRowCellValue("包装比例", inventoryDetail.包装比例);
                                this.popupGrid.PopupView.SetFocusedRowCellValue("注册证号", inventoryDetail.注册证号);
                                this.popupGrid.PopupView.SetFocusedRowCellValue("贮藏条件", inventoryDetail.贮藏条件);
                                this.popupGrid.PopupView.SetFocusedRowCellValue("库存数量", inventoryDetail.库存数量);
                                this.popupGrid.PopupView.SetFocusedRowCellValue("盘点数量", inventoryDetail.盘点数量);
                                this.popupGrid.PopupView.SetFocusedRowCellValue("盘点数量", inventoryDetail.盘点数量);
                                this.popupGrid.PopupView.AddNewRow();
                                this.popupGrid.PopupView.FocusedRowHandle = GridControl.NewItemRowHandle;
                            }
                        }
                    }
                }
            }
        }

        private List<InventoryDetail> ProcessFile(string fileName, ref string errorMessage)
        {
            List<InventoryDetail> importedRecords = new List<InventoryDetail>();
            try
            {
                var excel = new ExcelQueryFactory(fileName);
                excel.AddMapping<InventoryDetail>(x => x.产品编号 , "产品编号");
                excel.AddMapping<InventoryDetail>(x => x.产品名称, "产品名称");
                excel.AddMapping<InventoryDetail>(x => x.生产厂商, "生产厂商");
                excel.AddMapping<InventoryDetail>(x => x.规格型号, "规格型号");
                excel.AddMapping<InventoryDetail>(x => x.剂型, "剂型");
                excel.AddMapping<InventoryDetail>(x => x.单位, "单位");
                excel.AddMapping<InventoryDetail>(x => x.批号, "批号");
                excel.AddMapping<InventoryDetail>(x => x.包装规格, "包装规格型号");
                excel.AddMapping<InventoryDetail>(x => x.包装比例, "包装比例");
                excel.AddMapping<InventoryDetail>(x => x.注册证号, "注册证号");
                excel.AddMapping<InventoryDetail>(x => x.贮藏条件, "贮藏条件");
                excel.AddMapping<InventoryDetail>(x => x.生产日期, "生产日期");
                excel.AddMapping<InventoryDetail>(x => x.有效期至, "有效期至");
                excel.AddMapping<InventoryDetail>(x => x.库存数量, "库存数量");
                excel.AddMapping<InventoryDetail>(x => x.盘点数量, "盘点数量");
                excel.AddMapping<InventoryDetail>(x => x.差异数量, "差异数量");
                excel.AddMapping<InventoryDetail>(x => x.盘点结果, "盘点结果");

                importedRecords = (from c in excel.Worksheet<InventoryDetail>(0)
                                       where c.产品编号 != null
                                       select c).ToList();
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
            }
            return importedRecords;
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            using (FrmAddInventory fa = new FrmAddInventory())
            {
                fa.InventoryID = m_id.Value;
                DialogResult dr = fa.ShowDialog();
                if (dr == DialogResult.Yes)
                {
                    FrmSingleInventory_Load(null,null);
                }
            }
        }
    }

    internal class InventoryDetail
    {
        public int 产品ID { get; set; }
        public string 产品编号 { get; set; }
        public string 产品名称 { get; set; }
        public string 生产厂商 { get; set; }
        public string 规格型号 { get; set; }
        public string 剂型 { get; set; }
        public string 单位 { get; set; }
        public string 批号 { get; set; }
        public DateTime? 生产日期 { get; set; }
        public DateTime? 有效期至 { get; set; }
        public int? 库存数量 { get; set; }
        public int? 盘点数量 { get; set; }
        public int? 差异数量 { get; set; }
        public string 盘点结果 { get; set; }
        public string 包装规格 { get; set; }
        public string 包装比例 { get; set; }
        public string 注册证号 { get; set; }
        public string 贮藏条件 { get; set; }
    }
}