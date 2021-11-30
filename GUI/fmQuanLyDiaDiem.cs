using BUS;
using DAO;
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
    public partial class fmQuanLyDiaDiem : Form
    {
        B_diadiemden b_DiaDiemDen = new B_diadiemden();

        public fmQuanLyDiaDiem()
        {
            InitializeComponent();
            LoadDanhSachDiaDiem();
        }

        public void LoadDanhSachDiaDiem()
        {
            dataGridViewDanhSachDiaDiem.DataSource = b_DiaDiemDen.GetListDiaDiemDen();
        }

        public void ThemDiaDiemToListBox()
        {
            string tenDiaDiemThamQuan = textBoxDiaDiemThamQuan.Text;

            if (!String.IsNullOrWhiteSpace(tenDiaDiemThamQuan))
            {
                if (listBoxDiaDiemThamQuan.Items.Contains(tenDiaDiemThamQuan))
                {
                    MessageBox.Show("Địa điểm này đã có trong danh sách! Mời nhập địa điểm khác!", "Thông báo");
                }
                else
                {
                    listBoxDiaDiemThamQuan.Items.Add(textBoxDiaDiemThamQuan.Text);
                    textBoxDiaDiemThamQuan.Text = "";
                    textBoxDiaDiemThamQuan.Focus();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập tên địa điểm tham quan!", "Thông báo");
            }
        }

        public void XoaItemListBox()
        {
            if (listBoxDiaDiemThamQuan.SelectedIndex != -1)
            {
                string removeItem = listBoxDiaDiemThamQuan.SelectedItem.ToString();
                listBoxDiaDiemThamQuan.Items.Remove(removeItem);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn địa điểm muốn xóa!", "Thông báo");
            }
        }

        public void XoaTatCaItemListBox()
        {
            if (listBoxDiaDiemThamQuan.Items.Count != 0)
            {
                var confirmResult = MessageBox.Show("Bạn có chắc muốn xóa tất cả không ?? :D", "Thông báo", MessageBoxButtons.YesNo);

                if (confirmResult == DialogResult.Yes)
                {
                    listBoxDiaDiemThamQuan.Items.Clear();
                }
            }
            else
            {
                MessageBox.Show("Danh sách trống!", "Thông báo");
            }
        }

        public void ThemMoiDiaDiem()
        {
            if (!String.IsNullOrWhiteSpace(textBoxTenDiaDiemDen.Text))
            {
                if (listBoxDiaDiemThamQuan.Items.Count != 0)
                {
                    List<diadiemden> listDiaDiemDen = b_DiaDiemDen.GetListDiaDiemDen();
                    diadiemden objDiaDiemDen = new diadiemden();
                    
                    objDiaDiemDen.tenDiaDiemDen = textBoxTenDiaDiemDen.Text;
                    objDiaDiemDen.trangThai = 1;

                    if (b_DiaDiemDen.ThemDiaDiemDen(objDiaDiemDen))
                    {
                        System.Diagnostics.Debug.WriteLine("Thêm địa điểm đến thành công!"); //debug write line

                        foreach (string item in listBoxDiaDiemThamQuan.Items)
                        {
                            diadiemthamquan objDiaDiemThamQuan = new diadiemthamquan();

                            objDiaDiemThamQuan.tenDiaDiem = item;
                            objDiaDiemThamQuan.maDiaDiemDen = GetMaxMaDiaDiemDen(listDiaDiemDen) + 1; //mã địa điểm mới

                            if (b_DiaDiemDen.ThemDiaDiemThamQuan(objDiaDiemThamQuan))
                            {
                                System.Diagnostics.Debug.WriteLine("Thêm địa điểm tham quan thành công!"); //debug write line

                            }
                        }

                        LoadDanhSachDiaDiem();
                        ClearFields();
                        MessageBox.Show("Thêm địa điểm thành công!", "Thông báo");
                        
                    }

                }
                else
                {
                    MessageBox.Show("Vui lòng thêm danh sách địa điểm tham quan!", "Thông báo");
                    textBoxDiaDiemThamQuan.Focus();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập tên địa điểm đến!", "Thông báo");
                textBoxTenDiaDiemDen.Focus();
            }
        }

        public void ClearFields()
        {
            textBoxTenDiaDiemDen.Text = "";
            textBoxDiaDiemThamQuan.Text = "";
            listBoxDiaDiemThamQuan.Items.Clear();
        }

        //Dùng cho chức năng thêm
        public int GetMaxMaDiaDiemDen(List<diadiemden> list)
        {
            if (list.Count == 0)
            {
                throw new InvalidOperationException("Empty list");
            }
            int maxMaDiaDiemDen = 0;
            foreach (diadiemden type in list)
            {
                if (type.maDiaDiemDen > maxMaDiaDiemDen)
                {
                    maxMaDiaDiemDen = type.maDiaDiemDen;
                }
            }
            return maxMaDiaDiemDen;
        }

        private void XemChiTietDiaDiem()
        {
            foreach (DataGridViewRow row in dataGridViewDanhSachDiaDiem.SelectedRows)
            {
                if (!String.Equals(row.Cells[0].Value.ToString(), "System.Windows.Forms.DataGridViewTextBoxColumn"))
                {
                    string maDiaDiemDen = row.Cells[0].Value.ToString();
                    string tenDiaDiemDen = row.Cells[1].Value.ToString();

                    fmChiTietDiaDiem formChiTietDiaDiem = new fmChiTietDiaDiem(int.Parse(maDiaDiemDen), tenDiaDiemDen, this);
                    //System.Diagnostics.Debug.WriteLine(int.Parse(maSoTour));

                    formChiTietDiaDiem.ShowDialog();

                }

            }
        }

        public void TimKiemTenDiaDiem()
        {
            
            if (!String.IsNullOrWhiteSpace(textBoxTimKiem.Text))
            {
                string searchValue = textBoxTimKiem.Text;

                dataGridViewDanhSachDiaDiem.DataSource = b_DiaDiemDen.TimKiemTenDiaDiemDen(searchValue);
                
            }
            else
            {
                LoadDanhSachDiaDiem();
            }

        }

        private void buttonThemDDTQ_Click(object sender, EventArgs e)
        {
            ThemDiaDiemToListBox();
        }

        private void buttonXoaDDTQ_Click(object sender, EventArgs e)
        {
            XoaItemListBox();
        }

        //button xóa tất cả
        private void button1_Click(object sender, EventArgs e)
        {
            XoaTatCaItemListBox();
        }

        //button Thêm
        private void button2_Click(object sender, EventArgs e)
        {
            ThemMoiDiaDiem();
        }

        //button xem chi tiết
        private void button3_Click(object sender, EventArgs e)
        {
            XemChiTietDiaDiem();
        }

        private void fmQuanLyDiaDiem_Load(object sender, EventArgs e)
        {

        }

        private void textBoxDiaDiemThamQuan_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxTenDiaDiemDen_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxTimKiem_TextChanged(object sender, EventArgs e)
        {
            TimKiemTenDiaDiem();
        }

        


    }
}
