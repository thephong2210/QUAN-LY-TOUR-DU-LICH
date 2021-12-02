
namespace GUI
{
    partial class fmLoaiHinhDuLich
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbLoaiHinhDuLich = new System.Windows.Forms.Label();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxTimKiem = new System.Windows.Forms.TextBox();
            this.lbTimKiem = new System.Windows.Forms.Label();
            this.dataGridViewLoaiHinhDuLich = new System.Windows.Forms.DataGridView();
            this.maLoaiHinhDuLich = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenLoaiHinhDuLich = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.textBoxTenLoaiHinhDuLich = new System.Windows.Forms.TextBox();
            this.lbTenLoaiHinhDuLich = new System.Windows.Forms.Label();
            this.panelDiaDiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLoaiHinhDuLich)).BeginInit();
            this.SuspendLayout();
            // 
            // panelDiaDiem
            // 
            this.panelDiaDiem.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelDiaDiem.Controls.Add(this.pictureBox1);
            this.panelDiaDiem.Controls.Add(this.lbLoaiHinhDuLich);
            this.panelDiaDiem.Location = new System.Drawing.Point(0, 0);
            this.panelDiaDiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelDiaDiem.Name = "panelDiaDiem";
            this.panelDiaDiem.Size = new System.Drawing.Size(495, 59);
            this.panelDiaDiem.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = global::GUI.Properties.Resources.touricon;
            this.pictureBox1.Image = global::GUI.Properties.Resources.travel_guide;
            this.pictureBox1.Location = new System.Drawing.Point(93, 7);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(57, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // lbLoaiHinhDuLich
            // 
            this.lbLoaiHinhDuLich.AutoSize = true;
            this.lbLoaiHinhDuLich.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lbLoaiHinhDuLich.ForeColor = System.Drawing.Color.White;
            this.lbLoaiHinhDuLich.Location = new System.Drawing.Point(156, 5);
            this.lbLoaiHinhDuLich.Name = "lbLoaiHinhDuLich";
            this.lbLoaiHinhDuLich.Size = new System.Drawing.Size(282, 46);
            this.lbLoaiHinhDuLich.TabIndex = 0;
            this.lbLoaiHinhDuLich.Text = "Loại hình du lịch";
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.panelLeft.Controls.Add(this.panel1);
            this.panelLeft.Controls.Add(this.textBoxTimKiem);
            this.panelLeft.Controls.Add(this.lbTimKiem);
            this.panelLeft.Controls.Add(this.dataGridViewLoaiHinhDuLich);
            this.panelLeft.Controls.Add(this.btnThem);
            this.panelLeft.Controls.Add(this.btnXoa);
            this.panelLeft.Controls.Add(this.textBoxTenLoaiHinhDuLich);
            this.panelLeft.Controls.Add(this.lbTenLoaiHinhDuLich);
            this.panelLeft.Location = new System.Drawing.Point(0, 55);
            this.panelLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(495, 528);
            this.panelLeft.TabIndex = 37;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(0, 215);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(547, 2);
            this.panel1.TabIndex = 16;
            // 
            // textBoxTimKiem
            // 
            this.textBoxTimKiem.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.textBoxTimKiem.Location = new System.Drawing.Point(164, 241);
            this.textBoxTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxTimKiem.Name = "textBoxTimKiem";
            this.textBoxTimKiem.Size = new System.Drawing.Size(271, 31);
            this.textBoxTimKiem.TabIndex = 11;
            this.textBoxTimKiem.TextChanged += new System.EventHandler(this.textBoxTimKiem_TextChanged);
            // 
            // lbTimKiem
            // 
            this.lbTimKiem.AutoSize = true;
            this.lbTimKiem.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.lbTimKiem.Location = new System.Drawing.Point(67, 244);
            this.lbTimKiem.Name = "lbTimKiem";
            this.lbTimKiem.Size = new System.Drawing.Size(91, 25);
            this.lbTimKiem.TabIndex = 10;
            this.lbTimKiem.Text = "Tìm kiếm";
            // 
            // dataGridViewLoaiHinhDuLich
            // 
            this.dataGridViewLoaiHinhDuLich.AllowUserToAddRows = false;
            this.dataGridViewLoaiHinhDuLich.AllowUserToDeleteRows = false;
            this.dataGridViewLoaiHinhDuLich.AllowUserToResizeRows = false;
            this.dataGridViewLoaiHinhDuLich.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewLoaiHinhDuLich.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewLoaiHinhDuLich.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLoaiHinhDuLich.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maLoaiHinhDuLich,
            this.tenLoaiHinhDuLich});
            this.dataGridViewLoaiHinhDuLich.Location = new System.Drawing.Point(17, 286);
            this.dataGridViewLoaiHinhDuLich.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewLoaiHinhDuLich.MultiSelect = false;
            this.dataGridViewLoaiHinhDuLich.Name = "dataGridViewLoaiHinhDuLich";
            this.dataGridViewLoaiHinhDuLich.ReadOnly = true;
            this.dataGridViewLoaiHinhDuLich.RowHeadersWidth = 51;
            this.dataGridViewLoaiHinhDuLich.RowTemplate.Height = 29;
            this.dataGridViewLoaiHinhDuLich.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewLoaiHinhDuLich.Size = new System.Drawing.Size(454, 140);
            this.dataGridViewLoaiHinhDuLich.TabIndex = 12;
            // 
            // maLoaiHinhDuLich
            // 
            this.maLoaiHinhDuLich.DataPropertyName = "maLoaiHinhDuLich";
            this.maLoaiHinhDuLich.HeaderText = "Mã loại hình du lịch";
            this.maLoaiHinhDuLich.MinimumWidth = 6;
            this.maLoaiHinhDuLich.Name = "maLoaiHinhDuLich";
            this.maLoaiHinhDuLich.ReadOnly = true;
            // 
            // tenLoaiHinhDuLich
            // 
            this.tenLoaiHinhDuLich.DataPropertyName = "tenLoaiHinhDuLich";
            this.tenLoaiHinhDuLich.HeaderText = "Tên loại hình du lịch";
            this.tenLoaiHinhDuLich.MinimumWidth = 6;
            this.tenLoaiHinhDuLich.Name = "tenLoaiHinhDuLich";
            this.tenLoaiHinhDuLich.ReadOnly = true;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(177)))), ((int)(((byte)(65)))));
            this.btnThem.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(193, 141);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(89, 42);
            this.btnThem.TabIndex = 7;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Red;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(380, 430);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(91, 33);
            this.btnXoa.TabIndex = 9;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // textBoxTenLoaiHinhDuLich
            // 
            this.textBoxTenLoaiHinhDuLich.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.textBoxTenLoaiHinhDuLich.Location = new System.Drawing.Point(241, 69);
            this.textBoxTenLoaiHinhDuLich.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxTenLoaiHinhDuLich.Name = "textBoxTenLoaiHinhDuLich";
            this.textBoxTenLoaiHinhDuLich.Size = new System.Drawing.Size(197, 31);
            this.textBoxTenLoaiHinhDuLich.TabIndex = 6;
            // 
            // lbTenLoaiHinhDuLich
            // 
            this.lbTenLoaiHinhDuLich.AutoSize = true;
            this.lbTenLoaiHinhDuLich.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.lbTenLoaiHinhDuLich.Location = new System.Drawing.Point(49, 72);
            this.lbTenLoaiHinhDuLich.Name = "lbTenLoaiHinhDuLich";
            this.lbTenLoaiHinhDuLich.Size = new System.Drawing.Size(182, 25);
            this.lbTenLoaiHinhDuLich.TabIndex = 3;
            this.lbTenLoaiHinhDuLich.Text = "Tên loại hình du lịch";
            // 
            // fmLoaiHinhDuLich
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 568);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelDiaDiem);
            this.MaximumSize = new System.Drawing.Size(514, 615);
            this.MinimumSize = new System.Drawing.Size(514, 615);
            this.Name = "fmLoaiHinhDuLich";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loại chi phí | Tour App";
            this.Load += new System.EventHandler(this.fmLoaiHinhDuLich_Load);
            this.panelDiaDiem.ResumeLayout(false);
            this.panelDiaDiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLoaiHinhDuLich)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDiaDiem;
        private System.Windows.Forms.Label lbLoaiHinhDuLich;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.TextBox textBoxTimKiem;
        private System.Windows.Forms.Label lbTimKiem;
        private System.Windows.Forms.DataGridView dataGridViewLoaiHinhDuLich;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.TextBox textBoxTenLoaiHinhDuLich;
        private System.Windows.Forms.Label lbTenLoaiHinhDuLich;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maLoaiHinhDuLich;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenLoaiHinhDuLich;
    }
}