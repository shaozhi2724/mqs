namespace DQS.AppViews.ExceptionControl.ExceptionManager
{
    partial class FrmSingleProductUnqualified
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
            this.rdgIsCutAmount = new DevExpress.XtraEditors.RadioGroup();
            this.txtUnqualifiedRemark = new DQS.Controls.BUSProductUnqualifiedEntityTextBox();
            this.txtDealSuggestion = new DQS.Controls.BUSProductUnqualifiedEntityTextBox();
            this.txtUnqualifiedCause = new DQS.Controls.BUSProductUnqualifiedEntityTextBox();
            this.txtBlame = new DQS.Controls.BUSProductUnqualifiedEntityTextBox();
            this.txtUnqualifiedCode = new DQS.Controls.BUSProductUnqualifiedEntityTextBox();
            this.layControlGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layUnqualifiedCode = new DevExpress.XtraLayout.LayoutControlItem();
            this.layUnqualifiedCause = new DevExpress.XtraLayout.LayoutControlItem();
            this.layDealSuggestion = new DevExpress.XtraLayout.LayoutControlItem();
            this.layUnqualifiedRemark = new DevExpress.XtraLayout.LayoutControlItem();
            this.layIsCutAmount = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layBlame = new DevExpress.XtraLayout.LayoutControlItem();
            this.pnlAction = new DevExpress.XtraEditors.PanelControl();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.gpcButtom = new DevExpress.XtraEditors.GroupControl();
            this.popupGrid = new DQS.Controls.PopupGrid();
            ((System.ComponentModel.ISupportInitialize)(this.ftPanel)).BeginInit();
            this.ftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layControl)).BeginInit();
            this.layControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rdgIsCutAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUnqualifiedRemark.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDealSuggestion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUnqualifiedCause.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBlame.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUnqualifiedCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layControlGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layUnqualifiedCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layUnqualifiedCause)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layDealSuggestion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layUnqualifiedRemark)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layIsCutAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layBlame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlAction)).BeginInit();
            this.pnlAction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gpcButtom)).BeginInit();
            this.gpcButtom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.popupGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // ftPanel
            // 
            this.ftPanel.Controls.Add(this.layControl);
            this.ftPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ftPanel.Location = new System.Drawing.Point(0, 0);
            this.ftPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ftPanel.Name = "ftPanel";
            this.ftPanel.Size = new System.Drawing.Size(981, 174);
            this.ftPanel.TabIndex = 0;
            this.ftPanel.TypeOfEntity = DQS.Module.EntityType2.BUSProductUnqualifiedEntity;
            // 
            // layControl
            // 
            this.layControl.Controls.Add(this.rdgIsCutAmount);
            this.layControl.Controls.Add(this.txtUnqualifiedRemark);
            this.layControl.Controls.Add(this.txtDealSuggestion);
            this.layControl.Controls.Add(this.txtUnqualifiedCause);
            this.layControl.Controls.Add(this.txtBlame);
            this.layControl.Controls.Add(this.txtUnqualifiedCode);
            this.layControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layControl.Location = new System.Drawing.Point(2, 2);
            this.layControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.layControl.Name = "layControl";
            this.layControl.Root = this.layControlGroup;
            this.layControl.Size = new System.Drawing.Size(977, 170);
            this.layControl.TabIndex = 0;
            this.layControl.Text = "layControl";
            // 
            // rdgIsCutAmount
            // 
            this.rdgIsCutAmount.EditValue = false;
            this.rdgIsCutAmount.Location = new System.Drawing.Point(105, 128);
            this.rdgIsCutAmount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdgIsCutAmount.Name = "rdgIsCutAmount";
            this.rdgIsCutAmount.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.rdgIsCutAmount.Properties.Appearance.Options.UseBackColor = true;
            this.rdgIsCutAmount.Properties.Columns = 2;
            this.rdgIsCutAmount.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(false, "否"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(true, "是")});
            this.rdgIsCutAmount.Size = new System.Drawing.Size(141, 30);
            this.rdgIsCutAmount.StyleController = this.layControl;
            this.rdgIsCutAmount.TabIndex = 2;
            // 
            // txtUnqualifiedRemark
            // 
            this.txtUnqualifiedRemark.AlphabeticFiled = null;
            this.txtUnqualifiedRemark.EntityField = DQS.Module.Entities.BUSProductUnqualifiedEntityFields2.UnqualifiedRemark;
            this.txtUnqualifiedRemark.IsIntegerOnly = false;
            this.txtUnqualifiedRemark.IsNullString = null;
            this.txtUnqualifiedRemark.IsNullValidate = false;
            this.txtUnqualifiedRemark.IsTransferAlphabetic = false;
            this.txtUnqualifiedRemark.Location = new System.Drawing.Point(105, 99);
            this.txtUnqualifiedRemark.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUnqualifiedRemark.Name = "txtUnqualifiedRemark";
            this.txtUnqualifiedRemark.Size = new System.Drawing.Size(860, 25);
            this.txtUnqualifiedRemark.StyleController = this.layControl;
            this.txtUnqualifiedRemark.TabIndex = 3;
            // 
            // txtDealSuggestion
            // 
            this.txtDealSuggestion.AlphabeticFiled = null;
            this.txtDealSuggestion.EntityField = DQS.Module.Entities.BUSProductUnqualifiedEntityFields2.DealSuggestion;
            this.txtDealSuggestion.IsIntegerOnly = false;
            this.txtDealSuggestion.IsNullString = null;
            this.txtDealSuggestion.IsNullValidate = false;
            this.txtDealSuggestion.IsTransferAlphabetic = false;
            this.txtDealSuggestion.Location = new System.Drawing.Point(105, 70);
            this.txtDealSuggestion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDealSuggestion.Name = "txtDealSuggestion";
            this.txtDealSuggestion.Size = new System.Drawing.Size(860, 25);
            this.txtDealSuggestion.StyleController = this.layControl;
            this.txtDealSuggestion.TabIndex = 3;
            // 
            // txtUnqualifiedCause
            // 
            this.txtUnqualifiedCause.AlphabeticFiled = null;
            this.txtUnqualifiedCause.EntityField = DQS.Module.Entities.BUSProductUnqualifiedEntityFields2.UnqualifiedCause;
            this.txtUnqualifiedCause.IsIntegerOnly = false;
            this.txtUnqualifiedCause.IsNullString = null;
            this.txtUnqualifiedCause.IsNullValidate = false;
            this.txtUnqualifiedCause.IsTransferAlphabetic = false;
            this.txtUnqualifiedCause.Location = new System.Drawing.Point(105, 41);
            this.txtUnqualifiedCause.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUnqualifiedCause.Name = "txtUnqualifiedCause";
            this.txtUnqualifiedCause.Size = new System.Drawing.Size(860, 25);
            this.txtUnqualifiedCause.StyleController = this.layControl;
            this.txtUnqualifiedCause.TabIndex = 3;
            // 
            // txtBlame
            // 
            this.txtBlame.AlphabeticFiled = "BlameSpell";
            this.txtBlame.EntityField = DQS.Module.Entities.BUSProductUnqualifiedEntityFields2.Blame;
            this.txtBlame.IsIntegerOnly = false;
            this.txtBlame.IsNullString = null;
            this.txtBlame.IsNullValidate = false;
            this.txtBlame.IsTransferAlphabetic = true;
            this.txtBlame.Location = new System.Drawing.Point(582, 12);
            this.txtBlame.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBlame.Name = "txtBlame";
            this.txtBlame.Properties.ReadOnly = true;
            this.txtBlame.Size = new System.Drawing.Size(383, 25);
            this.txtBlame.StyleController = this.layControl;
            this.txtBlame.TabIndex = 3;
            // 
            // txtUnqualifiedCode
            // 
            this.txtUnqualifiedCode.AlphabeticFiled = null;
            this.txtUnqualifiedCode.EntityField = DQS.Module.Entities.BUSProductUnqualifiedEntityFields2.UnqualifiedCode;
            this.txtUnqualifiedCode.IsIntegerOnly = false;
            this.txtUnqualifiedCode.IsNullString = "记录编号不能为空。";
            this.txtUnqualifiedCode.IsNullValidate = true;
            this.txtUnqualifiedCode.IsTransferAlphabetic = false;
            this.txtUnqualifiedCode.Location = new System.Drawing.Point(105, 12);
            this.txtUnqualifiedCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUnqualifiedCode.Name = "txtUnqualifiedCode";
            this.txtUnqualifiedCode.Size = new System.Drawing.Size(380, 25);
            this.txtUnqualifiedCode.StyleController = this.layControl;
            this.txtUnqualifiedCode.TabIndex = 2;
            // 
            // layControlGroup
            // 
            this.layControlGroup.AppearanceItemCaption.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layControlGroup.AppearanceItemCaption.Options.UseFont = true;
            this.layControlGroup.CustomizationFormText = "不合格品记录";
            this.layControlGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layControlGroup.GroupBordersVisible = false;
            this.layControlGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layUnqualifiedCode,
            this.layUnqualifiedCause,
            this.layDealSuggestion,
            this.layUnqualifiedRemark,
            this.layIsCutAmount,
            this.emptySpaceItem1,
            this.layBlame});
            this.layControlGroup.Location = new System.Drawing.Point(0, 0);
            this.layControlGroup.Name = "layControlGroup";
            this.layControlGroup.Size = new System.Drawing.Size(977, 170);
            this.layControlGroup.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layControlGroup.Text = "不合格品记录";
            this.layControlGroup.TextVisible = false;
            // 
            // layUnqualifiedCode
            // 
            this.layUnqualifiedCode.Control = this.txtUnqualifiedCode;
            this.layUnqualifiedCode.CustomizationFormText = "记录编号";
            this.layUnqualifiedCode.Location = new System.Drawing.Point(0, 0);
            this.layUnqualifiedCode.Name = "layUnqualifiedCode";
            this.layUnqualifiedCode.Size = new System.Drawing.Size(477, 29);
            this.layUnqualifiedCode.Text = "记录编号";
            this.layUnqualifiedCode.TextSize = new System.Drawing.Size(90, 20);
            // 
            // layUnqualifiedCause
            // 
            this.layUnqualifiedCause.Control = this.txtUnqualifiedCause;
            this.layUnqualifiedCause.CustomizationFormText = "不合格原因";
            this.layUnqualifiedCause.Location = new System.Drawing.Point(0, 29);
            this.layUnqualifiedCause.Name = "layUnqualifiedCause";
            this.layUnqualifiedCause.Size = new System.Drawing.Size(957, 29);
            this.layUnqualifiedCause.Text = "不合格原因";
            this.layUnqualifiedCause.TextSize = new System.Drawing.Size(90, 20);
            // 
            // layDealSuggestion
            // 
            this.layDealSuggestion.Control = this.txtDealSuggestion;
            this.layDealSuggestion.CustomizationFormText = "处理意见";
            this.layDealSuggestion.Location = new System.Drawing.Point(0, 58);
            this.layDealSuggestion.Name = "layDealSuggestion";
            this.layDealSuggestion.Size = new System.Drawing.Size(957, 29);
            this.layDealSuggestion.Text = "处理意见";
            this.layDealSuggestion.TextSize = new System.Drawing.Size(90, 20);
            // 
            // layUnqualifiedRemark
            // 
            this.layUnqualifiedRemark.Control = this.txtUnqualifiedRemark;
            this.layUnqualifiedRemark.CustomizationFormText = "备注";
            this.layUnqualifiedRemark.Location = new System.Drawing.Point(0, 87);
            this.layUnqualifiedRemark.Name = "layUnqualifiedRemark";
            this.layUnqualifiedRemark.Size = new System.Drawing.Size(957, 29);
            this.layUnqualifiedRemark.Text = "备注";
            this.layUnqualifiedRemark.TextSize = new System.Drawing.Size(90, 20);
            // 
            // layIsCutAmount
            // 
            this.layIsCutAmount.Control = this.rdgIsCutAmount;
            this.layIsCutAmount.CustomizationFormText = "是否削减库存";
            this.layIsCutAmount.Location = new System.Drawing.Point(0, 116);
            this.layIsCutAmount.Name = "layIsCutAmount";
            this.layIsCutAmount.Size = new System.Drawing.Size(238, 34);
            this.layIsCutAmount.Text = "是否削减库存";
            this.layIsCutAmount.TextSize = new System.Drawing.Size(90, 20);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(238, 116);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(719, 34);
            this.emptySpaceItem1.Text = "emptySpaceItem1";
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layBlame
            // 
            this.layBlame.Control = this.txtBlame;
            this.layBlame.CustomizationFormText = "责任部门(人)";
            this.layBlame.Location = new System.Drawing.Point(477, 0);
            this.layBlame.Name = "layBlame";
            this.layBlame.Size = new System.Drawing.Size(480, 29);
            this.layBlame.Text = "责任部门(人)";
            this.layBlame.TextSize = new System.Drawing.Size(90, 20);
            // 
            // pnlAction
            // 
            this.pnlAction.Controls.Add(this.btnCancel);
            this.pnlAction.Controls.Add(this.btnSave);
            this.pnlAction.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlAction.Location = new System.Drawing.Point(0, 621);
            this.pnlAction.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlAction.Name = "pnlAction";
            this.pnlAction.Size = new System.Drawing.Size(981, 62);
            this.pnlAction.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Appearance.Options.UseFont = true;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(879, 17);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(86, 30);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "取消(&C)";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.Location = new System.Drawing.Point(759, 17);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(86, 30);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "保存(&S)";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // gpcButtom
            // 
            this.gpcButtom.AppearanceCaption.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpcButtom.AppearanceCaption.Options.UseFont = true;
            this.gpcButtom.Controls.Add(this.popupGrid);
            this.gpcButtom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpcButtom.Location = new System.Drawing.Point(0, 174);
            this.gpcButtom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpcButtom.Name = "gpcButtom";
            this.gpcButtom.Size = new System.Drawing.Size(981, 447);
            this.gpcButtom.TabIndex = 2;
            this.gpcButtom.Text = "药品明细";
            // 
            // popupGrid
            // 
            this.popupGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.popupGrid.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.popupGrid.IsCalculatePrice = false;
            this.popupGrid.Location = new System.Drawing.Point(2, 28);
            this.popupGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.popupGrid.Name = "popupGrid";
            this.popupGrid.OperationName = "Unqualified";
            this.popupGrid.Size = new System.Drawing.Size(977, 417);
            this.popupGrid.TabIndex = 2;
            this.popupGrid.PopupClosed += new DQS.Controls.PopupGrid.OnPopupClosedEventHandler(this.popupGrid_PopupClosed);
            // 
            // FrmSingleProductUnqualified
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 683);
            this.Controls.Add(this.gpcButtom);
            this.Controls.Add(this.pnlAction);
            this.Controls.Add(this.ftPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSingleProductUnqualified";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "不合格品记录";
            this.Load += new System.EventHandler(this.FrmSingleProductUnqualified_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ftPanel)).EndInit();
            this.ftPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layControl)).EndInit();
            this.layControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rdgIsCutAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUnqualifiedRemark.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDealSuggestion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUnqualifiedCause.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBlame.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUnqualifiedCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layControlGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layUnqualifiedCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layUnqualifiedCause)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layDealSuggestion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layUnqualifiedRemark)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layIsCutAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layBlame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlAction)).EndInit();
            this.pnlAction.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gpcButtom)).EndInit();
            this.gpcButtom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.popupGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DQS.Controls.FieldTextBoxPanel ftPanel;
        private DevExpress.XtraEditors.PanelControl pnlAction;
        private DevExpress.XtraLayout.LayoutControl layControl;
        private DevExpress.XtraLayout.LayoutControlGroup layControlGroup;
        private DevExpress.XtraEditors.GroupControl gpcButtom;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DQS.Controls.PopupGrid popupGrid;
        private DQS.Controls.BUSProductUnqualifiedEntityTextBox txtUnqualifiedRemark;
        private DQS.Controls.BUSProductUnqualifiedEntityTextBox txtDealSuggestion;
        private DQS.Controls.BUSProductUnqualifiedEntityTextBox txtUnqualifiedCause;
        private DQS.Controls.BUSProductUnqualifiedEntityTextBox txtBlame;
        private DQS.Controls.BUSProductUnqualifiedEntityTextBox txtUnqualifiedCode;
        private DevExpress.XtraLayout.LayoutControlItem layUnqualifiedCode;
        private DevExpress.XtraLayout.LayoutControlItem layBlame;
        private DevExpress.XtraLayout.LayoutControlItem layUnqualifiedCause;
        private DevExpress.XtraLayout.LayoutControlItem layDealSuggestion;
        private DevExpress.XtraLayout.LayoutControlItem layUnqualifiedRemark;
        private DevExpress.XtraEditors.RadioGroup rdgIsCutAmount;
        private DevExpress.XtraLayout.LayoutControlItem layIsCutAmount;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
    }
}