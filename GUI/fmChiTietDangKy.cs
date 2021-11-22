using BUS;
using DAO;
using Newtonsoft.Json;
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
    public partial class fmChiTietDangKy : Form
    {
        B_KH b_khachhang = new B_KH();
        B_LoaiKH b_loaikhachhang = new B_LoaiKH();
        B_tour b_tour = new B_tour();
        B_doan b_doan = new B_doan();
        B_DangKy b_dangky = new B_DangKy();
        public fmChiTietDangKy(int id, fmDangKy fmDK)
        {
            InitializeComponent();
            fmMain = fmDK;
            this.id = id;
            HienThiChiTietDangKy();
            LoadComboboxMaDoan();
            LoadComboboxMaLoaiKhachHang();
            LoadComboboxMaSoKhachHang();
            LoadComboboxMaTour();

            
        }
        private fmDangKy fmMain;
        public int id { get; set; }

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
        public void HienThiChiTietDangKy()
        {
            List<dynamic> listDetailsDangKy = b_dangky.GetListDetailsDangKy(id);

            //Convert List<dynamic> sang Datatable để dễ hiển thị chi tiết 
            var json = JsonConvert.SerializeObject(listDetailsDangKy);
            DataTable dataTableDetailsDangKy = (DataTable)JsonConvert.DeserializeObject(json, (typeof(DataTable)));

            //Hiển thị
            textBoxId.Text = id.ToString();
            comboBoxMaSoKhachHang.SelectedIndex = comboBoxMaSoKhachHang.FindString(dataTableDetailsDangKy.Rows[0][1].ToString());
            comboBoxMaTour.SelectedIndex = comboBoxMaTour.FindString(dataTableDetailsDangKy.Rows[0][2].ToString());
            comboBoxMaLoaiKhachHang.SelectedIndex = comboBoxMaLoaiKhachHang.FindString(dataTableDetailsDangKy.Rows[0][3].ToString());
            dateTimePickerNgayDangKy.Value = Convert.ToDateTime(dataTableDetailsDangKy.Rows[0][4]);
            comboBox3MaSoDoan.SelectedIndex = comboBox3MaSoDoan.FindString(dataTableDetailsDangKy.Rows[0][5].ToString());
            
        }
        



        public void SuaDangKy()
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

                if (b_dangky.SuaDangKy(objDangKy,id))
                {
                    System.Diagnostics.Debug.WriteLine("Sửa đăng ký thành công!");
                    fmMain.LoadDanhSachDangKyTour();
                    MessageBox.Show("Sửa đăng ký thành công!", "Thông báo");
                    
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Sửa không thành công!", "Thông báo");
                System.Diagnostics.Debug.WriteLine(e);
            }

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            SuaDangKy();
        }

        private void buttonDong_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void textBoxId_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxMaSoKhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
