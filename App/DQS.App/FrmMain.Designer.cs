namespace DQS.App
{
    partial class FrmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.pnlTop = new DevExpress.XtraEditors.PanelControl();
            this.hleWarning = new DevExpress.XtraEditors.HyperLinkEdit();
            this.hleApproveNote = new DevExpress.XtraEditors.HyperLinkEdit();
            this.pnlUserInfo = new DevExpress.XtraEditors.PanelControl();
            this.lblDate = new DevExpress.XtraEditors.LabelControl();
            this.lblWelcome = new DevExpress.XtraEditors.LabelControl();
            this.lblUserName = new DevExpress.XtraEditors.LabelControl();
            this.picTitle = new DevExpress.XtraEditors.PictureEdit();
            this.btnNavMainMenu = new DQS.Controls.ButtonNavigator();
            this.splitterTop = new DevExpress.XtraEditors.SplitterControl();
            this.navBarMenu = new DevExpress.XtraNavBar.NavBarControl();
            this.splitterLeft = new DevExpress.XtraEditors.SplitterControl();
            this.gpcFastQuery = new DevExpress.XtraEditors.GroupControl();
            this.btnNavFastQuery = new DQS.Controls.ButtonNavigator();
            this.splitterButtom = new DevExpress.XtraEditors.SplitterControl();
            this.tbControlMain = new DevExpress.XtraTab.XtraTabControl();
            this.tbMain = new DevExpress.XtraTab.XtraTabPage();
            this.defaultLookAndFeel = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.alertControl = new DevExpress.XtraBars.Alerter.AlertControl(this.components);
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.dockManager = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.hideContainerRight = new DevExpress.XtraBars.Docking.AutoHideContainer();
            this.dockPanel = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            ((System.ComponentModel.ISupportInitialize)(this.pnlTop)).BeginInit();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hleWarning.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hleApproveNote.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlUserInfo)).BeginInit();
            this.pnlUserInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTitle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNavMainMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gpcFastQuery)).BeginInit();
            this.gpcFastQuery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnNavFastQuery)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbControlMain)).BeginInit();
            this.tbControlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager)).BeginInit();
            this.hideContainerRight.SuspendLayout();
            this.dockPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.hleWarning);
            this.pnlTop.Controls.Add(this.hleApproveNote);
            this.pnlTop.Controls.Add(this.pnlUserInfo);
            this.pnlTop.Controls.Add(this.picTitle);
            this.pnlTop.Controls.Add(this.btnNavMainMenu);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1241, 107);
            this.pnlTop.TabIndex = 0;
            // 
            // hleWarning
            // 
            this.hleWarning.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.hleWarning.EditValue = "点击查看系统预警信息";
            this.hleWarning.Location = new System.Drawing.Point(770, 5);
            this.hleWarning.Margin = new System.Windows.Forms.Padding(4);
            this.hleWarning.Name = "hleWarning";
            this.hleWarning.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.hleWarning.Properties.Appearance.Options.UseBackColor = true;
            this.hleWarning.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.hleWarning.Size = new System.Drawing.Size(166, 23);
            this.hleWarning.TabIndex = 4;
            this.hleWarning.Visible = false;
            this.hleWarning.OpenLink += new DevExpress.XtraEditors.Controls.OpenLinkEventHandler(this.hleWarning_OpenLink);
            // 
            // hleApproveNote
            // 
            this.hleApproveNote.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.hleApproveNote.EditValue = "您有0个待批复的单据";
            this.hleApproveNote.Location = new System.Drawing.Point(580, 6);
            this.hleApproveNote.Margin = new System.Windows.Forms.Padding(4);
            this.hleApproveNote.Name = "hleApproveNote";
            this.hleApproveNote.Properties.AllowFocused = false;
            this.hleApproveNote.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.hleApproveNote.Properties.Appearance.Options.UseBackColor = true;
            this.hleApproveNote.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.hleApproveNote.Size = new System.Drawing.Size(166, 23);
            this.hleApproveNote.TabIndex = 3;
            this.hleApproveNote.Visible = false;
            this.hleApproveNote.OpenLink += new DevExpress.XtraEditors.Controls.OpenLinkEventHandler(this.hleApproveNote_OpenLink);
            // 
            // pnlUserInfo
            // 
            this.pnlUserInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlUserInfo.Controls.Add(this.lblDate);
            this.pnlUserInfo.Controls.Add(this.lblWelcome);
            this.pnlUserInfo.Controls.Add(this.lblUserName);
            this.pnlUserInfo.Location = new System.Drawing.Point(944, 1);
            this.pnlUserInfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlUserInfo.Name = "pnlUserInfo";
            this.pnlUserInfo.Size = new System.Drawing.Size(296, 29);
            this.pnlUserInfo.TabIndex = 2;
            // 
            // lblDate
            // 
            this.lblDate.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Appearance.Options.UseFont = true;
            this.lblDate.Location = new System.Drawing.Point(117, 6);
            this.lblDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(170, 20);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "2011年12月30日 星期三 ";
            // 
            // lblWelcome
            // 
            this.lblWelcome.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Appearance.Options.UseFont = true;
            this.lblWelcome.Location = new System.Drawing.Point(8, 6);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(30, 20);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "欢迎";
            // 
            // lblUserName
            // 
            this.lblUserName.Appearance.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Appearance.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblUserName.Appearance.Options.UseFont = true;
            this.lblUserName.Appearance.Options.UseForeColor = true;
            this.lblUserName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblUserName.Location = new System.Drawing.Point(54, 4);
            this.lblUserName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(53, 21);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "管理员 ";
            this.lblUserName.ToolTip = "点击修改密码";
            this.lblUserName.Click += new System.EventHandler(this.lblUserName_Click);
            // 
            // picTitle
            // 
            this.picTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.picTitle.EditValue = global::DQS.App.Properties.Resources.标题2;
            this.picTitle.Location = new System.Drawing.Point(2, 2);
            this.picTitle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picTitle.Name = "picTitle";
            this.picTitle.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.picTitle.Properties.Appearance.Options.UseBackColor = true;
            this.picTitle.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.picTitle.Size = new System.Drawing.Size(558, 50);
            this.picTitle.TabIndex = 1;
            // 
            // btnNavMainMenu
            // 
            this.btnNavMainMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnNavMainMenu.FirstButtonLocation = new System.Drawing.Point(5, 5);
            this.btnNavMainMenu.FontSize = 10F;
            this.btnNavMainMenu.HMargin = 10;
            this.btnNavMainMenu.IsAutoHeight = false;
            this.btnNavMainMenu.IsAutoWidth = false;
            this.btnNavMainMenu.IsLeftToCenter = false;
            this.btnNavMainMenu.IsTopToCenter = true;
            this.btnNavMainMenu.Location = new System.Drawing.Point(2, 52);
            this.btnNavMainMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNavMainMenu.MinButtonSize = new System.Drawing.Size(112, 30);
            this.btnNavMainMenu.Multiline = false;
            this.btnNavMainMenu.Name = "btnNavMainMenu";
            this.btnNavMainMenu.Size = new System.Drawing.Size(1237, 53);
            this.btnNavMainMenu.TabIndex = 0;
            this.btnNavMainMenu.VMargin = 10;
            this.btnNavMainMenu.ButtonClicked += new DQS.Controls.ButtonNavigator.OnButtonClicked(this.btnNavMainMenu_ButtonClicked);
            // 
            // splitterTop
            // 
            this.splitterTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitterTop.Location = new System.Drawing.Point(0, 107);
            this.splitterTop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.splitterTop.Name = "splitterTop";
            this.splitterTop.Size = new System.Drawing.Size(1241, 6);
            this.splitterTop.TabIndex = 1;
            this.splitterTop.TabStop = false;
            // 
            // navBarMenu
            // 
            this.navBarMenu.ActiveGroup = null;
            this.navBarMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.navBarMenu.Location = new System.Drawing.Point(0, 113);
            this.navBarMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.navBarMenu.Name = "navBarMenu";
            this.navBarMenu.OptionsNavPane.ExpandedWidth = 171;
            this.navBarMenu.Size = new System.Drawing.Size(220, 666);
            this.navBarMenu.TabIndex = 2;
            this.navBarMenu.Text = "navBarControl1";
            // 
            // splitterLeft
            // 
            this.splitterLeft.Location = new System.Drawing.Point(220, 113);
            this.splitterLeft.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.splitterLeft.Name = "splitterLeft";
            this.splitterLeft.Size = new System.Drawing.Size(6, 666);
            this.splitterLeft.TabIndex = 3;
            this.splitterLeft.TabStop = false;
            // 
            // gpcFastQuery
            // 
            this.gpcFastQuery.AppearanceCaption.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpcFastQuery.AppearanceCaption.Options.UseFont = true;
            this.gpcFastQuery.Controls.Add(this.btnNavFastQuery);
            this.gpcFastQuery.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gpcFastQuery.Location = new System.Drawing.Point(226, 670);
            this.gpcFastQuery.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gpcFastQuery.Name = "gpcFastQuery";
            this.gpcFastQuery.Size = new System.Drawing.Size(1015, 109);
            this.gpcFastQuery.TabIndex = 4;
            this.gpcFastQuery.Text = "快速查询";
            // 
            // btnNavFastQuery
            // 
            this.btnNavFastQuery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNavFastQuery.FirstButtonLocation = new System.Drawing.Point(5, 5);
            this.btnNavFastQuery.FontSize = 9F;
            this.btnNavFastQuery.HMargin = 5;
            this.btnNavFastQuery.IsAutoHeight = false;
            this.btnNavFastQuery.IsAutoWidth = false;
            this.btnNavFastQuery.IsLeftToCenter = false;
            this.btnNavFastQuery.IsTopToCenter = false;
            this.btnNavFastQuery.Location = new System.Drawing.Point(2, 28);
            this.btnNavFastQuery.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNavFastQuery.MinButtonSize = new System.Drawing.Size(156, 25);
            this.btnNavFastQuery.Multiline = true;
            this.btnNavFastQuery.Name = "btnNavFastQuery";
            this.btnNavFastQuery.Size = new System.Drawing.Size(1011, 79);
            this.btnNavFastQuery.TabIndex = 0;
            this.btnNavFastQuery.VMargin = 5;
            // 
            // splitterButtom
            // 
            this.splitterButtom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitterButtom.Location = new System.Drawing.Point(226, 664);
            this.splitterButtom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.splitterButtom.Name = "splitterButtom";
            this.splitterButtom.Size = new System.Drawing.Size(1015, 6);
            this.splitterButtom.TabIndex = 5;
            this.splitterButtom.TabStop = false;
            // 
            // tbControlMain
            // 
            this.tbControlMain.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbControlMain.Appearance.Options.UseFont = true;
            this.tbControlMain.AppearancePage.HeaderActive.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbControlMain.AppearancePage.HeaderActive.Options.UseFont = true;
            this.tbControlMain.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InActiveTabPageAndTabControlHeader;
            this.tbControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbControlMain.Location = new System.Drawing.Point(226, 113);
            this.tbControlMain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbControlMain.Name = "tbControlMain";
            this.tbControlMain.SelectedTabPage = this.tbMain;
            this.tbControlMain.Size = new System.Drawing.Size(1015, 551);
            this.tbControlMain.TabIndex = 6;
            this.tbControlMain.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tbMain});
            this.tbControlMain.SelectedPageChanged += new DevExpress.XtraTab.TabPageChangedEventHandler(this.tbControlMain_SelectedPageChanged);
            this.tbControlMain.HotTrackedPageChanged += new DevExpress.XtraTab.TabPageChangedEventHandler(this.tbControlMain_HotTrackedPageChanged);
            this.tbControlMain.CloseButtonClick += new System.EventHandler(this.tbControlMain_CloseButtonClick);
            this.tbControlMain.DoubleClick += new System.EventHandler(this.tbControlMain_DoubleClick);
            // 
            // tbMain
            // 
            this.tbMain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbMain.Name = "tbMain";
            this.tbMain.Size = new System.Drawing.Size(1008, 514);
            this.tbMain.Text = "首页";
            // 
            // defaultLookAndFeel
            // 
            this.defaultLookAndFeel.LookAndFeel.SkinName = "McSkin";
            // 
            // alertControl
            // 
            this.alertControl.Images = this.imageList;
            this.alertControl.LookAndFeel.SkinName = "Blue";
            this.alertControl.LookAndFeel.UseDefaultLookAndFeel = false;
            this.alertControl.AlertClick += new DevExpress.XtraBars.Alerter.AlertClickEventHandler(this.alertControl_AlertClick);
            this.alertControl.FormLoad += new DevExpress.XtraBars.Alerter.AlertFormLoadEventHandler(this.alertControl_FormLoad);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "Warning_Triangle.png");
            // 
            // dockManager
            // 
            this.dockManager.AutoHideContainers.AddRange(new DevExpress.XtraBars.Docking.AutoHideContainer[] {
            this.hideContainerRight});
            this.dockManager.DockMode = DevExpress.XtraBars.Docking.Helpers.DockMode.Standard;
            this.dockManager.Form = this;
            this.dockManager.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl"});
            // 
            // hideContainerRight
            // 
            this.hideContainerRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(245)))), ((int)(((byte)(241)))));
            this.hideContainerRight.Controls.Add(this.dockPanel);
            this.hideContainerRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.hideContainerRight.Location = new System.Drawing.Point(1241, 0);
            this.hideContainerRight.Name = "hideContainerRight";
            this.hideContainerRight.Size = new System.Drawing.Size(24, 779);
            // 
            // dockPanel
            // 
            this.dockPanel.Controls.Add(this.dockPanel_Container);
            this.dockPanel.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right;
            this.dockPanel.Hint = "查看消息历史记录";
            this.dockPanel.ID = new System.Guid("c8762968-e058-4a34-8d13-05b8f143352a");
            this.dockPanel.Location = new System.Drawing.Point(0, 0);
            this.dockPanel.Name = "dockPanel";
            this.dockPanel.Options.AllowDockFill = false;
            this.dockPanel.Options.AllowFloating = false;
            this.dockPanel.Options.FloatOnDblClick = false;
            this.dockPanel.OriginalSize = new System.Drawing.Size(520, 200);
            this.dockPanel.SavedDock = DevExpress.XtraBars.Docking.DockingStyle.Right;
            this.dockPanel.SavedIndex = 0;
            this.dockPanel.Size = new System.Drawing.Size(520, 779);
            this.dockPanel.TabText = "消息历史记录";
            this.dockPanel.Text = "消息历史记录";
            this.dockPanel.Visibility = DevExpress.XtraBars.Docking.DockVisibility.AutoHide;
            // 
            // dockPanel_Container
            // 
            this.dockPanel_Container.Location = new System.Drawing.Point(3, 26);
            this.dockPanel_Container.Name = "dockPanel_Container";
            this.dockPanel_Container.Size = new System.Drawing.Size(514, 750);
            this.dockPanel_Container.TabIndex = 0;
            // 
            // FrmMain
            // 
            this.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 779);
            this.Controls.Add(this.tbControlMain);
            this.Controls.Add(this.splitterButtom);
            this.Controls.Add(this.gpcFastQuery);
            this.Controls.Add(this.splitterLeft);
            this.Controls.Add(this.navBarMenu);
            this.Controls.Add(this.splitterTop);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.hideContainerRight);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.LookAndFeel.SkinName = "Blue";
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "DQS药品经营质量管理系统";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnlTop)).EndInit();
            this.pnlTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hleWarning.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hleApproveNote.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlUserInfo)).EndInit();
            this.pnlUserInfo.ResumeLayout(false);
            this.pnlUserInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTitle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNavMainMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gpcFastQuery)).EndInit();
            this.gpcFastQuery.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnNavFastQuery)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbControlMain)).EndInit();
            this.tbControlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dockManager)).EndInit();
            this.hideContainerRight.ResumeLayout(false);
            this.dockPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pnlTop;
        private DevExpress.XtraEditors.SplitterControl splitterTop;
        private DevExpress.XtraNavBar.NavBarControl navBarMenu;
        private DevExpress.XtraEditors.SplitterControl splitterLeft;
        private DevExpress.XtraEditors.GroupControl gpcFastQuery;
        private DevExpress.XtraEditors.SplitterControl splitterButtom;
        private DevExpress.XtraTab.XtraTabControl tbControlMain;
        private DevExpress.XtraTab.XtraTabPage tbMain;
        private DQS.Controls.ButtonNavigator btnNavMainMenu;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel;
        private DevExpress.XtraEditors.PictureEdit picTitle;
        private DevExpress.XtraEditors.PanelControl pnlUserInfo;
        private DevExpress.XtraEditors.LabelControl lblUserName;
        private DevExpress.XtraEditors.LabelControl lblDate;
        private DevExpress.XtraEditors.LabelControl lblWelcome;
        private DQS.Controls.ButtonNavigator btnNavFastQuery;
        private DevExpress.XtraEditors.HyperLinkEdit hleApproveNote;
        private DevExpress.XtraEditors.HyperLinkEdit hleWarning;
        private DevExpress.XtraBars.Alerter.AlertControl alertControl;
        private System.Windows.Forms.ImageList imageList;
        private DevExpress.XtraBars.Docking.DockManager dockManager;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel_Container;
        private DevExpress.XtraBars.Docking.AutoHideContainer hideContainerRight;
    }
}