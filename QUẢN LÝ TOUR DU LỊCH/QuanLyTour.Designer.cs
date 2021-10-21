
namespace QUẢN_LÝ_TOUR_DU_LỊCH
{
    partial class QuanLyTour
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxTenTour = new System.Windows.Forms.TextBox();
            this.textBoxGia = new System.Windows.Forms.TextBox();
            this.textBoxDacDiem = new System.Windows.Forms.TextBox();
            this.comboBoxLoaiHinhDuLich = new System.Windows.Forms.ComboBox();
            this.comboBoxDiaDiem = new System.Windows.Forms.ComboBox();
            this.dateTimePickerNgayBatDau = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerNgayKetThuc = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridViewQuanLyTour = new System.Windows.Forms.DataGridView();
            this.buttonTaoMoi = new System.Windows.Forms.Button();
            this.buttonXoa = new System.Windows.Forms.Button();
            this.buttonLamMoi = new System.Windows.Forms.Button();
            this.buttonSua = new System.Windows.Forms.Button();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaTour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiHinHDuLich = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaDiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayBatDau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayKetThuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DacDiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuanLyTour)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1145, 104);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(251)))), ((int)(((byte)(234)))));
            this.panel2.Controls.Add(this.buttonTaoMoi);
            this.panel2.Controls.Add(this.dateTimePickerNgayKetThuc);
            this.panel2.Controls.Add(this.dateTimePickerNgayBatDau);
            this.panel2.Controls.Add(this.comboBoxDiaDiem);
            this.panel2.Controls.Add(this.comboBoxLoaiHinhDuLich);
            this.panel2.Controls.Add(this.textBoxDacDiem);
            this.panel2.Controls.Add(this.textBoxGia);
            this.panel2.Controls.Add(this.textBoxTenTour);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(0, 110);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(349, 565);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(251)))), ((int)(((byte)(234)))));
            this.panel3.Controls.Add(this.buttonXoa);
            this.panel3.Controls.Add(this.buttonSua);
            this.panel3.Controls.Add(this.buttonLamMoi);
            this.panel3.Controls.Add(this.dataGridViewQuanLyTour);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Location = new System.Drawing.Point(355, 110);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(789, 564);
            this.panel3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(413, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(380, 81);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản Lý Tour";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(171, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tour";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 28);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên tour";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 28);
            this.label4.TabIndex = 2;
            this.label4.Text = "Loại hình du lịch";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(12, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 28);
            this.label5.TabIndex = 3;
            this.label5.Text = "Địa điểm";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(12, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 28);
            this.label6.TabIndex = 4;
            this.label6.Text = "Ngày bắt đầu";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(12, 253);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 28);
            this.label7.TabIndex = 5;
            this.label7.Text = "Ngày kết thúc";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(12, 298);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 28);
            this.label8.TabIndex = 6;
            this.label8.Text = "Giá";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(12, 346);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 28);
            this.label9.TabIndex = 7;
            this.label9.Text = "Đặc điểm";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // textBoxTenTour
            // 
            this.textBoxTenTour.Location = new System.Drawing.Point(173, 57);
            this.textBoxTenTour.Name = "textBoxTenTour";
            this.textBoxTenTour.Size = new System.Drawing.Size(160, 27);
            this.textBoxTenTour.TabIndex = 8;
            // 
            // textBoxGia
            // 
            this.textBoxGia.Location = new System.Drawing.Point(173, 302);
            this.textBoxGia.Name = "textBoxGia";
            this.textBoxGia.Size = new System.Drawing.Size(160, 27);
            this.textBoxGia.TabIndex = 9;
            // 
            // textBoxDacDiem
            // 
            this.textBoxDacDiem.Location = new System.Drawing.Point(173, 350);
            this.textBoxDacDiem.Name = "textBoxDacDiem";
            this.textBoxDacDiem.Size = new System.Drawing.Size(160, 27);
            this.textBoxDacDiem.TabIndex = 10;
            // 
            // comboBoxLoaiHinhDuLich
            // 
            this.comboBoxLoaiHinhDuLich.FormattingEnabled = true;
            this.comboBoxLoaiHinhDuLich.Location = new System.Drawing.Point(173, 106);
            this.comboBoxLoaiHinhDuLich.Name = "comboBoxLoaiHinhDuLich";
            this.comboBoxLoaiHinhDuLich.Size = new System.Drawing.Size(160, 28);
            this.comboBoxLoaiHinhDuLich.TabIndex = 11;
            // 
            // comboBoxDiaDiem
            // 
            this.comboBoxDiaDiem.FormattingEnabled = true;
            this.comboBoxDiaDiem.Location = new System.Drawing.Point(173, 156);
            this.comboBoxDiaDiem.Name = "comboBoxDiaDiem";
            this.comboBoxDiaDiem.Size = new System.Drawing.Size(160, 28);
            this.comboBoxDiaDiem.TabIndex = 12;
            // 
            // dateTimePickerNgayBatDau
            // 
            this.dateTimePickerNgayBatDau.Location = new System.Drawing.Point(171, 204);
            this.dateTimePickerNgayBatDau.Name = "dateTimePickerNgayBatDau";
            this.dateTimePickerNgayBatDau.Size = new System.Drawing.Size(160, 27);
            this.dateTimePickerNgayBatDau.TabIndex = 13;
            // 
            // dateTimePickerNgayKetThuc
            // 
            this.dateTimePickerNgayKetThuc.Location = new System.Drawing.Point(171, 253);
            this.dateTimePickerNgayKetThuc.Name = "dateTimePickerNgayKetThuc";
            this.dateTimePickerNgayKetThuc.Size = new System.Drawing.Size(160, 27);
            this.dateTimePickerNgayKetThuc.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(331, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 28);
            this.label10.TabIndex = 1;
            this.label10.Text = "Tour hiện có";
            // 
            // dataGridViewQuanLyTour
            // 
            this.dataGridViewQuanLyTour.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewQuanLyTour.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.MaTour,
            this.TenTour,
            this.LoaiHinHDuLich,
            this.DiaDiem,
            this.NgayBatDau,
            this.NgayKetThuc,
            this.DacDiem});
            this.dataGridViewQuanLyTour.Location = new System.Drawing.Point(15, 57);
            this.dataGridViewQuanLyTour.Name = "dataGridViewQuanLyTour";
            this.dataGridViewQuanLyTour.RowHeadersWidth = 51;
            this.dataGridViewQuanLyTour.RowTemplate.Height = 29;
            this.dataGridViewQuanLyTour.Size = new System.Drawing.Size(761, 422);
            this.dataGridViewQuanLyTour.TabIndex = 2;
            // 
            // buttonTaoMoi
            // 
            this.buttonTaoMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonTaoMoi.Location = new System.Drawing.Point(194, 510);
            this.buttonTaoMoi.Name = "buttonTaoMoi";
            this.buttonTaoMoi.Size = new System.Drawing.Size(139, 44);
            this.buttonTaoMoi.TabIndex = 15;
            this.buttonTaoMoi.Text = "Tạo mới";
            this.buttonTaoMoi.UseVisualStyleBackColor = false;
            this.buttonTaoMoi.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonXoa
            // 
            this.buttonXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonXoa.Location = new System.Drawing.Point(637, 510);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.Size = new System.Drawing.Size(139, 44);
            this.buttonXoa.TabIndex = 16;
            this.buttonXoa.Text = "Xóa";
            this.buttonXoa.UseVisualStyleBackColor = false;
            // 
            // buttonLamMoi
            // 
            this.buttonLamMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonLamMoi.Location = new System.Drawing.Point(287, 510);
            this.buttonLamMoi.Name = "buttonLamMoi";
            this.buttonLamMoi.Size = new System.Drawing.Size(139, 44);
            this.buttonLamMoi.TabIndex = 16;
            this.buttonLamMoi.Text = "Làm mới";
            this.buttonLamMoi.UseVisualStyleBackColor = false;
            this.buttonLamMoi.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonSua
            // 
            this.buttonSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonSua.Location = new System.Drawing.Point(463, 510);
            this.buttonSua.Name = "buttonSua";
            this.buttonSua.Size = new System.Drawing.Size(139, 44);
            this.buttonSua.TabIndex = 17;
            this.buttonSua.Text = "Sửa";
            this.buttonSua.UseVisualStyleBackColor = false;
            this.buttonSua.Click += new System.EventHandler(this.button3_Click);
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            this.STT.Width = 60;
            // 
            // MaTour
            // 
            this.MaTour.HeaderText = "Mã Tour";
            this.MaTour.MinimumWidth = 6;
            this.MaTour.Name = "MaTour";
            this.MaTour.Width = 80;
            // 
            // TenTour
            // 
            this.TenTour.HeaderText = "Tên Tour";
            this.TenTour.MinimumWidth = 6;
            this.TenTour.Name = "TenTour";
            this.TenTour.Width = 125;
            // 
            // LoaiHinHDuLich
            // 
            this.LoaiHinHDuLich.HeaderText = "Loại Hình Du Lịch";
            this.LoaiHinHDuLich.MinimumWidth = 6;
            this.LoaiHinHDuLich.Name = "LoaiHinHDuLich";
            this.LoaiHinHDuLich.Width = 155;
            // 
            // DiaDiem
            // 
            this.DiaDiem.HeaderText = "Địa điểm";
            this.DiaDiem.MinimumWidth = 6;
            this.DiaDiem.Name = "DiaDiem";
            this.DiaDiem.Width = 125;
            // 
            // NgayBatDau
            // 
            this.NgayBatDau.HeaderText = "Ngày Bắt Đầu";
            this.NgayBatDau.MinimumWidth = 6;
            this.NgayBatDau.Name = "NgayBatDau";
            this.NgayBatDau.Width = 135;
            // 
            // NgayKetThuc
            // 
            this.NgayKetThuc.HeaderText = "Ngày Kết Thúc";
            this.NgayKetThuc.MinimumWidth = 6;
            this.NgayKetThuc.Name = "NgayKetThuc";
            this.NgayKetThuc.Width = 135;
            // 
            // DacDiem
            // 
            this.DacDiem.HeaderText = "Đặc điểm";
            this.DacDiem.MinimumWidth = 6;
            this.DacDiem.Name = "DacDiem";
            this.DacDiem.Width = 125;
            // 
            // QuanLyTour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 676);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "QuanLyTour";
            this.Text = "QuanLyTour";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuanLyTour)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgayKetThuc;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgayBatDau;
        private System.Windows.Forms.ComboBox comboBoxDiaDiem;
        private System.Windows.Forms.ComboBox comboBoxLoaiHinhDuLich;
        private System.Windows.Forms.TextBox textBoxDacDiem;
        private System.Windows.Forms.TextBox textBoxGia;
        private System.Windows.Forms.TextBox textBoxTenTour;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridViewQuanLyTour;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button buttonTaoMoi;
        private System.Windows.Forms.Button buttonXoa;
        private System.Windows.Forms.Button buttonSua;
        private System.Windows.Forms.Button buttonLamMoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTour;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTour;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiHinHDuLich;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaDiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayBatDau;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayKetThuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn DacDiem;
    }
}