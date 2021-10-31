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
        B_giatour bGiaTour = new B_giatour();
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


        private void ClearFields()
        {
            textBoxTenTour.Text = "";
            textBoxDacDiem.Text = "";
            textBoxGia.Text = "";
            ChangeAllCheckBoxValues_DDThamQuan(false);
        }

        //hàm Check/uncheck các option checkbox, dùng clear listbox sau khi thêm
        private void ChangeAllCheckBoxValues_DDThamQuan(bool value)
        {
            for (int i = 1; i < checkedListBoxDDThamQuan.Items.Count; i++)
            {
                checkedListBoxDDThamQuan.SetItemChecked(i, value);
            }
        }

        private void ThemTour()
        {
            List<diadiemden> listDiaDiemDen = bDiaDiemDen.GetListDiaDiemDen();
            List<loaihinhdulich> listLHDL = bLoaiHinhDuLich.GetListLoaiHinhDL();
            List<tour> listTour = bTour.GetAllTour();

            if (!String.IsNullOrEmpty(textBoxTenTour.Text))
            {
                if (!String.IsNullOrEmpty(textBoxGia.Text))
                {
                    if (!String.IsNullOrEmpty(textBoxDacDiem.Text))
                    {
                        //Khai báo object
                        tour objTour = new tour();
                        giatour objGiaTour = new giatour();
                        diadiemtour objDiaDiemTour = new diadiemtour();

                        objTour.tenGoiTour = textBoxTenTour.Text;
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

                        objTour.soLuongKhachHang = 0;
                        objTour.tongTien = 0;
                        objTour.thoiGianBatDau = DateTime.Parse(dateTimePickerNgayBatDau.Value.Date.ToString("yyyy-MM-dd hh:mm:ss.ss"));
                        objTour.thoiGianKetThuc = DateTime.Parse(dateTimePickerNgayKetThuc.Value.Date.ToString("yyyy-MM-dd hh:mm:ss.ss"));

                        //Lấy thông tin giá tour để thêm vào giatour
                        objGiaTour.gia = float.Parse(textBoxGia.Text);
                        objGiaTour.maGiaTour = GetMaxMaSoTour(listTour) + 1; //Mã tour mới
                        objGiaTour.dieuKien = "mới tạo";

                        
                        //Bắt đầu thêm các dữ liệu
                        try
                        {
                            if (bTour.ThemTour(objTour))
                            {
                                System.Diagnostics.Debug.WriteLine("Thêm tour thành công!");
                                
                                //Thêm thông tin địa điểm của tour
                                foreach (object itemChecked in checkedListBoxDDThamQuan.CheckedItems)
                                {
                                    objDiaDiemTour.maTour = GetMaxMaSoTour(listTour) + 1;
                                    objDiaDiemTour.tenDiaDiemThamQuan = itemChecked.ToString();

                                    if (bDiaDiemDen.ThemDiaDiemTour(objDiaDiemTour))
                                    {
                                        System.Diagnostics.Debug.WriteLine("Thêm địa điểm tour thành công!");
                                    }
                                }

                                if (bGiaTour.ThemGiaTour(objGiaTour))
                                {
                                    LoadDanhSachTour();
                                   
                                    System.Diagnostics.Debug.WriteLine("Thêm giá tour thành công!");
                                    MessageBox.Show("Thêm tour thành công!", "Thông báo");
                                   
                                    ClearFields();

                                }
                                
                            }
                            

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Thêm không thành công!", "Thông báo");
                            System.Diagnostics.Debug.WriteLine(ex);
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
                    MessageBox.Show("Vui lòng nhập giá tour!", "Thông báo");
                    textBoxGia.Focus();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập tên tour!", "Thông báo");
                textBoxTenTour.Focus();
            }


        }

        //Dùng cho chức năng thêm, lấy mã số tour mới
        public int GetMaxMaSoTour(List<tour> list)
        {
            if (list.Count == 0)
            {
                throw new InvalidOperationException("Empty list");
            }
            int maxMaSoTour = 0;
            foreach (tour type in list)
            {
                if (type.maSoTour > maxMaSoTour)
                {
                    maxMaSoTour = type.maSoTour;
                }
            }
            return maxMaSoTour;
        }

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
            ThemTour();
            
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

        private void textBoxGia_TextChanged(object sender, EventArgs e)
        {

        }
    }



}