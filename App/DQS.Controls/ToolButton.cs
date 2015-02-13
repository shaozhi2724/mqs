using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using DevExpress.XtraTab;
using DevExpress.Utils;
using System.Threading;
using DQS.Module.Entities;
using ORMSCore;

namespace DQS.Controls
{
    public class ToolButton : SimpleButton
    {

        /// <summary>
        /// 菜单名称
        /// </summary>
        [Description("菜单名称")]
        public string MenuName { get; set; }

        /// <summary>
        /// 菜单编号
        /// </summary>
        [Description("菜单编号")]
        public string MenuCode { get; set; }

        /// <summary>
        /// 菜单限定类型名称
        /// </summary>
        [Description("菜单限定类型名称")]
        public string MenuFullClass { get; set; }

        /// <summary>
        /// 鼠标移入后显示的图片
        /// </summary>
        [Description("鼠标移入后显示的图片")]
        public Image MouseEnterImage { get; set; }

        [Browsable(false)]
        public Image m_BeforeImage;

        private WaitDialogForm m_WaitForm;

        public ToolButton()
        {
            this.Appearance.BackColor = Color.Transparent;
            this.Appearance.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.ButtonStyle = BorderStyles.UltraFlat;
            this.Cursor = Cursors.Hand;
            this.ImageLocation = ImageLocation.TopCenter;
            this.Size = new Size(135, 92);
            this.Text = "ToolButton";
            this.AllowFocus = false;
            
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            if (this.MouseEnterImage != null)
            {
                if (this.Image != null)
                {
                    this.m_BeforeImage = this.Image;
                }
                this.Image = this.MouseEnterImage;
            }
            this.ForeColor = Color.Blue;
            base.OnMouseEnter(e);
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            if (this.m_BeforeImage != null)
            {
                this.Image = this.m_BeforeImage;
            }
            this.ForeColor = Color.Black;
            base.OnMouseLeave(e);
        }

        private bool CheckEnterpriseLicense()
        {
            EntityCollection<BFIEnterpriseEntity> entities = new EntityCollection<BFIEnterpriseEntity>();
            entities.Fetch();

            if (entities.Count > 0)
            {
                BFIEnterpriseEntity entity = entities[0] as BFIEnterpriseEntity;
                if (!entity.IsNullField("LicenseValidateDate"))
                {
                    if (DateTime.Today > entity.LicenseValidateDate)
                    {
                        return false;
                    }
                }
            }
            return true;
            //this.Close();
        }
        protected override void OnClick(EventArgs e)
        {
            return;
            if (!string.IsNullOrEmpty(this.MenuFullClass))
            {
                bool checkEnterpriseLicense = CheckEnterpriseLicense();
                if (MenuFullClass.Contains("DQS.AppViews.Operation") && !checkEnterpriseLicense)
                {
                    XtraMessageBox.Show("企业GSP证书已到期，不能进行业务管理！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if ((this.Parent as XtraForm).Parent.Parent is XtraTabControl)
                {
                    #region 启动等待窗体
                    
                    new Thread((ThreadStart)delegate
                    {
                        m_WaitForm = new WaitDialogForm("正在努力加载页面...", "请稍候");
                        Application.Run(m_WaitForm);
                    }).Start();

                    #endregion

                    XtraTabControl tbControlMain = (this.Parent as XtraForm).Parent.Parent as XtraTabControl;

                    XtraForm frmContent = Activator.CreateInstance(Type.GetType(this.MenuFullClass)) as XtraForm;
                    frmContent.Show();

                    frmContent.TopLevel = false;
                    frmContent.FormBorderStyle = FormBorderStyle.None;
                    frmContent.Dock = DockStyle.Fill;

                    XtraTabPage page = new XtraTabPage { Name = this.MenuCode, Text = this.MenuName };
                    page.Controls.Add(frmContent);
                    tbControlMain.TabPages.Add(page);
                    tbControlMain.SelectedTabPage = page;
                }
            }
            base.OnClick(e);

            #region 关闭等待窗体
            m_WaitForm.Invoke((EventHandler)delegate { m_WaitForm.Close(); }); 
            #endregion

        }
    }
}
