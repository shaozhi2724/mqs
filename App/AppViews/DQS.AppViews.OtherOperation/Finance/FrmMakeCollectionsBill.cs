using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using DQS.Common;

namespace DQS.AppViews.OtherOperation.Finance
{
    public partial class FrmMakeCollectionsBill : XtraForm
    {
        public FrmMakeCollectionsBill()
        {
            InitializeComponent();
        }

        //自动生成发票编号
        string MakeCollectionsBillCode = "";
        //记录传进来的sql，来判断加载的sql是什么
        public string FrmSql = "";
        //记录传进来的sql，来判断加载的sql是什么
        public string FrmDetailSql = "";
        //记录单据ID
        public List<int> BillList = new List<int>();
        //记录单据明细ID
        public List<int> DetailList = new List<int>();
        //记录选中总金额
        public double TotalPrice = 0;
        //记录往来单位查询条件
        public string dealerCode = "";
        //记录单据编号查询条件
        public string billCode = "";
        //记录税率
        decimal tax = 1;
        //记录税率
        decimal taxadd = 1;
        //记录税率
        decimal taxabate = 1;
        //单位编号
        string saveDealerCode = "";
        //单位简拼
        string saveDealerSpell = "";

        private void LoadTax()
        {
            if (cboTax.Text.Trim() == "")
            {
                return;
            }
            tax = Convert.ToDecimal(cboTax.Text.Trim());
            taxadd = 1 + Convert.ToDecimal(cboTax.Text.Trim()) / 100;
            taxabate = Convert.ToDecimal(cboTax.Text.Trim()) / 100;
            txtNotIncludeTaxPrice.Text = (Convert.ToDecimal(txtIncludeTaxPrice.Text) / taxadd).ToString("f2");
            txtTaxPrice.Text = (Convert.ToDecimal(txtIncludeTaxPrice.Text) / taxadd * taxabate).ToString("f2");
        }

