﻿namespace DQS.AppViews.OtherOperation.Finance
{
    partial class FrmPaymentForOnPassage
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.txtDealerName = new DevExpress.XtraEditors.TextEdit();
            this.cboChoose = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.cboType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.btnOnPassage = new DevExpress.XtraEditors.SimpleButton();
            this.dePaymentDate = new DevExpress.XtraEditors.DateEdit();
            this.btnBill = new DevExpress.XtraEditors.SimpleButton();
            this.txtVoucherCode = new DevExpress.XtraEditors.TextEdit();
            this.txtPaymentPerson = new DevExpress.XtraEditors.TextEdit();
            this.txtTotalPrice = new DevExpress.XtraEditors.TextEdit();
            this.txtPaymentCode = new DevExpress.XtraEditors.TextEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.lblTotalPrice = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDealerName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboChoose.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dePaymentDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dePaymentDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVoucherCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPaymentPerson.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPaymentCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl1.Controls.Add(this.txtDealerName);
            this.panelControl1.Controls.Add(this.cboChoose);
            this.panelControl1.Controls.Add(this.labelControl12);
            this.panelControl1.Controls.Add(this.cboType);
            this.panelControl1.Controls.Add(this.btnOnPassage);
            this.panelControl1.Controls.Add(this.dePaymentDate);
            this.panelControl1.Controls.Add(this.btnBill);
            this.panelControl1.Controls.Add(this.txtVoucherCode);
            this.panelControl1.Controls.Add(this.txtPaymentPerson);
            this.panelControl1.Controls.Add(this.txtTotalPrice);
            this.panelControl1.Controls.Add(this.txtPaymentCode);
            this.panelControl1.Controls.Add(this.labelControl10);
            this.panelControl1.Controls.Add(this.labelControl6);
            this.panelControl1.Controls.Add(this.labelControl5);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Location = new System.Drawing.Point(3, 3);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(967, 76);
            this.panelControl1.TabIndex = 12;
            // 
            // txtDealerName
            // 
            this.txtDealerName.Location = new System.Drawing.Point(646, 11);
            this.txtDealerName.Name = "txtDealerName";
            this.txtDealerName.Size = new System.Drawing.Size(275, 21);
            this.txtDealerName.TabIndex = 24;
            this.txtDealerName.Click += new System.EventHandler(this.txtDealerName_Click);
            // 
            // cboChoose
            // 
            this.cboChoose.EditValue = "按单据付款";
            this.cboChoose.Location = new System.Drawing.Point(646, 42);
            this.cboChoose.Name = "cboChoose";
            this.cboChoose.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboChoose.Size = new System.Drawing.Size(90, 21);
            this.cboChoose.TabIndex = 23;
            this.cboChoose.TextChanged += new System.EventHandler(this.cboChoose_TextChanged);
            // 
            // labelControl12
            // 
            this.labelControl12.Location = new System.Drawing.Point(580, 45);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(60, 14);
            this.labelControl12.TabIndex = 22;
            this.labelControl12.Text = "付款条件：";
            // 
            // cboType
            // 
            this.cboType.Location = new System.Drawing.Point(484, 11);
            this.cboType.Name = "cboType";
            this.cboType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboType.Size = new System.Drawing.Size(90, 21);
            this.cboType.TabIndex = 21;
            // 
            // btnOnPassage
            // 
            this.btnOnPassage.Location = new System.Drawing.Point(786, 38);
            this.btnOnPassage.Name = "btnOnPassage";
            this.btnOnPassage.Size = new System.Drawing.Size(135, 27);
            this.btnOnPassage.TabIndex = 18;
            this.btnOnPassage.Text = "选择在途单据";
            this.btnOnPassage.Click += new System.EventHandler(this.btnOnPassage_Click);
            // 
            // dePaymentDate
            // 
            this.dePaymentDate.EditValue = null;
            this.dePaymentDate.Location = new System.Drawing.Point(484, 42);
            this.dePaymentDate.Name = "dePaymentDate";
            this.dePaymentDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dePaymentDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dePaymentDate.Size = new System.Drawing.Size(90, 21);
            this.dePaymentDate.TabIndex = 3;
            // 
            // btnBill
            // 
            this.btnBill.Location = new System.Drawing.Point(927, 38);
            this.btnBill.Name = "btnBill";
            this.btnBill.Size = new System.Drawing.Size(135, 27);
            this.btnBill.TabIndex = 2;
            this.btnBill.Text = "选择应付单据";
            this.btnBill.Visible = false;
            // 
            // txtVoucherCode
            // 
            this.txtVoucherCode.Location = new System.Drawing.Point(274, 11);
            this.txtVoucherCode.Name = "txtVoucherCode";
            this.txtVoucherCode.Size = new System.Drawing.Size(138, 21);
            this.txtVoucherCode.TabIndex = 1;
            // 
            // txtPaymentPerson
            // 
            this.txtPaymentPerson.Location = new System.Drawing.Point(274, 42);
            this.txtPaymentPerson.Name = "txtPaymentPerson";
            this.txtPaymentPerson.Properties.ReadOnly = true;
            this.txtPaymentPerson.Size = new System.Drawing.Size(138, 21);
            this.txtPaymentPerson.TabIndex = 1;
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Location = new System.Drawing.Point(76, 42);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.Size = new System.Drawing.Size(138, 21);
            this.txtTotalPrice.TabIndex = 1;
            // 
            // txtPaymentCode
            // 
            this.txtPaymentCode.Location = new System.Drawing.Point(76, 11);
            this.txtPaymentCode.Name = "txtPaymentCode";
            this.txtPaymentCode.Properties.ReadOnly = true;
            this.txtPaymentCode.Size = new System.Drawing.Size(138, 21);
            this.txtPaymentCode.TabIndex = 1;
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(418, 14);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(60, 14);
            this.labelControl10.TabIndex = 0;
            this.labelControl10.Text = "付款方式：";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(418, 45);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(60, 14);
            this.labelControl6.TabIndex = 0;
            this.labelControl6.Text = "付款日期：";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(220, 45);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(48, 14);
            this.labelControl5.TabIndex = 0;
            this.labelControl5.Text = "付款人：";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(10, 45);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(60, 14);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "付款金额：";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(580, 14);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(60, 14);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "往来单位：";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(220, 14);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(48, 14);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "凭证号：";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(10, 14);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(60, 14);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "付款编号：";
            // 
            // panelControl2
            // 
            this.panelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl2.Controls.Add(this.btnCancel);
            this.panelControl2.Controls.Add(this.btnSave);
            this.panelControl2.Controls.Add(this.labelControl11);
            this.panelControl2.Controls.Add(this.lblTotalPrice);
            this.panelControl2.Controls.Add(this.labelControl9);
            this.panelControl2.Controls.Add(this.labelControl8);
            this.panelControl2.Controls.Add(this.labelControl7);
            this.panelControl2.Location = new System.Drawing.Point(3, 429);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(968, 48);
            this.panelControl2.TabIndex = 11;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(874, 14);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "取消";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(755, 14);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "保存";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(459, 17);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(84, 14);
            this.labelControl11.TabIndex = 0;
            this.labelControl11.Text = "选中单据总额：";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.Location = new System.Drawing.Point(549, 17);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(0, 14);
            this.lblTotalPrice.TabIndex = 0;
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(294, 17);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(60, 14);
            this.labelControl9.TabIndex = 0;
            this.labelControl9.Text = "本期应付：";
            this.labelControl9.Visible = false;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(149, 17);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(60, 14);
            this.labelControl8.TabIndex = 0;
            this.labelControl8.Text = "本期应收：";
            this.labelControl8.Visible = false;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(9, 17);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(60, 14);
            this.labelControl7.TabIndex = 0;
            this.labelControl7.Text = "上期结存：";
            this.labelControl7.Visible = false;
            // 
            // gridControl
            // 
            this.gridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl.Location = new System.Drawing.Point(3, 81);
            this.gridControl.MainView = this.gridView;
            this.gridControl.Name = "gridControl";
            this.gridControl.Size = new System.Drawing.Size(967, 346);
            this.gridControl.TabIndex = 10;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // gridView
            // 
            this.gridView.GridControl = this.gridControl;
            this.gridView.IndicatorWidth = 40;
            this.gridView.Name = "gridView";
            this.gridView.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridView_CustomDrawRowIndicator);
            // 
            // FrmPaymentForOnPassage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 480);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.gridControl);
            this.Name = "FrmPaymentForOnPassage";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "在途转付款";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmPaymentForOnPassage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDealerName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboChoose.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dePaymentDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dePaymentDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVoucherCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPaymentPerson.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPaymentCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.TextEdit txtDealerName;
        private DevExpress.XtraEditors.ComboBoxEdit cboChoose;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.ComboBoxEdit cboType;
        private DevExpress.XtraEditors.SimpleButton btnOnPassage;
        private DevExpress.XtraEditors.DateEdit dePaymentDate;
        private DevExpress.XtraEditors.SimpleButton btnBill;
        private DevExpress.XtraEditors.TextEdit txtVoucherCode;
        private DevExpress.XtraEditors.TextEdit txtPaymentPerson;
        private DevExpress.XtraEditors.TextEdit txtTotalPrice;
        private DevExpress.XtraEditors.TextEdit txtPaymentCode;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl lblTotalPrice;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
    }
}