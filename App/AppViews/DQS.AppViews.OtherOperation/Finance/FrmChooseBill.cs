﻿using DevExpress.XtraEditors;
using DQS.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DQS.AppViews.OtherOperation.Finance
{
    public partial class FrmChooseBill : XtraForm
    {
        public FrmChooseBill()
        {
            InitializeComponent();
        }

        //记录单据存储过程
        public string storeBill = "";
        //记录单据明细存储过程
        public string storeBillDetail = "";
        //记录保存执行的存储过程
        public string storeBillSave = "";
        //记录当前往来单位查询条件
        public string DealerCode = "";
        //记录当前单据编号查询条件
        public string BillCode = "";
        //记录单据ID
        public List<int> BillList = new List<int>();
        //记录单据明细ID
        public List<int> DetailList = new List<int>();
        //记录上一次结存日期
        public string stringDate = "";

        /// <summary>
        /// 界面加载、隐藏ID、不能编辑
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmChooseBill_Load(object sender, EventArgs e)
        {
            ceAll.Checked = false;
            deStartDate.Text = stringDate;
            txtDealerCode.Text = DealerCode;
            txtBillCode.Text = BillCode;
            GainData();

            //new GridCheckMarksSelection(gVBill);
        }

        /// <summary>
        /// 加载gCBill、gVBill，单据信息
        /// </summary>
        private void GainData()
        {
            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                string sql = "EXEC " + storeBill + " '" + txtDealerCode.Text.Trim() + "','" + txtBillCode.Text.Trim() + "','" + deStartDate.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                try
                {
                    sda.Fill(ds, "Table");
                    ds.Tables["Table"].Columns.Add("选择", System.Type.GetType("System.Boolean"));

                    gCBill.DataSource = ds.Tables["Table"];
                    gVBill.BestFitColumns();
                    gVBill.OptionsView.ShowGroupPanel = false;
                    for (int i = 0; i < gVBill.Columns.Count; i++)
                    {
                        string ColumnName = gVBill.Columns[i].ToString();
                        if (ColumnName.Contains("ID"))
                        {
                            gVBill.Columns[i].Visible = false;
                        }
                        gVBill.Columns[i].OptionsColumn.AllowEdit = false;
                    }
                    for (int i = 0; i < gVBill.RowCount; i++)
                    {
                        gVBill.SetRowCellValue(i, "选择", "False");
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
        /// <summary>
        /// 加载gCDetails、gVDetails，单据明细信息
        /// </summary>
        /// <param name="id">单据ID</param>
        private void GainDetailData(int id)
        {
            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                string sql = "EXEC " + storeBillDetail + " " + id;
                SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                try
                {
                    sda.Fill(ds, "Table");
                    ds.Tables["Table"].Columns.Add("选择", System.Type.GetType("System.Boolean"));

                    gCDetails.DataSource = ds.Tables["Table"];
                    gVDetails.BestFitColumns();
                    gVDetails.OptionsView.ShowGroupPanel = false;

                    for (int i = 0; i < gVDetails.Columns.Count; i++)
                    {
                        string ColumnName = gVDetails.Columns[i].ToString();
                        if (ColumnName.Contains("ID") || ColumnName.Contains("往来单位"))
                        {
                            gVDetails.Columns[i].Visible = false;
                        }
                        gVDetails.Columns[i].OptionsColumn.AllowEdit = false;
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

        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                string insertBill = @"EXEC " + storeBillSave + " '{0}'";
                try
                {
                    conn.Open();
                    foreach (int storeid in BillList)
                    {
                        SqlCommand command = new SqlCommand(String.Format(insertBill, storeid), conn);
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
            DealerCode = txtDealerCode.Text.Trim();
            BillCode = txtBillCode.Text.Trim();
            this.DialogResult = DialogResult.Yes;
        }

        /// <summary>
        /// 单据信息焦点改变，明细信息根据ID变化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gVBill_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            GainDetailData(Convert.ToInt32(gVBill.GetRowCellValue(gVBill.FocusedRowHandle, "StoreID")));
            ReadList();
        }

        /// <summary>
        /// 读取是否选择
        /// </summary>
        private void ReadList()
        {
            for (int i = 0; i < gVDetails.RowCount; i++)
            {
                int detailID = Convert.ToInt32(gVDetails.GetRowCellValue(i, "DetailID"));
                if (DetailList.Contains(detailID))
                {
                    gVDetails.SetRowCellValue(i, "选择", "True");
                }
                else
                {
                    gVDetails.SetRowCellValue(i, "选择", "False");
                }
            }
        }

        /// <summary>
        /// 读取是否选择
        /// </summary>
        private void ReadBillList()
        {
            for (int i = 0; i < gVBill.RowCount; i++)
            {
                int BillID = Convert.ToInt32(gVBill.GetRowCellValue(i, "StoreID"));
                if (BillList.Contains(BillID))
                {
                    gVBill.SetRowCellValue(i, "选择", "True");
                }
                else
                {
                    gVBill.SetRowCellValue(i, "选择", "False");
                }
            }
        }

        /// <summary>
        /// 单据信息点击选择
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gVBill_Click(object sender, EventArgs e)
        {
            if (gVBill.FocusedColumn.ToString() == "选择")
            {
                string value = gVBill.GetRowCellValue(gVBill.FocusedRowHandle, "选择").ToString();
                string dvalue = "";
                if (value == "True")
                {
                    gVBill.SetRowCellValue(gVBill.FocusedRowHandle, "选择", "False");
                    BillList.Remove(Convert.ToInt32(gVBill.GetDataRow(gVBill.FocusedRowHandle)["StoreID"]));
                    for (int i = 0; i < gVDetails.RowCount; i++)
                    {
                        dvalue = gVDetails.GetDataRow(i)["选择"].ToString();
                        if (dvalue == "True")
                        {
                            gVDetails.SetRowCellValue(i, "选择", "False");
                            DetailList.Remove(Convert.ToInt32(gVDetails.GetDataRow(i)["DetailID"]));
                            sumPrice(-Convert.ToDouble(gVDetails.GetDataRow(i)["金额"]));
                        }
                    }
                }
                else
                {
                    gVBill.SetRowCellValue(gVBill.FocusedRowHandle, "选择", "True");
                    BillList.Add(Convert.ToInt32(gVBill.GetDataRow(gVBill.FocusedRowHandle)["StoreID"]));
                    for (int i = 0; i < gVDetails.RowCount; i++)
                    {
                        dvalue = gVDetails.GetDataRow(i)["选择"].ToString();
                        if (dvalue == "False" || dvalue == "")
                        {
                            gVDetails.SetRowCellValue(i, "选择", "True");
                            DetailList.Add(Convert.ToInt32(gVDetails.GetDataRow(i)["DetailID"]));
                            sumPrice(Convert.ToDouble(gVDetails.GetDataRow(i)["金额"]));
                        }
                    }
                }
            }
        }

        /// <summary>
        /// 单据详细信息点击选择
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gVDetails_Click(object sender, EventArgs e)
        {
            if (gVDetails.FocusedColumn.ToString() == "选择")
            {
                string value = gVDetails.GetDataRow(gVDetails.FocusedRowHandle)["选择"].ToString();
                //MessageBox.Show(dvalue);
                if (value == "True")
                {
                    gVDetails.SetRowCellValue(gVDetails.FocusedRowHandle, "选择", "False");
                    DetailList.Remove(Convert.ToInt32(gVDetails.GetDataRow(gVDetails.FocusedRowHandle)["DetailID"]));
                    sumPrice(-Convert.ToDouble(gVDetails.GetDataRow(gVDetails.FocusedRowHandle)["金额"]));
                }
                else
                {
                    gVDetails.SetRowCellValue(gVDetails.FocusedRowHandle, "选择", "True");
                    DetailList.Add(Convert.ToInt32(gVDetails.GetDataRow(gVDetails.FocusedRowHandle)["DetailID"]));
                    sumPrice(Convert.ToDouble(gVDetails.GetDataRow(gVDetails.FocusedRowHandle)["金额"]));
                }
            }
            string bvalue = gVBill.GetDataRow(gVBill.FocusedRowHandle)["选择"].ToString();
            bool istrue = false;
            for (int i = 0; i < gVDetails.RowCount; i++)
            {
                string value = gVDetails.GetDataRow(i)["选择"].ToString();
                if (value == "True" && bvalue == "False")
                {
                    istrue = true;
                    break;
                }
                else if (value == "True" && bvalue == "True")
                {
                    return;
                }
                else if (value == "False" && bvalue == "True")
                {
                    istrue = false;
                }
            }
            if (istrue)
            {
                gVBill.SetRowCellValue(gVBill.FocusedRowHandle, "选择", "True");
                BillList.Add(Convert.ToInt32(gVBill.GetDataRow(gVBill.FocusedRowHandle)["StoreID"]));
            }
            else
            {
                gVBill.SetRowCellValue(gVBill.FocusedRowHandle, "选择", "False");
                BillList.Remove(Convert.ToInt32(gVBill.GetDataRow(gVBill.FocusedRowHandle)["StoreID"]));
            }
        }

        private void gVBill_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
        }

        private void gVDetails_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
        }

        //文本框改变
        private void txtDealerCode_TextChanged(object sender, EventArgs e)
        {
            GainData();
            ReadBillList();
            gVBill_FocusedRowChanged(null, null);
        }

        private void sumPrice(double Price)
        {
            double lbl = Convert.ToDouble(lblTotalPrice.Text);
            lblTotalPrice.Text = (lbl + Price).ToString();
        }

        private void btnReSet_Click(object sender, EventArgs e)
        {
            this.txtDealerCode.Text = "";
            this.txtBillCode.Text = "";
            GainData();
        }

        private void ceAll_CheckedChanged(object sender, EventArgs e)
        {
            BillList.Clear();
            DetailList.Clear();
            lblTotalPrice.Text = "0";
            GainData();
            GainDetailData(Convert.ToInt32(gVBill.GetRowCellValue(gVBill.FocusedRowHandle, "StoreID")));
            if (ceAll.Checked)
            {
                for (int i = 0; i < gVBill.RowCount; i++)
                {
                    gVBill.SetRowCellValue(i, "选择", "True");
                    BillList.Add(Convert.ToInt32(gVBill.GetDataRow(i)["StoreID"]));
                    gVBill.FocusedRowHandle = i;
                    for (int j = 0; j < gVDetails.RowCount; j++)
                    {
                        gVDetails.SetRowCellValue(j, "选择", "True");
                        DetailList.Add(Convert.ToInt32(gVDetails.GetDataRow(j)["DetailID"]));
                        sumPrice(Convert.ToDouble(gVDetails.GetDataRow(j)["金额"]));
                    }
                }
            }
        }
    }
}