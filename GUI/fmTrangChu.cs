using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class fmTrangChu : Form
    {
        public fmTrangChu()
        {
            InitializeComponent();
        }

        private void fmTrangChu_Load(object sender, EventArgs e)
        {
            labelTime.Text = DateTime.Now.ToLongTimeString();

            labelDate.Text = DateTime.Now.ToString("d");
        }

        public void HienThiFormCon(Form formName)
        {
            this.Hide();
            formName.ShowDialog();
            this.Show();
        }

        private void btnTour_Click(object sender, EventArgs e)
        {
            fmQuanLyTour fmQLT = new fmQuanLyTour();
            HienThiFormCon(fmQLT);
        }

        private void btnDoanDuLich_Click(object sender, EventArgs e)
        {
            fmQLDoan fmQLD = new fmQLDoan();
            HienThiFormCon(fmQLD);
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            fmNhanVien fmNV = new fmNhanVien();
            HienThiFormCon(fmNV);
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            fmKhachHang fmKH = new fmKhachHang();
            HienThiFormCon(fmKH);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void labelTime_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelTime.Text = DateTime.Now.ToLongTimeString();

            timer1.Start();
        }

        private void labelDate_Click(object sender, EventArgs e)
        {

        }

        private void fmTrangChu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát chương trình không?","Thông báo" ,MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            fmLoaiHinhDuLich fmLHDL = new fmLoaiHinhDuLich();
            HienThiFormCon(fmLHDL);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            fmQuanLyDiaDiem fmQLDD = new fmQuanLyDiaDiem();
            HienThiFormCon(fmQLDD);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            fmDangKy fmDangKyKhachHang = new fmDangKy();
            HienThiFormCon(fmDangKyKhachHang);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            fmLoaiChiPhi fmLoaiChiPhi = new fmLoaiChiPhi();
            HienThiFormCon(fmLoaiChiPhi);
        }
    }
}
