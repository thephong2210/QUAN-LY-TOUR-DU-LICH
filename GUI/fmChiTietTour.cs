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
        D_DangKy d_dangky = new D_DangKy();
        D_doan d_doan = new D_doan();

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

        public void HienThiChiTietTour()
        {
            List<dynamic> listDetailsTour = bTour.GetListDetailsTour(maSoTour);
            
            //Convert List<dynamic> sang Datatable để dễ hiển thị chi tiết tour
            var json = JsonConvert.SerializeObject(listDetailsTour);
            DataTable dataTableDetailsTour = (DataTable)JsonConvert.DeserializeObject(json, (typeof(DataTable)));

            //Hiển thị
            textBoxMaSoTour.Text = maSoTour.ToString();
            textBoxTenGoiTour.Text = dataTableDetailsTour.Rows[0][1].ToString();
            textBoxDacDiem.Text = dataTableDetailsTour.Rows[0][2].ToString();
         
            comboBoxDiaDiem.SelectedIndex = comboBoxDiaDiem.FindString(dataTableDetailsTour.Rows[0][6].ToString());
            LoadDiaDiemThamQuan();
            checkedDiaDiemThamQuan(maSoTour);

            comboBoxLoaiHinhDuLich.SelectedIndex = comboBoxLoaiHinhDuLich.FindString(dataTableDetailsTour.Rows[0][5].ToString());

            dateTimePickerThoiGianBatDau.Value = Convert.ToDateTime(dataTableDetailsTour.Rows[0][3]);
            dateTimePickerThoiGianKetThuc.Value = Convert.ToDateTime(dataTableDetailsTour.Rows[0][4]);

            LoadTongChiPhiTongDoanhThu();

        }

        public void LoadTongChiPhiTongDoanhThu()
        {
            var listChiPhiTour = d_dangky.GetChiPhiOneTour(this.maSoTour);
            var listGiaVeTour = d_dangky.GetDoanhSoDangKyAllTour();

            //tổng chi phí
            foreach (var itemChiPhi in listChiPhiTour)
            {
                if (this.maSoTour == itemChiPhi.maSoTour)
                {
                    textBoxTongChiPhi.Text = String.Format("{0:n0}", itemChiPhi.totalChiPhi);
                }
                else
                {
                    textBoxTongChiPhi.Text = "0";
                }
            }

            //tổng doanh thu
            foreach (var itemGiaVe in listGiaVeTour)
            {
                double calcDoanhThu = 0;
                //var calcGiaVe = 0;
                foreach (var itemChiPhi in listChiPhiTour)
                {
                    if (itemGiaVe.maSoTour == this.maSoTour)
                    {
                        if (itemGiaVe.maSoTour == itemChiPhi.maSoTour)
                        {
                            calcDoanhThu = itemGiaVe.totalGiaVe - itemChiPhi.totalChiPhi;
                        }

                    }

                }

                if (calcDoanhThu != 0)
                {
                    textBoxTongDoanhThu.Text = String.Format("{0:n0}", calcDoanhThu);
                }
                


            }

            //danh sách đoàn trong tour
            var listGetListDoanWithMaTour = d_doan.GetListDoanWithMaTour(this.maSoTour);

            dataGridViewDanhSachDoan.AutoGenerateColumns = false;
            dataGridViewDanhSachDoan.Rows.Clear();
            foreach (var itemListDoan in listGetListDoanWithMaTour)
            {
                var _maSoDoan = itemListDoan.maSoDoan;
                var _tenGoiDoan = itemListDoan.tenGoiDoan;

                dataGridViewDanhSachDoan.Rows.Add(_maSoDoan, _tenGoiDoan);
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

        public bool CheckThoiGianDangKy() //ngày bắt đầu < ngày kết thúc
        {
            if (dateTimePickerThoiGianBatDau.Value <= dateTimePickerThoiGianKetThuc.Value)
            {
                return true;
            }
            return false;

        }

        private void SuaThongTinTour()
        {
            List<diadiemden> listDiaDiemDen = bDiaDiemDen.GetListDiaDiemDen();
            List<loaihinhdulich> listLHDL = bLoaiHinhDuLich.GetListLoaiHinhDL();
            List<giatour> listGiaTour = bGiaTour.GetGiaTour();
            List<diadiemtour> listDiaDiemTour = bDiaDiemDen.GetListDiaDiemTour();

            if (!String.IsNullOrWhiteSpace(textBoxTenGoiTour.Text))
            {
                if (!String.IsNullOrWhiteSpace(textBoxDacDiem.Text))
                {
                    if (CheckThoiGianDangKy())
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

                            objTour.thoiGianBatDau = DateTime.Parse(dateTimePickerThoiGianBatDau.Value.Date.ToString("yyyy-MM-dd hh:mm:ss.ss"));
                            objTour.thoiGianKetThuc = DateTime.Parse(dateTimePickerThoiGianKetThuc.Value.Date.ToString("yyyy-MM-dd hh:mm:ss.ss"));
                            
                            objTour.trangThai = 1;


                            //Bắt đầu sửa các dữ liệu
                            try
                            {
                                if (bTour.SuaTour(objTour, maSoTour))
                                {
                                    System.Diagnostics.Debug.WriteLine("Sửa tour thành công!");

                                    //Xoa truoc khi them
                                    foreach (var items in listDiaDiemTour)
                                    {
                                        if (maSoTour == items.maTour)
                                        {
                                            if (bDiaDiemDen.XoaDiaDiemTour(objDiaDiemTour, items.id))
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
                        MessageBox.Show("Ngày bắt đầu phải NHỎ HƠN ngầy kết thúc!", "Thông báo");
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
   
        }

        private void comboBoxGia_SelectedIndexChanged(object sender, EventArgs e)
        {
       
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel13_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonThemGia_Click(object sender, EventArgs e)
        {
            fmGiaTour fmGiaTour = new fmGiaTour(maSoTour, this);
            fmGiaTour.ShowDialog();
        }
    }
}
