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
    public partial class FrmMakeCollectionsOnPassage : XtraForm
    {
        public FrmMakeCollectionsOnPassage()
        {
            InitializeComponent();
        }

        //记录当前往来单位查询条件
        string DealerCode = "";
        //记录当前单据编号查询条件
        string BillCode = "";
        //记录上一次结存日期
        string stringDate = "";
        //查询条件
        string sqlSearch = "";

        private void btnChooseBill_Click(object sender, EventArgs e)
        {
            LastInventoryDate();
            if (IsInventory())
            {
                XtraMessageBox.Show("请完成期初数据", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }
            using (FrmChooseBill fb = new FrmChooseBill())
            {
                fb.storeBill = "fn_MakeCollectionsOnPassage";
                fb.storeBillDetail = "fn_MakeCollectionsOnPassageDetail";
                fb.storeBillSave = "fn_InsertOnPassage";
                fb.stringDate = stringDate;
                fb.DealerCode = DealerCode;
                fb.BillCode = BillCode;
                DialogResult dr = fb.ShowDialog();
                if (dr == DialogResult.Yes)
                {
                    DealerCode = fb.DealerCode;
                    BillCode = fb.BillCode;
                    gridLoad();
                }
            }
        }

        private void FrmMakeCollectionsOnPassage_Load(object sender, EventArgs e)
        {
            //this.btnInventory.Visible = IsInventory();
            //deStartDate.Text = DateTime.Today.ToString("d");
            //deEndDate.Text = DateTime.Today.ToString("d");
            LastInventoryDate();
            gridLoad();
        }

        private void gridLoad()
        {
            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                string sql = @"
SELECT BusinessBillID AS [ID] ,
          BusinessBillCode AS [单据编号] ,
          DealerName AS [往来单位名称] ,
          TotalPrice AS [总金额] ,
          (SELECT SUM((UnitPrice-PurchaasePrice)*Amount) FROM dbo.FIN_MakeCollectionsOnPassageDetail mo WHERE mo.BusinessBillID = m.BusinessBillID) AS [利润],
          OperatePerson AS [开票员] ,
          BusinessPerson AS [业务员] ,
          BusinessBillDate AS [下单日期] ,
          DealerCode AS [往来单位编码] ,
          DealerSpell AS [往来单位简拼] ,
          DealerType AS [往来单位类型] ,
          StoreOutPerson AS [出库员] ,
          StoreOutDate AS [出库日期] ,
          OperateDate AS [操作时间] 
FROM FIN_MakeCollectionsOnPassage m WHERE (DealerCode LIKE '%" + txtDealerCode.Text.Trim() + "%' OR DealerName LIKE '%" + txtDealerCode.Text.Trim() + "%' OR DealerSpell LIKE '%" + txtDealerCode.Text.Trim() + "%') AND (BusinessBillCode LIKE '%" + txtBillCode.Text.Trim() + "%') AND (BusinessPerson LIKE '%" + txtBusinessPerson.Text.Trim() + "%' OR dbo.fn_GetPy(BusinessPerson) LIKE '%" + txtBusinessPerson.Text.Trim() + "%')" + sqlSearch;
                SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                try
                {
                    sda.Fill(ds, "Table");
                    decimal Price = 0;
                    for (int i = 0; i < ds.Tables["Table"].Rows.Count; i++)
                    {
                        Price += Convert.ToDecimal(ds.Tables["Table"].Rows[i]["总金额"]);
                    }
                    lblTotalPrice.Text = Price.ToString();

                    gridControl.DataSource = ds.Tables["Table"];
                    gridView.Columns["总金额"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
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

        private void gridView_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
        }

        private void txt_TextChanged(object sender, EventArgs e)
        {
            gridLoad();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            DialogResult dr = XtraMessageBox.Show("确定删除单号为：" + gridView.GetDataRow(gridView.FocusedRowHandle)["单据编号"].ToString()+"的单据吗？", "系统提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
                {
                    string insertBill = @"DELETE FIN_MakeCollectionsOnPassage WHERE BusinessBillID = '{0}'

DELETE FIN_MakeCollectionsOnPassageDetail WHERE BusinessBillID = '{0}'
";
                    try
                    {
                        conn.Open();
                        SqlCommand Bcommand = new SqlCommand(String.Format(insertBill, ((gridView.GetDataRow(gridView.FocusedRowHandle)["ID"].ToString()))), conn);
                        Bcommand.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show(ex.ToString(), "系统", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
            gridLoad();
        }

        private void btnReSet_Click(object sender, EventArgs e)
        {
            this.txtDealerCode.Text = "";
            this.txtBillCode.Text = "";
            gridLoad();
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            using (FrmFirstInventory fb = new FrmFirstInventory())
            {
                DialogResult dr = fb.ShowDialog();
                if (dr == DialogResult.Yes)
                {
                    this.btnInventory.Visible = false;
                }
            }
        }

        private bool IsInventory()
        {
            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                string sql = "SELECT TOP 1 ISNULL(InventoryRemark,'') FROM dbo.FIN_Inventory WHERE InventoryCode = 'QCDJ'";
                try
                {
                    SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
                    DataSet ds = new DataSet();
                    sda.Fill(ds, "Table");
                    int i = ds.Tables["Table"].Rows.Count;
                    if (i == 0)
                    {
                        return true;
                    }
                    else if (ds.Tables["Table"].Rows[0][0].ToString() == "完成期初")
                    {
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            return true;
        }

        private void LastInventoryDate()
        {
            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                string sql = "SELECT TOP 1 CONVERT(NVARCHAR(100),OperateDate,23) FROM dbo.FIN_Inventory ORDER BY InventoryID DESC";
                try
                {
                    SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
                    DataSet ds = new DataSet();
                    sda.Fill(ds, "Table");
                    if (ds.Tables["Table"].Rows.Count == 0)
                    {
                        return;
                    }
                    stringDate = ds.Tables["Table"].Rows[0][0].ToString();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();  

            saveFileDialog.Title = "导出Excel";  

            saveFileDialog.Filter = "Excel文件(*.xls)|*.xls";  

            DialogResult dialogResult = saveFileDialog.ShowDialog(this);  

            if (dialogResult == DialogResult.OK)  

            {  

                DevExpress.XtraPrinting.XlsExportOptions options = new DevExpress.XtraPrinting.XlsExportOptions();  

                //gridControl1.ExportToXls(saveFileDialog.FileName, options);  

                //gridControl.ExportToExcelOld(saveFileDialog.FileName);
                gridControl.ExportToXls(saveFileDialog.FileName);

                DevExpress.XtraEditors.XtraMessageBox.Show("保存成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);  

            }  
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            sqlSearch = " AND (BusinessBillDate BETWEEN '" + deStartDate.Text.Trim() + " 00:00:00' AND '" + deEndDate.Text.Trim() + " 23:59:59')";
            gridLoad();
        }
    }
}
