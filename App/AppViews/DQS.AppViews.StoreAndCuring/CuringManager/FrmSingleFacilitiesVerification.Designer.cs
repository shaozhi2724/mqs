namespace DQS.AppViews.StoreAndCuring.CuringManager
{
    partial class FrmSingleFacilitiesVerification
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.txtFacilityCode = new DQS.Controls.TextBoxQueryEx();
            this.layFacilityCode = new DevExpress.XtraLayout.LayoutControlItem();
            this.txtFacilityName = new DQS.Controls.TextBoxQueryEx();
            this.layFacilityName = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.gpcQuery)).BeginInit();
            this.gpcQuery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pageNavigator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolBarPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFacilityCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layFacilityCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFacilityName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layFacilityName)).BeginInit();
            this.SuspendLayout();
            // 
            // gpcQuery
            // 
            this.gpcQuery.Controls.Add(this.layoutControl1);
            this.gpcQuery.Location = new System.Drawing.Point(0, 37);
            this.gpcQuery.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpcQuery.Size = new System.Drawing.Size(811, 72);
            // 
            // pageNavigator
            // 
            this.pageNavigator.Appearance.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageNavigator.Appearance.Options.UseFont = true;
            this.pageNavigator.Location = new System.Drawing.Point(0, 109);
            this.pageNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pageNavigator.MinimumSize = new System.Drawing.Size(800, 53);
            this.pageNavigator.Size = new System.Drawing.Size(811, 53);
            // 
            // toolBarPanel
            // 
            this.toolBarPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.toolBarPanel.Size = new System.Drawing.Size(811, 37);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.txtFacilityName);
            this.layoutControl1.Controls.Add(this.txtFacilityCode);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(2, 23);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(807, 47);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layFacilityCode,
            this.layFacilityName});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(807, 47);
            this.layoutControlGroup1.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // txtFacilityCode
            // 
            this.txtFacilityCode.FormatQueryString = "[编号] LIKE \'%{0}%\'";
            this.txtFacilityCode.Location = new System.Drawing.Point(64, 12);
            this.txtFacilityCode.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtFacilityCode.Name = "txtFacilityCode";
            this.txtFacilityCode.Size = new System.Drawing.Size(337, 21);
            this.txtFacilityCode.StyleController = this.layoutControl1;
            this.txtFacilityCode.TabIndex = 10;
            // 
            // layFacilityCode
            // 
            this.layFacilityCode.Control = this.txtFacilityCode;
            this.layFacilityCode.CustomizationFormText = "设备编号";
            this.layFacilityCode.Location = new System.Drawing.Point(0, 0);
            this.layFacilityCode.Name = "layFacilityCode";
            this.layFacilityCode.Size = new System.Drawing.Size(393, 27);
            this.layFacilityCode.Text = "设备编号";
            this.layFacilityCode.TextSize = new System.Drawing.Size(48, 14);
            // 
            // txtFacilityName
            // 
            this.txtFacilityName.FormatQueryString = "[设备名称] LIKE \'%{0}%\'";
            this.txtFacilityName.Location = new System.Drawing.Point(457, 12);
            this.txtFacilityName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtFacilityName.Name = "txtFacilityName";
            this.txtFacilityName.Size = new System.Drawing.Size(338, 21);
            this.txtFacilityName.StyleController = this.layoutControl1;
            this.txtFacilityName.TabIndex = 10;
            // 
            // layFacilityName
            // 
            this.layFacilityName.Control = this.txtFacilityName;
            this.layFacilityName.CustomizationFormText = "设备名称";
            this.layFacilityName.Location = new System.Drawing.Point(393, 0);
            this.layFacilityName.Name = "layFacilityName";
            this.layFacilityName.Size = new System.Drawing.Size(394, 27);
            this.layFacilityName.Text = "设备名称";
            this.layFacilityName.TextSize = new System.Drawing.Size(48, 14);
            // 
            // FrmSingleFacilitiesVerification
            // 
            this.Appearance.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 463);
            this.Name = "FrmSingleFacilitiesVerification";
            this.Text = "FrmSingleFacilitiesVerification";
            this.Load += new System.EventHandler(this.FrmSingleFacilitiesVerification_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gpcQuery)).EndInit();
            this.gpcQuery.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pageNavigator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolBarPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFacilityCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layFacilityCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFacilityName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layFacilityName)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private Controls.TextBoxQueryEx txtFacilityCode;
        private DevExpress.XtraLayout.LayoutControlItem layFacilityCode;
        private Controls.TextBoxQueryEx txtFacilityName;
        private DevExpress.XtraLayout.LayoutControlItem layFacilityName;

    }
}