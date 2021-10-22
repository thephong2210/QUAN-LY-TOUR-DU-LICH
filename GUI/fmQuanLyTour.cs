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
    }
}
