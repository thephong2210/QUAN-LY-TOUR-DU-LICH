using BUS;
using DAO;
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
    public partial class fmLoaiKhachHang : Form
    {
        B_LoaiKH b_loaiKH = new B_LoaiKH();
        public fmLoaiKhachHang()
        {
            
            InitializeComponent();
            LoadDanhSachLoaiKH();
        }
        public void LoadDanhSachLoaiKH()

        {
            dataGridViewLoaiKH.DataSource = b_loaiKH.GetLoaikhachhangs();

        }
        public void ClearFields()
        {
            textBoxTenLoaiKH.Text = "";

        }

        public bool KiemTraTT()
        {
            if (String.IsNullOrEmpty(textBoxTenLoaiKH.Text))
            {
                MessageBox.Show("Vui lòng nhập tên khách hàng", "Thông báo");
                textBoxTenLoaiKH.Focus();
                return false;
            }
            if (!Regex.IsMatch(textBoxTenLoaiKH.Text, @"^([a-zA-Z]+|[a-zA-Z]+\s[a-zA-Z]+)$"))
            {
                MessageBox.Show("Tên loại khách hàng không được có kí tự đặc biệt và số!", "Thông báo");
                textBoxTenLoaiKH.Focus();
                return false;
            }
            return true;
        }





        public void XoaLoaiKH()
        {
            loaikhachhang objLoaiKhachHang = new loaikhachhang();

            if (dataGridViewLoaiKH.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridViewLoaiKH.SelectedRows)
                {
                    int maLoaiKhachHang = Convert.ToInt32(row.Cells[0].Value.ToString());
                    b_loaiKH.XoaLoaiKH(objLoaiKhachHang, maLoaiKhachHang);
                    LoadDanhSachLoaiKH();
                    MessageBox.Show("Xóa thành công", "Thông báo");
                    ClearFields();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn loại khách hàng cần xóa", "Thông báo");
            }

        }




        public void XemChiTiet()
        {
            foreach (DataGridViewRow row in dataGridViewLoaiKH.SelectedRows) // lấy row đã click
            {
                if (!String.Equals(row.Cells[0].Value.ToString(), "System.Windows.Forms.DataGridViewTextBoxColumn"))
                {
                    string maLoaiKhachHang = row.Cells[0].Value.ToString();

                    fmChiTietLoaiKhachHang formChiTietLoaiKhachHang = new fmChiTietLoaiKhachHang(int.Parse(maLoaiKhachHang), this);

                    formChiTietLoaiKhachHang.ShowDialog();

                }
            }
        }

        public void ThemLoaiKH1()
        {
            if (KiemTraTT())
            {
                try
                {
                    loaikhachhang objLoaiKhachHang = new loaikhachhang();
                    objLoaiKhachHang.tenLoaiKhachHang = textBoxTenLoaiKH.Text;
                    if (b_loaiKH.ThemLoaiKH(objLoaiKhachHang))
                    {
                        MessageBox.Show("Thêm thành công", "Thông báo");
                        LoadDanhSachLoaiKH();
                        ClearFields();
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Thêm loại khách hàng không thành công", "Thông báo");
                    System.Diagnostics.Debug.WriteLine(e);
                }
            }

        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            ThemLoaiKH1();
        }

        private void btnXemChiTiet_Click(object sender, EventArgs e)
        {
            XemChiTiet();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Bạn có chắc muốn xóa loại khách hàng này", "Thông báo", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                XoaLoaiKH();
            }
        }
    }
}
