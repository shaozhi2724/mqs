namespace DQS.Controls
{
    partial class FrmPopupQuery
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
            this.pnlTop = new DevExpress.XtraEditors.PanelControl();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnQuery = new DevExpress.XtraEditors.SimpleButton();
            this.txtQuery = new DQS.Controls.TextBoxQueryEx();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.pageNavigator = new DQS.Controls.PageNavigator();
            this.gvControl = new DevExpress.XtraGrid.GridControl();
            this.gvData = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.pnlTop)).BeginInit();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuery.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageNavigator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvData)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.btnClose);
            this.pnlTop.Controls.Add(this.btnQuery);
            this.pnlTop.Controls.Add(this.txtQuery);
            this.pnlTop.Controls.Add(this.labelControl1);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(804, 44);
            this.pnlTop.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Appearance.Options.UseFont = true;
            this.btnClose.Location = new System.Drawing.Point(466, 11);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "关闭(&C)";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnQuery
            // 
            this.btnQuery.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuery.Appearance.Options.UseFont = true;
            this.btnQuery.Location = new System.Drawing.Point(373, 11);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 23);
            this.btnQuery.TabIndex = 2;
            this.btnQuery.Text = "查询(&Q)";
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // txtQuery
            // 
            this.txtQuery.FormatQueryString = null;
            this.txtQuery.Location = new System.Drawing.Point(108, 13);
            this.txtQuery.Name = "txtQuery";
            this.txtQuery.Size = new System.Drawing.Size(249, 21);
            this.txtQuery.TabIndex = 1;
            this.txtQuery.TextChanged += new System.EventHandler(this.txtQuery_TextChanged);
            this.txtQuery.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuery_KeyPress);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(12, 15);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(80, 17);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "编号或名称(&U):";
            // 
            // pageNavigator
            // 
            this.pageNavigator.DefaultFilter = "";
            this.pageNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pageNavigator.EmptySource = null;
            this.pageNavigator.Fields = "*";
            this.pageNavigator.Filter = "";
            this.pageNavigator.GridControl = this.gvControl;
            this.pageNavigator.Location = new System.Drawing.Point(0, 437);
            this.pageNavigator.MinimumSize = new System.Drawing.Size(800, 40);
            this.pageNavigator.Name = "pageNavigator";
            this.pageNavigator.PageCount = 0;
            this.pageNavigator.PageIndex = 0;
            this.pageNavigator.PageSize = 50;
            this.pageNavigator.PrimaryField = null;
            this.pageNavigator.RecordCount = 0;
            this.pageNavigator.Size = new System.Drawing.Size(804, 40);
            this.pageNavigator.SortField = "";
            this.pageNavigator.SortType = "";
            this.pageNavigator.TabIndex = 2;
            this.pageNavigator.ViewName = "";
            // 
            // gvControl
            // 
            this.gvControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvControl.Location = new System.Drawing.Point(0, 44);
            this.gvControl.MainView = this.gvData;
            this.gvControl.Name = "gvControl";
            this.gvControl.Size = new System.Drawing.Size(804, 393);
            this.gvControl.TabIndex = 1;
            this.gvControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvData});
            // 
            // gvData
            // 
            this.gvData.Appearance.EvenRow.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gvData.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvData.Appearance.FocusedCell.BackColor = System.Drawing.Color.Aqua;
            this.gvData.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvData.Appearance.FocusedRow.BackColor = System.Drawing.Color.Beige;
            this.gvData.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black;
            this.gvData.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvData.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvData.Appearance.HeaderPanel.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.gvData.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvData.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gvData.GridControl = this.gvControl;
            this.gvData.IndicatorWidth = 43;
            this.gvData.Name = "gvData";
            this.gvData.OptionsBehavior.Editable = false;
            this.gvData.OptionsNavigation.EnterMoveNextColumn = true;
            this.gvData.OptionsView.EnableAppearanceEvenRow = true;
            this.gvData.OptionsView.ShowGroupPanel = false;
            this.gvData.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gvData_RowClick);
            this.gvData.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gvData_CustomDrawRowIndicator);
            this.gvData.DoubleClick += new System.EventHandler(this.gvData_DoubleClick);
            // 
            // FrmPopupQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 477);
            this.Controls.Add(this.gvControl);
            this.Controls.Add(this.pageNavigator);
            this.Controls.Add(this.pnlTop);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(820, 427);
            this.Name = "FrmPopupQuery";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "双击选择项";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmPopupQuery_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnlTop)).EndInit();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuery.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageNavigator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pnlTop;
        private PageNavigator pageNavigator;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        protected DevExpress.XtraGrid.GridControl gvControl;
        protected DevExpress.XtraGrid.Views.Grid.GridView gvData;
        private TextBoxQueryEx txtQuery;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.SimpleButton btnQuery;
    }
}