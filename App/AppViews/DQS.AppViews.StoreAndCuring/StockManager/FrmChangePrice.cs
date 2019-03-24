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

namespace DQS.AppViews.StoreAndCuring.StockManager
{
    public partial class FrmChangePrice : XtraForm
    {
        int _instoreid;
        bool _isok;
        public FrmChangePrice()
        {
            InitializeComponent();
        }
        public FrmChangePrice(int instoreid, bool isok = false)
        {
            InitializeComponent();
            _instoreid = instoreid;
            _isok = isok;
        }

        private void FrmChangePrice_Load(object sender, EventArgs e)
        {
            //判断变价表有没有这个inStoreID
            if (checkInstoreid())
            {
                //保存按钮不能用，修改可以用，确认按钮可以
                btnSave.Enabled = false;
                btnXg.Enabled = true;
            }
            else
            {
                //加载查询出来的信息
                BindDealer();
                //保存可用，修改，确认不可用
                btnSave.Enabled = true;
                btnXg.Enabled = false;
            }
            if (_isok)
            {
                btnSave.Enabled = false;
                btnXg.Enabled = false;
                btnOK.Visible = true;
            }
            else
            {
                btnOK.Visible = false;
            }
            if (checkInstoreidIsOk())
            {
                btnSave.Enabled = false;
                btnXg.Enabled = false;
                btnOK.Enabled = false;
            }
            else
            {
                btnOK.Enabled = true;
            }
        }
        private bool checkInstoreidIsOk()
        {
            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                string sql = "SELECT CheckOk FROM dbo.BUS_StoreDetailForNewPrice WHERE InstoreID = " + _instoreid;
                SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                try
                {
                    sda.Fill(ds, "Table");
                    if (ds.Tables["Table"].Rows.Count > 0)
                    {
                        return ds.Tables["Table"].Rows[0]["CheckOk"].ToString() == "1" ? true : false;
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
            return false;
        }
        private bool checkInstoreid()
        {
            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                string sql = "SELECT InstoreID ,DealerName ,Amount ,OldUnitPrice ,UnitPrice ,TradePrice ,AdjustPrice ,AdjustTotalPrice FROM dbo.BUS_StoreDetailForNewPrice WHERE InstoreID = " + _instoreid;
                string searchsql = "SELECT UpDealerName,ISNULL(ViewPrice,InUnitPrice) InUnitPrice,ISNULL((SELECT pp.Price FROM dbo.BFI_ProductPrice pp WHERE pp.ProductID = isd.ProductID AND PriceID = 2),0) TradePrice FROM dbo.BUS_InStoreDetail isd WHERE InStoreID = " + _instoreid;
                SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
                SqlDataAdapter sdasearch = new SqlDataAdapter(searchsql, conn);
                DataSet ds = new DataSet();
                try
                {
                    sda.Fill(ds, "Table");
                    sdasearch.Fill(ds, "Tablesearch");
                    if (ds.Tables["Table"].Rows.Count == 0)
                    {
                        var inprice = ds.Tables["Tablesearch"].Rows[0]["InUnitPrice"];
                        var tradeprice = ds.Tables["Tablesearch"].Rows[0]["TradePrice"];
                        txtDealerName.Text = ds.Tables["Tablesearch"].Rows[0]["UpDealerName"].ToString();
                        txtOldUnitPrice.Text = inprice == null ? "0" : inprice.ToString();
                        txtTradePrice.Text = tradeprice == null ? "0" : tradeprice.ToString();
                        return false;
                    }
                    else
                    {
                        txtDealerName.Text = ds.Tables["Table"].Rows[0]["DealerName"].ToString();
                        txtAmount.Text = ds.Tables["Table"].Rows[0]["Amount"].ToString();
                        txtOldUnitPrice.Text = ds.Tables["Table"].Rows[0]["OldUnitPrice"].ToString();
                        txtNewUnitPrice.Text = ds.Tables["Table"].Rows[0]["UnitPrice"].ToString();
                        txtTradePrice.Text = ds.Tables["Table"].Rows[0]["TradePrice"].ToString();
                        txtAdjustPrice.Text = ds.Tables["Table"].Rows[0]["AdjustPrice"].ToString();
                        txtAdjustTotalPrice.Text = ds.Tables["Table"].Rows[0]["AdjustTotalPrice"].ToString();
                        return true;
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
            return true;
        }

        private void BindDealer()
        {
            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                string sql = "SELECT DealerName FROM dbo.BFI_Dealer WHERE DealerType = '供应商' AND (DealerStatus IS NULL OR DealerStatus != '禁用')";
                SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                try
                {
                    sda.Fill(ds, "Table");
                    for (int i = 0; i < ds.Tables["Table"].Rows.Count; i++)
                    {
                        txtDealerName.Properties.Items.Add(ds.Tables["Table"].Rows[i]["DealerName"].ToString());
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            execsp(1);
            this.DialogResult = DialogResult.Yes;
        }

        private void btnXg_Click(object sender, EventArgs e)
        {
            execsp(2);
            this.DialogResult = DialogResult.Yes;
        }

        private void execsp(int dz)
        {
            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                string sql = @"
EXEC dbo.sp_InsertChangePrice @DZ = {0},
    @InstoreID = {1},
    @DealerName = N'{2}',
    @Amount = {3},
    @OldUnitPrice = {4},
    @UnitPrice = {5},
    @TradePrice = {6},
    @AdjustPrice = {7},
    @AdjustTotalPrice = {8}";
                try
                {
                    conn.Open();
                    SqlCommand comm = new SqlCommand(string.Format(sql,
                        dz,
                        _instoreid,
                        txtDealerName.Text.Trim(),
                        txtAmount.Text.Trim(),
                        txtOldUnitPrice.Text.Trim(),
                        txtNewUnitPrice.Text.Trim(),
                        txtTradePrice.Text.Trim(),
                        txtAdjustPrice.Text.Trim(),
                        txtAdjustTotalPrice.Text.Trim()
                        ), conn);
                    comm.ExecuteNonQuery();
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

        private void txtKeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != (char)8 && e.KeyChar != (char)46)
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void txtChanged(object sender, EventArgs e)
        {
            int amount = int.Parse(txtAmount.Text.Trim());
            decimal oldunitprice = Convert.ToDecimal(txtOldUnitPrice.Text.Trim());
            decimal newunitprice = Convert.ToDecimal(txtNewUnitPrice.Text.Trim());
            txtAdjustPrice.Text = (newunitprice - oldunitprice).ToString();
            decimal price = Convert.ToDecimal(newunitprice - oldunitprice);
            decimal toprice = price * amount;
            txtAdjustTotalPrice.Text = toprice.ToString();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            execoksp();
            this.DialogResult = DialogResult.Yes;
        }

        private void execoksp()
        {
            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                string sql = @"EXEC dbo.sp_OKChangePrice @InstoreID = {0}";
                try
                {
                    conn.Open();
                    SqlCommand comm = new SqlCommand(string.Format(sql, _instoreid), conn);
                    comm.ExecuteNonQuery();
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
