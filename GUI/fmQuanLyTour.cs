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
            dateTimePickerNgayBatDau.MinDate = DateTime.Now; //ngày đăng ký tour bắt đầu từ hiện tại đến tương lai
            dateTimePickerNgayKetThuc.MinDate = DateTime.Now;
        }

        public void LoadDanhSachTour()
        {
            dataGridViewQuanLyTour.DataSource = bTour.GetListTour();
            dataGridViewQuanLyTour.AutoGenerateColumns = false;
        }

        public void LoadComboboxDiaDiem()
        {
            comboBoxDiaDiem.DataSource = bDiaDiemDen.GetListDiaDiemDen();
            comboBoxDiaDiem.DisplayMember = "tenDiaDiemDen";
            comboBoxDiaDiem.ValueMember = "maDiaDiemDen";
        }

        public void LoadComboboxLoaiHinhDuLich()
        {
            comboBoxLoaiHinhDuLich.DataSource = bLoaiHinhDuLich.GetListLoaiHinhDL();
            comboBoxLoaiHinhDuLich.DisplayMember = "tenLoaiHinhDuLich";
            comboBoxLoaiHinhDuLich.ValueMember = "maLoaiHinhDuLich";
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

                    fmChiTietTour formChiTietTour = new fmChiTietTour(int.Parse(maSoTour), this);
                    //System.Diagnostics.Debug.WriteLine(int.Parse(maSoTour));

                    formChiTietTour.ShowDialog();

                }

            }
        }


        private void ClearFields()
        {
            textBoxTenTour.Text = "";
            textBoxDacDiem.Text = "";
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

        public bool CheckThoiGianDangKy() //ngày bắt đầu < ngày kết thúc
        {
            if (dateTimePickerNgayBatDau.Value <= dateTimePickerNgayKetThuc.Value)
            {
                return true;
            }
            return false;

        }


        private void ThemTour()
        {
            List<diadiemden> listDiaDiemDen = bDiaDiemDen.GetListDiaDiemDen();
            List<loaihinhdulich> listLHDL = bLoaiHinhDuLich.GetListLoaiHinhDL();
            List<tour> listTour = bTour.GetAllTour();

            if (!String.IsNullOrWhiteSpace(textBoxTenTour.Text))
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

                                objTour.tenGoiTour = textBoxTenTour.Text;
                                objTour.dacDiem = textBoxDacDiem.Text;

                                objTour.maDiaDiemDen = Convert.ToInt32(comboBoxDiaDiem.SelectedValue);
                                objTour.maLoaiHinhDuLich = Convert.ToInt32(comboBoxLoaiHinhDuLich.SelectedValue);


                                objTour.thoiGianBatDau = DateTime.Parse(dateTimePickerNgayBatDau.Value.Date.ToString("yyyy-MM-dd hh:mm:ss.ss"));
                                objTour.thoiGianKetThuc = DateTime.Parse(dateTimePickerNgayKetThuc.Value.Date.ToString("yyyy-MM-dd hh:mm:ss.ss"));

                                objTour.idGiaTour = null; //tour mới

                                objTour.trangThai = 1;

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

                                        LoadDanhSachTour();

                                        System.Diagnostics.Debug.WriteLine("Thêm giá tour thành công!");
                                        MessageBox.Show("Thêm tour thành công!", "Thông báo");

                                        ClearFields();

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
                                MessageBox.Show("Vui lòng chọn địa điểm tham quan!", "Thông báo");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Ngày bắt đầu phải NHỎ HƠN ngày kết thúc!", "Thông báo");
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
                textBoxTenTour.Focus();
            }


        }

        //Dùng cho chức năng thêm, lấy mã số tour mới
        public int GetMaxMaSoTour(List<tour> list)
        {
            if (list.Count == 0)
            {
                return 1;
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

        //Dùng cho chức năng thêm, cho thuộc tính idGiaTour
        public int GetMaxIDGiaTour(List<giatour> list)
        {
            if (list.Count == 0)
            {
                return 1;
            }
            int maxID = 0;
            foreach (giatour type in list)
            {
                if (type.id > maxID)
                {
                    maxID = type.id;
                }
            }
            return maxID;
        }

        public void XoaTour()
        {
            List<diadiemtour> listDiaDiemTour = bDiaDiemDen.GetListDiaDiemTour();
            List<giatour> listGiaTour = bGiaTour.GetGiaTour();
            diadiemtour objDiaDiemTour = new diadiemtour();
            giatour objGiaTour = new giatour();

            if (dataGridViewQuanLyTour.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridViewQuanLyTour.SelectedRows)
                {
                    int maSoTour = Convert.ToInt32(row.Cells[0].Value.ToString());

                    bTour.XoaTour(maSoTour);

                    //Xoa dia diem tham quan trong tour này
                    foreach (var items in listDiaDiemTour)
                    {
                        if (maSoTour == items.maTour)
                        {
                            if (bDiaDiemDen.XoaDiaDiemTour(objDiaDiemTour, items.id))   // ??
                            {
                                System.Diagnostics.Debug.WriteLine("Xóa địa điểm tour thành công!");
                            }
                        }
                    }

                    //Xóa bảng giá của tour
                    foreach (var itemGiaTour in listGiaTour)
                    {
                        if (maSoTour == itemGiaTour.maGiaTour)
                        {
                            if (bGiaTour.XoaGiaTour(objGiaTour, itemGiaTour.maGiaTour))
                            {
                                System.Diagnostics.Debug.WriteLine("Xóa giá tour thành công!");
                            }
                        }
                    }

                    LoadDanhSachTour();
                    MessageBox.Show("Xóa thành công!", "Thông báo");
                    
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn tour muốn xóa!", "Thông báo");
            }
            
            


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

        public void TimKiemTen()
        {

            if (!String.IsNullOrWhiteSpace(textBoxTimKiem.Text))
            {
                string searchValue = textBoxTimKiem.Text;

                dataGridViewQuanLyTour.DataSource = bTour.TimKiemTenTour(searchValue);

            }
            else
            {
                LoadDanhSachTour();
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            TimKiemTen();
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

        private void checkedListBoxDDThamQuan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Bạn có chắc muốn xóa không ?? :D", "Xóa tour", MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                XoaTour();
            }

        }

        private void dataGridViewQuanLyTour_BindingContextChanged(object sender, EventArgs e)
        {
          
        }

        private void fmQuanLyTour_Load(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }



}