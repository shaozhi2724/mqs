namespace DQS.AppViews.StoreAndCuring.CuringManager
{
    partial class FrmFacilitiesService
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
            this.groupControl = new DevExpress.XtraEditors.GroupControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.dteFulfillDate = new DevExpress.XtraEditors.DateEdit();
            this.dteRepairDate = new DevExpress.XtraEditors.DateEdit();
            this.txtCreateUser = new DevExpress.XtraEditors.TextEdit();
            this.txtFacServiceResult = new DevExpress.XtraEditors.TextEdit();
            this.txtRepairPerson = new DevExpress.XtraEditors.TextEdit();
            this.txtFacServicePerson = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layRepairPerson = new DevExpress.XtraLayout.LayoutControlItem();
            this.layCreateUser = new DevExpress.XtraLayout.LayoutControlItem();
            this.layRepairDate = new DevExpress.XtraLayout.LayoutControlItem();
            this.layFulfillDate = new DevExpress.XtraLayout.LayoutControlItem();
            this.layFacServicePerson = new DevExpress.XtraLayout.LayoutControlItem();
            this.layFacServiceResult = new DevExpress.XtraLayout.LayoutControlItem();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl)).BeginInit();
            this.groupControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dteFulfillDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteFulfillDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteRepairDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteRepairDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCreateUser.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFacServiceResult.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRepairPerson.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFacServicePerson.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layRepairPerson)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layCreateUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layRepairDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layFulfillDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layFacServicePerson)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layFacServiceResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl
            // 
            this.groupControl.Controls.Add(this.layoutControl1);
            this.groupControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl.Location = new System.Drawing.Point(0, 0);
            this.groupControl.Name = "groupControl";
            this.groupControl.Size = new System.Drawing.Size(518, 143);
            this.groupControl.TabIndex = 3;
            this.groupControl.Text = "明细";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.dteFulfillDate);
            this.layoutControl1.Controls.Add(this.dteRepairDate);
            this.layoutControl1.Controls.Add(this.txtCreateUser);
            this.layoutControl1.Controls.Add(this.txtFacServiceResult);
            this.layoutControl1.Controls.Add(this.txtRepairPerson);
            this.layoutControl1.Controls.Add(this.txtFacServicePerson);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(2, 23);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(514, 118);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // dteFulfillDate
            // 
            this.dteFulfillDate.EditValue = null;
            this.dteFulfillDate.Location = new System.Drawing.Point(301, 37);
            this.dteFulfillDate.Name = "dteFulfillDate";
            this.dteFulfillDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteFulfillDate.Properties.Mask.EditMask = "";
            this.dteFulfillDate.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.dteFulfillDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dteFulfillDate.Size = new System.Drawing.Size(184, 21);
            this.dteFulfillDate.StyleController = this.layoutControl1;
            this.dteFulfillDate.TabIndex = 6;
            // 
            // dteRepairDate
            // 
            this.dteRepairDate.EditValue = null;
            this.dteRepairDate.Location = new System.Drawing.Point(301, 12);
            this.dteRepairDate.Name = "dteRepairDate";
            this.dteRepairDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteRepairDate.Properties.Mask.EditMask = "";
            this.dteRepairDate.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.dteRepairDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dteRepairDate.Size = new System.Drawing.Size(184, 21);
            this.dteRepairDate.StyleController = this.layoutControl1;
            this.dteRepairDate.TabIndex = 6;
            // 
            // txtCreateUser
            // 
            this.txtCreateUser.Location = new System.Drawing.Point(63, 87);
            this.txtCreateUser.Name = "txtCreateUser";
            this.txtCreateUser.Properties.ReadOnly = true;
            this.txtCreateUser.Size = new System.Drawing.Size(422, 21);
            this.txtCreateUser.StyleController = this.layoutControl1;
            this.txtCreateUser.TabIndex = 0;
            // 
            // txtFacServiceResult
            // 
            this.txtFacServiceResult.Location = new System.Drawing.Point(63, 62);
            this.txtFacServiceResult.Name = "txtFacServiceResult";
            this.txtFacServiceResult.Size = new System.Drawing.Size(422, 21);
            this.txtFacServiceResult.StyleController = this.layoutControl1;
            this.txtFacServiceResult.TabIndex = 0;
            // 
            // txtRepairPerson
            // 
            this.txtRepairPerson.Location = new System.Drawing.Point(63, 12);
            this.txtRepairPerson.Name = "txtRepairPerson";
            this.txtRepairPerson.Size = new System.Drawing.Size(183, 21);
            this.txtRepairPerson.StyleController = this.layoutControl1;
            this.txtRepairPerson.TabIndex = 0;
            // 
            // txtFacServicePerson
            // 
            this.txtFacServicePerson.Location = new System.Drawing.Point(63, 37);
            this.txtFacServicePerson.Name = "txtFacServicePerson";
            this.txtFacServicePerson.Size = new System.Drawing.Size(183, 21);
            this.txtFacServicePerson.StyleController = this.layoutControl1;
            this.txtFacServicePerson.TabIndex = 0;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layRepairPerson,
            this.layCreateUser,
            this.layRepairDate,
            this.layFulfillDate,
            this.layFacServicePerson,
            this.layFacServiceResult});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(497, 120);
            this.layoutControlGroup1.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layRepairPerson
            // 
            this.layRepairPerson.Control = this.txtRepairPerson;
            this.layRepairPerson.CustomizationFormText = "编号";
            this.layRepairPerson.Location = new System.Drawing.Point(0, 0);
            this.layRepairPerson.Name = "layRepairPerson";
            this.layRepairPerson.Size = new System.Drawing.Size(238, 25);
            this.layRepairPerson.Text = "送修人";
            this.layRepairPerson.TextSize = new System.Drawing.Size(48, 14);
            // 
            // layCreateUser
            // 
            this.layCreateUser.Control = this.txtCreateUser;
            this.layCreateUser.CustomizationFormText = "创建人";
            this.layCreateUser.Location = new System.Drawing.Point(0, 75);
            this.layCreateUser.Name = "layCreateUser";
            this.layCreateUser.Size = new System.Drawing.Size(477, 25);
            this.layCreateUser.Text = "创建人";
            this.layCreateUser.TextSize = new System.Drawing.Size(48, 14);
            // 
            // layRepairDate
            // 
            this.layRepairDate.Control = this.dteRepairDate;
            this.layRepairDate.CustomizationFormText = "生产日期";
            this.layRepairDate.Location = new System.Drawing.Point(238, 0);
            this.layRepairDate.Name = "layRepairDate";
            this.layRepairDate.Size = new System.Drawing.Size(239, 25);
            this.layRepairDate.Text = "送修日期";
            this.layRepairDate.TextSize = new System.Drawing.Size(48, 14);
            // 
            // layFulfillDate
            // 
            this.layFulfillDate.Control = this.dteFulfillDate;
            this.layFulfillDate.CustomizationFormText = "启用日期";
            this.layFulfillDate.Location = new System.Drawing.Point(238, 25);
            this.layFulfillDate.Name = "layFulfillDate";
            this.layFulfillDate.Size = new System.Drawing.Size(239, 25);
            this.layFulfillDate.Text = "完成日期";
            this.layFulfillDate.TextSize = new System.Drawing.Size(48, 14);
            // 
            // layFacServicePerson
            // 
            this.layFacServicePerson.Control = this.txtFacServicePerson;
            this.layFacServicePerson.CustomizationFormText = "规格";
            this.layFacServicePerson.Location = new System.Drawing.Point(0, 25);
            this.layFacServicePerson.Name = "layFacServicePerson";
            this.layFacServicePerson.Size = new System.Drawing.Size(238, 25);
            this.layFacServicePerson.Text = "维修人";
            this.layFacServicePerson.TextSize = new System.Drawing.Size(48, 14);
            // 
            // layFacServiceResult
            // 
            this.layFacServiceResult.Control = this.txtFacServiceResult;
            this.layFacServiceResult.CustomizationFormText = "地址";
            this.layFacServiceResult.Location = new System.Drawing.Point(0, 50);
            this.layFacServiceResult.Name = "layFacServiceResult";
            this.layFacServiceResult.Size = new System.Drawing.Size(477, 25);
            this.layFacServiceResult.Text = "维修情况";
            this.layFacServiceResult.TextSize = new System.Drawing.Size(48, 14);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnCancel);
            this.panelControl1.Controls.Add(this.btnSave);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 143);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(518, 50);
            this.panelControl1.TabIndex = 2;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Appearance.Options.UseFont = true;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(414, 13);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(87, 27);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "取消(&C)";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.Location = new System.Drawing.Point(312, 13);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(87, 27);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "保存(&S)";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FrmFacilitiesService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 193);
            this.Controls.Add(this.groupControl);
            this.Controls.Add(this.panelControl1);
            this.Name = "FrmFacilitiesService";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "维修记录";
            this.Load += new System.EventHandler(this.FrmFacilitiesService_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl)).EndInit();
            this.groupControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dteFulfillDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteFulfillDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteRepairDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteRepairDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCreateUser.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFacServiceResult.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRepairPerson.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFacServicePerson.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layRepairPerson)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layCreateUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layRepairDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layFulfillDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layFacServicePerson)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layFacServiceResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.DateEdit dteFulfillDate;
        private DevExpress.XtraEditors.DateEdit dteRepairDate;
        private DevExpress.XtraEditors.TextEdit txtCreateUser;
        private DevExpress.XtraEditors.TextEdit txtFacServiceResult;
        private DevExpress.XtraEditors.TextEdit txtRepairPerson;
        private DevExpress.XtraEditors.TextEdit txtFacServicePerson;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layRepairPerson;
        private DevExpress.XtraLayout.LayoutControlItem layCreateUser;
        private DevExpress.XtraLayout.LayoutControlItem layRepairDate;
        private DevExpress.XtraLayout.LayoutControlItem layFulfillDate;
        private DevExpress.XtraLayout.LayoutControlItem layFacServicePerson;
        private DevExpress.XtraLayout.LayoutControlItem layFacServiceResult;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnSave;
    }
}