namespace chuong4_part1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.chaoMungToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tinhTongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tinhTongBt1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chaoMungToolStripMenuItem,
            this.tinhTongToolStripMenuItem,
            this.tinhTongBt1ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // chaoMungToolStripMenuItem
            // 
            this.chaoMungToolStripMenuItem.Name = "chaoMungToolStripMenuItem";
            this.chaoMungToolStripMenuItem.Size = new System.Drawing.Size(99, 24);
            this.chaoMungToolStripMenuItem.Text = "Chao Mung";
            this.chaoMungToolStripMenuItem.Click += new System.EventHandler(this.chaoMungToolStripMenuItem_Click);
            // 
            // tinhTongToolStripMenuItem
            // 
            this.tinhTongToolStripMenuItem.Name = "tinhTongToolStripMenuItem";
            this.tinhTongToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.tinhTongToolStripMenuItem.Text = "Tinh Tong";
            this.tinhTongToolStripMenuItem.Click += new System.EventHandler(this.tinhTongToolStripMenuItem_Click);
            // 
            // tinhTongBt1ToolStripMenuItem
            // 
            this.tinhTongBt1ToolStripMenuItem.Name = "tinhTongBt1ToolStripMenuItem";
            this.tinhTongBt1ToolStripMenuItem.Size = new System.Drawing.Size(114, 24);
            this.tinhTongBt1ToolStripMenuItem.Text = "Tinh Tong bt1";
            this.tinhTongBt1ToolStripMenuItem.Click += new System.EventHandler(this.tinhTongBt1ToolStripMenuItem_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.Text = "FrmMain";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem chaoMungToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tinhTongToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tinhTongBt1ToolStripMenuItem;
    }
}