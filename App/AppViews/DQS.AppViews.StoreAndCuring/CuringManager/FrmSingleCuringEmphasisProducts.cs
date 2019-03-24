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
using System.Data.SqlClient;
using DQS.Common;

namespace DQS.AppViews.StoreAndCuring.CuringManager
{
    public partial class FrmSingleCuringEmphasisProducts : XtraForm
    {
        public FrmSingleCuringEmphasisProducts()
        {
            InitializeComponent();
        }

        private void txtProductCode_Click(object sender, EventArgs e)
        {
            using (FrmSearchProducts frm = new FrmSearchProducts())
            {
                DialogResult dr = frm.ShowDialog();
                if (dr == DialogResult.Yes)
                {
                    GetProduct(frm._PID);
                }
            }
        }

        private void GetProduct(int p)
        {
            BFIProductEntity pro = new BFIProductEntity { ProductID = p };
            pro.Fetch();
            txtProductCode.Tag = p;
            txtProductCode.Text = pro.ProductCode;
            txtCommonName.Text = pro.CommonName;
            txtTradeName.Text = pro.TradeName;
            txtProductSpec.Text = pro.ProductSpec;
            txtPhysicType.Text = pro.PhysicType;
            txtAuthorizedNo.Text = pro.AuthorizedNo;
            txtProducerName.Text = pro.ProducerName;
            txtProductionPostalCode.Text = pro.ProductionPostalCode;
            txtProductUnit.Text = pro.ProductUnit;
            txtProductionOriginAddress.Text = pro.ProductionOriginAddress;
            txtValidateYears.Text = pro.ValidateYears;
            txtStockCondition.Text = pro.StockCondition;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (checkText())
            {
                using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
                {
                    string sql = "EXEC sp_UpdateProductCuring {0},'{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}'";
                    sql = string.Format(sql,txtProductCode.Tag,txtCuringCode.Text.Trim(),txtCodeDate.DateTime,txtApplication.Text.Trim(),txtCharacter.Text.Trim(),txtSmallPackage.Text.Trim(),txtMiddlePackage.Text.Trim(),txtBigPackage.Text.Trim(),txtQualityStandard.Text.Trim(),txtStockFilter.Text.Trim(),txtCheckCuring.Text.Trim());
                    
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
                this.DialogResult = DialogResult.OK;
            }
        }

        private bool checkText()
        {
            bool isgo = true;
            foreach (Control item in layoutControl.Controls)
            {
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
            foreach (Control item in layoutControl.Controls)
            {
                if (item.GetType().Name.Equals("DateEdit"))
                {
                    if ((item as DateEdit).Properties.NullValuePromptShowForEmptyValue)
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

        private void FrmSingleCuringEmphasisProducts_Load(object sender, EventArgs e)
        {
            object id = this.Tag;
            if (id != null)
            {
                this.groupControl1.Visible = true;
                this.Height = 650;
                LoadControls(this.Tag);
                LoadGrid(this.Tag);
            }
        }

        private void LoadGrid(object p)
        {
            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                string sql = @"EXEC sp_SearchCuringRecord {0}";
                sql = string.Format(sql, (int)this.Tag);
                SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                try
                {
                    sda.Fill(ds, "Table");
                    gridControl.DataSource = ds.Tables["Table"];
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

        private void LoadControls(object p)
        {
            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                string sql = @"SELECT CuringCode,CodeDate,ProductCode,CommonName,TradeName,ProductSpec,PhysicType,AuthorizedNo,ProducerName,ProductionPostalCode,Application,Character,ProductUnit,SmallPackage,MiddlePackage,BigPackage,QualityStandard,StockFilter,CheckCuring,ProductionOriginAddress,ValidateYears,StockCondition FROM bfi_product where productid = {0}";
                sql = string.Format(sql, (int)this.Tag);
                SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                try
                {
                    sda.Fill(ds, "Table");
                    int i = ds.Tables["Table"].Rows.Count;
                    if (i > 0)
                    {
                        txtProductCode.Tag = this.Tag;
                        txtCuringCode.Text = ds.Tables["Table"].Rows[0]["CuringCode"].ToString();
                        txtCodeDate.Text = ds.Tables["Table"].Rows[0]["CodeDate"].ToString();
                        txtProductCode.Text = ds.Tables["Table"].Rows[0]["ProductCode"].ToString();
                        txtCommonName.Text = ds.Tables["Table"].Rows[0]["CommonName"].ToString();
                        txtTradeName.Text = ds.Tables["Table"].Rows[0]["TradeName"].ToString();
                        txtProductSpec.Text = ds.Tables["Table"].Rows[0]["ProductSpec"].ToString();
                        txtPhysicType.Text = ds.Tables["Table"].Rows[0]["PhysicType"].ToString();
                        txtAuthorizedNo.Text = ds.Tables["Table"].Rows[0]["AuthorizedNo"].ToString();
                        txtProducerName.Text = ds.Tables["Table"].Rows[0]["ProducerName"].ToString();
                        txtProductionPostalCode.Text = ds.Tables["Table"].Rows[0]["ProductionPostalCode"].ToString();
                        txtApplication.Text = ds.Tables["Table"].Rows[0]["Application"].ToString();
                        txtCharacter.Text = ds.Tables["Table"].Rows[0]["Character"].ToString();
                        txtProductUnit.Text = ds.Tables["Table"].Rows[0]["ProductUnit"].ToString();
                        txtSmallPackage.Text = ds.Tables["Table"].Rows[0]["SmallPackage"].ToString();
                        txtMiddlePackage.Text = ds.Tables["Table"].Rows[0]["MiddlePackage"].ToString();
                        txtBigPackage.Text = ds.Tables["Table"].Rows[0]["BigPackage"].ToString();
                        txtQualityStandard.Text = ds.Tables["Table"].Rows[0]["QualityStandard"].ToString();
                        txtStockFilter.Text = ds.Tables["Table"].Rows[0]["StockFilter"].ToString();
                        txtCheckCuring.Text = ds.Tables["Table"].Rows[0]["CheckCuring"].ToString();
                        txtProductionOriginAddress.Text = ds.Tables["Table"].Rows[0]["ProductionOriginAddress"].ToString();
                        txtValidateYears.Text = ds.Tables["Table"].Rows[0]["ValidateYears"].ToString();
                        txtStockCondition.Text = ds.Tables["Table"].Rows[0]["StockCondition"].ToString();
                        //txtCuringPerson.Text = ds.Tables["Table"].Rows[0]["CuringPerson"].ToString();

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
