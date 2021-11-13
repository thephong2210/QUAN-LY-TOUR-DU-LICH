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
using System;


namespace GUI
{
    public partial class fmQLDoan : Form
    {
        B_doan b_Doan = new B_doan();
        B_tour bTour = new B_tour();
        D_doan d_Doan = new D_doan();
        public fmQLDoan()
        {
            InitializeComponent();
            LoadDanhSachDoan();
            LoadComboBoxTour();
        }


        #region method

        private void LoadDanhSachDoan()
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
            objDoan.soLuongKhachHang = 22;
            objDoan.SoLuongNhanVien = 10;
            objDoan.chiTiet = chiTiet;
            return objDoan;
        }

        public void ThemDoan()
        {
            b_Doan.ThemDoan(createDoan());
            LoadDanhSachDoan();
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
                MessageBox.Show("Vui lòng chọn tour muốn xóa!", "Thông báo");
            }
        }
        private void SuaDoan()
        {

            if (dataGridViewQuanLyDoan.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridViewQuanLyDoan.SelectedRows)
                {
                    int maSoDoan = Convert.ToInt32(row.Cells[0].Value.ToString());
                    b_Doan.SuaDoan(createDoan(), maSoDoan);
                    LoadDanhSachDoan();
                    MessageBox.Show("Sửa thành công!", "Thông báo");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn tour muốn Sửa!", "Thông báo");
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
            XoaDoan();
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            SuaDoan();
        }

        private void buttonXemChiTiet_Click(object sender, EventArgs e)
        {
            XemChiTietDoan();
        }

        private void dataGridViewQuanLyDoan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (textBoxTenDoan.DataBindings.Count > 0)
                textBoxTenDoan.DataBindings.RemoveAt(0);

            textBoxTenDoan.DataBindings.Add(
                new Binding("Text", dataGridViewQuanLyDoan[1, e.RowIndex], "Value", true));
            if (comboBoxTour.DataBindings.Count > 0)
                comboBoxTour.DataBindings.RemoveAt(0);

            comboBoxTour.DataBindings.Add(
                new Binding("Text", dataGridViewQuanLyDoan[2, e.RowIndex], "Value", true));
            if (dateTimePickerNgayBatDau.DataBindings.Count > 0)
                dateTimePickerNgayBatDau.DataBindings.RemoveAt(0);

            dateTimePickerNgayBatDau.DataBindings.Add(
                new Binding("Text", dataGridViewQuanLyDoan[3, e.RowIndex], "Value", true));
            if (dateTimePickerNgayKetThuc.DataBindings.Count > 0)
                dateTimePickerNgayKetThuc.DataBindings.RemoveAt(0);

            dateTimePickerNgayKetThuc.DataBindings.Add(
                new Binding("Text", dataGridViewQuanLyDoan[4, e.RowIndex], "Value", true));
            if (textBoxChiTiet.DataBindings.Count > 0)
                textBoxChiTiet.DataBindings.RemoveAt(0);

            textBoxChiTiet.DataBindings.Add(
                new Binding("Text", dataGridViewQuanLyDoan[5, e.RowIndex], "Value", true));
        }

        private void buttonTaoMoi_Click(object sender, EventArgs e)
        {
            ThemDoan();
        }
    }
    #endregion event
}
