namespace DQS.Controls
{
    partial class PrintDesignerForm
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
            this.stiDesignerControl = new Stimulsoft.Report.Design.StiDesignerControl();
            this.SuspendLayout();
            // 
            // stiDesignerControl
            // 
            this.stiDesignerControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(221)))), ((int)(((byte)(238)))));
            this.stiDesignerControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stiDesignerControl.Location = new System.Drawing.Point(0, 0);
            this.stiDesignerControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.stiDesignerControl.Name = "stiDesignerControl";
            this.stiDesignerControl.ShowMainMenu = false;
            this.stiDesignerControl.ShowPanelReportTree = false;
            this.stiDesignerControl.ShowToolbarLayout = false;
            this.stiDesignerControl.ShowToolbarStatusBar = false;
            this.stiDesignerControl.ShowToolbarStyle = false;
            this.stiDesignerControl.ShowToolbarDockStyle = false;
            this.stiDesignerControl.ShowToolbarTextFormat = false;
            this.stiDesignerControl.ShowToolbarTools = false;
            this.stiDesignerControl.Size = new System.Drawing.Size(864, 475);
            this.stiDesignerControl.TabIndex = 0;
            // 
            // PrintDesignerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 475);
            this.Controls.Add(this.stiDesignerControl);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PrintDesignerForm";
            this.Text = "设计模版窗体";
            this.ResumeLayout(false);

        }

        #endregion

        private Stimulsoft.Report.Design.StiDesignerControl stiDesignerControl;
    }
}