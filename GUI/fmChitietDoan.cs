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
        public fmQLDoan fmMain;
        public fmChitietDoan(int maDoan, fmQLDoan fmQLD)
        {
            madoan = maDoan;
            fmMain = fmQLD;
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
            comboBoxTour.SelectedIndex = comboBoxTour.FindString(dataTableDetailsDoan.Rows[0][1].ToString());
            dateTimePickerNgayBatDau.Text = dataTableDetailsDoan.Rows[0][2].ToString();
            dateTimePickerNgayKetThuc.Text = dataTableDetailsDoan.Rows[0][3].ToString();
            textBoxChiTiet.Text = dataTableDetailsDoan.Rows[0][4].ToString();
            textBoxTongSLKH.Text = dataTableDetailsDoan.Rows[0][5].ToString();
            textBoxSLNV.Text = dataTableDetailsDoan.Rows[0][6].ToString();
            textBoxMaSoDoan.Text = dataTableDetailsDoan.Rows[0][7].ToString();

            _passengerDgv.DataSource = d_Doan.GetKhachHangOfDoan(madoan);
            _employeeDgv.DataSource = d_Doan.GetNhanVienOfDoan(madoan);
        }
        private void SuaDoan()
        {
            b_Doan.SuaDoan(createDoan(), madoan);
            fmMain.LoadDanhSachDoan();
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
            objDoan.chiTiet = chiTiet;
            objDoan.trangThai = 1;
            return objDoan;
        }

        private void _customerDetail_Click(object sender, EventArgs e)
        {
          

        }

        private void _customerDeleteBtn_Click(object sender, EventArgs e)
        {
           

        }

        private void _employeeDetailBtn_Click(object sender, EventArgs e)
        {
  
        }

        private void _employeeDeleteBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            SuaDoan();
        }

        private void textBoxTongSLKH_TextChanged(object sender, EventArgs e)
        {

        }

        private void fmChitietDoan_Load(object sender, EventArgs e)
        {
            LoadChiTietDoan(madoan);
        }
    }
}
