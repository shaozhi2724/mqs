using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DQS.Module.Entities;
using DQS.Common;

namespace DQS.Controls
{
    public partial class FrmSingleAttribute : DevExpress.XtraEditors.XtraForm
    {
        private int m_QualificationID;

        public FrmSingleAttribute()
        {
            InitializeComponent();
        }

        public FrmSingleAttribute(int qualificationID)
        {
            InitializeComponent();

            this.m_QualificationID = qualificationID;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ftPanel.ValidateIsNullFields()) return;

            BFIQualificationAttributeEntity entity = this.ftPanel.GetEntity() as BFIQualificationAttributeEntity;

            entity.QualificationID = this.m_QualificationID;

            entity.CreateDate = DateTime.Now;
            entity.LastModifyDate = DateTime.Now;
            entity.CreateUserID = GlobalItem.g_CurrentUser.UserID;
            entity.LastModifyUserID = GlobalItem.g_CurrentUser.UserID;
            entity.Save();

            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}