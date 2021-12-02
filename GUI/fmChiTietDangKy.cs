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
            RefreshData();
        }
        private fmDangKy fmMain;
        public int id { get; set; }

        public void RefreshData()
        {
            LoadDoanTheoTour();
            LoadComboboxMaLoaiKhachHang();
            LoadComboboxMaSoKhachHang();
            LoadComboboxMaTour();
            HienThiChiTietDangKy();
            TinhTongTien();
        }
        private void fmChiTietDangKy_Load(object sender, EventArgs e)
        {
            RefreshData();
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

        public void HienThiChiTietDangKy()
        {
            List<dynamic> listDetailsDangKy = b_dangky.GetListDetailsDangKy(id);

            //Convert List<dynamic> sang Datatable để dễ hiển thị chi tiết 
            var json = JsonConvert.SerializeObject(listDetailsDangKy);
            DataTable dataTableDetailsDangKy = (DataTable)JsonConvert.DeserializeObject(json, (typeof(DataTable)));

            //Hiển thị
            textBoxId.Text = id.ToString();
            //comboBoxMaSoKhachHang.SelectedIndex = comboBoxMaSoKhachHang.FindStringExact(dataTableDetailsDangKy.Rows[0][1].ToString());
            comboBoxMaSoKhachHang.SelectedIndex = comboBoxMaSoKhachHang.FindStringExact(dataTableDetailsDangKy.Rows[0][1].ToString());
            comboBoxMaTour.SelectedIndex = comboBoxMaTour.FindStringExact(dataTableDetailsDangKy.Rows[0][2].ToString());
            comboBoxMaLoaiKhachHang.SelectedIndex = comboBoxMaLoaiKhachHang.FindStringExact(dataTableDetailsDangKy.Rows[0][3].ToString());
            dateTimePickerNgayDangKy.Value = Convert.ToDateTime(dataTableDetailsDangKy.Rows[0][4]);
            comboBox3MaSoDoan.SelectedIndex = comboBox3MaSoDoan.FindStringExact(dataTableDetailsDangKy.Rows[0][5].ToString());
            textBoxSoLuongKhachHang.Text = dataTableDetailsDangKy.Rows[0][6].ToString();
            textBoxGia.Text = dataTableDetailsDangKy.Rows[0][7].ToString();


        }

        private void TinhTongTien()
        {
            int giaTour = 0;
            int soLuongKH = 0;
            if (!String.IsNullOrWhiteSpace(textBoxSoLuongKhachHang.Text) && !String.IsNullOrWhiteSpace(textBoxGia.Text))
            {
                giaTour = Int32.Parse(textBoxGia.Text);
                soLuongKH = Int32.Parse(textBoxSoLuongKhachHang.Text);
                textBoxTongTien.Text = (giaTour * soLuongKH).ToString();
            }
            else
            {
                textBoxTongTien.Text = "";
            }

        }


        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
    
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
            System.Diagnostics.Debug.WriteLine("index khach hang: " +comboBoxMaSoKhachHang.SelectedIndex);
        }

       

        private void comboBoxMaTour_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDoanTheoTour();
        }

        private void comboBoxMaLoaiKhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void textBoxSoLuongKhachHang_TextChanged(object sender, EventArgs e)
        {
            TinhTongTien();
        }

        private void textBoxGia_TextChanged(object sender, EventArgs e)
        {
            TinhTongTien();
        }
    }
}
