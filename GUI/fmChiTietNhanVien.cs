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
    public partial class fmChiTietNhanVien : Form
    {
        B_nhanvien bNhanVien = new B_nhanvien();

        public fmChiTietNhanVien(int maNhanVien, fmNhanVien fmNV) // ??
        {
            InitializeComponent();
            fmMain = fmNV;
            this.maNhanVien = maNhanVien;

            HienThiChiTietNhanVien();
        }

        private fmNhanVien fmMain;
        public int maNhanVien { get; set; } //Set data sẽ lấy từ form quản lý tour

        // Hiển thị chi tiết nhân viết
        private void HienThiChiTietNhanVien()
        {
            List<dynamic> listDetailsNhanVien = bNhanVien.GetListDetailsNhanVien(maNhanVien);

            //Convert List<dynamic> sang Datatable để dễ hiển thị chi tiết tour
            var json = JsonConvert.SerializeObject(listDetailsNhanVien);
            DataTable dataTableDetailsNhanVien = (DataTable)JsonConvert.DeserializeObject(json, (typeof(DataTable)));

            //Hiển thị
            textBoxMaNhanVien.Text = maNhanVien.ToString();
            textBoxTenNhanVien.Text = dataTableDetailsNhanVien.Rows[0][1].ToString();
            textBoxNhiemVu.Text = dataTableDetailsNhanVien.Rows[0][2].ToString();
        }

        // Sửa nhân viên
        public void SuaNhanVien()
        {
            if (!String.IsNullOrEmpty(textBoxTenNhanVien.Text))
            {
                if (!String.IsNullOrEmpty(textBoxNhiemVu.Text))
                {
                    
                        //Khai báo object
                        nhanvien objNhanVien = new nhanvien();

                        objNhanVien.tenNhanVien = textBoxTenNhanVien.Text;
                        objNhanVien.nhiemVu = textBoxNhiemVu.Text;

                        //Bắt đầu sửa các dữ liệu
                        try
                        {
                            if (bNhanVien.SuaNhanVien(objNhanVien, maNhanVien))
                            {
                                System.Diagnostics.Debug.WriteLine("Sửa nhân viên thành công!");

                                fmMain.LoadDanhSachNhanVien();
                                MessageBox.Show("Sửa nhân viên thành công!", "Thông báo");
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
                    MessageBox.Show("Vui lòng nhập đặc điểm tour!", "Thông báo");
                    textBoxNhiemVu.Focus();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập tên tour!", "Thông báo");
                textBoxTenNhanVien.Focus();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonDong_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            SuaNhanVien();
        }

        private void textBoxNhiemVu_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
