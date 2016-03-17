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
using ORMSCore;
using DQS.Module.Entities;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraLayout.Utils;
using DQS.Common;

namespace DQS.AppViews.QualityControl.UserManager
{
    public partial class FrmSingleUser : DevExpress.XtraEditors.XtraForm
    {
        private Guid? m_id;

        private ATCUserEntity m_ModifyUser;

        public FrmSingleUser()
        {
            InitializeComponent();

            var gridView = this.popupGrid.MainView as GridView;
            if (gridView != null)
            {
                gridView.OptionsSelection.MultiSelect = true;
                gridView.OptionsSelection.MultiSelectMode = GridMultiSelectMode.RowSelect;
            }
        }

        private void FrmSingleUser_Load(object sender, EventArgs e)
        {
            this.InitCategory();
            chkUseInternalProductPrice.Checked = true;
            //BindGrantedProducts();
            BindAreas();
            if (this.Tag != null)
            {
                this.txtPassword2.IsNullValidate = false;
                this.txtUserPassword.IsNullValidate = false;
                this.layPassword.Visibility = LayoutVisibility.Never;
                this.layPassword2.Visibility = LayoutVisibility.Never;
                btnRePassword.Visible = GlobalItem.g_CurrentUser.UserCode == "admin" || GlobalItem.g_CurrentUser.UserCode == "root" ? true : false;


                this.m_id = new Guid(this.Tag.ToString());

                m_ModifyUser = new ATCUserEntity { UserID = m_id.Value };
                m_ModifyUser.Fetch();
                BindGrantedAreas();
                this.ftPanel.SetEntity(m_ModifyUser);

                this.txtUserCode.Enabled = false;
                //this.txtPopupEmployee.Enabled = false;

                /****************非文本框赋值****************************************************************/

                rgpStatus.EditValue = m_ModifyUser.UserStatus;
                if (!m_ModifyUser.IsNullField("EmployeeID"))
                {
                    txtPopupEmployee.SetMemberValue(m_ModifyUser.EmployeeID);
                }
                /********************************************************************************/
                chkUseInternalProductPrice.Checked = m_ModifyUser.UseInternalProductPrice;
				BindGrantedProducts();
                BindGridDeputy();
            }
        }

