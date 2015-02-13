namespace DQS.App
{
    partial class FrmCategorySetting
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cboType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnDel = new DevExpress.XtraEditors.SimpleButton();
            this.gridCategory = new DQS.Controls.StandardGrid();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.lblTypeUpdate = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.txtNew = new DQS.Controls.TextBoxEx();
            this.txtOld = new DQS.Controls.TextBoxEx();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.lblType = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.btnCancelAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btnSaveNew = new DevExpress.XtraEditors.SimpleButton();
            this.txtAddNew = new DQS.Controls.TextBoxEx();
            this.panelAdd = new DevExpress.XtraEditors.PanelControl();
            this.panelChange = new DevExpress.XtraEditors.PanelControl();
            this.panelchoose = new DevExpress.XtraEditors.PanelControl();
            this.xtcCategoryMain = new DevExpress.XtraTab.XtraTabControl();
            this.xtbBillStyle = new DevExpress.XtraTab.XtraTabPage();
            this.panelProductStyle = new DevExpress.XtraEditors.PanelControl();
            this.btnDelProductStyle = new DevExpress.XtraEditors.SimpleButton();
            this.btnSaveProductStyle = new DevExpress.XtraEditors.SimpleButton();
            this.lblStyle = new DevExpress.XtraEditors.LabelControl();
            this.cboProductStyle = new DevExpress.XtraEditors.ComboBoxEdit();
            this.gridControlProductStyle = new DevExpress.XtraGrid.GridControl();
            this.gridViewProductStyle = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panelAddStyle = new DevExpress.XtraEditors.PanelControl();
            this.txtStyleName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.btnCancelStye = new DevExpress.XtraEditors.SimpleButton();
            this.btnSaveStyle = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.gridControlStyle = new DevExpress.XtraGrid.GridControl();
            this.gridViewStyle = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnDelStyle = new DevExpress.XtraEditors.SimpleButton();
            this.btnReSetStyle = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddStyle = new DevExpress.XtraEditors.SimpleButton();
            this.xtbCategory = new DevExpress.XtraTab.XtraTabPage();
            ((System.ComponentModel.ISupportInitialize)(this.cboType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNew.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOld.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddNew.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelAdd)).BeginInit();
            this.panelAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelChange)).BeginInit();
            this.panelChange.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelchoose)).BeginInit();
            this.panelchoose.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtcCategoryMain)).BeginInit();
            this.xtcCategoryMain.SuspendLayout();
            this.xtbBillStyle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelProductStyle)).BeginInit();
            this.panelProductStyle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboProductStyle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlProductStyle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProductStyle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelAddStyle)).BeginInit();
            this.panelAddStyle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtStyleName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlStyle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewStyle)).BeginInit();
            this.xtbCategory.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(16, 30);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(24, 17);
            this.labelControl1.TabIndex = 9;
            this.labelControl1.Text = "类型";
            // 
            // cboType
            // 
            this.cboType.Location = new System.Drawing.Point(51, 27);
            this.cboType.Name = "cboType";
            this.cboType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboType.Size = new System.Drawing.Size(187, 21);
            this.cboType.TabIndex = 8;
            this.cboType.SelectedIndexChanged += new System.EventHandler(this.cboType_SelectedIndexChanged);
            this.cboType.TextChanged += new System.EventHandler(this.cboType_TextChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Appearance.Options.UseFont = true;
            this.btnAdd.Location = new System.Drawing.Point(245, 25);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(70, 27);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "新建";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Appearance.Options.UseFont = true;
            this.btnUpdate.Location = new System.Drawing.Point(322, 25);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(70, 27);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "修改";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDel
            // 
            this.btnDel.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.Appearance.Options.UseFont = true;
            this.btnDel.Location = new System.Drawing.Point(399, 25);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(70, 27);
            this.btnDel.TabIndex = 5;
            this.btnDel.Text = "删除";
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // gridCategory
            // 
            this.gridCategory.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridCategory.Filter = null;
            this.gridCategory.Location = new System.Drawing.Point(2, 55);
            this.gridCategory.Name = "gridCategory";
            this.gridCategory.Size = new System.Drawing.Size(470, 378);
            this.gridCategory.TabIndex = 0;
            this.gridCategory.ViewName = null;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(5, 196);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(36, 17);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "新值：";
            // 
            // lblTypeUpdate
            // 
            this.lblTypeUpdate.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTypeUpdate.Appearance.Options.UseFont = true;
            this.lblTypeUpdate.Location = new System.Drawing.Point(74, 97);
            this.lblTypeUpdate.Name = "lblTypeUpdate";
            this.lblTypeUpdate.Size = new System.Drawing.Size(56, 17);
            this.lblTypeUpdate.TabIndex = 9;
            this.lblTypeUpdate.Text = "请选择……";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(5, 142);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(36, 17);
            this.labelControl2.TabIndex = 9;
            this.labelControl2.Text = "旧值：";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(5, 97);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(36, 17);
            this.labelControl6.TabIndex = 9;
            this.labelControl6.Text = "类型：";
            // 
            // btnCancel
            // 
            this.btnCancel.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Appearance.Options.UseFont = true;
            this.btnCancel.Location = new System.Drawing.Point(151, 268);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(70, 27);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "取消";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.Location = new System.Drawing.Point(74, 268);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(70, 27);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "保存";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtNew
            // 
            this.txtNew.AlphabeticFiled = null;
            this.txtNew.IsIntegerOnly = false;
            this.txtNew.IsNullString = null;
            this.txtNew.IsNullValidate = false;
            this.txtNew.IsTransferAlphabetic = false;
            this.txtNew.Location = new System.Drawing.Point(74, 192);
            this.txtNew.Name = "txtNew";
            this.txtNew.Size = new System.Drawing.Size(187, 21);
            this.txtNew.TabIndex = 2;
            // 
            // txtOld
            // 
            this.txtOld.AlphabeticFiled = null;
            this.txtOld.IsIntegerOnly = false;
            this.txtOld.IsNullString = null;
            this.txtOld.IsNullValidate = false;
            this.txtOld.IsTransferAlphabetic = false;
            this.txtOld.Location = new System.Drawing.Point(74, 140);
            this.txtOld.Name = "txtOld";
            this.txtOld.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtOld.Properties.Appearance.Options.UseBackColor = true;
            this.txtOld.Properties.ReadOnly = true;
            this.txtOld.Size = new System.Drawing.Size(187, 21);
            this.txtOld.TabIndex = 2;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(5, 195);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(36, 17);
            this.labelControl4.TabIndex = 9;
            this.labelControl4.Text = "新建：";
            // 
            // lblType
            // 
            this.lblType.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Appearance.Options.UseFont = true;
            this.lblType.Location = new System.Drawing.Point(74, 97);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(56, 17);
            this.lblType.TabIndex = 9;
            this.lblType.Text = "请选择……";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(5, 97);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(36, 17);
            this.labelControl5.TabIndex = 9;
            this.labelControl5.Text = "类型：";
            // 
            // btnCancelAdd
            // 
            this.btnCancelAdd.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelAdd.Appearance.Options.UseFont = true;
            this.btnCancelAdd.Location = new System.Drawing.Point(151, 268);
            this.btnCancelAdd.Name = "btnCancelAdd";
            this.btnCancelAdd.Size = new System.Drawing.Size(70, 27);
            this.btnCancelAdd.TabIndex = 5;
            this.btnCancelAdd.Text = "取消";
            this.btnCancelAdd.Click += new System.EventHandler(this.btnCancelAdd_Click);
            // 
            // btnSaveNew
            // 
            this.btnSaveNew.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveNew.Appearance.Options.UseFont = true;
            this.btnSaveNew.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSaveNew.Location = new System.Drawing.Point(74, 268);
            this.btnSaveNew.Name = "btnSaveNew";
            this.btnSaveNew.Size = new System.Drawing.Size(70, 27);
            this.btnSaveNew.TabIndex = 5;
            this.btnSaveNew.Text = "保存";
            this.btnSaveNew.Click += new System.EventHandler(this.btnSaveNew_Click);
            // 
            // txtAddNew
            // 
            this.txtAddNew.AlphabeticFiled = null;
            this.txtAddNew.IsIntegerOnly = false;
            this.txtAddNew.IsNullString = null;
            this.txtAddNew.IsNullValidate = false;
            this.txtAddNew.IsTransferAlphabetic = false;
            this.txtAddNew.Location = new System.Drawing.Point(74, 192);
            this.txtAddNew.Name = "txtAddNew";
            this.txtAddNew.Size = new System.Drawing.Size(187, 21);
            this.txtAddNew.TabIndex = 2;
            // 
            // panelAdd
            // 
            this.panelAdd.Controls.Add(this.labelControl4);
            this.panelAdd.Controls.Add(this.lblType);
            this.panelAdd.Controls.Add(this.txtAddNew);
            this.panelAdd.Controls.Add(this.labelControl5);
            this.panelAdd.Controls.Add(this.btnSaveNew);
            this.panelAdd.Controls.Add(this.btnCancelAdd);
            this.panelAdd.Location = new System.Drawing.Point(496, 3);
            this.panelAdd.Name = "panelAdd";
            this.panelAdd.Size = new System.Drawing.Size(288, 434);
            this.panelAdd.TabIndex = 2;
            // 
            // panelChange
            // 
            this.panelChange.Controls.Add(this.labelControl3);
            this.panelChange.Controls.Add(this.lblTypeUpdate);
            this.panelChange.Controls.Add(this.txtOld);
            this.panelChange.Controls.Add(this.labelControl2);
            this.panelChange.Controls.Add(this.txtNew);
            this.panelChange.Controls.Add(this.labelControl6);
            this.panelChange.Controls.Add(this.btnSave);
            this.panelChange.Controls.Add(this.btnCancel);
            this.panelChange.Location = new System.Drawing.Point(496, 3);
            this.panelChange.Name = "panelChange";
            this.panelChange.Size = new System.Drawing.Size(288, 434);
            this.panelChange.TabIndex = 2;
            // 
            // panelchoose
            // 
            this.panelchoose.Controls.Add(this.gridCategory);
            this.panelchoose.Controls.Add(this.labelControl1);
            this.panelchoose.Controls.Add(this.btnAdd);
            this.panelchoose.Controls.Add(this.cboType);
            this.panelchoose.Controls.Add(this.btnDel);
            this.panelchoose.Controls.Add(this.btnUpdate);
            this.panelchoose.Location = new System.Drawing.Point(3, 2);
            this.panelchoose.Name = "panelchoose";
            this.panelchoose.Size = new System.Drawing.Size(474, 435);
            this.panelchoose.TabIndex = 2;
            // 
            // xtcCategoryMain
            // 
            this.xtcCategoryMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtcCategoryMain.Location = new System.Drawing.Point(0, 0);
            this.xtcCategoryMain.Name = "xtcCategoryMain";
            this.xtcCategoryMain.SelectedTabPage = this.xtbBillStyle;
            this.xtcCategoryMain.Size = new System.Drawing.Size(794, 470);
            this.xtcCategoryMain.TabIndex = 3;
            this.xtcCategoryMain.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtbCategory,
            this.xtbBillStyle});
            this.xtcCategoryMain.SelectedPageChanged += new DevExpress.XtraTab.TabPageChangedEventHandler(this.xtcCategoryMain_SelectedPageChanged);
            // 
            // xtbBillStyle
            // 
            this.xtbBillStyle.Controls.Add(this.panelProductStyle);
            this.xtbBillStyle.Controls.Add(this.panelAddStyle);
            this.xtbBillStyle.Controls.Add(this.panelControl1);
            this.xtbBillStyle.Name = "xtbBillStyle";
            this.xtbBillStyle.Size = new System.Drawing.Size(787, 440);
            this.xtbBillStyle.Text = "药品开单类别";
            // 
            // panelProductStyle
            // 
            this.panelProductStyle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelProductStyle.Controls.Add(this.btnDelProductStyle);
            this.panelProductStyle.Controls.Add(this.btnSaveProductStyle);
            this.panelProductStyle.Controls.Add(this.lblStyle);
            this.panelProductStyle.Controls.Add(this.cboProductStyle);
            this.panelProductStyle.Controls.Add(this.gridControlProductStyle);
            this.panelProductStyle.Location = new System.Drawing.Point(346, 3);
            this.panelProductStyle.Name = "panelProductStyle";
            this.panelProductStyle.Size = new System.Drawing.Size(438, 434);
            this.panelProductStyle.TabIndex = 2;
            // 
            // btnDelProductStyle
            // 
            this.btnDelProductStyle.Location = new System.Drawing.Point(358, 17);
            this.btnDelProductStyle.Name = "btnDelProductStyle";
            this.btnDelProductStyle.Size = new System.Drawing.Size(75, 23);
            this.btnDelProductStyle.TabIndex = 11;
            this.btnDelProductStyle.Text = "删除";
            this.btnDelProductStyle.Click += new System.EventHandler(this.btnDelProductStyle_Click);
            // 
            // btnSaveProductStyle
            // 
            this.btnSaveProductStyle.Location = new System.Drawing.Point(277, 17);
            this.btnSaveProductStyle.Name = "btnSaveProductStyle";
            this.btnSaveProductStyle.Size = new System.Drawing.Size(75, 23);
            this.btnSaveProductStyle.TabIndex = 11;
            this.btnSaveProductStyle.Text = "保存";
            this.btnSaveProductStyle.Click += new System.EventHandler(this.btnSaveProductStyle_Click);
            // 
            // lblStyle
            // 
            this.lblStyle.Location = new System.Drawing.Point(9, 22);
            this.lblStyle.Name = "lblStyle";
            this.lblStyle.Size = new System.Drawing.Size(0, 14);
            this.lblStyle.TabIndex = 10;
            // 
            // cboProductStyle
            // 
            this.cboProductStyle.Location = new System.Drawing.Point(138, 19);
            this.cboProductStyle.Name = "cboProductStyle";
            this.cboProductStyle.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboProductStyle.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboProductStyle.Size = new System.Drawing.Size(133, 21);
            this.cboProductStyle.TabIndex = 9;
            // 
            // gridControlProductStyle
            // 
            this.gridControlProductStyle.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridControlProductStyle.Location = new System.Drawing.Point(2, 57);
            this.gridControlProductStyle.MainView = this.gridViewProductStyle;
            this.gridControlProductStyle.Name = "gridControlProductStyle";
            this.gridControlProductStyle.Size = new System.Drawing.Size(434, 375);
            this.gridControlProductStyle.TabIndex = 0;
            this.gridControlProductStyle.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewProductStyle});
            // 
            // gridViewProductStyle
            // 
            this.gridViewProductStyle.GridControl = this.gridControlProductStyle;
            this.gridViewProductStyle.Name = "gridViewProductStyle";
            // 
            // panelAddStyle
            // 
            this.panelAddStyle.Controls.Add(this.txtStyleName);
            this.panelAddStyle.Controls.Add(this.labelControl7);
            this.panelAddStyle.Controls.Add(this.btnCancelStye);
            this.panelAddStyle.Controls.Add(this.btnSaveStyle);
            this.panelAddStyle.Location = new System.Drawing.Point(346, 3);
            this.panelAddStyle.Name = "panelAddStyle";
            this.panelAddStyle.Size = new System.Drawing.Size(438, 434);
            this.panelAddStyle.TabIndex = 1;
            // 
            // txtStyleName
            // 
            this.txtStyleName.Location = new System.Drawing.Point(176, 158);
            this.txtStyleName.Name = "txtStyleName";
            this.txtStyleName.Size = new System.Drawing.Size(178, 21);
            this.txtStyleName.TabIndex = 2;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(68, 161);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(60, 14);
            this.labelControl7.TabIndex = 1;
            this.labelControl7.Text = "开单类别：";
            // 
            // btnCancelStye
            // 
            this.btnCancelStye.Location = new System.Drawing.Point(244, 254);
            this.btnCancelStye.Name = "btnCancelStye";
            this.btnCancelStye.Size = new System.Drawing.Size(75, 23);
            this.btnCancelStye.TabIndex = 0;
            this.btnCancelStye.Text = "取消";
            this.btnCancelStye.Click += new System.EventHandler(this.btnCancelStye_Click);
            // 
            // btnSaveStyle
            // 
            this.btnSaveStyle.Location = new System.Drawing.Point(120, 254);
            this.btnSaveStyle.Name = "btnSaveStyle";
            this.btnSaveStyle.Size = new System.Drawing.Size(75, 23);
            this.btnSaveStyle.TabIndex = 0;
            this.btnSaveStyle.Text = "保存";
            this.btnSaveStyle.Click += new System.EventHandler(this.btnSaveStyle_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.gridControlStyle);
            this.panelControl1.Controls.Add(this.btnDelStyle);
            this.panelControl1.Controls.Add(this.btnReSetStyle);
            this.panelControl1.Controls.Add(this.btnAddStyle);
            this.panelControl1.Location = new System.Drawing.Point(3, 3);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(337, 434);
            this.panelControl1.TabIndex = 0;
            // 
            // gridControlStyle
            // 
            this.gridControlStyle.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridControlStyle.Location = new System.Drawing.Point(2, 57);
            this.gridControlStyle.MainView = this.gridViewStyle;
            this.gridControlStyle.Name = "gridControlStyle";
            this.gridControlStyle.Size = new System.Drawing.Size(333, 375);
            this.gridControlStyle.TabIndex = 1;
            this.gridControlStyle.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewStyle});
            // 
            // gridViewStyle
            // 
            this.gridViewStyle.GridControl = this.gridControlStyle;
            this.gridViewStyle.Name = "gridViewStyle";
            this.gridViewStyle.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridViewStyle_RowClick);
            // 
            // btnDelStyle
            // 
            this.btnDelStyle.Location = new System.Drawing.Point(229, 17);
            this.btnDelStyle.Name = "btnDelStyle";
            this.btnDelStyle.Size = new System.Drawing.Size(75, 23);
            this.btnDelStyle.TabIndex = 0;
            this.btnDelStyle.Text = "删除";
            this.btnDelStyle.Click += new System.EventHandler(this.btnDelStyle_Click);
            // 
            // btnReSetStyle
            // 
            this.btnReSetStyle.Location = new System.Drawing.Point(123, 17);
            this.btnReSetStyle.Name = "btnReSetStyle";
            this.btnReSetStyle.Size = new System.Drawing.Size(75, 23);
            this.btnReSetStyle.TabIndex = 0;
            this.btnReSetStyle.Text = "修改";
            this.btnReSetStyle.Click += new System.EventHandler(this.btnReSetStyle_Click);
            // 
            // btnAddStyle
            // 
            this.btnAddStyle.Location = new System.Drawing.Point(17, 17);
            this.btnAddStyle.Name = "btnAddStyle";
            this.btnAddStyle.Size = new System.Drawing.Size(75, 23);
            this.btnAddStyle.TabIndex = 0;
            this.btnAddStyle.Text = "新建";
            this.btnAddStyle.Click += new System.EventHandler(this.btnAddStyle_Click);
            // 
            // xtbCategory
            // 
            this.xtbCategory.Controls.Add(this.panelchoose);
            this.xtbCategory.Controls.Add(this.panelAdd);
            this.xtbCategory.Controls.Add(this.panelChange);
            this.xtbCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.xtbCategory.Name = "xtbCategory";
            this.xtbCategory.Size = new System.Drawing.Size(787, 440);
            this.xtbCategory.Text = "系统配置";
            // 
            // FrmCategorySetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 470);
            this.Controls.Add(this.xtcCategoryMain);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCategorySetting";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "配置中心";
            this.Load += new System.EventHandler(this.FrmCategorySetting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cboType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNew.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOld.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddNew.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelAdd)).EndInit();
            this.panelAdd.ResumeLayout(false);
            this.panelAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelChange)).EndInit();
            this.panelChange.ResumeLayout(false);
            this.panelChange.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelchoose)).EndInit();
            this.panelchoose.ResumeLayout(false);
            this.panelchoose.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtcCategoryMain)).EndInit();
            this.xtcCategoryMain.ResumeLayout(false);
            this.xtbBillStyle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelProductStyle)).EndInit();
            this.panelProductStyle.ResumeLayout(false);
            this.panelProductStyle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboProductStyle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlProductStyle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProductStyle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelAddStyle)).EndInit();
            this.panelAddStyle.ResumeLayout(false);
            this.panelAddStyle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtStyleName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlStyle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewStyle)).EndInit();
            this.xtbCategory.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.StandardGrid gridCategory;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private DevExpress.XtraEditors.SimpleButton btnDel;
        private DevExpress.XtraEditors.ComboBoxEdit cboType;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private Controls.TextBoxEx txtNew;
        private Controls.TextBoxEx txtOld;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.SimpleButton btnSaveNew;
        private Controls.TextBoxEx txtAddNew;
        private DevExpress.XtraEditors.LabelControl lblType;
        private DevExpress.XtraEditors.LabelControl lblTypeUpdate;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnCancelAdd;
        private DevExpress.XtraEditors.PanelControl panelAdd;
        private DevExpress.XtraEditors.PanelControl panelChange;
        private DevExpress.XtraEditors.PanelControl panelchoose;
        private DevExpress.XtraTab.XtraTabControl xtcCategoryMain;
        private DevExpress.XtraTab.XtraTabPage xtbBillStyle;
        private DevExpress.XtraTab.XtraTabPage xtbCategory;
        private DevExpress.XtraEditors.PanelControl panelAddStyle;
        private DevExpress.XtraEditors.TextEdit txtStyleName;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.SimpleButton btnCancelStye;
        private DevExpress.XtraEditors.SimpleButton btnSaveStyle;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl gridControlStyle;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewStyle;
        private DevExpress.XtraEditors.SimpleButton btnDelStyle;
        private DevExpress.XtraEditors.SimpleButton btnReSetStyle;
        private DevExpress.XtraEditors.SimpleButton btnAddStyle;
        private DevExpress.XtraEditors.PanelControl panelProductStyle;
        private DevExpress.XtraEditors.SimpleButton btnDelProductStyle;
        private DevExpress.XtraEditors.SimpleButton btnSaveProductStyle;
        private DevExpress.XtraEditors.LabelControl lblStyle;
        private DevExpress.XtraEditors.ComboBoxEdit cboProductStyle;
        private DevExpress.XtraGrid.GridControl gridControlProductStyle;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewProductStyle;
    }
}