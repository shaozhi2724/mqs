﻿using DevExpress.XtraEditors;
using DQS.Common;
using DQS.Module.Entities;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
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
            object productid = this.gridAcceptDetailControl.GridViewData.GetFocusedRowCellValue("产品ID");
            object batchno = this.gridAcceptDetailControl.GridViewData.GetFocusedRowCellValue("批号");
            if (m_Id > 0 && productid != null && productid != DBNull.Value
                && batchno != null && batchno != DBNull.Value)
            {
                this.gridAttachmentControl.Filter = string.Format("验收ID = {0} AND 产品ID={1} AND 批号='{2}'", m_Id, Convert.ToInt32(productid), Convert.ToString(batchno));
                this.gridAttachmentControl.InitGrid();
            }
        }
        private void FrmAcceptAttachment_Load(object sender, EventArgs e)
        {
            BindAcceptDetails();
            BindAttachment();
        }
        #region GetPicThumbnail
        /// <summary>
        /// 无损压缩图片
        /// </summary>
        /// <param name="sFile">原图片</param>
        /// <param name="dFile">压缩后保存位置</param>
        /// <param name="dHeight">高度</param>
        /// <param name="dWidth"></param>
        /// <param name="flag">压缩质量 1-100</param>
        /// <returns></returns>

        public bool GetPicThumbnail(string sFile, string fileName)
        {
            string dFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory + "TempUp", fileName);
            System.Drawing.Image iSource = System.Drawing.Image.FromFile(sFile);
            //MessageBox.Show(iSource.Size.ToString());
            ImageFormat tFormat = iSource.RawFormat;
            int dHeight = iSource.Height;
            int dWidth = iSource.Width;
            int sW = 0, sH = 0;
            //按比例缩放
            Size tem_size = new Size(iSource.Width, iSource.Height);
            if (tem_size.Width > dHeight || tem_size.Width > dWidth) //将**改成c#中的或者操作符号
            {
                if ((tem_size.Width * dHeight) > (tem_size.Height * dWidth))
                {
                    sW = dWidth;
                    sH = (dWidth * tem_size.Height) / tem_size.Width;
                }
                else
                {
                    sH = dHeight;
                    sW = (tem_size.Width * dHeight) / tem_size.Height;
                }
            }
            else
            {
                sW = tem_size.Width;
                sH = tem_size.Height;
            }
            Bitmap ob = new Bitmap(dWidth, dHeight);
            Graphics g = Graphics.FromImage(ob);
            g.Clear(Color.WhiteSmoke);
            g.CompositingQuality = CompositingQuality.HighQuality;
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            g.DrawImage(iSource, new Rectangle((dWidth - sW) / 2, (dHeight - sH) / 2, sW, sH), 0, 0, iSource.Width, iSource.Height, GraphicsUnit.Pixel);
            g.Dispose();
            //以下代码为保存图片时，设置压缩质量
            EncoderParameters ep = new EncoderParameters();
            long[] qy = new long[1];
            qy[0] = 50;//设置压缩的比例1-100
            EncoderParameter eParam = new EncoderParameter(System.Drawing.Imaging.Encoder.Quality, qy);
            ep.Param[0] = eParam;
            try
            {
                ImageCodecInfo[] arrayICI = ImageCodecInfo.GetImageEncoders();
                ImageCodecInfo jpegICIinfo = null;
                for (int x = 0; x < arrayICI.Length; x++)
                {
                    if (arrayICI[x].FormatDescription.Equals("JPEG"))
                    {
                        jpegICIinfo = arrayICI[x];
                        break;
                    }
                }
                if (jpegICIinfo != null)
                {
                    ob.Save(dFile, jpegICIinfo, ep);//dFile是压缩后的新路径
                }
                else
                {
                    ob.Save(dFile, tFormat);
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                iSource.Dispose();
                ob.Dispose();
            }
        }
        #endregion
        private void barBtnUpAttachment_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            object productid = this.gridAcceptDetailControl.GridViewData.GetFocusedRowCellValue("产品ID");
            object batchno = this.gridAcceptDetailControl.GridViewData.GetFocusedRowCellValue("批号");
            if (m_Id > 0 && productid != null && productid != DBNull.Value
                && batchno != null && batchno != DBNull.Value)
            {
                using (OpenFileDialog attachmentUpDialog = new OpenFileDialog())
                {
                    if (attachmentUpDialog.ShowDialog(this) == DialogResult.OK)
                    {
                        string fullName = attachmentUpDialog.FileName;

                        //压缩
                        string fileName = attachmentUpDialog.SafeFileName;
                        string dFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory + "TempUp", fileName);
                        //如果目录不存在，新建
                        if (!Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + "TempUp"))
                        {
                            Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + "TempUp");
                        }
                        //如果图片名称存在，删除
                        if (File.Exists(dFile))
                        {
                            File.Delete(dFile);
                        }
                        FileInfo file = new FileInfo(GetPicThumbnail(fullName, dFile) ? dFile : fullName);

                        BUSAcceptAttachmentEntity attchment = new BUSAcceptAttachmentEntity();
                        attchment.ProductID = Convert.ToInt32(productid);
                        attchment.BatchNo = Convert.ToString(batchno);
                        attchment.AttachmentName = file.Name;
                        attchment.AttachmentSize = GlobalMethod.FormatFileSize(file.Length);
                        attchment.AttachmentType = file.Extension;
                        attchment.CreateDate = DateTime.Now;
                        attchment.AcceptID = m_Id;

                        attchment.AttachmentContent = File.ReadAllBytes(file.FullName);

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