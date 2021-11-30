using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
        TextBox textBox11 = new TextBox();
        TextBox textBox2 = new TextBox();
        public fmQLDoan()
        {
            InitializeComponent();
            LoadDanhSachDoan();
            LoadComboBoxTour();
        }


        #region method

        public void LoadDanhSachDoan()
        {
            dataGridViewQuanLyDoan.DataSource = b_Doan.GetListDoan();

        }
        private void LoadComboBoxTour()
        {
            comboBoxTour.DataSource = bTour.GetListTour();
            comboBoxTour.DisplayMember = "tenGoiTour";
            comboBoxTour.ValueMember = "maSoTour";
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
            b_Doan.ThemDoan(createDoan());
            LoadDanhSachDoan();
            MessageBox.Show("Thêm thành công!", "Thông báo");
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
                //_tourGroupNameLb.Text = row.Cells[1].Value.ToString();
                //_tourNameLb.Text = row.Cells[2].Value.ToString();
                //_departDateLb.Text = row.Cells[3].Value.ToString();
                //_returnDateLb.Text = row.Cells[4].Value.ToString();

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
            //if (textBoxTenDoan.DataBindings.Count > 0)
            //    textBoxTenDoan.DataBindings.RemoveAt(0);

            //textBoxTenDoan.DataBindings.Add(
            //    new Binding("Text", dataGridViewQuanLyDoan[1, e.RowIndex], "Value", true));
            //if (comboBoxTour.DataBindings.Count > 0)
            //    comboBoxTour.DataBindings.RemoveAt(0);

            //comboBoxTour.DataBindings.Add(
            //    new Binding("Text", dataGridViewQuanLyDoan[2, e.RowIndex], "Value", true));
            //if (dateTimePickerNgayBatDau.DataBindings.Count > 0)
            //    dateTimePickerNgayBatDau.DataBindings.RemoveAt(0);

            //dateTimePickerNgayBatDau.DataBindings.Add(
            //    new Binding("Text", dataGridViewQuanLyDoan[3, e.RowIndex], "Value", true));
            //if (dateTimePickerNgayKetThuc.DataBindings.Count > 0)
            //    dateTimePickerNgayKetThuc.DataBindings.RemoveAt(0);

            //dateTimePickerNgayKetThuc.DataBindings.Add(
            //    new Binding("Text", dataGridViewQuanLyDoan[4, e.RowIndex], "Value", true));
            //if (textBoxChiTiet.DataBindings.Count > 0)
            //    textBoxChiTiet.DataBindings.RemoveAt(0);

            //textBoxChiTiet.DataBindings.Add(
            //    new Binding("Text", dataGridViewQuanLyDoan[5, e.RowIndex], "Value", true));
            //buttonLamMoi.Enabled = true;
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

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void textBoxTenDoan_TextChanged(object sender, EventArgs e)
        {

        }
    }
    #endregion event
}
