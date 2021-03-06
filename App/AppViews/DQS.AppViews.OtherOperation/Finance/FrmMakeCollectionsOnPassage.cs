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
            deStartDate.Text = DateTime.Today.ToString("d");
            deEndDate.Text = DateTime.Today.ToString("d");
            LastInventoryDate();
            //gridLoad();
        }

        private void gridLoad()
        {
            //sqlSearch = " AND (OperateDate BETWEEN '" + deStartDate.Text.Trim() + " 00:00:00' AND '" + deEndDate.Text.Trim() + " 23:59:59')";
            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                string sql = @"EXEC sp_ShowMakeCollectionsOnPassage '{0}','{1}','{2}','{3}','{4}'";
                sql = string.Format(sql, deStartDate.Text.Trim(), deEndDate.Text.Trim(), txtDealerCode.Text.Trim(), txtBillCode.Text.Trim(), txtBusinessPerson.Text.Trim());
                SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                try
                {
                    sda.Fill(ds, "Table");

                    gridControl.DataSource = ds.Tables["Table"];
                    gridView.OptionsView.ColumnAutoWidth = false;
                    gridView.BestFitColumns();
                    gridView.OptionsView.ShowGroupPanel = false;

                    gridView.Columns["总金额"].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
                    gridView.Columns["总金额"].SummaryItem.DisplayFormat = "合计: {0}";
                    gridView.Columns["实际总金额"].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
                    gridView.Columns["实际总金额"].SummaryItem.DisplayFormat = "合计: {0}";
                    gridView.Columns["利润"].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
                    gridView.Columns["利润"].SummaryItem.DisplayFormat = "合计: {0}";

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
            //gridLoad();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            DialogResult dr = XtraMessageBox.Show("确定删除单号为：" + gridView.GetDataRow(gridView.FocusedRowHandle)["单据编号"].ToString()+"的单据吗？", "系统提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
                {
                    int detailID = int.Parse(gridView.GetDataRow(gridView.FocusedRowHandle)["DetailID"].ToString());
                    int storeID = int.Parse(gridView.GetDataRow(gridView.FocusedRowHandle)["ID"].ToString());
                    string insertBill = @"EXEC sp_DelMakeCollectionsOnPassageDetail {0},{1}";
                    try
                    {
                        conn.Open();
                        SqlCommand Bcommand = new SqlCommand(String.Format(insertBill, detailID,storeID), conn);
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
            gridLoad();
        }

        private void btnChooseBillAgio_Click(object sender, EventArgs e)
        {
            LastInventoryDate();
            if (IsInventory())
            {
                XtraMessageBox.Show("请完成期初数据", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }
            using (FrmChooseBill fb = new FrmChooseBill())
            {
                fb.storeBill = "fn_MakeCollectionsOnPassageForAgio";
                fb.storeBillDetail = "fn_MakeCollectionsOnPassageDetailForAgio";
                fb.storeBillSave = "fn_InsertOnPassageForAgio";
                fb.isIn = 1;
                fb.lblAgio.Visible = true;
                fb.cboAgio.Visible = true;
                fb.cboAgio.Properties.ReadOnly = false;
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
    }
}
