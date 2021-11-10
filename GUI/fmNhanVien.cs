﻿using BUS;
using DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class fmNhanVien : Form
    {
        B_nhanvien bNhanVien = new BUS.B_nhanvien();
        public fmNhanVien()
        {
            InitializeComponent();
            LoadDanhSachNhanVien();
        }

        public void LoadDanhSachNhanVien()
        {
            dataGridViewNhanVien.DataSource = bNhanVien.GetListNhanVien();
        }

        private void ClearFields()
        {
            textBoxTenNhanVien.Text = "";
            textBoxNhiemVu.Text = "";
        }

        // Xem chi tiết
        private void buttonXemChiTiet_Click(object sender, EventArgs e)
        {
            XemChiTiet();
        }
        public void XemChiTiet()
        {
            foreach (DataGridViewRow row in dataGridViewNhanVien.SelectedRows) // lấy row đã click
            {
                if (!String.Equals(row.Cells[0].Value.ToString(), "System.Windows.Forms.DataGridViewTextBoxColumn"))
                {
                    string maNhanVien = row.Cells[0].Value.ToString();

                    fmChiTietNhanVien formChiTietNhanVien = new fmChiTietNhanVien(int.Parse(maNhanVien), this);

                    formChiTietNhanVien.ShowDialog();

                }
            }
        }

        // Thêm nhân viên
        private void buttonTaoMoi_Click(object sender, EventArgs e)
        {
            List<nhanvien> listNhanVien = bNhanVien.GetAllNhanVien();

            if (!String.IsNullOrEmpty(textBoxTenNhanVien.Text))
            {
                if (!String.IsNullOrEmpty(textBoxNhiemVu.Text))
                {                   
                    //Khai báo object
                    nhanvien objNhanVien = new nhanvien();

                    objNhanVien.tenNhanVien = textBoxTenNhanVien.Text;
                    objNhanVien.nhiemVu = textBoxNhiemVu.Text;

                    //Bắt đầu thêm các dữ liệu
                    try
                    {
                        if (bNhanVien.ThemNhanVien(objNhanVien))    // ??
                        {
                            System.Diagnostics.Debug.WriteLine("Thêm tour thành công!");    // ??
                            MessageBox.Show("Thêm nhân viên thành công!", "Thông báo");

                            ClearFields();
                            LoadDanhSachNhanVien();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Thêm không thành công!", "Thông báo");
                        System.Diagnostics.Debug.WriteLine(ex);
                    } 
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập nhiệm vụ!", "Thông báo");
                    textBoxNhiemVu.Focus();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập tên nhân viên!", "Thông báo");
                textBoxTenNhanVien.Focus();
            }
        }

        //Xóa nhân viên
        private void buttonXoa_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Bạn có chắc muốn xóa không ?? :D", "Xóa tour", MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                XoaNhanVien();
            }
        }

        public void XoaNhanVien()
        {
            nhanvien objNhanVien = new nhanvien();

            if (dataGridViewNhanVien.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridViewNhanVien.SelectedRows) // lấy row đã click
                {
                    int maNhanVien = Convert.ToInt32(row.Cells[0].Value.ToString());

                    bNhanVien.XoaNhanVien(objNhanVien, maNhanVien);

                    LoadDanhSachNhanVien();
                    MessageBox.Show("Xóa thành công!", "Thông báo");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn tour muốn xóa!", "Thông báo");
            }
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewNhanVien_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBoxNhiemVu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
