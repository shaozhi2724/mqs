namespace DQS.AppViews.WarehouseOut.WarehouseOutManager
{
    partial class FrmSingleReview
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
            this.txtRemark = new DQS.Controls.BUSReviewEntityTextBox();
            this.txtDealerName = new DQS.Controls.TextBoxEx();
            this.txtBillTypeName = new DQS.Controls.TextBoxEx();
            this.txtBillCode = new DQS.Controls.TextBoxPopupEx();
            this.txtReviewPerson = new DQS.Controls.TextBoxEnterPopupEx();
            this.txtReviewCode = new DQS.Controls.BUSReviewEntityTextBox();
            this.layControlGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layReviewCode = new DevExpress.XtraLayout.LayoutControlItem();
            this.layReviewPerson = new DevExpress.XtraLayout.LayoutControlItem();
            this.layBillCode = new DevExpress.XtraLayout.LayoutControlItem();
            this.layBillTypeName = new DevExpress.XtraLayout.LayoutControlItem();
            this.layDealerName = new DevExpress.XtraLayout.LayoutControlItem();
            this.layRemark = new DevExpress.XtraLayout.LayoutControlItem();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnPrint = new DQS.Controls.StiPrintButtonEx();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnOneKeyFinish = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.popupGrid = new DQS.Controls.PopupGrid();
            ((System.ComponentModel.ISupportInitialize)(this.ftPanel)).BeginInit();
            this.ftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layControl)).BeginInit();
            this.layControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtRemark.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDealerName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBillTypeName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBillCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReviewPerson.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReviewCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layControlGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layReviewCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layReviewPerson)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layBillCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layBillTypeName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layDealerName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layRemark)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.popupGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // ftPanel
            // 
            this.ftPanel.Controls.Add(this.layControl);
            this.ftPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ftPanel.Location = new System.Drawing.Point(0, 0);
            this.ftPanel.Name = "ftPanel";
            this.ftPanel.Size = new System.Drawing.Size(872, 124);
            this.ftPanel.TabIndex = 0;
            this.ftPanel.TypeOfEntity = DQS.Module.EntityType2.BUSReviewEntity;
            // 
            // layControl
            // 
            this.layControl.Controls.Add(this.txtRemark);
            this.layControl.Controls.Add(this.txtDealerName);
            this.layControl.Controls.Add(this.txtBillTypeName);
            this.layControl.Controls.Add(this.txtBillCode);
            this.layControl.Controls.Add(this.txtReviewPerson);
            this.layControl.Controls.Add(this.txtReviewCode);
            this.layControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layControl.Location = new System.Drawing.Point(2, 2);
            this.layControl.Name = "layControl";
            this.layControl.Root = this.layControlGroup;
            this.layControl.Size = new System.Drawing.Size(868, 120);
            this.layControl.TabIndex = 0;
            this.layControl.Text = "layControl";
            // 
            // txtRemark
            // 
            this.txtRemark.AlphabeticFiled = null;
            this.txtRemark.EntityField = DQS.Module.Entities.BUSReviewEntityFields2.ReviewRemark;
            this.txtRemark.IsIntegerOnly = false;
            this.txtRemark.IsNullString = null;
            this.txtRemark.IsNullValidate = false;
            this.txtRemark.IsTransferAlphabetic = false;
            this.txtRemark.Location = new System.Drawing.Point(63, 87);
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(793, 21);
            this.txtRemark.StyleController = this.layControl;
            this.txtRemark.TabIndex = 3;
            // 
            // txtDealerName
            // 
            this.txtDealerName.AlphabeticFiled = null;
            this.txtDealerName.IsIntegerOnly = false;
            this.txtDealerName.IsNullString = null;
            this.txtDealerName.IsNullValidate = false;
            this.txtDealerName.IsTransferAlphabetic = false;
            this.txtDealerName.Location = new System.Drawing.Point(63, 62);
            this.txtDealerName.Name = "txtDealerName";
            this.txtDealerName.Properties.ReadOnly = true;
            this.txtDealerName.Size = new System.Drawing.Size(793, 21);
            this.txtDealerName.StyleController = this.layControl;
            this.txtDealerName.TabIndex = 1;
            // 
            // txtBillTypeName
            // 
            this.txtBillTypeName.AlphabeticFiled = null;
            this.txtBillTypeName.IsIntegerOnly = false;
            this.txtBillTypeName.IsNullString = null;
            this.txtBillTypeName.IsNullValidate = false;
            this.txtBillTypeName.IsTransferAlphabetic = false;
            this.txtBillTypeName.Location = new System.Drawing.Point(487, 37);
            this.txtBillTypeName.Name = "txtBillTypeName";
            this.txtBillTypeName.Properties.ReadOnly = true;
            this.txtBillTypeName.Size = new System.Drawing.Size(369, 21);
            this.txtBillTypeName.StyleController = this.layControl;
            this.txtBillTypeName.TabIndex = 1;
            // 
            // txtBillCode
            // 
            this.txtBillCode.AlphabeticFiled = "";
            this.txtBillCode.EditData = null;
            this.txtBillCode.Fields = "";
            this.txtBillCode.Filter = "[状态] = \'等待复核\'";
            this.txtBillCode.FormatQueryString = "[订单编号] = \'{0}\'";
            this.txtBillCode.GroupColumn = null;
            this.txtBillCode.IsIntegerOnly = false;
            this.txtBillCode.IsNullString = "订单编号不能为空。";
            this.txtBillCode.IsNullValidate = true;
            this.txtBillCode.IsTransferAlphabetic = false;
            this.txtBillCode.Location = new System.Drawing.Point(63, 37);
            this.txtBillCode.MemberText = "订单编号";
            this.txtBillCode.MemberValue = "订单ID";
            this.txtBillCode.Name = "txtBillCode";
            this.txtBillCode.PageSize = 0;
            this.txtBillCode.PrimaryField = "订单ID";
            this.txtBillCode.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtBillCode.Properties.Appearance.Options.UseBackColor = true;
            this.txtBillCode.Properties.ReadOnly = true;
            this.txtBillCode.Size = new System.Drawing.Size(369, 21);
            this.txtBillCode.StyleController = this.layControl;
            this.txtBillCode.TabIndex = 5;
            this.txtBillCode.ViewName = "vw_AllWarehouseOutBill";
            this.txtBillCode.PopupClosing += new DQS.Controls.TextBoxPopupEx.OnPopupClosingDelegate(this.txtBillCode_PopupClosing);
            // 
            // txtReviewPerson
            // 
            this.txtReviewPerson.AlphabeticFiled = "ReviewPersonSpell";
            this.txtReviewPerson.EditData = null;
            this.txtReviewPerson.Fields = null;
            this.txtReviewPerson.Filter = null;
            this.txtReviewPerson.FormatQueryString = "[员工编号] LIKE \'%{0}%\' OR ([员工姓名] LIKE \'%{0}%\' OR [员工姓名Spell] LIKE \'%{0}%\')";
            this.txtReviewPerson.GroupColumn = null;
            this.txtReviewPerson.IsIntegerOnly = false;
            this.txtReviewPerson.IsNullString = null;
            this.txtReviewPerson.IsNullValidate = false;
            this.txtReviewPerson.IsTransferAlphabetic = false;
            this.txtReviewPerson.Location = new System.Drawing.Point(487, 12);
            this.txtReviewPerson.MemberText = "员工姓名";
            this.txtReviewPerson.MemberValue = "员工ID";
            this.txtReviewPerson.Name = "txtReviewPerson";
            this.txtReviewPerson.PageSize = 0;
            this.txtReviewPerson.PrimaryField = "员工ID";
            this.txtReviewPerson.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtReviewPerson.Properties.Appearance.Options.UseBackColor = true;
            this.txtReviewPerson.Properties.ReadOnly = true;
            this.txtReviewPerson.Size = new System.Drawing.Size(369, 21);
            this.txtReviewPerson.StyleController = this.layControl;
            this.txtReviewPerson.TabIndex = 1;
            this.txtReviewPerson.ViewName = "vw_AllEmployee";
            // 
            // txtReviewCode
            // 
            this.txtReviewCode.AlphabeticFiled = null;
            this.txtReviewCode.EntityField = DQS.Module.Entities.BUSReviewEntityFields2.ReviewCode;
            this.txtReviewCode.IsIntegerOnly = false;
            this.txtReviewCode.IsNullString = "复核单号不能为空。";
            this.txtReviewCode.IsNullValidate = true;
            this.txtReviewCode.IsTransferAlphabetic = false;
            this.txtReviewCode.Location = new System.Drawing.Point(63, 12);
            this.txtReviewCode.Name = "txtReviewCode";
            this.txtReviewCode.Size = new System.Drawing.Size(369, 21);
            this.txtReviewCode.StyleController = this.layControl;
            this.txtReviewCode.TabIndex = 1;
            // 
            // layControlGroup
            // 
            this.layControlGroup.AppearanceItemCaption.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layControlGroup.AppearanceItemCaption.Options.UseFont = true;
            this.layControlGroup.CustomizationFormText = "出库复核记录";
            this.layControlGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layControlGroup.GroupBordersVisible = false;
            this.layControlGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layReviewCode,
            this.layReviewPerson,
            this.layBillCode,
            this.layBillTypeName,
            this.layDealerName,
            this.layRemark});
            this.layControlGroup.Location = new System.Drawing.Point(0, 0);
            this.layControlGroup.Name = "layControlGroup";
            this.layControlGroup.Size = new System.Drawing.Size(868, 120);
            this.layControlGroup.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layControlGroup.Text = "出库复核记录";
            this.layControlGroup.TextVisible = false;
            // 
            // layReviewCode
            // 
            this.layReviewCode.Control = this.txtReviewCode;
            this.layReviewCode.CustomizationFormText = "复核单号";
            this.layReviewCode.Location = new System.Drawing.Point(0, 0);
            this.layReviewCode.Name = "layReviewCode";
            this.layReviewCode.Size = new System.Drawing.Size(424, 25);
            this.layReviewCode.Text = "复核单号";
            this.layReviewCode.TextSize = new System.Drawing.Size(48, 17);
            // 
            // layReviewPerson
            // 
            this.layReviewPerson.Control = this.txtReviewPerson;
            this.layReviewPerson.CustomizationFormText = "复核人";
            this.layReviewPerson.Location = new System.Drawing.Point(424, 0);
            this.layReviewPerson.Name = "layReviewPerson";
            this.layReviewPerson.Size = new System.Drawing.Size(424, 25);
            this.layReviewPerson.Text = "复核人";
            this.layReviewPerson.TextSize = new System.Drawing.Size(48, 17);
            // 
            // layBillCode
            // 
            this.layBillCode.Control = this.txtBillCode;
            this.layBillCode.CustomizationFormText = "出库记录";
            this.layBillCode.Location = new System.Drawing.Point(0, 25);
            this.layBillCode.Name = "layBillCode";
            this.layBillCode.Size = new System.Drawing.Size(424, 25);
            this.layBillCode.Text = "出库记录";
            this.layBillCode.TextSize = new System.Drawing.Size(48, 17);
            // 
            // layBillTypeName
            // 
            this.layBillTypeName.Control = this.txtBillTypeName;
            this.layBillTypeName.CustomizationFormText = "订单类型";
            this.layBillTypeName.Location = new System.Drawing.Point(424, 25);
            this.layBillTypeName.Name = "layBillTypeName";
            this.layBillTypeName.Size = new System.Drawing.Size(424, 25);
            this.layBillTypeName.Text = "订单类型";
            this.layBillTypeName.TextSize = new System.Drawing.Size(48, 17);
            // 
            // layDealerName
            // 
            this.layDealerName.Control = this.txtDealerName;
            this.layDealerName.CustomizationFormText = "往来单位";
            this.layDealerName.Location = new System.Drawing.Point(0, 50);
            this.layDealerName.Name = "layDealerName";
            this.layDealerName.Size = new System.Drawing.Size(848, 25);
            this.layDealerName.Text = "往来单位";
            this.layDealerName.TextSize = new System.Drawing.Size(48, 17);
            // 
            // layRemark
            // 
            this.layRemark.Control = this.txtRemark;
            this.layRemark.CustomizationFormText = "备注";
            this.layRemark.Location = new System.Drawing.Point(0, 75);
            this.layRemark.Name = "layRemark";
            this.layRemark.Size = new System.Drawing.Size(848, 25);
            this.layRemark.Text = "备注";
            this.layRemark.TextSize = new System.Drawing.Size(48, 17);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnPrint);
            this.panelControl1.Controls.Add(this.btnCancel);
            this.panelControl1.Controls.Add(this.btnSave);
            this.panelControl1.Controls.Add(this.btnOneKeyFinish);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 483);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(872, 48);
            this.panelControl1.TabIndex = 1;
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Appearance.Options.UseFont = true;
            this.btnPrint.Location = new System.Drawing.Point(471, 13);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.OperationName = "Review";
            this.btnPrint.ReportName = "出库复核单";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 5;
            this.btnPrint.Text = "打印(&P)";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Appearance.Options.UseFont = true;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(783, 13);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "取消(&C)";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.Location = new System.Drawing.Point(678, 13);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "保存(&S)";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnOneKeyFinish
            // 
            this.btnOneKeyFinish.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOneKeyFinish.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOneKeyFinish.Appearance.Options.UseFont = true;
            this.btnOneKeyFinish.Location = new System.Drawing.Point(803, 14);
            this.btnOneKeyFinish.Name = "btnOneKeyFinish";
            this.btnOneKeyFinish.Size = new System.Drawing.Size(32, 21);
            this.btnOneKeyFinish.TabIndex = 2;
            this.btnOneKeyFinish.Text = "一键完成(&K)";
            this.btnOneKeyFinish.Click += new System.EventHandler(this.btnOneKeyFinish_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.popupGrid);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 124);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(872, 359);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "出库复核明细";
            // 
            // popupGrid
            // 
            this.popupGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.popupGrid.IsCalculatePrice = false;
            this.popupGrid.Location = new System.Drawing.Point(2, 25);
            this.popupGrid.Name = "popupGrid";
            this.popupGrid.OperationName = "Review";
            this.popupGrid.Size = new System.Drawing.Size(868, 332);
            this.popupGrid.TabIndex = 3;
            // 
            // FrmSingleReview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 531);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.ftPanel);
            this.MinimizeBox = false;
            this.Name = "FrmSingleReview";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "出库复核记录";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmSingleReview_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ftPanel)).EndInit();
            this.ftPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layControl)).EndInit();
            this.layControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtRemark.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDealerName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBillTypeName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBillCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReviewPerson.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReviewCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layControlGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layReviewCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layReviewPerson)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layBillCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layBillTypeName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layDealerName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layRemark)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.popupGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DQS.Controls.FieldTextBoxPanel ftPanel;
        private DevExpress.XtraLayout.LayoutControl layControl;
        private DevExpress.XtraLayout.LayoutControlGroup layControlGroup;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnOneKeyFinish;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DQS.Controls.PopupGrid popupGrid;
        private DQS.Controls.TextBoxEnterPopupEx txtReviewPerson;
        private DQS.Controls.BUSReviewEntityTextBox txtReviewCode;
        private DevExpress.XtraLayout.LayoutControlItem layReviewCode;
        private DevExpress.XtraLayout.LayoutControlItem layReviewPerson;
        private DQS.Controls.TextBoxPopupEx txtBillCode;
        private DevExpress.XtraLayout.LayoutControlItem layBillCode;
        private DQS.Controls.TextBoxEx txtBillTypeName;
        private DevExpress.XtraLayout.LayoutControlItem layBillTypeName;
        private DQS.Controls.BUSReviewEntityTextBox txtRemark;
        private DQS.Controls.TextBoxEx txtDealerName;
        private DevExpress.XtraLayout.LayoutControlItem layDealerName;
        private DevExpress.XtraLayout.LayoutControlItem layRemark;
        private DQS.Controls.StiPrintButtonEx btnPrint;
    }
}