        private void BindGrantedAreas()
        {
            EntityCollection<ATCUserAreaEntity> userAreas = new EntityCollection<ATCUserAreaEntity>();
            userAreas.Fetch(ATCUserAreaEntityFields.UserID == m_id.Value);

            if (userAreas.Count > 0)
            {
                this.chkArea.UnCheckAll(); //先全部清空

                foreach (ATCUserAreaEntity area in userAreas)
                {
                    foreach (CheckedListBoxItem item in this.chkArea.Items)
                    {
                        if (item.Value.ToString() == area.AreaName)
                        {
                            this.chkArea.SelectedItem = item;
                            item.CheckState = CheckState.Checked;
                            break;
                        }
                    }
                }
            }
            else
            {
                this.chkArea.SelectedIndex = 0;
                this.chkArea.UnCheckAll();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ftPanel.ValidateIsNullFields()) return;

            ATCUserEntity entity = this.ftPanel.GetEntity() as ATCUserEntity;

            /****************非文本框赋值****************************************************************/

            entity.UserStatus = Convert.ToInt32(rgpStatus.EditValue);
            entity.EmployeeID = Convert.ToInt32(txtPopupEmployee.SelectedValue);
            entity.UseInternalProductPrice = chkUseInternalProductPrice.Checked;
            if (this.m_id == null)
            {
                //两次密码
                if (this.txtUserPassword.Text.Trim() != this.txtPassword2.Text.Trim())
                {
                    XtraMessageBox.Show("两次密码输入不一致，请重新输入。");
                    this.txtPassword2.Focus();
                    this.txtPassword2.Select(this.txtPassword2.Text.Length, 0);
                    return;
                }

                if (!entity.IsNew(ATCUserEntityFields.EmployeeID == entity.EmployeeID))
                {
                    XtraMessageBox.Show("该员工已注册。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            else
            {
                if (m_ModifyUser != null)
                {
                    if (!entity.IsNew(ATCUserEntityFields.EmployeeID == entity.EmployeeID & ATCUserEntityFields.EmployeeID != m_ModifyUser.EmployeeID))
                    {
                        XtraMessageBox.Show("该员工已注册。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                }
            }
            /********************************************************************************/

            if (this.m_id != null)
            {
                entity.UserPassword = null;//修改时不修改密码
                entity.LastModifyDate = DateTime.Now;
                entity.LastModifyUserID = GlobalItem.g_CurrentUser.UserID;
                entity.Update();
                //SaveGrantedProducts(this.m_id.Value, txtUserName.Text.Trim());
                SaveGrantedAreas(this.m_id.Value, txtUserName.Text.Trim());
            }
            else
            {
                if (entity.IsNew())
                {
                    Guid userid = Guid.NewGuid();
                    entity.UserID = userid;
                    entity.UserPassword = GlobalMethod.GetEncryptPassword(entity.UserPassword);
                    entity.CreateDate = DateTime.Now;
                    entity.LastModifyDate = DateTime.Now;
                    entity.CreateUserID = GlobalItem.g_CurrentUser.UserID;
                    entity.LastModifyUserID = GlobalItem.g_CurrentUser.UserID;
                    entity.Save();
                    m_id = userid;
                    //SaveGrantedProducts(userid, txtUserName.Text.Trim());
                    SaveGrantedAreas(userid, txtUserName.Text.Trim());
                }
                else
                {
                    XtraMessageBox.Show("用户编号已存在。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            //SaveGrantedProducts(this.m_id.Value, txtUserName.Text.Trim());
            //SaveDeputyProducts(this.m_id.Value, txtUserName.Text.Trim());
            
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InitCategory()
        {
            EntityCollection<SYSCategoryEntity> categories = new EntityCollection<SYSCategoryEntity>();
            categories.Fetch(SYSCategoryEntityFields.CategoryCode == "UserStatus");
            foreach (SYSCategoryEntity category in categories)
            {
                RadioGroupItem item = new RadioGroupItem
                {
                    Description = category.ItemName,
                    Value = category.ItemID
                };
                this.rgpStatus.Properties.Items.Add(item);
            }

            if (rgpStatus.Properties.Items.Count > 0)
            {
                rgpStatus.SelectedIndex = 0;
            }
        }

        private void btnRePassword_Click(object sender, EventArgs e)
        {
            if (this.m_id != null)
            {
                ATCUserEntity modifyUserPassword = new ATCUserEntity { UserID = m_id.Value, UserPassword = GlobalMethod.GetEncryptPassword(this.txtUserCode.Text.Trim()) };
                modifyUserPassword.Update();

                XtraMessageBox.Show(String.Format("密码重置成功，重置密码为“{0}”，新密码将在下一次系统登录时生效。", this.txtUserCode.Text.Trim()), "系统信息", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        #region 销售区域授权

        private void BindAreas()
        {
            EntityCollection<BFIDealerEntity> areas = new EntityCollection<BFIDealerEntity>();
            areas.Fetch();
            List<string> areaList = areas.Cast<BFIDealerEntity>().AsQueryable().Select(p => p.DealerArea).Where(p => !string.IsNullOrWhiteSpace(p)).Distinct().OrderBy(p => p).ToList();

            foreach (string c in areaList)
            {
                this.chkArea.Items.Add(c);
            }
        }
		private void SaveGrantedAreas(Guid userID, string userName)
        {
            ATCUserAreaEntity userArea = new ATCUserAreaEntity { UserID = userID };
            userArea.DeleteByCommonly();

            foreach (CheckedListBoxItem area in this.chkArea.CheckedItems)
            {
                userArea.UserName = userName;
                userArea.AreaName = area.Value.ToString();
                userArea.Save();
            }
        }
        #endregion

        private void chkCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCheck.Checked)
            {
                chkCheck.Text = "反选";
                this.chkArea.CheckAll();
            }
            else
            {
                chkCheck.Text = "全选";
                this.chkArea.UnCheckAll();
            }
        }

        List<int> selectedProductIDs = new List<int>();
        List<int> ProductIDs = new List<int>();
        private void barBtnNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int pageSize = 10000;
            string formatQueryString = "[产品编号] LIKE '%{0}%' OR [产品名称] LIKE '%{0}%' OR [产品名称Spell] LIKE '%{0}%'";
            string viewName = "vw_AllUserProduct";
            string primaryField = "产品ID";
            string fields = "产品ID,产品编号,产品名称,产品名称Spell,生产厂商,规格型号,包装规格型号,包装比例,注册证号,贮藏条件,产品类别,单位,归属人";
            string filter = "([状态] IS NULL OR [状态] = '正常') AND ([归属人] = '未关联')";
            //List<int> selectedProductIDs = new List<int>();
            /*
            DataTable dataSource = popupGrid.DataSource as DataTable;
            if (dataSource != null)
            {
                EnumerableRowCollection<DataRow> enumerableRowCollection = dataSource.AsEnumerable();
                if (enumerableRowCollection.Any())
                {
                    selectedProductIDs = enumerableRowCollection.Select(p => Convert.ToInt32(p["产品ID"])).ToList();
                }
            }
            if (selectedProductIDs.Any())
            {
                string productsFilter = string.Join(",", selectedProductIDs);
                filter += string.Format(" AND ([产品ID] NOT IN ({0}))", productsFilter);
                //filter += string.Format(" AND ([归属人] = '未关联' )");
            }
            */
            using (FrmPopupQueryMultiple frmPopupQueryMultiple = new FrmPopupQueryMultiple(formatQueryString, viewName, primaryField, fields, filter, pageSize, "产品类别"))
            {
                DialogResult result = frmPopupQueryMultiple.ShowDialog();
                if (result == DialogResult.OK)
                {
                    var rows = frmPopupQueryMultiple.EditRows;
                    BindGrantedProducts(rows);
                    SaveGrantedProducts(this.m_id.Value, txtUserName.Text.Trim());
                    BindGrantedProducts(); 
                }
            }
        }

        private void barBtnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var gridView = this.popupGrid.MainView as GridView;
            if (null != gridView)
            {
                List<int> deletedProductGrants = new List<int>();
                int[] selectedRows = gridView.GetSelectedRows();

                if (selectedRows.Length > 0)
                {
                    DialogResult result = XtraMessageBox.Show("确定要删除选中的产品授权吗？", "警告", MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
                    if (result == DialogResult.OK)
                    {
                        foreach (var rowIndex in selectedRows)
                        {
                            DataRow selectedRow = gridView.GetDataRow(rowIndex);
                            deletedProductGrants.Add(Convert.ToInt32(selectedRow["产品ID"]));
                        }

                        string deleteSql = "DELETE.[dbo].[ATC_UserProduct] WHERE UserID='{0}' AND [ProductID] IN({1}) AND IsBelong = 1";
                        string sql = string.Format(deleteSql, m_id.Value, string.Join(",", deletedProductGrants));
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

                        BindGrantedProducts();
                    }
                }
                else
                {
                    XtraMessageBox.Show("请选择要删除的产品授权。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
        }
        #region 产品授权
        private void BindGrantedProducts()
        {
            string sql = string.Format(@"SELECT
    UserProductID AS [授权ID],
    ProductCategoryID AS [类别ID],
    ProductCategoryName AS [产品类别],
    up.ProductID AS [产品ID],
    p.ProductName AS [产品名称],
    p.PackageSpec AS [包装规格],
    p.ProducerName AS [生产厂家]
FROM
    dbo.ATC_UserProduct up
    INNER JOIN dbo.BFI_Product p
		ON up.ProductID = p.ProductID
WHERE UserID='{0}' AND IsBelong = 1
ORDER BY ProductCategoryID,up.ProductID", m_id.HasValue ? m_id.Value : Guid.Empty);

            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {

                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                da.Fill(ds);
                conn.Close();
                popupGrid.DataSource = ds.Tables[0];
            }
            var gridView = popupGrid.MainView as GridView;
            if (gridView != null)
            {
                for (int index = 0; index < gridView.Columns.Count; index++)
                {
                    gridView.Columns[index].Visible = !gridView.Columns[index].FieldName.EndsWith("ID");
                    gridView.Columns[index].OptionsColumn.AllowEdit = false;
                }

                gridView.OptionsView.RowAutoHeight = true;
                gridView.OptionsView.ShowGroupPanel = true;
                gridView.OptionsView.ShowGroupedColumns = true;
                gridView.Columns["产品类别"].GroupIndex = 0;
                gridView.ExpandAllGroups();
                gridView.BestFitColumns();
            }
        }

        private void BindGrantedProducts(DataRow[] rows)
        {
            Dictionary<int, string> productStyles = new Dictionary<int, string>();
            string sql = "SELECT [ItemID],[ItemName] FROM [dbo].[SYS_Category] WHERE CategoryCode='ProductStyle' ORDER BY ItemID";

            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                da.Fill(ds);
                conn.Close();

                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    int itemID = Convert.ToInt32(row["ItemID"]);
                    if (!productStyles.ContainsKey(itemID))
                    {
                        productStyles.Add(itemID, row["ItemName"].ToString());
                    }
                }
            }

            DataTable dataSource = popupGrid.DataSource as DataTable;
            if (dataSource == null)
            {
                BindGrantedProducts();
            }
            dataSource = popupGrid.DataSource as DataTable;
            EnumerableRowCollection<DataRow> enumerableRowCollection = dataSource.AsEnumerable();
            foreach (DataRow dataRow in rows)
            {
                if (null ==
                    enumerableRowCollection.FirstOrDefault(
                        p => Convert.ToInt32(p["产品ID"]) == Convert.ToInt32(dataRow["产品ID"])))
                {
                    var newRow = dataSource.NewRow();
                    newRow["类别ID"] = productStyles.SingleOrDefault(p => p.Value == dataRow["产品类别"].ToString()).Key;
                    newRow["产品类别"] = dataRow["产品类别"];
                    newRow["产品ID"] = dataRow["产品ID"];
                    newRow["产品名称"] = dataRow["产品名称"];
                    newRow["包装规格型号"] = dataRow["包装规格型号"];
                    newRow["生产厂家"] = dataRow["生产厂商"];
                    selectedProductIDs.Add(Convert.ToInt32(dataRow["产品ID"]));
                    dataSource.Rows.Add(newRow);
                    
                }
            }
            dataSource.AcceptChanges();
            popupGrid.DataSource = dataSource;
            var gridView = popupGrid.MainView as GridView;
            if (gridView != null)
            {
                for (int index = 0; index < gridView.Columns.Count; index++)
                {
                    gridView.Columns[index].Visible = !gridView.Columns[index].FieldName.EndsWith("ID");
                    gridView.Columns[index].OptionsColumn.AllowEdit = false;
                }

                gridView.OptionsView.RowAutoHeight = true;
                gridView.OptionsView.ShowGroupPanel = true;
                gridView.OptionsView.ShowGroupedColumns = true;
                gridView.Columns["产品类别"].GroupIndex = 0;
                gridView.ExpandAllGroups();
                gridView.BestFitColumns();
            }
        }

        private void SaveGrantedProducts(Guid userID, string userName)
        {
            DataTable grantedProducts = popupGrid.DataSource as DataTable;
            if (grantedProducts == null)
            {
                return;
            }
            DataRow[] rows = grantedProducts.Select("[授权ID] IS NULL OR [授权ID]='0'");

            if (rows.Length > 0)
            {
                StringBuilder insertSql = new StringBuilder(@"INSERT INTO [dbo].[ATC_UserProduct]
([UserID],[UserName],[ProductCategoryID],[ProductCategoryName],[ProductID],[ProductName],[IsBelong])
VALUES");
                foreach (var dataRow in rows)
                {
                    insertSql.AppendFormat("{0}('{1}','{2}',{3},'{4}',{5},'{6}',1),",
                        Environment.NewLine, userID, userName, Convert.ToInt32(dataRow["类别ID"]),
                        dataRow["产品类别"].ToString(), Convert.ToInt32(dataRow["产品ID"]), dataRow["产品名称"].ToString());
                }
                string sql = insertSql.ToString();
                if (sql.EndsWith(","))
                {
                    sql = sql.TrimEnd(',');
                }

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

        private void barBtnNewShould_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int pageSize = 10000;
            string formatQueryString = "[产品编号] LIKE '%{0}%' OR [产品名称] LIKE '%{0}%' OR [产品名称Spell] LIKE '%{0}%'";
            string viewName = "vw_AllUserProduct";
            string primaryField = "产品ID";
            string fields = "产品ID,产品编号,产品名称,产品名称Spell,生产厂商,规格型号,包装规格型号,包装比例,注册证号,贮藏条件,产品类别,单位,归属人";
            string filter = "([状态] IS NULL OR [状态] = '正常') AND ([归属人] != '未关联' AND [归属人] != '" + txtPopupEmployee.Text.Trim() + "' AND NOT EXISTS(SELECT * FROM ATC_UserProduct WHERE [产品ID]=ProductID AND UserName = '" + txtUserName.Text.Trim() + "'))";

            filter += string.Format("");
            /*
            if (ProductIDs.Any())
            {
                string productsFilter = string.Join(",", ProductIDs);
                filter += string.Format(" AND ([产品ID] NOT IN ({0}))", productsFilter);
            }
            else
            */
            {
                DataTable dataSource = GridDeputy.DataSource as DataTable;
                if (dataSource != null)
                {
                    EnumerableRowCollection<DataRow> enumerableRowCollection = dataSource.AsEnumerable();
                    if (enumerableRowCollection.Any())
                    {
                        ProductIDs = enumerableRowCollection.Select(p => Convert.ToInt32(p["产品ID"])).ToList();
                    }
                }
                /*
                if (ProductIDs.Any())
                {
                    string productsFilter = string.Join(",", ProductIDs);
                    filter += string.Format(" AND ([产品ID] NOT IN ({0}))", productsFilter);
                }
                */
            }
            using (FrmPopupQueryMultiple frmPopupQueryMultiple = new FrmPopupQueryMultiple(formatQueryString, viewName, primaryField, fields, filter, pageSize, "产品类别"))
            {
                DialogResult result = frmPopupQueryMultiple.ShowDialog();
                if (result == DialogResult.OK)
                {
                    var rows = frmPopupQueryMultiple.EditRows;
                    BindGridDeputy(rows);
                    SaveDeputyProducts(this.m_id.Value, txtUserName.Text.Trim());
                    BindGridDeputy();
                }
            }
        }
        private void BindGridDeputy()
        {
            string sql = string.Format(@"SELECT
    UserProductID AS [授权ID],
    ProductCategoryID AS [类别ID],
    ProductCategoryName AS [产品类别],
    up.ProductID AS [产品ID],
    p.ProductName AS [产品名称],
    p.PackageSpec AS [包装规格],
    p.ProducerName AS [生产厂家],
    (SELECT aup.UserName FROM dbo.ATC_UserProduct aup WHERE aup.ProductID = up.ProductID AND aup.IsBelong = 1) AS [归属人]
FROM
    dbo.ATC_UserProduct up
    INNER JOIN dbo.BFI_Product p
		ON up.ProductID = p.ProductID
WHERE UserID='{0}' AND IsBelong = 2
ORDER BY ProductCategoryID,up.ProductID", m_id.HasValue ? m_id.Value : Guid.Empty);

            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {

                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                da.Fill(ds);
                conn.Close();
                GridDeputy.DataSource = ds.Tables[0];
            }
            var gridView = GridDeputy.MainView as GridView;
            if (gridView != null)
            {
                for (int index = 0; index < gridView.Columns.Count; index++)
                {
                    gridView.Columns[index].Visible = !gridView.Columns[index].FieldName.EndsWith("ID");
                    gridView.Columns[index].OptionsColumn.AllowEdit = false;
                }

                gridView.OptionsView.RowAutoHeight = true;
                gridView.OptionsView.ShowGroupPanel = true;
                gridView.OptionsView.ShowGroupedColumns = true;
                gridView.Columns["产品类别"].GroupIndex = 0;
                gridView.ExpandAllGroups();
                gridView.BestFitColumns();
            }
        }
        private void BindGridDeputy(DataRow[] rows)
        {
            Dictionary<int, string> productStyles = new Dictionary<int, string>();
            string sql = "SELECT [ItemID],[ItemName] FROM [dbo].[SYS_Category] WHERE CategoryCode='ProductStyle' ORDER BY ItemID";

            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                da.Fill(ds);
                conn.Close();

                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    int itemID = Convert.ToInt32(row["ItemID"]);
                    if (!productStyles.ContainsKey(itemID))
                    {
                        productStyles.Add(itemID, row["ItemName"].ToString());
                    }
                }
            }

            DataTable dataSource = GridDeputy.DataSource as DataTable;
            if (dataSource == null)
            {
                BindGridDeputy();
            }
            dataSource = GridDeputy.DataSource as DataTable;
            EnumerableRowCollection<DataRow> enumerableRowCollection = dataSource.AsEnumerable();
            foreach (DataRow dataRow in rows)
            {
                if (null ==
                    enumerableRowCollection.FirstOrDefault(
                        p => Convert.ToInt32(p["产品ID"]) == Convert.ToInt32(dataRow["产品ID"])))
                {
                    var newRow = dataSource.NewRow();
                    newRow["类别ID"] = productStyles.SingleOrDefault(p => p.Value == dataRow["产品类别"].ToString()).Key;
                    newRow["产品类别"] = dataRow["产品类别"];
                    newRow["产品ID"] = dataRow["产品ID"];
                    newRow["产品名称"] = dataRow["产品名称"];
                    newRow["包装规格型号"] = dataRow["包装规格型号"];
                    newRow["生产厂家"] = dataRow["生产厂商"];
                    newRow["归属人"] = dataRow["归属人"];
                    ProductIDs.Add(Convert.ToInt32(dataRow["产品ID"]));
                    dataSource.Rows.Add(newRow);

                }
            }
            dataSource.AcceptChanges();
            GridDeputy.DataSource = dataSource;
            var gridView = GridDeputy.MainView as GridView;
            if (gridView != null)
            {
                for (int index = 0; index < gridView.Columns.Count; index++)
                {
                    gridView.Columns[index].Visible = !gridView.Columns[index].FieldName.EndsWith("ID");
                    gridView.Columns[index].OptionsColumn.AllowEdit = false;
                }

                gridView.OptionsView.RowAutoHeight = true;
                gridView.OptionsView.ShowGroupPanel = true;
                gridView.OptionsView.ShowGroupedColumns = true;
                gridView.Columns["产品类别"].GroupIndex = 0;
                gridView.ExpandAllGroups();
                gridView.BestFitColumns();
            }
        }
        private void SaveDeputyProducts(Guid userID, string userName)
        {

            DataTable grantedProducts = GridDeputy.DataSource as DataTable;
            if (grantedProducts == null)
            {
                return;
            }
            DataRow[] rows = grantedProducts.Select("[授权ID] IS NULL OR [授权ID]='0'");

            if (rows.Length > 0)
            {
                StringBuilder insertSql = new StringBuilder(@"INSERT INTO [dbo].[ATC_UserProduct]
([UserID],[UserName],[ProductCategoryID],[ProductCategoryName],[ProductID],[ProductName],[IsBelong])
VALUES");
                foreach (var dataRow in rows)
                {
                    insertSql.AppendFormat("{0}('{1}','{2}',{3},'{4}',{5},'{6}',2),",
                        Environment.NewLine, userID, userName, Convert.ToInt32(dataRow["类别ID"]),
                        dataRow["产品类别"].ToString(), Convert.ToInt32(dataRow["产品ID"]), dataRow["产品名称"].ToString());
                }
                string sql = insertSql.ToString();
                if (sql.EndsWith(","))
                {
                    sql = sql.TrimEnd(',');
                }

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

        private void barBtnDelDeputy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var gridView = this.GridDeputy.MainView as GridView;
            if (null != gridView)
            {
                List<int> deletedProductGrants = new List<int>();
                int[] selectedRows = gridView.GetSelectedRows();

                if (selectedRows.Length > 0)
                {
                    DialogResult result = XtraMessageBox.Show("确定要删除选中的产品授权吗？", "警告", MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Question);
                    if (result == DialogResult.OK)
                    {
                        foreach (var rowIndex in selectedRows)
                        {
                            DataRow selectedRow = gridView.GetDataRow(rowIndex);
                            deletedProductGrants.Add(Convert.ToInt32(selectedRow["产品ID"]));
                        }

                        string deleteSql = "DELETE.[dbo].[ATC_UserProduct] WHERE UserID='{0}' AND [ProductID] IN({1}) AND IsBelong = 2";
                        string sql = string.Format(deleteSql, m_id.Value, string.Join(",", deletedProductGrants));
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

                        BindGridDeputy();
                    }
                }
                else
                {
                    XtraMessageBox.Show("请选择要删除的可经营产品授权。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
        }
    }
}