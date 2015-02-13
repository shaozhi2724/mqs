using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraEditors;
using System.Drawing;
using System.ComponentModel;

namespace DQS.Controls
{
    /// <summary>
    /// 按钮呈现面板
    /// </summary>
    public class ButtonNavigator : PanelControl
    {

        public delegate void OnButtonClicked(object sender, EventArgs e);

        /// <summary>
        /// 按钮点击事件
        /// </summary>
        [Description("按钮点击事件")]
        public event OnButtonClicked ButtonClicked;

        private float m_FontSize = 9;
        private Size m_MinButtonSize = new Size(75, 23);//按钮最小大小
        private int m_VMargin = 10;//垂直间距
        private int m_HMargin = 10;//水平间距
        private Point m_FirstButtonLocation = new Point(5, 5);//首按钮位置
        private List<SimpleButton> m_Buttons;//按钮集合

        /// <summary>
        /// 设置按钮的字体
        /// </summary>
        [Description("设置按钮的字体")]
        public float FontSize
        {
            get 
            { 
                return m_FontSize; 
            }
            set 
            {
                m_FontSize = value; 
            }
        }

        /// <summary>
        /// 是否可多行显示
        /// </summary>
        [Description("设置是否可多行显示")]
        public bool Multiline { get; set; }

        /// <summary>
        /// Button 高度是否可变
        /// </summary>
        [Description("设置 Button 高度是否可变")]
        public bool IsAutoHeight { get; set; }

        /// <summary>
        /// Button 宽度是否可变
        /// </summary>
        [Description("设置 Button 宽度是否可变")]
        public bool IsAutoWidth { get; set; }

        /// <summary>
        /// 是否将左对齐的按钮左右居中
        /// </summary>
        [Description("设置是否将左对齐的按钮左右居中")]
        public bool IsLeftToCenter { get; set; }

        /// <summary>
        /// 是否将上对齐的按钮上下居中
        /// </summary>
        [Description("设置是否将上对齐的按钮上下居中")]
        public bool IsTopToCenter { get; set; }


        /// <summary>
        /// Button最小尺寸
        /// </summary>
        [Description("设置 Button 的最小尺寸")]
        public Size MinButtonSize
        {
            get
            {
                return m_MinButtonSize;
            }
            set
            {
                m_MinButtonSize = value;
            }
        }

        /// <summary>
        /// 垂直间隙
        /// </summary>
        [Description("多行显示时，设置 Button 之间的垂直间隙")]
        public int VMargin
        {
            get
            {
                return m_VMargin;
            }
            set
            {
                m_VMargin = value;
            }
        }

        /// <summary>
        /// 水平间隙
        /// </summary>
        [Description("设置 Button 之间的水平间隙")]
        public int HMargin
        {
            get
            {
                return m_HMargin;
            }
            set
            {
                m_HMargin = value;
            }
        }

        /// <summary>
        /// 第一个按钮的位置
        /// </summary>
        [Description("设置第一个 Button 的位置")]
        public Point FirstButtonLocation
        {
            get
            {
                return m_FirstButtonLocation;
            }
            set
            {
                m_FirstButtonLocation = value;
            }
        }
        
        /// <summary>
        /// 获取列表所有的 Button
        /// </summary>
        [Browsable(false)]
        public List<SimpleButton> Buttons
        {
            get
            {
                return m_Buttons;
            }
        }

