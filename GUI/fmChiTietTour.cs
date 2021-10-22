using BUS;
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
    public partial class fmChiTietTour : Form
    {
        B_tour b_tour = new B_tour();

        public fmChiTietTour(int maSoTour)
        {
            InitializeComponent();

            this.maSoTour = maSoTour;
            LoadComboboxDiaDiem();
            LoadComboboxLoaiHinhDuLich();

            HienThiChiTietTour();

        }

        public int maSoTour { get; set; } //Set data sẽ lấy từ form quản lý tour

        private void HienThiChiTietTour()
        {
           
            textBoxMaSoTour.Text = maSoTour.ToString();
            textBoxTenGoiTour.Text = b_tour.GetListDetailsTour(maSoTour).Rows[0][0].ToString();
            textBoxDacDiem.Text = b_tour.GetListDetailsTour(maSoTour).Rows[0][1].ToString();

            comboBoxDiaDiem.SelectedIndex = comboBoxDiaDiem.FindString(b_tour.GetListDetailsTour(maSoTour).Rows[0][3].ToString()); 
            comboBoxLoaiHinhDuLich.SelectedIndex = comboBoxLoaiHinhDuLich.FindString(b_tour.GetListDetailsTour(maSoTour).Rows[0][2].ToString());

            textBoxGia.Text = b_tour.GetListDetailsTour(maSoTour).Rows[0][4].ToString();
            textBoxSoLuongKhachHang.Text = b_tour.GetListDetailsTour(maSoTour).Rows[0][5].ToString();
            textBoxTongTien.Text = b_tour.GetListDetailsTour(maSoTour).Rows[0][6].ToString();

            //Chưa xử lý giá, thời gian bắt đầu, thời gian kết thúc
            //dateTimePickerThoiGianBatDau.Value = b_tour.GetListDetailsTour(maSoTour).Rows[0][7].ToString();

        }

        private void LoadComboboxDiaDiem()
        {
            comboBoxDiaDiem.DataSource = b_tour.GetListDiaDiem().Tables[0];
            comboBoxDiaDiem.DisplayMember = "tenDiaDiem";
        }

        private void LoadComboboxLoaiHinhDuLich()
        {
            comboBoxLoaiHinhDuLich.DataSource = b_tour.GetListLoaiHinhDuLich().Tables[0];
            comboBoxLoaiHinhDuLich.DisplayMember = "tenLoaiHinhDuLich";
        }



        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void buttonDong_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }
    }
}
