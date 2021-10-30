using BUS;
using DAO;
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
        B_tour bTour = new B_tour();
        B_diadiemden bDiaDiemDen = new B_diadiemden();
        B_loaihinhdulich bLoaiHinhDuLich = new B_loaihinhdulich();

        public fmQuanLyTour()
        {
            InitializeComponent();
            LoadDanhSachTour();
            LoadComboboxDiaDiem();
            LoadComboboxLoaiHinhDuLich();
            

        }

        private void LoadDanhSachTour()
        {
            dataGridViewQuanLyTour.DataSource = bTour.GetListTour();
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

        private void LoadDiaDiemThamQuan()
        {
            List<diadiemden> listDiaDiemDen = bDiaDiemDen.GetListDiaDiemDen();
            List<diadiemthamquan> listDDTQ = bDiaDiemDen.GetListDiaDiemThamQuan();
            string tenDiaDiemDen = comboBoxDiaDiem.Text;

            //gán khởi tạo tenDiaDiem = giá trị đầu tiên trong list nếu null
            if (tenDiaDiemDen.Equals("DAO.diadiemden")){
                tenDiaDiemDen = listDiaDiemDen.FirstOrDefault().tenDiaDiemDen;
            }

            //Clear listbox trước khi add
            checkedListBoxDDThamQuan.Items.Clear();

            //Lấy maDiaDiemDen từ tenDiaDiemDen lấy từ combobox
            foreach (var itemDDD in listDiaDiemDen)
            {
                if (itemDDD.tenDiaDiemDen.Equals(tenDiaDiemDen))
                {
                    //lấy danh sách địa điểm tham quan trong địa điểm đến
                    foreach (var itemDDTQ in listDDTQ)
                    {
                        if (itemDDTQ.maDiaDiemDen == itemDDD.maDiaDiemDen)
                        {
                            //Thêm vào checkedListbox
                            checkedListBoxDDThamQuan.Items.Add(itemDDTQ.tenDiaDiem);
                        }
                    }

                }
                
            }

        }

        private void XemChiTietTour()
        {
            foreach (DataGridViewRow row in dataGridViewQuanLyTour.SelectedRows)
            {
                if (!String.Equals(row.Cells[0].Value.ToString(), "System.Windows.Forms.DataGridViewTextBoxColumn"))
                {
                    string maSoTour = row.Cells[0].Value.ToString();

                    fmChiTietTour formChiTietTour = new fmChiTietTour(int.Parse(maSoTour));
                    //System.Diagnostics.Debug.WriteLine(int.Parse(maSoTour));

                    formChiTietTour.ShowDialog();

                }

            }
        }



        private void XoaTextBox()
        {
            textBoxTenTour.Text = "";
            textBoxDacDiem.Text = "";
        }

        //private void ThemTour()
        //{

        //    if (!String.IsNullOrEmpty(textBoxTenTour.Text))
        //    {
        //        if (!String.IsNullOrEmpty(textBoxDacDiem.Text))
        //        {
        //            string tenGoi = textBoxTenTour.Text;
        //            string dacDiem = textBoxDacDiem.Text;
        //            int maDiaDiem = int.Parse(b_Tour.GetMaDiaDiem(comboBoxDiaDiem.Text).Rows[0][0].ToString());
        //            int maGiaTour = 1;
        //            int maLHDL = int.Parse(b_Tour.GetMaLoaiHinhDuLich(comboBoxLoaiHinhDuLich.Text).Rows[0][0].ToString());
        //            int soLuongKH = 0;
        //            int tongTien = 0;
        //            string thoiGianBD = dateTimePickerNgayBatDau.Value.Date.ToString("yyyy-MM-dd hh:mm:ss.ss");
        //            string thoiGianKT = dateTimePickerNgayKetThuc.Value.Date.ToString("yyyy-MM-dd hh:mm:ss.ss");

        //            DTO_tour DTOtour = new DTO_tour(tenGoi, dacDiem, maDiaDiem, maGiaTour, maLHDL, soLuongKH, tongTien, thoiGianBD, thoiGianKT);

        //            try
        //            {
        //                b_Tour.ThemTour(DTOtour);
        //                LoadDanhSachTour();
        //                XoaTextBox();

        //                MessageBox.Show("Thêm thành công!", "Thông báo");
        //            }
        //            catch
        //            {
        //                MessageBox.Show("Thêm không thành công!", "Thông báo");
        //            }

        //        }
        //        else
        //        {
        //            MessageBox.Show("Vui lòng nhập đặc điểm tour!", "Thông báo");
        //            textBoxDacDiem.Focus();
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("Vui lòng nhập tên tour!", "Thông báo");
        //        textBoxTenTour.Focus();
        //    }


        //}

        private void buttonXemChiTiet_Click_1(object sender, EventArgs e)
        {
            XemChiTietTour();
        }

        private void dataGridViewQuanLyTour_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonTaoMoi_Click(object sender, EventArgs e)
        {
            //ThemTour();
            
        }

        private void comboBoxDiaDiem_SelectedIndexChanged(object sender, EventArgs e)
        {
           LoadDiaDiemThamQuan();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        
    }



}