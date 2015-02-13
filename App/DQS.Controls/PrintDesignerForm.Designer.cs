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
            this.stiDesignerControl1 = new Stimulsoft.Report.Design.StiDesignerControl();
            this.SuspendLayout();
            // 
            // stiDesignerControl1
            // 
            this.stiDesignerControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(221)))), ((int)(((byte)(238)))));
            this.stiDesignerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stiDesignerControl1.Location = new System.Drawing.Point(0, 0);
            this.stiDesignerControl1.Name = "stiDesignerControl1";
            this.stiDesignerControl1.ShowMainMenu = false;
            this.stiDesignerControl1.Size = new System.Drawing.Size(988, 611);
            this.stiDesignerControl1.TabIndex = 0;
            // 
            // PrintDesignerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 611);
            this.Controls.Add(this.stiDesignerControl1);
            this.Name = "PrintDesignerForm";
            this.Text = "设计模版窗体";
            this.ResumeLayout(false);

        }

        #endregion

        private Stimulsoft.Report.Design.StiDesignerControl stiDesignerControl1;
    }
}