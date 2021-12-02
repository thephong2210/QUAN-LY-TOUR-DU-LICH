﻿using BUS;
using DAO;
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
    public partial class fmKhachHang : Form
    {
        B_KH b_KH = new B_KH();
        private fmDangKy fmDK;
        public fmKhachHang(fmDangKy fmDK)
        {
            InitializeComponent();
            this.fmDK = fmDK;
            LoadDSKH();
        }
        public void LoadDSKH()
        {
            dataGridViewQuanLyKH.DataSource = b_KH.GetKhachHang();
            dataGridViewQuanLyKH.AutoGenerateColumns = false;
        }
        public void ClearField()
        {
            textBoxTenKH.Text = "";
            textBoxCMND.Text = "";
            textBoxDiaChi.Text = "";
            textBoxSDT.Text = "";
            textBoxQuocTich.Text = "";
            radioButtonNam.Checked = false;
            radioButtonNu.Checked = false;

        }

        private bool KiemTraTT()
        {
            if (String.IsNullOrEmpty(textBoxTenKH.Text))
            {
                MessageBox.Show("Vui lòng nhập tên khách hàng", "Thông báo");
                textBoxTenKH.Focus();
                return false;
            }
        
           if(Regex.IsMatch(textBoxTenKH.Text,@"[""!#$%&'()*+,-./:;<=>?@[\\\]^_`{|}~0-9]"))
             {
                 MessageBox.Show("Tên khách hàng không có số và kí tự đặc biệt!", "Thông báo");
                 textBoxTenKH.Focus();
                 return false;
             }

            if (String.IsNullOrEmpty(textBoxCMND.Text))
            {
                MessageBox.Show("Vui lòng nhập CMND", "Thông báo");
                textBoxCMND.Focus();
                return false;
            }
          
            if (!Regex.IsMatch(textBoxCMND.Text, @"^([0-9]{9})$"))
            {
                
                MessageBox.Show("Số CMND gồm 9 chữ số", "Thông báo");
                textBoxCMND.Focus();
                return false;
            }

            if (String.IsNullOrEmpty(textBoxDiaChi.Text))
            {
                MessageBox.Show("Vui lòng nhập địa chỉ", "Thông báo");
                textBoxDiaChi.Focus();
                return false;
            }
     
            if (Regex.IsMatch(textBoxDiaChi.Text, @"[""!#$%&'()*+,-.:;<=>?@[\\\]^_`{|}~]"))
            {
                MessageBox.Show("Vui lòng nhập địa chỉ không chứa kí tự đặc biệt", "Thông báo");
                textBoxDiaChi.Focus();
                return false;
            }

            if (radioButtonNam.Checked == false && radioButtonNu.Checked == false)
            {
                MessageBox.Show("Vui lòng chọn giới tính", "Thông báo");
                return false;
            }

            if (String.IsNullOrEmpty(textBoxSDT.Text))
            {
                MessageBox.Show("Vui lòng nhập số điện thoại", "Thông báo");
                textBoxSDT.Focus();
                return false;
            }

            if (!Regex.IsMatch(textBoxSDT.Text, @"^(0+[0-9]{9})$"))
            {
                MessageBox.Show("Số điện thoại gồm 10 chữ số và bắt đầu bằng 0", "Thông báo");
                textBoxSDT.Focus();
                return false;
            }
            if (String.IsNullOrEmpty(textBoxQuocTich.Text))
            {
                MessageBox.Show("Vui lòng nhập quốc tịch", "Thông báo");
                textBoxQuocTich.Focus();
                return false;
            }

            if (Regex.IsMatch(textBoxQuocTich.Text, @"[""!#$%&'()*+,-./:;<=>?@[\\\]^_`{|}~0-9]"))
            {
                MessageBox.Show("Quốc tịch không được có số và kí tự đặc biệt!", "Thông báo");
                textBoxQuocTich.Focus();
                return false;
            }
            return true;
        }

        public void ThemKhachHang1()
        {
            if (KiemTraTT())
            {
                try
                {
                    khachhang objKhachHang = new khachhang();
                    objKhachHang.hoTenKhachHang = textBoxTenKH.Text;
                    objKhachHang.soCMND = textBoxCMND.Text;
                    objKhachHang.diaChi = textBoxDiaChi.Text;
                    objKhachHang.gioiTinh = radioButtonNam.Text;
                    objKhachHang.gioiTinh = radioButtonNu.Text;
                    objKhachHang.SDT = textBoxSDT.Text;
                    objKhachHang.quocTich = textBoxQuocTich.Text;
                    objKhachHang.trangThai = 1;

                    if (b_KH.ThemKhachHang(objKhachHang))
                    {
                        LoadDSKH();
                        ClearField();
                        fmDK.LoadComboboxMaLoaiKhachHang();
                        MessageBox.Show("Thêm khách hàng thành công", "Thông báo");
                        
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Thêm khách hàng không thành công", "Thông báo");
                    System.Diagnostics.Debug.WriteLine(e);
                }
            }
        }


        public void XoaKhachHang()
        {
          
            if (dataGridViewQuanLyKH.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridViewQuanLyKH.SelectedRows)
                {
                    int maKhachHang = Convert.ToInt32(row.Cells[0].Value.ToString());
                    b_KH.XoaKhachHang(maKhachHang);
                    LoadDSKH();
                    fmDK.LoadComboboxMaLoaiKhachHang();
                    MessageBox.Show("Xóa thành công", "Thông báo");

                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần xóa", "Thông báo");
            }
        }




        public void XemChiTiet()
        {
            foreach (DataGridViewRow row in dataGridViewQuanLyKH.SelectedRows) // lấy row đã click
            {
                if (!String.Equals(row.Cells[0].Value.ToString(), "System.Windows.Forms.DataGridViewTextBoxColumn"))
                {
                    string maSoKhachHang = row.Cells[0].Value.ToString();

                    fmChiTietKhachHang formChiTietKhachHang = new fmChiTietKhachHang(int.Parse(maSoKhachHang), this, fmDK);

                    formChiTietKhachHang.ShowDialog();

                }
            }
        }

        private void buttonTaoMoi_Click(object sender, EventArgs e)
        {
            ThemKhachHang1();
        }

        private void buttonXemChiTiet_Click(object sender, EventArgs e)
        {
            XemChiTiet();
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Bạn có muốn xóa khách hàng không", "Thông báo", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                XoaKhachHang();
            }
        }
        public void TimKiemTenKhachHang()
        {

            if (!String.IsNullOrWhiteSpace(textBoxTimKiem.Text))
            {
                string searchValue = textBoxTimKiem.Text;
                dataGridViewQuanLyKH.DataSource = b_KH.TimKiemTenKhachHang(searchValue);
            }
            else
            {
                LoadDSKH();
            }

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            TimKiemTenKhachHang();
        }
    }
}
