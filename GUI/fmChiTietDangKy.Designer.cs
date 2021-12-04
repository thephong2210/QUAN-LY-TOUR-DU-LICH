
namespace GUI
{
    partial class fmChiTietDangKy
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
            this.panel8 = new System.Windows.Forms.Panel();
            this.textBoxGia = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox3MaSoDoan = new System.Windows.Forms.ComboBox();
            this.panel11 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePickerNgayDangKy = new System.Windows.Forms.DateTimePicker();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxMaTour = new System.Windows.Forms.ComboBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBoxMaSoKhachHang = new System.Windows.Forms.ComboBox();
            this.buttonDong = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(629, 50);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources.icons8_view_details_50;
            this.pictureBox1.Location = new System.Drawing.Point(154, 11);
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
            this.label1.Location = new System.Drawing.Point(197, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chi tiết đăng ký";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.panel2.Controls.Add(this.panel8);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel11);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel9);
            this.panel2.Controls.Add(this.buttonDong);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(1, 46);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(570, 674);
            this.panel2.TabIndex = 2;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.label4);
            this.panel8.Controls.Add(this.textBoxGia);
            this.panel8.Controls.Add(this.label8);
            this.panel8.Location = new System.Drawing.Point(11, 202);
            this.panel8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(534, 42);
            this.panel8.TabIndex = 3;
            // 
            // textBoxGia
            // 
            this.textBoxGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxGia.Location = new System.Drawing.Point(200, 9);
            this.textBoxGia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxGia.Name = "textBoxGia";
            this.textBoxGia.ReadOnly = true;
            this.textBoxGia.Size = new System.Drawing.Size(266, 26);
            this.textBoxGia.TabIndex = 1;
            this.textBoxGia.TextChanged += new System.EventHandler(this.textBoxGia_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(3, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 28);
            this.label8.TabIndex = 0;
            this.label8.Text = "Giá đăng ký";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label6);
            this.panel6.Controls.Add(this.comboBox3MaSoDoan);
            this.panel6.Location = new System.Drawing.Point(11, 258);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(534, 50);
            this.panel6.TabIndex = 40;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(3, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 28);
            this.label6.TabIndex = 17;
            this.label6.Text = "Tên đoàn";
            // 
            // comboBox3MaSoDoan
            // 
            this.comboBox3MaSoDoan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3MaSoDoan.Enabled = false;
            this.comboBox3MaSoDoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboBox3MaSoDoan.FormattingEnabled = true;
            this.comboBox3MaSoDoan.Location = new System.Drawing.Point(200, 13);
            this.comboBox3MaSoDoan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox3MaSoDoan.Name = "comboBox3MaSoDoan";
            this.comboBox3MaSoDoan.Size = new System.Drawing.Size(319, 28);
            this.comboBox3MaSoDoan.TabIndex = 2;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.label5);
            this.panel11.Controls.Add(this.dateTimePickerNgayDangKy);
            this.panel11.Location = new System.Drawing.Point(11, 323);
            this.panel11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(534, 51);
            this.panel11.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(3, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 28);
            this.label5.TabIndex = 17;
            this.label5.Text = "Ngày đăng ký";
            // 
            // dateTimePickerNgayDangKy
            // 
            this.dateTimePickerNgayDangKy.CustomFormat = "";
            this.dateTimePickerNgayDangKy.Enabled = false;
            this.dateTimePickerNgayDangKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.dateTimePickerNgayDangKy.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerNgayDangKy.Location = new System.Drawing.Point(200, 13);
            this.dateTimePickerNgayDangKy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerNgayDangKy.Name = "dateTimePickerNgayDangKy";
            this.dateTimePickerNgayDangKy.Size = new System.Drawing.Size(319, 28);
            this.dateTimePickerNgayDangKy.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.comboBoxMaTour);
            this.panel4.Location = new System.Drawing.Point(11, 139);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(534, 50);
            this.panel4.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(3, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 28);
            this.label3.TabIndex = 17;
            this.label3.Text = "Tên tour";
            // 
            // comboBoxMaTour
            // 
            this.comboBoxMaTour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMaTour.Enabled = false;
            this.comboBoxMaTour.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboBoxMaTour.FormattingEnabled = true;
            this.comboBoxMaTour.Location = new System.Drawing.Point(200, 13);
            this.comboBoxMaTour.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxMaTour.Name = "comboBoxMaTour";
            this.comboBoxMaTour.Size = new System.Drawing.Size(319, 28);
            this.comboBoxMaTour.TabIndex = 2;
            this.comboBoxMaTour.SelectedIndexChanged += new System.EventHandler(this.comboBoxMaTour_SelectedIndexChanged);
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.label11);
            this.panel9.Controls.Add(this.comboBoxMaSoKhachHang);
            this.panel9.Location = new System.Drawing.Point(11, 85);
            this.panel9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(534, 50);
            this.panel9.TabIndex = 36;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(3, 13);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(191, 28);
            this.label11.TabIndex = 17;
            this.label11.Text = "Họ tên khách hàng";
            // 
            // comboBoxMaSoKhachHang
            // 
            this.comboBoxMaSoKhachHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMaSoKhachHang.Enabled = false;
            this.comboBoxMaSoKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboBoxMaSoKhachHang.FormattingEnabled = true;
            this.comboBoxMaSoKhachHang.Location = new System.Drawing.Point(200, 13);
            this.comboBoxMaSoKhachHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxMaSoKhachHang.Name = "comboBoxMaSoKhachHang";
            this.comboBoxMaSoKhachHang.Size = new System.Drawing.Size(319, 28);
            this.comboBoxMaSoKhachHang.TabIndex = 2;
            this.comboBoxMaSoKhachHang.SelectedIndexChanged += new System.EventHandler(this.comboBoxMaSoKhachHang_SelectedIndexChanged);
            // 
            // buttonDong
            // 
            this.buttonDong.BackColor = System.Drawing.Color.Gray;
            this.buttonDong.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.buttonDong.ForeColor = System.Drawing.Color.White;
            this.buttonDong.Location = new System.Drawing.Point(203, 438);
            this.buttonDong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDong.Name = "buttonDong";
            this.buttonDong.Size = new System.Drawing.Size(138, 49);
            this.buttonDong.TabIndex = 11;
            this.buttonDong.Text = "Đóng";
            this.buttonDong.UseVisualStyleBackColor = false;
            this.buttonDong.Click += new System.EventHandler(this.buttonDong_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.textBoxId);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(11, 27);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(534, 42);
            this.panel3.TabIndex = 1;
            // 
            // textBoxId
            // 
            this.textBoxId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxId.Location = new System.Drawing.Point(200, 9);
            this.textBoxId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.ReadOnly = true;
            this.textBoxId.Size = new System.Drawing.Size(319, 26);
            this.textBoxId.TabIndex = 1;
            this.textBoxId.TextChanged += new System.EventHandler(this.textBoxId_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(3, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã đăng ký";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(472, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "VND";
            // 
            // fmChiTietDangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 574);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "fmChiTietDangKy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi tiết đăng ký khách hàng cho tour | Tour App";
            this.Load += new System.EventHandler(this.fmChiTietDangKy_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
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
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBoxMaSoKhachHang;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxMaTour;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgayDangKy;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox3MaSoDoan;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox textBoxGia;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
    }
}