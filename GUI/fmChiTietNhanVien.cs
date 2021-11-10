﻿using BUS;
using DAO;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class fmChiTietNhanVien : Form
    {
        B_nhanvien bNhanVien = new B_nhanvien();

        public fmChiTietNhanVien(int maNhanVien, fmNhanVien fmNV) // ??
        {
            InitializeComponent();
            fmMain = fmNV;
            this.maNhanVien = maNhanVien;

            HienThiChiTietNhanVien();
        }

        private fmNhanVien fmMain;
        public int maNhanVien { get; set; } //Set data sẽ lấy từ form quản lý tour

        // Hiển thị chi tiết nhân viên
        private void HienThiChiTietNhanVien()
        {
            List<dynamic> listDetailsNhanVien = bNhanVien.GetListDetailsNhanVien(maNhanVien);

            //Convert List<dynamic> sang Datatable để dễ hiển thị chi tiết tour
            var json = JsonConvert.SerializeObject(listDetailsNhanVien);
            DataTable dataTableDetailsNhanVien = (DataTable)JsonConvert.DeserializeObject(json, (typeof(DataTable)));

            //Hiển thị
            textBoxMaNhanVien.Text = maNhanVien.ToString();
            textBoxTenNhanVien.Text = dataTableDetailsNhanVien.Rows[0][1].ToString();
            textBoxNhiemVu.Text = dataTableDetailsNhanVien.Rows[0][2].ToString();
        }

        // Sửa nhân viên
        public void SuaNhanVien()
        {           
            if (KiemTraTextBoxNhanVien()==true)
            {                    
                //Khai báo object
                nhanvien objNhanVien = new nhanvien();

                objNhanVien.tenNhanVien = textBoxTenNhanVien.Text;
                objNhanVien.nhiemVu = textBoxNhiemVu.Text;

                //Bắt đầu sửa các dữ liệu
                try
                {
                    if (bNhanVien.SuaNhanVien(objNhanVien, maNhanVien))
                    {
                        System.Diagnostics.Debug.WriteLine("Sửa nhân viên thành công!");

                        fmMain.LoadDanhSachNhanVien();
                        MessageBox.Show("Sửa nhân viên thành công!", "Thông báo");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Sửa không thành công!", "Thông báo");
                    System.Diagnostics.Debug.WriteLine(ex);
                }
            }
        }

        //Kiểm tra textbox nhân viên
        bool KiemTraTextBoxNhanVien()
        {
            if (String.IsNullOrEmpty(textBoxTenNhanVien.Text))
            {
                MessageBox.Show("Vui lòng nhập tên nhân viên!", "Thông báo");
                textBoxTenNhanVien.Focus();
                return false;
            }
            if (String.IsNullOrEmpty(textBoxNhiemVu.Text))
            {
                MessageBox.Show("Vui lòng nhập nhiệm vụ!", "Thông báo");
                textBoxNhiemVu.Focus();
                return false;
            }

            //Kiểm tra Kí tự đặc biệt và số
            Regex regex = new Regex(@"[!@#$%&^*()-_+=\/|?0-9]");
            if (regex.IsMatch(textBoxTenNhanVien.Text))
            {
                MessageBox.Show("Tên nhân viên không được có số hoặc kí tự đặc biệt!", "Thông báo");
                textBoxTenNhanVien.Focus();
                return false;
            }
            if (regex.IsMatch(textBoxNhiemVu.Text))
            {
                MessageBox.Show("Nhiệm vụ không được có số hoặc kí tự đặc biệt!", "Thông báo");
                textBoxNhiemVu.Focus();
                return false;
            }
            return true;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonDong_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            SuaNhanVien();
        }

        private void textBoxNhiemVu_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
