
namespace GUI
{
    partial class fmGiaTour
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonApDungGia = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.dateTimePickerNgay = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.textBoxNoiDungGia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxTimKiem = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lbTimKiem = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBoxGia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewGiaTour = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noiDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayThem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThem = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBoxMaTour = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGiaTour)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources.icons8_view_details_50;
            this.pictureBox1.Location = new System.Drawing.Point(191, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(234, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Giá tour";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(588, 51);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.panel2.Controls.Add(this.buttonApDungGia);
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.textBoxTimKiem);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.lbTimKiem);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.dataGridViewGiaTour);
            this.panel2.Controls.Add(this.btnThem);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(0, 48);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(539, 598);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // buttonApDungGia
            // 
            this.buttonApDungGia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonApDungGia.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.buttonApDungGia.ForeColor = System.Drawing.Color.White;
            this.buttonApDungGia.Location = new System.Drawing.Point(26, 503);
            this.buttonApDungGia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonApDungGia.Name = "buttonApDungGia";
            this.buttonApDungGia.Size = new System.Drawing.Size(158, 42);
            this.buttonApDungGia.TabIndex = 18;
            this.buttonApDungGia.Text = "Áp dụng giá";
            this.buttonApDungGia.UseVisualStyleBackColor = false;
            this.buttonApDungGia.Click += new System.EventHandler(this.buttonApDungGia_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.dateTimePickerNgay);
            this.panel7.Controls.Add(this.label5);
            this.panel7.Location = new System.Drawing.Point(12, 146);
            this.panel7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(512, 42);
            this.panel7.TabIndex = 4;
            // 
            // dateTimePickerNgay
            // 
            this.dateTimePickerNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dateTimePickerNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerNgay.Location = new System.Drawing.Point(228, 7);
            this.dateTimePickerNgay.Name = "dateTimePickerNgay";
            this.dateTimePickerNgay.Size = new System.Drawing.Size(269, 26);
            this.dateTimePickerNgay.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(63, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 28);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ngày:";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.textBoxNoiDungGia);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Location = new System.Drawing.Point(12, 100);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(512, 42);
            this.panel6.TabIndex = 3;
            // 
            // textBoxNoiDungGia
            // 
            this.textBoxNoiDungGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxNoiDungGia.Location = new System.Drawing.Point(228, 9);
            this.textBoxNoiDungGia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxNoiDungGia.Name = "textBoxNoiDungGia";
            this.textBoxNoiDungGia.Size = new System.Drawing.Size(269, 26);
            this.textBoxNoiDungGia.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(63, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 28);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nội dung giá:";
            // 
            // textBoxTimKiem
            // 
            this.textBoxTimKiem.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.textBoxTimKiem.Location = new System.Drawing.Point(187, 300);
            this.textBoxTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxTimKiem.Name = "textBoxTimKiem";
            this.textBoxTimKiem.Size = new System.Drawing.Size(271, 31);
            this.textBoxTimKiem.TabIndex = 15;
            this.textBoxTimKiem.TextChanged += new System.EventHandler(this.textBoxTimKiem_TextChanged);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Black;
            this.panel5.Location = new System.Drawing.Point(0, 273);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(547, 2);
            this.panel5.TabIndex = 17;
            // 
            // lbTimKiem
            // 
            this.lbTimKiem.AutoSize = true;
            this.lbTimKiem.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.lbTimKiem.Location = new System.Drawing.Point(90, 303);
            this.lbTimKiem.Name = "lbTimKiem";
            this.lbTimKiem.Size = new System.Drawing.Size(91, 25);
            this.lbTimKiem.TabIndex = 14;
            this.lbTimKiem.Text = "Tìm kiếm";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.textBoxGia);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(12, 54);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(512, 42);
            this.panel4.TabIndex = 2;
            // 
            // textBoxGia
            // 
            this.textBoxGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxGia.Location = new System.Drawing.Point(228, 9);
            this.textBoxGia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxGia.Name = "textBoxGia";
            this.textBoxGia.Size = new System.Drawing.Size(232, 26);
            this.textBoxGia.TabIndex = 1;
            this.textBoxGia.Leave += new System.EventHandler(this.textBoxGia_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(63, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 28);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nhập giá:";
            // 
            // dataGridViewGiaTour
            // 
            this.dataGridViewGiaTour.AllowUserToAddRows = false;
            this.dataGridViewGiaTour.AllowUserToDeleteRows = false;
            this.dataGridViewGiaTour.AllowUserToResizeRows = false;
            this.dataGridViewGiaTour.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewGiaTour.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewGiaTour.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGiaTour.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.gia,
            this.noiDung,
            this.ngayThem});
            this.dataGridViewGiaTour.Location = new System.Drawing.Point(26, 345);
            this.dataGridViewGiaTour.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewGiaTour.MultiSelect = false;
            this.dataGridViewGiaTour.Name = "dataGridViewGiaTour";
            this.dataGridViewGiaTour.ReadOnly = true;
            this.dataGridViewGiaTour.RowHeadersWidth = 51;
            this.dataGridViewGiaTour.RowTemplate.Height = 29;
            this.dataGridViewGiaTour.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewGiaTour.Size = new System.Drawing.Size(483, 140);
            this.dataGridViewGiaTour.TabIndex = 16;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // gia
            // 
            this.gia.DataPropertyName = "gia";
            this.gia.HeaderText = "Giá tour";
            this.gia.MinimumWidth = 6;
            this.gia.Name = "gia";
            this.gia.ReadOnly = true;
            // 
            // noiDung
            // 
            this.noiDung.DataPropertyName = "dieuKien";
            this.noiDung.HeaderText = "Nội dung";
            this.noiDung.MinimumWidth = 6;
            this.noiDung.Name = "noiDung";
            this.noiDung.ReadOnly = true;
            // 
            // ngayThem
            // 
            this.ngayThem.DataPropertyName = "ngayThem";
            this.ngayThem.HeaderText = "Ngày";
            this.ngayThem.MinimumWidth = 6;
            this.ngayThem.Name = "ngayThem";
            this.ngayThem.ReadOnly = true;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(177)))), ((int)(((byte)(65)))));
            this.btnThem.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(213, 212);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(89, 42);
            this.btnThem.TabIndex = 10;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.textBoxMaTour);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(12, 8);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(512, 42);
            this.panel3.TabIndex = 1;
            // 
            // textBoxMaTour
            // 
            this.textBoxMaTour.Enabled = false;
            this.textBoxMaTour.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxMaTour.Location = new System.Drawing.Point(228, 9);
            this.textBoxMaTour.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxMaTour.Name = "textBoxMaTour";
            this.textBoxMaTour.Size = new System.Drawing.Size(269, 26);
            this.textBoxMaTour.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(63, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã tour";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(461, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "VND";
            // 
            // fmGiaTour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 619);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(559, 666);
            this.Name = "fmGiaTour";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giá tour | Tour App";
            this.Load += new System.EventHandler(this.fmGiaTour_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGiaTour)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBoxMaTour;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox textBoxGia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox textBoxTimKiem;
        private System.Windows.Forms.Label lbTimKiem;
        private System.Windows.Forms.DataGridView dataGridViewGiaTour;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox textBoxNoiDungGia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgay;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn noiDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayThem;
        private System.Windows.Forms.Button buttonApDungGia;
        private System.Windows.Forms.Label label6;
    }
}