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
    public partial class FrmPayables : XtraForm
    {
        public FrmPayables()
        {
            InitializeComponent();
        }

        //记录单据ID
        public List<int> BillList = new List<int>();
        //记录单据明细ID
        public List<int> DetailList = new List<int>();
        //记录选中总金额
        double TotalPrice = 0;
        //记录往来单位查询条件
        string dealerCode = "";
        //记录单据编号查询条件
        string billCode = "";

        private void FrmPayables_Load(object sender, EventArgs e)
        {
            dePayDate.Text = DateTime.Today.ToString("d");
            LoadCode();
            //BindDealers();
            GainData();
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            using (FrmFinChooseBill fmb = new FrmFinChooseBill())
            {
                fmb.FrmSql = "fn_ShowPaymentOnPassage";
                fmb.FrmDetailSql = "fn_ShowPaymentOnPassageDetail";
                fmb.BillList = BillList;
                fmb.DetailList = DetailList;
                fmb.TotalPrice = TotalPrice;
                fmb.dealerCode = dealerCode;
                fmb.billCode = billCode;
                DialogResult dr = fmb.ShowDialog();
                if (dr == DialogResult.Yes)
                {
                    BillList = fmb.BillList;
                    DetailList = fmb.DetailList;
                    TotalPrice = fmb.TotalPrice;
                    this.lblTotalPrice.Text = TotalPrice.ToString();
                    dealerCode = fmb.dealerCode;
                    billCode = fmb.billCode;
                    GainData();
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                string insertBill = @"EXEC fn_InsertPayables '{0}','{1}','{2}','{3}',0";
                try
                {
                    conn.Open();
                    foreach (int storeid in BillList)
                    {
                        SqlCommand command = new SqlCommand(String.Format(insertBill, storeid, txtPayablesCode.Text.Trim(), txtVoucherCode.Text.Trim(), dePayDate.Text.Trim()), conn);
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

        /// <summary>
        /// 加载gCBill、gVBill，单据信息
        /// </summary>
        private void GainData()
        {
            string StoreID = "0";
            if (BillList.Count > 0)
            {
                StoreID = "";
                for (int i = 0; i < BillList.Count; i++)
                {
                    StoreID += BillList[i].ToString() + ",";
                }
                StoreID = StoreID.Substring(0, StoreID.Length - 1);
            }
            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                string sql = @"SELECT 
	PaymentOnPassageID AS [OnPassageID],
	BusinessBillID AS [StoreID],
	BusinessBillCode AS [单据编码],
	DealerCode AS [往来单位编码],
	DealerName AS [往来单位名称],
	DealerSpell AS [往来单位简拼],
	DealerType AS [往来单位类型],
	OperatePerson AS [开票员],
	BusinessPerson AS [业务员],
	BusinessBillDate AS [下单日期],
	StoreInPerson AS [入库人],
	StoreInDate AS [入库日期],
	TotalPrice AS [总金额] 
FROM dbo.FIN_PaymentOnPassage onp WHERE NOT EXISTS(SELECT * FROM dbo.FIN_Payables nr WHERE onp.BusinessBillID = nr.BusinessBillID) AND onp.BusinessBillID IN (" + StoreID + ")";
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

        private void LoadCode()
        {
            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                string str = DateTime.Now.ToString("yyyyMMdd");
                string strban = DateTime.Now.ToString("yyyyMM");
                string sql = "SELECT TOP 1 PayablesCode FROM FIN_Payables WHERE PayablesCode LIKE 'YFDJ" + strban + "%' ORDER BY PayablesID DESC";
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
                    this.txtPayablesCode.Text = "YFDJ" + str + No;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void gridView_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
        }
    }
}
