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
    public partial class FrmPaymentForOnPassage : XtraForm
    {
        public FrmPaymentForOnPassage()
        {
            InitializeComponent();
        }

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
        //保存时记录单位
        DataTable dt = new DataTable();
        //单位编号
        string saveDealerCode = "";
        //单位简拼
        string saveDealerSpell = "";

        /// <summary>
        /// 点击选择应付单据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBill_Click(object sender, EventArgs e)
        {
            if (cboChoose.Text == "按单位付款")
            {
                if (this.txtDealerName.Text == "")
                {
                    XtraMessageBox.Show("请选择往来单位", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            using (FrmFinChooseBill fmb = new FrmFinChooseBill())
            {
                fmb.FrmSql = "fn_ShowPayables";
                fmb.FrmDetailSql = "fn_ShowPayablesDetail";
                fmb.BillList = BillList;
                fmb.DetailList = DetailList;
                fmb.TotalPrice = TotalPrice;
                fmb.dealerCode = txtDealerName.Text.Trim();
                if (cboChoose.Text == "按单位付款")
                    fmb.txtDealerCode.Properties.ReadOnly = true;
                fmb.billCode = billCode;
                DialogResult dr = fmb.ShowDialog();
                if (dr == DialogResult.Yes)
                {
                    BillList = fmb.BillList;
                    DetailList = fmb.DetailList;
                    TotalPrice = fmb.TotalPrice;
                    lblTotalPrice.Text = TotalPrice.ToString();
                    txtTotalPrice.Text = TotalPrice.ToString();
                    dealerCode = fmb.dealerCode;
                    billCode = fmb.billCode;
                    GainData();
                    valDealer();
                }
            }
        }
        /// <summary>
        /// 点击选择在途单据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOnPassage_Click(object sender, EventArgs e)
        {
            if (cboChoose.Text == "按单位付款")
            {
                if (this.txtDealerName.Text == "")
                {
                    XtraMessageBox.Show("请选择往来单位", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            using (FrmFinChooseBill fmb = new FrmFinChooseBill())
            {
                fmb.FrmSql = "fn_ShowPaymentOnPassage";
                fmb.FrmDetailSql = "fn_ShowPaymentOnPassageDetail";
                fmb.BillList = BillList;
                fmb.DetailList = DetailList;
                fmb.TotalPrice = TotalPrice;
                fmb.dealerCode = txtDealerName.Text.Trim();
                if (cboChoose.Text == "按单位付款")
                    fmb.txtDealerCode.Properties.ReadOnly = true;
                fmb.billCode = billCode;
                DialogResult dr = fmb.ShowDialog();
                if (dr == DialogResult.Yes)
                {
                    BillList = fmb.BillList;
                    DetailList = fmb.DetailList;
                    TotalPrice = fmb.TotalPrice;
                    lblTotalPrice.Text = TotalPrice.ToString();
                    txtTotalPrice.Text = TotalPrice.ToString();
                    dealerCode = fmb.dealerCode;
                    billCode = fmb.billCode;
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
	ra.PayablesCode AS [应付单据编号],
	ra.VoucherCode AS [凭证号],
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
	onp.ProductName AS [药品名称],
	onp.BatchNo AS [批号],
	onp.Amount AS [数量],
	onp.TotalPrice AS [金额],
	onp.PackageSpec AS [包装规格],
	onp.ProducerName AS [生产厂商],
	onp.ProductStyle AS [类别],
	onp.PhysicType AS [剂型]
FROM dbo.FIN_PaymentOnPassageDetail onp 
INNER JOIN dbo.FIN_PaymentOnPassage fm ON onp.BusinessBillID = fm.BusinessBillID
LEFT JOIN dbo.FIN_Payables ra ON onp.BusinessBillID = ra.BusinessBillID
WHERE NOT EXISTS(SELECT * FROM dbo.FIN_PaymentDetail nr WHERE onp.BusinessBillID = nr.BusinessBillID) AND onp.BusinessBillDetailID IN (" + StoreID + ")";
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
                        if (ColumnName.Contains("ID"))
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

        private void FrmPaymentForOnPassage_Load(object sender, EventArgs e)
        {
            dePaymentDate.Text = DateTime.Today.ToString("d");
            txtDealerName.Properties.ReadOnly = true;
            LoadCboChoose();
            LoadType();
            if (GlobalItem.g_CurrentEmployee != null)
            {
                this.txtPaymentPerson.Text = GlobalItem.g_CurrentEmployee.EmployeeName;
            }
            LoadCode();
            //BindDealers();
            GainData();
        }

        private void LoadCboChoose()
        {
            cboChoose.Properties.Items.Add("按单据付款");
            cboChoose.Properties.Items.Add("按单位付款");
        }

        private void LoadType()
        {
            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                string sql = "SELECT TypeName FROM FIN_MakeCollectionsPaymentType";
                SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                try
                {
                    sda.Fill(ds, "Table");
                    for (int i = 0; i < ds.Tables["Table"].Rows.Count; i++)
                    {
                        cboType.Properties.Items.Add(ds.Tables["Table"].Rows[i]["TypeName"].ToString());
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
                string sql = "SELECT TypeName FROM FIN_MakeCollectionsPaymentType WHERE TypeName = '" + cboType.Text.Trim() + "'";
                string insertSql = "INSERT FIN_MakeCollectionsPaymentType VALUES ('" + cboType.Text.Trim() + "')";
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

        private void LoadCode()
        {
            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                string str = DateTime.Now.ToString("yyyyMMdd");
                string strban = DateTime.Now.ToString("yyyyMM");
                string sql = "SELECT TOP 1 PaymentCode FROM FIN_Payment WHERE PaymentCode LIKE 'FKDJ" + strban + "%' ORDER BY PaymentID DESC";
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
                    this.txtPaymentCode.Text = "FKDJ" + str + No;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        /// <summary>
        /// 保存前验证
        /// </summary>
        private bool validatetxt()
        {
            if (txtTotalPrice.Text.Trim() == "")
            {
                XtraMessageBox.Show("请输入付款金额！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTotalPrice.Focus();
                return false;
            }
            else if (dePaymentDate.Text.Trim() == "")
            {
                XtraMessageBox.Show("请选择付款日期！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dePaymentDate.Focus();
                return false;
            }
            else if (gridView.RowCount < 1)
            {
                XtraMessageBox.Show("请选择付款单据！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (cboChoose.Text == "按单据付款")
            {
                if (Convert.ToDecimal(txtTotalPrice.Text) != Convert.ToDecimal(lblTotalPrice.Text))
                {
                    XtraMessageBox.Show("付款金额与所选单据金额不符，请查看！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
            }
            return true;
        }

        //保存时记录单位
        private DataTable SaveDealer()
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
            DataSet ds = new DataSet();
            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                string sql = "SELECT DealerCode,DealerName,DealerSpell,SUM(TotalPrice) AS [TotalPrice] FROM FIN_PaymentOnPassageDetail WHERE BusinessBillDetailID IN (" + StoreID + ") GROUP BY DealerCode,DealerName,DealerSpell";
                SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
                try
                {
                    sda.Fill(ds, "Table");
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

            return ds.Tables["Table"];
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            dt = SaveDealer();
            SaveType();
            if (!validatetxt()) return;
            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                string insertBill = "EXEC fn_InsertPayablesAuto '{0}'";
                string insertPayment = "EXEC fn_InsertPayment '{0}','{1}','{2}',{3},'{4}','{5}','{6}','{7}','{8}'";
                string insertPaymentDetail = "EXEC fn_InsertPaymentDetail {0},'{1}'";
                try
                {
                    conn.Open();
                    SqlCommand command;
                    foreach (int storeid in BillList)
                    {
                        command = new SqlCommand(String.Format(insertBill, storeid), conn);
                        command.ExecuteNonQuery();
                    }

                    if (cboChoose.Text == "按单据付款")
                    {
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            command = new SqlCommand(String.Format(insertPayment,
                                txtPaymentCode.Text.Trim(),
                                cboType.Text.Trim(),
                                txtVoucherCode.Text.Trim(),
                                Convert.ToDecimal(dt.Rows[i]["TotalPrice"]),
                                txtPaymentPerson.Text.Trim(),
                                Convert.ToDateTime(dePaymentDate.Text),
                                dt.Rows[i]["DealerCode"].ToString(),
                                dt.Rows[i]["DealerName"].ToString(),
                                dt.Rows[i]["DealerSpell"].ToString()), conn);
                            command.ExecuteNonQuery();
                        }
                    }
                    else
                    {
                        command = new SqlCommand(String.Format(insertPayment,
                            txtPaymentCode.Text.Trim(),
                            cboType.Text.Trim(),
                            txtVoucherCode.Text.Trim(),
                            Convert.ToDecimal(txtTotalPrice.Text),
                            txtPaymentPerson.Text.Trim(),
                            Convert.ToDateTime(dePaymentDate.Text),
                            saveDealerCode,
                            txtDealerName.Text.Trim(),
                            saveDealerSpell), conn);
                        command.ExecuteNonQuery();
                    }

                    foreach (int detailid in DetailList)
                    {
                        command = new SqlCommand(String.Format(insertPaymentDetail, detailid, txtPaymentCode.Text.Trim()), conn);
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

        private void cboChoose_TextChanged(object sender, EventArgs e)
        {
            lblTotalPrice.Text = "";
            txtTotalPrice.Text = "";
            BillList.Clear();
            DetailList.Clear();
            TotalPrice = 0;
            GainData();
            if (cboChoose.Text == "按单据付款")
            {
                txtDealerName.Text = "";
                txtDealerName.Properties.ReadOnly = true;
            }
            else if (cboChoose.Text == "按单位付款")
            {
                txtDealerName.Properties.ReadOnly = false;
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
