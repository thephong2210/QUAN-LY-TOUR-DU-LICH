﻿
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
            this.lbLoaiHinhDuLich = new System.Windows.Forms.Label();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.textBoxTimKiem = new System.Windows.Forms.TextBox();
            this.lbTimKiem = new System.Windows.Forms.Label();
            this.dataGridViewLoaiHinhDuLich = new System.Windows.Forms.DataGridView();
            this.maLoaiHinhDuLich = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenLoaiHinhDuLich = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnChiTiet = new System.Windows.Forms.Button();
            this.textBoxTenLoaiHinhDuLich = new System.Windows.Forms.TextBox();
            this.lbTenLoaiHinhDuLich = new System.Windows.Forms.Label();
            this.panelDiaDiem.SuspendLayout();
            this.panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLoaiHinhDuLich)).BeginInit();
            this.SuspendLayout();
            // 
            // panelDiaDiem
            // 
            this.panelDiaDiem.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelDiaDiem.Controls.Add(this.lbLoaiHinhDuLich);
            this.panelDiaDiem.Location = new System.Drawing.Point(0, 0);
            this.panelDiaDiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelDiaDiem.Name = "panelDiaDiem";
            this.panelDiaDiem.Size = new System.Drawing.Size(495, 59);
            this.panelDiaDiem.TabIndex = 3;
            // 
            // lbLoaiHinhDuLich
            // 
            this.lbLoaiHinhDuLich.AutoSize = true;
            this.lbLoaiHinhDuLich.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold);
            this.lbLoaiHinhDuLich.ForeColor = System.Drawing.Color.White;
            this.lbLoaiHinhDuLich.Location = new System.Drawing.Point(58, 2);
            this.lbLoaiHinhDuLich.Name = "lbLoaiHinhDuLich";
            this.lbLoaiHinhDuLich.Size = new System.Drawing.Size(315, 51);
            this.lbLoaiHinhDuLich.TabIndex = 0;
            this.lbLoaiHinhDuLich.Text = "Loại hình du lịch";
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.panelLeft.Controls.Add(this.textBoxTimKiem);
            this.panelLeft.Controls.Add(this.lbTimKiem);
            this.panelLeft.Controls.Add(this.dataGridViewLoaiHinhDuLich);
            this.panelLeft.Controls.Add(this.btnThem);
            this.panelLeft.Controls.Add(this.btnXoa);
            this.panelLeft.Controls.Add(this.btnChiTiet);
            this.panelLeft.Controls.Add(this.textBoxTenLoaiHinhDuLich);
            this.panelLeft.Controls.Add(this.lbTenLoaiHinhDuLich);
            this.panelLeft.Location = new System.Drawing.Point(0, 55);
            this.panelLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(495, 577);
            this.panelLeft.TabIndex = 37;
            // 
            // textBoxTimKiem
            // 
            this.textBoxTimKiem.Location = new System.Drawing.Point(142, 300);
            this.textBoxTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxTimKiem.Name = "textBoxTimKiem";
            this.textBoxTimKiem.Size = new System.Drawing.Size(271, 22);
            this.textBoxTimKiem.TabIndex = 11;
            // 
            // lbTimKiem
            // 
            this.lbTimKiem.AutoSize = true;
            this.lbTimKiem.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.lbTimKiem.Location = new System.Drawing.Point(15, 296);
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
            this.dataGridViewLoaiHinhDuLich.Location = new System.Drawing.Point(17, 356);
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
            this.btnThem.Location = new System.Drawing.Point(17, 179);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(89, 50);
            this.btnThem.TabIndex = 7;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Red;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnXoa.Location = new System.Drawing.Point(313, 179);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(91, 50);
            this.btnXoa.TabIndex = 9;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnChiTiet
            // 
            this.btnChiTiet.BackColor = System.Drawing.Color.SlateGray;
            this.btnChiTiet.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnChiTiet.ForeColor = System.Drawing.Color.White;
            this.btnChiTiet.Location = new System.Drawing.Point(170, 179);
            this.btnChiTiet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnChiTiet.Name = "btnChiTiet";
            this.btnChiTiet.Size = new System.Drawing.Size(89, 50);
            this.btnChiTiet.TabIndex = 8;
            this.btnChiTiet.Text = "Chi tiết";
            this.btnChiTiet.UseVisualStyleBackColor = false;
            this.btnChiTiet.Click += new System.EventHandler(this.btnChiTiet_Click);
            // 
            // textBoxTenLoaiHinhDuLich
            // 
            this.textBoxTenLoaiHinhDuLich.Location = new System.Drawing.Point(219, 88);
            this.textBoxTenLoaiHinhDuLich.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxTenLoaiHinhDuLich.Name = "textBoxTenLoaiHinhDuLich";
            this.textBoxTenLoaiHinhDuLich.Size = new System.Drawing.Size(173, 22);
            this.textBoxTenLoaiHinhDuLich.TabIndex = 6;
            // 
            // lbTenLoaiHinhDuLich
            // 
            this.lbTenLoaiHinhDuLich.AutoSize = true;
            this.lbTenLoaiHinhDuLich.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.lbTenLoaiHinhDuLich.Location = new System.Drawing.Point(12, 85);
            this.lbTenLoaiHinhDuLich.Name = "lbTenLoaiHinhDuLich";
            this.lbTenLoaiHinhDuLich.Size = new System.Drawing.Size(182, 25);
            this.lbTenLoaiHinhDuLich.TabIndex = 3;
            this.lbTenLoaiHinhDuLich.Text = "Tên loại hình du lịch";
            // 
            // fmLoaiHinhDuLich
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 631);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelDiaDiem);
            this.Name = "fmLoaiHinhDuLich";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fmChiTietLoaiHinhDuLich";
            this.panelDiaDiem.ResumeLayout(false);
            this.panelDiaDiem.PerformLayout();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn maLoaiHinhDuLich;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenLoaiHinhDuLich;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnChiTiet;
        private System.Windows.Forms.TextBox textBoxTenLoaiHinhDuLich;
        private System.Windows.Forms.Label lbTenLoaiHinhDuLich;
    }
}