using DevExpress.XtraEditors;
using DQS.Common;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
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
    public partial class FrmImport : XtraForm
    {
        public FrmImport()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog(this);
        }

        private void openFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            var file = openFileDialog.FileName;
            LoadExcelData(file);
            gridView.BestFitColumns();
        }

        DataTable dt = new DataTable();
        private void LoadExcelData(string filename)
        {
            dt.Columns.Clear();
            dt.Rows.Clear();
            dt.Clear();
            //StringBuilder sbr = new StringBuilder();
            using (FileStream fs = File.OpenRead(filename))   //打开myxls.xls文件
            {
                HSSFWorkbook wk = new HSSFWorkbook(fs);   //把xls文件中的数据写入wk中
                //for (int i = 0; i < wk.NumberOfSheets; i++)  //NumberOfSheets是myxls.xls中总共的表数
                //{

                IRow titlerow = wk.GetSheetAt(0).GetRow(0);  //读取当前行数据
                if (titlerow != null)
                {
                    //sbr.Append("-------------------------------------\r\n"); //读取行与行之间的提示界限
                    for (int k = 0; k <= titlerow.LastCellNum; k++)  //LastCellNum 是当前行的总列数
                    {
                        ICell cell = titlerow.GetCell(k);  //当前表格
                        if (cell != null)
                        {
                            DataColumn dc = new DataColumn();
                            dc.ColumnName = cell.ToString();
                            dt.Columns.Add(dc);
                            //sbr.Append(cell.ToString());   //获取表格中的数据并转换为字符串类型
                        }
                    }
                }
                ISheet sheet = wk.GetSheetAt(0);   //读取当前表数据
                for (int j = 1; j <= sheet.LastRowNum; j++)  //LastRowNum 是当前表的总行数
                {
                    IRow row = sheet.GetRow(j);  //读取当前行数据
                    DataRow dr = dt.NewRow();
                    if (row != null)
                    {
                        //sbr.Append("-------------------------------------\r\n"); //读取行与行之间的提示界限
                        for (int k = 0; k <= row.LastCellNum; k++)  //LastCellNum 是当前行的总列数
                        {
                            ICell cell = row.GetCell(k);  //当前表格
                            if (cell != null)
                            {
                                dr[k] = cell.ToString();
                                //sbr.Append(cell.ToString());   //获取表格中的数据并转换为字符串类型
                            }
                        }
                        dt.Rows.Add(dr);
                    }
                }
                //}
            }
            gridControl.DataSource = dt;
        }

        private void gridView_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            if (deStartDate.Text == "")
            {
                MessageBox.Show("请选择导入日期！");
                return;
            }
            
            string insql = "INSERT BUS_T(";
            string columns = "";
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    columns += "["+dt.Columns[i].ColumnName.ToString() + "],";
                }
                insql += columns + "[CreateDate])";
            }
            int result = 0;
            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                conn.Open(); //连接数据库
                //必须为SqlCommand指定数据库连接和登记的事务
                try
                {

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        string values = "";
                        for (int j = 0; j < dt.Columns.Count; j++)
                        {
                            values += "'" + dt.Rows[i][j].ToString() + "',";
                        }
                        string sql = insql + "VALUES(" + values + "'" + DateTime.Now + "')";
                        SqlCommand cmd = new SqlCommand(sql, conn);
                        int num = cmd.ExecuteNonQuery();
                        if (num == 1)
                        {
                            result += 1;
                        }
                    }
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                }
                MessageBox.Show("成功导入" + result.ToString() + "条。");
            }
            this.DialogResult = DialogResult.Yes;
        }
    }
}
