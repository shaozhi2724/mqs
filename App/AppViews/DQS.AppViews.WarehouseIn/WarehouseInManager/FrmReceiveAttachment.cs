using DevExpress.XtraEditors;
using DQS.Common;
using DQS.Module.Entities;
using System;
using System.IO;
using System.Windows.Forms;

namespace DQS.AppViews.WarehouseIn.WarehouseInManager
{
    public partial class FrmReceiveAttachment : DevExpress.XtraEditors.XtraForm
    {
        private int m_Id;

        private string[] m_ImageType = new string[] { "BMP", "JPG", "GIF", "PNG", "PCX", "DCX", "EMF", "JIF", "JPE", "JFIF", "JPEG", "RLE", "DIB", "PCD", "DXF", "ICO", "WMF", "TIFF", "TGA" };

        public FrmReceiveAttachment()
        {
            InitializeComponent();
        }

        public FrmReceiveAttachment(int id)
        {
            InitializeComponent();

            this.m_Id = id;
        }

        /// <summary>
        /// 绑定附件信息
        /// </summary>
        private void BindAttachment()
        {
            if (m_Id > 0)
            {
                this.gridAttachmentControl.Filter = string.Format("收货ID = {0}", m_Id);
                this.gridAttachmentControl.InitGrid();
            }
        }
        private void FrmReceiveAttachment_Load(object sender, EventArgs e)
        {
            this.BindAttachment();
        }
        private void barBtnUpAttachment_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (m_Id > 0)
            {
                using (OpenFileDialog attachmentUpDialog = new OpenFileDialog())
                {
                    if (attachmentUpDialog.ShowDialog(this) == DialogResult.OK)
                    {
                        string fullName = attachmentUpDialog.FileName;
                        FileInfo file = new FileInfo(fullName);
                        BUSReceiveTemperatureAttachmentEntity attchment = new BUSReceiveTemperatureAttachmentEntity();
                        attchment.AttachmentName = file.Name;
                        attchment.AttachmentSize = GlobalMethod.FormatFileSize(file.Length);
                        attchment.AttachmentType = file.Extension;
                        attchment.CreateDate = DateTime.Now;
                        attchment.ReceiveID = m_Id;

                        attchment.AttachmentContent = File.ReadAllBytes(fullName);

                        using (FrmReceiveAttachmentProgressing frmProgressing = new FrmReceiveAttachmentProgressing(attchment))
                        {
                            frmProgressing.ShowDialog(this);

                            this.BindAttachment();
                        }
                    }
                }
            }
        }

        private void barBtnDownAttachment_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (this.gridAttachmentControl.GridViewData.RowCount > 0)
            {
                if (this.gridAttachmentControl.GridViewData.GetFocusedRowCellValue("附件名称") != null && this.gridAttachmentControl.GridViewData.GetFocusedRowCellValue("附件ID") != null)
                {
                    int attachmentID = Convert.ToInt32(this.gridAttachmentControl.GridViewData.GetFocusedRowCellValue("附件ID"));
                    string fileName = this.gridAttachmentControl.GridViewData.GetFocusedRowCellValue("附件名称").ToString();

                    using (FolderBrowserDialog attachmentDownDialog = new FolderBrowserDialog())
                    {
                        if (attachmentDownDialog.ShowDialog(this) == DialogResult.OK)
                        {
                            string fullName = Path.Combine(attachmentDownDialog.SelectedPath, fileName);
                            if (File.Exists(fullName))
                            {
                                XtraMessageBox.Show(fullName + "已存在，请选择其它目录进行存放。", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                return;
                            }

                            using (FrmReceiveAttachmentProgressing frmProgressing = new FrmReceiveAttachmentProgressing(attachmentID, fullName))
                            {
                                frmProgressing.ShowDialog(this);
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

        private void barBtnPreview_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (this.gridAttachmentControl.GridViewData.RowCount > 0)
            {
                if (this.gridAttachmentControl.GridViewData.GetFocusedRowCellValue("附件名称") != null && this.gridAttachmentControl.GridViewData.GetFocusedRowCellValue("附件ID") != null)
                {
                    int attachmentID = Convert.ToInt32(this.gridAttachmentControl.GridViewData.GetFocusedRowCellValue("附件ID"));
                    string fileName = this.gridAttachmentControl.GridViewData.GetFocusedRowCellValue("附件名称").ToString();

                    string fileType = this.gridAttachmentControl.GridViewData.GetFocusedRowCellValue("类型").ToString();

                    bool isImage = false;
                    foreach (string imageType in m_ImageType)
                    {
                        if (fileType.ToUpper().Contains(imageType))
                        {
                            isImage = true;
                            break;
                        }
                    }

                    if (!isImage)
                    {
                        XtraMessageBox.Show("不支持此附件类型，只能显示图片类型的附件。", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }

                    string tempName = String.Format("TEMP~{0}~{1}", Guid.NewGuid(), fileName);

                    using (FrmReceiveAttachmentPreview frmAttachmentPreview = new FrmReceiveAttachmentPreview(attachmentID, tempName))
                    {
                        frmAttachmentPreview.ShowDialog(this);
                    }
                }
            }
        }

        private void barDeleteAttachment_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            object id = this.gridAttachmentControl.GridViewData.GetFocusedRowCellValue("附件ID");
            if (id != null)
            {
                DialogResult result = XtraMessageBox.Show("确定要删除该记录吗？", "警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {

                    BUSReceiveTemperatureAttachmentEntity entity = new BUSReceiveTemperatureAttachmentEntity { ReceiveTemperatureAttachmentID = Convert.ToInt32(id) };
                    //删除
                    entity.Delete();

                    this.gridAttachmentControl.InitGrid();
                }
            }
        }
    }
}