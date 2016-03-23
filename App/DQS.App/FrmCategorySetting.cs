using DevExpress.XtraEditors;
using DQS.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DQS.App
{
    public partial class FrmCategorySetting : XtraForm
    {
        public FrmCategorySetting()
        {
            InitializeComponent();
        }

        private void FrmCategorySetting_Load(object sender, EventArgs e)
        {
            xtcCategoryMain.SelectedTabPageIndex = 0;
            LoadCategory();
        }

        private void LoadCategory()
        {
            this.panelChange.Visible = true;
            this.btnSave.Enabled = false;
            this.btnCancel.Enabled = false;
            this.panelAdd.Visible = false;
            this.btnSaveNew.Enabled = false;
            this.btnCancelAdd.Enabled = false;
            string categorySql = "SELECT CategoryName FROM dbo.SYS_Category WHERE CategoryName NOT LIKE '%状态%' AND CategoryName != '订单类型' AND CategoryName != '往来单位类型' AND CategoryName NOT LIKE '%结构%' GROUP BY CategoryName";
            using (DataSet dataSet = new DataSet())
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(categorySql, GlobalItem.g_DbConnectStrings))
                {
                    adapter.Fill(dataSet);
                }

                this.cboType.Properties.NullText = "请选择……";
                cboType.Properties.Items.Clear();
                for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
                {
                    this.cboType.Properties.Items.Add(dataSet.Tables[0].Rows[i][0].ToString());
                }
            }
        }

        private void cboType_TextChanged(object sender, EventArgs e)
        {
            string categortSql = "SELECT CategoryName as [类型],ItemName as [类型值] FROM dbo.SYS_Category WHERE CategoryName = '" + this.cboType.SelectedItem.ToString() + "'";
            using (DataSet dataSet = new DataSet())
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(categortSql, GlobalItem.g_DbConnectStrings))
                {
                    adapter.Fill(dataSet);
                }
                this.gridCategory.DataSource = dataSet.Tables[0];
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                this.lblType.Text = this.cboType.SelectedItem.ToString();
                this.panelAdd.Visible = true;
                this.btnSaveNew.Enabled = true;
                this.btnCancelAdd.Enabled = true;
                this.panelChange.Visible = false;
            }
            catch (Exception)
            {
                XtraMessageBox.Show("请选择……", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                this.lblTypeUpdate.Text = this.cboType.SelectedItem.ToString();
                this.txtOld.Text = this.gridCategory.GridViewData.GetFocusedRowCellValue("类型值").ToString();
                this.panelChange.Visible = true;
                this.btnSave.Enabled = true;
                this.btnCancel.Enabled = true;
                this.panelAdd.Visible = false;
            }
            catch (Exception)
            {
                XtraMessageBox.Show("请选择……", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            DialogResult dr = XtraMessageBox.Show("确定要删除此行数据吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings);
                conn.Open();
                try
                {
                    string categoryName = this.gridCategory.GridViewData.GetFocusedRowCellValue("类型").ToString();
                    string itemName = this.gridCategory.GridViewData.GetFocusedRowCellValue("类型值").ToString();
                    string catesql = "DELETE dbo.SYS_Category WHERE CategoryName = '" + categoryName + "' AND ItemName = '" + itemName + "'";
                    SqlCommand com = new SqlCommand(catesql, conn);
                    int result = com.ExecuteNonQuery();
                    if (result == 1)
                    {
                        XtraMessageBox.Show("删除成功。", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        this.cboType_TextChanged(null, null);
                    }
                }
                catch (Exception)
                {
                    XtraMessageBox.Show("未能删除成功。", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.txtNew.Text.Trim() == "")
            {
                XtraMessageBox.Show("不能为空。", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            string sql = "select count(*) from SYS_Category where CategoryName = '" + this.lblTypeUpdate.Text + "' and ItemName='" + this.txtNew.Text.Trim() + "'";
            string categortSql = "UPDATE dbo.SYS_Category SET ItemName='" + this.txtNew.Text.Trim() + "' WHERE CategoryName = '" + this.lblTypeUpdate.Text + "' AND ItemName = '" + this.txtOld.Text.Trim() + "'";
            SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings);
            conn.Open();
            try
            {
                SqlCommand com = new SqlCommand(sql, conn);
                int result  = (int)com.ExecuteScalar();
                if (result > 0)
                {
                    XtraMessageBox.Show("该类型值已存在！请重新填写！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    SqlCommand com2 = new SqlCommand(categortSql, conn);
                    int num = com2.ExecuteNonQuery();
                    if (num >= 1)
                    {
                        XtraMessageBox.Show("修改成功！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        this.cboType_TextChanged(null, null);
                        this.panelChange.Visible = true;
                        this.btnSave.Enabled = false;
                        this.btnCancel.Enabled = false;
                    }
                }
            }
            catch (Exception)
            {
                XtraMessageBox.Show("错误！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                conn.Close();
            }

        }

        private void btnSaveNew_Click(object sender, EventArgs e)
        {
            if (this.txtAddNew.Text.Trim() == "")
            {
                XtraMessageBox.Show("不能为空。", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            string addSql = "INSERT dbo.SYS_Category ( CategoryCode,CategoryName,CategoryDescription,ItemID,ItemName,ItemSpell,ItemDescription,IsSystemItem,StatusSort,IsEffective)"
          + " VALUES  ( (SELECT CategoryCode FROM dbo.SYS_Category WHERE CategoryName = '" + this.lblType.Text + "' GROUP BY CategoryCode),"
          + " (SELECT CategoryName FROM dbo.SYS_Category WHERE CategoryName = '" + this.lblType.Text + "' GROUP BY CategoryName),"
          + " (SELECT CategoryDescription FROM dbo.SYS_Category WHERE CategoryName = '" + this.lblType.Text + "' GROUP BY CategoryDescription),"
          + " (SELECT TOP 1 ItemID+1 FROM dbo.SYS_Category WHERE CategoryName = '" + this.lblType.Text + "' ORDER BY ItemID DESC),"
          + " N'" + this.txtAddNew.Text.Trim() + "',N'',N'',1 ,(SELECT TOP 1 StatusSort+1 FROM dbo.SYS_Category WHERE CategoryName = '" + this.lblType.Text + "' ORDER BY StatusSort DESC),0)";
            
            string sql = "select count(*) from SYS_Category where CategoryName = '" + this.lblType.Text + "' and ItemName='" + this.txtAddNew.Text.Trim() + "'";
            
            SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings);
            conn.Open();
            try
            {
                SqlCommand com = new SqlCommand(sql, conn);
                int result = (int)com.ExecuteScalar();
                if (result > 0)
                {
                    XtraMessageBox.Show("该类型值已存在！请重新填写！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    SqlCommand com2 = new SqlCommand(addSql, conn);
                    int num = com2.ExecuteNonQuery();
                    if (num >= 1)
                    {
                        XtraMessageBox.Show("添加成功！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        this.cboType_TextChanged(null, null);
                        this.panelAdd.Visible = true;
                        this.btnSaveNew.Enabled = false;
                        this.btnCancelAdd.Enabled = false;
                    }
                }
            }
            catch (Exception)
            {
                XtraMessageBox.Show("错误！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                conn.Close();
            }
        }

        private void cboType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.btnSave.Enabled = false;
            this.btnCancel.Enabled = false;
        }

        private void btnCancelAdd_Click(object sender, EventArgs e)
        {
            this.btnCancelAdd.Enabled = false;
            this.btnSaveNew.Enabled = false;
        }


        /// <summary>
        /// 开单大类
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        int type = 0;//0--新建1--修改

        private void btnSaveStyle_Click(object sender, EventArgs e)
        {
            string sql = "";
            string message = "";
            if (type == 0)
            {
                sql = "INSERT TotalStyle(StyleName) VALUES('" + this.txtStyleName.Text + "')";
                message = "添加成功。";
            }
            if (type == 1)
            {
                sql = "UPDATE TotalStyle SET StyleName = '" + this.txtStyleName.Text + "' WHERE StyleName = '" + gridViewStyle.GetFocusedRowCellValue("类别名称").ToString() + "'";
                message = "更新成功。";
            }
            
            int num = GetCountBySQL(sql);
            if (num == 1)
            {
                XtraMessageBox.Show(message, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            LoadStyle();
        }

        private void btnCancelStye_Click(object sender, EventArgs e)
        {
            LoadStyle();
        }

        private void btnSaveProductStyle_Click(object sender, EventArgs e)
        {
            string sql = "INSERT ProductStyle(StyleID,ProductStyle) VALUES (" + gridViewStyle.GetFocusedRowCellValue("类别ID").ToString() + ",'" + cboProductStyle.Text + "')";
            if (cboProductStyle.Text == "请选择……")
            {
                XtraMessageBox.Show("请选择……", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int num = GetCountBySQL(sql);
            if (num == 1)
            {
                XtraMessageBox.Show("添加成功。", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            LoadView();
            LoadCboStyle();
        }

        private void btnDelProductStyle_Click(object sender, EventArgs e)
        {
            string sql = "DELETE ProductStyle WHERE ProductStyle = '" + gridViewProductStyle.GetFocusedRowCellValue("产品类别").ToString() + "'";
            int num = GetCountBySQL(sql);
            if (num == 1)
            {
                XtraMessageBox.Show("删除成功。", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            LoadStyle();
            LoadCboStyle();
        }

        private void btnAddStyle_Click(object sender, EventArgs e)
        {
            type = 0;
            panelAddStyle.Visible = true;
            panelProductStyle.Visible = false;
            panelControl1.Enabled = false;
        }

        private void btnReSetStyle_Click(object sender, EventArgs e)
        {
            type = 1;
            string StyleName = this.gridViewStyle.GetFocusedRowCellValue("类别名称").ToString();
            this.txtStyleName.Text = "";
            panelAddStyle.Visible = true;
            panelProductStyle.Visible = false;
            panelControl1.Enabled = false;
        }

        private void btnDelStyle_Click(object sender, EventArgs e)
        {
            string sql = "DELETE ProductStyle WHERE StyleID = " + gridViewStyle.GetFocusedRowCellValue("类别ID").ToString();
            string sqlstyle = "DELETE TotalStyle WHERE StyleID = " + gridViewStyle.GetFocusedRowCellValue("类别ID").ToString();
            DialogResult dr = XtraMessageBox.Show("删除类别，会自动把类别下所关联的产品类别全部情况，确定删除吗？", "系统提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (DialogResult.OK == dr)
            {
                GetCountBySQL(sql);
                int num = GetCountBySQL(sqlstyle);
                if (num == 1)
                {
                    XtraMessageBox.Show("删除成功。", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            LoadStyle();
            LoadCboStyle();
        }

        private void LoadStyle()
        {
            panelControl1.Enabled = true;
            panelAddStyle.Visible = false;
            panelProductStyle.Visible = true;
            string sql = "SELECT StyleID AS [类别ID],StyleName AS [类别名称],StyleRemark AS [备注] FROM TotalStyle";
            this.gridControlStyle.DataSource = GetDataBySQL(sql);
            lblStyle.Text = gridViewStyle.GetFocusedRowCellValue("类别名称").ToString();
            //加载类别
            LoadView();
            //加载cboProductStyle
            LoadCboStyle();

            gridViewStyle.OptionsBehavior.Editable = false;
            gridViewStyle.OptionsView.ShowGroupPanel = false;
            gridViewProductStyle.OptionsBehavior.Editable = false;
            gridViewProductStyle.OptionsView.ShowGroupPanel = false;
        }

        private void LoadCboStyle()
        {
            this.cboProductStyle.Properties.Items.Clear();
            this.cboProductStyle.Properties.NullText = "请选择……";
            string stylesql = "SELECT ItemName FROM dbo.SYS_Category WHERE CategoryCode = 'ProductStyle' AND ItemName NOT IN (SELECT ProductStyle FROM ProductStyle)";
            using (DataSet dataSet = new DataSet())
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(stylesql, GlobalItem.g_DbConnectStrings))
                {
                    adapter.Fill(dataSet);
                }
                if (dataSet.Tables[0].Rows.Count == 0)
                {
                    this.cboProductStyle.Properties.NullText = "请选择……";
                }
                for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
                {
                    this.cboProductStyle.Properties.Items.Add(dataSet.Tables[0].Rows[i][0].ToString());
                }
            }
        }

        private void LoadView()
        {
            string productstyle = "SELECT ProductStyle AS [产品类别] FROM ProductStyle WHERE StyleID = " + gridViewStyle.GetFocusedRowCellValue("类别ID").ToString();
            DataTable dt = GetDataBySQL(productstyle);
            if (dt.Rows.Count <= 0)
            {
                this.gridControlProductStyle.DataSource = null;
            }
            else
            {
                this.gridControlProductStyle.DataSource = dt;
            }
        }


        /// <summary>
        /// 执行sql查询语句，并将结果以DataTable的形式返回
        /// </summary>
        /// <param name="sql">sql查询语句</param>
        /// <param name="conString">连接字符串</param>
        /// <returns>sql查询语句结果</returns>
        public static DataTable GetDataBySQL(string sql)
        {
            SqlConnection cn = new SqlConnection(GlobalItem.g_DbConnectStrings);
            if (cn.State != ConnectionState.Open)
                cn.Open();
            SqlCommand cmd = new SqlCommand(sql, cn);
            SqlDataAdapter sdap = new SqlDataAdapter();
            sdap.SelectCommand = cmd;
            DataTable dt = new DataTable();
            sdap.Fill(dt);
            cn.Close();
            return dt;
        }
        public int GetCountBySQL(string sql)
        {
            SqlConnection cn = new SqlConnection(GlobalItem.g_DbConnectStrings);
            if (cn.State != ConnectionState.Open)
                cn.Open();
            SqlCommand cmd = new SqlCommand(sql, cn);
            int count = cmd.ExecuteNonQuery();
            cn.Close();
            return count;
        }

        private void xtcCategoryMain_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            if (this.xtcCategoryMain.SelectedTabPageIndex == 0)
            {
                LoadCategory();
            }
            if (this.xtcCategoryMain.SelectedTabPageIndex == 1)
            {
                LoadStyle();
            }
        }

        private void gridViewStyle_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            lblStyle.Text = gridViewStyle.GetFocusedRowCellValue("类别名称").ToString();
            //加载类别
            LoadView();
            //加载cboProductStyle
            LoadCboStyle();
        }
    }
}
