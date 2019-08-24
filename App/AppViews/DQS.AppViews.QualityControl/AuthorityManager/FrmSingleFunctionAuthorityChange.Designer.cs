namespace DQS.AppViews.QualityControl.AuthorityManager
{
    partial class FrmSingleFunctionAuthorityChange
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.gcDel = new DevExpress.XtraGrid.GridControl();
            this.gvDel = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gcAdd = new DevExpress.XtraGrid.GridControl();
            this.gvAdd = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.groupControl3);
            this.groupControl1.Controls.Add(this.groupControl2);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(808, 491);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "功能权限变更明细";
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.gcDel);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl3.Location = new System.Drawing.Point(415, 23);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(391, 466);
            this.groupControl3.TabIndex = 1;
            this.groupControl3.Text = "删除功能权限";
            // 
            // gcDel
            // 
            this.gcDel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcDel.Location = new System.Drawing.Point(2, 23);
            this.gcDel.MainView = this.gvDel;
            this.gcDel.Name = "gcDel";
            this.gcDel.Size = new System.Drawing.Size(387, 441);
            this.gcDel.TabIndex = 0;
            this.gcDel.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDel});
            // 
            // gvDel
            // 
            this.gvDel.GridControl = this.gcDel;
            this.gvDel.IndicatorWidth = 45;
            this.gvDel.Name = "gvDel";
            this.gvDel.OptionsBehavior.Editable = false;
            this.gvDel.OptionsBehavior.ReadOnly = true;
            this.gvDel.OptionsView.ShowGroupPanel = false;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.gcAdd);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupControl2.Location = new System.Drawing.Point(2, 23);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(413, 466);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "增加功能权限";
            // 
            // gcAdd
            // 
            this.gcAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcAdd.Location = new System.Drawing.Point(2, 23);
            this.gcAdd.MainView = this.gvAdd;
            this.gcAdd.Name = "gcAdd";
            this.gcAdd.Size = new System.Drawing.Size(409, 441);
            this.gcAdd.TabIndex = 0;
            this.gcAdd.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvAdd});
            // 
            // gvAdd
            // 
            this.gvAdd.GridControl = this.gcAdd;
            this.gvAdd.IndicatorWidth = 45;
            this.gvAdd.Name = "gvAdd";
            this.gvAdd.OptionsBehavior.Editable = false;
            this.gvAdd.OptionsBehavior.ReadOnly = true;
            this.gvAdd.OptionsView.ShowGroupPanel = false;
            // 
            // FrmSingleFunctionAuthorityChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 491);
            this.Controls.Add(this.groupControl1);
            this.Name = "FrmSingleFunctionAuthorityChange";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "功能权限变更明细";
            this.Load += new System.EventHandler(this.FrmSingleFunctionAuthorityChange_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcDel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAdd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraGrid.GridControl gcDel;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDel;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl gcAdd;
        private DevExpress.XtraGrid.Views.Grid.GridView gvAdd;
    }
}