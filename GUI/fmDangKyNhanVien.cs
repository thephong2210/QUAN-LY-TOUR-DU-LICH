using BUS;
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
    public partial class fmDangKyNhanVien : Form
    {
        B_dangkynhanvien b_dangkynhanvien = new B_dangkynhanvien();
        B_doan b_doan = new B_doan();
        B_nhanvien b_nhanvien = new B_nhanvien();

        public fmDangKyNhanVien()
        {
            InitializeComponent();
            RefreshData();
        }

        public void RefreshData()
        {
            LoadDanhSachDangKyTour();
            LoadComboboxDoan();
            LoadComboboxNhanVien();
            GetInfoChiTietCuaDoan();
        }

        private void fmDangKy_Load(object sender, EventArgs e)
        {

            GetInfoChiTietCuaDoan();
            
        }

        public void LoadDanhSachDangKyTour()
        {
            dataGridViewDangKy.DataSource = b_dangkynhanvien.GetListDangKy();
            dataGridViewDangKy.AutoGenerateColumns = false;
        }

        public void LoadComboboxDoan()
        {
            comboBoxTenDoan.DataSource = b_doan.GetAllDoan();
            comboBoxTenDoan.DisplayMember = "tenGoiDoan";
        }

        public void LoadComboboxNhanVien()
        {
            comboBoxTenNhanVien.DataSource = b_nhanvien.GetAllNhanVien();
            comboBoxTenNhanVien.DisplayMember = "tenNhanVien";
        }

        public void GetInfoChiTietCuaDoan() //Max 5 nhân viên/đoàn
        {
            List<doandulich> listDoanDuLich = b_doan.GetAllDoan();

            if (!String.IsNullOrWhiteSpace(comboBoxTenDoan.Text))
            {
                foreach (var itemmaSoDoan in listDoanDuLich)
                {
                    if (itemmaSoDoan.tenGoiDoan.Equals(comboBoxTenDoan.Text))
                    {
                        //số lượng nhân viên còn lại của đoàn
                        labelSoLuongConLai.Text = (5 - Convert.ToInt32(itemmaSoDoan.SoLuongNhanVien)).ToString();
                        dateTimePickerNgayBatDau.MinDate = Convert.ToDateTime(itemmaSoDoan.thoiGianKhoiHanh);
                        dateTimePickerNgayBatDau.MaxDate = Convert.ToDateTime(itemmaSoDoan.thoiGianKetThuc);

                        dateTimePickerNgayKetThuc.MaxDate = Convert.ToDateTime(itemmaSoDoan.thoiGianKetThuc);
                        dateTimePickerNgayKetThuc.MinDate = Convert.ToDateTime(itemmaSoDoan.thoiGianKhoiHanh);
                    }
                }
            }
            else
            {
                labelSoLuongConLai.Text = "0";
            }
            
        }

        public bool CheckThoiGianDangKy() //ngày bắt đầu < ngày kết thúc
        {
            if (dateTimePickerNgayBatDau.Value <= dateTimePickerNgayKetThuc.Value)
            {
                return true;
            }
            return false;

        }

        public bool CheckNhanVienDangKy() //check nhân viên này có đang trong đoàn khác không
        {
            List<thamgiadoan> listThamGiaDoan = b_dangkynhanvien.GetAllDangKy();
            List<nhanvien> listNhanVien = b_nhanvien.GetAllNhanVien();

            foreach (var items in listThamGiaDoan)
            {

                foreach (var itemNhanVien in listNhanVien)
                {
                        
                    if (itemNhanVien.maNhanVien == items.maNhanVien)
                    {
                        if (itemNhanVien.tenNhanVien.Equals(comboBoxTenNhanVien.Text))
                        {
                            System.Diagnostics.Debug.WriteLine(dateTimePickerNgayBatDau.Value.Date + "-" + items.thoiGianKetThuc.Date);
                            if (dateTimePickerNgayBatDau.Value.Date < items.thoiGianKetThuc.Date)
                            {
                                return false;
                            }
                        }
                       
                    }
                }
            }

            return true;

        }


        public void DangKyTour()
        {
            List<nhanvien> listNhanVien = b_nhanvien.GetAllNhanVien();
            List<doandulich> listDoanDuLich = b_doan.GetAllDoan();
            int maDoanEdit = 0;


            if (Convert.ToInt32(labelSoLuongConLai.Text) != 0)
            {
                if (CheckThoiGianDangKy())
                {
                    if (CheckNhanVienDangKy())
                    {
                        if (!String.IsNullOrWhiteSpace(comboBoxTenDoan.Text))
                        {
                            try
                            {
                                thamgiadoan objThamGiaDoan = new thamgiadoan();

                                foreach (var itemNhanVien in listNhanVien)
                                {
                                    if (itemNhanVien.tenNhanVien.Equals(comboBoxTenNhanVien.Text))
                                    {
                                        objThamGiaDoan.maNhanVien = itemNhanVien.maNhanVien;
                                    }
                                }

                                foreach (var itemmaSoDoan in listDoanDuLich)
                                {
                                    if (itemmaSoDoan.tenGoiDoan.Equals(comboBoxTenDoan.Text))
                                    {
                                        objThamGiaDoan.maSoDoan = itemmaSoDoan.maSoDoan;
                                        maDoanEdit = itemmaSoDoan.maSoDoan;
                                    }
                                }

                                objThamGiaDoan.thoiGianBatDau = DateTime.Parse(dateTimePickerNgayBatDau.Value.Date.ToString("yyyy-MM-dd hh:mm:ss.ss"));
                                objThamGiaDoan.thoiGianKetThuc = DateTime.Parse(dateTimePickerNgayKetThuc.Value.Date.ToString("yyyy-MM-dd hh:mm:ss.ss"));

                                objThamGiaDoan.trangThai = 1;

                                if (b_dangkynhanvien.ThemDangKy(objThamGiaDoan))
                                {
                                    doandulich objDoan = new doandulich();
                                    objDoan.SoLuongNhanVien = 1;

                                    if (b_doan.ThemSoLuongNhanVienDoan(objDoan, maDoanEdit))
                                    {
                                        System.Diagnostics.Debug.WriteLine("Thêm số lượng bên đoàn du lịch thành công!");
                                    }

                                    RefreshData();
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
                        MessageBox.Show("Nhân viên này đã tham gia vào một đoàn khác! Vui lòng chọn nhân viên khác!", "Thông báo");
                    }
                    
                }
                else
                {
                    MessageBox.Show("Ngày bắt đầu phải NHỎ HƠN ngày kết thúc!", "Thông báo");
                }
            }
            else
            {
                MessageBox.Show("Đoàn này đã đủ số lượng nhân viên! Vui lòng chọn đoàn khác!", "Thông báo");
            }


        }





        public void XoaDangKy()
        {
            if (dataGridViewDangKy.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridViewDangKy.SelectedRows)
                {
                    int maThamGia = Convert.ToInt32(row.Cells[0].Value.ToString());

                    //Giảm số lượng trong đoàn
                    List<thamgiadoan> listThamGiaDoan = b_dangkynhanvien.GetAllDangKy();
                    foreach (var itemDK in listThamGiaDoan)
                    {
                        if (itemDK.maThamGia == maThamGia)
                        {
                            doandulich objDoan = new doandulich();
                            objDoan.SoLuongNhanVien = 1;
                            b_doan.GiamSoLuongNhanVienDoan(objDoan, itemDK.maSoDoan); //giảm 1 nhân viên trong đoàn
                        }
                    }


                    b_dangkynhanvien.XoaDangKy(maThamGia); //Update trangThai = 0

                    LoadDanhSachDangKyTour();
                    RefreshData();
                    MessageBox.Show("Xóa thành công!", "Thông báo");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn đăng ký muốn xóa!", "Thông báo");
            }
        }

        //public void XemChiTiet()
        //{
        //    foreach (DataGridViewRow row in dataGridViewDangKy.SelectedRows)
        //    {
        //        if (!String.Equals(row.Cells[0].Value.ToString(), "System.Windows.Forms.DataGridViewTextBoxColumn"))
        //        {
        //            string id = row.Cells[0].Value.ToString();

        //            fmChiTietDangKy formChiTietDangKy = new fmChiTietDangKy(int.Parse(id), this);
        //            System.Diagnostics.Debug.WriteLine(int.Parse(id));

        //            formChiTietDangKy.ShowDialog();

        //        }

        //    }
        //}




        private void buttonTaoMoi_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("XÁC NHẬN ĐĂNG KÝ?\nLƯU Ý: KHÔNG THỂ SỬA SAU KHI ĐĂNG KÝ", "Thông báo", MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                DangKyTour();
            }

        }

        private void buttonXemChiTiet_Click(object sender, EventArgs e)
        {
            //XemChiTiet();
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
            

            
        }

        private void comboBoxMaTour_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            
        }

        private void textBoxSoLuongKhachHang_TextChanged(object sender, EventArgs e)
        {
 
        }

        private void comboBoxTenDoan_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetInfoChiTietCuaDoan();
        }

        private void buttonThemNhanVien_Click(object sender, EventArgs e)
        {

            fmNhanVien formNhanVien = new fmNhanVien(this);
            formNhanVien.ShowDialog();


        }
        public void TimKiemTheoTenNV()
        {

            if (!String.IsNullOrWhiteSpace(textBoxTimKiem.Text))
            {
                string searchValue = textBoxTimKiem.Text;
                dataGridViewDangKy.DataSource = b_dangkynhanvien.TimKiemTheoTenNV(searchValue);
            }
            else
            {
                LoadDanhSachDangKyTour();
            }

        }
        private void textBoxTimKiem_TextChanged(object sender, EventArgs e)
        {
            TimKiemTheoTenNV();
        }
    }
}
