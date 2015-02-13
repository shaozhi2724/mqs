using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DQS.Common;
using System.IO;

namespace DQS.Controls
{
    public partial class FrmAttachmentPreview : DevExpress.XtraEditors.XtraForm
    {
        private int m_Id;
        private string m_TempName;

        public FrmAttachmentPreview()
        {
            InitializeComponent();
        }

        public FrmAttachmentPreview(int id, string tempName)
        {
            InitializeComponent();

            this.m_Id = id;
            this.m_TempName = tempName;
        }

        private void FrmAttachmentPreview_Load(object sender, EventArgs e)
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "TEMP");
            if (!Directory.Exists(filePath))
            { 
                Directory.CreateDirectory(filePath); 
            }
            string fileFullPath = Path.Combine(filePath, this.m_TempName);
            GlobalMethod.DownAttachment(this.m_Id, fileFullPath);
            this.picAttachment.Image = Image.FromFile(fileFullPath);
        }
    }
}