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

namespace DQS.App
{
    public partial class FrmDownAttachment : XtraForm
    {
        public FrmDownAttachment()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtCode.Text.Trim() == "")
            {
                MessageBox.Show("请输入产品编号或名称。");
                return;
            }
            string sql = @"SELECT  AcceptAttachmentID ,
        a.ProductID ,
        p.ProductCode,
        p.ProductName,
        p.PackageSpec,
        p.ProducerName,
        BatchNo ,
        AttachmentName
FROM dbo.BUS_AcceptAttachment a
INNER JOIN dbo.BFI_Product p ON a.ProductID = p.ProductID
WHERE (p.ProductCode LIKE '%{0}%' OR p.ProductName LIKE '%{0}%' OR p.ProductSpell LIKE '%{0}%') AND BatchNo LIKE '%{1}%'
ORDER BY a.CreateDate DESC";
            sql = string.Format(sql, txtCode.Text.Trim(), txtBatchNo.Text.Trim());
            using (DataSet dataSet = new DataSet())
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(sql, GlobalItem.g_DbConnectStrings))
                {
                    adapter.Fill(dataSet);
                }
                this.gridControl.DataSource = dataSet.Tables[0];
            }
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            if (this.gridView.RowCount > 0)
            {
                if (this.gridView.GetFocusedRowCellValue("AttachmentName") != null && this.gridView.GetFocusedRowCellValue("AcceptAttachmentID") != null)
                {
                    int attachmentID = Convert.ToInt32(this.gridView.GetFocusedRowCellValue("AcceptAttachmentID"));
                    string fileName = this.gridView.GetFocusedRowCellValue("AttachmentName").ToString();

                    using (FolderBrowserDialog attachmentDownDialog = new FolderBrowserDialog())
                    {
                        if (attachmentDownDialog.ShowDialog(this) == DialogResult.OK)
                        {
                            string fullName = Path.Combine(attachmentDownDialog.SelectedPath, fileName);
                            if (File.Exists(fullName))
                            {
                                DialogResult dr = XtraMessageBox.Show(fullName + "已存在，是否替换？", "系统提示", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                                if (dr == DialogResult.Yes)
                                {
                                    File.Delete(fullName);
                                }
                                else
                                {
                                    return;
                                }
                            }
                            try
                            {
                                SqlDataReader dataReader = null;
                                using (SqlConnection connection = new SqlConnection { ConnectionString = GlobalItem.g_DbConnectStrings })
                                {
                                    using (SqlCommand command = new SqlCommand { Connection = connection })
                                    {
                                        connection.Open();
                                        command.CommandText = "SELECT AttachmentContent FROM BUS_AcceptAttachment WHERE AcceptAttachmentID = " + attachmentID;
                                        dataReader = command.ExecuteReader();
                                        byte[] file = null;

                                        if (dataReader.Read())
                                        {
                                            file = (byte[])dataReader[0];
                                        }
                                        if (dataReader != null)
                                        {
                                            dataReader.Close();
                                        }

                                        connection.Close();

                                        FileStream stream;
                                        FileInfo fInfo = new FileInfo(fullName);
                                        stream = fInfo.OpenWrite();
                                        stream.Write(file, 0, file.Length);
                                        stream.Close();
                                    }
                                }
                            }
                            catch (Exception ex)
                            {
                                throw ex;
                            }
                        }
                    }

                }
                else
                {
                    XtraMessageBox.Show("请先选中一个附件再进行下载。", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                XtraMessageBox.Show("无任何附件可供下载。", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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

        private void PicLoad()
        {
            int AcceptAttachmentID = Convert.ToInt32(gridView.GetDataRow(gridView.FocusedRowHandle)["AcceptAttachmentID"]);
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
            //pictureEdit.Properties.SizeMode = "Zoom";
        }

        private void gridView_Click(object sender, EventArgs e)
        {
            if (gridView.RowCount > 0)
            {
                PicLoad();
            }
        }
    }
}
