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
    public partial class fmDangKy : Form
    {
        B_KH b_khachhang = new B_KH();
        B_LoaiKH b_loaikhachhang = new B_LoaiKH();
        B_tour b_tour = new B_tour();
        B_doan b_doan = new B_doan();
        B_DangKy b_dangky = new B_DangKy();
        B_giatour b_giatour = new B_giatour();
        public fmDangKy()
        {
            InitializeComponent();
            LoadComboboxMaLoaiKhachHang();
            LoadComboboxMaSoKhachHang();
            LoadComboboxMaTour();
            LoadDanhSachDangKyTour();
        }

        private void fmDangKy_Load(object sender, EventArgs e)
        {
            LoadGiaTheoTour();
            LoadDoanTheoTour();
            TinhTongTien();
        }

        public void LoadDanhSachDangKyTour()
        {
            dataGridViewDangKy.DataSource = b_dangky.GetListDangKy();
        }

        public void LoadComboboxMaSoKhachHang()
        {
            comboBoxMaSoKhachHang.DataSource = b_khachhang.GetKhachHang();
            comboBoxMaSoKhachHang.DisplayMember = "hoTenKhachHang";
        }

        public void LoadComboboxMaTour()
        {
            comboBoxMaTour.DataSource = b_tour.GetAllTour();
            comboBoxMaTour.DisplayMember = "tenGoiTour";
        }

        public void LoadComboboxMaLoaiKhachHang()
        {
            comboBoxMaLoaiKhachHang.DataSource = b_loaikhachhang.GetLoaikhachhangs();
            comboBoxMaLoaiKhachHang.DisplayMember = "tenLoaiKhachHang";
        }

        public void DangKyTour()
        {
            List<khachhang> listKhachHang = b_khachhang.GetKhachHang();
            List<loaikhachhang> listLoaiKhachHang = b_loaikhachhang.GetLoaikhachhangs();
            List<doandulich> listDoanDuLich = b_doan.GetAllDoan();
            List<tour> listTour = b_tour.GetAllTour();
            List<giatour> listGiaTour = b_giatour.GetGiaTour();
            int maDoanEdit = 0;
           
            try
            {
                if (Int32.Parse(textBoxSoLuongKhachHang.Text) <= 50)
                {
                    if (!String.IsNullOrWhiteSpace(comboBox3MaSoDoan.Text))
                    {
                        try
                        {
                            dangky objDangKy = new dangky();
                            doandulich objDoan = new doandulich();
                            tour objTour = new tour();

                            foreach (var itemmaSoKhachHang in listKhachHang)
                            {
                                if (itemmaSoKhachHang.hoTenKhachHang.Equals(comboBoxMaSoKhachHang.Text))
                                {
                                    objDangKy.maSoKhachHang = itemmaSoKhachHang.maSoKhachHang;
                                }
                            }

                            foreach (var itemmaTour in listTour)
                            {
                                if (itemmaTour.tenGoiTour.Equals(comboBoxMaTour.Text))
                                {
                                    objDangKy.maTour = itemmaTour.maSoTour;
                                   

                                    foreach (var itemGiaTour in listGiaTour)
                                    {
                                        if (itemGiaTour.maGiaTour.Equals(itemmaTour.idGiaTour))
                                        {
                                            objDangKy.giaTourDangKy = itemGiaTour.gia;
                                        }
                                    }
                                }
                            }

                            foreach (var itemmaLoaiKhachHang in listLoaiKhachHang)
                            {
                                if (comboBoxMaLoaiKhachHang.Text.Equals("DAO.loaikhachhang"))
                                {
                                    if (itemmaLoaiKhachHang.tenLoaiKhachHang.Equals("Cá nhân"))
                                    {
                                        objDangKy.maLoaiKhachHang = itemmaLoaiKhachHang.maLoaiKhachHang;
                                    }
                                }
                                else
                                {
                                    if (itemmaLoaiKhachHang.tenLoaiKhachHang.Equals(comboBoxMaLoaiKhachHang.Text))
                                    {
                                        objDangKy.maLoaiKhachHang = itemmaLoaiKhachHang.maLoaiKhachHang;
                                    }
                                }


                            }
                            objDangKy.ngayDangKy = DateTime.Parse(dateTimePickerNgayDangKy.Value.Date.ToString("yyyy-MM-dd hh:mm:ss.ss"));

                            foreach (var itemmaSoDoan in listDoanDuLich)
                            {
                                if (itemmaSoDoan.tenGoiDoan.Equals(comboBox3MaSoDoan.Text))
                                {
                                    objDangKy.maSoDoan = itemmaSoDoan.maSoDoan;
                                    maDoanEdit = itemmaSoDoan.maSoDoan;
                                }
                            }

                            objDangKy.soLuongKhachHang = Int32.Parse(textBoxSoLuongKhachHang.Text);
                            objDoan.soLuongKhachHang = Int32.Parse(textBoxSoLuongKhachHang.Text);
                            
                            objDangKy.trangThai = 1;

                            if (b_dangky.ThemDangKy(objDangKy))
                            {
                                if (b_doan.ThemSoLuongKhachHangDoan(objDoan, maDoanEdit))
                                {
                                    System.Diagnostics.Debug.WriteLine("Thêm số lượng bên đoàn du lịch thành công!");
                                }
                                
                                LoadDanhSachDangKyTour();
                                MessageBox.Show("Đăng ký thành công!", "Thông báo");
                            }
                        }
                        catch (Exception e)
                        {
                            MessageBox.Show("Thêm không thành công!", "Thông báo");
                            System.Diagnostics.Debug.WriteLine(e);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Đoàn đang trống! Vui lòng chọn đoàn!", "Thông báo");
                    }
                }
                else
                {
                    MessageBox.Show("Số lượng khách hàng phải nhỏ hơn 50!", "Thông báo");
                }
            }
            catch (FormatException fmex)
            {
                MessageBox.Show("Số lượng phải là số!", "Thông báo");
                System.Diagnostics.Debug.WriteLine(fmex);
            }

        }

        public void XoaDangKy()
        {
            if (dataGridViewDangKy.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridViewDangKy.SelectedRows)
                {
                    int id = Convert.ToInt32(row.Cells[0].Value.ToString());
                    b_dangky.XoaDangKy(id); //Update trangThai = 0

                    //Giảm số lượng trong đoàn và tour
                    List<dangky> listDangKy = b_dangky.GetAllDangKy();
                    foreach (var itemDK in listDangKy)
                    {
                        if (itemDK.id == id)
                        {
                            b_doan.GiamSoLuongKhachHangDoan((int)itemDK.soLuongKhachHang, itemDK.maSoDoan);
                        }
                    }

                    LoadDanhSachDangKyTour();
                    MessageBox.Show("Xóa thành công!", "Thông báo");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn đăng ký muốn xóa!", "Thông báo");
            }
        }

        public void XemChiTiet()
        {
            foreach (DataGridViewRow row in dataGridViewDangKy.SelectedRows)
            {
                if (!String.Equals(row.Cells[0].Value.ToString(), "System.Windows.Forms.DataGridViewTextBoxColumn"))
                {
                    string id = row.Cells[0].Value.ToString();

                    fmChiTietDangKy formChiTietDangKy = new fmChiTietDangKy(int.Parse(id), this);
                    System.Diagnostics.Debug.WriteLine(int.Parse(id));

                    formChiTietDangKy.ShowDialog();

                }

            }
        }

        public void LoadDoanTheoTour()
        {
            List<tour> listTour = b_tour.GetAllTour();

            foreach (var itemmaTour in listTour)
            {
                if (itemmaTour.tenGoiTour.Equals(comboBoxMaTour.Text))
                {
                    comboBox3MaSoDoan.DataSource = b_doan.GetListDoanWithMaTour(itemmaTour.maSoTour);
                    comboBox3MaSoDoan.DisplayMember = "tenGoiDoan";
                }
            }
        }

        public void LoadGiaTheoTour()
        {
            List<tour> listTour = b_tour.GetAllTour();
            List<giatour> listGiaTour = b_giatour.GetGiaTour();

            foreach (var itemmaTour in listTour)
            {
                if (itemmaTour.tenGoiTour.Equals(comboBoxMaTour.Text))
                {
                    foreach (var itemGiaTour in listGiaTour)
                    {
                        if (itemGiaTour.maGiaTour.Equals(itemmaTour.idGiaTour))
                        {
                            textBoxGiaTour.Text = itemGiaTour.gia.ToString();
                        }
                    }
                }
            }
        }

        
        private void buttonTaoMoi_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("XÁC NHẬN ĐĂNG KÝ KHÁCH HÀNG?\nLƯU Ý: KHÔNG THỂ SỬA SAU KHI ĐĂNG KÝ", "Thông báo", MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                DangKyTour();
            }
            
        }

        private void buttonXemChiTiet_Click(object sender, EventArgs e)
        {
            XemChiTiet();
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Bạn có chắc muốn xóa không ?? :D", "Xóa đăng ký", MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                XoaDangKy();
            }
        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxMaLoaiKhachHang_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void comboBoxMaLoaiKhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxMaLoaiKhachHang.Text.Equals("Cá nhân") || comboBoxMaLoaiKhachHang.Text.Equals("DAO.loaikhachhang"))
            {
                textBoxSoLuongKhachHang.Text = "1";
                textBoxSoLuongKhachHang.Enabled = false;
            }
            else
            {
                textBoxSoLuongKhachHang.Text = "";
                textBoxSoLuongKhachHang.Enabled = true;
            }

            
        }

        private void comboBoxMaTour_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadGiaTheoTour();
            LoadDoanTheoTour();
            
        }

        private void textBoxSoLuongKhachHang_TextChanged(object sender, EventArgs e)
        {
            TinhTongTien();
        }

        private void TinhTongTien()
        {
            int giaTour = 0;
            int soLuongKH = 0;
            if (!String.IsNullOrWhiteSpace(textBoxSoLuongKhachHang.Text) && !String.IsNullOrWhiteSpace(textBoxGiaTour.Text))
            {
                giaTour = Int32.Parse(textBoxGiaTour.Text);
                soLuongKH = Int32.Parse(textBoxSoLuongKhachHang.Text);
                textBoxTongTien.Text = (giaTour*soLuongKH).ToString();
            }
            else
            {
                textBoxTongTien.Text = "";
            }

        }

        private void textBoxGiaTour_TextChanged(object sender, EventArgs e)
        {
            TinhTongTien();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

          

        }

        private void buttonThemKhachHang_Click(object sender, EventArgs e)
        {
            fmKhachHang fmKH = new fmKhachHang();
            fmKH.ShowDialog();
        }

        private void buttonThemLoaiKhachHang_Click(object sender, EventArgs e)
        {
            fmLoaiKhachHang fmLoaiKH = new fmLoaiKhachHang();
            fmLoaiKH.ShowDialog();
        }
    }
}
