﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DQS.Common;
using DQS.Controls;
using DQS.Module.Entities;
using DQS.Module.Views;
using ORMSCore;

namespace DQS.AppViews.QualityDocument.ProductManager
{
    public partial class FrmSingleFirstProductChange : DevExpress.XtraEditors.XtraForm
    {
        private Guid m_id;
        private ATCAntiApproveEntity entity;
        public FrmSingleFirstProductChange()
        {
            InitializeComponent();
        }

        public FrmSingleFirstProductChange(bool isView)
            : this()
        {
            btnAccept.Visible = !isView;
            btnDeny.Visible = !isView;
        }

        private void FrmSingleFirstProductChange_Load(object sender, EventArgs e)
        {
            this.popupGrid.InitGrid();

            if (this.Tag != null)
            {
                this.m_id = new Guid(this.Tag.ToString());

                entity = new ATCAntiApproveEntity { AntiApproveID = m_id };
                entity.Fetch();

                this.CustomGetEntity(entity);
                this.popupGrid.SetGridData(m_id, true);
                BindCertificateChanges();
            }
        }
        private void BindCertificateChanges()
        {
            string sql = string.Format("SELECT QualificationName AS [档案名称], QualificationCode AS [档案编号], ActionRemark AS [操作] FROM ATC_AntiApproveQualificationAction WHERE AntiApproveID='{0}'", m_id);

            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {

                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                da.Fill(ds);
                conn.Close();
                popupGrid1.DataSource = ds.Tables[0];
            }
            var gridView = popupGrid1.MainView as GridView;
            if (gridView != null)
            {
                for (int index = 0; index < gridView.Columns.Count; index++)
                {
                    gridView.Columns[index].OptionsColumn.AllowEdit = false;
                }

                DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit x = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
                gridView.Columns[gridView.Columns.Count - 1].ColumnEdit = x;
                gridView.OptionsView.RowAutoHeight = true;
                gridView.BestFitColumns();
            }
        }

