using DevExpress.XtraEditors;
using DQS.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DQS.AppViews.QualityDocument.EnterpriseManager
{
    public partial class FrmEnterpriseAttachmentPreview : XtraForm
    {
        private int m_Id;
        private string m_TempName;

        public FrmEnterpriseAttachmentPreview()
        {
            InitializeComponent();
        }

        public FrmEnterpriseAttachmentPreview(int id, string tempName)
        {
            InitializeComponent();

            this.m_Id = id;
            this.m_TempName = tempName;
        }

        private void FrmEnterpriseAttachmentPreview_Load(object sender, EventArgs e)
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "TEMP");
            if (!Directory.Exists(filePath))
            { 
                Directory.CreateDirectory(filePath); 
            }
            string fileFullPath = Path.Combine(filePath, this.m_TempName);

            GlobalMethod.DownAttachment("BFI_EnterpriseAttachment", "AttachmentContent", "EnterpriseAttachmentID", this.m_Id, fileFullPath);
            this.picAttachment.Image = Image.FromFile(fileFullPath);
            //this.Height = picAttachment.Image.Height;
            //this.Width = picAttachment.Image.Width;
        }
    }
}
