
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
            this.dataGridViewLoaiKH = new System.Windows.Forms.DataGridView();
            this.maLoaiKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenLoaiKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThem = new System.Windows.Forms.Button();
            this.textBoxTimKiem = new System.Windows.Forms.TextBox();
            this.lbTimKiem = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.textBoxTenLoaiKH = new System.Windows.Forms.TextBox();
            this.lbTenLoaiKH = new System.Windows.Forms.Label();
            this.panelDiaDiem.SuspendLayout();
            this.panelLeft.SuspendLayout();
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
            this.panelDiaDiem.Size = new System.Drawing.Size(537, 53);
            this.panelDiaDiem.TabIndex = 3;
            // 
            // lbLoaiKH
            // 
            this.lbLoaiKH.AutoSize = true;
            this.lbLoaiKH.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold);
            this.lbLoaiKH.ForeColor = System.Drawing.Color.White;
            this.lbLoaiKH.Location = new System.Drawing.Point(117, 1);
            this.lbLoaiKH.Name = "lbLoaiKH";
            this.lbLoaiKH.Size = new System.Drawing.Size(310, 51);
            this.lbLoaiKH.TabIndex = 0;
            this.lbLoaiKH.Text = "Loại khách hàng";
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.panelLeft.Controls.Add(this.dataGridViewLoaiKH);
            this.panelLeft.Controls.Add(this.btnThem);
            this.panelLeft.Controls.Add(this.textBoxTimKiem);
            this.panelLeft.Controls.Add(this.lbTimKiem);
            this.panelLeft.Controls.Add(this.btnXoa);
            this.panelLeft.Controls.Add(this.btnSua);
            this.panelLeft.Controls.Add(this.textBoxTenLoaiKH);
            this.panelLeft.Controls.Add(this.lbTenLoaiKH);
            this.panelLeft.Location = new System.Drawing.Point(0, 54);
            this.panelLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(537, 543);
            this.panelLeft.TabIndex = 37;
            this.panelLeft.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLeft_Paint);
            // 
            // dataGridViewLoaiKH
            // 
            this.dataGridViewLoaiKH.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewLoaiKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLoaiKH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maLoaiKhachHang,
            this.tenLoaiKhachHang});
            this.dataGridViewLoaiKH.Location = new System.Drawing.Point(35, 294);
            this.dataGridViewLoaiKH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewLoaiKH.Name = "dataGridViewLoaiKH";
            this.dataGridViewLoaiKH.RowHeadersWidth = 51;
            this.dataGridViewLoaiKH.RowTemplate.Height = 29;
            this.dataGridViewLoaiKH.Size = new System.Drawing.Size(467, 140);
            this.dataGridViewLoaiKH.TabIndex = 12;
            this.dataGridViewLoaiKH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewLoaiKH_CellClick_1);
            // 
            // maLoaiKhachHang
            // 
            this.maLoaiKhachHang.DataPropertyName = "maLoaiKhachHang";
            this.maLoaiKhachHang.HeaderText = "Mã loại KH";
            this.maLoaiKhachHang.MinimumWidth = 6;
            this.maLoaiKhachHang.Name = "maLoaiKhachHang";
            this.maLoaiKhachHang.Width = 200;
            // 
            // tenLoaiKhachHang
            // 
            this.tenLoaiKhachHang.DataPropertyName = "tenLoaiKhachHang";
            this.tenLoaiKhachHang.HeaderText = "Tên loại KH";
            this.tenLoaiKhachHang.MinimumWidth = 6;
            this.tenLoaiKhachHang.Name = "tenLoaiKhachHang";
            this.tenLoaiKhachHang.Width = 200;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(177)))), ((int)(((byte)(65)))));
            this.btnThem.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(53, 140);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(88, 47);
            this.btnThem.TabIndex = 7;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // textBoxTimKiem
            // 
            this.textBoxTimKiem.Location = new System.Drawing.Point(183, 246);
            this.textBoxTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxTimKiem.Name = "textBoxTimKiem";
            this.textBoxTimKiem.Size = new System.Drawing.Size(271, 22);
            this.textBoxTimKiem.TabIndex = 11;
            // 
            // lbTimKiem
            // 
            this.lbTimKiem.AutoSize = true;
            this.lbTimKiem.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.lbTimKiem.Location = new System.Drawing.Point(50, 243);
            this.lbTimKiem.Name = "lbTimKiem";
            this.lbTimKiem.Size = new System.Drawing.Size(91, 25);
            this.lbTimKiem.TabIndex = 10;
            this.lbTimKiem.Text = "Tìm kiếm";
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Red;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnXoa.Location = new System.Drawing.Point(366, 140);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(88, 47);
            this.btnXoa.TabIndex = 9;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.Orange;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(206, 140);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(88, 47);
            this.btnSua.TabIndex = 8;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // textBoxTenLoaiKH
            // 
            this.textBoxTenLoaiKH.Location = new System.Drawing.Point(235, 65);
            this.textBoxTenLoaiKH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxTenLoaiKH.Name = "textBoxTenLoaiKH";
            this.textBoxTenLoaiKH.Size = new System.Drawing.Size(173, 22);
            this.textBoxTenLoaiKH.TabIndex = 6;
            // 
            // lbTenLoaiKH
            // 
            this.lbTenLoaiKH.AutoSize = true;
            this.lbTenLoaiKH.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.lbTenLoaiKH.Location = new System.Drawing.Point(30, 62);
            this.lbTenLoaiKH.Name = "lbTenLoaiKH";
            this.lbTenLoaiKH.Size = new System.Drawing.Size(181, 25);
            this.lbTenLoaiKH.TabIndex = 3;
            this.lbTenLoaiKH.Text = "Tên loại khách hàng";
            // 
            // fmLoaiKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 593);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelDiaDiem);
            this.Name = "fmLoaiKhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loại khách hàng | Tour App";
            this.panelDiaDiem.ResumeLayout(false);
            this.panelDiaDiem.PerformLayout();
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLoaiKH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDiaDiem;
        private System.Windows.Forms.Label lbLoaiKH;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox textBoxTenLoaiKH;
        private System.Windows.Forms.Label lbTenLoaiKH;
        private System.Windows.Forms.DataGridView dataGridViewLoaiKH;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label lbTimKiem;
        private System.Windows.Forms.TextBox textBoxTimKiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn maLoaiKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenLoaiKhachHang;
    }
}