        private void btnOnPassage_Click(object sender, EventArgs e)
        {
            if (this.txtDealerName.Text == "")
            {
                XtraMessageBox.Show("请选择往来单位", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            using (FrmFinChooseBill fmb = new FrmFinChooseBill())
            {
                fmb.FrmSql = "fn_ShowMakeCollectionsBillOnPassage";
                fmb.FrmDetailSql = "fn_ShowMakeCollectionsBillDetailOnPassage";
                fmb.BillList = BillList;
                fmb.DetailList = DetailList;
                fmb.TotalPrice = TotalPrice;
                fmb.dealerCode = txtDealerName.Text.Trim();
                fmb.billCode = billCode;
                DialogResult dr = fmb.ShowDialog();
                if (dr == DialogResult.Yes)
                {
                    BillList = fmb.BillList;
                    DetailList = fmb.DetailList;
                    TotalPrice = fmb.TotalPrice;
                    lblTotalPrice.Text = TotalPrice.ToString();
                    txtIncludeTaxPrice.Text = TotalPrice.ToString();
                    dealerCode = fmb.dealerCode;
                    billCode = fmb.billCode;
                    LoadTax();
                    GainData();
                    valDealer();
                }
            }
        }

        //加载在途所有往来单位
        /*
        private void BindDealers()
        {
            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                string sql = "EXEC fn_MakeCollectionsOnPassageDealer";
                SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                try
                {
                    sda.Fill(ds, "Table");

                    cbxDealer.Properties.NullText = null;
                    cbxDealer.Properties.ValueMember = "简拼";
                    cbxDealer.Properties.DisplayMember = "名称";
                    cbxDealer.Properties.DataSource = ds.Tables["Table"];
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
        */

        /// <summary>
        /// 加载gCBill、gVBill，单据信息
        /// </summary>
        private void GainData()
        {
            string StoreID = "0";
            if (DetailList.Count > 0)
            {
                StoreID = "";
                for (int i = 0; i < DetailList.Count; i++)
                {
                    StoreID += DetailList[i].ToString() + ",";
                }
                StoreID = StoreID.Substring(0, StoreID.Length - 1);
            }
            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                string sql = @"SELECT  b.BillID AS StoreID,
		BillCode AS [单据编码],
		DealerCode AS [单位编码],
		DealerName AS [单位名称],
		b.Reservation6 AS [开票员],
		b.Operator AS [业务员],
		b.BillDate AS [下单日期],
		bd.DetailID,
		ProductName AS [产品名称],
		BatchNo AS [批号],
		CASE b.IsBillIn
		WHEN 0 THEN Amount
		ELSE -Amount
		END AS [数量],
		UnitPrice AS [单价],
		CASE b.IsBillIn
		WHEN 0 THEN bd.TotalPrice
		ELSE -bd.TotalPrice
		END AS [含税金额],
		CONVERT(DECIMAL(18,2), 
        CASE b.IsBillIn
		WHEN 0 THEN bd.TotalPrice
		ELSE -bd.TotalPrice
		END/{1}) AS [不含税金额],
		{0} AS [税率],
		CONVERT(DECIMAL(18,2), 
        CASE b.IsBillIn
		WHEN 0 THEN bd.TotalPrice
		ELSE -bd.TotalPrice
		END/{1}*{2}) AS [税额],
		ProducerName AS [生产厂商],
		ProductUnit AS [单位],
		PackageSpec AS [包装规格]
FROM dbo.BUS_Bill b
INNER JOIN dbo.BUS_BillDetail bd ON b.BillID = bd.BillID
INNER JOIN dbo.BFI_Product p ON bd.ProductID = p.ProductID
WHERE bd.DetailID IN (" + StoreID + ")";
                sql = String.Format(sql, tax, taxadd, taxabate);
                SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                try
                {
                    sda.Fill(ds, "Table");
                    //ds.Tables["Table"].Columns.Add("选择", System.Type.GetType("System.Boolean"));

                    gridControl.DataSource = ds.Tables["Table"];
                    gridView.OptionsView.ColumnAutoWidth = false;
                    gridView.BestFitColumns();
                    gridView.OptionsView.ShowGroupPanel = false;
                    for (int i = 0; i < gridView.Columns.Count; i++)
                    {
                        string ColumnName = gridView.Columns[i].ToString();
                        if (ColumnName.Contains("ID") || ColumnName.Contains("往来单位"))
                        {
                            gridView.Columns[i].Visible = false;
                        }
                        gridView.Columns[i].OptionsColumn.AllowEdit = false;
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
        private void valDealer()
        {
            if (gridView.RowCount > 0)
            {
                this.txtDealerName.Properties.ReadOnly = true;
            }
            else
            {
                this.txtDealerName.Properties.ReadOnly = false;
            }
        }

        private void FrmPaymentBill_Load(object sender, EventArgs e)
        {
            deBillDate.Text = DateTime.Today.ToString("d");
            LoadType();
            //BindDealers();
            LoadCode();
            GainData();
        }


        private void LoadType()
        {
            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                string sql = "SELECT TypeName FROM FIN_BillingType";
                string sqlt = "SELECT Tax FROM FIN_Tax";
                SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
                SqlDataAdapter sdad = new SqlDataAdapter(sqlt, conn);
                DataSet ds = new DataSet();
                try
                {
                    sda.Fill(ds, "Table");
                    for (int i = 0; i < ds.Tables["Table"].Rows.Count; i++)
                    {
                        cboBillingType.Properties.Items.Add(ds.Tables["Table"].Rows[i]["TypeName"].ToString());
                    }
                    sdad.Fill(ds, "Tax");
                    for (int i = 0; i < ds.Tables["Tax"].Rows.Count; i++)
                    {
                        cboTax.Properties.Items.Add(ds.Tables["Tax"].Rows[i]["Tax"].ToString());
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

        private void SaveType()
        {
            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                string sql = "SELECT TypeName FROM FIN_BillingType WHERE TypeName = '" + cboBillingType.Text.Trim() + "'";
                string insertSql = "INSERT FIN_BillingType VALUES ('" + cboBillingType.Text.Trim() + "')";
                SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                try
                {
                    sda.Fill(ds, "Table");
                    int i = ds.Tables["Table"].Rows.Count;
                    if (i == 0)
                    {
                        conn.Open();
                        SqlCommand comm = new SqlCommand(insertSql, conn);
                        comm.ExecuteNonQuery();
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

        private void SaveTax()
        {
            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                string sql = "SELECT Tax FROM FIN_Tax WHERE Tax = '" + cboTax.Text.Trim() + "'";
                string insertSql = "INSERT FIN_Tax VALUES ('" + cboTax.Text.Trim() + "')";
                SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                try
                {
                    sda.Fill(ds, "Table");
                    int i = ds.Tables["Table"].Rows.Count;
                    if (i == 0)
                    {
                        conn.Open();
                        SqlCommand comm = new SqlCommand(insertSql, conn);
                        comm.ExecuteNonQuery();
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

        /// <summary>
        /// 保存前验证
        /// </summary>
        private bool validatetxt()
        {
            if (cboBillingType.Text.Trim() == "")
            {
                XtraMessageBox.Show("请选择发票类型！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboBillingType.Focus();
                return false;
            }
            else if (txtVoucherCode.Text.Trim() == "")
            {
                XtraMessageBox.Show("请填写发票号！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtVoucherCode.Focus();
                return false;
            }
            else if (txtTaxCode.Text.Trim() == "")
            {
                XtraMessageBox.Show("请填写税号！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTaxCode.Focus();
                return false;
            }
            else if (deBillDate.Text.Trim() == "")
            {
                XtraMessageBox.Show("请选择发票日期！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                deBillDate.Focus();
                return false;
            }
            else if (gridView.RowCount < 1)
            {
                XtraMessageBox.Show("请选择付款单据！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveType();
            SaveTax();
            //保存前判断
            if (!validatetxt()) return;
            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                string insertBill = "EXEC fn_InsertMakeCollectionsBill '{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}'";
                string insertBillDetail = "EXEC fn_InsertMakeCollectionsBillDetail '{0}','{1}','{2}','{3}','{4}'";
                try
                {
                    conn.Open();
                    SqlCommand command;
                    insertBill = String.Format(insertBill, MakeCollectionsBillCode, txtTaxCode.Text, saveDealerCode, txtDealerName.Text.Trim(), saveDealerSpell, txtVoucherCode.Text, cboBillingType.Text.Trim(), deBillDate.Text.Trim(), Convert.ToDecimal(txtIncludeTaxPrice.Text), Convert.ToDecimal(txtNotIncludeTaxPrice.Text), cboTax.Text.Trim(), Convert.ToDecimal(txtTaxPrice.Text), "");
                    command = new SqlCommand(insertBill, conn);
                    command.ExecuteNonQuery();
                    foreach (int detailid in DetailList)
                    {
                        command = new SqlCommand(String.Format(insertBillDetail, MakeCollectionsBillCode, detailid, tax, taxadd, taxabate), conn);
                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.ToString(), "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                }
            }
            this.DialogResult = DialogResult.Yes;
        }

        private void gridView_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
        }
        private void LoadCode()
        {
            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                string str = DateTime.Now.ToString("yyyyMMdd");
                string strban = DateTime.Now.ToString("yyyyMM");
                string sql = "SELECT TOP 1 MakeCollectionsBillCode FROM dbo.FIN_MakeCollectionsBill WHERE MakeCollectionsBillCode LIKE 'KPDJ" + strban + "%' ORDER BY MakeCollectionsBillID DESC";
                try
                {
                    SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
                    DataSet ds = new DataSet();
                    sda.Fill(ds, "Table");
                    int i = ds.Tables["Table"].Rows.Count;
                    string No = "";
                    if (i == 0)
                    {
                        No = "0001";
                    }
                    else
                    {
                        int Num = Convert.ToInt32(ds.Tables["Table"].Rows[0][0].ToString().Substring(12, 4)) + 1;
                        if (Num < 10)
                        {
                            No = "000" + Num;
                        }
                        else if (Num >= 10 && Num < 100)
                        {
                            No = "00" + Num;
                        }
                        else if (Num >= 100 && Num < 1000)
                        {
                            No = "0" + Num;
                        }
                        else
                        {
                            No = Num.ToString();
                        }
                    }
                    MakeCollectionsBillCode = "KPDJ" + str + No;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void cboTax_TextChanged(object sender, EventArgs e)
        {
            LoadTax();
            GainData();
        }

        private void txtDealerName_Click(object sender, EventArgs e)
        {
            if (txtDealerName.Properties.ReadOnly)
            {
                return;
            }
            using (FrmDealer fd = new FrmDealer())
            {
                fd.table = "FIN_MakeCollectionsOnPassage";
                if (fd.ShowDialog() == DialogResult.Yes)
                {
                    saveDealerCode = fd.code;
                    txtDealerName.Text = fd.name;
                    saveDealerSpell = fd.spell;
                }
            }
        }
    }
}