        /// <summary>
        /// 添加 Button 到列表中
        /// </summary>
        /// <param name="button">Button</param>
        public void AddButton(SimpleButton button)
        {
            button.Appearance.Font = new Font("微软雅黑", m_FontSize, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.Controls.Add(button);
        }

        protected void Button_Click(object sender, EventArgs e)
        {
            if (this.ButtonClicked != null)
            {
                this.ButtonClicked(sender, e);
            }
        }

        /// <summary>
        /// 排列 Button 列表
        /// </summary>
        public void ComposeButtons()
        {
            if (this.m_Buttons.Count > 0)
            {
                if (Multiline)
                {
                    //多行显示
                    this.ComposeMultiline();
                }
                else
                {
                    //单行显示
                    this.ComposeSingle();
                }
            }
        }

        public ButtonNavigator()
        {
            m_Buttons = new List<SimpleButton>();
        }

        /// <summary>
        /// 单行排列 Button
        /// </summary>
        private void ComposeSingle()
        {
            SimpleButton button = m_Buttons[0];
            button.Size = MinButtonSize;
            button.Location = FirstButtonLocation;

            int count = m_Buttons.Count;

            int totalWidth = this.Width;
            int totalHeight = this.Height;

            //高度大小判定
            if (IsAutoHeight)
            {
                //可变高度，上下拉伸
                button.Height = totalHeight - button.Location.Y * 2;
            }
            else
            {
                //不可变高度，上下居中
                if (IsTopToCenter)
                {
                    button.Location = new Point(button.Location.X, (totalHeight - button.Height) / 2);
                }
            }

            //宽度大小判定
            if (IsAutoWidth)
            {
                //可变宽度，左右拉伸
                button.Width = (totalWidth - button.Location.X * 2 - HMargin * (count - 1)) / count;
            }
            else
            {
                //不可变宽度，可设置将左对齐的按钮左右居中
                if (IsLeftToCenter)
                {
                    button.Location = new Point((totalWidth - button.Width * count - HMargin * (count - 1)) / 2, button.Location.Y);
                }
            }

            for (int i = 1; i < m_Buttons.Count; i++)
            {
                //设定其它 Button 的大小及位置
                SimpleButton btn = m_Buttons[i];
                btn.Size = button.Size;
                btn.Location = new Point(button.Location.X + (button.Width + HMargin) * i, button.Location.Y);
            }
        }

        /// <summary>
        /// 多行排列 Button
        /// </summary>
        private void ComposeMultiline()
        {
            SimpleButton button = m_Buttons[0];
            button.Size = MinButtonSize;
            button.Location = FirstButtonLocation;

            int count = m_Buttons.Count;

            int totalWidth = this.Width;
            int totalHeight = this.Height;


            //计算列和行
            int clos = (totalWidth - button.Location.X * 2 - HMargin) / (button.Width + HMargin);

            //可放置的列数超出集合个数
            if (clos > count)
            {
                clos = count;
            }

            //宽度不足以放置1个时也要放一个
            if (clos == 0)
            {
                clos = 1;
            }

            int rows = count / clos;

            if (count % clos != 0)
            {
                //有余则另加一行
                rows++;
            }

            //高度大小判定
            if (IsAutoHeight)
            {
                //可变高度，上下拉伸
                button.Height = (totalHeight - button.Location.Y * 2 - VMargin * (rows - 1)) / rows;
            }
            else
            {
                //不可变高度，上下居中
                if (IsTopToCenter)
                {
                    //判定行不超过总高度时才可上下居中
                    if (button.Location.Y * 2 + button.Height + (button.Height + VMargin) * (rows - 1) < totalHeight)
                    {
                        int y = (totalHeight - ((button.Height + VMargin) * rows - VMargin)) / 2;
                        button.Location = new Point(button.Location.X, y);
                    }
                }
            }

            //宽度大小判定
            if (IsAutoWidth)
            {
                //可变宽度，左右拉伸
                button.Width = (totalWidth - button.Location.X * 2 - HMargin * (clos - 1)) / clos;
            }
            else
            {
                //不可变宽度，可设置将左对齐的按钮左右居中
                if (IsLeftToCenter)
                {
                    button.Location = new Point((totalWidth - button.Width * clos - HMargin * (clos - 1)) / 2, button.Location.Y);
                }
            }

            //设定位置
            int index = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < clos; j++)
                {
                    SimpleButton btn = m_Buttons[index];
                    btn.Size = button.Size;

                    int x = button.Location.X + (HMargin + btn.Width) * j;
                    int y = button.Location.Y + (VMargin + btn.Height) * i;
                    btn.Location = new Point(x, y);

                    index++;
                    if (index == count)
                    {
                        break;
                    }
                }

                if (index == count)
                {
                    break;
                }
            }
        }

        protected override void OnControlAdded(System.Windows.Forms.ControlEventArgs e)
        {
            if (e.Control is SimpleButton)
            {
                SimpleButton button = e.Control as SimpleButton;
                this.m_Buttons.Add(e.Control as SimpleButton);
                button.Click += Button_Click;
                button.Size = MinButtonSize;
                this.ComposeButtons();
            }
            base.OnControlAdded(e);
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            ComposeButtons();
            base.OnSizeChanged(e);
        }
    }
}
