namespace DQS.AppViews.QualityDocument.ProductManager
{
    partial class FrmSinglePriceStyle
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
            this.pnOperating = new DevExpress.XtraEditors.PanelControl();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.pnlCenter = new DevExpress.XtraEditors.PanelControl();
            this.layControl = new DevExpress.XtraLayout.LayoutControl();
            this.txtRemark = new DQS.Controls.TextBoxEx();
            this.txtStyleDescription = new DQS.Controls.TextBoxEx();
            this.txtStyleName = new DQS.Controls.TextBoxEx();
            this.txtStyleID = new DQS.Controls.TextBoxEx();
            this.layControlGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layRemark = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.pnOperating)).BeginInit();
            this.pnOperating.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlCenter)).BeginInit();
            this.pnlCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layControl)).BeginInit();
            this.layControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtRemark.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStyleDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStyleName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStyleID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layControlGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layRemark)).BeginInit();
            this.SuspendLayout();
            // 
            // pnOperating
            // 
            this.pnOperating.Controls.Add(this.btnCancel);
            this.pnOperating.Controls.Add(this.btnSave);
            this.pnOperating.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnOperating.Location = new System.Drawing.Point(0, 161);
            this.pnOperating.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnOperating.Name = "pnOperating";
            this.pnOperating.Size = new System.Drawing.Size(417, 55);
            this.pnOperating.TabIndex = 2;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Appearance.Options.UseFont = true;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(318, 12);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(86, 30);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "取消(&C)";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.Location = new System.Drawing.Point(217, 12);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(86, 30);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "保存(&S)";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlCenter
            // 
            this.pnlCenter.Controls.Add(this.layControl);
            this.pnlCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCenter.Location = new System.Drawing.Point(0, 0);
            this.pnlCenter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlCenter.Name = "pnlCenter";
            this.pnlCenter.Size = new System.Drawing.Size(417, 161);
            this.pnlCenter.TabIndex = 3;
            // 
            // layControl
            // 
            this.layControl.Controls.Add(this.txtRemark);
            this.layControl.Controls.Add(this.txtStyleDescription);
            this.layControl.Controls.Add(this.txtStyleName);
            this.layControl.Controls.Add(this.txtStyleID);
            this.layControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layControl.Location = new System.Drawing.Point(2, 2);
            this.layControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.layControl.Name = "layControl";
            this.layControl.Root = this.layControlGroup;
            this.layControl.Size = new System.Drawing.Size(413, 157);
            this.layControl.TabIndex = 0;
            this.layControl.Text = "layoutControl1";
            // 
            // txtRemark
            // 
            this.txtRemark.AlphabeticFiled = null;
            this.txtRemark.IsIntegerOnly = false;
            this.txtRemark.IsNullString = null;
            this.txtRemark.IsNullValidate = false;
            this.txtRemark.IsTransferAlphabetic = false;
            this.txtRemark.Location = new System.Drawing.Point(75, 99);
            this.txtRemark.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(326, 25);
            this.txtRemark.StyleController = this.layControl;
            this.txtRemark.TabIndex = 7;
            // 
            // txtStyleDescription
            // 
            this.txtStyleDescription.AlphabeticFiled = null;
            this.txtStyleDescription.IsIntegerOnly = false;
            this.txtStyleDescription.IsNullString = null;
            this.txtStyleDescription.IsNullValidate = false;
            this.txtStyleDescription.IsTransferAlphabetic = false;
            this.txtStyleDescription.Location = new System.Drawing.Point(75, 70);
            this.txtStyleDescription.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtStyleDescription.Name = "txtStyleDescription";
            this.txtStyleDescription.Size = new System.Drawing.Size(326, 25);
            this.txtStyleDescription.StyleController = this.layControl;
            this.txtStyleDescription.TabIndex = 6;
            // 
            // txtStyleName
            // 
            this.txtStyleName.AlphabeticFiled = null;
            this.txtStyleName.IsIntegerOnly = false;
            this.txtStyleName.IsNullString = null;
            this.txtStyleName.IsNullValidate = false;
            this.txtStyleName.IsTransferAlphabetic = false;
            this.txtStyleName.Location = new System.Drawing.Point(75, 41);
            this.txtStyleName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtStyleName.Name = "txtStyleName";
            this.txtStyleName.Size = new System.Drawing.Size(326, 25);
            this.txtStyleName.StyleController = this.layControl;
            this.txtStyleName.TabIndex = 5;
            // 
            // txtStyleID
            // 
            this.txtStyleID.AlphabeticFiled = null;
            this.txtStyleID.IsIntegerOnly = false;
            this.txtStyleID.IsNullString = null;
            this.txtStyleID.IsNullValidate = false;
            this.txtStyleID.IsTransferAlphabetic = false;
            this.txtStyleID.Location = new System.Drawing.Point(75, 12);
            this.txtStyleID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtStyleID.Name = "txtStyleID";
            this.txtStyleID.Size = new System.Drawing.Size(326, 25);
            this.txtStyleID.StyleController = this.layControl;
            this.txtStyleID.TabIndex = 4;
            // 
            // layControlGroup
            // 
            this.layControlGroup.CustomizationFormText = "价格分类";
            this.layControlGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layControlGroup.GroupBordersVisible = false;
            this.layControlGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layRemark});
            this.layControlGroup.Location = new System.Drawing.Point(0, 0);
            this.layControlGroup.Name = "layControlGroup";
            this.layControlGroup.Size = new System.Drawing.Size(413, 157);
            this.layControlGroup.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layControlGroup.Text = "价格分类";
            this.layControlGroup.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txtStyleID;
            this.layoutControlItem1.CustomizationFormText = "分类ID";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(393, 29);
            this.layoutControlItem1.Text = "分类ID";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(60, 18);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtStyleName;
            this.layoutControlItem2.CustomizationFormText = "分类名称";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 29);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(393, 29);
            this.layoutControlItem2.Text = "分类名称";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(60, 18);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.txtStyleDescription;
            this.layoutControlItem3.CustomizationFormText = "分类描述";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 58);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(393, 29);
            this.layoutControlItem3.Text = "分类描述";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(60, 18);
            // 
            // layRemark
            // 
            this.layRemark.Control = this.txtRemark;
            this.layRemark.CustomizationFormText = "备注";
            this.layRemark.Location = new System.Drawing.Point(0, 87);
            this.layRemark.Name = "layRemark";
            this.layRemark.Size = new System.Drawing.Size(393, 50);
            this.layRemark.Text = "备注";
            this.layRemark.TextSize = new System.Drawing.Size(60, 18);
            // 
            // FrmSinglePriceStyle
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(417, 216);
            this.Controls.Add(this.pnlCenter);
            this.Controls.Add(this.pnOperating);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmSinglePriceStyle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "价格分类";
            this.Load += new System.EventHandler(this.FrmSinglePriceStyle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnOperating)).EndInit();
            this.pnOperating.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlCenter)).EndInit();
            this.pnlCenter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layControl)).EndInit();
            this.layControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtRemark.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStyleDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStyleName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStyleID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layControlGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layRemark)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pnOperating;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.PanelControl pnlCenter;
        private DevExpress.XtraLayout.LayoutControl layControl;
        private DQS.Controls.TextBoxEx txtStyleID;
        private DevExpress.XtraLayout.LayoutControlGroup layControlGroup;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DQS.Controls.TextBoxEx txtStyleDescription;
        private DQS.Controls.TextBoxEx txtStyleName;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DQS.Controls.TextBoxEx txtRemark;
        private DevExpress.XtraLayout.LayoutControlItem layRemark;
    }
}