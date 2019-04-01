namespace DQS.AppViews.QualityDocument.DealerManager
{
    partial class FrmSingleFirstDealerChange
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
            this.ftPanel = new DQS.Controls.FieldTextBoxPanel();
            this.layControl = new DevExpress.XtraLayout.LayoutControl();
            this.txtRequestPerson = new DQS.Controls.TextBoxEx();
            this.txtDealerCode = new DQS.Controls.TextBoxEx();
            this.txtCreateDate = new DQS.Controls.TextBoxEx();
            this.txtDealerName = new DQS.Controls.TextBoxEx();
            this.layControlGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layDealerName = new DevExpress.XtraLayout.LayoutControlItem();
            this.layRequestPerson = new DevExpress.XtraLayout.LayoutControlItem();
            this.layDealerCode = new DevExpress.XtraLayout.LayoutControlItem();
            this.layCreateDate = new DevExpress.XtraLayout.LayoutControlItem();
            this.pnlAction = new DevExpress.XtraEditors.PanelControl();
            this.btnDealerInfo = new DevExpress.XtraEditors.SimpleButton();
            this.btnDeny = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnAccept = new DevExpress.XtraEditors.SimpleButton();
            this.gpcButtom = new DevExpress.XtraEditors.GroupControl();
            this.popupGrid = new DQS.Controls.PopupGrid();
            this.splitterControl1 = new DevExpress.XtraEditors.SplitterControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.popupGrid1 = new DQS.Controls.PopupGrid();
            this.txtReason = new DQS.Controls.TextBoxEx();
            this.layReason = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.ftPanel)).BeginInit();
            this.ftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layControl)).BeginInit();
            this.layControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtRequestPerson.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDealerCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCreateDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDealerName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layControlGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layDealerName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layRequestPerson)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layDealerCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layCreateDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlAction)).BeginInit();
            this.pnlAction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gpcButtom)).BeginInit();
            this.gpcButtom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.popupGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.popupGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReason.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layReason)).BeginInit();
            this.SuspendLayout();
            // 
            // ftPanel
            // 
            this.ftPanel.Controls.Add(this.layControl);
            this.ftPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ftPanel.Location = new System.Drawing.Point(0, 0);
            this.ftPanel.Name = "ftPanel";
            this.ftPanel.Size = new System.Drawing.Size(859, 92);
            this.ftPanel.TabIndex = 0;
            this.ftPanel.TypeOfEntity = DQS.Module.EntityType2.BUSReceiveEntity;
            // 
            // layControl
            // 
            this.layControl.Controls.Add(this.txtReason);
            this.layControl.Controls.Add(this.txtRequestPerson);
            this.layControl.Controls.Add(this.txtDealerCode);
            this.layControl.Controls.Add(this.txtCreateDate);
            this.layControl.Controls.Add(this.txtDealerName);
            this.layControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layControl.Location = new System.Drawing.Point(2, 2);
            this.layControl.Name = "layControl";
            this.layControl.Root = this.layControlGroup;
            this.layControl.Size = new System.Drawing.Size(855, 88);
            this.layControl.TabIndex = 0;
            this.layControl.Text = "layControl";
            // 
            // txtRequestPerson
            // 
            this.txtRequestPerson.AlphabeticFiled = null;
            this.txtRequestPerson.IsIntegerOnly = false;
            this.txtRequestPerson.IsNullString = null;
            this.txtRequestPerson.IsNullValidate = false;
            this.txtRequestPerson.IsTransferAlphabetic = true;
            this.txtRequestPerson.Location = new System.Drawing.Point(63, 37);
            this.txtRequestPerson.Name = "txtRequestPerson";
            this.txtRequestPerson.Properties.ReadOnly = true;
            this.txtRequestPerson.Size = new System.Drawing.Size(345, 21);
            this.txtRequestPerson.StyleController = this.layControl;
            this.txtRequestPerson.TabIndex = 8;
            // 
            // txtDealerCode
            // 
            this.txtDealerCode.AlphabeticFiled = null;
            this.txtDealerCode.IsIntegerOnly = false;
            this.txtDealerCode.IsNullString = null;
            this.txtDealerCode.IsNullValidate = false;
            this.txtDealerCode.IsTransferAlphabetic = false;
            this.txtDealerCode.Location = new System.Drawing.Point(463, 12);
            this.txtDealerCode.Name = "txtDealerCode";
            this.txtDealerCode.Properties.ReadOnly = true;
            this.txtDealerCode.Size = new System.Drawing.Size(363, 21);
            this.txtDealerCode.StyleController = this.layControl;
            this.txtDealerCode.TabIndex = 6;
            // 
            // txtCreateDate
            // 
            this.txtCreateDate.AlphabeticFiled = "";
            this.txtCreateDate.IsIntegerOnly = false;
            this.txtCreateDate.IsNullString = null;
            this.txtCreateDate.IsNullValidate = false;
            this.txtCreateDate.IsTransferAlphabetic = false;
            this.txtCreateDate.Location = new System.Drawing.Point(463, 37);
            this.txtCreateDate.Name = "txtCreateDate";
            this.txtCreateDate.Properties.ReadOnly = true;
            this.txtCreateDate.Size = new System.Drawing.Size(363, 21);
            this.txtCreateDate.StyleController = this.layControl;
            this.txtCreateDate.TabIndex = 7;
            // 
            // txtDealerName
            // 
            this.txtDealerName.AlphabeticFiled = null;
            this.txtDealerName.IsIntegerOnly = false;
            this.txtDealerName.IsNullString = null;
            this.txtDealerName.IsNullValidate = false;
            this.txtDealerName.IsTransferAlphabetic = false;
            this.txtDealerName.Location = new System.Drawing.Point(63, 12);
            this.txtDealerName.Name = "txtDealerName";
            this.txtDealerName.Properties.ReadOnly = true;
            this.txtDealerName.Size = new System.Drawing.Size(345, 21);
            this.txtDealerName.StyleController = this.layControl;
            this.txtDealerName.TabIndex = 4;
            // 
            // layControlGroup
            // 
            this.layControlGroup.AppearanceItemCaption.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layControlGroup.AppearanceItemCaption.Options.UseFont = true;
            this.layControlGroup.CustomizationFormText = "基本信息";
            this.layControlGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layControlGroup.GroupBordersVisible = false;
            this.layControlGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layDealerName,
            this.layRequestPerson,
            this.layDealerCode,
            this.layCreateDate,
            this.layReason});
            this.layControlGroup.Location = new System.Drawing.Point(0, 0);
            this.layControlGroup.Name = "layControlGroup";
            this.layControlGroup.Size = new System.Drawing.Size(838, 95);
            this.layControlGroup.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layControlGroup.Text = "基本信息";
            this.layControlGroup.TextVisible = false;
            // 
            // layDealerName
            // 
            this.layDealerName.Control = this.txtDealerName;
            this.layDealerName.CustomizationFormText = "单位名称";
            this.layDealerName.Location = new System.Drawing.Point(0, 0);
            this.layDealerName.Name = "layDealerName";
            this.layDealerName.Size = new System.Drawing.Size(400, 25);
            this.layDealerName.Text = "单位名称";
            this.layDealerName.TextSize = new System.Drawing.Size(48, 17);
            // 
            // layRequestPerson
            // 
            this.layRequestPerson.Control = this.txtRequestPerson;
            this.layRequestPerson.CustomizationFormText = "申请人";
            this.layRequestPerson.Location = new System.Drawing.Point(0, 25);
            this.layRequestPerson.Name = "layRequestPerson";
            this.layRequestPerson.Size = new System.Drawing.Size(400, 25);
            this.layRequestPerson.Text = "申请人";
            this.layRequestPerson.TextSize = new System.Drawing.Size(48, 17);
            // 
            // layDealerCode
            // 
            this.layDealerCode.Control = this.txtDealerCode;
            this.layDealerCode.CustomizationFormText = "单位编号";
            this.layDealerCode.Location = new System.Drawing.Point(400, 0);
            this.layDealerCode.Name = "layDealerCode";
            this.layDealerCode.Size = new System.Drawing.Size(418, 25);
            this.layDealerCode.Text = "单位编号";
            this.layDealerCode.TextSize = new System.Drawing.Size(48, 17);
            // 
            // layCreateDate
            // 
            this.layCreateDate.Control = this.txtCreateDate;
            this.layCreateDate.CustomizationFormText = "申请时间";
            this.layCreateDate.Location = new System.Drawing.Point(400, 25);
            this.layCreateDate.Name = "layCreateDate";
            this.layCreateDate.Size = new System.Drawing.Size(418, 50);
            this.layCreateDate.Text = "申请时间";
            this.layCreateDate.TextSize = new System.Drawing.Size(48, 17);
            // 
            // pnlAction
            // 
            this.pnlAction.Controls.Add(this.btnDealerInfo);
            this.pnlAction.Controls.Add(this.btnDeny);
            this.pnlAction.Controls.Add(this.btnCancel);
            this.pnlAction.Controls.Add(this.btnAccept);
            this.pnlAction.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlAction.Location = new System.Drawing.Point(0, 460);
            this.pnlAction.Name = "pnlAction";
            this.pnlAction.Size = new System.Drawing.Size(859, 48);
            this.pnlAction.TabIndex = 1;
            // 
            // btnDealerInfo
            // 
            this.btnDealerInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDealerInfo.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDealerInfo.Appearance.Options.UseFont = true;
            this.btnDealerInfo.Location = new System.Drawing.Point(318, 13);
            this.btnDealerInfo.Name = "btnDealerInfo";
            this.btnDealerInfo.Size = new System.Drawing.Size(114, 23);
            this.btnDealerInfo.TabIndex = 3;
            this.btnDealerInfo.Text = "查看原始数据(&I)";
            this.btnDealerInfo.Click += new System.EventHandler(this.btnDealerInfo_Click);
            // 
            // btnDeny
            // 
            this.btnDeny.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeny.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeny.Appearance.Options.UseFont = true;
            this.btnDeny.Location = new System.Drawing.Point(471, 13);
            this.btnDeny.Name = "btnDeny";
            this.btnDeny.Size = new System.Drawing.Size(114, 23);
            this.btnDeny.TabIndex = 2;
            this.btnDeny.Text = "拒绝变更(&D)";
            this.btnDeny.Visible = false;
            this.btnDeny.Click += new System.EventHandler(this.btnDeny_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Appearance.Options.UseFont = true;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(770, 13);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "关闭(&C)";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAccept
            // 
            this.btnAccept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAccept.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccept.Appearance.Options.UseFont = true;
            this.btnAccept.Location = new System.Drawing.Point(613, 13);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(114, 23);
            this.btnAccept.TabIndex = 0;
            this.btnAccept.Text = "同意变更(&A)";
            this.btnAccept.Visible = false;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // gpcButtom
            // 
            this.gpcButtom.AppearanceCaption.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpcButtom.AppearanceCaption.Options.UseFont = true;
            this.gpcButtom.Controls.Add(this.popupGrid);
            this.gpcButtom.Dock = System.Windows.Forms.DockStyle.Left;
            this.gpcButtom.Location = new System.Drawing.Point(0, 92);
            this.gpcButtom.Name = "gpcButtom";
            this.gpcButtom.Size = new System.Drawing.Size(425, 368);
            this.gpcButtom.TabIndex = 2;
            this.gpcButtom.Text = "变更明细";
            // 
            // popupGrid
            // 
            this.popupGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.popupGrid.IsCalculatePrice = false;
            this.popupGrid.IsCompute = false;
            this.popupGrid.Location = new System.Drawing.Point(2, 25);
            this.popupGrid.Name = "popupGrid";
            this.popupGrid.OperationName = "DealerChangeDetail";
            this.popupGrid.Size = new System.Drawing.Size(421, 341);
            this.popupGrid.TabIndex = 2;
            // 
            // splitterControl1
            // 
            this.splitterControl1.Location = new System.Drawing.Point(425, 92);
            this.splitterControl1.Name = "splitterControl1";
            this.splitterControl1.Size = new System.Drawing.Size(6, 368);
            this.splitterControl1.TabIndex = 3;
            this.splitterControl1.TabStop = false;
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.popupGrid1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(431, 92);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(428, 368);
            this.groupControl1.TabIndex = 4;
            this.groupControl1.Text = "电子档案变更明细";
            // 
            // popupGrid1
            // 
            this.popupGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.popupGrid1.IsCalculatePrice = false;
            this.popupGrid1.IsCompute = false;
            this.popupGrid1.Location = new System.Drawing.Point(2, 25);
            this.popupGrid1.Name = "popupGrid1";
            this.popupGrid1.OperationName = "";
            this.popupGrid1.Size = new System.Drawing.Size(424, 341);
            this.popupGrid1.TabIndex = 2;
            // 
            // txtReason
            // 
            this.txtReason.AlphabeticFiled = "";
            this.txtReason.IsIntegerOnly = false;
            this.txtReason.IsNullString = null;
            this.txtReason.IsNullValidate = false;
            this.txtReason.IsTransferAlphabetic = false;
            this.txtReason.Location = new System.Drawing.Point(63, 62);
            this.txtReason.Name = "txtReason";
            this.txtReason.Properties.ReadOnly = true;
            this.txtReason.Size = new System.Drawing.Size(345, 21);
            this.txtReason.StyleController = this.layControl;
            this.txtReason.TabIndex = 8;
            // 
            // layReason
            // 
            this.layReason.Control = this.txtReason;
            this.layReason.CustomizationFormText = "变更原因";
            this.layReason.Location = new System.Drawing.Point(0, 50);
            this.layReason.Name = "layReason";
            this.layReason.Size = new System.Drawing.Size(400, 25);
            this.layReason.Text = "变更原因";
            this.layReason.TextSize = new System.Drawing.Size(48, 17);
            // 
            // FrmSingleFirstDealerChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 508);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.splitterControl1);
            this.Controls.Add(this.gpcButtom);
            this.Controls.Add(this.pnlAction);
            this.Controls.Add(this.ftPanel);
            this.MinimizeBox = false;
            this.Name = "FrmSingleFirstDealerChange";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "供应商信息变更明细";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmSingleFirstDealerChange_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ftPanel)).EndInit();
            this.ftPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layControl)).EndInit();
            this.layControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtRequestPerson.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDealerCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCreateDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDealerName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layControlGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layDealerName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layRequestPerson)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layDealerCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layCreateDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlAction)).EndInit();
            this.pnlAction.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gpcButtom)).EndInit();
            this.gpcButtom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.popupGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.popupGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReason.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layReason)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DQS.Controls.FieldTextBoxPanel ftPanel;
        private DevExpress.XtraEditors.PanelControl pnlAction;
        private DQS.Controls.TextBoxEx txtDealerName;
        private DQS.Controls.TextBoxEx txtDealerCode;
        private DevExpress.XtraLayout.LayoutControl layControl;
        private DevExpress.XtraLayout.LayoutControlGroup layControlGroup;
        private DQS.Controls.TextBoxEx txtRequestPerson;
        private DQS.Controls.TextBoxEx txtCreateDate;
        private DevExpress.XtraLayout.LayoutControlItem layDealerName;
        private DevExpress.XtraLayout.LayoutControlItem layDealerCode;
        private DevExpress.XtraLayout.LayoutControlItem layCreateDate;
        private DevExpress.XtraLayout.LayoutControlItem layRequestPerson;
        private DevExpress.XtraEditors.GroupControl gpcButtom;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DQS.Controls.PopupGrid popupGrid;
        public DevExpress.XtraEditors.SimpleButton btnAccept;
        public DevExpress.XtraEditors.SimpleButton btnDeny;
        public DevExpress.XtraEditors.SimpleButton btnDealerInfo;
        private DevExpress.XtraEditors.SplitterControl splitterControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private Controls.PopupGrid popupGrid1;
        private Controls.TextBoxEx txtReason;
        private DevExpress.XtraLayout.LayoutControlItem layReason;

    }
}