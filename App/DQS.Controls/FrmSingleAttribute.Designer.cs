namespace DQS.Controls
{
    partial class FrmSingleAttribute
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
            this.ftPanel = new DQS.Controls.FieldTextBoxPanel();
            this.layData = new DevExpress.XtraLayout.LayoutControl();
            this.txtAttributeValue = new DQS.Controls.BFIQualificationAttributeEntityTextBox();
            this.txtAttributeName = new DQS.Controls.BFIQualificationAttributeEntityTextBox();
            this.layControlGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layAttributeName = new DevExpress.XtraLayout.LayoutControlItem();
            this.layAttributeValue = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.pnOperating)).BeginInit();
            this.pnOperating.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ftPanel)).BeginInit();
            this.ftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layData)).BeginInit();
            this.layData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAttributeValue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAttributeName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layControlGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layAttributeName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layAttributeValue)).BeginInit();
            this.SuspendLayout();
            // 
            // pnOperating
            // 
            this.pnOperating.Controls.Add(this.btnCancel);
            this.pnOperating.Controls.Add(this.btnSave);
            this.pnOperating.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnOperating.Location = new System.Drawing.Point(0, 90);
            this.pnOperating.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnOperating.Name = "pnOperating";
            this.pnOperating.Size = new System.Drawing.Size(374, 55);
            this.pnOperating.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Appearance.Options.UseFont = true;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(274, 12);
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
            this.btnSave.Location = new System.Drawing.Point(174, 12);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(86, 30);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "保存(&S)";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ftPanel
            // 
            this.ftPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.ftPanel.Controls.Add(this.layData);
            this.ftPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ftPanel.Location = new System.Drawing.Point(0, 0);
            this.ftPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ftPanel.Name = "ftPanel";
            this.ftPanel.Size = new System.Drawing.Size(374, 90);
            this.ftPanel.TabIndex = 0;
            this.ftPanel.TypeOfEntity = DQS.Module.EntityType2.BFIQualificationAttributeEntity;
            // 
            // layData
            // 
            this.layData.Controls.Add(this.txtAttributeValue);
            this.layData.Controls.Add(this.txtAttributeName);
            this.layData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layData.Location = new System.Drawing.Point(0, 0);
            this.layData.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.layData.Name = "layData";
            this.layData.Root = this.layControlGroup;
            this.layData.Size = new System.Drawing.Size(374, 90);
            this.layData.TabIndex = 0;
            this.layData.Text = "layControl";
            // 
            // txtAttributeValue
            // 
            this.txtAttributeValue.AlphabeticFiled = null;
            this.txtAttributeValue.EntityField = DQS.Module.Entities.BFIQualificationAttributeEntityFields2.AttributeValue;
            this.txtAttributeValue.IsIntegerOnly = false;
            this.txtAttributeValue.IsNullString = null;
            this.txtAttributeValue.IsNullValidate = false;
            this.txtAttributeValue.IsTransferAlphabetic = false;
            this.txtAttributeValue.Location = new System.Drawing.Point(75, 41);
            this.txtAttributeValue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAttributeValue.Name = "txtAttributeValue";
            this.txtAttributeValue.Size = new System.Drawing.Size(287, 25);
            this.txtAttributeValue.StyleController = this.layData;
            this.txtAttributeValue.TabIndex = 4;
            // 
            // txtAttributeName
            // 
            this.txtAttributeName.AlphabeticFiled = null;
            this.txtAttributeName.EntityField = DQS.Module.Entities.BFIQualificationAttributeEntityFields2.AttributeName;
            this.txtAttributeName.IsIntegerOnly = false;
            this.txtAttributeName.IsNullString = null;
            this.txtAttributeName.IsNullValidate = false;
            this.txtAttributeName.IsTransferAlphabetic = false;
            this.txtAttributeName.Location = new System.Drawing.Point(75, 12);
            this.txtAttributeName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAttributeName.Name = "txtAttributeName";
            this.txtAttributeName.Size = new System.Drawing.Size(287, 25);
            this.txtAttributeName.StyleController = this.layData;
            this.txtAttributeName.TabIndex = 2;
            // 
            // layControlGroup
            // 
            this.layControlGroup.AppearanceItemCaption.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layControlGroup.AppearanceItemCaption.Options.UseFont = true;
            this.layControlGroup.CustomizationFormText = "属性信息";
            this.layControlGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layControlGroup.GroupBordersVisible = false;
            this.layControlGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layAttributeName,
            this.layAttributeValue});
            this.layControlGroup.Location = new System.Drawing.Point(0, 0);
            this.layControlGroup.Name = "layControlGroup";
            this.layControlGroup.Size = new System.Drawing.Size(374, 90);
            this.layControlGroup.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layControlGroup.Text = "属性信息";
            this.layControlGroup.TextVisible = false;
            // 
            // layAttributeName
            // 
            this.layAttributeName.Control = this.txtAttributeName;
            this.layAttributeName.CustomizationFormText = "属性名称";
            this.layAttributeName.Location = new System.Drawing.Point(0, 0);
            this.layAttributeName.Name = "layAttributeName";
            this.layAttributeName.Size = new System.Drawing.Size(354, 29);
            this.layAttributeName.Text = "属性名称";
            this.layAttributeName.TextSize = new System.Drawing.Size(60, 20);
            // 
            // layAttributeValue
            // 
            this.layAttributeValue.Control = this.txtAttributeValue;
            this.layAttributeValue.CustomizationFormText = "属性内容";
            this.layAttributeValue.Location = new System.Drawing.Point(0, 29);
            this.layAttributeValue.Name = "layAttributeValue";
            this.layAttributeValue.Size = new System.Drawing.Size(354, 41);
            this.layAttributeValue.Text = "属性内容";
            this.layAttributeValue.TextSize = new System.Drawing.Size(60, 20);
            // 
            // FrmSingleAttribute
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(374, 145);
            this.Controls.Add(this.ftPanel);
            this.Controls.Add(this.pnOperating);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSingleAttribute";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "属性信息";
            ((System.ComponentModel.ISupportInitialize)(this.pnOperating)).EndInit();
            this.pnOperating.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ftPanel)).EndInit();
            this.ftPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layData)).EndInit();
            this.layData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtAttributeValue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAttributeName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layControlGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layAttributeName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layAttributeValue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pnOperating;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DQS.Controls.FieldTextBoxPanel ftPanel;
        private DevExpress.XtraLayout.LayoutControl layData;
        private DevExpress.XtraLayout.LayoutControlGroup layControlGroup;
        private BFIQualificationAttributeEntityTextBox txtAttributeValue;
        private BFIQualificationAttributeEntityTextBox txtAttributeName;
        private DevExpress.XtraLayout.LayoutControlItem layAttributeName;
        private DevExpress.XtraLayout.LayoutControlItem layAttributeValue;
    }
}