using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DQS.Module.Entities;
using DQS.Common;
using ORMSCore;

namespace DQS.AppViews.StoreAndCuring.StockManager
{
    public partial class FrmSingleInitInventory : DevExpress.XtraEditors.XtraForm
    {
        private int? m_id;

        public FrmSingleInitInventory()
        {
            InitializeComponent();
        }

        private void FrmSingleInitInventory_Load(object sender, EventArgs e)
        {
            this.cbxDepartment.InitSource();
            if (this.Tag != null)
            {
                this.m_id = Convert.ToInt32(this.Tag);

                BUSStoreDetailEntity entity = new BUSStoreDetailEntity { StoreDetailID = m_id.Value };
                entity.Fetch();
                CustomGetEntity(entity);
                this.ftPanel.SetEntity(entity);
                txtProductCode.Enabled = false;
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.ftPanel.ValidateIsNullFields()) return;

                BUSStoreDetailEntity entity = this.ftPanel.GetEntity() as BUSStoreDetailEntity;

                this.CustomSetEntity(entity);

                if (this.m_id != null)
                {
                    #region 修改
                    BUSStoreDetailEntity storeDetail = new BUSStoreDetailEntity { StoreDetailID = m_id.Value };
                    
                    //更新库存
                    storeDetail.Fetch();

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
    '{8}',
    '{9}',
    (SELECT ISNULL((SELECT TOP 1 ISNULL(VersionNumber, 0) FROM dbo.BUS_StoreDetailChangeHistory WHERE StoreDetailID={0} ORDER BY ChangeDate DESC),0)+1),
    '修改 - DQS库存管理',
    '{1}',
    GETDATE()
FROM dbo.BUS_StoreDetail
WHERE StoreDetailID={0}
";
                    string changeUserName = null == GlobalItem.g_CurrentEmployee
                        ? GlobalItem.g_CurrentUser.UserName
                        : GlobalItem.g_CurrentEmployee.EmployeeName;
                    string sql = string.Format(sqlString, m_id.Value, changeUserName,
                        entity.ProductID, entity.BatchNo, entity.ProduceDate, entity.ValidateDate,
                        entity.Amount, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), entity.DetailRemark,
                        entity.IsNullField("DepartmentID") ? 0 : entity.DepartmentID);
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
                    storeDetail.Amount = entity.Amount;
                    storeDetail.BatchNo = entity.BatchNo;
                    storeDetail.ProduceDate = entity.ProduceDate;
                    storeDetail.ValidateDate = entity.ValidateDate;
                    storeDetail.DetailRemark = entity.DetailRemark;
                    if (!entity.IsNullField("DepartmentID"))
                    {
                        storeDetail.DepartmentID = entity.DepartmentID;
                    }
                    storeDetail.LastCuringDate = DateTime.Now;
                    storeDetail.LastModifyDate = DateTime.Now;
                    storeDetail.LastModifyUserID = GlobalItem.g_CurrentUser.UserID;
                    storeDetail.Update();

                    #endregion
                }
                else
                {
                    #region 新建

                    entity.LastCuringDate = DateTime.Now;
                    entity.CreateDate = DateTime.Now;
                    entity.LastModifyDate = DateTime.Now;
                    entity.CreateUserID = GlobalItem.g_CurrentUser.UserID;
                    entity.LastModifyUserID = GlobalItem.g_CurrentUser.UserID;
                    entity.Save();

                    EntityCollection<BUSStoreDetailEntity> storeDetails = new EntityCollection<BUSStoreDetailEntity>();
                    storeDetails.Fetch(BUSStoreDetailEntityFields.ProductID == entity.ProductID &
                        BUSStoreDetailEntityFields.BatchNo == entity.BatchNo &
                        BUSStoreDetailEntityFields.DepartmentID == (cbxDepartment.SelectedValue == null ? 0 : (int)cbxDepartment.SelectedValue) &
                        BUSStoreDetailEntityFields.Amount == entity.Amount);
                    if (storeDetails.Count > 0)
                    {
                        var busStoreDetailEntity = storeDetails[0] as BUSStoreDetailEntity;
                        if (busStoreDetailEntity != null)
                        {
                            m_id = busStoreDetailEntity.StoreDetailID;

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
    '新建 - DQS库存管理',
    '{1}',
    GETDATE()
FROM dbo.BUS_StoreDetail
WHERE StoreDetailID={0}
";
                            string changeUserName = null == GlobalItem.g_CurrentEmployee
                                ? GlobalItem.g_CurrentUser.UserName
                                : GlobalItem.g_CurrentEmployee.EmployeeName;
                            string sql = string.Format(sqlString, m_id.Value, changeUserName);
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
                    }

                    #endregion
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 非文本框取值
        /// </summary>
        /// <param name="entity">实体</param>
        protected virtual void CustomGetEntity(BUSStoreDetailEntity entity)
        {
            if (!entity.IsNullField("ProductID"))
            {
                this.txtProductCode.SetMemberValue(entity.ProductID);
                BFIProductEntity productEntity = new BFIProductEntity{ProductID = entity.ProductID};
                productEntity.Fetch();

                if (!productEntity.IsNullField("ProductName"))
                {
                    this.txtProductName.Text = productEntity.ProductName;
                }

                if (!productEntity.IsNullField("PhysicType"))
                {
                    this.txtPhysicType.Text = productEntity.PhysicType;
                }

                if (!productEntity.IsNullField("PackageSpec"))
                {
                    this.txtPackageSpec.Text = productEntity.PackageSpec;
                }

                if (!productEntity.IsNullField("ProducerName"))
                {
                    this.txtProducerName.Text = productEntity.ProducerName;
                }

                if (!productEntity.IsNullField("ProductSpec"))
                {
                    this.txtProductSpec.Text = productEntity.ProductSpec;
                }

                if (!productEntity.IsNullField("ProductStyle"))
                {
                    this.txtProductStyle.Text = productEntity.ProductStyle;
                }

                if (!productEntity.IsNullField("ProductUnit"))
                {
                    this.txtProductUnit.Text = productEntity.ProductUnit;
                }

                if (!productEntity.IsNullField("AuthorizedNo"))
                {
                    this.txtAuthorizedNo.Text = productEntity.AuthorizedNo;
                }
            }

            if (!entity.IsNullField("ProduceDate"))
            {
                this.dteProduceDate.DateTime = entity.ProduceDate;
            }

            if (!entity.IsNullField("ValidateDate"))
            {
                this.dteValidateDate.DateTime = entity.ValidateDate;
            }

            if (!entity.IsNullField("BatchNo"))
            {
                this.txtBatchNo.Text = entity.BatchNo;
            }

            if (!entity.IsNullField("Amount"))
            {
                this.speAmount.Value = entity.Amount;
            }
            else
            {
                this.speAmount.Value = 0;
            }

            if (!entity.IsNullField("DepartmentID"))
            {
                this.cbxDepartment.SelectedValue = entity.DepartmentID;
            }
        }
        /// <summary>
        /// 非文本框赋值
        /// </summary>
        /// <param name="entity">实体</param>
        protected virtual void CustomSetEntity(BUSStoreDetailEntity entity)
        {
            entity.ProductID = (int) txtProductCode.SelectedValue;
            entity.ProduceDate = dteProduceDate.DateTime;
            entity.ValidateDate = dteValidateDate.DateTime;
            entity.BatchNo = txtBatchNo.Text.Trim();
            entity.Amount = (int)speAmount.Value;
            entity.DetailRemark = txtDetailRemark.Text.Trim();

            if (null != cbxDepartment.SelectedValue)
            {
                entity.DepartmentID = Convert.ToInt32(cbxDepartment.SelectedValue);
            }
        }

        private void txtProductCode_PopupClosing(object sender, EventArgs e)
        {
            if (this.txtProductCode.EditData != null)
            {
                this.txtProductName.Text = (this.txtProductCode.EditData as DataRow)["药品名称"].ToString();
                this.txtProductSpec.Text = (this.txtProductCode.EditData as DataRow)["规格"].ToString();
                this.txtProductUnit.Text = (this.txtProductCode.EditData as DataRow)["单位"].ToString();
                this.txtPackageSpec.Text = (this.txtProductCode.EditData as DataRow)["包装规格"].ToString();
                this.txtPhysicType.Text = (this.txtProductCode.EditData as DataRow)["剂型"].ToString();
                this.txtAuthorizedNo.Text = (this.txtProductCode.EditData as DataRow)["批准文号"].ToString();
                this.txtProductStyle.Text = (this.txtProductCode.EditData as DataRow)["药品类别"].ToString();
                this.txtProducerName.Text = (this.txtProductCode.EditData as DataRow)["生产厂商"].ToString();

                this.txtBatchNo.Focus();
            }
        }
    }
}