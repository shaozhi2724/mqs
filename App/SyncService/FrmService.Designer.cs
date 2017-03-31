namespace SyncService
{
    partial class FrmService
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
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnDeserialize = new DevExpress.DXCore.Controls.XtraEditors.SimpleButton();
            this.btnGen = new DevExpress.DXCore.Controls.XtraEditors.SimpleButton();
            this.btnSerilize = new DevExpress.DXCore.Controls.XtraEditors.SimpleButton();
            this.prpXmlObject = new System.Windows.Forms.PropertyGrid();
            this.txtNewXML = new DevExpress.XtraEditors.MemoEdit();
            this.txtOldXML = new DevExpress.XtraEditors.MemoEdit();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.txtDownCon = new DevExpress.XtraEditors.MemoEdit();
            this.btnDown = new DevExpress.XtraEditors.SimpleButton();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNewXML.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOldXML.Properties)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDownCon.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(0, 0);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(711, 463);
            this.tabControl2.TabIndex = 3;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnDeserialize);
            this.tabPage3.Controls.Add(this.btnGen);
            this.tabPage3.Controls.Add(this.btnSerilize);
            this.tabPage3.Controls.Add(this.prpXmlObject);
            this.tabPage3.Controls.Add(this.txtNewXML);
            this.tabPage3.Controls.Add(this.txtOldXML);
            this.tabPage3.Location = new System.Drawing.Point(4, 23);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(703, 436);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "tabPage1";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnDeserialize
            // 
            this.btnDeserialize.Location = new System.Drawing.Point(334, 215);
            this.btnDeserialize.Name = "btnDeserialize";
            this.btnDeserialize.Size = new System.Drawing.Size(75, 32);
            this.btnDeserialize.TabIndex = 5;
            this.btnDeserialize.Text = "反序列化";
            this.btnDeserialize.Click += new System.EventHandler(this.btnDeserialize_Click);
            // 
            // btnGen
            // 
            this.btnGen.Location = new System.Drawing.Point(415, -1);
            this.btnGen.Name = "btnGen";
            this.btnGen.Size = new System.Drawing.Size(75, 32);
            this.btnGen.TabIndex = 6;
            this.btnGen.Text = "生成";
            this.btnGen.Click += new System.EventHandler(this.btnGen_Click);
            // 
            // btnSerilize
            // 
            this.btnSerilize.Location = new System.Drawing.Point(334, -1);
            this.btnSerilize.Name = "btnSerilize";
            this.btnSerilize.Size = new System.Drawing.Size(75, 32);
            this.btnSerilize.TabIndex = 8;
            this.btnSerilize.Text = "序列化";
            this.btnSerilize.Click += new System.EventHandler(this.btnSerilize_Click);
            // 
            // prpXmlObject
            // 
            this.prpXmlObject.Location = new System.Drawing.Point(415, 36);
            this.prpXmlObject.Name = "prpXmlObject";
            this.prpXmlObject.Size = new System.Drawing.Size(284, 392);
            this.prpXmlObject.TabIndex = 3;
            // 
            // txtNewXML
            // 
            this.txtNewXML.Location = new System.Drawing.Point(8, 253);
            this.txtNewXML.Name = "txtNewXML";
            this.txtNewXML.Size = new System.Drawing.Size(401, 175);
            this.txtNewXML.TabIndex = 11;
            // 
            // txtOldXML
            // 
            this.txtOldXML.Location = new System.Drawing.Point(8, 34);
            this.txtOldXML.Name = "txtOldXML";
            this.txtOldXML.Size = new System.Drawing.Size(401, 175);
            this.txtOldXML.TabIndex = 12;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.txtDownCon);
            this.tabPage4.Controls.Add(this.btnDown);
            this.tabPage4.Location = new System.Drawing.Point(4, 23);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(703, 436);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "tabPage2";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // txtDownCon
            // 
            this.txtDownCon.Location = new System.Drawing.Point(6, 45);
            this.txtDownCon.Name = "txtDownCon";
            this.txtDownCon.Size = new System.Drawing.Size(507, 320);
            this.txtDownCon.TabIndex = 13;
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(91, 6);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(75, 23);
            this.btnDown.TabIndex = 0;
            this.btnDown.Text = "下载";
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // FrmService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 463);
            this.Controls.Add(this.tabControl2);
            this.Name = "FrmService";
            this.Text = "FrmService";
            this.Load += new System.EventHandler(this.FrmService_Load);
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtNewXML.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOldXML.Properties)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtDownCon.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private DevExpress.DXCore.Controls.XtraEditors.SimpleButton btnDeserialize;
        private DevExpress.DXCore.Controls.XtraEditors.SimpleButton btnGen;
        private DevExpress.DXCore.Controls.XtraEditors.SimpleButton btnSerilize;
        private System.Windows.Forms.PropertyGrid prpXmlObject;
        private DevExpress.XtraEditors.MemoEdit txtNewXML;
        private DevExpress.XtraEditors.MemoEdit txtOldXML;
        private System.Windows.Forms.TabPage tabPage4;
        private DevExpress.XtraEditors.SimpleButton btnDown;
        private DevExpress.XtraEditors.MemoEdit txtDownCon;


    }
}