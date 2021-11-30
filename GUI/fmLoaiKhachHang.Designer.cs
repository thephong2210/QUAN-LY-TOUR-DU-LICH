
namespace GUI
{
    partial class fmLoaiKhachHang
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
            this.panelDiaDiem = new System.Windows.Forms.Panel();
            this.lbLoaiKH = new System.Windows.Forms.Label();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTenLoaiKH = new System.Windows.Forms.TextBox();
            this.dataGridViewLoaiKH = new System.Windows.Forms.DataGridView();
            this.maLoaiKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenLoaiKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThem = new System.Windows.Forms.Button();
            this.textBoxTimKiem = new System.Windows.Forms.TextBox();
            this.lbTimKiem = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.panelDiaDiem.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLoaiKH)).BeginInit();
            this.SuspendLayout();
            // 
            // panelDiaDiem
            // 
            this.panelDiaDiem.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelDiaDiem.Controls.Add(this.lbLoaiKH);
            this.panelDiaDiem.Location = new System.Drawing.Point(0, 0);
            this.panelDiaDiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelDiaDiem.Name = "panelDiaDiem";
            this.panelDiaDiem.Size = new System.Drawing.Size(540, 53);
            this.panelDiaDiem.TabIndex = 4;
            // 
            // lbLoaiKH
            // 
            this.lbLoaiKH.AutoSize = true;
            this.lbLoaiKH.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lbLoaiKH.ForeColor = System.Drawing.Color.White;
            this.lbLoaiKH.Location = new System.Drawing.Point(139, 5);
            this.lbLoaiKH.Name = "lbLoaiKH";
            this.lbLoaiKH.Size = new System.Drawing.Size(277, 46);
            this.lbLoaiKH.TabIndex = 0;
            this.lbLoaiKH.Text = "Loại khách hàng";
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.panelLeft.Controls.Add(this.panel1);
            this.panelLeft.Controls.Add(this.panel2);
            this.panelLeft.Controls.Add(this.dataGridViewLoaiKH);
            this.panelLeft.Controls.Add(this.btnThem);
            this.panelLeft.Controls.Add(this.textBoxTimKiem);
            this.panelLeft.Controls.Add(this.lbTimKiem);
            this.panelLeft.Controls.Add(this.btnXoa);
            this.panelLeft.Location = new System.Drawing.Point(0, 53);
            this.panelLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(540, 553);
            this.panelLeft.TabIndex = 38;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(0, 233);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(547, 2);
            this.panel1.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.textBoxTenLoaiKH);
            this.panel2.Location = new System.Drawing.Point(36, 68);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(478, 44);
            this.panel2.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(14, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tên loại khách hàng";
            // 
            // textBoxTenLoaiKH
            // 
            this.textBoxTenLoaiKH.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.textBoxTenLoaiKH.Location = new System.Drawing.Point(213, 8);
            this.textBoxTenLoaiKH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxTenLoaiKH.Name = "textBoxTenLoaiKH";
            this.textBoxTenLoaiKH.Size = new System.Drawing.Size(241, 31);
            this.textBoxTenLoaiKH.TabIndex = 6;
            // 
            // dataGridViewLoaiKH
            // 
            this.dataGridViewLoaiKH.AllowUserToAddRows = false;
            this.dataGridViewLoaiKH.AllowUserToDeleteRows = false;
            this.dataGridViewLoaiKH.AllowUserToResizeRows = false;
            this.dataGridViewLoaiKH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewLoaiKH.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewLoaiKH.ColumnHeadersHeight = 30;
            this.dataGridViewLoaiKH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maLoaiKhachHang,
            this.tenLoaiKhachHang});
            this.dataGridViewLoaiKH.Location = new System.Drawing.Point(28, 300);
            this.dataGridViewLoaiKH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewLoaiKH.MultiSelect = false;
            this.dataGridViewLoaiKH.Name = "dataGridViewLoaiKH";
            this.dataGridViewLoaiKH.ReadOnly = true;
            this.dataGridViewLoaiKH.RowHeadersWidth = 51;
            this.dataGridViewLoaiKH.RowTemplate.Height = 29;
            this.dataGridViewLoaiKH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewLoaiKH.Size = new System.Drawing.Size(486, 143);
            this.dataGridViewLoaiKH.TabIndex = 12;
            // 
            // maLoaiKhachHang
            // 
            this.maLoaiKhachHang.DataPropertyName = "maLoaiKhachHang";
            this.maLoaiKhachHang.FillWeight = 100.2494F;
            this.maLoaiKhachHang.HeaderText = "Mã loại KH";
            this.maLoaiKhachHang.MinimumWidth = 6;
            this.maLoaiKhachHang.Name = "maLoaiKhachHang";
            this.maLoaiKhachHang.ReadOnly = true;
            // 
            // tenLoaiKhachHang
            // 
            this.tenLoaiKhachHang.DataPropertyName = "tenLoaiKhachHang";
            this.tenLoaiKhachHang.FillWeight = 99.75063F;
            this.tenLoaiKhachHang.HeaderText = "Tên loại KH";
            this.tenLoaiKhachHang.MinimumWidth = 6;
            this.tenLoaiKhachHang.Name = "tenLoaiKhachHang";
            this.tenLoaiKhachHang.ReadOnly = true;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(177)))), ((int)(((byte)(65)))));
            this.btnThem.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(204, 146);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(123, 47);
            this.btnThem.TabIndex = 7;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // textBoxTimKiem
            // 
            this.textBoxTimKiem.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.textBoxTimKiem.Location = new System.Drawing.Point(138, 258);
            this.textBoxTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxTimKiem.Name = "textBoxTimKiem";
            this.textBoxTimKiem.Size = new System.Drawing.Size(376, 31);
            this.textBoxTimKiem.TabIndex = 11;
            // 
            // lbTimKiem
            // 
            this.lbTimKiem.AutoSize = true;
            this.lbTimKiem.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.lbTimKiem.Location = new System.Drawing.Point(31, 261);
            this.lbTimKiem.Name = "lbTimKiem";
            this.lbTimKiem.Size = new System.Drawing.Size(91, 25);
            this.lbTimKiem.TabIndex = 10;
            this.lbTimKiem.Text = "Tìm kiếm";
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Red;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(426, 456);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(88, 40);
            this.btnXoa.TabIndex = 9;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // fmLoaiKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 594);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelDiaDiem);
            this.MaximumSize = new System.Drawing.Size(557, 641);
            this.MinimumSize = new System.Drawing.Size(557, 641);
            this.Name = "fmLoaiKhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loại khách hàng | Tour App";
            this.panelDiaDiem.ResumeLayout(false);
            this.panelDiaDiem.PerformLayout();
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLoaiKH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDiaDiem;
        private System.Windows.Forms.Label lbLoaiKH;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTenLoaiKH;
        private System.Windows.Forms.DataGridView dataGridViewLoaiKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn maLoaiKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenLoaiKhachHang;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox textBoxTimKiem;
        private System.Windows.Forms.Label lbTimKiem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnXoa;
    }
}