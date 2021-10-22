using BUS;
using DTO;
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
            LoadComboboxDiaDiem();
            LoadComboboxLoaiHinhDuLich();

        }

        B_tour b_Tour = new B_tour();

        private void LoadDanhSachTour()
        {
            dataGridViewQuanLyTour.DataSource = b_Tour.GetListTour();
        }

        private void LoadComboboxDiaDiem()
        {
            comboBoxDiaDiem.DataSource = b_Tour.GetListDiaDiem().Tables[0];
            comboBoxDiaDiem.DisplayMember = "tenDiaDiem";
        }

        private void LoadComboboxLoaiHinhDuLich()
        {
            comboBoxLoaiHinhDuLich.DataSource = b_Tour.GetListLoaiHinhDuLich().Tables[0];
            comboBoxLoaiHinhDuLich.DisplayMember = "tenLoaiHinhDuLich";
        }

        private void XoaTextBox()
        {
            textBoxTenTour.Text = "";
            textBoxDacDiem.Text = "";
        }

        private void ThemTour()
        {

            if (!String.IsNullOrEmpty(textBoxTenTour.Text))
            {
                if (!String.IsNullOrEmpty(textBoxDacDiem.Text))
                {
                    string tenGoi = textBoxTenTour.Text;
                    string dacDiem = textBoxDacDiem.Text;
                    int maDiaDiem = int.Parse(b_Tour.GetMaDiaDiem(comboBoxDiaDiem.Text).Rows[0][0].ToString());
                    int maGiaTour = 1;
                    int maLHDL = int.Parse(b_Tour.GetMaLoaiHinhDuLich(comboBoxLoaiHinhDuLich.Text).Rows[0][0].ToString());
                    int soLuongKH = 0;
                    int tongTien = 0;
                    string thoiGianBD = dateTimePickerNgayBatDau.Value.Date.ToString("yyyy-MM-dd hh:mm:ss.ss");
                    string thoiGianKT = dateTimePickerNgayKetThuc.Value.Date.ToString("yyyy-MM-dd hh:mm:ss.ss");

                    DTO_tour DTOtour = new DTO_tour(tenGoi, dacDiem, maDiaDiem, maGiaTour, maLHDL, soLuongKH, tongTien, thoiGianBD, thoiGianKT);

                    try
                    {
                        b_Tour.ThemTour(DTOtour);
                        LoadDanhSachTour();
                        XoaTextBox();

                        MessageBox.Show("Thêm thành công!", "Thông báo");
                    }
                    catch
                    {
                        MessageBox.Show("Thêm không thành công!", "Thông báo");
                    }

                }
                else
                {
                    MessageBox.Show("Vui lòng đặc điểm tour!", "Thông báo");
                    textBoxDacDiem.Focus();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập tên tour!", "Thông báo");
                textBoxTenTour.Focus();
            }

            
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

        private void buttonTaoMoi_Click(object sender, EventArgs e)
        {
            ThemTour();
            
        }

        private void comboBoxDiaDiem_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }



}