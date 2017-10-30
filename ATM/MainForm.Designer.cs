namespace ATM
{
    partial class MainForm
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
            this.btnRutTien = new System.Windows.Forms.Button();
            this.btnNapTien = new System.Windows.Forms.Button();
            this.btnChuyenTien = new System.Windows.Forms.Button();
            this.btnVanTin = new System.Windows.Forms.Button();
            this.btnDoiMaPIN = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnHuongDan = new System.Windows.Forms.Button();
            this.lblHienThongTin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRutTien
            // 
            this.btnRutTien.Location = new System.Drawing.Point(12, 132);
            this.btnRutTien.Name = "btnRutTien";
            this.btnRutTien.Size = new System.Drawing.Size(136, 43);
            this.btnRutTien.TabIndex = 0;
            this.btnRutTien.Text = "Rút tiền";
            this.btnRutTien.UseVisualStyleBackColor = true;
            this.btnRutTien.Click += new System.EventHandler(this.btnRutTien_Click);
            // 
            // btnNapTien
            // 
            this.btnNapTien.Location = new System.Drawing.Point(12, 205);
            this.btnNapTien.Name = "btnNapTien";
            this.btnNapTien.Size = new System.Drawing.Size(136, 41);
            this.btnNapTien.TabIndex = 1;
            this.btnNapTien.Text = "Nạp tiền";
            this.btnNapTien.UseVisualStyleBackColor = true;
            this.btnNapTien.Click += new System.EventHandler(this.btnGuiTien_Click);
            // 
            // btnChuyenTien
            // 
            this.btnChuyenTien.Location = new System.Drawing.Point(12, 277);
            this.btnChuyenTien.Name = "btnChuyenTien";
            this.btnChuyenTien.Size = new System.Drawing.Size(136, 40);
            this.btnChuyenTien.TabIndex = 2;
            this.btnChuyenTien.Text = "Chuyển Tiền";
            this.btnChuyenTien.UseVisualStyleBackColor = true;
            // 
            // btnVanTin
            // 
            this.btnVanTin.Location = new System.Drawing.Point(577, 132);
            this.btnVanTin.Name = "btnVanTin";
            this.btnVanTin.Size = new System.Drawing.Size(133, 43);
            this.btnVanTin.TabIndex = 3;
            this.btnVanTin.Text = "Vấn tin";
            this.btnVanTin.UseVisualStyleBackColor = true;
            // 
            // btnDoiMaPIN
            // 
            this.btnDoiMaPIN.Location = new System.Drawing.Point(577, 205);
            this.btnDoiMaPIN.Name = "btnDoiMaPIN";
            this.btnDoiMaPIN.Size = new System.Drawing.Size(133, 41);
            this.btnDoiMaPIN.TabIndex = 4;
            this.btnDoiMaPIN.Text = "Đổi mã PIN";
            this.btnDoiMaPIN.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(577, 342);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(133, 39);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnHuongDan
            // 
            this.btnHuongDan.Location = new System.Drawing.Point(577, 277);
            this.btnHuongDan.Name = "btnHuongDan";
            this.btnHuongDan.Size = new System.Drawing.Size(133, 40);
            this.btnHuongDan.TabIndex = 6;
            this.btnHuongDan.Text = "Hướng dẫn sử dụng";
            this.btnHuongDan.UseVisualStyleBackColor = true;
            // 
            // lblHienThongTin
            // 
            this.lblHienThongTin.Location = new System.Drawing.Point(154, 44);
            this.lblHienThongTin.Name = "lblHienThongTin";
            this.lblHienThongTin.Size = new System.Drawing.Size(417, 273);
            this.lblHienThongTin.TabIndex = 7;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 403);
            this.Controls.Add(this.lblHienThongTin);
            this.Controls.Add(this.btnHuongDan);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnDoiMaPIN);
            this.Controls.Add(this.btnVanTin);
            this.Controls.Add(this.btnChuyenTien);
            this.Controls.Add(this.btnNapTien);
            this.Controls.Add(this.btnRutTien);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRutTien;
        private System.Windows.Forms.Button btnNapTien;
        private System.Windows.Forms.Button btnChuyenTien;
        private System.Windows.Forms.Button btnVanTin;
        private System.Windows.Forms.Button btnDoiMaPIN;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnHuongDan;
        private System.Windows.Forms.Label lblHienThongTin;
    }
}