
namespace GUI
{
    partial class fmChiTietLoaiKhachHang
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonDong = new System.Windows.Forms.Button();
            this.buttonSua = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBoxTenLoaiKhachHang = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBoxMaLoaiKhachHang = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(567, 57);
            this.panel1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources.icons8_view_details_50;
            this.pictureBox1.Location = new System.Drawing.Point(72, 8);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(132, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chi tiết loại khách hàng";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.panel2.Controls.Add(this.buttonDong);
            this.panel2.Controls.Add(this.buttonSua);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(0, 56);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(567, 326);
            this.panel2.TabIndex = 5;
            // 
            // buttonDong
            // 
            this.buttonDong.BackColor = System.Drawing.Color.Gray;
            this.buttonDong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDong.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.buttonDong.ForeColor = System.Drawing.Color.White;
            this.buttonDong.Location = new System.Drawing.Point(405, 219);
            this.buttonDong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDong.Name = "buttonDong";
            this.buttonDong.Size = new System.Drawing.Size(119, 49);
            this.buttonDong.TabIndex = 11;
            this.buttonDong.Text = "Đóng";
            this.buttonDong.UseVisualStyleBackColor = false;
            this.buttonDong.Click += new System.EventHandler(this.buttonDong_Click);
            // 
            // buttonSua
            // 
            this.buttonSua.BackColor = System.Drawing.Color.Orange;
            this.buttonSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSua.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.buttonSua.ForeColor = System.Drawing.Color.White;
            this.buttonSua.Location = new System.Drawing.Point(12, 219);
            this.buttonSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSua.Name = "buttonSua";
            this.buttonSua.Size = new System.Drawing.Size(119, 49);
            this.buttonSua.TabIndex = 10;
            this.buttonSua.Text = "Sửa";
            this.buttonSua.UseVisualStyleBackColor = false;
            this.buttonSua.Click += new System.EventHandler(this.buttonSua_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.textBoxTenLoaiKhachHang);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Location = new System.Drawing.Point(12, 98);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(512, 42);
            this.panel4.TabIndex = 2;
            // 
            // textBoxTenLoaiKhachHang
            // 
            this.textBoxTenLoaiKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxTenLoaiKhachHang.Location = new System.Drawing.Point(228, 9);
            this.textBoxTenLoaiKhachHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxTenLoaiKhachHang.Name = "textBoxTenLoaiKhachHang";
            this.textBoxTenLoaiKhachHang.Size = new System.Drawing.Size(269, 26);
            this.textBoxTenLoaiKhachHang.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(3, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(201, 28);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tên loại khách hàng";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.textBoxMaLoaiKhachHang);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(12, 24);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(512, 42);
            this.panel3.TabIndex = 1;
            // 
            // textBoxMaLoaiKhachHang
            // 
            this.textBoxMaLoaiKhachHang.Enabled = false;
            this.textBoxMaLoaiKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxMaLoaiKhachHang.Location = new System.Drawing.Point(228, 9);
            this.textBoxMaLoaiKhachHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxMaLoaiKhachHang.Name = "textBoxMaLoaiKhachHang";
            this.textBoxMaLoaiKhachHang.Size = new System.Drawing.Size(269, 26);
            this.textBoxMaLoaiKhachHang.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(3, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã loại khách hàng";
            // 
            // fmChiTietLoaiKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 381);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "fmChiTietLoaiKhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fmChiTietLoaiKhachHang";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonDong;
        private System.Windows.Forms.Button buttonSua;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox textBoxTenLoaiKhachHang;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBoxMaLoaiKhachHang;
        private System.Windows.Forms.Label label2;
    }
}