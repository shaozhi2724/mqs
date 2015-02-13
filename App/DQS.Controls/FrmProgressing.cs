﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Threading;
using DQS.Module.Entities;
using DQS.Common;

namespace DQS.Controls
{
    public partial class FrmProgressing : DevExpress.XtraEditors.XtraForm
    {
        private string _suffix = string.Empty;
        private BFIQualificationAttachmentEntity _attachment;
        private Thread _thread;
        private bool _flag;

        private int _attachmentID;
        private string _fullName;

        public FrmProgressing(BFIQualificationAttachmentEntity attachment)
        {
            InitializeComponent();

            this.lblProgressing.Text = "正在上传附件";
            this._attachment = attachment;
        }

        public FrmProgressing(int attachmentID, string fullName)
        {
            InitializeComponent();

            this.lblProgressing.Text = "正在下载附件";
            this._attachmentID = attachmentID;
            this._fullName = fullName;
        }

        private void timer_Tick(object sender, EventArgs e)
        {

            if (this._flag)
            {
                this.Close();
            }

            switch (_suffix.Length)
            {
                case 0:
                    _suffix = ".";
                    break;
                case 1:
                    _suffix = "..";
                    break;
                case 2:
                    _suffix = "...";
                    break;
                case 3:
                    _suffix = "";
                    break;
                default:
                    _suffix = "";
                    break;
            }
            this.lblProgressing.Text = this.lblProgressing.Text.Trim('.') + _suffix;
        }

        private void FrmProgressing_Load(object sender, EventArgs e)
        {
            if (this._attachment != null)
            {
                this._thread = new Thread(DoSave);

            }
            else
            {
                this._thread = new Thread(DoDownload);
            }
            this._thread.Start();
        }

        private void DoSave()
        {
            try
            {
                this._attachment.Save();
                this._flag = true;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("上传附件发生错误：\r\n" + ex.Message, "系统错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this._flag = true;
            }
        }

        private void DoDownload()
        {
            try
            {
                GlobalMethod.DownAttachment(this._attachmentID, this._fullName);
                this._flag = true;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("下载附件发生错误：\r\n" + ex.Message, "系统错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this._flag = true;
            }
        }
    }
}