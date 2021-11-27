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
    public partial class fmChitietDoan : Form
    {
        D_doan d_Doan = new D_doan();
        B_tour bTour = new B_tour();
        B_doan b_Doan = new B_doan();
        public static int madoan;
        public fmChitietDoan(int maDoan, fmQLDoan fmQLD)
        {
            madoan = maDoan;
            InitializeComponent();
            LoadChiTietDoan(maDoan);
            LoadComboBoxTour();


        }
        private void LoadComboBoxTour()
        {
            comboBoxTour.DataSource = bTour.GetListTour();
            comboBoxTour.DisplayMember = "tenGoiTour";
            comboBoxTour.ValueMember = "maSoTour";
        }

        private void LoadChiTietDoan(int madoan)
        {
            var json = JsonConvert.SerializeObject(d_Doan.GetDoan(madoan));
            DataTable dataTableDetailsDoan = (DataTable)JsonConvert.DeserializeObject(json, (typeof(DataTable)));
            textBoxTenDoan.Text = dataTableDetailsDoan.Rows[0][0].ToString();
            comboBoxTour.Text = dataTableDetailsDoan.Rows[0][1].ToString();
            dateTimePickerNgayBatDau.Text = dataTableDetailsDoan.Rows[0][2].ToString();
            dateTimePickerNgayKetThuc.Text = dataTableDetailsDoan.Rows[0][3].ToString();
            textBoxChiTiet.Text = dataTableDetailsDoan.Rows[0][4].ToString();
            _passengerDgv.DataSource = d_Doan.GetKhachHangOfDoan(madoan);
            _employeeDgv.DataSource = d_Doan.GetNhanVienOfDoan(madoan);
        }
        private void SuaDoan()
        {
            b_Doan.SuaDoan(createDoan(), madoan);
            MessageBox.Show("Sửa thành công!", "Thông báo");
        }
        public doandulich createDoan()
        {
            String tenDoan = textBoxTenDoan.Text;
            int maTour = (int)comboBoxTour.SelectedValue;// return ma tour
            DateTime ngayBatDau = DateTime.Parse(dateTimePickerNgayBatDau.Value.Date.ToString("yyyy-MM-dd hh:mm:ss.ss"));
            DateTime ngayKetThuc = DateTime.Parse(dateTimePickerNgayKetThuc.Value.Date.ToString("yyyy-MM-dd hh:mm:ss.ss"));
            String chiTiet = textBoxChiTiet.Text;
            doandulich objDoan = new doandulich();
            objDoan.tenGoiDoan = tenDoan;
            objDoan.maSoTour = maTour;
            objDoan.thoiGianKhoiHanh = ngayBatDau;
            objDoan.thoiGianKetThuc = ngayKetThuc;
            objDoan.soLuongKhachHang = 22;
            objDoan.SoLuongNhanVien = 10;
            objDoan.chiTiet = chiTiet;
            return objDoan;
        }

        private void _customerDetail_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đợi from đăng ký khách hàng", "Thông báo");

        }

        private void _customerDeleteBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đợi from đăng ký khách hàng", "Thông báo");

        }

        private void _employeeDetailBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đợi from tham gia đoàn của nhân viên", "Thông báo");
        }

        private void _employeeDeleteBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đợi from tham gia đoàn của nhân viên", "Thông báo");
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            SuaDoan();
        }
    }
}
