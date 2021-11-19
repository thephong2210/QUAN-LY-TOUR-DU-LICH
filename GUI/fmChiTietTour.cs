using BUS;
using DAO;
using Newtonsoft.Json;
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
        B_giatour bGiaTour = new B_giatour();

        public fmChiTietTour(int maSoTour, fmQuanLyTour fmQLT)
        {
            InitializeComponent();

            fmMain = fmQLT;
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

        private fmQuanLyTour fmMain;
        public int maSoTour { get; set; } //Set data sẽ lấy từ form quản lý tour

        private void HienThiChiTietTour()
        {
            List<dynamic> listDetailsTour = bTour.GetListDetailsTour(maSoTour);
            
            //Convert List<dynamic> sang Datatable để dễ hiển thị chi tiết tour
            var json = JsonConvert.SerializeObject(listDetailsTour);
            DataTable dataTableDetailsTour = (DataTable)JsonConvert.DeserializeObject(json, (typeof(DataTable)));

            //Hiển thị
            textBoxMaSoTour.Text = maSoTour.ToString();
            textBoxTenGoiTour.Text = dataTableDetailsTour.Rows[0][1].ToString();
            textBoxDacDiem.Text = dataTableDetailsTour.Rows[0][2].ToString();
            textBoxSoLuongKhachHang.Text = dataTableDetailsTour.Rows[0][3].ToString();
            textBoxTongTien.Text = dataTableDetailsTour.Rows[0][4].ToString();
            comboBoxDiaDiem.SelectedIndex = comboBoxDiaDiem.FindString(dataTableDetailsTour.Rows[0][8].ToString());
            LoadDiaDiemThamQuan();
            checkedDiaDiemThamQuan(maSoTour);

            comboBoxLoaiHinhDuLich.SelectedIndex = comboBoxLoaiHinhDuLich.FindString(dataTableDetailsTour.Rows[0][7].ToString());

            dateTimePickerThoiGianBatDau.Value = Convert.ToDateTime(dataTableDetailsTour.Rows[0][5]);
            dateTimePickerThoiGianKetThuc.Value = Convert.ToDateTime(dataTableDetailsTour.Rows[0][6]);

            //Load combobox gia hien tai cua tour
            List<giatour> listGiaTour = bGiaTour.GetGiaTour();
            int idGiaTour = Convert.ToInt32(dataTableDetailsTour.Rows[0][9]);

            foreach (var item in listGiaTour)
            {
                if (item.maGiaTour == maSoTour)
                {
                    comboBoxGia.Items.Add(item.gia.ToString());
                    if (idGiaTour == item.id)
                    {
                        comboBoxGia.SelectedIndex = comboBoxGia.FindStringExact(item.gia.ToString());
                    }
                }
            }

           
        }

        private void TinhTongTien()
        {
            if (!String.IsNullOrEmpty(comboBoxGia.Text))
            {
                int soLuongKhach = Convert.ToInt32(textBoxSoLuongKhachHang.Text);
                float giaHienTai = float.Parse(comboBoxGia.SelectedItem.ToString());
                textBoxTongTien.Text = (soLuongKhach * giaHienTai).ToString();
            }
            
        }

        private void LoadDiaDiemThamQuan()
        {
            List<diadiemden> listDiaDiemDen = bDiaDiemDen.GetListDiaDiemDen();
            List<diadiemthamquan> listDDTQ = bDiaDiemDen.GetListDiaDiemThamQuan();

            string tenDiaDiemDen = comboBoxDiaDiem.Text;

            //gán khởi tạo tenDiaDiem = giá trị đầu tiên trong list nếu null
            if (tenDiaDiemDen.Equals("DAO.diadiemden"))
            {
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

        private void checkedDiaDiemThamQuan(int maSoTour)
        {
            List<diadiemtour> listDDTour = bDiaDiemDen.GetListDiaDiemTour();
            
            //vòng for trong list diadiemtour
            foreach (var itemDDTour in listDDTour)
            {
                //vòng for trong checkedListbox
                for (int count= 0; count < checkedListBoxDDThamQuan.Items.Count; count++ )
                {
                    if (itemDDTour.maTour == maSoTour)
                    {
                        if (itemDDTour.tenDiaDiemThamQuan.Equals(checkedListBoxDDThamQuan.Items[count].ToString()))
                        {
                            //System.Diagnostics.Debug.WriteLine(count);
                            checkedListBoxDDThamQuan.SetItemChecked(count, true);
                        }
                    }
                    
                }

            }
        }

       
        private void SuaThongTinTour()
        {
            List<diadiemden> listDiaDiemDen = bDiaDiemDen.GetListDiaDiemDen();
            List<loaihinhdulich> listLHDL = bLoaiHinhDuLich.GetListLoaiHinhDL();
            List<giatour> listGiaTour = bGiaTour.GetGiaTour();
            List<diadiemtour> listDiaDiemTour = bDiaDiemDen.GetListDiaDiemTour();

            if (!String.IsNullOrEmpty(textBoxTenGoiTour.Text))
            {
                if (!String.IsNullOrEmpty(textBoxDacDiem.Text))
                {
                    if (checkedListBoxDDThamQuan.CheckedItems.Count != 0)
                        {
                        //Khai báo object
                        tour objTour = new tour();
                        diadiemtour objDiaDiemTour = new diadiemtour();

                        objTour.tenGoiTour = textBoxTenGoiTour.Text;
                        objTour.dacDiem = textBoxDacDiem.Text;

                        //Lấy maDiaDiem
                        foreach (var itemDD in listDiaDiemDen)
                        {
                            if (itemDD.tenDiaDiemDen.Equals(comboBoxDiaDiem.Text))
                            {
                                objTour.maDiaDiemDen = itemDD.maDiaDiemDen;
                            }
                        }

                         //Lấy maLoaiHinhDuLich
                         foreach (var itemLHDL in listLHDL)
                         {
                            if (itemLHDL.tenLoaiHinhDuLich.Equals(comboBoxLoaiHinhDuLich.Text))
                            {
                                objTour.maLoaiHinhDuLich = itemLHDL.maLoaiHinhDuLich;
                            }
                         }

                         objTour.soLuongKhachHang = Convert.ToInt32(textBoxSoLuongKhachHang.Text);
                         objTour.tongTien = float.Parse(textBoxTongTien.Text);
                         objTour.thoiGianBatDau = DateTime.Parse(dateTimePickerThoiGianBatDau.Value.Date.ToString("yyyy-MM-dd hh:mm:ss.ss"));
                         objTour.thoiGianKetThuc = DateTime.Parse(dateTimePickerThoiGianKetThuc.Value.Date.ToString("yyyy-MM-dd hh:mm:ss.ss"));

                         //Lấy idGiaTour
                         foreach (var itemGiaTour in listGiaTour)
                         {
                            if (itemGiaTour.maGiaTour == maSoTour)
                            {
                                if (itemGiaTour.gia.Equals(Double.Parse(comboBoxGia.Text)))
                                {
                                    objTour.idGiaTour = itemGiaTour.id;
                                }
                            }
                        }

                        //Bắt đầu sửa các dữ liệu
                        try
                            {
                                if (bTour.SuaTour(objTour, maSoTour))
                                {
                                    System.Diagnostics.Debug.WriteLine("Sửa tour thành công!");

                                    //Xoa truoc khi them
                                    foreach (var items in listDiaDiemTour)
                                    {
                                        if(maSoTour == items.maTour)
                                        {
                                            if(bDiaDiemDen.XoaDiaDiemTour(objDiaDiemTour, items.id))
                                            {
                                                System.Diagnostics.Debug.WriteLine("Xóa địa điểm tour thành công!");
                                            }
                                        }
                                    }    

                                    //Thêm thông tin địa điểm của tour
                                    foreach (object itemChecked in checkedListBoxDDThamQuan.CheckedItems)
                                    {
                                        objDiaDiemTour.maTour = maSoTour;
                                        objDiaDiemTour.tenDiaDiemThamQuan = itemChecked.ToString();

                                        if (bDiaDiemDen.ThemDiaDiemTour(objDiaDiemTour))
                                        {
                                            System.Diagnostics.Debug.WriteLine("Thêm địa điểm tour thành công!");
                                        }
                                    }

                                    fmMain.LoadDanhSachTour();
                                    MessageBox.Show("Sửa tour thành công!", "Thông báo");

                                }

                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Sửa không thành công!", "Thông báo");
                                System.Diagnostics.Debug.WriteLine(ex);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Vui lòng chọn địa điểm tham quan!", "Thông báo");
                        }

                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đặc điểm tour!", "Thông báo");
                    textBoxDacDiem.Focus();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập tên tour!", "Thông báo");
                textBoxTenGoiTour.Focus();
            }


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
            SuaThongTinTour();
        }

        private void checkedListBoxDDThamQuan_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBoxDiaDiem_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDiaDiemThamQuan();
            checkedDiaDiemThamQuan(maSoTour);
        }

        private void textBoxTongTien_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBoxSoLuongKhachHang_TextChanged(object sender, EventArgs e)
        {
            TinhTongTien();
        }

        private void comboBoxGia_SelectedIndexChanged(object sender, EventArgs e)
        {
            TinhTongTien();
        }
    }
}
