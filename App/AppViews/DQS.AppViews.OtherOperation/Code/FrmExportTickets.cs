using DevExpress.XtraEditors;
using DQS.AppViews.OtherOperation.Properties;
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
using DQS.Module.Entities;

namespace DQS.AppViews.OtherOperation.Code
{
    public partial class FrmExportTickets : XtraForm
    {
        //private IRegulatoryCodeService _service;
        public FrmExportTickets()
        {
            InitializeComponent();

            //_service = new RegulatoryCodeService();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            var dialogResult = saveFileDialog.ShowDialog(this);
            if (dialogResult == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void saveFileDialog_FileOk(object sender, CancelEventArgs e)
        {

            try
            {
                var filename = saveFileDialog.FileName;
                string sql = @"
SELECT rc.Code,rc.CorpCode,rc.ReviewCode,b.DealerCode,b.DealerName,b.DealerAddress,b.BillTypeName,b.BillDate,
p.ProductCode,bd.BatchNo,bd.Amount,bd.ProduceDate,bd.ValidateDate,ISNULL(bd.DetailRemark,'') AS [DetailRemark] FROM dbo.WMS_RegulatoryCode rc
INNER JOIN dbo.BUS_Bill b ON rc.ReviewCode = b.BillCode
INNER JOIN dbo.BUS_BillDetail bd ON b.BillID = bd.BillID
INNER JOIN dbo.BFI_Product p ON bd.ProductID = p.ProductID
WHERE rc.StatusID = 1";
                DataTable dta = GetDataBySQL(sql);

                string sqlcode = @"
SELECT rc.Code FROM dbo.WMS_RegulatoryCode rc
INNER JOIN dbo.BUS_Bill b ON rc.ReviewCode = b.BillCode
WHERE rc.StatusID = 1";
                DataTable codes = GetDataBySQL(sqlcode);


                //Resources.上传单据
                HSSFWorkbook hssfworkbook = new HSSFWorkbook(new MemoryStream(Resources.上传单据));
                HSSFSheet sheet1 = (HSSFSheet)hssfworkbook.GetSheet("Sheet1");
                int rowCount = dta.Rows.Count;

                for (int i = 1; i <= rowCount; i++)
                {
                    IRow row = sheet1.CreateRow(i);
                    for (int j = 0; j < 15; j++)
                    {
                        row.CreateCell(j, CellType.STRING);
                    }
                    row.Cells[0].SetCellValue(dta.Rows[i - 1]["Code"].ToString());
                    row.Cells[1].SetCellValue(dta.Rows[i - 1]["CorpCode"].ToString());
                    row.Cells[2].SetCellValue(dta.Rows[i - 1]["ReviewCode"].ToString());
                    row.Cells[3].SetCellValue(i.ToString());
                    row.Cells[4].SetCellValue(dta.Rows[i - 1]["DealerCode"].ToString());
                    row.Cells[5].SetCellValue(dta.Rows[i - 1]["DealerName"].ToString());
                    row.Cells[6].SetCellValue(dta.Rows[i - 1]["DealerAddress"].ToString());
                    row.Cells[7].SetCellValue(ParseStoreTypeCode(dta.Rows[i - 1]["BillTypeName"].ToString()));
                    row.Cells[8].SetCellValue(dta.Rows[i - 1]["BillDate"].ToString());
                    row.Cells[9].SetCellValue(dta.Rows[i - 1]["ProductCode"].ToString());
                    row.Cells[10].SetCellValue(dta.Rows[i - 1]["BatchNo"].ToString());
                    row.Cells[11].SetCellValue(dta.Rows[i - 1]["Amount"].ToString());
                    row.Cells[12].SetCellValue(dta.Rows[i - 1]["ProduceDate"].ToString());
                    row.Cells[13].SetCellValue(dta.Rows[i - 1]["ValidateDate"].ToString());
                    row.Cells[14].SetCellValue(dta.Rows[i - 1]["DetailRemark"].ToString());
                }

                FileStream file = new FileStream(filename, FileMode.Create);
                hssfworkbook.Write(file);
                file.Close();

                UpdateCodesStatusToExported(codes);

                XtraMessageBox.Show("导出成功!", "系统提示", MessageBoxButtons.OK,
                    MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(string.Format("导出失败！\n 错误信息：{0}", ex.Message), "错误信息", MessageBoxButtons.OK,
                    MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }

        }

        public void UpdateCodesStatusToExported(DataTable codes)
        {
            int rowCount = codes.Rows.Count;
            for (int i = 1; i <= rowCount; i++)
            {
                WMSRegulatoryCodeEntity code = new WMSRegulatoryCodeEntity { Code = codes.Rows[i - 1]["Code"].ToString() };
                code.Fetch();
                code.StatusID = 2;
                code.StatusName = "已导出";
                code.ExportDate = DateTime.Now;
                code.Update();
            }
        }

        /// <summary>
        /// 执行sql查询语句，并将结果以DataTable的形式返回
        /// </summary>
        /// <param name="sql">sql查询语句</param>
        /// <param name="conString">连接字符串</param>
        /// <returns>sql查询语句结果</returns>
        public static DataTable GetDataBySQL(string sql)
        {
            SqlConnection cn = new SqlConnection(GlobalItem.g_DbConnectStrings);
            if (cn.State != ConnectionState.Open)
                cn.Open();
            SqlCommand cmd = new SqlCommand(sql, cn);
            SqlDataAdapter sdap = new SqlDataAdapter();
            sdap.SelectCommand = cmd;
            DataTable dt = new DataTable();
            sdap.Fill(dt);
            cn.Close();
            return dt;
        }

        private string ParseStoreTypeCode(string storeTypeName)
        {
            string code = string.Empty;
            Dictionary<string, string> dic = new Dictionary<string, string>
            {
                {"销售出库","01"},
                {"销售出货","01"},
                {"采购入库","02"},
                {"采购入货","02"},
                {"采购进货","02"},
                {"盘盈","03"},
                {"盘亏","04"},
                {"销售退货","05"},
                {"采购退货","06"}
            };

            dic.TryGetValue(storeTypeName, out code);
            return code;
        }

            //using (SaveFileDialog fileDialog = new SaveFileDialog())
            //{
            //    fileDialog.FileName = "流通监管码";
            //    fileDialog.Filter = "Excel文件(*.xls)|*.xls";
            //    fileDialog.Title = "选择要导出的文件位置";
            //    fileDialog.InitialDirectory = "桌面";

            //    if (fileDialog.ShowDialog(this) == DialogResult.OK)
            //    {
            //        this.gridControl.ExportToXls(fileDialog.FileName);
            //        //this.gvControl.ExportToXls(fileDialog.FileName);
            //    }
            //}
            
        private int count(string sql)
        {
            int count = 0;
            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                conn.Open(); //连接数据库
                //必须为SqlCommand指定数据库连接和登记的事务
                SqlCommand cmd = new SqlCommand(sql, conn);
                try
                {
                    count = (int)cmd.ExecuteScalar();
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
            return count;
        }
        private void FrmExportTickets_Load(object sender, EventArgs e)
        {
            string total = "SELECT COUNT(*) FROM dbo.WMS_RegulatoryCode";
            string unused = "SELECT COUNT(*) FROM dbo.WMS_RegulatoryCode WHERE StatusID = 0";
            string unexported = "SELECT COUNT(*) FROM dbo.WMS_RegulatoryCode WHERE StatusID = 1";
            string exported = "SELECT COUNT(*) FROM dbo.WMS_RegulatoryCode WHERE StatusID = 2";
            lblTotalCodeCount.Text = count(total).ToString();
            lblUsedCodesCount.Text = count(unexported).ToString();
            lblExportedCodesCount.Text = count(exported).ToString();
            lblCanUsedCodesCount.Text = count(unused).ToString();
            btnExport.Enabled = count(unexported) > 0;
        }
    }
}
