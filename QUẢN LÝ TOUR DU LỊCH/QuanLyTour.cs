using System;
using System.Windows.Forms;
using BUS;

namespace QUẢN_LÝ_TOUR_DU_LỊCH
{
    public partial class QuanLyTour : Form
    {
        B_tour b_Tour = new B_tour();
        
        public QuanLyTour()
        {
            InitializeComponent();
        }
        private void QuanLyTour_Load(object sender, EventArgs e) 
        {
            dataGridViewQuanLyTour.DataSource = b_Tour.GetListTour();


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

      

        private void dataGridViewQuanLyTour_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
