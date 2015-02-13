namespace DQS.Controls
{
    partial class FrmApproveStatus
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
            this.pnlButtom = new DevExpress.XtraEditors.PanelControl();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.gpcTop = new DevExpress.XtraEditors.GroupControl();
            this.layControl = new DevExpress.XtraLayout.LayoutControl();
            this.txtIsPass = new DevExpress.XtraEditors.TextEdit();
            this.txtIsWhole = new DevExpress.XtraEditors.TextEdit();
            this.txtCreateDate = new DevExpress.XtraEditors.TextEdit();
            this.txtCreateUser = new DevExpress.XtraEditors.TextEdit();
            this.txtApprovalContent = new DevExpress.XtraEditors.MemoEdit();
            this.txtApproveTitle = new DevExpress.XtraEditors.TextEdit();
            this.txtApproveCode = new DevExpress.XtraEditors.TextEdit();
            this.layControlGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layApproveCode = new DevExpress.XtraLayout.LayoutControlItem();
            this.layApproveTitle = new DevExpress.XtraLayout.LayoutControlItem();
            this.layApprovalContent = new DevExpress.XtraLayout.LayoutControlItem();
            this.layCreateUser = new DevExpress.XtraLayout.LayoutControlItem();
            this.layCreateDate = new DevExpress.XtraLayout.LayoutControlItem();
            this.layIsWhole = new DevExpress.XtraLayout.LayoutControlItem();
            this.layIsPass = new DevExpress.XtraLayout.LayoutControlItem();
            this.gpcCenter = new DevExpress.XtraEditors.GroupControl();
            this.gvControl = new DevExpress.XtraGrid.GridControl();
            this.gvData = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colApprovalUser = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsApprovaled = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colApprovalDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colApproveOrder = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colApprovalSuggestion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colApprovalResult = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colApprovalRemark = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pnlButtom)).BeginInit();
            this.pnlButtom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gpcTop)).BeginInit();
            this.gpcTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layControl)).BeginInit();
            this.layControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtIsPass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIsWhole.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCreateDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCreateUser.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtApprovalContent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtApproveTitle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtApproveCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layControlGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layApproveCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layApproveTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layApprovalContent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layCreateUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layCreateDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layIsWhole)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layIsPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gpcCenter)).BeginInit();
            this.gpcCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvData)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlButtom
            // 
            this.pnlButtom.Controls.Add(this.btnClose);
            this.pnlButtom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButtom.Location = new System.Drawing.Point(0, 702);
            this.pnlButtom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlButtom.Name = "pnlButtom";
            this.pnlButtom.Size = new System.Drawing.Size(917, 58);
            this.pnlButtom.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(807, 12);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(86, 31);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "关闭(&C)";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // gpcTop
            // 
            this.gpcTop.Controls.Add(this.layControl);
            this.gpcTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.gpcTop.Location = new System.Drawing.Point(0, 0);
            this.gpcTop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpcTop.Name = "gpcTop";
            this.gpcTop.Size = new System.Drawing.Size(917, 292);
            this.gpcTop.TabIndex = 1;
            this.gpcTop.Text = "申请信息";
            // 
            // layControl
            // 
            this.layControl.Controls.Add(this.txtIsPass);
            this.layControl.Controls.Add(this.txtIsWhole);
            this.layControl.Controls.Add(this.txtCreateDate);
            this.layControl.Controls.Add(this.txtCreateUser);
            this.layControl.Controls.Add(this.txtApprovalContent);
            this.layControl.Controls.Add(this.txtApproveTitle);
            this.layControl.Controls.Add(this.txtApproveCode);
            this.layControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layControl.Location = new System.Drawing.Point(2, 27);
            this.layControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.layControl.Name = "layControl";
            this.layControl.OptionsView.DrawItemBorders = true;
            this.layControl.Root = this.layControlGroup;
            this.layControl.Size = new System.Drawing.Size(913, 263);
            this.layControl.TabIndex = 0;
            this.layControl.Text = "审批信息";
            // 
            // txtIsPass
            // 
            this.txtIsPass.Location = new System.Drawing.Point(521, 228);
            this.txtIsPass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtIsPass.Name = "txtIsPass";
            this.txtIsPass.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtIsPass.Properties.ReadOnly = true;
            this.txtIsPass.Size = new System.Drawing.Size(380, 23);
            this.txtIsPass.StyleController = this.layControl;
            this.txtIsPass.TabIndex = 10;
            // 
            // txtIsWhole
            // 
            this.txtIsWhole.Location = new System.Drawing.Point(75, 228);
            this.txtIsWhole.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtIsWhole.Name = "txtIsWhole";
            this.txtIsWhole.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtIsWhole.Properties.ReadOnly = true;
            this.txtIsWhole.Size = new System.Drawing.Size(379, 23);
            this.txtIsWhole.StyleController = this.layControl;
            this.txtIsWhole.TabIndex = 9;
            // 
            // txtCreateDate
            // 
            this.txtCreateDate.Location = new System.Drawing.Point(75, 201);
            this.txtCreateDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCreateDate.Name = "txtCreateDate";
            this.txtCreateDate.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtCreateDate.Properties.ReadOnly = true;
            this.txtCreateDate.Size = new System.Drawing.Size(826, 23);
            this.txtCreateDate.StyleController = this.layControl;
            this.txtCreateDate.TabIndex = 8;
            // 
            // txtCreateUser
            // 
            this.txtCreateUser.Location = new System.Drawing.Point(75, 174);
            this.txtCreateUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCreateUser.Name = "txtCreateUser";
            this.txtCreateUser.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtCreateUser.Properties.ReadOnly = true;
            this.txtCreateUser.Size = new System.Drawing.Size(826, 23);
            this.txtCreateUser.StyleController = this.layControl;
            this.txtCreateUser.TabIndex = 7;
            // 
            // txtApprovalContent
            // 
            this.txtApprovalContent.Location = new System.Drawing.Point(75, 66);
            this.txtApprovalContent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtApprovalContent.Name = "txtApprovalContent";
            this.txtApprovalContent.Properties.ReadOnly = true;
            this.txtApprovalContent.Size = new System.Drawing.Size(826, 104);
            this.txtApprovalContent.StyleController = this.layControl;
            this.txtApprovalContent.TabIndex = 6;
            // 
            // txtApproveTitle
            // 
            this.txtApproveTitle.Location = new System.Drawing.Point(75, 39);
            this.txtApproveTitle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtApproveTitle.Name = "txtApproveTitle";
            this.txtApproveTitle.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtApproveTitle.Properties.ReadOnly = true;
            this.txtApproveTitle.Size = new System.Drawing.Size(826, 23);
            this.txtApproveTitle.StyleController = this.layControl;
            this.txtApproveTitle.TabIndex = 5;
            // 
            // txtApproveCode
            // 
            this.txtApproveCode.Location = new System.Drawing.Point(75, 12);
            this.txtApproveCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtApproveCode.Name = "txtApproveCode";
            this.txtApproveCode.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtApproveCode.Properties.ReadOnly = true;
            this.txtApproveCode.Size = new System.Drawing.Size(826, 23);
            this.txtApproveCode.StyleController = this.layControl;
            this.txtApproveCode.TabIndex = 4;
            // 
            // layControlGroup
            // 
            this.layControlGroup.CustomizationFormText = "申请信息";
            this.layControlGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layControlGroup.GroupBordersVisible = false;
            this.layControlGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layApproveCode,
            this.layApproveTitle,
            this.layApprovalContent,
            this.layCreateUser,
            this.layCreateDate,
            this.layIsWhole,
            this.layIsPass});
            this.layControlGroup.Location = new System.Drawing.Point(0, 0);
            this.layControlGroup.Name = "layControlGroup";
            this.layControlGroup.Size = new System.Drawing.Size(913, 263);
            this.layControlGroup.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layControlGroup.Text = "申请信息";
            this.layControlGroup.TextVisible = false;
            // 
            // layApproveCode
            // 
            this.layApproveCode.Control = this.txtApproveCode;
            this.layApproveCode.CustomizationFormText = "编号";
            this.layApproveCode.Location = new System.Drawing.Point(0, 0);
            this.layApproveCode.Name = "layApproveCode";
            this.layApproveCode.Size = new System.Drawing.Size(893, 27);
            this.layApproveCode.Text = "编号";
            this.layApproveCode.TextSize = new System.Drawing.Size(60, 18);
            // 
            // layApproveTitle
            // 
            this.layApproveTitle.Control = this.txtApproveTitle;
            this.layApproveTitle.CustomizationFormText = "标题";
            this.layApproveTitle.Location = new System.Drawing.Point(0, 27);
            this.layApproveTitle.Name = "layApproveTitle";
            this.layApproveTitle.Size = new System.Drawing.Size(893, 27);
            this.layApproveTitle.Text = "标题";
            this.layApproveTitle.TextSize = new System.Drawing.Size(60, 18);
            // 
            // layApprovalContent
            // 
            this.layApprovalContent.Control = this.txtApprovalContent;
            this.layApprovalContent.CustomizationFormText = "内容";
            this.layApprovalContent.Location = new System.Drawing.Point(0, 54);
            this.layApprovalContent.Name = "layApprovalContent";
            this.layApprovalContent.Size = new System.Drawing.Size(893, 108);
            this.layApprovalContent.Text = "内容";
            this.layApprovalContent.TextSize = new System.Drawing.Size(60, 18);
            // 
            // layCreateUser
            // 
            this.layCreateUser.Control = this.txtCreateUser;
            this.layCreateUser.CustomizationFormText = "申请人";
            this.layCreateUser.Location = new System.Drawing.Point(0, 162);
            this.layCreateUser.Name = "layCreateUser";
            this.layCreateUser.Size = new System.Drawing.Size(893, 27);
            this.layCreateUser.Text = "申请人";
            this.layCreateUser.TextSize = new System.Drawing.Size(60, 18);
            // 
            // layCreateDate
            // 
            this.layCreateDate.Control = this.txtCreateDate;
            this.layCreateDate.CustomizationFormText = "申请时间";
            this.layCreateDate.Location = new System.Drawing.Point(0, 189);
            this.layCreateDate.Name = "layCreateDate";
            this.layCreateDate.Size = new System.Drawing.Size(893, 27);
            this.layCreateDate.Text = "申请时间";
            this.layCreateDate.TextSize = new System.Drawing.Size(60, 18);
            // 
            // layIsWhole
            // 
            this.layIsWhole.Control = this.txtIsWhole;
            this.layIsWhole.CustomizationFormText = "审批类型";
            this.layIsWhole.Location = new System.Drawing.Point(0, 216);
            this.layIsWhole.Name = "layIsWhole";
            this.layIsWhole.Size = new System.Drawing.Size(446, 27);
            this.layIsWhole.Text = "审批类型";
            this.layIsWhole.TextSize = new System.Drawing.Size(60, 18);
            // 
            // layIsPass
            // 
            this.layIsPass.Control = this.txtIsPass;
            this.layIsPass.CustomizationFormText = "状态";
            this.layIsPass.Location = new System.Drawing.Point(446, 216);
            this.layIsPass.Name = "layIsPass";
            this.layIsPass.Size = new System.Drawing.Size(447, 27);
            this.layIsPass.Text = "状态";
            this.layIsPass.TextSize = new System.Drawing.Size(60, 18);
            // 
            // gpcCenter
            // 
            this.gpcCenter.Controls.Add(this.gvControl);
            this.gpcCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpcCenter.Location = new System.Drawing.Point(0, 292);
            this.gpcCenter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpcCenter.Name = "gpcCenter";
            this.gpcCenter.Size = new System.Drawing.Size(917, 410);
            this.gpcCenter.TabIndex = 2;
            this.gpcCenter.Text = "待审批人列表";
            // 
            // gvControl
            // 
            this.gvControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvControl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gvControl.Location = new System.Drawing.Point(2, 27);
            this.gvControl.MainView = this.gvData;
            this.gvControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gvControl.Name = "gvControl";
            this.gvControl.Size = new System.Drawing.Size(913, 381);
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
            this.gvData.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colApprovalUser,
            this.colIsApprovaled,
            this.colApprovalDate,
            this.colApproveOrder,
            this.colApprovalSuggestion,
            this.colApprovalResult,
            this.colApprovalRemark});
            this.gvData.GridControl = this.gvControl;
            this.gvData.IndicatorWidth = 40;
            this.gvData.Name = "gvData";
            this.gvData.OptionsBehavior.Editable = false;
            this.gvData.OptionsNavigation.EnterMoveNextColumn = true;
            this.gvData.OptionsView.EnableAppearanceEvenRow = true;
            this.gvData.OptionsView.ShowGroupPanel = false;
            this.gvData.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gvData_CustomDrawRowIndicator);
            this.gvData.CustomDrawEmptyForeground += new DevExpress.XtraGrid.Views.Base.CustomDrawEventHandler(this.gvData_CustomDrawEmptyForeground);
            // 
            // colApprovalUser
            // 
            this.colApprovalUser.Caption = "审批人";
            this.colApprovalUser.FieldName = "审批人";
            this.colApprovalUser.Name = "colApprovalUser";
            this.colApprovalUser.Visible = true;
            this.colApprovalUser.VisibleIndex = 0;
            // 
            // colIsApprovaled
            // 
            this.colIsApprovaled.Caption = "是否审批";
            this.colIsApprovaled.FieldName = "是否审批";
            this.colIsApprovaled.Name = "colIsApprovaled";
            this.colIsApprovaled.Visible = true;
            this.colIsApprovaled.VisibleIndex = 1;
            // 
            // colApprovalDate
            // 
            this.colApprovalDate.Caption = "审批时间";
            this.colApprovalDate.FieldName = "审批时间";
            this.colApprovalDate.Name = "colApprovalDate";
            this.colApprovalDate.Visible = true;
            this.colApprovalDate.VisibleIndex = 2;
            // 
            // colApproveOrder
            // 
            this.colApproveOrder.Caption = "审批顺序";
            this.colApproveOrder.FieldName = "审批顺序";
            this.colApproveOrder.Name = "colApproveOrder";
            this.colApproveOrder.Visible = true;
            this.colApproveOrder.VisibleIndex = 3;
            // 
            // colApprovalSuggestion
            // 
            this.colApprovalSuggestion.Caption = "审批意见";
            this.colApprovalSuggestion.FieldName = "审批意见";
            this.colApprovalSuggestion.Name = "colApprovalSuggestion";
            this.colApprovalSuggestion.Visible = true;
            this.colApprovalSuggestion.VisibleIndex = 4;
            // 
            // colApprovalResult
            // 
            this.colApprovalResult.Caption = "审批结果";
            this.colApprovalResult.FieldName = "审批结果";
            this.colApprovalResult.Name = "colApprovalResult";
            this.colApprovalResult.Visible = true;
            this.colApprovalResult.VisibleIndex = 5;
            // 
            // colApprovalRemark
            // 
            this.colApprovalRemark.Caption = "备注";
            this.colApprovalRemark.FieldName = "备注";
            this.colApprovalRemark.Name = "colApprovalRemark";
            this.colApprovalRemark.Visible = true;
            this.colApprovalRemark.VisibleIndex = 6;
            // 
            // FrmApproveStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 760);
            this.Controls.Add(this.gpcCenter);
            this.Controls.Add(this.gpcTop);
            this.Controls.Add(this.pnlButtom);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmApproveStatus";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "审批状态";
            this.Load += new System.EventHandler(this.FrmApproveStatus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnlButtom)).EndInit();
            this.pnlButtom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gpcTop)).EndInit();
            this.gpcTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layControl)).EndInit();
            this.layControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtIsPass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIsWhole.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCreateDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCreateUser.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtApprovalContent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtApproveTitle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtApproveCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layControlGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layApproveCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layApproveTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layApprovalContent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layCreateUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layCreateDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layIsWhole)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layIsPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gpcCenter)).EndInit();
            this.gpcCenter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pnlButtom;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.GroupControl gpcTop;
        private DevExpress.XtraEditors.GroupControl gpcCenter;
        private DevExpress.XtraGrid.GridControl gvControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gvData;
        private DevExpress.XtraLayout.LayoutControl layControl;
        private DevExpress.XtraEditors.TextEdit txtApproveCode;
        private DevExpress.XtraLayout.LayoutControlGroup layControlGroup;
        private DevExpress.XtraLayout.LayoutControlItem layApproveCode;
        private DevExpress.XtraEditors.TextEdit txtApproveTitle;
        private DevExpress.XtraLayout.LayoutControlItem layApproveTitle;
        private DevExpress.XtraEditors.TextEdit txtCreateDate;
        private DevExpress.XtraEditors.TextEdit txtCreateUser;
        private DevExpress.XtraEditors.MemoEdit txtApprovalContent;
        private DevExpress.XtraLayout.LayoutControlItem layApprovalContent;
        private DevExpress.XtraLayout.LayoutControlItem layCreateUser;
        private DevExpress.XtraLayout.LayoutControlItem layCreateDate;
        private DevExpress.XtraGrid.Columns.GridColumn colApprovalUser;
        private DevExpress.XtraGrid.Columns.GridColumn colIsApprovaled;
        private DevExpress.XtraGrid.Columns.GridColumn colApprovalDate;
        private DevExpress.XtraGrid.Columns.GridColumn colApproveOrder;
        private DevExpress.XtraEditors.TextEdit txtIsPass;
        private DevExpress.XtraEditors.TextEdit txtIsWhole;
        private DevExpress.XtraLayout.LayoutControlItem layIsWhole;
        private DevExpress.XtraLayout.LayoutControlItem layIsPass;
        private DevExpress.XtraGrid.Columns.GridColumn colApprovalSuggestion;
        private DevExpress.XtraGrid.Columns.GridColumn colApprovalResult;
        private DevExpress.XtraGrid.Columns.GridColumn colApprovalRemark;
    }
}