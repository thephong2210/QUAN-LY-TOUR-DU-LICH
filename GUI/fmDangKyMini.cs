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
    public partial class fmDangKyMini : Form
    {
        B_KH b_khachhang = new B_KH();
        B_tour b_tour = new B_tour();
        B_doan b_doan = new B_doan();
        B_DangKy b_dangky = new B_DangKy();
        B_giatour b_giatour = new B_giatour();

        private int maSoDoanGet { get; set; }
        private int maSoTourGet { get; set; }
        private double giaTourDangKyGet { get; set; }
        private fmChitietDoan fmCTDGet;
        public fmDangKyMini(int maSoDoan, int maSoTour, double giaTourDangKy, fmChitietDoan fmCTD)
        {
            InitializeComponent();
            this.maSoDoanGet = maSoDoan;
            this.maSoTourGet = maSoTour;
            this.giaTourDangKyGet = giaTourDangKy;
            this.fmCTDGet = fmCTD;
            RefreshData();
            
        }

        public void RefreshData()
        {
            LoadComboboxMaSoKhachHang();
            LoadComboboxMaTour();
            LoadGiaTheoTour();
            fmCTDGet.LoadChiTietDoan();
            GetSoLuongConLaiCuaDoan();
        }

        private void fmDangKy_Load(object sender, EventArgs e)
        {
            LoadGiaTheoTour();
            LoadDoanTheoTour();
            LoadNgayDangKyTheoDoan();
            GetSoLuongConLaiCuaDoan();

        }

        public void LoadComboboxMaSoKhachHang()
        {
            comboBoxMaSoKhachHang.DataSource = b_khachhang.GetKhachHang();
            comboBoxMaSoKhachHang.DisplayMember = "hoTenKhachHang";
            comboBoxMaSoKhachHang.ValueMember = "maSoKhachHang";
        }

        public void LoadComboboxMaTour()
        {
            comboBoxMaTour.DataSource = b_tour.GetOneTour(maSoTourGet);
            comboBoxMaTour.DisplayMember = "tenGoiTour";
            comboBoxMaTour.ValueMember = "maSoTour";
        }

        public void LoadNgayDangKyTheoDoan() 
        {
            List<doandulich> listDoanDuLich = b_doan.GetAllDoan();

            //Set maxDate và minDate về mặc định trước khi change để không lỗi
            dateTimePickerNgayDangKy.MaxDate = new DateTime(2500, 12, 20);
            dateTimePickerNgayDangKy.MinDate = new DateTime(1753, 1, 1);

            foreach (var itemmaSoDoan in listDoanDuLich)
            {
                if (itemmaSoDoan.maSoDoan.Equals(comboBox3MaSoDoan.SelectedValue))
                {
                    dateTimePickerNgayDangKy.MaxDate = itemmaSoDoan.thoiGianKetThuc;
                    dateTimePickerNgayDangKy.MinDate = itemmaSoDoan.thoiGianKhoiHanh;
                    

                }
            }
        }

        public void DangKyTour()
        {
           
            int maDoanEdit = 0;
           
            try
            {
                if (CheckSoLuongToiDaDoan(comboBox3MaSoDoan.Text))
                {
                    if (!String.IsNullOrWhiteSpace(comboBox3MaSoDoan.Text))
                    {
                        try
                        {
                            dangky objDangKy = new dangky();
                            doandulich objDoan = new doandulich();
                            tour objTour = new tour();

                            
                            objDangKy.maSoKhachHang = Convert.ToInt32(comboBoxMaSoKhachHang.SelectedValue);
                            objDangKy.maTour = this.maSoTourGet;
                            objDangKy.giaTourDangKy = this.giaTourDangKyGet;

                            objDangKy.ngayDangKy = DateTime.Parse(dateTimePickerNgayDangKy.Value.Date.ToString("yyyy-MM-dd hh:mm:ss.ss"));
                            objDangKy.maSoDoan = this.maSoDoanGet;
                            maDoanEdit = this.maSoDoanGet;

                            objDangKy.soLuongKhachHang = 1;
                            objDoan.soLuongKhachHang = 1;
                            
                            objDangKy.trangThai = 1;

                            if (b_dangky.ThemDangKy(objDangKy))
                            {
                                if (b_doan.ThemSoLuongKhachHangDoan(objDoan, maDoanEdit))
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
                    MessageBox.Show("Số lượng khách hàng VƯỢT QUÁ số lượng còn lại của đoàn!", "Thông báo");
                }
            }
            catch (FormatException fmex)
            {
                MessageBox.Show("Số lượng phải là số!", "Thông báo");
                System.Diagnostics.Debug.WriteLine(fmex);
            }

        }

        public bool CheckSoLuongToiDaDoan(string comboBoxDoanString) //check soLuongKhachHang cua doan <= 45
        {
            List<doandulich> listDoanDuLich = b_doan.GetAllDoan();
            int soLuongKHDangKy = 1;

            foreach (var itemmaSoDoan in listDoanDuLich)
            {
                if (itemmaSoDoan.tenGoiDoan.Equals(comboBoxDoanString))
                {
                    if ((itemmaSoDoan.soLuongKhachHang + soLuongKHDangKy) <= 45) return true;
                }
            }
            return false;

        }

        
        public void LoadDoanTheoTour()
        {
            
            comboBox3MaSoDoan.DataSource = b_doan.GetOneDoan(maSoDoanGet);
            comboBox3MaSoDoan.DisplayMember = "tenGoiDoan";
            comboBox3MaSoDoan.ValueMember = "maSoDoan";

        }

        public void GetSoLuongConLaiCuaDoan()
        {
            List<doandulich> listDoanDuLich = b_doan.GetAllDoan();
            if (!String.IsNullOrEmpty(comboBox3MaSoDoan.Text))
            {
                foreach (var itemmaSoDoan in listDoanDuLich)
                {

                    if (itemmaSoDoan.maSoDoan.Equals(comboBox3MaSoDoan.SelectedValue))
                    {
                        labelSoLuongConLai.Text = (45 - Convert.ToInt32(itemmaSoDoan.soLuongKhachHang)).ToString();
                    }


                }
            }
            else
            {
                labelSoLuongConLai.Text = "0";
            }
            
        }

        public void LoadGiaTheoTour()
        {
            List<tour> listTour = b_tour.GetAllTour();
            List<giatour> listGiaTour = b_giatour.GetGiaTour();

            foreach (var itemmaTour in listTour)
            {
                
                    if (itemmaTour.maSoTour.Equals(comboBoxMaTour.SelectedValue))
                    {
                        foreach (var itemGiaTour in listGiaTour)
                        {
                            if (itemGiaTour.id.Equals(itemmaTour.idGiaTour))
                            {
                                textBoxGiaTour.Text = itemGiaTour.gia.ToString();
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

        
        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxMaLoaiKhachHang_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        
        private void comboBoxMaTour_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadGiaTheoTour();
            LoadDoanTheoTour();
            GetSoLuongConLaiCuaDoan();
        }
        
      
        private void textBoxSoLuongKhachHang_TextChanged(object sender, EventArgs e)
        {
      
        }

     

        private void textBoxGiaTour_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textBoxGiaTour.Text = string.Format("{0:#,##0}", double.Parse(textBoxGiaTour.Text));
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Vui lòng chỉ nhập số vào ô giá!", "Thông báo");
                System.Diagnostics.Debug.WriteLine(ex);
            }

        }

        private void buttonThemKhachHang_Click(object sender, EventArgs e)
        {
            fmThemKhachHang fmKH = new fmThemKhachHang(this);
            fmKH.ShowDialog();
        }

        
        private void comboBox3MaSoDoan_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadGiaTheoTour();
            GetSoLuongConLaiCuaDoan();
            LoadNgayDangKyTheoDoan();
        }

        private void dateTimePickerNgayDangKy_ValueChanged(object sender, EventArgs e)
        {
            LoadNgayDangKyTheoDoan();
        }
    }
}
