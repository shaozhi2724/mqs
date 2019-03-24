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

namespace DQS.AppViews.Operation.PurchaseAndSaleManager
{
    public partial class FrmSelectStoreForProduct : XtraForm
    {
        int productID;
        int amount;
        int department;
        public List<OutSaleViewDetail> outlist = new List<OutSaleViewDetail>();
        public FrmSelectStoreForProduct()
        {
            InitializeComponent();
        }
        public FrmSelectStoreForProduct(int _productID, int _amount, int _department)
        {
            productID = _productID;
            amount = _amount;
            department = _department;
            InitializeComponent();
        }

        private void FrmSelectStoreForProduct_Load(object sender, EventArgs e)
        {
            labelAmount.Text = amount.ToString();
            GetList();
        }

        private void GetList()
        {
            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                string sqlBill = @"EXEC dbo.sp_SelectedStoreDetailDepartmentForOut " + productID + "," + department;

                SqlDataAdapter sdad = new SqlDataAdapter(sqlBill, conn);
                DataSet ds = new DataSet();
                try
                {
                    sdad.Fill(ds, "Table");
                    if (ds.Tables["Table"].Rows.Count > 0)
                    {
                        gridControl.DataSource = ds.Tables["Table"];
                    }
                    for (int i = 0; i < gridView.Columns.Count; i++)
                    {
                        string ColumnName = gridView.Columns[i].ToString();
                        if (ColumnName.Contains("ID"))
                        {
                            gridView.Columns[i].Visible = false;
                        }
                        if (ColumnName == "数量")
                        {
                            gridView.Columns[i].OptionsColumn.AllowEdit = true;
                        }
                        else
                        {
                            gridView.Columns[i].OptionsColumn.AllowEdit = false;
                        }
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
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            outlist.Clear();
            int camount = CheckAmount();
            if (camount > amount)
            {
                MessageBox.Show("选择的数量超过订单数量，请重新选择。");
                return;
            }
            if (camount < amount)
            {
                MessageBox.Show("选择的数量小于订单数量，请重新选择。");
                return;
            }
            for (int i = 0; i < gridView.RowCount; i++)
            {
                int jamount = Convert.ToInt32(gridView.GetDataRow(i)["数量"]);
                if (jamount > 0)
                {
                    OutSaleViewDetail outsale = new OutSaleViewDetail();
                    outsale.InStoreID = Convert.ToInt32(gridView.GetDataRow(i)["入库ID"]);
                    outsale.ProductID = productID;
                    outsale.ProductCode = gridView.GetDataRow(i)["产品编号"].ToString();
                    outsale.ProductName = gridView.GetDataRow(i)["产品名称"].ToString();
                    outsale.BatchNo = gridView.GetDataRow(i)["批号"].ToString();
                    outsale.StoreAmount = Convert.ToInt32(gridView.GetDataRow(i)["库存数量"]);
                    outsale.OutAmount = Convert.ToInt32(gridView.GetDataRow(i)["数量"]);
                    //outsale.UnitPrice = 0;
                    //outsale.TotalPrice = outsale.UnitPrice * Convert.ToInt32(gridView.GetDataRow(i)["数量"]);
                    outsale.ProduceDate = Convert.ToDateTime(gridView.GetDataRow(i)["生产日期"]);
                    outsale.ValidateDate = Convert.ToDateTime(gridView.GetDataRow(i)["有效期至"]);
                    outsale.TradePrice = Convert.ToDouble(gridView.GetDataRow(i)["批发价"]);
                    outsale.RetailPrice = Convert.ToDouble(gridView.GetDataRow(i)["标售价"]);
                    outsale.Reservation1 = gridView.GetDataRow(i)["销项税"].ToString();
                    outsale.isPrint = "否";
                    outlist.Add(outsale);
                }
            }
            this.DialogResult = DialogResult.Yes;
        }

        private int CheckAmount()
        {
            int camount = 0;
            for (int i = 0; i < gridView.RowCount; i++)
            {
                camount += Convert.ToInt32(gridView.GetDataRow(i)["数量"]);
            }
            return camount;
        }
    }
}
