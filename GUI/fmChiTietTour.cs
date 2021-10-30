using BUS;
using DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class fmChiTietTour : Form
    {
        B_tour bTour = new B_tour();
        B_diadiemden bDiaDiemDen = new B_diadiemden();
        B_loaihinhdulich bLoaiHinhDuLich = new B_loaihinhdulich();

        public fmChiTietTour(int maSoTour)
        {
            InitializeComponent();

            this.maSoTour = maSoTour;
            LoadComboboxDiaDiem();
            LoadComboboxLoaiHinhDuLich();

            HienThiChiTietTour();

        }

        public void LoadComboboxDiaDiem()
        {
            comboBoxDiaDiem.DataSource = bDiaDiemDen.GetListDiaDiemDen();
            comboBoxDiaDiem.DisplayMember = "tenDiaDiemDen";
        }

        public void LoadComboboxLoaiHinhDuLich()
        {
            comboBoxLoaiHinhDuLich.DataSource = bLoaiHinhDuLich.GetListLoaiHinhDL();
            comboBoxLoaiHinhDuLich.DisplayMember = "tenLoaiHinhDuLich";
        }

        public int maSoTour { get; set; } //Set data sẽ lấy từ form quản lý tour

        private void HienThiChiTietTour()
        {
            List<dynamic> listDetailsTour = bTour.GetListDetailsTour(maSoTour);
            
            dataGridView1.DataSource = listDetailsTour;

            textBoxMaSoTour.Text = maSoTour.ToString();
            // textBoxTenGoiTour.Text =
            //  dynamic d = new { Property1 = "Value1", Property2 = "Value2" };

            //Type type = data.GetType().GetGenericArguments()[0];
            //PropertyInfo property = type.GetProperty("tenGoiTour");

            //object value = listDetailsTour.GetType().GetProperty("maSoTour").GetValue(listDetailsTour[0], null);

            

            var tenGoiTour = from p in listDetailsTour
             
                             select p;

            MessageBox.Show(tenGoiTour.ToString());

            //textBoxDacDiem.Text = b_tour.GetListDetailsTour(maSoTour).Rows[0][1].ToString();

            //comboBoxDiaDiem.SelectedIndex = comboBoxDiaDiem.FindString(b_tour.GetListDetailsTour(maSoTour).Rows[0][3].ToString());
            //comboBoxLoaiHinhDuLich.SelectedIndex = comboBoxLoaiHinhDuLich.FindString(b_tour.GetListDetailsTour(maSoTour).Rows[0][2].ToString());

            //textBoxGia.Text = b_tour.GetListDetailsTour(maSoTour).Rows[0][4].ToString();
            //textBoxSoLuongKhachHang.Text = b_tour.GetListDetailsTour(maSoTour).Rows[0][5].ToString();
            //textBoxTongTien.Text = b_tour.GetListDetailsTour(maSoTour).Rows[0][6].ToString();

            //Chưa xử lý giá, thời gian bắt đầu, thời gian kết thúc
            // dateTimePickerThoiGianBatDau.Value = b_tour.GetListDetailsTour(maSoTour).Rows[0][7].ToString();

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

        private void buttonSua_Click(object sender, EventArgs e)
        {

        }
    }
}
