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
    public partial class fmChiTietDiaDiem : Form
    {
        B_diadiemden b_DiaDiemDen = new B_diadiemden();

        public fmChiTietDiaDiem(int maDiaDiemDen, string tenDiaDiemDen, fmQuanLyDiaDiem fmQuanLyDiaDiem)
        {
            InitializeComponent();
            this.maDiaDiemDen = maDiaDiemDen;
            this.tenDiaDiemDen = tenDiaDiemDen;
            fmMain = fmQuanLyDiaDiem;

            HienThiChiTietDiaDiem();

        }

        private fmQuanLyDiaDiem fmMain;
        public int maDiaDiemDen { get; set; } //Set data sẽ lấy từ form
        public string tenDiaDiemDen { get; set; }

        public void HienThiChiTietDiaDiem()
        {
            List<diadiemthamquan> listDetailsDDTQ = b_DiaDiemDen.GetListDetailsDiaDiemThamQuan(maDiaDiemDen);

            textBoxMaDiaDiemDen.Text = maDiaDiemDen.ToString();
            textBoxTenDiaDiemDen.Text = tenDiaDiemDen;

            //Xóa trước khi add new
            listBoxDiaDiemThamQuan.Items.Clear();

            foreach (var itemDDTQ in listDetailsDDTQ)
            {
                listBoxDiaDiemThamQuan.Items.Add(itemDDTQ.tenDiaDiem);
            }

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

        public void SuaThongTinDiaDiem()
        {
            List<diadiemthamquan> listDiaDiemThamQuan = b_DiaDiemDen.GetListDiaDiemThamQuan();

            if (!String.IsNullOrWhiteSpace(textBoxTenDiaDiemDen.Text))
            {
                if (listBoxDiaDiemThamQuan.Items.Count != 0)
                {
                    diadiemden objDiaDiemDen = new diadiemden();
                    diadiemthamquan objDiaDiemThamQuan = new diadiemthamquan();

                    objDiaDiemDen.tenDiaDiemDen = textBoxTenDiaDiemDen.Text;
                    objDiaDiemDen.trangThai = 1;

                    if (b_DiaDiemDen.SuaDiaDiemDen(objDiaDiemDen, maDiaDiemDen)) //Hàm sửa địa điểm đến
                    {
                        System.Diagnostics.Debug.WriteLine("Sửa địa điểm đến thành công!"); //debug write line

                        //Xóa địa điểm tham quan có mã địa điểm đến cũ trước khi sửa
                        foreach (var items in listDiaDiemThamQuan)
                        {
                            if (maDiaDiemDen == items.maDiaDiemDen)
                            {
                                
                                if (b_DiaDiemDen.XoaDiaDiemThamQuan(objDiaDiemThamQuan, items.maDiaDiem))
                                {
                                    System.Diagnostics.Debug.WriteLine("Xóa địa điểm tham quan cũ thành công!");
                                }
                            }
                        }

                        foreach (string item in listBoxDiaDiemThamQuan.Items)
                        {
                            objDiaDiemThamQuan.tenDiaDiem = item;
                            objDiaDiemThamQuan.maDiaDiemDen = maDiaDiemDen;

                            if (b_DiaDiemDen.ThemDiaDiemThamQuan(objDiaDiemThamQuan))
                            {
                                System.Diagnostics.Debug.WriteLine("Thêm địa điểm tham quan thành công!"); //debug write line

                            }
                        }

                        fmMain.LoadDanhSachDiaDiem();
                        MessageBox.Show("Sửa địa điểm thành công!", "Thông báo");

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

        private void buttonThemDDTQ_Click(object sender, EventArgs e)
        {
            ThemDiaDiemToListBox();
        }

        private void buttonXoaDDTQ_Click(object sender, EventArgs e)
        {
            XoaItemListBox();
        }

        private void buttonXoaTatCa_Click(object sender, EventArgs e)
        {
            XoaTatCaItemListBox();
        }

        private void buttonDong_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            SuaThongTinDiaDiem();
        }

    }
}
