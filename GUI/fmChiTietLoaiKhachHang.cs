using BUS;
using DAO;
using Newtonsoft.Json;
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
    public partial class fmChiTietLoaiKhachHang : Form
    {
        B_LoaiKH b_LoaiKH = new B_LoaiKH();
        public fmChiTietLoaiKhachHang(int maLoaiKhachHang, fmLoaiKhachHang fmLKH)
        {
            InitializeComponent();

            fmMain = fmLKH;
            this.maLoaiKhachHang = maLoaiKhachHang;

            HienThiChiTietLoaiKhachHang();
        }

        private fmLoaiKhachHang fmMain;
        public int maLoaiKhachHang { get; set; }

        public void HienThiChiTietLoaiKhachHang()
        {
            List<dynamic> listDetailsLoaiKhachHang = b_LoaiKH.GetListDetailsLoaiKhachHang(maLoaiKhachHang);

            //Convert List<dynamic> sang Datatable để dễ hiển thị chi tiết tour
            var json = JsonConvert.SerializeObject(listDetailsLoaiKhachHang);
            DataTable dataTableDetailsLoaiKhachHang = (DataTable)JsonConvert.DeserializeObject(json, (typeof(DataTable)));

            //Hiển thị
            textBoxMaLoaiKhachHang.Text = maLoaiKhachHang.ToString();
            textBoxTenLoaiKhachHang.Text = dataTableDetailsLoaiKhachHang.Rows[0][1].ToString();

        }
        public bool KiemTraTT()
        {
            if (String.IsNullOrEmpty(textBoxTenLoaiKhachHang.Text))
            {
                MessageBox.Show("Vui lòng nhập tên khách hàng", "Thông báo");
                textBoxTenLoaiKhachHang.Focus();
                return false;
            }
            return true;
        }
        public void SuaLoaiKhachHang()
        {
            if (KiemTraTT())
            {

                try
                {
                    loaikhachhang objLoaiKhachHang = new loaikhachhang();
                    objLoaiKhachHang.tenLoaiKhachHang = textBoxTenLoaiKhachHang.Text;
                    if (b_LoaiKH.SuaLoaiKH(objLoaiKhachHang, maLoaiKhachHang))
                    {
                        fmMain.LoadDanhSachLoaiKH();
                        MessageBox.Show("Sửa thông tin loại khách hàng thành công", "Thông báo");

                    }

                }
                catch (Exception e)
                {
                    MessageBox.Show("Sửa thông tin loại khách hàng không thành công", "Thông báo");
                    System.Diagnostics.Debug.WriteLine(e);
                }
            }
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            SuaLoaiKhachHang();
        }

        private void buttonDong_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
