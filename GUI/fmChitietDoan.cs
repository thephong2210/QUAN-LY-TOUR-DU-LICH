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
        B_chiphi b_chiphi = new B_chiphi();
        D_giatour DGiaTour = new D_giatour();
        D_DangKy d_dangky = new D_DangKy();

        public static int madoan;
        public fmQLDoan fmMain;
        public fmChitietDoan(int maDoan, fmQLDoan fmQLD)
        {
            madoan = maDoan;
            fmMain = fmQLD;
            InitializeComponent();
            LoadChiTietDoan();
            LoadComboBoxTour();

            
        }
        private void LoadComboBoxTour()
        {
            comboBoxTour.DataSource = bTour.GetListTour();
            comboBoxTour.DisplayMember = "tenGoiTour";
            comboBoxTour.ValueMember = "maSoTour";
        }

        public void LoadChiTietDoan()
        {
           
            List<chiphi> listChiPhi = b_chiphi.GetListLoaiChiPhi();
            double tongChiPhi = 0;

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

            foreach (var item in listChiPhi)
            {
                if (item.maSoDoan == madoan)
                {
                    tongChiPhi += item.tongChiPhi;
                }
            }

            textBoxTongChiPhi.Text = tongChiPhi.ToString();

            _passengerDgv.DataSource = d_Doan.GetKhachHangOfDoan(madoan);
            _employeeDgv.DataSource = d_Doan.GetNhanVienOfDoan(madoan);
            _passengerDgv.Columns["gia"].DefaultCellStyle.Format = "N2";
            

            _passengerDgv.AutoGenerateColumns = false;
            _employeeDgv.AutoGenerateColumns = false;

            LoadDoanhThuDoan();

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

        public void LoadDoanhThuDoan()
        {
            var listTotalGiaVeAllDoan = d_dangky.GetDoanhSoDangKyOneDoan(madoan);
            var listChiPhiAllDoan = d_dangky.GetChiPhiOneDoan_Doan(madoan);

            foreach (var itemGiaVe in listTotalGiaVeAllDoan)
            {
                double calcDoanhThu = 0;
                //var calcGiaVe = 0;
                foreach (var itemChiPhi in listChiPhiAllDoan)
                {
                    if (itemGiaVe.maSoDoan == madoan)
                    {
                        if (itemGiaVe.maSoDoan == itemChiPhi.maSoDoan)
                        {
                            calcDoanhThu = itemGiaVe.totalGiaVe - itemChiPhi.totalChiPhi;
                        }

                    }

                }

                if (calcDoanhThu != 0)
                {
                    textBoxTongDoanhThu.Text = String.Format("{0:n0}", calcDoanhThu);
                 
                }


            }


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
            LoadChiTietDoan();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            fmChiTietChiPhi fmChiTietChiPhi = new fmChiTietChiPhi(madoan, this);
            fmChiTietChiPhi.ShowDialog();

           
        }

        private void buttonThemDKKH_Click(object sender, EventArgs e)
        {
            int maSoTour = Convert.ToInt32(comboBoxTour.SelectedValue);
            double giaTourHienTai = 0;
            List<tour> listTour = bTour.GetOneTour(maSoTour);
            List<giatour> listGiaTour = DGiaTour.GetGiaTourWithMaTour(maSoTour);

            foreach (var item in listGiaTour)
            {
                if (listTour[0].idGiaTour.Equals(item.id))
                {
                    giaTourHienTai = item.gia;
                }   
            } 
            
            fmDangKyMini fmDKmini = new fmDangKyMini(madoan, maSoTour, giaTourHienTai, this);
            fmDKmini.ShowDialog();
        }

        private void buttonThemDKNV_Click(object sender, EventArgs e)
        {
            fmDangKyNhanVienMini fmDKmini = new fmDangKyNhanVienMini(madoan, this);
            fmDKmini.ShowDialog();
        }

        private void textBoxTongChiPhi_Leave(object sender, EventArgs e)
        {
            try
            {
                textBoxTongChiPhi.Text = string.Format("{0:#,##0}", double.Parse(textBoxTongChiPhi.Text));
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Vui lòng chỉ nhập số!", "Thông báo");
                System.Diagnostics.Debug.WriteLine(ex);
            }

        }

        private void textBoxTongChiPhi_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textBoxTongChiPhi.Text = string.Format("{0:#,##0}", double.Parse(textBoxTongChiPhi.Text));
                LoadDoanhThuDoan();
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Vui lòng chỉ nhập số!", "Thông báo");
                System.Diagnostics.Debug.WriteLine(ex);
            }
        }
    }
}
