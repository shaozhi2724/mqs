namespace DQS.AppViews.WarehouseIn.WarehouseInManager
{
    partial class FrmSingleCondition
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
            this.pnlAction = new DevExpress.XtraEditors.PanelControl();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.ftPanel = new DQS.Controls.FieldTextBoxPanel();
            this.layControl = new DevExpress.XtraLayout.LayoutControl();
            this.txtConditionCode = new DQS.Controls.BUSReceiveAcceptConditionEntityTextBox();
            this.txtConditionName = new DQS.Controls.BUSReceiveAcceptConditionEntityTextBox();
            this.txtConditionRemark = new DQS.Controls.BUSReceiveAcceptConditionEntityTextBox();
            this.txtConditionContent = new DQS.Controls.BUSReceiveAcceptConditionEntityTextBox();
            this.txtConditionTypeName = new DQS.Controls.BUSReceiveAcceptConditionEntityTextBox();
            this.txtConditionMethod = new DQS.Controls.BUSReceiveAcceptConditionEntityTextBox();
            this.layControlGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layConditionCode = new DevExpress.XtraLayout.LayoutControlItem();
            this.layConditionName = new DevExpress.XtraLayout.LayoutControlItem();
            this.layConditionContent = new DevExpress.XtraLayout.LayoutControlItem();
            this.layConditionMethod = new DevExpress.XtraLayout.LayoutControlItem();
            this.layConditionTypeName = new DevExpress.XtraLayout.LayoutControlItem();
            this.layConditionRemark = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.pnlAction)).BeginInit();
            this.pnlAction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ftPanel)).BeginInit();
            this.ftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layControl)).BeginInit();
            this.layControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtConditionCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtConditionName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtConditionRemark.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtConditionContent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtConditionTypeName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtConditionMethod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layControlGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layConditionCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layConditionName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layConditionContent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layConditionMethod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layConditionTypeName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layConditionRemark)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlAction
            // 
            this.pnlAction.Controls.Add(this.btnCancel);
            this.pnlAction.Controls.Add(this.btnSave);
            this.pnlAction.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlAction.Location = new System.Drawing.Point(0, 153);
            this.pnlAction.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlAction.Name = "pnlAction";
            this.pnlAction.Size = new System.Drawing.Size(576, 62);
            this.pnlAction.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Appearance.Options.UseFont = true;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(474, 17);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(86, 30);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "取消(&C)";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.Location = new System.Drawing.Point(354, 17);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(86, 30);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "保存(&S)";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ftPanel
            // 
            this.ftPanel.Controls.Add(this.layControl);
            this.ftPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ftPanel.Location = new System.Drawing.Point(0, 0);
            this.ftPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ftPanel.Name = "ftPanel";
            this.ftPanel.Size = new System.Drawing.Size(576, 215);
            this.ftPanel.TabIndex = 0;
            this.ftPanel.TypeOfEntity = DQS.Module.EntityType2.BUSReceiveAcceptConditionEntity;
            // 
            // layControl
            // 
            this.layControl.Controls.Add(this.txtConditionCode);
            this.layControl.Controls.Add(this.txtConditionName);
            this.layControl.Controls.Add(this.txtConditionRemark);
            this.layControl.Controls.Add(this.txtConditionContent);
            this.layControl.Controls.Add(this.txtConditionTypeName);
            this.layControl.Controls.Add(this.txtConditionMethod);
            this.layControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layControl.Location = new System.Drawing.Point(2, 2);
            this.layControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.layControl.Name = "layControl";
            this.layControl.Root = this.layControlGroup;
            this.layControl.Size = new System.Drawing.Size(572, 211);
            this.layControl.TabIndex = 0;
            this.layControl.Text = "layControl";
            // 
            // txtConditionCode
            // 
            this.txtConditionCode.AlphabeticFiled = null;
            this.txtConditionCode.EntityField = DQS.Module.Entities.BUSReceiveAcceptConditionEntityFields2.ConditionCode;
            this.txtConditionCode.IsIntegerOnly = false;
            this.txtConditionCode.IsNullString = "检查的项目编号不能为空。";
            this.txtConditionCode.IsNullValidate = true;
            this.txtConditionCode.IsTransferAlphabetic = false;
            this.txtConditionCode.Location = new System.Drawing.Point(120, 12);
            this.txtConditionCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtConditionCode.Name = "txtConditionCode";
            this.txtConditionCode.Size = new System.Drawing.Size(164, 25);
            this.txtConditionCode.StyleController = this.layControl;
            this.txtConditionCode.TabIndex = 0;
            // 
            // txtConditionName
            // 
            this.txtConditionName.AlphabeticFiled = null;
            this.txtConditionName.EntityField = DQS.Module.Entities.BUSReceiveAcceptConditionEntityFields2.ConditionName;
            this.txtConditionName.IsIntegerOnly = false;
            this.txtConditionName.IsNullString = "检查的项目名称不能为空。";
            this.txtConditionName.IsNullValidate = true;
            this.txtConditionName.IsTransferAlphabetic = false;
            this.txtConditionName.Location = new System.Drawing.Point(396, 12);
            this.txtConditionName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtConditionName.Name = "txtConditionName";
            this.txtConditionName.Size = new System.Drawing.Size(164, 25);
            this.txtConditionName.StyleController = this.layControl;
            this.txtConditionName.TabIndex = 1;
            // 
            // txtConditionRemark
            // 
            this.txtConditionRemark.AlphabeticFiled = null;
            this.txtConditionRemark.EntityField = DQS.Module.Entities.BUSReceiveAcceptConditionEntityFields2.ConditionRemark;
            this.txtConditionRemark.IsIntegerOnly = false;
            this.txtConditionRemark.IsNullString = null;
            this.txtConditionRemark.IsNullValidate = false;
            this.txtConditionRemark.IsTransferAlphabetic = false;
            this.txtConditionRemark.Location = new System.Drawing.Point(120, 99);
            this.txtConditionRemark.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtConditionRemark.Name = "txtConditionRemark";
            this.txtConditionRemark.Size = new System.Drawing.Size(440, 25);
            this.txtConditionRemark.StyleController = this.layControl;
            this.txtConditionRemark.TabIndex = 5;
            // 
            // txtConditionContent
            // 
            this.txtConditionContent.AlphabeticFiled = null;
            this.txtConditionContent.EntityField = DQS.Module.Entities.BUSReceiveAcceptConditionEntityFields2.ConditionContent;
            this.txtConditionContent.IsIntegerOnly = false;
            this.txtConditionContent.IsNullString = null;
            this.txtConditionContent.IsNullValidate = false;
            this.txtConditionContent.IsTransferAlphabetic = false;
            this.txtConditionContent.Location = new System.Drawing.Point(120, 41);
            this.txtConditionContent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtConditionContent.Name = "txtConditionContent";
            this.txtConditionContent.Size = new System.Drawing.Size(440, 25);
            this.txtConditionContent.StyleController = this.layControl;
            this.txtConditionContent.TabIndex = 2;
            // 
            // txtConditionTypeName
            // 
            this.txtConditionTypeName.AlphabeticFiled = null;
            this.txtConditionTypeName.EntityField = DQS.Module.Entities.BUSReceiveAcceptConditionEntityFields2.ConditionTypeName;
            this.txtConditionTypeName.IsIntegerOnly = false;
            this.txtConditionTypeName.IsNullString = null;
            this.txtConditionTypeName.IsNullValidate = false;
            this.txtConditionTypeName.IsTransferAlphabetic = false;
            this.txtConditionTypeName.Location = new System.Drawing.Point(396, 70);
            this.txtConditionTypeName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtConditionTypeName.Name = "txtConditionTypeName";
            this.txtConditionTypeName.Size = new System.Drawing.Size(164, 25);
            this.txtConditionTypeName.StyleController = this.layControl;
            this.txtConditionTypeName.TabIndex = 4;
            // 
            // txtConditionMethod
            // 
            this.txtConditionMethod.AlphabeticFiled = null;
            this.txtConditionMethod.EntityField = DQS.Module.Entities.BUSReceiveAcceptConditionEntityFields2.ConditionMethod;
            this.txtConditionMethod.IsIntegerOnly = false;
            this.txtConditionMethod.IsNullString = null;
            this.txtConditionMethod.IsNullValidate = false;
            this.txtConditionMethod.IsTransferAlphabetic = false;
            this.txtConditionMethod.Location = new System.Drawing.Point(120, 70);
            this.txtConditionMethod.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtConditionMethod.Name = "txtConditionMethod";
            this.txtConditionMethod.Size = new System.Drawing.Size(164, 25);
            this.txtConditionMethod.StyleController = this.layControl;
            this.txtConditionMethod.TabIndex = 3;
            // 
            // layControlGroup
            // 
            this.layControlGroup.AppearanceItemCaption.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layControlGroup.AppearanceItemCaption.Options.UseFont = true;
            this.layControlGroup.CustomizationFormText = "收货验收情况定义";
            this.layControlGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layControlGroup.GroupBordersVisible = false;
            this.layControlGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layConditionCode,
            this.layConditionName,
            this.layConditionContent,
            this.layConditionMethod,
            this.layConditionTypeName,
            this.layConditionRemark});
            this.layControlGroup.Location = new System.Drawing.Point(0, 0);
            this.layControlGroup.Name = "layControlGroup";
            this.layControlGroup.Size = new System.Drawing.Size(572, 211);
            this.layControlGroup.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layControlGroup.Text = "收货验收情况定义";
            this.layControlGroup.TextVisible = false;
            // 
            // layConditionCode
            // 
            this.layConditionCode.Control = this.txtConditionCode;
            this.layConditionCode.CustomizationFormText = "检查的项目编号";
            this.layConditionCode.Location = new System.Drawing.Point(0, 0);
            this.layConditionCode.Name = "layConditionCode";
            this.layConditionCode.Size = new System.Drawing.Size(276, 29);
            this.layConditionCode.Text = "检查的项目编号";
            this.layConditionCode.TextSize = new System.Drawing.Size(105, 20);
            // 
            // layConditionName
            // 
            this.layConditionName.Control = this.txtConditionName;
            this.layConditionName.CustomizationFormText = "检查的项目名称";
            this.layConditionName.Location = new System.Drawing.Point(276, 0);
            this.layConditionName.Name = "layConditionName";
            this.layConditionName.Size = new System.Drawing.Size(276, 29);
            this.layConditionName.Text = "检查的项目名称";
            this.layConditionName.TextSize = new System.Drawing.Size(105, 20);
            // 
            // layConditionContent
            // 
            this.layConditionContent.Control = this.txtConditionContent;
            this.layConditionContent.CustomizationFormText = "检查的项目内容";
            this.layConditionContent.Location = new System.Drawing.Point(0, 29);
            this.layConditionContent.Name = "layConditionContent";
            this.layConditionContent.Size = new System.Drawing.Size(552, 29);
            this.layConditionContent.Text = "检查的项目内容";
            this.layConditionContent.TextSize = new System.Drawing.Size(105, 20);
            // 
            // layConditionMethod
            // 
            this.layConditionMethod.Control = this.txtConditionMethod;
            this.layConditionMethod.CustomizationFormText = "检查的方式";
            this.layConditionMethod.Location = new System.Drawing.Point(0, 58);
            this.layConditionMethod.Name = "layConditionMethod";
            this.layConditionMethod.Size = new System.Drawing.Size(276, 29);
            this.layConditionMethod.Text = "检查的方式";
            this.layConditionMethod.TextSize = new System.Drawing.Size(105, 20);
            // 
            // layConditionTypeName
            // 
            this.layConditionTypeName.Control = this.txtConditionTypeName;
            this.layConditionTypeName.CustomizationFormText = "检查类型名称";
            this.layConditionTypeName.Location = new System.Drawing.Point(276, 58);
            this.layConditionTypeName.Name = "layConditionTypeName";
            this.layConditionTypeName.Size = new System.Drawing.Size(276, 29);
            this.layConditionTypeName.Text = "检查类型名称";
            this.layConditionTypeName.TextSize = new System.Drawing.Size(105, 20);
            // 
            // layConditionRemark
            // 
            this.layConditionRemark.Control = this.txtConditionRemark;
            this.layConditionRemark.CustomizationFormText = "备注";
            this.layConditionRemark.Location = new System.Drawing.Point(0, 87);
            this.layConditionRemark.Name = "layConditionRemark";
            this.layConditionRemark.Size = new System.Drawing.Size(552, 104);
            this.layConditionRemark.Text = "备注";
            this.layConditionRemark.TextSize = new System.Drawing.Size(105, 20);
            // 
            // FrmSingleCondition
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(576, 215);
            this.Controls.Add(this.pnlAction);
            this.Controls.Add(this.ftPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSingleCondition";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "收货验收情况定义";
            this.Load += new System.EventHandler(this.FrmSingleCondition_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnlAction)).EndInit();
            this.pnlAction.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ftPanel)).EndInit();
            this.ftPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layControl)).EndInit();
            this.layControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtConditionCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtConditionName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtConditionRemark.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtConditionContent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtConditionTypeName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtConditionMethod.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layControlGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layConditionCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layConditionName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layConditionContent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layConditionMethod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layConditionTypeName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layConditionRemark)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DQS.Controls.FieldTextBoxPanel ftPanel;
        private DevExpress.XtraEditors.PanelControl pnlAction;
        private DevExpress.XtraLayout.LayoutControl layControl;
        private DQS.Controls.BUSReceiveAcceptConditionEntityTextBox txtConditionCode;
        private DQS.Controls.BUSReceiveAcceptConditionEntityTextBox txtConditionName;
        private DevExpress.XtraLayout.LayoutControlGroup layControlGroup;
        private DevExpress.XtraLayout.LayoutControlItem layConditionCode;
        private DevExpress.XtraLayout.LayoutControlItem layConditionName;
        private DQS.Controls.BUSReceiveAcceptConditionEntityTextBox txtConditionContent;
        private DQS.Controls.BUSReceiveAcceptConditionEntityTextBox txtConditionMethod;
        private DQS.Controls.BUSReceiveAcceptConditionEntityTextBox txtConditionTypeName;
        private DQS.Controls.BUSReceiveAcceptConditionEntityTextBox txtConditionRemark;
        private DevExpress.XtraLayout.LayoutControlItem layConditionContent;
        private DevExpress.XtraLayout.LayoutControlItem layConditionMethod;
        private DevExpress.XtraLayout.LayoutControlItem layConditionTypeName;
        private DevExpress.XtraLayout.LayoutControlItem layConditionRemark;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnSave;
    }
}