        private void btnProductInfo_Click(object sender, EventArgs e)
        {
            int productId = (int) btnProductInfo.Tag;
            FrmSingleFirstProductChangeDetail doc = new FrmSingleFirstProductChangeDetail();
            doc.Tag = productId;
            doc.MarkChangedFieds(m_id);
            doc.ShowDialog(this);
        }
        private void btnAccept_Click(object sender, EventArgs e)
        {
            try
            {
                if (DialogResult.Yes ==
                    XtraMessageBox.Show("确定同意信息变更？", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    AcceptChanges();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }

        private void btnDeny_Click(object sender, EventArgs e)
        {
            try
            {
                if (DialogResult.Yes ==
                    XtraMessageBox.Show("确定拒绝信息变更？", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    DenyChanges();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }

        private void AcceptChanges()
        {
            if (null != entity)
            {
                List<string> updateFieldsToNull = new List<string>();
                int productID = entity.AntiApproveItemID;
                BFIProductEntity product = new BFIProductEntity { ProductID = productID };
                product.Fetch();

                EntityCollection<ATCAntiApproveDetailEntity> details = new EntityCollection<ATCAntiApproveDetailEntity>();
                details.Fetch(ATCAntiApproveDetailEntityFields.AntiApproveID == entity.AntiApproveID);

                foreach (ATCAntiApproveDetailEntity detail in details)
                {

                    PropertyInfo property = product.GetType().GetProperty(detail.FieldName);
                    if (detail.FieldType == "Boolean")
                    {
                        if (detail.NewValue.Trim() == "是")
                        {
                            property.SetValue(product, true, null);
                        }
                        else
                        {
                            property.SetValue(product, false, null);
                        }
                    }
                    else
                    {
                        property.SetValue(product, Convert.ChangeType(detail.NewValue.Trim(), property.PropertyType), null);
                    }

                }
                product.LastModifyDate = entity.CreateDate;
                product.LastModifyUserID = entity.CreateUserID;
                product.Update();

                UpdateNullFields(productID, updateFieldsToNull);

                ATCUserEntity currentUser = GlobalItem.g_CurrentUser;
                BFIEmployeeEntity currentEmployee = GlobalItem.g_CurrentEmployee;

                entity.StatusID = 2;
                entity.StatusName = "同意变更";
                entity.ApproveUserID = currentUser.UserID;
                if (null != currentEmployee)
                {
                    entity.ApprovePerson = currentEmployee.EmployeeName;
                }
                else
                {
                    entity.ApprovePerson = currentUser.UserName;
                }
                entity.ApproveDate = DateTime.Now;
                entity.Update();

                UpdateCertificates();
            }
            this.DialogResult = DialogResult.OK;
        }

        private void UpdateNullFields(int productID, List<string> updateFieldsToNull)
        {
            if (!updateFieldsToNull.Any())
            {
                return;
            }

            StringBuilder sql = new StringBuilder("UPDATE BFI_Product SET CreateDate=CreateDate");
            foreach (string field in updateFieldsToNull)
            {
                sql.AppendFormat(",{0}=NULL", field);
            }
            sql.AppendFormat(" WHERE ProductID={0}", productID);

            SqlCommand command = new SqlConnection(GlobalItem.g_DbConnectStrings).CreateCommand();
            command.CommandType =  CommandType.Text;
            command.CommandText = sql.ToString();
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

        private void UpdateCertificates()
        {
            const string tableName = "BFI_Product";
            const string fieldName = "ProductID";

            //取旧电子档案
            string updateSql = @"UPDATE O
    SET
        CertificateNo = N.CertificateNo,
        IssuingAuthority = N.IssuingAuthority,
        IssuingDate = N.IssuingDate,
        ValidateDate = N.ValidateDate,
        LastModifyUserID = N.LastModifyUserID,
        LastModifyDate = N.LastModifyDate,
        QualificationRemark = N.QualificationRemark
    FROM dbo.BFI_Qualification AS O
        INNER JOIN dbo.ATC_AntiApproveQualificationDetail AS N
        ON N.QualificationID = O.QualificationID
            AND N.QualificationCode = O.QualificationCode
    WHERE
        N.AntiApproveID='{0}'
        AND N.BelongTable='{1}'
        AND N.BelongFieldName='{2}'
        AND
        (
            ISNULL(N.CertificateNo,'') <> ISNULL(O.CertificateNo,'')
            OR ISNULL(N.IssuingAuthority,'') <> ISNULL(O.IssuingAuthority,'')
            OR ISNULL(N.IssuingDate,'') <> ISNULL(O.IssuingDate,'')
            OR ISNULL(N.ValidateDate,'') <> ISNULL(O.ValidateDate,'')
            OR ISNULL(N.QualificationRemark,'') <> ISNULL(O.QualificationRemark,'')
        )";
            SqlCommand command = new SqlConnection(GlobalItem.g_DbConnectStrings).CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = string.Format(updateSql, m_id, tableName, fieldName);
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
        private void DenyChanges()
        {
            if (null != entity)
            {

                entity.StatusID = 3;
                entity.StatusName = "拒绝变更";

                ATCUserEntity currentUser = GlobalItem.g_CurrentUser;
                BFIEmployeeEntity currentEmployee = GlobalItem.g_CurrentEmployee;

                entity.ApproveUserID = currentUser.UserID;
                if (null != currentEmployee)
                {
                    entity.ApprovePerson = currentEmployee.EmployeeName;
                }
                else
                {
                    entity.ApprovePerson = currentUser.UserName;
                }
                entity.ApproveDate = DateTime.Now;
                entity.Update();
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
        protected virtual void CustomGetEntity(ATCAntiApproveEntity entity)
        {
            if (!entity.IsNullField("AntiApproveItemName"))
            {
                this.txtProductName.Text = entity.AntiApproveItemName;
            }

            if (!entity.IsNullField("AntiApproveItemCode"))
            {
                this.txtProductCode.Text = entity.AntiApproveItemCode;
            }

            if (!entity.IsNullField("RequestPerson"))
            {
                this.txtRequestPerson.Text = entity.RequestPerson;
            }

            if (!entity.IsNullField("CreateDate"))
            {
                this.txtCreateDate.Text = entity.CreateDate.ToString("yyyy年M月d日 HH时m分");
            }
            btnProductInfo.Tag = entity.AntiApproveItemID;
        }
    }
}