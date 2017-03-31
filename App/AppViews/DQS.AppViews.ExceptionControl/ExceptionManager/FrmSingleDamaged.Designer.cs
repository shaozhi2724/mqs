namespace DQS.AppViews.ExceptionControl.ExceptionManager
{
    partial class FrmSingleDamaged
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
            this.gpcButtom = new DevExpress.XtraEditors.GroupControl();
            this.popupGrid = new DQS.Controls.PopupGrid();
            this.pnlAction = new DevExpress.XtraEditors.PanelControl();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.ftPanel = new DQS.Controls.FieldTextBoxPanel();
            this.layControl = new DevExpress.XtraLayout.LayoutControl();
            this.txtDestroyCode = new DQS.Controls.BUSProdcutDestroyEntityTextBox();
            this.tmeDestroyTime = new DevExpress.XtraEditors.TimeEdit();
            this.dteDestroyDate = new DevExpress.XtraEditors.DateEdit();
            this.txtDestroyRemark = new DQS.Controls.BUSProdcutDestroyEntityTextBox();
            this.txtDestroyResult = new DQS.Controls.BUSProdcutDestroyEntityTextBox();
            this.txtDestroyProcedure = new DQS.Controls.BUSProdcutDestroyEntityTextBox();
            this.txtDestroyCause = new DQS.Controls.BUSProdcutDestroyEntityTextBox();
            this.txtTransactor = new DQS.Controls.BUSProdcutDestroyEntityTextBox();
            this.layControlGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layDestroyCode = new DevExpress.XtraLayout.LayoutControlItem();
            this.layDestroyProcedure = new DevExpress.XtraLayout.LayoutControlItem();
            this.layDestroyResult = new DevExpress.XtraLayout.LayoutControlItem();
            this.layTransactor = new DevExpress.XtraLayout.LayoutControlItem();
            this.layDestroyRemark = new DevExpress.XtraLayout.LayoutControlItem();
            this.layDestroyDate = new DevExpress.XtraLayout.LayoutControlItem();
            this.layDestroyTime = new DevExpress.XtraLayout.LayoutControlItem();
            this.layDestroyCause = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.gpcButtom)).BeginInit();
            this.gpcButtom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.popupGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlAction)).BeginInit();
            this.pnlAction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ftPanel)).BeginInit();
            this.ftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layControl)).BeginInit();
            this.layControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDestroyCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tmeDestroyTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteDestroyDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteDestroyDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDestroyRemark.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDestroyResult.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDestroyProcedure.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDestroyCause.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTransactor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layControlGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layDestroyCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layDestroyProcedure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layDestroyResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layTransactor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layDestroyRemark)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layDestroyDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layDestroyTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layDestroyCause)).BeginInit();
            this.SuspendLayout();
            // 
            // gpcButtom
            // 
            this.gpcButtom.AppearanceCaption.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpcButtom.AppearanceCaption.Options.UseFont = true;
            this.gpcButtom.Controls.Add(this.popupGrid);
            this.gpcButtom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpcButtom.Location = new System.Drawing.Point(0, 155);
            this.gpcButtom.Name = "gpcButtom";
            this.gpcButtom.Size = new System.Drawing.Size(828, 311);
            this.gpcButtom.TabIndex = 5;
            this.gpcButtom.Text = "产品明细";
            // 
            // popupGrid
            // 
            this.popupGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.popupGrid.IsCalculatePrice = false;
            this.popupGrid.IsCompute = false;
            this.popupGrid.Location = new System.Drawing.Point(2, 25);
            this.popupGrid.Name = "popupGrid";
            this.popupGrid.OperationName = "Destroy";
            this.popupGrid.Size = new System.Drawing.Size(824, 284);
            this.popupGrid.TabIndex = 2;
            // 
            // pnlAction
            // 
            this.pnlAction.Controls.Add(this.btnCancel);
            this.pnlAction.Controls.Add(this.btnSave);
            this.pnlAction.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlAction.Location = new System.Drawing.Point(0, 466);
            this.pnlAction.Name = "pnlAction";
            this.pnlAction.Size = new System.Drawing.Size(828, 48);
            this.pnlAction.TabIndex = 4;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Appearance.Options.UseFont = true;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(740, 13);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "取消(&C)";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.Location = new System.Drawing.Point(635, 13);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "保存(&S)";
            // 
            // ftPanel
            // 
            this.ftPanel.Controls.Add(this.layControl);
            this.ftPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ftPanel.Location = new System.Drawing.Point(0, 0);
            this.ftPanel.Name = "ftPanel";
            this.ftPanel.Size = new System.Drawing.Size(828, 155);
            this.ftPanel.TabIndex = 3;
            this.ftPanel.TypeOfEntity = DQS.Module.EntityType2.BUSProdcutDestroyEntity;
            // 
            // layControl
            // 
            this.layControl.Controls.Add(this.txtDestroyCode);
            this.layControl.Controls.Add(this.tmeDestroyTime);
            this.layControl.Controls.Add(this.dteDestroyDate);
            this.layControl.Controls.Add(this.txtDestroyRemark);
            this.layControl.Controls.Add(this.txtDestroyResult);
            this.layControl.Controls.Add(this.txtDestroyProcedure);
            this.layControl.Controls.Add(this.txtDestroyCause);
            this.layControl.Controls.Add(this.txtTransactor);
            this.layControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layControl.Location = new System.Drawing.Point(2, 2);
            this.layControl.Name = "layControl";
            this.layControl.Root = this.layControlGroup;
            this.layControl.Size = new System.Drawing.Size(824, 151);
            this.layControl.TabIndex = 0;
            this.layControl.Text = "layControl";
            // 
            // txtDestroyCode
            // 
            this.txtDestroyCode.AlphabeticFiled = null;
            this.txtDestroyCode.EntityField = DQS.Module.Entities.BUSProdcutDestroyEntityFields2.DestroyCode;
            this.txtDestroyCode.IsIntegerOnly = false;
            this.txtDestroyCode.IsNullString = "销毁记录编号不能为空。";
            this.txtDestroyCode.IsNullValidate = true;
            this.txtDestroyCode.IsTransferAlphabetic = false;
            this.txtDestroyCode.Location = new System.Drawing.Point(63, 12);
            this.txtDestroyCode.Name = "txtDestroyCode";
            this.txtDestroyCode.Size = new System.Drawing.Size(338, 21);
            this.txtDestroyCode.StyleController = this.layControl;
            this.txtDestroyCode.TabIndex = 2;
            // 
            // tmeDestroyTime
            // 
            this.tmeDestroyTime.EditValue = new System.DateTime(2013, 10, 18, 0, 0, 0, 0);
            this.tmeDestroyTime.Location = new System.Drawing.Point(456, 37);
            this.tmeDestroyTime.Name = "tmeDestroyTime";
            this.tmeDestroyTime.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.tmeDestroyTime.Properties.ReadOnly = true;
            this.tmeDestroyTime.Size = new System.Drawing.Size(339, 21);
            this.tmeDestroyTime.StyleController = this.layControl;
            this.tmeDestroyTime.TabIndex = 14;
            // 
            // dteDestroyDate
            // 
            this.dteDestroyDate.EditValue = null;
            this.dteDestroyDate.Location = new System.Drawing.Point(63, 37);
            this.dteDestroyDate.Name = "dteDestroyDate";
            this.dteDestroyDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteDestroyDate.Properties.Mask.EditMask = "";
            this.dteDestroyDate.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.dteDestroyDate.Properties.ReadOnly = true;
            this.dteDestroyDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dteDestroyDate.Size = new System.Drawing.Size(338, 21);
            this.dteDestroyDate.StyleController = this.layControl;
            this.dteDestroyDate.TabIndex = 6;
            // 
            // txtDestroyRemark
            // 
            this.txtDestroyRemark.AlphabeticFiled = null;
            this.txtDestroyRemark.EntityField = DQS.Module.Entities.BUSProdcutDestroyEntityFields2.DestroyRemark;
            this.txtDestroyRemark.IsIntegerOnly = false;
            this.txtDestroyRemark.IsNullString = null;
            this.txtDestroyRemark.IsNullValidate = false;
            this.txtDestroyRemark.IsTransferAlphabetic = false;
            this.txtDestroyRemark.Location = new System.Drawing.Point(63, 137);
            this.txtDestroyRemark.Name = "txtDestroyRemark";
            this.txtDestroyRemark.Size = new System.Drawing.Size(732, 21);
            this.txtDestroyRemark.StyleController = this.layControl;
            this.txtDestroyRemark.TabIndex = 4;
            // 
            // txtDestroyResult
            // 
            this.txtDestroyResult.AlphabeticFiled = null;
            this.txtDestroyResult.EntityField = DQS.Module.Entities.BUSProdcutDestroyEntityFields2.DestroyResult;
            this.txtDestroyResult.IsIntegerOnly = false;
            this.txtDestroyResult.IsNullString = null;
            this.txtDestroyResult.IsNullValidate = false;
            this.txtDestroyResult.IsTransferAlphabetic = false;
            this.txtDestroyResult.Location = new System.Drawing.Point(63, 112);
            this.txtDestroyResult.Name = "txtDestroyResult";
            this.txtDestroyResult.Size = new System.Drawing.Size(732, 21);
            this.txtDestroyResult.StyleController = this.layControl;
            this.txtDestroyResult.TabIndex = 3;
            // 
            // txtDestroyProcedure
            // 
            this.txtDestroyProcedure.AlphabeticFiled = null;
            this.txtDestroyProcedure.EntityField = DQS.Module.Entities.BUSProdcutDestroyEntityFields2.DestroyProcedure;
            this.txtDestroyProcedure.IsIntegerOnly = false;
            this.txtDestroyProcedure.IsNullString = null;
            this.txtDestroyProcedure.IsNullValidate = false;
            this.txtDestroyProcedure.IsTransferAlphabetic = false;
            this.txtDestroyProcedure.Location = new System.Drawing.Point(63, 87);
            this.txtDestroyProcedure.Name = "txtDestroyProcedure";
            this.txtDestroyProcedure.Size = new System.Drawing.Size(732, 21);
            this.txtDestroyProcedure.StyleController = this.layControl;
            this.txtDestroyProcedure.TabIndex = 3;
            // 
            // txtDestroyCause
            // 
            this.txtDestroyCause.AlphabeticFiled = null;
            this.txtDestroyCause.EntityField = DQS.Module.Entities.BUSProdcutDestroyEntityFields2.DestroyCause;
            this.txtDestroyCause.IsIntegerOnly = false;
            this.txtDestroyCause.IsNullString = null;
            this.txtDestroyCause.IsNullValidate = false;
            this.txtDestroyCause.IsTransferAlphabetic = false;
            this.txtDestroyCause.Location = new System.Drawing.Point(63, 62);
            this.txtDestroyCause.Name = "txtDestroyCause";
            this.txtDestroyCause.Size = new System.Drawing.Size(732, 21);
            this.txtDestroyCause.StyleController = this.layControl;
            this.txtDestroyCause.TabIndex = 3;
            // 
            // txtTransactor
            // 
            this.txtTransactor.AlphabeticFiled = "TransactorSpell";
            this.txtTransactor.EntityField = DQS.Module.Entities.BUSProdcutDestroyEntityFields2.Transactor;
            this.txtTransactor.IsIntegerOnly = false;
            this.txtTransactor.IsNullString = null;
            this.txtTransactor.IsNullValidate = false;
            this.txtTransactor.IsTransferAlphabetic = true;
            this.txtTransactor.Location = new System.Drawing.Point(456, 12);
            this.txtTransactor.Name = "txtTransactor";
            this.txtTransactor.Properties.ReadOnly = true;
            this.txtTransactor.Size = new System.Drawing.Size(339, 21);
            this.txtTransactor.StyleController = this.layControl;
            this.txtTransactor.TabIndex = 3;
            // 
            // layControlGroup
            // 
            this.layControlGroup.AppearanceItemCaption.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layControlGroup.AppearanceItemCaption.Options.UseFont = true;
            this.layControlGroup.CustomizationFormText = "销毁记录";
            this.layControlGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layControlGroup.GroupBordersVisible = false;
            this.layControlGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layDestroyCode,
            this.layDestroyProcedure,
            this.layDestroyResult,
            this.layTransactor,
            this.layDestroyRemark,
            this.layDestroyDate,
            this.layDestroyTime,
            this.layDestroyCause});
            this.layControlGroup.Location = new System.Drawing.Point(0, 0);
            this.layControlGroup.Name = "layControlGroup";
            this.layControlGroup.Size = new System.Drawing.Size(807, 170);
            this.layControlGroup.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layControlGroup.Text = "销毁记录";
            this.layControlGroup.TextVisible = false;
            // 
            // layDestroyCode
            // 
            this.layDestroyCode.Control = this.txtDestroyCode;
            this.layDestroyCode.CustomizationFormText = "销毁记录编号";
            this.layDestroyCode.Location = new System.Drawing.Point(0, 0);
            this.layDestroyCode.Name = "layDestroyCode";
            this.layDestroyCode.Size = new System.Drawing.Size(393, 25);
            this.layDestroyCode.Text = "报损编号";
            this.layDestroyCode.TextSize = new System.Drawing.Size(48, 17);
            // 
            // layDestroyProcedure
            // 
            this.layDestroyProcedure.Control = this.txtDestroyProcedure;
            this.layDestroyProcedure.CustomizationFormText = "销毁过程";
            this.layDestroyProcedure.Location = new System.Drawing.Point(0, 75);
            this.layDestroyProcedure.Name = "layDestroyProcedure";
            this.layDestroyProcedure.Size = new System.Drawing.Size(787, 25);
            this.layDestroyProcedure.Text = "销毁过程";
            this.layDestroyProcedure.TextSize = new System.Drawing.Size(48, 17);
            // 
            // layDestroyResult
            // 
            this.layDestroyResult.Control = this.txtDestroyResult;
            this.layDestroyResult.CustomizationFormText = "销毁结果";
            this.layDestroyResult.Location = new System.Drawing.Point(0, 100);
            this.layDestroyResult.Name = "layDestroyResult";
            this.layDestroyResult.Size = new System.Drawing.Size(787, 25);
            this.layDestroyResult.Text = "销毁结果";
            this.layDestroyResult.TextSize = new System.Drawing.Size(48, 17);
            // 
            // layTransactor
            // 
            this.layTransactor.Control = this.txtTransactor;
            this.layTransactor.CustomizationFormText = "办理人";
            this.layTransactor.Location = new System.Drawing.Point(393, 0);
            this.layTransactor.Name = "layTransactor";
            this.layTransactor.Size = new System.Drawing.Size(394, 25);
            this.layTransactor.Text = "报损人";
            this.layTransactor.TextSize = new System.Drawing.Size(48, 17);
            // 
            // layDestroyRemark
            // 
            this.layDestroyRemark.Control = this.txtDestroyRemark;
            this.layDestroyRemark.CustomizationFormText = "备注";
            this.layDestroyRemark.Location = new System.Drawing.Point(0, 125);
            this.layDestroyRemark.Name = "layDestroyRemark";
            this.layDestroyRemark.Size = new System.Drawing.Size(787, 25);
            this.layDestroyRemark.Text = "备注";
            this.layDestroyRemark.TextSize = new System.Drawing.Size(48, 17);
            // 
            // layDestroyDate
            // 
            this.layDestroyDate.Control = this.dteDestroyDate;
            this.layDestroyDate.CustomizationFormText = "销毁日期";
            this.layDestroyDate.Location = new System.Drawing.Point(0, 25);
            this.layDestroyDate.Name = "layDestroyDate";
            this.layDestroyDate.Size = new System.Drawing.Size(393, 25);
            this.layDestroyDate.Text = "报损日期";
            this.layDestroyDate.TextSize = new System.Drawing.Size(48, 17);
            // 
            // layDestroyTime
            // 
            this.layDestroyTime.Control = this.tmeDestroyTime;
            this.layDestroyTime.CustomizationFormText = "销毁时间";
            this.layDestroyTime.Location = new System.Drawing.Point(393, 25);
            this.layDestroyTime.Name = "layDestroyTime";
            this.layDestroyTime.Size = new System.Drawing.Size(394, 25);
            this.layDestroyTime.Text = "报损时间";
            this.layDestroyTime.TextSize = new System.Drawing.Size(48, 17);
            // 
            // layDestroyCause
            // 
            this.layDestroyCause.Control = this.txtDestroyCause;
            this.layDestroyCause.CustomizationFormText = "销毁原因";
            this.layDestroyCause.Location = new System.Drawing.Point(0, 50);
            this.layDestroyCause.Name = "layDestroyCause";
            this.layDestroyCause.Size = new System.Drawing.Size(787, 25);
            this.layDestroyCause.Text = "销毁原因";
            this.layDestroyCause.TextSize = new System.Drawing.Size(48, 17);
            // 
            // FrmSingleDamaged
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 514);
            this.Controls.Add(this.gpcButtom);
            this.Controls.Add(this.pnlAction);
            this.Controls.Add(this.ftPanel);
            this.Name = "FrmSingleDamaged";
            this.ShowIcon = false;
            this.Text = "报损明细";
            ((System.ComponentModel.ISupportInitialize)(this.gpcButtom)).EndInit();
            this.gpcButtom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.popupGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlAction)).EndInit();
            this.pnlAction.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ftPanel)).EndInit();
            this.ftPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layControl)).EndInit();
            this.layControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtDestroyCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tmeDestroyTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteDestroyDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteDestroyDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDestroyRemark.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDestroyResult.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDestroyProcedure.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDestroyCause.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTransactor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layControlGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layDestroyCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layDestroyProcedure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layDestroyResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layTransactor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layDestroyRemark)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layDestroyDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layDestroyTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layDestroyCause)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl gpcButtom;
        private Controls.PopupGrid popupGrid;
        private DevExpress.XtraEditors.PanelControl pnlAction;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private Controls.FieldTextBoxPanel ftPanel;
        private DevExpress.XtraLayout.LayoutControl layControl;
        private Controls.BUSProdcutDestroyEntityTextBox txtDestroyCode;
        private DevExpress.XtraEditors.TimeEdit tmeDestroyTime;
        private DevExpress.XtraEditors.DateEdit dteDestroyDate;
        private Controls.BUSProdcutDestroyEntityTextBox txtDestroyRemark;
        private Controls.BUSProdcutDestroyEntityTextBox txtDestroyResult;
        private Controls.BUSProdcutDestroyEntityTextBox txtDestroyProcedure;
        private Controls.BUSProdcutDestroyEntityTextBox txtDestroyCause;
        private Controls.BUSProdcutDestroyEntityTextBox txtTransactor;
        private DevExpress.XtraLayout.LayoutControlGroup layControlGroup;
        private DevExpress.XtraLayout.LayoutControlItem layDestroyCode;
        private DevExpress.XtraLayout.LayoutControlItem layDestroyProcedure;
        private DevExpress.XtraLayout.LayoutControlItem layDestroyResult;
        private DevExpress.XtraLayout.LayoutControlItem layTransactor;
        private DevExpress.XtraLayout.LayoutControlItem layDestroyRemark;
        private DevExpress.XtraLayout.LayoutControlItem layDestroyDate;
        private DevExpress.XtraLayout.LayoutControlItem layDestroyTime;
        private DevExpress.XtraLayout.LayoutControlItem layDestroyCause;
    }
}