using DQS.Common;
using System;
using System.Drawing;
using System.IO;

namespace DQS.AppViews.WarehouseOut.WarehouseOutManager
{
    public partial class FrmTransportAttachmentPreview : DevExpress.XtraEditors.XtraForm
    {
        private int m_Id;
        private string m_TempName;

        public FrmTransportAttachmentPreview()
        {
            InitializeComponent();
        }

        public FrmTransportAttachmentPreview(int id, string tempName)
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

            GlobalMethod.DownAttachment("BUS_TransportTemperatureAttachment", "AttachmentContent", "TransportTemperatureAttachmentID",this.m_Id, fileFullPath);
            this.picAttachment.Image = Image.FromFile(fileFullPath);
        }
    }
}