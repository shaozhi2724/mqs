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

namespace DQS.AppViews.QualityDocument.DealerManager
{
    public partial class FrmSingleProductOfDealerChange : XtraForm
    {
        int _DealerID;
        int _ChangeID;
        bool _isSave;
        public FrmSingleProductOfDealerChange()
        {
            InitializeComponent();
        }

        public FrmSingleProductOfDealerChange(int ChangeID,int DealerID, bool isSave)
        {
            InitializeComponent();
            _ChangeID = ChangeID;
            _DealerID = DealerID;
            _isSave = isSave;
        }

        private void FrmSingleProductOfDealerChange_Load(object sender, EventArgs e)
        {
            BandAddGrid();
            BandDelGrid();
            btnSave.Enabled = _isSave;
            btnUnSave.Enabled = _isSave;
        }
        private void BandAddGrid()
        {
            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                string sql = @"
SELECT sm.ProductCode 产品编号,sm.ProductName 产品名称,sm.PackageSpec 包装规格 FROM dbo.BUS_DealerVSProductChangeDetail bacd
INNER JOIN dbo.BFI_Product sm ON bacd.ProductID = sm.ProductID
WHERE ChangeID = {0} AND bacd.DataType = 'NEW'
AND bacd.ProductID NOT IN (SELECT ProductID FROM dbo.BUS_DealerVSProductChangeDetail WHERE ChangeID = {0} AND DataType = 'OLD')";
                sql = string.Format(sql, _ChangeID);
                try
                {
                    SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
                    DataSet ds = new DataSet();
                    sda.Fill(ds, "Table");

                    gcAdd.DataSource = ds.Tables["Table"];
                    gvAdd.OptionsView.ColumnAutoWidth = false;
                    gvAdd.BestFitColumns();
                    gvAdd.OptionsView.ShowGroupPanel = false;
                    for (int i = 0; i < gvAdd.Columns.Count; i++)
                    {
                        string ColumnName = gvAdd.Columns[i].ToString();
                        if (ColumnName.Contains("ID"))
                        {
                            gvAdd.Columns[i].Visible = false;
                        }
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

        private void BandDelGrid()
        {
            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                string sql = @"
SELECT sm.ProductCode 产品编号,sm.ProductName 产品名称,sm.PackageSpec 包装规格 FROM dbo.BUS_DealerVSProductChangeDetail bacd
INNER JOIN dbo.BFI_Product sm ON bacd.ProductID = sm.ProductID
WHERE ChangeID = {0} AND bacd.DataType = 'OLD'
AND bacd.ProductID NOT IN (SELECT ProductID FROM dbo.BUS_DealerVSProductChangeDetail WHERE ChangeID = {0} AND DataType = 'NEW')";
                sql = string.Format(sql, _ChangeID);
                try
                {
                    SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
                    DataSet ds = new DataSet();
                    sda.Fill(ds, "Table");

                    gcDel.DataSource = ds.Tables["Table"];
                    gvDel.OptionsView.ColumnAutoWidth = false;
                    gvDel.BestFitColumns();
                    gvDel.OptionsView.ShowGroupPanel = false;
                    for (int i = 0; i < gvDel.Columns.Count; i++)
                    {
                        string ColumnName = gvDel.Columns[i].ToString();
                        if (ColumnName.Contains("ID"))
                        {
                            gvDel.Columns[i].Visible = false;
                        }
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

        private void btnUnSave_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                string sql = @"UPDATE dbo.BUS_DealerVSProductChange SET AppStatus = '不通过' WHERE ID = " + _ChangeID;
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
            this.DialogResult = DialogResult.Yes;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                string sql = @"UPDATE dbo.BUS_DealerVSProductChange SET AppStatus = '通过' WHERE ID = " + _ChangeID;
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                    //删除明细
                    string delsql = "DELETE dbo.BUS_DealerVSProduct WHERE DealerID = " + _DealerID;
                    cmd = new SqlCommand(delsql, conn);
                    cmd.ExecuteNonQuery();
                    //写入明细
                    string inssql = @"INSERT dbo.BUS_DealerVSProduct( DealerID ,ProductID ,Operate ,OperateDate)
SELECT dc.DealerID,dcd.ProductID,dc.CreateUserName,dc.CreateDate FROM dbo.BUS_DealerVSProductChange dc
INNER JOIN dbo.BUS_DealerVSProductChangeDetail dcd ON dc.ID = dcd.ChangeID
WHERE ChangeID = " + _ChangeID + " AND DataType = 'NEW'";
                    cmd = new SqlCommand(inssql, conn);
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
            this.DialogResult = DialogResult.Yes;
        }
    }
}
