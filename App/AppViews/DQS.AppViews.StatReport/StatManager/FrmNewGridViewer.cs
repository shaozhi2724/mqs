﻿using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraLayout;
using DevExpress.XtraPrinting;
using DQS.Common;
using DQS.Controls;
using DQS.Module.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DQS.AppViews.StatReport.StatManager
{
    public partial class FrmNewGridViewer : XtraForm
    {
        private SYSPageEntity sysPage;
        public FrmNewGridViewer()
        {
            InitializeComponent();
        }

        string choose = "";
        int height = 31;

        private void FrmNewGridViewer_Load(object sender, EventArgs e)
        {
            deStartDate.Text = DateTime.Today.ToString("d");
            deEndDate.Text = DateTime.Today.ToString("d");
            gridLoad();
            LoadControl();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadChooseText();
            panelControl.Height = 33;
            gridLoad();
        }

        private void btnReSet_Click(object sender, EventArgs e)
        {
            deStartDate.Text = DateTime.Today.ToString("d");
            deEndDate.Text = DateTime.Today.ToString("d");
            choose = "";
            foreach (Control item in panelControl.Controls)
            {
                if (item.GetType().Name.Equals("TextEdit"))
                {
                    item.Text = "";
                }
            }
            gridLoad();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.SaveFileDialog saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            saveFileDialog.Title = "导出Excel";
            saveFileDialog.Filter = "Excel文件(*.xls)|*.xls";
            System.Windows.Forms.DialogResult dialogResult = saveFileDialog.ShowDialog(this);
            if (dialogResult == System.Windows.Forms.DialogResult.OK)
            {
                XlsExportOptions xlsExportOptions = new XlsExportOptions();
                this.gridControl.ExportToXls(saveFileDialog.FileName);
                XtraMessageBox.Show("保存成功！", "提示", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Asterisk);
            }
            //SaveFileDialog saveFileDialog = new SaveFileDialog();
            //saveFileDialog.Title = "导出Excel";
            //saveFileDialog.Filter = "Excel文件(*.xls)|*.xls";
            //DialogResult dialogResult = saveFileDialog.ShowDialog(this);
            //if (dialogResult == DialogResult.OK)
            //{
                //DevExpress.XtraPrinting.XlsExportOptions options = new DevExpress.XtraPrinting.XlsExportOptions();
                //gridControl.ExportToXls(saveFileDialog.FileName);
                //DataTable dt = gridControl.DataSource as DataTable;
                //DataGridToExcel(dt,gridView);
                //XtraMessageBox.Show("保存成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
        }

 #region 用流将数据导入到Excel中

        public static void DataGridToExcel(DataTable dt, GridView dgv)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel文件(*.xls)|*.xls";
            //saveFileDialog.FilterIndex = 0;
            //saveFileDialog.RestoreDirectory = true;
            //saveFileDialog.CreatePrompt = true;
            saveFileDialog.Title = "导出Excel文件到";
            //DateTime now = SystemManage.GetTimeNow();
            //saveFileDialog.FileName = title;
            DialogResult dr = saveFileDialog.ShowDialog();
            if (dr == DialogResult.Cancel)
                return;
            Stream myStream;
            myStream = saveFileDialog.OpenFile();
            string fileName = saveFileDialog.FileName;
            if (fileName == "")
            {
                XtraMessageBox.Show("请输入文件名!", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            StreamWriter sw = new StreamWriter(myStream, System.Text.Encoding.GetEncoding("gb2312"));
            string str = "";
            try
            {
                //写标题
                //string stc = title;
                //sw.WriteLine(stc);
                for (int i = 0; i <= dgv.Columns.Count; i++)
                {
                    if (i == 0)
                    {
                        str += "序号";
                    }
                    else
                    {
                        if (dgv.Columns[i - 1].Visible == true)
                        {
                            str += "\t";
                            str += dgv.Columns[i - 1].FieldName;
                        }
                    }
                }
                sw.WriteLine(str);
                int count = 0;
                //写内容
                for (int j = 0; j < dt.Rows.Count; j++)
                {
                    string tempStr = "";
                    for (int k = 0; k < dt.Columns.Count + 1; k++)
                    {
                        if (k == 0)
                        {
                            tempStr = (count+1).ToString();
                        }
                        else
                        {
                            if (dgv.Columns[k - 1].Visible == true)
                            {
                                tempStr += "\t";
                                tempStr += dt.Rows[j][k - 1].ToString().Trim();
                            }
                        }
                    }
                    sw.WriteLine(tempStr);
                    count++;
                }
                sw.Close();
                sw.Dispose();
                myStream.Close();
                myStream.Dispose();
                XtraMessageBox.Show("操作成功!", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception e)
            {
                XtraMessageBox.Show("操作失败!", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            finally
            {
                sw.Close();
                myStream.Close();
            }
        }

 #endregion


        private void LoadControl()
        {
            GetPY gp = new GetPY();
            string pageName = this.Tag.ToString();
            //设置数据
            sysPage = GlobalMethod.GetFormPage(pageName);
            if (sysPage != null)
            {
                if (sysPage.Reservation3 != "")
                {
                        string name;
                        string py;
                        int locationx = 9;
                        int locationy = 48;
                    if (sysPage.Reservation3.Contains(","))
                    {
                        string s = sysPage.Reservation3;
                        string[] sArray = s.Split(',');
                        string sn = sysPage.Reservation4;
                        string[] sArraytxt = sn.Split(',');

                            int j = 0;
                        foreach (string i in sArray)
                        {
                            //MessageBox.Show(sArraytxt[j]);
                            //MessageBox.Show(sArray[0].ToString()+j.ToString()+i.ToString());
                            name = i.ToString();
                            py = gp.GetPYString(name);
                            LabelControl lc = new LabelControl();
                            lc.Location = new Point(locationx, locationy);
                            lc.Name = py;
                            lc.Text = name + "：";
                            TextEdit te = new TextEdit();
                            te.Size = new Size(120, 21);
                            te.Location = new Point(locationx + 100, locationy);
                            locationx += 242;
                            if (locationx > 472)
                            {
                                locationx = 9;
                                locationy += 40;
                            }
                            te.Name = sArraytxt[j];
                            this.panelControl.Controls.Add(lc);
                            this.panelControl.Controls.Add(te);
                            j++;
                        }
                        height = locationy + 40;
                    }
                    else
                    {
                        name = sysPage.Reservation3;
                        py = gp.GetPYString(name);
                        LabelControl lc = new LabelControl();
                        lc.Location = new Point(locationx, locationy);
                        lc.Name = py;
                        lc.Text = name + "：";
                        TextEdit te = new TextEdit();
                        te.Size = new Size(120, 21);
                        te.Location = new Point(locationx + 100, locationy);
                        te.Name = sysPage.Reservation4;
                        this.panelControl.Controls.Add(lc);
                        this.panelControl.Controls.Add(te);
                    }
                }
            }
        }

        private void LoadChooseText()
        {
            choose = "";
            foreach (Control item in panelControl.Controls)
            {
                if (item.GetType().Name.Equals("TextEdit"))
                {
                    if (item.Text.Trim() != "")
                    {
                        choose += " AND (" + item.Name + " LIKE ''%" + item.Text + "%'' OR dbo.fn_GetPy(" + item.Name + ") LIKE ''%" + item.Text + "%'')";
                    }
                }
            }
            if (DQS.Controls.Properties.Settings.Default.IsLockDepartment)
            {
                choose += " AND (DepartmentID = " + GlobalItem.g_CurrentEmployee.DepartmentID + ")";
            }
        }

        private void gridLoad()
        {
            if (DQS.Controls.Properties.Settings.Default.IsLockDepartment)
            {
                choose += " AND (DepartmentID = " + GlobalItem.g_CurrentEmployee.DepartmentID + ")";
            }
            string pageName = this.Tag.ToString();
            //设置数据
            sysPage = GlobalMethod.GetFormPage(pageName);
            if (sysPage != null)
            {
                using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
                {
                    string sql = "";
                    if (sysPage.Reservation1 == "1")
                    {
                        deStartDate.Visible = true;
                        deEndDate.Visible = true;
                        //sql = "exec " + sysPage.DbViewName + " '" + deStartDate.DateTime.ToString("d") + "','" + deEndDate.DateTime.ToString("d") + "'";
                        sql = "exec " + sysPage.DbViewName + " '" + deStartDate.DateTime.ToString("d") + "','" + deEndDate.DateTime.ToString("d") + "','" + choose + "'";
                    }
                    else
                    {
                        deStartDate.Visible = false;
                        deEndDate.Visible = false;
                        sql = "exec " + sysPage.DbViewName + " '" + choose + "'";
                    }

                    SqlDataAdapter sdad = new SqlDataAdapter(sql, conn);
                    DataSet ds = new DataSet();
                    try
                    {
                        sdad.Fill(ds, "Table");
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
                        if (!sysPage.IsNullField("Reservation5"))
                        {
                            if (sysPage.Reservation5.Contains(","))
                            {
                                string s = sysPage.Reservation5;
                                string[] sArray = s.Split(',');
                                foreach (string i in sArray)
                                {
                                    gridView.Columns[i].OptionsColumn.AllowEdit = true;
                                }
                            }
                            else
                            {
                                gridView.Columns[0].OptionsColumn.AllowEdit = true;
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
            if (sysPage.Reservation2 != "")
            {
                //DevExpress.XtraGrid.Columns.GridColumn col_Profit = gridView.Columns["总数"];
                //gridView.Columns["数量"].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
                //gridView.Columns["数量"].SummaryItem.DisplayFormat = "数量合计: {0}";
                //GridGroupSummaryItem item1 = new GridGroupSummaryItem();
                //item1.FieldName = "参考利润";
                //item1.SummaryType = DevExpress.Data.SummaryItemType.Sum;
                //item1.DisplayFormat = "利润小计:  {0:c2}";//格式
                //item1.ShowInGroupColumnFooter = col_Profit;
                if (sysPage.Reservation2.Contains(","))
                {
                    string s = sysPage.Reservation2;
                    string[] sArray = s.Split(',');
                    foreach (string i in sArray)
                    {
                        gridView.Columns[i.ToString()].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
                        gridView.Columns[i.ToString()].SummaryItem.DisplayFormat = i.ToString() + "合计: {0}";
                    }
                }
                else
                {
                    gridView.Columns[sysPage.Reservation2].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
                    gridView.Columns[sysPage.Reservation2].SummaryItem.DisplayFormat = sysPage.Reservation2 + "合计: {0}";
                }
            }
        }

        private void gridView_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {

            object id = gridView.GetFocusedRowCellValue("MakeCollectionsBillID");
            if (id != null)
            {
                string fileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory + "发票清单.mrt");
                if (File.Exists(fileName))
                {
                    PrintPreviewForm printPreview = new PrintPreviewForm(fileName, Convert.ToInt32(id));
                    printPreview.ShowDialog(this);
                }
                else
                {
                    XtraMessageBox.Show("找不到文件。", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnChooseSearch_Click(object sender, EventArgs e)
        {
            string py;

            string pageName = this.Tag.ToString();
            //设置数据
            sysPage = GlobalMethod.GetFormPage(pageName);

            if (sysPage.Reservation3 != "")
            {
                if (sysPage.Reservation3.Contains(","))
                {
                    string s = sysPage.Reservation3;
                    string[] sArray = s.Split(',');
                    foreach (string i in sArray)
                    {
                        GetPY gp = new GetPY();
                        py = gp.GetPYString(i.ToString());

                        //gridView.Columns[i.ToString()].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
                        //gridView.Columns[i.ToString()].SummaryItem.DisplayFormat = i.ToString() + "合计: {0}";
                    }
                }
                else
                {
                    gridView.Columns[sysPage.Reservation2].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
                    gridView.Columns[sysPage.Reservation2].SummaryItem.DisplayFormat = sysPage.Reservation2 + "合计: {0}";
                }
            }
            using (FrmChooseSearch fcs = new FrmChooseSearch())
            {
                DialogResult dr = fcs.ShowDialog();
                if (dr == DialogResult.Yes)
                {

                }
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            panelControl.Height = height;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            panelControl.Height = 33;
        }

        private void gridView_DoubleClick(object sender, EventArgs e)
        {
            string pageName = this.Tag.ToString();
            //设置数据
            sysPage = GlobalMethod.GetFormPage(pageName);
            if (sysPage != null)
            {
                if (!sysPage.IsNullField("PageDescription") && sysPage.PageDescription != "")
                {
                    if (gridView.RowCount == 0)
                    {
                        return;
                    }
                    string sql = sysPage.PageDescription + gridView.GetDataRow(gridView.FocusedRowHandle)["ID"].ToString();
                    using (FrmNewGridViewerDetail fs = new FrmNewGridViewerDetail())
                    {
                        fs.sqlConditions = sql;
                        DialogResult dr = fs.ShowDialog();
                    }
                }
            }
        }
    }
}
