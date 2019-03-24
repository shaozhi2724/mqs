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
    public partial class FrmAddOldSaleBill : XtraForm
    {
        public FrmAddOldSaleBill()
        {
            InitializeComponent();
        }

        private void txtDealerName_DoubleClick(object sender, EventArgs e)
        {
            string sql = @"
SELECT DealerID,DealerCode as Code,DealerName as Name,DealerSpell,
DealerAddress,BusinessPerson,BusinessPersonSpell,BusinessPhone
FROM dbo.BFI_Dealer WHERE DealerType = '客户'
";
            lblName.Text = "单位名称：";
            GridLoad(sql);
        }

        private void GridLoad(string sql)
        {
            gridControl.DataSource = null;
            gridView.Columns.Clear();
            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                try
                {
                    sda.Fill(ds, "Table");
                    gridControl.DataSource = ds.Tables["Table"];
                    gridView.OptionsView.ColumnAutoWidth = false;
                    gridView.BestFitColumns();
                    gridView.OptionsView.ShowGroupPanel = false;
                    //gridView.OptionsBehavior.Editable = false;
                    for (int i = 0; i < gridView.Columns.Count; i++)
                    {
                        string ColumnName = gridView.Columns[i].ToString();
                        if (ColumnName.Contains("Code") || ColumnName.Contains("Name") || ColumnName.Contains("Spec"))
                        {
                            gridView.Columns[i].Visible = true;
                        }
                        else
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

        private void gridView_DoubleClick(object sender, EventArgs e)
        {
            if (lblName.Text == "单位名称：")
            {
                txtDealerCode.Text = gridView.GetDataRow(gridView.FocusedRowHandle)["Code"].ToString();
                txtDealerCode.Tag = gridView.GetDataRow(gridView.FocusedRowHandle)["DealerID"].ToString();
                txtDealerName.Text = gridView.GetDataRow(gridView.FocusedRowHandle)["Name"].ToString();
                txtDealerName.Tag = gridView.GetDataRow(gridView.FocusedRowHandle)["DealerSpell"].ToString();
                txtDealerAddress.Text = gridView.GetDataRow(gridView.FocusedRowHandle)["DealerAddress"].ToString();
                txtBusinessPerson.Text = gridView.GetDataRow(gridView.FocusedRowHandle)["BusinessPerson"].ToString();
                txtBusinessPerson.Tag = gridView.GetDataRow(gridView.FocusedRowHandle)["BusinessPersonSpell"].ToString();
                txtBusinessPersonPhone.Text = gridView.GetDataRow(gridView.FocusedRowHandle)["BusinessPhone"].ToString();
            }
            if (lblName.Text == "药品名称：")
            {
                txtProductName.Text = gridView.GetDataRow(gridView.FocusedRowHandle)["Name"].ToString();
                txtProductName.Tag = gridView.GetDataRow(gridView.FocusedRowHandle)["ProductID"].ToString();
                txtPiFa.Text = gridView.GetDataRow(gridView.FocusedRowHandle)["TradePrice"].ToString();
                txtLiSh.Text = gridView.GetDataRow(gridView.FocusedRowHandle)["RetailPrice"].ToString();
            }
            if (lblName.Text == "创建人：")
            {
                txtCreateUser.Tag = gridView.GetDataRow(gridView.FocusedRowHandle)["UserID"].ToString();
                txtCreateUser.Text = gridView.GetDataRow(gridView.FocusedRowHandle)["UserName"].ToString();
            }
            lblName.Text = "名称：";
            gridControl.DataSource = null;
        }

        private void txtProductName_DoubleClick(object sender, EventArgs e)
        {
            string sql = @"
SELECT p.ProductID,p.ProductCode as Code,p.ProductName as Name,ProductSpec AS Spec,
ISNULL((SELECT Price FROM dbo.BFI_ProductPrice pp WHERE pp.ProductID = p.ProductID AND pp.PriceID = 2),0) AS TradePrice,
ISNULL((SELECT Price FROM dbo.BFI_ProductPrice pp WHERE pp.ProductID = p.ProductID AND pp.PriceID = 3),0) AS RetailPrice
FROM dbo.BFI_Product p
";
            lblName.Text = "药品名称：";
            GridLoad(sql);
        }

        private int GetSaleID()
        {
            int ID = 0;
            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                string sql = @"SELECT BillID FROM dbo.BUS_Bill WHERE BillCode = '" + txtSaleCode.Text + "'";
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    ID = (int)cmd.ExecuteScalar();
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
            return ID;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                string sql = @"INSERT dbo.BUS_Bill(BillCode,BillDate,IsBillIn,BillTypeID,BillTypeName,BillTypeSpell,BillStyle,BillStatus,
BillStatusName,DealerID,DealerCode,DealerName,DealerSpell,DealerAddress,BusinessPerson,BusinessPersonSpell,
BusinessPhone,DeliveryTypeID,DeliveryTypeName,TotalPrice,Operator,OperatorSpell,ProductAmount,CreateUserID,
CreateDate,LastModifyUserID,LastModifyDate)
VALUES (N'{0}','{1}',0,1,N'销售出货',N'xsch',N'正常',6,N'运输结束',{2},N'{3}',N'{4}',N'{5}',
N'{6}',N'{7}',N'{8}',N'{9}',1,N'送货',0,N'{10}',N'',1,
'{11}','{1}','{11}','{1}')";
                sql = string.Format(sql, txtSaleCode.Text, deSaleDate.Text, txtDealerCode.Tag, txtDealerCode.Text, txtDealerName.Text, txtDealerName.Tag, txtDealerAddress.Text, txtBusinessPerson.Text, txtBusinessPerson.Tag, txtBusinessPersonPhone.Text, txtOp.Text,txtCreateUser.Tag);
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
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
            XtraMessageBox.Show("单据保存成功。", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtSaleCode.Properties.ReadOnly = true;
        }

        private void txtCreateUser_DoubleClick(object sender, EventArgs e)
        {
            string sql = @"SELECT UserName,UserID FROM dbo.ATC_User";
            lblName.Text = "创建人：";
            GridLoad(sql);
        }

        private void btnSaveDetail_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                string sql = @"INSERT dbo.BUS_BillDetail(BillID,ProductID,BatchNo,ProduceDate,ValidateDate,Amount,
UnitPrice,TotalPrice,TradePrice,RetailPrice,StoreAmount,InUnitPrice)
VALUES ({0},{1},N'{2}','{3}','{4}',{5},{6},0,{7},{8},0,{9})


UPDATE bus_billdetail SET totalprice = amount*unitprice WHERE billid = {0}
UPDATE bus_bill SET totalprice = (SELECT SUM(totalprice) FROM bus_billdetail WHERE billid = {0}) WHERE billid = {0}
";
                sql = string.Format(sql, GetSaleID(), txtProductName.Tag, txtBatchNo.Text, deStartDate.Text, deEndDate.Text, txtAmount.Text, txtUnitPrice.Text, txtPiFa.Text, txtLiSh.Text, txtInUnitPrice.Text);
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
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
            XtraMessageBox.Show("单据明细保存成功。", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string sql="";
            string choose = txtChoose.Text;
            if (lblName.Text == "单位名称：")
            {
                sql = @"
SELECT DealerID,DealerCode as Code,DealerName as Name,DealerSpell,
DealerAddress,BusinessPerson,BusinessPersonSpell,BusinessPhone
FROM dbo.BFI_Dealer WHERE DealerType = '客户' and (dealername like '%" + choose + "%' or dealerspell like '%" + choose + "%' )";
            }
            if (lblName.Text == "药品名称：")
            {
                sql = @"
SELECT p.ProductID,p.ProductCode as Code,p.ProductName as Name,ProductSpec AS Spec,
ISNULL((SELECT Price FROM dbo.BFI_ProductPrice pp WHERE pp.ProductID = p.ProductID AND pp.PriceID = 2),0) AS TradePrice,
ISNULL((SELECT Price FROM dbo.BFI_ProductPrice pp WHERE pp.ProductID = p.ProductID AND pp.PriceID = 3),0) AS RetailPrice
FROM dbo.BFI_Product p where p.productname like '%" + choose + "%' or p.productspell like '%" + choose + "%'";
            }
            if (lblName.Text == "创建人：")
            {
                sql = @"SELECT UserName,UserID FROM dbo.ATC_User where username like '%" + choose + "%'";
            }
            GridLoad(sql);
        }

        private void btnOKReview_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                string sql = @"INSERT dbo.BUS_Review(ReviewCode,ReviewDate,StatusID,StatusName,SaleBillID,SaleBillCode,CreateDate)
SELECT REPLACE(billcode,'XS','FH'),billdate,1,'复核成功',billid,billcode,billdate FROM bus_bill WHERE billid = {0}

INSERT dbo.BUS_ReviewDetail(ReviewID,ProductID,BatchNo,ProduceDate,ValidateDate,Amount,ReviewAmount,CreateDate)
SELECT r.reviewid,bd.productid,bd.batchNo,bd.ProduceDate,bd.ValidateDate,bd.Amount,bd.Amount,r.reviewDate FROM bus_billdetail bd 
INNER JOIN bus_review r ON bd.billid = r.salebillid
WHERE billid = {0}
";
                sql = string.Format(sql, GetSaleID());
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
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
            XtraMessageBox.Show("复核单据、明细保存成功。", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtSaleCode.Properties.ReadOnly = false;
        }
    }
}
