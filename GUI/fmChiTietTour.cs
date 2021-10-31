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
            
            //Convert List<dynamic> sang Datatable để dễ hiển thị chi tiết tour
            var json = JsonConvert.SerializeObject(listDetailsTour);
            DataTable dataTableDetailsTour = (DataTable)JsonConvert.DeserializeObject(json, (typeof(DataTable)));

            //Hiển thị
            textBoxMaSoTour.Text = maSoTour.ToString();
            textBoxTenGoiTour.Text = dataTableDetailsTour.Rows[0][1].ToString();
            textBoxDacDiem.Text = dataTableDetailsTour.Rows[0][2].ToString();

            //textBoxGia.Text = dataTableDetailsTour.Rows[0][3].ToString();
            int maGiaTour = Convert.ToInt32(dataTableDetailsTour.Rows[0][3]);
            List<giatour> listGiaTour = bTour.GetGiaTour();
            
            foreach (var item in listGiaTour)
            {
                if (item.maGiaTour == maGiaTour)
                {
                    textBoxGia.Text = item.gia.ToString();
                }
            }

            textBoxSoLuongKhachHang.Text = dataTableDetailsTour.Rows[0][4].ToString();
            textBoxTongTien.Text = dataTableDetailsTour.Rows[0][5].ToString();
            comboBoxDiaDiem.SelectedIndex = comboBoxDiaDiem.FindString(dataTableDetailsTour.Rows[0][9].ToString());
            LoadDiaDiemThamQuan();
            checkedDiaDiemThamQuan(maSoTour);

            comboBoxLoaiHinhDuLich.SelectedIndex = comboBoxLoaiHinhDuLich.FindString(dataTableDetailsTour.Rows[0][8].ToString());

            dateTimePickerThoiGianBatDau.Value = Convert.ToDateTime(dataTableDetailsTour.Rows[0][6]);
            dateTimePickerThoiGianKetThuc.Value = Convert.ToDateTime(dataTableDetailsTour.Rows[0][7]);


            
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

        private void checkedListBoxDDThamQuan_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBoxDiaDiem_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDiaDiemThamQuan();
            checkedDiaDiemThamQuan(maSoTour);
        }
    }
}
