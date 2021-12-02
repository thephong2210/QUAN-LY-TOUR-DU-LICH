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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class fmGiaTour : Form
    {
        B_giatour bGiaTour = new B_giatour();

        public fmGiaTour(int maSoTour, fmChiTietTour fmCTTour) // ??
        {
            InitializeComponent();
            fmMain = fmCTTour;
            this.maSoTour = maSoTour;

            HienThiChiTiet();
        }

        private fmChiTietTour fmMain;
        public int maSoTour { get; set; } //Set data sẽ lấy từ form quản lý tour

        // Hiển thị chi tiết 
        private void HienThiChiTiet()
        {
            textBoxMaTour.Text = maSoTour.ToString();

            dataGridViewGiaTour.DataSource = bGiaTour.GetGiaTourWithMaTour(maSoTour);
            dataGridViewGiaTour.AutoGenerateColumns = false;
        }

        public void ThemGiaTour()
        {
            if (!String.IsNullOrWhiteSpace(textBoxGia.Text))
            {
                if (!String.IsNullOrWhiteSpace(textBoxGia.Text))
                {
                    giatour objGiaTour = new giatour();
                    objGiaTour.gia = Convert.ToInt32(textBoxGia.Text);
                    objGiaTour.maGiaTour = maSoTour;
                    objGiaTour.dieuKien = textBoxNoiDungGia.Text;

                    if (bGiaTour.ThemGiaTour(objGiaTour))
                    {
                        fmMain.HienThiChiTietTour();
                        HienThiChiTiet();
                        ClearFields();
                        MessageBox.Show("Thêm thành công!", "Thông báo");
                    }
                    
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập nội dung giá!", "Thông báo");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập giá!", "Thông báo");
            }


        }

        public void ClearFields()
        {
            textBoxGia.Text = "";
            textBoxNoiDungGia.Text = "";
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonDong_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {

        }

        private void textBoxNhiemVu_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ThemGiaTour();
        }
        public void TimKiemGiaTour()
        {

            if (!String.IsNullOrWhiteSpace(textBoxTimKiem.Text))
            {
                string searchValue = textBoxTimKiem.Text;
                dataGridViewGiaTour.DataSource = bGiaTour.TimKiemGiaTour(searchValue);//tim theo dieu kien
            }
            else
            {
                HienThiChiTiet();
            }

        }
        private void textBoxTimKiem_TextChanged(object sender, EventArgs e)
        {
            TimKiemGiaTour();
        }
    }
}
