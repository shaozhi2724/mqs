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

        //记录选择内容
        List<ViewMakeCollectionsOnPassage> views = new List<ViewMakeCollectionsOnPassage>();

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
                fmb.BillList.Clear();
                if (BillList.Any())
                {
                    foreach (var item in BillList)
                    {
                        fmb.BillList.Add(item);
                    }
                }
                fmb.DetailList.Clear();
                if (DetailList.Any())
                {
                    foreach (var item in DetailList)
                    {
                        fmb.DetailList.Add(item);
                    }
                }
                fmb.TotalPrice = TotalPrice;
                fmb.dealerCode = txtDealerName.Text.Trim();
                fmb.billCode = billCode;
                DialogResult dr = fmb.ShowDialog();
                if (dr == DialogResult.Yes)
                {
                    if (fmb.BillList.Any())
                    {
                        foreach (var item in fmb.BillList)
                        {
                            if (!BillList.Contains(item))
                            {
                                BillList.Add(item);
                            }
                        }
                    }
                    else
                    {
                        BillList.Clear();
                    }

                    if (fmb.DetailList.Any())
                    {
                        foreach (var item in fmb.DetailList)
                        {
                            if (!DetailList.Contains(item))
                            {
                                DetailList.Add(item);
                                GainDataList(item);
                            }
                        }

                        List<int> ComDetailList = new List<int>();
                        foreach (var item in DetailList)
                        {
                            ComDetailList.Add(item);
                        }
                        foreach (var item in ComDetailList)
                        {
                            if (!fmb.DetailList.Contains(item))
                            {
                                DetailList.Remove(item);
                                views.Remove(views.FirstOrDefault(p => p.DetailID == item));
                            }
                        }
                    }
                    else
                    {
                        DetailList.Clear();
                    }
                    TotalPrice = fmb.TotalPrice;
                    GetTotalPrice();
                    dealerCode = fmb.dealerCode;
                    billCode = fmb.billCode;
                    LoadTax();
                    GainData();
                    valDealer();
                }
            }
        }
        private void GetTotalPrice()
        {
            double total = 0;
            foreach (var item in views)
            {
                total += Convert.ToDouble(item.HTotalPrice);
            }
            lblTotalPrice.Text = total.ToString();
            txtIncludeTaxPrice.Text = total.ToString();
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
        private void GainDataList(int detailID)
        {

            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                string sql = @"EXEC sp_MakeCollectionsDetailForBill '{0}'";
                sql = String.Format(sql, " AND DetailID IN (" + detailID + ")");
                SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                try
                {
                    sda.Fill(ds, "Table");
                    //ds.Tables["Table"].Columns.Add("选择", System.Type.GetType("System.Boolean"));

                    ViewMakeCollectionsOnPassage vmconpassage = new ViewMakeCollectionsOnPassage();
                    vmconpassage.StoreID = int.Parse(ds.Tables["Table"].Rows[0]["StoreID"].ToString());
                    vmconpassage.BillCode = ds.Tables["Table"].Rows[0]["BillCode"].ToString();
                    vmconpassage.DealerCode = ds.Tables["Table"].Rows[0]["DealerCode"].ToString();
                    vmconpassage.DealerName = ds.Tables["Table"].Rows[0]["DealerName"].ToString();
                    vmconpassage.Operator = ds.Tables["Table"].Rows[0]["Operator"].ToString();
                    vmconpassage.BillDate = DateTime.Parse(ds.Tables["Table"].Rows[0]["BillDate"].ToString());
                    vmconpassage.DetailID = int.Parse(ds.Tables["Table"].Rows[0]["DetailID"].ToString());
                    vmconpassage.ProductName = ds.Tables["Table"].Rows[0]["ProductName"].ToString();
                    vmconpassage.BatchNo = ds.Tables["Table"].Rows[0]["BatchNo"].ToString();
                    vmconpassage.Amount = int.Parse(ds.Tables["Table"].Rows[0]["Amount"].ToString());
                    vmconpassage.UnitPrice = decimal.Parse(ds.Tables["Table"].Rows[0]["UnitPrice"].ToString());
                    vmconpassage.HTotalPrice = decimal.Parse(ds.Tables["Table"].Rows[0]["HTotalPrice"].ToString());
                    vmconpassage.Tax = tax;
                    vmconpassage.UTotalPrice = Fix(vmconpassage.HTotalPrice / taxadd);
                    vmconpassage.TaxPrice = Fix(vmconpassage.HTotalPrice / taxadd * taxabate);
                    vmconpassage.ProducerName = ds.Tables["Table"].Rows[0]["ProducerName"].ToString();
                    vmconpassage.ProductUnit = ds.Tables["Table"].Rows[0]["ProductUnit"].ToString();
                    vmconpassage.ProductSpec = ds.Tables["Table"].Rows[0]["ProductSpec"].ToString();
                    vmconpassage.PackageSpec = ds.Tables["Table"].Rows[0]["PackageSpec"].ToString();
                    vmconpassage.BillAmount = int.Parse(ds.Tables["Table"].Rows[0]["Amount"].ToString());
                    vmconpassage.GotAmount = 0;
                    views.Add(vmconpassage);

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
        /// 加载gCBill、gVBill，单据信息
        /// </summary>
        private void GainData()
        {

            gridControl.DataSource = views;
            gridControl.RefreshDataSource();

            for (int i = 0; i < gridView.Columns.Count; i++)
            {
                string ColumnName = gridView.Columns[i].ToString();
                if (ColumnName.Contains("ID") || ColumnName.Contains("往来单位"))
                {
                    gridView.Columns[i].Visible = false;
                }
                if (ColumnName.Contains("数量") || ColumnName.Contains("备注"))
                {
                    gridView.Columns[i].OptionsColumn.AllowEdit = true;
                }
                else
                {
                    gridView.Columns[i].OptionsColumn.AllowEdit = false;
                }
            }
            //gridView.RefreshData();
            //string StoreID = "0";
            //if (DetailList.Count > 0)
            //{
            //    StoreID = "";
            //    for (int i = 0; i < DetailList.Count; i++)
            //    {
            //        StoreID += DetailList[i].ToString() + ",";
            //    }
            //    StoreID = StoreID.Substring(0, StoreID.Length - 1);
            //}
            //using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            //{
            //    string sql = @"EXEC sp_MakeCollectionsDetailForBill '{0}','{1}','{2}','{3}'";
            //    sql = String.Format(sql, tax, taxadd, taxabate, " AND BusinessBillDetailID IN (" + StoreID + ")");
            //    SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
            //    DataSet ds = new DataSet();
            //    try
            //    {
            //        sda.Fill(ds, "Table");
            //        //ds.Tables["Table"].Columns.Add("选择", System.Type.GetType("System.Boolean"));

            //        for (int i = 0; i < ds.Tables["Table"].Rows.Count; i++)
            //        {
                        
            //        }

            //        gridControl.DataSource = ds.Tables["Table"];
            //        gridView.OptionsView.ColumnAutoWidth = false;
            //        gridView.BestFitColumns();
            //        gridView.OptionsView.ShowGroupPanel = false;
            //        for (int i = 0; i < gridView.Columns.Count; i++)
            //        {
            //            string ColumnName = gridView.Columns[i].ToString();
            //            if (ColumnName.Contains("ID") || ColumnName.Contains("往来单位"))
            //            {
            //                gridView.Columns[i].Visible = false;
            //            }
            //            if (!ColumnName.Contains("数量"))
            //            {
            //                gridView.Columns[i].OptionsColumn.AllowEdit = false;
            //            }
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(ex.ToString());
            //    }
            //    finally
            //    {
            //        conn.Close();
            //    }
            //}
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
            /*
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
            */
            if (cboTax.Text.Trim() == "")
            {
                XtraMessageBox.Show("填写税率！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboTax.Focus();
                return false;
            }
            if (deBillDate.Text.Trim() == "")
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
                string insertBillDetail = "EXEC fn_InsertMakeCollectionsBillDetail '{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}'";
                try
                {
                    conn.Open();
                    SqlCommand command;
                    insertBill = String.Format(insertBill, 
                        MakeCollectionsBillCode, 
                        txtTaxCode.Text, 
                        saveDealerCode, 
                        txtDealerName.Text.Trim(), 
                        saveDealerSpell, 
                        txtVoucherCode.Text, 
                        cboBillingType.Text.Trim(), 
                        deBillDate.Text.Trim(), 
                        Convert.ToDecimal(txtIncludeTaxPrice.Text), 
                        Convert.ToDecimal(txtNotIncludeTaxPrice.Text), 
                        cboTax.Text.Trim(), 
                        Convert.ToDecimal(txtTaxPrice.Text), 
                        "");
                    command = new SqlCommand(insertBill, conn);
                    command.ExecuteNonQuery();
                    foreach (var item in views)
                    {
                        command = new SqlCommand(String.Format(insertBillDetail, 
                            MakeCollectionsBillCode, 
                            item.DetailID,
                            item.Amount,
                            item.HTotalPrice,
                            item.Tax,
                            item.HTotalPrice,
                            item.UTotalPrice,
                            item.TaxPrice,
                            item.Remark,
                            item.GotAmount
                            ), conn);
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
            ChangeTax();
            GainData();
        }

        private void ChangeTax()
        {
            foreach (var item in views)
            {
                item.Tax = tax;
                item.UTotalPrice = Fix(item.HTotalPrice / taxadd);
                item.TaxPrice = Fix(item.HTotalPrice / taxadd * taxabate);
            }
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

        private void gridView_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.Caption == "数量")
            {
                int Amount = 0;
                try
                {
                    if (e.Value.ToString().Trim() != "")
                    {
                        Amount = Convert.ToInt32(e.Value);
                    }
                }
                catch
                {
                    XtraMessageBox.Show("数量输入格式错误.", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                object DetailID = this.gridView.GetFocusedRowCellValue("DetailID");

                if (DetailID != null && DetailID != DBNull.Value)
                {
                    var data = views.FirstOrDefault(p => p.DetailID == int.Parse(DetailID.ToString()));
                    data.Amount = Amount;
                    data.HTotalPrice = Amount * data.UnitPrice;
                    data.Tax = tax;
                    data.UTotalPrice = Fix(data.HTotalPrice / taxadd);
                    data.TaxPrice = Fix(data.HTotalPrice / taxadd * taxabate);
                    data.GotAmount = data.BillAmount - Amount;
                }
                gridView.RefreshRow(e.RowHandle);
                GetTotalPrice(); 
                LoadTax();
            }
        }
        public decimal Fix(decimal value)
        {
            var x = value;
            var i = 2;
            var t = decimal.Round(x, i);
            x = t;
            return x;
            /*
            var x = value;
            var i = 28;
            while (i >= 0)
            {
                var t = decimal.Round(x, i);
                if (t != x)
                {
                    return x;
                }
                x = t;
                i--;
            }
            return x;
            */
        }
    }
    public class ViewMakeCollectionsOnPassage
    {
        public int StoreID { get; set; }
        public string BillCode { get; set; }
        public string DealerCode { get; set; }
        public string DealerName { get; set; }
        public string CreateUser { get; set; }
        public string Operator { get; set; }
        public DateTime BillDate { get; set; }
        public int DetailID { get; set; }
        public string ProductName { get; set; }
        public string BatchNo { get; set; }
        public int Amount { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal HTotalPrice { get; set; }
        public decimal UTotalPrice { get; set; }
        public decimal Tax { get; set; }
        public decimal TaxPrice { get; set; }
        public string ProducerName { get; set; }
        public string ProductUnit { get; set; }
        public string ProductSpec { get; set; }
        public string PackageSpec { get; set; }
        public int BillAmount { get; set; }
        public int GotAmount { get; set; }
        public string Remark { get; set; }
    }
}
