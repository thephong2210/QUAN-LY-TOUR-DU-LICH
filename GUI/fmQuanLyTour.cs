using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class fmQuanLyTour : Form
    {
        
        public fmQuanLyTour()
        {
            InitializeComponent();
            LoadDanhSachTour();



        }

        B_tour b_Tour = new B_tour();

        private void LoadDanhSachTour()
        {

            dataGridViewQuanLyTour.DataSource = b_Tour.GetListTour();

            

        }

        private void dataGridViewQuanLyTour_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
