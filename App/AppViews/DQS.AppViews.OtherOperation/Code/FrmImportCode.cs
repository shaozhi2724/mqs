using DevExpress.XtraEditors;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DQS.Module.Entities;
using DQS.Common;

namespace DQS.AppViews.OtherOperation.Code
{
    public partial class FrmImportCode : XtraForm
    {

        List<string> _codes;
        public FrmImportCode()
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
            txtFile.Text = file;

            LoadExcelData(file);
            gridView.BestFitColumns();
        }

        private void LoadExcelData(string filename)
        {
            _codes = new List<string>();
            try
            {
                using (FileStream file = new FileStream(filename, FileMode.Open, FileAccess.Read))
                {
                    HSSFWorkbook hssfworkbook = new HSSFWorkbook(file);
                    ISheet sheet1 = hssfworkbook.GetSheet("Sheet1");
                    int rowCount = (sheet1 as HSSFSheet).LastRowNum;
                    for (int i = 1; i <= rowCount; i++)
                    {
                        var code = sheet1.GetRow(i).GetCell(0).StringCellValue;
                        if (!string.IsNullOrWhiteSpace(code))
                        {
                            _codes.Add(code);
                        }
                    }
                    grdCodes.DataSource = _codes;
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
            btnImport.Enabled = _codes.Any();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            string file = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "CorpCode.dat");
            if (!File.Exists(file))
            {
                MessageBox.Show("请先输入企业编码！");
                FrmCorpCodeSetting doc = new FrmCorpCodeSetting();
                if (System.Windows.Forms.DialogResult.Yes == doc.ShowDialog(this))
                {
                    ImportCodes(file);
                }
            }
            else
            {
                ImportCodes(file);
            }
        }

        private void ImportCodes(string file)
        {
            string corpCode = File.ReadAllText(file);
            var importedCodes = ImportedCodes(_codes, corpCode);
            if (importedCodes > 0)
            {
                XtraMessageBox.Show(string.Format("流通监管码导入成功！共导入 {0} 条记录！", importedCodes));
                btnImport.Enabled = false;
            }
            else
            {
                XtraMessageBox.Show("流通监管码导入失败！数据重复导入，请检查文件后重试!");
            }
        }

        private int ImportedCodes(List<string> _Codes, string _CorpCode)
        {
            int result = 0;
            foreach (var codeViewModel in _Codes)
            {
                if (codeViewModel == null || codeViewModel == "")
                {
                    continue;
                }
                string sql = @"
INSERT dbo.WMS_RegulatoryCode(Code,CorpCode,StatusID,StatusName,CreateDate)
VALUES  ('{0}','{1}',0,N'未使用','{2}')";
                using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
                {
                    conn.Open(); //连接数据库
                    //必须为SqlCommand指定数据库连接和登记的事务
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    try
                    {
                        cmd.CommandText = string.Format(sql, codeViewModel, _CorpCode, DateTime.Now);
                        int num = cmd.ExecuteNonQuery();
                        if (num == 1)
                        {
                            result += 1;
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
                }
                
            }
            return result;
        }

        private void gridView_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
        }
    }
}
