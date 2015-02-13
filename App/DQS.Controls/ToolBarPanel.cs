using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraEditors;
using System.Reflection;
using System.Resources;
using DevExpress.XtraBars;
using System.Drawing;
using System.ComponentModel;

namespace DQS.Controls
{
    public class ToolBarPanel : PanelControl
    {
        public BarManager barManager;
    
        public delegate void OnToolButtonClicked(object sender, ItemClickEventArgs e);

        /// <summary>
        /// 按钮点击事件
        /// </summary>
        [Description("工具按钮点击事件")]
        public event OnToolButtonClicked ToolButtonClicked;
        private Bar toolBar;
        private BarDockControl barDockControlTop;

        private ResourceManager m_ResourceManager;

        public ToolBarPanel()
        {
            InitializeComponent();

            Assembly assembly = Assembly.GetExecutingAssembly();
            m_ResourceManager = new ResourceManager("DQS.Controls.Properties.Resources", assembly);
        }

        public void InitializeComponent()
        {
            this.barManager = new DevExpress.XtraBars.BarManager();
            this.toolBar = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager
            // 
            this.barManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.toolBar});
            this.barManager.DockControls.Add(this.barDockControlTop);
            this.barManager.Form = this;
            this.barManager.MaxItemId = 0;
            // 
            // toolBar
            // 
            this.toolBar.BarName = "Tools";
            this.toolBar.DockCol = 0;
            this.toolBar.DockRow = 0;
            this.toolBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.toolBar.OptionsBar.AllowQuickCustomization = false;
            this.toolBar.OptionsBar.DrawDragBorder = false;
            this.toolBar.OptionsBar.UseWholeRow = true;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(0, 94);
            // 
            // ToolBarPanel
            // 
            this.Controls.Add(this.barDockControlTop);
            this.Name = "toolBarPanel1";
            this.Size = new System.Drawing.Size(0, 0);
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        /// <summary>
        /// 添加工具栏按钮
        /// </summary>
        /// <param name="caption">按钮文件</param>
        public void AddTool(string caption)
        {
            this.AddTool(caption, "");
        }

        /// <summary>
        /// 添加工具栏按钮
        /// </summary>
        /// <param name="caption">按钮文件</param>
        /// <param name="glyph">按钮图片</param>
        public void AddTool(string caption, string glyph)
        {

            if (this.m_ResourceManager == null)
            {
                Assembly assembly = Assembly.GetExecutingAssembly();
                m_ResourceManager = new ResourceManager("DQS.Controls.Properties.Resources", assembly);
            }

            this.Size = barDockControlTop.Size;
            
            
            ((ISupportInitialize)(this.barManager)).BeginInit();//必须有，否则不显示

            BarLargeButtonItem item = new BarLargeButtonItem(this.barManager, caption);
            item.ItemClick += Item_ToolButtonClick;
            
            object img = m_ResourceManager.GetObject(glyph);
            if (img != null)
            {
                item.Glyph = img as Image;//设置图片
            }

            item.Id = this.barManager.GetNewItemId();
            this.barManager.Items.Add(item);

            LinkPersistInfo linkInfo = new LinkPersistInfo(BarLinkUserDefines.PaintStyle, item, BarItemPaintStyle.CaptionGlyph);
            this.toolBar.LinksPersistInfo.Add(linkInfo);

            ((ISupportInitialize)(this.barManager)).EndInit();//必须有，否则不显示
            
            //设置大小
            this.Size = barDockControlTop.Size;
            this.Height += 5;
        }

        protected void Item_ToolButtonClick(object sender, ItemClickEventArgs e)
        {
            if (this.ToolButtonClicked != null)
            {
                this.ToolButtonClicked(sender, e);
            }
        }
    }
}
