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

namespace DQS.AppViews.StoreAndCuring.CuringManager
{
    public partial class FrmSingleCuringProducts : XtraForm
    {
        public FrmSingleCuringProducts()
        {
            InitializeComponent();
        }

        private void FrmSingleCuringProducts_Load(object sender, EventArgs e)
        {
            if (this.Tag != null)
            {
                GetFacilities();
            }
            else
            {
                txtCreateDate.Text = DateTime.Now.ToString();
                txtCuringPerson.Text = GlobalItem.g_CurrentUser.UserName;
            }
            LoadType("BUS_CuringTools", "ToolsType", txtToolsType);
            LoadType("BUS_CuringTools", "ToolsPut", txtToolsPut);
            LoadType("BUS_CuringTools", "ToolsPutWaith", txtToolsPutWaith);
            LoadType("BUS_CuringTools", "ToolsIsDown", txtToolsIsDown);
            LoadType("BUS_CuringTools", "ToolsPackage", txtToolsPackage);
            LoadType("BUS_CuringTools", "Facilities", txtFacilities);
            LoadType("BUS_CuringTools", "HouseTools", txtHouseTools);
            LoadType("BUS_CuringTools", "FireTools", txtFireTools);
            LoadType("BUS_CuringTools", "PowerTools", txtPowerTools);
            LoadType("BUS_CuringTools", "HealthTools", txtHealthTools);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (checkText())
            {
                if (this.Tag != null)
                {
                    saveTools((int)this.Tag);
                }
                else
                {
                    saveTools(0);
                }
                this.DialogResult = DialogResult.OK;
            }
        }

        private bool checkText()
        {
            bool isgo = true;
            foreach (Control item in layoutControl.Controls)
            {
                if (item.GetType().Name.Equals("ComboBoxEdit"))
                {
                    if ((item as ComboBoxEdit).Properties.NullValuePromptShowForEmptyValue)
                    {
                        if (item.Text.Trim() == "")
                        {
                            MessageBox.Show(item.Tag + "不能为空。");
                            isgo = false;
                        }
                    }
                }
                if (item.GetType().Name.Equals("TextEdit"))
                {
                    if ((item as TextEdit).Properties.NullValuePromptShowForEmptyValue)
                    {
                        if (item.Text.Trim() == "")
                        {
                            MessageBox.Show(item.Tag + "不能为空。");
                            isgo = false;
                        }
                    }
                }
            }
            return isgo;
        }

        private void saveTools(int id)
        {
            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                string sql = "EXEC sp_insertCuringTools {0},{1},'{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}','{15}','{16}','{17}','{18}'";
                sql = string.Format(sql, id, 2, txtCuringPerson.Text,
        txtToolsType.Text,
        txtToolsPut.Text,
        txtToolsPutWaith.Text,
        txtToolsIsDown.Text,
        txtToolsPackage.Text,
        txtFacilities.Text,
        txtHouseTools.Text,
        txtFireTools.Text,
        txtPowerTools.Text,
        txtHealthTools.Text,
        txtCheckSituation.Text,
        txtExpdescribe.Text,
        txtMeasure.Text,
        txtRemark.Text,
        txtCuringPerson.Text,
        DateTime.Parse(txtCreateDate.Text));
                SqlCommand com = new SqlCommand(sql, conn);
                try
                {
                    conn.Open();
                    int i = com.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("保存成功。");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void GetFacilities()
        {
            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                string sql = @"SELECT  ID ,
        CuringPerson ,
        ToolsType ,
        ToolsPut ,
        ToolsPutWaith ,
        ToolsIsDown ,
        ToolsPackage ,
        Facilities ,
        HouseTools ,
        FireTools ,
        PowerTools ,
        HealthTools ,
        CheckSituation ,
        Expdescribe ,
        Measure ,
        Remark ,
        CreateUser ,
        CreateDate FROM dbo.BUS_CuringTools WHERE ID = {0}";
                sql = string.Format(sql, (int)this.Tag);
                SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                try
                {
                    sda.Fill(ds, "Table");
                    int i = ds.Tables["Table"].Rows.Count;
                    if (i > 0)
                    {
                        txtCuringPerson.Text = ds.Tables["Table"].Rows[0]["CuringPerson"].ToString();
                        txtToolsType.Text = ds.Tables["Table"].Rows[0]["ToolsType"].ToString();
                        txtToolsPut.Text = ds.Tables["Table"].Rows[0]["ToolsPut"].ToString();
                        txtToolsPutWaith.Text = ds.Tables["Table"].Rows[0]["ToolsPutWaith"].ToString();
                        txtToolsIsDown.Text = ds.Tables["Table"].Rows[0]["ToolsIsDown"].ToString();
                        txtToolsPackage.Text = ds.Tables["Table"].Rows[0]["ToolsPackage"].ToString();
                        txtFacilities.Text = ds.Tables["Table"].Rows[0]["Facilities"].ToString();
                        txtHouseTools.Text = ds.Tables["Table"].Rows[0]["HouseTools"].ToString();
                        txtFireTools.Text = ds.Tables["Table"].Rows[0]["FireTools"].ToString();
                        txtPowerTools.Text = ds.Tables["Table"].Rows[0]["PowerTools"].ToString();
                        txtHealthTools.Text = ds.Tables["Table"].Rows[0]["HealthTools"].ToString();
                        txtCheckSituation.Text = ds.Tables["Table"].Rows[0]["CheckSituation"].ToString();
                        txtExpdescribe.Text = ds.Tables["Table"].Rows[0]["Expdescribe"].ToString();
                        txtMeasure.Text = ds.Tables["Table"].Rows[0]["Measure"].ToString();
                        txtCreateDate.Text = ds.Tables["Table"].Rows[0]["CreateDate"].ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void LoadType(string tableName, string tableColumn, ComboBoxEdit cbo)
        {
            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                string sql = "SELECT " + tableColumn + " FROM " + tableName + " GROUP BY " + tableColumn;
                SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                try
                {
                    sda.Fill(ds, "Table");
                    for (int i = 0; i < ds.Tables["Table"].Rows.Count; i++)
                    {
                        cbo.Properties.Items.Add(ds.Tables["Table"].Rows[i][tableColumn].ToString());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
    }
}
