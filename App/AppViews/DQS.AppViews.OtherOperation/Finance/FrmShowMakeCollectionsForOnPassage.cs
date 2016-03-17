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
    public partial class FrmShowMakeCollectionsForOnPassage : XtraForm
    {
        public FrmShowMakeCollectionsForOnPassage()
        {
            InitializeComponent();
        }
        //查询条件
        string sqlSearch = "";

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (FrmMakeCollectionsForOnPassage mc = new FrmMakeCollectionsForOnPassage())
            {
                DialogResult dr = mc.ShowDialog();
                if (dr == DialogResult.Yes)
                {
                    gridLoad();
                }
            }
        }

        private void gridView_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
        }

        private void FrmShowMakeCollectionsForOnPassage_Load(object sender, EventArgs e)
        {
            deStartDate.Text = DateTime.Today.ToString("d");
            deEndDate.Text = DateTime.Today.ToString("d");
            //gridLoad();
        }

        private void gridLoad()
        {
            sqlSearch = " AND (m.OperateDate BETWEEN '" + deStartDate.Text.Trim() + " 00:00:00' AND '" + deEndDate.Text.Trim() + " 23:59:59')";
            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                string sqlBill = @"SELECT DISTINCT m.MakeCollectionsID,m.MakeCollectionsCode AS [收款单号],m.VoucherCode AS [凭证号],m.MakeCollectionsPerson AS [收款人],m.OperateDate AS [收款日期],m.DealerName AS [往来单位名称],m.MakeCollectionsType AS [收款方式],TotalPrice AS [总金额],m.DealerCode AS [往来单位编号],m.DealerSpell AS [往来单位简拼]
FROM dbo.FIN_MakeCollections m WHERE m.MakeCollectionsCode LIKE 'ZTSK%' AND (m.DealerCode LIKE '%{0}%' OR m.DealerName LIKE '%{0}%' OR m.DealerSpell LIKE '%{0}%') AND (m.MakeCollectionsCode LIKE '%{1}%') AND (m.VoucherCode LIKE '%{2}%')" + sqlSearch;
                sqlBill = String.Format(sqlBill, txtDealerCode.Text.Trim(), txtMakeCollectionsCode.Text.Trim(), txtVoucherCode.Text.Trim());
                SqlDataAdapter sdad = new SqlDataAdapter(sqlBill, conn);
                DataSet ds = new DataSet();
                try
                {
                    sdad.Fill(ds, "TableBill");
                    //decimal Price = 0;
                    //for (int i = 0; i < ds.Tables["TableBill"].Rows.Count; i++)
                    //{
                    //    Price += Convert.ToDecimal(ds.Tables["TableBill"].Rows[i]["总金额"]);
                    //}
                    //lblTotalPrice.Text = Price.ToString();
                    gridControl.DataSource = ds.Tables["TableBill"];
                    gridView.OptionsView.ColumnAutoWidth = false;
                    gridView.OptionsView.ColumnAutoWidth = false;
                    gridView.BestFitColumns();
                    gridView.OptionsView.ShowGroupPanel = false;

                    gridView.Columns["总金额"].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
                    gridView.Columns["总金额"].SummaryItem.DisplayFormat = "合计: {0}";

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
        private void txtChanged(object sender, EventArgs e)
        {
            //gridLoad();
        }

        
        private void btnSearch_Click(object sender, EventArgs e)
        {
            gridLoad();
        }
        

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (gridView.RowCount < 1)
            {
                XtraMessageBox.Show("无单据可删除。", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult dr = XtraMessageBox.Show("1.删除该组数据，点击“是(Yes)”按钮（同一个收款编号或凭证号中的数据）\n2.删除该单位收款信息，点击“否(No)”按钮\n3.取消请点击“取消(Cancel)”按钮", "系统提示", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (dr == DialogResult.Cancel) return;

            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                string Delsql = @"
DELETE dbo.FIN_Receivables FROM dbo.FIN_Receivables nr
WHERE EXISTS(SELECT * FROM FIN_MakeCollectionsDetail WHERE {0} AND BusinessBillCode = nr.BusinessBillCode AND nr.IsAutoCreate = 1)
DELETE dbo.FIN_ReceivablesDetail FROM dbo.FIN_ReceivablesDetail nr
WHERE EXISTS(SELECT * FROM FIN_MakeCollectionsDetail WHERE {0} AND BusinessBillCode = nr.BusinessBillCode AND nr.IsAutoCreate = 1)
DELETE dbo.FIN_MakeCollections WHERE {0}
DELETE dbo.FIN_MakeCollectionsDetail WHERE {0}";
                if (dr == DialogResult.Yes)
                {
                    string code = gridView.GetDataRow(gridView.FocusedRowHandle)["收款单号"].ToString();
                    Delsql = String.Format(Delsql, "MakeCollectionsCode = '" + code + "'");
                }
                else if (dr == DialogResult.No)
                {
                    string code = gridView.GetDataRow(gridView.FocusedRowHandle)["收款单号"].ToString();
                    string dealercode = gridView.GetDataRow(gridView.FocusedRowHandle)["往来单位编号"].ToString();
                    Delsql = String.Format(Delsql, "MakeCollectionsCode = '" + code + "' AND DealerCode = '" + dealercode + "'");
                }

                try
                {
                    conn.Open();
                    SqlCommand Bcommand = new SqlCommand(Delsql, conn);
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
            gridLoad();
        }

        private void btnReSet_Click(object sender, EventArgs e)
        {
            txtDealerCode.Text = "";
            txtMakeCollectionsCode.Text = "";
            txtVoucherCode.Text = "";
            gridLoad();
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

        private void gridView_DoubleClick(object sender, EventArgs e)
        {
            if (gridView.RowCount == 0)
            {
                return;
            }
            DialogResult drcode = XtraMessageBox.Show("是否按照收款单号查询", "系统提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            string sql = "SELECT MakeCollectionsCode AS [收款单据],VoucherCode AS [凭证号],BusinessBillCode AS [单据编号],DealerCode AS [往来单位编码],DealerName AS [往来单位名称],DealerSpell AS [往来单位简拼],OperatePerson AS [操作员],BusinessPerson AS [业务员],DepartmentName AS [部门],CONVERT(NVARCHAR(60),BusinessBillDate,23) AS [下单日期],CONVERT(NVARCHAR(60),StoreOutDate,23) AS [出库日期],ProductName AS [产品名称],BatchNo AS [批号],Amount AS [数量],UnitPrice AS [单价],TotalPrice AS [金额],PurchaasePrice AS [进价],ProductStyle AS [类别],PhysicType AS [剂型],ProducerName AS [生产厂家],AuthorizedNo AS [注册证号],ProduceDate AS [生产日期],ValidateDate AS [有效期],ProductSpec AS [规格],PackageSpec AS [包装规格],ProductUnit AS [单位] FROM dbo.FIN_MakeCollectionsDetail WHERE (BusinessPerson LIKE '%{0}%' OR dbo.fn_GetPy(BusinessPerson) LIKE '%{0}%') AND (DealerCode LIKE '%{1}%' OR DealerName LIKE '%{1}%' OR DealerSpell LIKE '%{1}%') AND (ProductStyle LIKE '%{2}%' OR dbo.fn_GetPy(ProductStyle) LIKE '%{2}%')";
            string code = sql + " AND MakeCollectionsCode = '" + gridView.GetDataRow(gridView.FocusedRowHandle)["收款单号"].ToString() + "'";
            string vcode = sql + " AND VoucherCode = '" + gridView.GetDataRow(gridView.FocusedRowHandle)["凭证号"].ToString() + "'";
            using (FrmMakeCollectionsSecond fs = new FrmMakeCollectionsSecond())
            {
                if (drcode == DialogResult.Yes)
                {
                    fs.sqlConditions = code;
                }
                else
                {
                    fs.sqlConditions = vcode;
                }
                DialogResult dr = fs.ShowDialog();
            }
        }
    }
}
