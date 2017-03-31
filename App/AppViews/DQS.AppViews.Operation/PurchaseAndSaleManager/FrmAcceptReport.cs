using DevExpress.XtraEditors;
using DQS.Common;
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

namespace DQS.AppViews.Operation.PurchaseAndSaleManager
{
    public partial class FrmAcceptReport : XtraForm
    {
        int _BillID;
        public FrmAcceptReport()
        {
            InitializeComponent();
        }
        public FrmAcceptReport(int BillID)
        {
            InitializeComponent();
            _BillID = BillID;
        }
        //加载
        private void FrmAcceptReport_Load(object sender, EventArgs e)
        {
            LoadGridDetails();
            PrintControl(0);
        }
        //加载明细
        private void LoadGridDetails()
        {
            string sql = @"SELECT p.ProductID,p.ProductCode,p.ProductName,p.ProductSpec,BatchNo FROM dbo.BUS_BillDetail bd
INNER JOIN dbo.BFI_Product p ON bd.ProductID = p.ProductID
WHERE BillID = {0}";
            sql = string.Format(sql, _BillID);
            using (DataSet dataSet = new DataSet())
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(sql, GlobalItem.g_DbConnectStrings))
                {
                    adapter.Fill(dataSet);
                }
                this.gDetails.DataSource = dataSet.Tables[0];
            }
        }
        //加载验报列表
        private void LoadGridReport(int _ProductID,string _BatchNo)
        {
            string sql = @"SELECT AcceptAttachmentID,ProductID,BatchNo,AttachmentName,AttachmentSize,AttachmentType,CreateDate 
FROM dbo.BUS_AcceptAttachment 
WHERE ProductID = {0} AND BatchNo = '{1}'";
            sql = string.Format(sql, _ProductID, _BatchNo);
            using (DataSet dataSet = new DataSet())
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(sql, GlobalItem.g_DbConnectStrings))
                {
                    adapter.Fill(dataSet);
                }
                this.gReport.DataSource = dataSet.Tables[0];
            }
        }
        //
        private void PrintControl(int i)
        {
            if (vDetails.RowCount > 0)
            {
                int productid = Convert.ToInt32(vDetails.GetDataRow(i)["ProductID"]);
                string batchNo = vDetails.GetDataRow(i)["BatchNo"].ToString();
                LoadGridReport(productid, batchNo);
                if (vReport.RowCount > 0)
                {
                    PicControl(0);
                    btnPrint.Enabled = true;
                }
                else
                {
                    btnPrint.Enabled = false;
                }
            }
        }
        private void PicControl(int i)
        {
            if (vReport.RowCount > 0)
            {
                int AcceptAttachmentID = Convert.ToInt32(vReport.GetDataRow(i)["AcceptAttachmentID"]);
                PicLoad(AcceptAttachmentID);
            }
        }

        private void PicLoad(int AcceptAttachmentID)
        {
            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                string sql = @"SELECT AttachmentContent FROM BUS_AcceptAttachment WHERE AcceptAttachmentID = " + AcceptAttachmentID;
                try
                {
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    conn.Open();
                    byte[] b = (byte[])cmd.ExecuteScalar();
                    if (b.Length > 0)
                    {
                        MemoryStream stream = new MemoryStream(b, true);
                        pictureEdit.Image = Bitmap.FromStream(stream);
                        stream.Close();
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

        private void vDetails_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
        }

        private void vReport_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
        }

        private void vDetails_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            PrintControl(e.RowHandle);
        }

        private void vReport_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            PicControl(e.RowHandle);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument;

            if (printDialog.ShowDialog(this) == DialogResult.OK) //到这里会出现选择打印项的窗口
            {
                printDialog.Document.Print(); //到这里会出现给文件命名的窗口，点击确定后进行打印并完成打印
            }
        }

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                if (pictureEdit.Image != null)
                {
                    e.Graphics.DrawImage(pictureEdit.Image, e.Graphics.VisibleClipBounds);
                    e.HasMorePages = false;
                }
            }
            catch (Exception exception)
            {
                XtraMessageBox.Show(exception.ToString());
            }
        }
    }
}
