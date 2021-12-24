using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class fmThongKe : Form
    {
        B_nhanvien bNhanVien = new BUS.B_nhanvien();
        B_doan bDoan = new BUS.B_doan();
        B_tour bTour= new BUS.B_tour();
        B_DangKy bDangKy = new BUS.B_DangKy();

        public fmThongKe()
        {
            InitializeComponent();
            ThongKe();

        }
 
        public void ThongKe()
        {
            labelThongKeNhanVien.Text = bNhanVien.GetListNhanVien().Count.ToString();        
            labelThongKeDoanDuLich.Text = bDoan.GetListDoan().Count.ToString();
            labelThongKeTour.Text = bTour.GetListTour().Count.ToString();

            int tongGiaTourDangKy = (int)(from DangKy in bDangKy.GetAllDangKy() select DangKy.giaTourDangKy).Sum();
            int tongChiPhi = (int)(from ChiPhi in bDangKy.GetAllChiPhi() select ChiPhi.tongChiPhi).Sum();

            labelThongKeDoanhThu.Text = (tongGiaTourDangKy - tongChiPhi).ToString() + " đ";
        }

        private OleDbConnection GetconnectionString()
        {
            throw new NotImplementedException();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void fmThongKe_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelThongKeTour_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
