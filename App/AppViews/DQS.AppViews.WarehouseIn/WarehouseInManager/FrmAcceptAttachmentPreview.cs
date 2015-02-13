using DQS.Common;
using System;
using System.Drawing;
using System.IO;

namespace DQS.AppViews.WarehouseIn.WarehouseInManager
{
    public partial class FrmAcceptAttachmentPreview : DevExpress.XtraEditors.XtraForm
    {
        private int m_Id;
        private string m_TempName;

        public FrmAcceptAttachmentPreview()
        {
            InitializeComponent();
        }

        public FrmAcceptAttachmentPreview(int id, string tempName)
        {
            InitializeComponent();

            this.m_Id = id;
            this.m_TempName = tempName;
        }

        private void FrmAcceptAttachmentPreview_Load(object sender, EventArgs e)
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "TEMP");
            if (!Directory.Exists(filePath))
            { 
                Directory.CreateDirectory(filePath); 
            }
            string fileFullPath = Path.Combine(filePath, this.m_TempName);

            GlobalMethod.DownAttachment("BUS_AcceptAttachment", "AttachmentContent", "AcceptAttachmentID", this.m_Id, fileFullPath);
            this.picAttachment.Image = Image.FromFile(fileFullPath);
        }
    }
}