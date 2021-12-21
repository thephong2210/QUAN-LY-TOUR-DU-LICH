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

        public fmThongKe()
        {
            InitializeComponent();
            LoadDataGridView();
            ThongKe();

        }
        public void LoadDataGridView()
        {
            dataGridViewNhanVien.DataSource = bNhanVien.GetListNhanVien(); // datagridview đã set kích thước (0,0)
            dataGridViewNhanVien.AutoGenerateColumns = false;


            dataGridViewQuanLyDoan.DataSource = bDoan.GetListDoan(); // datagridview đã set visible = false
            dataGridViewQuanLyDoan.AutoGenerateColumns = false;

            dataGridViewQuanLyTour.DataSource = bTour.GetListTour();
            dataGridViewQuanLyTour.AutoGenerateColumns = false;

        }

        public void ThongKe()
        {
            string soLuongNhanVien = dataGridViewNhanVien.Rows.Count.ToString();
            labelThongKeNhanVien.Text = soLuongNhanVien.ToString();

            string soLuongDoan = dataGridViewQuanLyDoan.Rows.Count.ToString();
            labelThongKeDoanDuLich.Text = soLuongDoan.ToString();

            string soLuongTour = dataGridViewQuanLyTour.Rows.Count.ToString();
            labelThongKeTour.Text = soLuongTour.ToString();
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
