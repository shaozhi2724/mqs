using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DQS.Common;
using DQS.Controls;
using DQS.Module.Entities;

namespace DQS.AppViews.StoreAndCuring.StockManager
{
    public partial class FrmInitInventory : StandardForm
    {
        public FrmInitInventory()
        {
            InitializeComponent();
        }

        private void FrmInitInventory_Load(object sender, EventArgs e)
        {
            this.pageNavigator.SortField = "产品编号";
            this.pageNavigator.SortType = "ASC";
            base.InitPage();
        }

        protected override void CustomDelete()
        {

            object id = gvData.GetFocusedRowCellValue("库存ID");
            if (id != null)
            {
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
    ProductID,
    BatchNo,
    ProduceDate,
    ValidateDate,
    Amount,
    LastCuringDate,
    DetailRemark,
    DepartmentID,
    (SELECT ISNULL((SELECT TOP 1 ISNULL(VersionNumber, 0) FROM dbo.BUS_StoreDetailChangeHistory WHERE StoreDetailID={0} ORDER BY ChangeDate DESC),0)+1),
    '删除 - DQS库存管理',
    '{1}',
    GETDATE()
FROM dbo.BUS_StoreDetail
WHERE StoreDetailID={0}
";
                string changeUserName = null == GlobalItem.g_CurrentEmployee
                    ? GlobalItem.g_CurrentUser.UserName
                    : GlobalItem.g_CurrentEmployee.EmployeeName;
                string sql = string.Format(sqlString, (int)id, changeUserName);
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
            }


            base.CustomDelete();
        }
    }
}