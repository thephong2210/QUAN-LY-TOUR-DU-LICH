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
using BUS;
using DAO;


namespace GUI
{
    public partial class fmQLDoan : Form
    {
        B_doan b_Doan = new B_doan();
        B_tour bTour = new B_tour();
        D_doan d_Doan = new D_doan();
        B_chiphi b_chiphi = new B_chiphi();


        public fmQLDoan()
        {
            InitializeComponent();
            LoadDanhSachDoan();
            LoadComboBoxTour();
            LoadNgayBatDauNgayKetThucTour();
        }


        #region method

        public void LoadDanhSachDoan()
        {
            dataGridViewQuanLyDoan.DataSource = b_Doan.GetListDoan();
            dataGridViewQuanLyDoan.AutoGenerateColumns = false;

        }
        private void LoadComboBoxTour()
        {
            comboBoxTour.DataSource = bTour.GetListTour();
            comboBoxTour.DisplayMember = "tenGoiTour";
            comboBoxTour.ValueMember = "maSoTour";
        }

        public void LoadNgayBatDauNgayKetThucTour()
        {
            List<tour> listTour = bTour.GetAllTour();

            //Set maxDate và minDate về mặc định trước khi change để không lỗi
            dateTimePickerNgayBatDau.MaxDate = new DateTime(2500, 12, 20);
            dateTimePickerNgayBatDau.MinDate = new DateTime(1753, 1, 1);
            dateTimePickerNgayKetThuc.MaxDate = new DateTime(2500, 12, 20);
            dateTimePickerNgayKetThuc.MinDate = new DateTime(1753, 1, 1);

            foreach (var items in listTour)
            {
                if (items.tenGoiTour.Equals(comboBoxTour.Text))
                {
                    dateTimePickerNgayBatDau.MinDate = Convert.ToDateTime(items.thoiGianBatDau);
                    dateTimePickerNgayBatDau.MaxDate = Convert.ToDateTime(items.thoiGianKetThuc);

                    dateTimePickerNgayKetThuc.MaxDate = Convert.ToDateTime(items.thoiGianKetThuc);
                    dateTimePickerNgayKetThuc.MinDate = Convert.ToDateTime(items.thoiGianBatDau);
                }
            }
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
            objDoan.soLuongKhachHang = 0;
            objDoan.SoLuongNhanVien = 0;
            objDoan.chiTiet = chiTiet;
            objDoan.trangThai = 1;
            return objDoan;
        }

        public void ThemDoan()
        {
            if (!String.IsNullOrWhiteSpace(textBoxTenDoan.Text))
            {
                if (CheckThoiGianDangKy())
                {
                    if (b_Doan.ThemDoan(createDoan()))
                    {
                        LoadDanhSachDoan();
                        ClearFields();
                        MessageBox.Show("Thêm thành công!", "Thông báo");
                    }
                    else
                    {
                        MessageBox.Show("Thêm KHÔNG thành công!", "Thông báo");
                    }
                    
                }
                else
                {
                    MessageBox.Show("Ngày bắt đầu phải NHỎ HƠN ngày kết thúc!", "Thông báo");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập tên đoàn!", "Thông báo");
                textBoxTenDoan.Focus();
            }

        }

        public void ClearFields()
        {
            textBoxTenDoan.Text = "";
            textBoxChiTiet.Text = "";
        }

        public bool CheckThoiGianDangKy() //ngày bắt đầu < ngày kết thúc
        {   
            if (dateTimePickerNgayBatDau.Value <= dateTimePickerNgayKetThuc.Value)
            {
                return true;
            }
            return false;

        }

        public void XoaDoan()
        {


            if (dataGridViewQuanLyDoan.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridViewQuanLyDoan.SelectedRows)
                {
                    int maSoDoan = Convert.ToInt32(row.Cells[0].Value.ToString());
                    b_Doan.XoaDoan(maSoDoan);
                    LoadDanhSachDoan();
                    MessageBox.Show("Xóa thành công!", "Thông báo");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn đoàn muốn xóa!", "Thông báo");
            }
        }
        
        void XemChiTietDoan()
        {
            foreach (DataGridViewRow row in dataGridViewQuanLyDoan.SelectedRows)
            {
                String maDoan = row.Cells[0].Value.ToString();

                fmChitietDoan fmChitietDoan = new fmChitietDoan(int.Parse(maDoan), this);
                fmChitietDoan.ShowDialog();

            }
        }
        #endregion method
        #region event


        private void buttonXoa_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Bạn có chắc muốn xóa không ?? :D", "Thông báo", MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                XoaDoan();
            }
           
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            LoadDanhSachDoan();
        }

        private void buttonXemChiTiet_Click(object sender, EventArgs e)
        {
            XemChiTietDoan();
        }

        private void dataGridViewQuanLyDoan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void buttonTaoMoi_Click(object sender, EventArgs e)
        {
            ThemDoan();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBoxTenDoan_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
          
        }
        

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxTour_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadNgayBatDauNgayKetThucTour();
        }

        private void fmQLDoan_Load(object sender, EventArgs e)
        {
            LoadNgayBatDauNgayKetThucTour();
        }

        public void TimKiemTenDoan()
        {

            if (!String.IsNullOrWhiteSpace(textBoxTimKiem.Text))
            {
                string searchValue = textBoxTimKiem.Text;
                dataGridViewQuanLyDoan.DataSource = b_Doan.TimKiemTenDoan(searchValue);
            }
            else
            {
                LoadDanhSachDoan();
            }

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            TimKiemTenDoan();
        }
    }
    #endregion event
}
