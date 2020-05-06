namespace chuong4_part1
{
    partial class TinhTong_bt1
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
            this.btnThoat = new System.Windows.Forms.Button();
            this.lbNhapA = new System.Windows.Forms.Label();
            this.btnTong = new System.Windows.Forms.Button();
            this.txtNhapA = new System.Windows.Forms.TextBox();
            this.lbNhapB = new System.Windows.Forms.Label();
            this.txtNhapB = new System.Windows.Forms.TextBox();
            this.btnLamLai = new System.Windows.Forms.Button();
            this.lbHienThi = new System.Windows.Forms.Label();
            this.lbTinhTong = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(516, 247);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(89, 28);
            this.btnThoat.TabIndex = 0;
            this.btnThoat.Text = "Thoat";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // lbNhapA
            // 
            this.lbNhapA.AutoSize = true;
            this.lbNhapA.Location = new System.Drawing.Point(185, 117);
            this.lbNhapA.Name = "lbNhapA";
            this.lbNhapA.Size = new System.Drawing.Size(70, 17);
            this.lbNhapA.TabIndex = 1;
            this.lbNhapA.Text = "Nhap a = ";
            this.lbNhapA.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnTong
            // 
            this.btnTong.Location = new System.Drawing.Point(212, 247);
            this.btnTong.Name = "btnTong";
            this.btnTong.Size = new System.Drawing.Size(82, 28);
            this.btnTong.TabIndex = 2;
            this.btnTong.Text = "Tong";
            this.btnTong.UseVisualStyleBackColor = true;
            this.btnTong.Click += new System.EventHandler(this.btnTong_Click);
            // 
            // txtNhapA
            // 
            this.txtNhapA.Location = new System.Drawing.Point(337, 112);
            this.txtNhapA.Name = "txtNhapA";
            this.txtNhapA.Size = new System.Drawing.Size(114, 22);
            this.txtNhapA.TabIndex = 3;
            this.toolTip1.SetToolTip(this.txtNhapA, "Nhap so nguyen");
            // 
            // lbNhapB
            // 
            this.lbNhapB.AutoSize = true;
            this.lbNhapB.Location = new System.Drawing.Point(185, 166);
            this.lbNhapB.Name = "lbNhapB";
            this.lbNhapB.Size = new System.Drawing.Size(66, 17);
            this.lbNhapB.TabIndex = 4;
            this.lbNhapB.Text = "Nhap b =";
            // 
            // txtNhapB
            // 
            this.txtNhapB.Location = new System.Drawing.Point(338, 167);
            this.txtNhapB.Name = "txtNhapB";
            this.txtNhapB.Size = new System.Drawing.Size(114, 22);
            this.txtNhapB.TabIndex = 5;
            this.toolTip2.SetToolTip(this.txtNhapB, "Nhap so nguyen");
            // 
            // btnLamLai
            // 
            this.btnLamLai.Location = new System.Drawing.Point(370, 247);
            this.btnLamLai.Name = "btnLamLai";
            this.btnLamLai.Size = new System.Drawing.Size(87, 28);
            this.btnLamLai.TabIndex = 6;
            this.btnLamLai.Text = "Lam Lai";
            this.btnLamLai.UseVisualStyleBackColor = true;
            this.btnLamLai.Click += new System.EventHandler(this.btnLamLai_Click);
            // 
            // lbHienThi
            // 
            this.lbHienThi.AutoSize = true;
            this.lbHienThi.Location = new System.Drawing.Point(185, 211);
            this.lbHienThi.Name = "lbHienThi";
            this.lbHienThi.Size = new System.Drawing.Size(0, 17);
            this.lbHienThi.TabIndex = 7;
            // 
            // lbTinhTong
            // 
            this.lbTinhTong.AutoSize = true;
            this.lbTinhTong.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTinhTong.Location = new System.Drawing.Point(191, 211);
            this.lbTinhTong.Name = "lbTinhTong";
            this.lbTinhTong.Size = new System.Drawing.Size(0, 29);
            this.lbTinhTong.TabIndex = 8;
            // 
            // TinhTong_bt1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbTinhTong);
            this.Controls.Add(this.lbHienThi);
            this.Controls.Add(this.btnLamLai);
            this.Controls.Add(this.txtNhapB);
            this.Controls.Add(this.lbNhapB);
            this.Controls.Add(this.txtNhapA);
            this.Controls.Add(this.btnTong);
            this.Controls.Add(this.lbNhapA);
            this.Controls.Add(this.btnThoat);
            this.Name = "TinhTong_bt1";
            this.Text = "TinhTong_bt1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label lbNhapA;
        private System.Windows.Forms.Button btnTong;
        private System.Windows.Forms.TextBox txtNhapA;
        private System.Windows.Forms.Label lbNhapB;
        private System.Windows.Forms.TextBox txtNhapB;
        private System.Windows.Forms.Button btnLamLai;
        private System.Windows.Forms.Label lbHienThi;
        private System.Windows.Forms.Label lbTinhTong;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
    }
}