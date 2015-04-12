﻿using DevExpress.XtraEditors;
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
    public partial class FrmShowPayment : XtraForm
    {
        public FrmShowPayment()
        {
            InitializeComponent();
        }

        //查询条件
        string sqlSearch = "";

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (FrmPayment fp = new FrmPayment())
            {
                DialogResult dr = fp.ShowDialog();
                if (dr == DialogResult.Yes)
                {
                    gridLoad();
                }
            }
        }

        private void FrmShowPayment_Load(object sender, EventArgs e)
        {
            gridLoad();
        }

        private void gridLoad()
        {
            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                string sqlBill = @"SELECT DISTINCT m.PaymentID,m.PaymentCode AS [付款单号],m.VoucherCode AS [凭证号],m.PaymentPerson AS [付款人],m.OperateDate AS [付款日期],m.DealerName AS [往来单位名称],m.PaymentType AS [付款方式],TotalPrice AS [总金额],m.DealerCode AS [往来单位编号],m.DealerSpell AS [往来单位简拼]
FROM dbo.FIN_Payment m WHERE (m.DealerCode LIKE '%{0}%' OR m.DealerName LIKE '%{0}%' OR m.DealerSpell LIKE '%{0}%') AND (m.PaymentCode LIKE '%{1}%') AND (m.VoucherCode LIKE '%{2}%')";
//                string sql = @"SELECT md.BusinessBillCode AS [单据编号],md.DealerName AS [往来单位名称],md.ProductName AS [药品名称],md.BatchNo AS [批号],md.UnitPrice AS [单价],md.Amount AS [数量],md.TotalPrice AS [金额]
//FROM dbo.FIN_Payment m
//INNER JOIN dbo.FIN_PaymentDetail md ON m.PaymentCode = md.PaymentCode";

                sqlBill = String.Format(sqlBill, txtDealerCode.Text.Trim(), txtPaymentCode.Text.Trim(), txtVoucherCode.Text.Trim());
                //SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
                SqlDataAdapter sdad = new SqlDataAdapter(sqlBill, conn);
                DataSet ds = new DataSet();
                try
                {
                    //sda.Fill(ds, "Table");
                    sdad.Fill(ds, "TableBill");
                    //DataRelation dr = new DataRelation("单据明细", ds.Tables["TableBill"].Columns["单据编号"], ds.Tables["Table"].Columns["单据编号"], false);
                    //ds.Relations.Add(dr);
                    decimal Price = 0;
                    for (int i = 0; i < ds.Tables["TableBill"].Rows.Count; i++)
                    {
                        Price += Convert.ToDecimal(ds.Tables["TableBill"].Rows[i]["总金额"]);
                    }
                    lblTotalPrice.Text = Price.ToString();
                    gridControl.DataSource = ds.Tables["TableBill"];
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

        private void txtChanged(object sender, EventArgs e)
        {
            gridLoad();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            DialogResult dr = XtraMessageBox.Show("1.删除该组数据，点击“是(Yes)”按钮（同一个付款编号或凭证号中的数据）\n2.删除该条信息，点击“否(No)”按钮\n3.取消请点击“取消(Cancel)”按钮", "系统提示", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (dr == DialogResult.Cancel) return;

            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                string Delsql = @"DELETE dbo.FIN_Payment WHERE {0}
DELETE dbo.FIN_PaymentDetail WHERE {0}";
                if (dr == DialogResult.Yes)
                {
                    string code = gridView.GetDataRow(gridView.FocusedRowHandle)["付款单号"].ToString();
                    Delsql = String.Format(Delsql, "PaymentCode = '" + code + "'");
                }
                else if (dr == DialogResult.No)
                {
                    string code = gridView.GetDataRow(gridView.FocusedRowHandle)["付款单号"].ToString();
                    string dealercode = gridView.GetDataRow(gridView.FocusedRowHandle)["往来单位编号"].ToString();
                    Delsql = String.Format(Delsql, "PaymentCode = '" + code + "' AND DealerCode = '" + dealercode + "'");
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
            sqlSearch = "";
            txtDealerCode.Text = "";
            txtPaymentCode.Text = "";
            txtVoucherCode.Text = "";
            gridLoad();
        }

        private void gridView_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
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
