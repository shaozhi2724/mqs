namespace DQS.App
{
    partial class FrmCreateXml
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Timer timer;
            this.btnCreate = new DevExpress.XtraEditors.SimpleButton();
            this.txtPath = new DevExpress.XtraEditors.TextEdit();
            this.btnCheckProduct = new DevExpress.XtraEditors.SimpleButton();
            this.btnZoneCheck = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtVersion = new DevExpress.XtraEditors.TextEdit();
            this.txtSenderId = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtReceiverId = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtSoftType = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtSendName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txthour = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtmin = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.txtPath.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVersion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSenderId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReceiverId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoftType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSendName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txthour.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmin.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(263, 306);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(116, 56);
            this.btnCreate.TabIndex = 2;
            this.btnCreate.Text = "生成";
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(194, 56);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(415, 21);
            this.txtPath.TabIndex = 9;
            // 
            // btnCheckProduct
            // 
            this.btnCheckProduct.Location = new System.Drawing.Point(493, 97);
            this.btnCheckProduct.Name = "btnCheckProduct";
            this.btnCheckProduct.Size = new System.Drawing.Size(116, 56);
            this.btnCheckProduct.TabIndex = 2;
            this.btnCheckProduct.Text = "今日匹配药品";
            this.btnCheckProduct.Click += new System.EventHandler(this.btnCheckProduct_Click);
            // 
            // btnZoneCheck
            // 
            this.btnZoneCheck.Location = new System.Drawing.Point(493, 195);
            this.btnZoneCheck.Name = "btnZoneCheck";
            this.btnZoneCheck.Size = new System.Drawing.Size(116, 56);
            this.btnZoneCheck.TabIndex = 2;
            this.btnZoneCheck.Text = "今日匹配区域";
            this.btnZoneCheck.Click += new System.EventHandler(this.btnZoneCheck_Click);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(82, 97);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(96, 14);
            this.labelControl4.TabIndex = 11;
            this.labelControl4.Text = "VERSION(版本)：";
            // 
            // txtVersion
            // 
            this.txtVersion.EditValue = "v1.0";
            this.txtVersion.Location = new System.Drawing.Point(194, 94);
            this.txtVersion.Name = "txtVersion";
            this.txtVersion.Size = new System.Drawing.Size(259, 21);
            this.txtVersion.TabIndex = 10;
            // 
            // txtSenderId
            // 
            this.txtSenderId.EditValue = "1306000096";
            this.txtSenderId.Location = new System.Drawing.Point(194, 132);
            this.txtSenderId.Name = "txtSenderId";
            this.txtSenderId.Size = new System.Drawing.Size(259, 21);
            this.txtSenderId.TabIndex = 10;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(45, 135);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(133, 14);
            this.labelControl1.TabIndex = 11;
            this.labelControl1.Text = "SENDER_ID(单位编码)：";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(118, 59);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(60, 14);
            this.labelControl2.TabIndex = 11;
            this.labelControl2.Text = "生成路径：";
            // 
            // txtReceiverId
            // 
            this.txtReceiverId.EditValue = "1300000000";
            this.txtReceiverId.Location = new System.Drawing.Point(194, 170);
            this.txtReceiverId.Name = "txtReceiverId";
            this.txtReceiverId.Size = new System.Drawing.Size(259, 21);
            this.txtReceiverId.TabIndex = 10;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(47, 173);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(131, 14);
            this.labelControl3.TabIndex = 11;
            this.labelControl3.Text = "RECEIVER_ID(接收ID)：";
            // 
            // txtSoftType
            // 
            this.txtSoftType.EditValue = "1";
            this.txtSoftType.Location = new System.Drawing.Point(194, 208);
            this.txtSoftType.Name = "txtSoftType";
            this.txtSoftType.Size = new System.Drawing.Size(259, 21);
            this.txtSoftType.TabIndex = 10;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(48, 211);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(130, 14);
            this.labelControl5.TabIndex = 11;
            this.labelControl5.Text = "SOFTTYPE(消息类型)：";
            // 
            // txtSendName
            // 
            this.txtSendName.EditValue = "河北烨弘医药贸易有限公司";
            this.txtSendName.Location = new System.Drawing.Point(194, 246);
            this.txtSendName.Name = "txtSendName";
            this.txtSendName.Size = new System.Drawing.Size(259, 21);
            this.txtSendName.TabIndex = 10;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(32, 249);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(146, 14);
            this.labelControl6.TabIndex = 11;
            this.labelControl6.Text = "SENDERNAME(单位名称)：";
            // 
            // timer
            // 
            timer.Enabled = true;
            timer.Interval = 60000;
            timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // txthour
            // 
            this.txthour.EditValue = "6";
            this.txthour.Location = new System.Drawing.Point(458, 341);
            this.txthour.Name = "txthour";
            this.txthour.Size = new System.Drawing.Size(52, 21);
            this.txthour.TabIndex = 10;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(458, 306);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(52, 14);
            this.labelControl7.TabIndex = 11;
            this.labelControl7.Text = "定时执行:";
            // 
            // txtmin
            // 
            this.txtmin.EditValue = "15";
            this.txtmin.Location = new System.Drawing.Point(537, 341);
            this.txtmin.Name = "txtmin";
            this.txtmin.Size = new System.Drawing.Size(52, 21);
            this.txtmin.TabIndex = 10;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(516, 344);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(12, 14);
            this.labelControl8.TabIndex = 11;
            this.labelControl8.Text = "时";
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(595, 344);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(12, 14);
            this.labelControl9.TabIndex = 11;
            this.labelControl9.Text = "分";
            // 
            // FrmCreateXml
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 421);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtmin);
            this.Controls.Add(this.txthour);
            this.Controls.Add(this.txtSendName);
            this.Controls.Add(this.txtSoftType);
            this.Controls.Add(this.txtReceiverId);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtSenderId);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.txtVersion);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.btnZoneCheck);
            this.Controls.Add(this.btnCheckProduct);
            this.Controls.Add(this.btnCreate);
            this.Name = "FrmCreateXml";
            this.Text = "FrmCreateXml";
            ((System.ComponentModel.ISupportInitialize)(this.txtPath.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVersion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSenderId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReceiverId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoftType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSendName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txthour.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmin.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnCreate;
        private DevExpress.XtraEditors.TextEdit txtPath;
        private DevExpress.XtraEditors.SimpleButton btnCheckProduct;
        private DevExpress.XtraEditors.SimpleButton btnZoneCheck;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtVersion;
        private DevExpress.XtraEditors.TextEdit txtSenderId;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtReceiverId;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtSoftType;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtSendName;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txthour;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txtmin;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl9;
    }
}