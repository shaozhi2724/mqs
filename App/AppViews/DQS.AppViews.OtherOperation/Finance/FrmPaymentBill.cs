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

namespace DQS.AppViews.OtherOperation.Finance
{
    public partial class FrmPaymentBill : XtraForm
    {
        public FrmPaymentBill()
        {
            InitializeComponent();
        }
        //自动生成发票编号
        string PaymentBillCode = "";
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
                fmb.FrmSql = "fn_ShowPaymentBillOnPassage";
                fmb.FrmDetailSql = "fn_ShowPaymentBillDetailOnPassage";
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
                string sql = "EXEC fn_PaymentOnPassageDealer";
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
                string sql = @"SELECT 
	onp.PaymentOnPassageID AS [OnPassageID],
	onp.BusinessBillID AS [StoreID],
	onp.BusinessBillCode AS [单据编码],
	onp.DealerCode AS [往来单位编码],
	onp.DealerName AS [往来单位名称],
	onp.DealerSpell AS [往来单位简拼],
	onp.DealerType AS [往来单位类型],
	fm.OperatePerson AS [开票员],
	fm.BusinessPerson AS [业务员],
	fm.BusinessBillDate AS [下单日期],
	fm.StoreInPerson AS [入库人],
	fm.StoreInDate AS [入库日期],
	onp.BusinessBillDetailID AS [DetailID],
	onp.ProductName AS [产品名称],
	onp.BatchNo AS [批号],
	onp.Amount AS [数量],
	onp.TotalPrice AS [金额],
	onp.PackageSpec AS [包装规格],
	onp.ProducerName AS [生产厂商],
	onp.ProductStyle AS [类别],
	onp.PhysicType AS [剂型],
	onp.AuthorizedNo AS [注册证号],
	onp.ProduceDate AS [生产日期],
	onp.ValidateDate AS [有效期],
	onp.PackageSpec AS [包装规格],
	onp.TotalPrice AS [含税金额],
	CONVERT(DECIMAL(18,2), onp.TotalPrice/{1}) AS [不含税金额],
	{0} AS [税率],
	CONVERT(DECIMAL(18,2), onp.TotalPrice/{1}*{2}) AS [税额]
FROM dbo.FIN_PaymentOnPassageDetail onp 
INNER JOIN dbo.FIN_PaymentOnPassage fm ON onp.BusinessBillID = fm.BusinessBillID
WHERE NOT EXISTS(SELECT * FROM dbo.FIN_PaymentBillDetail nr WHERE onp.BusinessBillDetailID = nr.BusinessBillDetailID) AND onp.BusinessBillDetailID IN (" + StoreID + ")";
                sql = String.Format(sql,tax,taxadd,taxabate);
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
                XtraMessageBox.Show("请填写税号！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtVoucherCode.Focus();
                return false;
            }
            else if (txtTaxCode.Text.Trim() == "")
            {
                XtraMessageBox.Show("请填写发票号！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                string insertBill = "EXEC fn_InsertPaymentBill '{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}'";
                string insertBillDetail = "EXEC fn_InsertPaymentBillDetail '{0}','{1}','{2}','{3}','{4}'";
                try
                {
                    conn.Open();
                    SqlCommand command;
                    insertBill = String.Format(insertBill, PaymentBillCode, txtTaxCode.Text, saveDealerCode, txtDealerName.Text, saveDealerSpell,txtVoucherCode.Text,cboBillingType.Text.Trim(),deBillDate.Text.Trim(),Convert.ToDecimal(txtIncludeTaxPrice.Text),Convert.ToDecimal(txtNotIncludeTaxPrice.Text),cboTax.Text.Trim(),Convert.ToDecimal(txtTaxPrice.Text),"");
                    command = new SqlCommand(insertBill, conn);
                    command.ExecuteNonQuery();
                    foreach (int detailid in DetailList)
                    {
                        command = new SqlCommand(String.Format(insertBillDetail,PaymentBillCode,detailid,tax,taxadd,taxabate), conn);
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
                string sql = "SELECT TOP 1 PaymentBillCode FROM dbo.FIN_PaymentBill WHERE PaymentBillCode LIKE 'SPDJ" + strban + "%' ORDER BY PaymentBillID DESC";
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
                    PaymentBillCode = "SPDJ" + str + No;
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
                fd.table = "FIN_PaymentOnPassage";
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
