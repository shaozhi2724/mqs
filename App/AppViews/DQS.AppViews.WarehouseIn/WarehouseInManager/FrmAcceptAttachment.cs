using DevExpress.XtraEditors;
using DQS.Common;
using DQS.Module.Entities;
using System;
using System.IO;
using System.Windows.Forms;

namespace DQS.AppViews.WarehouseIn.WarehouseInManager
{
    public partial class FrmAcceptAttachment : DevExpress.XtraEditors.XtraForm
    {
        private int m_Id;

        private string[] m_ImageType = new string[] { "BMP", "JPG", "GIF", "PNG", "PCX", "DCX", "EMF", "JIF", "JPE", "JFIF", "JPEG", "RLE", "DIB", "PCD", "DXF", "ICO", "WMF", "TIFF", "TGA" };

        public FrmAcceptAttachment()
        {
            InitializeComponent();
        }

        public FrmAcceptAttachment(int id)
        {
            InitializeComponent();

            this.m_Id = id;
            this.gridAcceptDetailControl.GridViewData.FocusedRowChanged += AcceptDetail_FocusedRowChanged;
        }

        //选中行发生变化,重新加载附件和属性
        private void AcceptDetail_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            this.BindAttachment();
        }
        /// <summary>
        /// 绑定附件信息
        /// </summary>
        private void BindAcceptDetails()
        {
            if (m_Id > 0)
            {
                this.gridAcceptDetailControl.Filter = string.Format("验收单ID = {0}", m_Id);
                this.gridAcceptDetailControl.InitGrid();
            }
        }
        /// <summary>
        /// 绑定附件信息
        /// </summary>
        private void BindAttachment()
        {
            object productid = this.gridAcceptDetailControl.GridViewData.GetFocusedRowCellValue("药品ID");
            object batchno = this.gridAcceptDetailControl.GridViewData.GetFocusedRowCellValue("批号");
            if (m_Id > 0 && productid != null && productid != DBNull.Value
                && batchno != null && batchno != DBNull.Value)
            {
                this.gridAttachmentControl.Filter = string.Format("验收ID = {0} AND 药品ID={1} AND 批号='{2}'", m_Id, Convert.ToInt32(productid), Convert.ToString(batchno));
                this.gridAttachmentControl.InitGrid();
            }
        }
        private void FrmAcceptAttachment_Load(object sender, EventArgs e)
        {
            BindAcceptDetails();
            BindAttachment();
        }
        private void barBtnUpAttachment_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            object productid = this.gridAcceptDetailControl.GridViewData.GetFocusedRowCellValue("药品ID");
            object batchno = this.gridAcceptDetailControl.GridViewData.GetFocusedRowCellValue("批号");
            if (m_Id > 0 && productid != null && productid != DBNull.Value
                && batchno != null && batchno != DBNull.Value)
            {
                using (OpenFileDialog attachmentUpDialog = new OpenFileDialog())
                {
                    if (attachmentUpDialog.ShowDialog(this) == DialogResult.OK)
                    {
                        string fullName = attachmentUpDialog.FileName;
                        FileInfo file = new FileInfo(fullName);
                        BUSAcceptAttachmentEntity attchment = new BUSAcceptAttachmentEntity();
                        attchment.ProductID = Convert.ToInt32(productid);
                        attchment.BatchNo = Convert.ToString(batchno);
                        attchment.AttachmentName = file.Name;
                        attchment.AttachmentSize = GlobalMethod.FormatFileSize(file.Length);
                        attchment.AttachmentType = file.Extension;
                        attchment.CreateDate = DateTime.Now;
                        attchment.AcceptID = m_Id;

                        attchment.AttachmentContent = File.ReadAllBytes(fullName);

                        using (FrmAcceptAttachmentProgressing frmProgressing = new FrmAcceptAttachmentProgressing(attchment))
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

                            using (FrmAcceptAttachmentProgressing frmProgressing = new FrmAcceptAttachmentProgressing(attachmentID, fullName))
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

                    using (FrmAcceptAttachmentPreview frmAttachmentPreview = new FrmAcceptAttachmentPreview(attachmentID, tempName))
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

                    BUSAcceptAttachmentEntity entity = new BUSAcceptAttachmentEntity { AcceptAttachmentID = Convert.ToInt32(id) };
                    //删除
                    entity.Delete();

                    this.gridAttachmentControl.InitGrid();
                }
            }
        }
    }
}