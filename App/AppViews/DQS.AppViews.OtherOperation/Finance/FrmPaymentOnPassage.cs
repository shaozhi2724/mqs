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
    public partial class FrmPaymentOnPassage : XtraForm
    {
        public FrmPaymentOnPassage()
        {
            InitializeComponent();
        }

        //记录当前往来单位查询条件
        string DealerCode = "";
        //记录当前单据编号查询条件
        string BillCode = "";
        //记录上一次结存日期
        string stringDate = "";

        private void gridLoad()
        {
            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                string sql = @"
SELECT BusinessBillID AS [ID] ,
          BusinessBillCode AS [单据编号] ,
          DealerName AS [往来单位名称] ,
          TotalPrice AS [总金额] ,
          OperatePerson AS [开票员] ,
          BusinessPerson AS [业务员] ,
          BusinessBillDate AS [下单日期] ,
          StoreInPerson AS [入库员] ,
          StoreInDate AS [入库日期] ,
          DealerCode AS [往来单位编码] ,
          DealerSpell AS [往来单位简拼] ,
          DealerType AS [往来单位类型] ,
          OperateDate AS [操作时间] 
FROM dbo.FIN_PaymentOnPassage WHERE (DealerCode LIKE '%" + txtDealerCode.Text.Trim() + "%' OR DealerName LIKE '%" + txtDealerCode.Text.Trim() + "%' OR DealerSpell LIKE '%" + txtDealerCode.Text.Trim() + "%') AND (BusinessBillCode LIKE '%" + txtBillCode.Text.Trim() + "%') AND (BusinessPerson LIKE '%" + txtBusinessPerson.Text.Trim() + "%' OR dbo.fn_GetPy(BusinessPerson) LIKE '%" + txtBusinessPerson.Text.Trim() + "%')";
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

        private void btnChooseBill_Click(object sender, EventArgs e)
        {
            LastInventoryDate();
            using (FrmChooseBill fb = new FrmChooseBill())
            {
                fb.storeBill = "fn_PaymentOnPassage";
                fb.storeBillDetail = "fn_PaymentOnPassageDetail";
                fb.storeBillSave = "fn_InsertPaymentOnPassage";
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

        private void FrmPaymentOnPassage_Load(object sender, EventArgs e)
        {
            LastInventoryDate();
            gridLoad();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            DialogResult dr = XtraMessageBox.Show("确定删除单号为：" + gridView.GetDataRow(gridView.FocusedRowHandle)["单据编号"].ToString() + "的单据吗？", "系统提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
                {
                    string insertBill = @"DELETE FIN_PaymentOnPassage WHERE BusinessBillID = '{0}'

DELETE FIN_PaymentOnPassageDetail WHERE BusinessBillID = '{0}'
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
        private void txt_TextChanged(object sender, EventArgs e)
        {
            gridLoad();
        }

        private void gridView_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
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
    }
}
