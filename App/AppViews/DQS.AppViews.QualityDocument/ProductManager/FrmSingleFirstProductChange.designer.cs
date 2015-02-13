namespace DQS.AppViews.QualityDocument.ProductManager
{
    partial class FrmSingleFirstProductChange
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
            this.txtProductCode = new DQS.Controls.TextBoxEx();
            this.txtCreateDate = new DQS.Controls.TextBoxEx();
            this.txtProductName = new DQS.Controls.TextBoxEx();
            this.layControlGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layProductName = new DevExpress.XtraLayout.LayoutControlItem();
            this.layRequestPerson = new DevExpress.XtraLayout.LayoutControlItem();
            this.layProductCode = new DevExpress.XtraLayout.LayoutControlItem();
            this.layCreateDate = new DevExpress.XtraLayout.LayoutControlItem();
            this.pnlAction = new DevExpress.XtraEditors.PanelControl();
            this.btnProductInfo = new DevExpress.XtraEditors.SimpleButton();
            this.btnDeny = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnAccept = new DevExpress.XtraEditors.SimpleButton();
            this.gpcButtom = new DevExpress.XtraEditors.GroupControl();
            this.popupGrid = new DQS.Controls.PopupGrid();
            this.splitterControl1 = new DevExpress.XtraEditors.SplitterControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.popupGrid1 = new DQS.Controls.PopupGrid();
            ((System.ComponentModel.ISupportInitialize)(this.ftPanel)).BeginInit();
            this.ftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layControl)).BeginInit();
            this.layControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtRequestPerson.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCreateDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layControlGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layProductName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layRequestPerson)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layProductCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layCreateDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlAction)).BeginInit();
            this.pnlAction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gpcButtom)).BeginInit();
            this.gpcButtom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.popupGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.popupGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // ftPanel
            // 
            this.ftPanel.Controls.Add(this.layControl);
            this.ftPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ftPanel.Location = new System.Drawing.Point(0, 0);
            this.ftPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ftPanel.Name = "ftPanel";
            this.ftPanel.Size = new System.Drawing.Size(982, 84);
            this.ftPanel.TabIndex = 0;
            this.ftPanel.TypeOfEntity = DQS.Module.EntityType2.BUSReceiveEntity;
            // 
            // layControl
            // 
            this.layControl.Controls.Add(this.txtRequestPerson);
            this.layControl.Controls.Add(this.txtProductCode);
            this.layControl.Controls.Add(this.txtCreateDate);
            this.layControl.Controls.Add(this.txtProductName);
            this.layControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layControl.Location = new System.Drawing.Point(2, 2);
            this.layControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.layControl.Name = "layControl";
            this.layControl.Root = this.layControlGroup;
            this.layControl.Size = new System.Drawing.Size(978, 80);
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
            this.txtRequestPerson.Location = new System.Drawing.Point(75, 41);
            this.txtRequestPerson.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRequestPerson.Name = "txtRequestPerson";
            this.txtRequestPerson.Properties.ReadOnly = true;
            this.txtRequestPerson.Size = new System.Drawing.Size(402, 25);
            this.txtRequestPerson.StyleController = this.layControl;
            this.txtRequestPerson.TabIndex = 8;
            // 
            // txtProductCode
            // 
            this.txtProductCode.AlphabeticFiled = null;
            this.txtProductCode.IsIntegerOnly = false;
            this.txtProductCode.IsNullString = null;
            this.txtProductCode.IsNullValidate = false;
            this.txtProductCode.IsTransferAlphabetic = false;
            this.txtProductCode.Location = new System.Drawing.Point(544, 12);
            this.txtProductCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtProductCode.Name = "txtProductCode";
            this.txtProductCode.Properties.ReadOnly = true;
            this.txtProductCode.Size = new System.Drawing.Size(422, 25);
            this.txtProductCode.StyleController = this.layControl;
            this.txtProductCode.TabIndex = 6;
            // 
            // txtCreateDate
            // 
            this.txtCreateDate.AlphabeticFiled = "";
            this.txtCreateDate.IsIntegerOnly = false;
            this.txtCreateDate.IsNullString = null;
            this.txtCreateDate.IsNullValidate = false;
            this.txtCreateDate.IsTransferAlphabetic = false;
            this.txtCreateDate.Location = new System.Drawing.Point(544, 41);
            this.txtCreateDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCreateDate.Name = "txtCreateDate";
            this.txtCreateDate.Properties.ReadOnly = true;
            this.txtCreateDate.Size = new System.Drawing.Size(422, 25);
            this.txtCreateDate.StyleController = this.layControl;
            this.txtCreateDate.TabIndex = 7;
            // 
            // txtProductName
            // 
            this.txtProductName.AlphabeticFiled = null;
            this.txtProductName.IsIntegerOnly = false;
            this.txtProductName.IsNullString = null;
            this.txtProductName.IsNullValidate = false;
            this.txtProductName.IsTransferAlphabetic = false;
            this.txtProductName.Location = new System.Drawing.Point(75, 12);
            this.txtProductName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Properties.ReadOnly = true;
            this.txtProductName.Size = new System.Drawing.Size(402, 25);
            this.txtProductName.StyleController = this.layControl;
            this.txtProductName.TabIndex = 4;
            // 
            // layControlGroup
            // 
            this.layControlGroup.AppearanceItemCaption.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layControlGroup.AppearanceItemCaption.Options.UseFont = true;
            this.layControlGroup.CustomizationFormText = "药品信息变更";
            this.layControlGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layControlGroup.GroupBordersVisible = false;
            this.layControlGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layProductName,
            this.layRequestPerson,
            this.layProductCode,
            this.layCreateDate});
            this.layControlGroup.Location = new System.Drawing.Point(0, 0);
            this.layControlGroup.Name = "layControlGroup";
            this.layControlGroup.Size = new System.Drawing.Size(978, 80);
            this.layControlGroup.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layControlGroup.Text = "药品信息变更";
            this.layControlGroup.TextVisible = false;
            // 
            // layProductName
            // 
            this.layProductName.Control = this.txtProductName;
            this.layProductName.CustomizationFormText = "药品名称";
            this.layProductName.Location = new System.Drawing.Point(0, 0);
            this.layProductName.Name = "layProductName";
            this.layProductName.Size = new System.Drawing.Size(469, 29);
            this.layProductName.Text = "药品名称";
            this.layProductName.TextSize = new System.Drawing.Size(60, 20);
            // 
            // layRequestPerson
            // 
            this.layRequestPerson.Control = this.txtRequestPerson;
            this.layRequestPerson.CustomizationFormText = "申请人";
            this.layRequestPerson.Location = new System.Drawing.Point(0, 29);
            this.layRequestPerson.Name = "layRequestPerson";
            this.layRequestPerson.Size = new System.Drawing.Size(469, 31);
            this.layRequestPerson.Text = "申请人";
            this.layRequestPerson.TextSize = new System.Drawing.Size(60, 20);
            // 
            // layProductCode
            // 
            this.layProductCode.Control = this.txtProductCode;
            this.layProductCode.CustomizationFormText = "药品编号";
            this.layProductCode.Location = new System.Drawing.Point(469, 0);
            this.layProductCode.Name = "layProductCode";
            this.layProductCode.Size = new System.Drawing.Size(489, 29);
            this.layProductCode.Text = "药品编号";
            this.layProductCode.TextSize = new System.Drawing.Size(60, 20);
            // 
            // layCreateDate
            // 
            this.layCreateDate.Control = this.txtCreateDate;
            this.layCreateDate.CustomizationFormText = "申请时间";
            this.layCreateDate.Location = new System.Drawing.Point(469, 29);
            this.layCreateDate.Name = "layCreateDate";
            this.layCreateDate.Size = new System.Drawing.Size(489, 31);
            this.layCreateDate.Text = "申请时间";
            this.layCreateDate.TextSize = new System.Drawing.Size(60, 20);
            // 
            // pnlAction
            // 
            this.pnlAction.Controls.Add(this.btnProductInfo);
            this.pnlAction.Controls.Add(this.btnDeny);
            this.pnlAction.Controls.Add(this.btnCancel);
            this.pnlAction.Controls.Add(this.btnAccept);
            this.pnlAction.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlAction.Location = new System.Drawing.Point(0, 591);
            this.pnlAction.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlAction.Name = "pnlAction";
            this.pnlAction.Size = new System.Drawing.Size(982, 62);
            this.pnlAction.TabIndex = 1;
            // 
            // btnProductInfo
            // 
            this.btnProductInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProductInfo.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductInfo.Appearance.Options.UseFont = true;
            this.btnProductInfo.Location = new System.Drawing.Point(363, 17);
            this.btnProductInfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnProductInfo.Name = "btnProductInfo";
            this.btnProductInfo.Size = new System.Drawing.Size(130, 30);
            this.btnProductInfo.TabIndex = 3;
            this.btnProductInfo.Text = "查看原始数据(&I)";
            this.btnProductInfo.Click += new System.EventHandler(this.btnProductInfo_Click);
            // 
            // btnDeny
            // 
            this.btnDeny.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeny.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeny.Appearance.Options.UseFont = true;
            this.btnDeny.Location = new System.Drawing.Point(538, 17);
            this.btnDeny.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDeny.Name = "btnDeny";
            this.btnDeny.Size = new System.Drawing.Size(130, 30);
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
            this.btnCancel.Location = new System.Drawing.Point(880, 17);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(86, 30);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "关闭(&C)";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAccept
            // 
            this.btnAccept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAccept.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccept.Appearance.Options.UseFont = true;
            this.btnAccept.Location = new System.Drawing.Point(701, 17);
            this.btnAccept.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(130, 30);
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
            this.gpcButtom.Location = new System.Drawing.Point(0, 84);
            this.gpcButtom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpcButtom.Name = "gpcButtom";
            this.gpcButtom.Size = new System.Drawing.Size(486, 507);
            this.gpcButtom.TabIndex = 2;
            this.gpcButtom.Text = "变更明细";
            // 
            // popupGrid
            // 
            this.popupGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.popupGrid.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.popupGrid.IsCalculatePrice = false;
            this.popupGrid.Location = new System.Drawing.Point(2, 28);
            this.popupGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.popupGrid.Name = "popupGrid";
            this.popupGrid.OperationName = "ProductChangeDetail";
            this.popupGrid.Size = new System.Drawing.Size(482, 477);
            this.popupGrid.TabIndex = 2;
            // 
            // splitterControl1
            // 
            this.splitterControl1.Location = new System.Drawing.Point(486, 84);
            this.splitterControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitterControl1.Name = "splitterControl1";
            this.splitterControl1.Size = new System.Drawing.Size(6, 507);
            this.splitterControl1.TabIndex = 3;
            this.splitterControl1.TabStop = false;
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.popupGrid1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(492, 84);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(490, 507);
            this.groupControl1.TabIndex = 4;
            this.groupControl1.Text = "电子档案变更明细";
            // 
            // popupGrid1
            // 
            this.popupGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.popupGrid1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.popupGrid1.IsCalculatePrice = false;
            this.popupGrid1.Location = new System.Drawing.Point(2, 28);
            this.popupGrid1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.popupGrid1.Name = "popupGrid1";
            this.popupGrid1.OperationName = "";
            this.popupGrid1.Size = new System.Drawing.Size(486, 477);
            this.popupGrid1.TabIndex = 2;
            // 
            // FrmSingleFirstProductChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 653);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.splitterControl1);
            this.Controls.Add(this.gpcButtom);
            this.Controls.Add(this.pnlAction);
            this.Controls.Add(this.ftPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimizeBox = false;
            this.Name = "FrmSingleFirstProductChange";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "药品信息变更明细";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmSingleFirstProductChange_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ftPanel)).EndInit();
            this.ftPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layControl)).EndInit();
            this.layControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtRequestPerson.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCreateDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layControlGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layProductName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layRequestPerson)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layProductCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layCreateDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlAction)).EndInit();
            this.pnlAction.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gpcButtom)).EndInit();
            this.gpcButtom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.popupGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.popupGrid1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DQS.Controls.FieldTextBoxPanel ftPanel;
        private DevExpress.XtraEditors.PanelControl pnlAction;
        private DQS.Controls.TextBoxEx txtProductName;
        private DQS.Controls.TextBoxEx txtProductCode;
        private DevExpress.XtraLayout.LayoutControl layControl;
        private DevExpress.XtraLayout.LayoutControlGroup layControlGroup;
        private DQS.Controls.TextBoxEx txtRequestPerson;
        private DQS.Controls.TextBoxEx txtCreateDate;
        private DevExpress.XtraLayout.LayoutControlItem layProductName;
        private DevExpress.XtraLayout.LayoutControlItem layProductCode;
        private DevExpress.XtraLayout.LayoutControlItem layCreateDate;
        private DevExpress.XtraLayout.LayoutControlItem layRequestPerson;
        private DevExpress.XtraEditors.GroupControl gpcButtom;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DQS.Controls.PopupGrid popupGrid;
        public DevExpress.XtraEditors.SimpleButton btnAccept;
        public DevExpress.XtraEditors.SimpleButton btnDeny;
        public DevExpress.XtraEditors.SimpleButton btnProductInfo;
        private DevExpress.XtraEditors.SplitterControl splitterControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private Controls.PopupGrid popupGrid1;

    }
}