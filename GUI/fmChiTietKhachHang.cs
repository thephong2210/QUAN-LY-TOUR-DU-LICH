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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class fmChiTietKhachHang : Form
    {
        B_KH b_KhachHang = new B_KH();
        public fmChiTietKhachHang(int maSoKhachHang, fmKhachHang fmKH)
        {
            InitializeComponent();
            fmMain = fmKH;
            this.maSoKhachHang = maSoKhachHang;

            HienThiChiTietNhanVien();
        }
        private fmKhachHang fmMain;
        public int maSoKhachHang { get; set; }
        public void HienThiChiTietNhanVien()
        {

            List<dynamic> listDetailsKhachhang = b_KhachHang.GetListDetailsKhachHang(maSoKhachHang);

            //Convert List<dynamic> sang Datatable để dễ hiển thị chi tiết tour
            var json = JsonConvert.SerializeObject(listDetailsKhachhang);
            DataTable dataTableDetailsKhachHang = (DataTable)JsonConvert.DeserializeObject(json, (typeof(DataTable)));

            //Hiển thị
            textBoxMaKhachHang.Text = maSoKhachHang.ToString();
            textBoxTenKhachHang.Text = dataTableDetailsKhachHang.Rows[0][1].ToString();
            textBoxCMND.Text = dataTableDetailsKhachHang.Rows[0][2].ToString();
            textBoxDiaChi.Text = dataTableDetailsKhachHang.Rows[0][3].ToString();
            string GioiTinh;
            GioiTinh = dataTableDetailsKhachHang.Rows[0][4].ToString();
            if (GioiTinh == "Nam")
            {
                radioButtonNam.Checked = true;
            }
            else if (GioiTinh == "Nữ")
            {
                radioButtonNu.Checked = true;
            }
            textBoxSDT.Text = dataTableDetailsKhachHang.Rows[0][5].ToString();
            textBoxQuocTich.Text = dataTableDetailsKhachHang.Rows[0][6].ToString();

        }

        private bool KiemTraTT()
        {
            if (String.IsNullOrEmpty(textBoxTenKhachHang.Text))
            {
                MessageBox.Show("Vui lòng nhập tên khách hàng", "Thông báo");
                textBoxTenKhachHang.Focus();
                return false;
            }

            if (Regex.IsMatch(textBoxTenKhachHang.Text, @"[""!#$%&'()*+,-./:;<=>?@[\\\]^_`{|}~0-9]"))
            {
                MessageBox.Show("Tên khách hàng không có số và kí tự đặc biệt!", "Thông báo");
                textBoxTenKhachHang.Focus();
                return false;
            }

            if (String.IsNullOrEmpty(textBoxCMND.Text))
            {
                MessageBox.Show("Vui lòng nhập CMND", "Thông báo");
                textBoxCMND.Focus();
                return false;
            }

            if (!Regex.IsMatch(textBoxCMND.Text, @"^([0-9]{9})$"))
            {

                MessageBox.Show("Số CMND gồm 9 chữ số", "Thông báo");
                textBoxCMND.Focus();
                return false;
            }

            if (String.IsNullOrEmpty(textBoxDiaChi.Text))
            {
                MessageBox.Show("Vui lòng nhập địa chỉ", "Thông báo");
                textBoxDiaChi.Focus();
                return false;
            }

            if (Regex.IsMatch(textBoxDiaChi.Text, @"[""!#$%&'()*+,-.:;<=>?@[\\\]^_`{|}~]"))
            {
                MessageBox.Show("Vui lòng nhập địa chỉ không chứa kí tự đặc biệt", "Thông báo");
                textBoxDiaChi.Focus();
                return false;
            }

            if (radioButtonNam.Checked == false && radioButtonNu.Checked == false)
            {
                MessageBox.Show("Vui lòng chọn giới tính", "Thông báo");
                return false;
            }

            if (String.IsNullOrEmpty(textBoxSDT.Text))
            {
                MessageBox.Show("Vui lòng nhập số điện thoại", "Thông báo");
                textBoxSDT.Focus();
                return false;
            }

            if (!Regex.IsMatch(textBoxSDT.Text, @"^(0+[0-9]{9})$"))
            {
                MessageBox.Show("Số điện thoại gồm 10 chữ số và bắt đầu bằng 0", "Thông báo");
                textBoxSDT.Focus();
                return false;
            }
            if (String.IsNullOrEmpty(textBoxQuocTich.Text))
            {
                MessageBox.Show("Vui lòng nhập quốc tịch", "Thông báo");
                textBoxQuocTich.Focus();
                return false;
            }

            if (Regex.IsMatch(textBoxQuocTich.Text, @"[""!#$%&'()*+,-./:;<=>?@[\\\]^_`{|}~0-9]"))
            {
                MessageBox.Show("Quốc tịch không được có số và kí tự đặc biệt!", "Thông báo");
                textBoxQuocTich.Focus();
                return false;
            }
            return true;
        }
        public void SuaKhachHang()
        {
            if (KiemTraTT())
            {
                try
                {
                    khachhang objKhachHang = new khachhang();
                    objKhachHang.hoTenKhachHang = textBoxTenKhachHang.Text;
                    objKhachHang.soCMND = textBoxCMND.Text;
                    objKhachHang.diaChi = textBoxDiaChi.Text;


                    if (radioButtonNam.Checked == true)
                    {
                        objKhachHang.gioiTinh = radioButtonNam.Text;
                    }
                    else if (radioButtonNu.Checked == true)
                    {
                        objKhachHang.gioiTinh = radioButtonNu.Text;
                    }
                    objKhachHang.SDT = textBoxSDT.Text;
                    objKhachHang.quocTich = textBoxQuocTich.Text;
                    objKhachHang.trangThai = 1;
                    if (b_KhachHang.SuaKhachHang(objKhachHang, maSoKhachHang))
                    {
                        fmMain.LoadDSKH();
                        MessageBox.Show("Sửa thông tin khách hàng thành công", "Thông báo");

                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Sửa thông tin khách hàng không thành công", "Thông báo");
                    System.Diagnostics.Debug.WriteLine(e);
                }
            }
        }


        private void buttonSua_Click(object sender, EventArgs e)
        {
            SuaKhachHang();
        }

        private void buttonDong_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
