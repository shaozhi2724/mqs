using DQS.Common;
using System;
using System.Drawing;
using System.IO;

namespace DQS.AppViews.WarehouseIn.WarehouseInManager
{
    public partial class FrmReceiveAttachmentPreview : DevExpress.XtraEditors.XtraForm
    {
        private int m_Id;
        private string m_TempName;

        public FrmReceiveAttachmentPreview()
        {
            InitializeComponent();
        }

        public FrmReceiveAttachmentPreview(int id, string tempName)
        {
            InitializeComponent();

            this.m_Id = id;
            this.m_TempName = tempName;
        }

        private void FrmReceiveAttachmentPreview_Load(object sender, EventArgs e)
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "TEMP");
            if (!Directory.Exists(filePath))
            { 
                Directory.CreateDirectory(filePath); 
            }
            string fileFullPath = Path.Combine(filePath, this.m_TempName);

            GlobalMethod.DownAttachment("BUS_ReceiveTemperatureAttachment", "AttachmentContent", "ReceiveTemperatureAttachmentID",this.m_Id, fileFullPath);
            this.picAttachment.Image = Image.FromFile(fileFullPath);
        }
    }
}