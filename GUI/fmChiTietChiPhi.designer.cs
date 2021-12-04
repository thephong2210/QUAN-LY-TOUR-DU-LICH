
namespace GUI
{
    partial class fmChiTietChiPhi
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonSua = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.dataGridViewLoaiCP = new System.Windows.Forms.DataGridView();
            this.maChiPhi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenChiPhi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongChiPhi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel6 = new System.Windows.Forms.Panel();
            this.textBoxTongChiPhi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.buttonThemKhachHang = new System.Windows.Forms.Button();
            this.comboBoxLoaiChiPhi = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonThem = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBoxMaSoDoan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLoaiCP)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(198, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bảng chi phí";
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
            this.panel2.Controls.Add(this.buttonSua);
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.dataGridViewLoaiCP);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.btnXoa);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.buttonThem);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(0, 48);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(539, 637);
            this.panel2.TabIndex = 2;
            // 
            // buttonSua
            // 
            this.buttonSua.BackColor = System.Drawing.Color.Orange;
            this.buttonSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSua.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.buttonSua.ForeColor = System.Drawing.Color.White;
            this.buttonSua.Location = new System.Drawing.Point(31, 468);
            this.buttonSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSua.Name = "buttonSua";
            this.buttonSua.Size = new System.Drawing.Size(94, 35);
            this.buttonSua.TabIndex = 19;
            this.buttonSua.Text = "Sửa";
            this.buttonSua.UseVisualStyleBackColor = false;
            this.buttonSua.Click += new System.EventHandler(this.buttonSua_Click_1);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Black;
            this.panel7.Location = new System.Drawing.Point(3, 266);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(547, 2);
            this.panel7.TabIndex = 18;
            // 
            // dataGridViewLoaiCP
            // 
            this.dataGridViewLoaiCP.AllowUserToAddRows = false;
            this.dataGridViewLoaiCP.AllowUserToDeleteRows = false;
            this.dataGridViewLoaiCP.AllowUserToResizeRows = false;
            this.dataGridViewLoaiCP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewLoaiCP.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewLoaiCP.ColumnHeadersHeight = 30;
            this.dataGridViewLoaiCP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maChiPhi,
            this.tenChiPhi,
            this.tongChiPhi});
            this.dataGridViewLoaiCP.Location = new System.Drawing.Point(31, 302);
            this.dataGridViewLoaiCP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewLoaiCP.MultiSelect = false;
            this.dataGridViewLoaiCP.Name = "dataGridViewLoaiCP";
            this.dataGridViewLoaiCP.ReadOnly = true;
            this.dataGridViewLoaiCP.RowHeadersWidth = 51;
            this.dataGridViewLoaiCP.RowTemplate.Height = 29;
            this.dataGridViewLoaiCP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewLoaiCP.Size = new System.Drawing.Size(486, 148);
            this.dataGridViewLoaiCP.TabIndex = 17;
            // 
            // maChiPhi
            // 
            this.maChiPhi.DataPropertyName = "maChiPhi";
            this.maChiPhi.FillWeight = 100.2494F;
            this.maChiPhi.HeaderText = "Mã chi phí";
            this.maChiPhi.MinimumWidth = 6;
            this.maChiPhi.Name = "maChiPhi";
            this.maChiPhi.ReadOnly = true;
            // 
            // tenChiPhi
            // 
            this.tenChiPhi.DataPropertyName = "tenChiPhi";
            this.tenChiPhi.FillWeight = 99.75063F;
            this.tenChiPhi.HeaderText = "Tên chi phí";
            this.tenChiPhi.MinimumWidth = 6;
            this.tenChiPhi.Name = "tenChiPhi";
            this.tenChiPhi.ReadOnly = true;
            // 
            // tongChiPhi
            // 
            this.tongChiPhi.DataPropertyName = "tongChiPhi";
            this.tongChiPhi.HeaderText = "Tổng chi phí";
            this.tongChiPhi.MinimumWidth = 6;
            this.tongChiPhi.Name = "tongChiPhi";
            this.tongChiPhi.ReadOnly = true;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label6);
            this.panel6.Controls.Add(this.textBoxTongChiPhi);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Location = new System.Drawing.Point(12, 114);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(512, 42);
            this.panel6.TabIndex = 2;
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            // 
            // textBoxTongChiPhi
            // 
            this.textBoxTongChiPhi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxTongChiPhi.Location = new System.Drawing.Point(192, 9);
            this.textBoxTongChiPhi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxTongChiPhi.Name = "textBoxTongChiPhi";
            this.textBoxTongChiPhi.Size = new System.Drawing.Size(251, 26);
            this.textBoxTongChiPhi.TabIndex = 1;
            this.textBoxTongChiPhi.Leave += new System.EventHandler(this.textBoxTongChiPhi_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(46, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 28);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tổng chi phí";
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Red;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(429, 468);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(88, 40);
            this.btnXoa.TabIndex = 16;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.buttonThemKhachHang);
            this.panel4.Controls.Add(this.comboBoxLoaiChiPhi);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(12, 68);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(512, 42);
            this.panel4.TabIndex = 2;
            // 
            // buttonThemKhachHang
            // 
            this.buttonThemKhachHang.BackColor = System.Drawing.Color.SeaGreen;
            this.buttonThemKhachHang.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold);
            this.buttonThemKhachHang.ForeColor = System.Drawing.Color.White;
            this.buttonThemKhachHang.Location = new System.Drawing.Point(416, 5);
            this.buttonThemKhachHang.Name = "buttonThemKhachHang";
            this.buttonThemKhachHang.Size = new System.Drawing.Size(81, 28);
            this.buttonThemKhachHang.TabIndex = 20;
            this.buttonThemKhachHang.Text = "Thêm";
            this.buttonThemKhachHang.UseVisualStyleBackColor = false;
            this.buttonThemKhachHang.Click += new System.EventHandler(this.buttonThemKhachHang_Click);
            // 
            // comboBoxLoaiChiPhi
            // 
            this.comboBoxLoaiChiPhi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLoaiChiPhi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboBoxLoaiChiPhi.FormattingEnabled = true;
            this.comboBoxLoaiChiPhi.Location = new System.Drawing.Point(192, 5);
            this.comboBoxLoaiChiPhi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxLoaiChiPhi.Name = "comboBoxLoaiChiPhi";
            this.comboBoxLoaiChiPhi.Size = new System.Drawing.Size(218, 28);
            this.comboBoxLoaiChiPhi.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(46, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 28);
            this.label3.TabIndex = 0;
            this.label3.Text = "Loại chi phí";
            // 
            // buttonThem
            // 
            this.buttonThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(177)))), ((int)(((byte)(65)))));
            this.buttonThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonThem.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.buttonThem.ForeColor = System.Drawing.Color.White;
            this.buttonThem.Location = new System.Drawing.Point(220, 188);
            this.buttonThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Size = new System.Drawing.Size(119, 49);
            this.buttonThem.TabIndex = 10;
            this.buttonThem.Text = "Thêm";
            this.buttonThem.UseVisualStyleBackColor = false;
            this.buttonThem.Click += new System.EventHandler(this.buttonThem_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.textBoxMaSoDoan);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(12, 8);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(512, 42);
            this.panel3.TabIndex = 1;
            // 
            // textBoxMaSoDoan
            // 
            this.textBoxMaSoDoan.Enabled = false;
            this.textBoxMaSoDoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxMaSoDoan.Location = new System.Drawing.Point(192, 9);
            this.textBoxMaSoDoan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxMaSoDoan.Name = "textBoxMaSoDoan";
            this.textBoxMaSoDoan.Size = new System.Drawing.Size(305, 26);
            this.textBoxMaSoDoan.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(46, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã số đoàn";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources.icons8_view_details_50;
            this.pictureBox1.Location = new System.Drawing.Point(164, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(449, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "VND";
            // 
            // fmChiTietChiPhi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 589);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "fmChiTietChiPhi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bảng chi phí | Tour App";
            this.Load += new System.EventHandler(this.fmChiTietChiPhi_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLoaiCP)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonThem;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBoxMaSoDoan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxLoaiChiPhi;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox textBoxTongChiPhi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonThemKhachHang;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.DataGridView dataGridViewLoaiCP;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button buttonSua;
        private System.Windows.Forms.DataGridViewTextBoxColumn maChiPhi;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenChiPhi;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongChiPhi;
        private System.Windows.Forms.Label label6;
    }
}