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

namespace DQS.AppViews.WarehouseOut.WarehouseOutManager
{
    public partial class FrmModifyReviewBackDetail : XtraForm
    {
        private int _detailID;
        private int _DownStructureID;
        private int _ProductID;
        private string _BatchNo;
        private int _PackagingProportion;
        public bool _isEmpty;
        public FrmModifyReviewBackDetail()
        {
            InitializeComponent();
        }
        public FrmModifyReviewBackDetail(int detailID)
        {
            InitializeComponent();
            _detailID = detailID;
        }

        private void FrmModifyReviewBackDetail_Load(object sender, EventArgs e)
        {
            BandInfo();
            BandStructureCode();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                string sql = "";
                
                if (_isEmpty)
                {
                    sql = @"
UPDATE dbo.BUS_ReviewBackDetail SET UpStructureID = {1},OperUserName = '{2}' WHERE DetialID = {0}

INSERT dbo.WMS_CargoSpaceStoreDetail(StructureID,ProductID,ProductBatchNumber,ProductionDate,ProductValidDate,ProductAmount,Manufacturer,DosageForm,PackagingSpecification)
SELECT {1},rbd.ProductID,rbd.BatchNo,rbd.ProduceDate,rbd.ValidateDate,rbd.Amount,p.ProducerName,p.PhysicType,p.PackagingProportion FROM dbo.BUS_ReviewBackDetail rbd
INNER JOIN dbo.BFI_Product p ON rbd.ProductID = p.ProductID
WHERE rbd.DetialID = {0}
";
                    sql = string.Format(sql, _detailID, int.Parse(txtUpStructureCode.Tag.ToString()), GlobalItem.g_CurrentUser.UserName);
                }
                else
                {
                    sql = @"
UPDATE dbo.BUS_ReviewBackDetail SET UpStructureID = {1},OperUserName = '{2}' WHERE DetialID = {0}
UPDATE dbo.WMS_CargoSpaceStoreDetail SET ProductAmount = ProductAmount+{3} WHERE StructureID = {1}
";
                    sql = string.Format(sql, _detailID, int.Parse(txtUpStructureCode.Tag.ToString()), GlobalItem.g_CurrentUser.UserName, int.Parse(txtAmount.Text));
                }
                try
                {
                    conn.Open();
                    SqlCommand comm = new SqlCommand(sql, conn);
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
            this.DialogResult = DialogResult.OK;
        }

        private void BandInfo()
        {
            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                string sql = @"SELECT  p.ProductID,p.ProductCode,p.ProductName,p.ProductSpec,p.ProducerName,p.PackagingProportion,BatchNo,Amount,DownStructureID,sd.StructureCode 
FROM dbo.BUS_ReviewBackDetail rbd
INNER JOIN dbo.BFI_Product p ON rbd.ProductID = p.ProductID
INNER JOIN dbo.BFI_StorageStructure sd ON rbd.DownStructureID = sd.StructureID
WHERE rbd.DetialID = {0}";
                sql = string.Format(sql, _detailID);
                SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                try
                {
                    sda.Fill(ds, "Table");
                    int i = ds.Tables["Table"].Rows.Count;
                    if (i > 0)
                    {
                        _ProductID = int.Parse(ds.Tables["Table"].Rows[0]["ProductID"].ToString());
                        txtProductCode.Text = ds.Tables["Table"].Rows[0]["ProductCode"].ToString();
                        txtProductName.Text = ds.Tables["Table"].Rows[0]["ProductName"].ToString();
                        txtProductSpec.Text = ds.Tables["Table"].Rows[0]["ProductSpec"].ToString();
                        txtProducerName.Text = ds.Tables["Table"].Rows[0]["ProducerName"].ToString();
                        _PackagingProportion = int.Parse(ds.Tables["Table"].Rows[0]["PackagingProportion"].ToString());
                        txtBatchNo.Text = ds.Tables["Table"].Rows[0]["BatchNo"].ToString();
                        _BatchNo = ds.Tables["Table"].Rows[0]["BatchNo"].ToString();
                        txtAmount.Text = ds.Tables["Table"].Rows[0]["Amount"].ToString();
                        txtDownStructure.Text = ds.Tables["Table"].Rows[0]["StructureCode"].ToString();
                        _DownStructureID = int.Parse(ds.Tables["Table"].Rows[0]["DownStructureID"].ToString());
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
        private void BandStructureCode()
        {
            //判断原货位是否还是这个产品同批号的货
            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                string sql = @"SELECT wc.StructureID,ss.StructureCode FROM dbo.WMS_CargoSpaceStoreDetail wc
INNER JOIN dbo.BFI_StorageStructure ss ON wc.StructureID = ss.StructureID
WHERE wc.StructureID = {0} AND ProductID = {1} AND ProductBatchNumber = '{2}'";
                sql = string.Format(sql, _DownStructureID, _ProductID, _BatchNo);
                SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                try
                {
                    sda.Fill(ds, "Table");
                    int i = ds.Tables["Table"].Rows.Count;
                    if (i > 0)
                    {
                        txtUpStructureCode.Tag = ds.Tables["Table"].Rows[0]["StructureID"].ToString();
                        txtUpStructureCode.Text = ds.Tables["Table"].Rows[0]["StructureCode"].ToString();
                        _isEmpty = false;
                    }
                    else
                    {
                        //找一个空货位，赋予建议货位
                        EmptyStructureCode();
                        _isEmpty = true;
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

        private void EmptyStructureCode()
        {
            string sql = "";
            if (int.Parse(txtAmount.Text)%_PackagingProportion > 0)
            {
                sql = @"SELECT TOP 1 ss.StructureID,ss.StructureCode FROM dbo.BFI_Product p
INNER JOIN dbo.BFI_Warehouse w ON p.StockCondition = w.WarehouseType
INNER JOIN dbo.BFI_StorageStructure ss ON w.WarehouseID = ss.WarehouseID
WHERE p.ProductID = {0} AND ss.StructureType = '货位' AND AreaType = '零货'
AND NOT EXISTS(SELECT 0 FROM dbo.WMS_CargoSpaceStoreDetail wc WHERE ss.StructureID = wc.StructureID)";
            }
            else
            {
                sql = @"SELECT TOP 1 ss.StructureID,ss.StructureCode FROM dbo.BFI_Product p
INNER JOIN dbo.BFI_Warehouse w ON p.StockCondition = w.WarehouseType
INNER JOIN dbo.BFI_StorageStructure ss ON w.WarehouseID = ss.WarehouseID
WHERE p.ProductID = {0} AND ss.StructureType = '货位' AND AreaType = '整货'
AND NOT EXISTS(SELECT 0 FROM dbo.WMS_CargoSpaceStoreDetail wc WHERE ss.StructureID = wc.StructureID)";
            }
            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                sql = string.Format(sql, _ProductID);
                SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                try
                {
                    sda.Fill(ds, "Table");
                    int i = ds.Tables["Table"].Rows.Count;
                    if (i > 0)
                    {
                        txtUpStructureCode.Tag = ds.Tables["Table"].Rows[0]["StructureID"].ToString();
                        txtUpStructureCode.Text = ds.Tables["Table"].Rows[0]["StructureCode"].ToString();
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
