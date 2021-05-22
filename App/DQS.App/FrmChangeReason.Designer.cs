namespace DQS.App
{
    partial class FrmChangeReason
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
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtReason = new DevExpress.XtraEditors.TextEdit();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnDealer = new DevExpress.XtraEditors.SimpleButton();
            this.btnProduct = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lableID = new DevExpress.XtraEditors.LabelControl();
            this.lableTypeID = new DevExpress.XtraEditors.LabelControl();
            this.lableType = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReason.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridView
            // 
            this.gridView.GridControl = this.gridControl;
            this.gridView.IndicatorWidth = 50;
            this.gridView.Name = "gridView";
            this.gridView.OptionsView.ShowFooter = true;
            this.gridView.DoubleClick += new System.EventHandler(this.gridView_DoubleClick);
            // 
            // gridControl
            // 
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl.Location = new System.Drawing.Point(2, 2);
            this.gridControl.MainView = this.gridView;
            this.gridControl.Name = "gridControl";
            this.gridControl.Size = new System.Drawing.Size(1010, 488);
            this.gridControl.TabIndex = 7;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(15, 98);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(24, 14);
            this.labelControl6.TabIndex = 7;
            this.labelControl6.Text = "ID：";
            // 
            // txtReason
            // 
            this.txtReason.Location = new System.Drawing.Point(54, 131);
            this.txtReason.Name = "txtReason";
            this.txtReason.Size = new System.Drawing.Size(141, 21);
            this.txtReason.TabIndex = 6;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(217, 129);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "更新";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDealer
            // 
            this.btnDealer.Location = new System.Drawing.Point(120, 12);
            this.btnDealer.Name = "btnDealer";
            this.btnDealer.Size = new System.Drawing.Size(75, 23);
            this.btnDealer.TabIndex = 4;
            this.btnDealer.Text = "供应商/客户";
            this.btnDealer.Click += new System.EventHandler(this.btnDealer_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.Location = new System.Drawing.Point(15, 12);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(75, 23);
            this.btnProduct.TabIndex = 4;
            this.btnProduct.Text = "产品";
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.gridControl);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl3.Location = new System.Drawing.Point(0, 169);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(1014, 492);
            this.panelControl3.TabIndex = 6;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.lableID);
            this.panelControl1.Controls.Add(this.lableTypeID);
            this.panelControl1.Controls.Add(this.lableType);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.labelControl6);
            this.panelControl1.Controls.Add(this.txtReason);
            this.panelControl1.Controls.Add(this.btnSave);
            this.panelControl1.Controls.Add(this.btnDealer);
            this.panelControl1.Controls.Add(this.btnProduct);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1014, 169);
            this.panelControl1.TabIndex = 4;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(15, 57);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(36, 14);
            this.labelControl2.TabIndex = 7;
            this.labelControl2.Text = "修改：";
            // 
            // lableID
            // 
            this.lableID.Location = new System.Drawing.Point(54, 98);
            this.lableID.Name = "lableID";
            this.lableID.Size = new System.Drawing.Size(0, 14);
            this.lableID.TabIndex = 7;
            // 
            // lableTypeID
            // 
            this.lableTypeID.Location = new System.Drawing.Point(217, 57);
            this.lableTypeID.Name = "lableTypeID";
            this.lableTypeID.Size = new System.Drawing.Size(7, 14);
            this.lableTypeID.TabIndex = 7;
            this.lableTypeID.Text = "1";
            this.lableTypeID.Visible = false;
            // 
            // lableType
            // 
            this.lableType.Location = new System.Drawing.Point(54, 57);
            this.lableType.Name = "lableType";
            this.lableType.Size = new System.Drawing.Size(24, 14);
            this.lableType.TabIndex = 7;
            this.lableType.Text = "产品";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(15, 134);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(36, 14);
            this.labelControl1.TabIndex = 7;
            this.labelControl1.Text = "新值：";
            // 
            // FrmChangeReason
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 661);
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.panelControl1);
            this.Name = "FrmChangeReason";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "修改变更原因";
            this.Load += new System.EventHandler(this.FrmChangeReason_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReason.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtReason;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnDealer;
        private DevExpress.XtraEditors.SimpleButton btnProduct;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl lableID;
        private DevExpress.XtraEditors.LabelControl lableType;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl lableTypeID;
    }
}