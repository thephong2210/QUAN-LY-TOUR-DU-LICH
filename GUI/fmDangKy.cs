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
    public partial class fmDangKy : Form
    {
        B_KH b_khachhang = new B_KH();
        B_LoaiKH b_loaikhachhang = new B_LoaiKH();
        B_tour b_tour = new B_tour();
        B_doan b_doan = new B_doan();
        B_DangKy b_dangky = new B_DangKy();
        public fmDangKy()
        {
            InitializeComponent();
           
            LoadComboboxMaDoan();
            LoadComboboxMaLoaiKhachHang();
            LoadComboboxMaSoKhachHang();
            LoadComboboxMaTour();
            LoadDanhSachDangKyTour();
        }

        public void LoadDanhSachDangKyTour()
        {
            dataGridViewDangKy.DataSource = b_dangky.GetAllDangKy();
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

        public void LoadComboboxMaDoan()
        {
            comboBox3MaSoDoan.DataSource = b_doan.GetAllDoan();
            comboBox3MaSoDoan.DisplayMember = "tenGoiDoan";
        }

        public void DangKyTour()
        {
            List<khachhang> listKhachHang = b_khachhang.GetKhachHang();
            List<loaikhachhang> listLoaiKhachHang = b_loaikhachhang.GetLoaikhachhangs();
            List<doandulich> listDoanDuLich = b_doan.GetAllDoan();
            List<tour> listTour = b_tour.GetAllTour();


            try
            {
                dangky objDangKy = new dangky();
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
                    }
                }

                foreach (var itemmaLoaiKhachHang in listLoaiKhachHang)
                {
                    if (itemmaLoaiKhachHang.tenLoaiKhachHang.Equals(comboBoxMaLoaiKhachHang.Text))
                    {
                        objDangKy.maLoaiKhachHang = itemmaLoaiKhachHang.maLoaiKhachHang;
                    }
                }
                objDangKy.ngayDangKy = DateTime.Parse(dateTimePickerNgayDangKy.Value.Date.ToString("yyyy-MM-dd hh:mm:ss.ss"));

                foreach (var itemmaSoDoan in listDoanDuLich)
                {
                    if (itemmaSoDoan.tenGoiDoan.Equals(comboBox3MaSoDoan.Text))
                    {
                        objDangKy.maSoDoan = itemmaSoDoan.maSoDoan;
                    }
                }

                if (b_dangky.ThemDangKy(objDangKy))
                {
                    System.Diagnostics.Debug.WriteLine("Thêm đăng ký thành công!");
                    LoadDanhSachDangKyTour();
                    MessageBox.Show("Thêm đăng ký thành công!", "Thông báo");
                    LoadDanhSachDangKyTour();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Thêm không thành công!", "Thông báo");
                System.Diagnostics.Debug.WriteLine(e);
            }



        }

        public void XoaDangKy()
        {
            if (dataGridViewDangKy.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridViewDangKy.SelectedRows)
                {
                    int id = Convert.ToInt32(row.Cells[0].Value.ToString());
                    b_dangky.XoaDangKy(id);
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
        private void fmDangKy_Load(object sender, EventArgs e)
        {

        }

        private void buttonTaoMoi_Click(object sender, EventArgs e)
        {
            DangKyTour();
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
    }
}
