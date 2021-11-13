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
            textBoxTenLoaiKH.Text = " ";
        }

        

        public void ThemLoaiKH()
        {
            
            if (!String.IsNullOrEmpty(textBoxTenLoaiKH.Text))
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
                }catch(Exception e)
                {
                    MessageBox.Show("Thêm không thành công", "Thông báo");
                    System.Diagnostics.Debug.WriteLine(e);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập tên loại khách hàng", "Thông báo");
                textBoxTenLoaiKH.Focus();
            }
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


        public void SuaLoaiKH()
        {

            if (!String.IsNullOrEmpty(textBoxTenLoaiKH.Text))
            {
                loaikhachhang objLoaiKhachHang= new loaikhachhang();
                objLoaiKhachHang.tenLoaiKhachHang = textBoxTenLoaiKH.Text;
                try
                {
                    if (dataGridViewLoaiKH.SelectedRows.Count > 0)
                    {

                        foreach (DataGridViewRow row in dataGridViewLoaiKH.SelectedRows)
                        {
                            int maLoaiKhachHang = Convert.ToInt32(row.Cells[0].Value.ToString());

                            if (b_loaiKH.SuaLoaiKH(objLoaiKhachHang, maLoaiKhachHang))
                            {
                                LoadDanhSachLoaiKH();
                                MessageBox.Show("Sửa thành công", "Thông báo");
                                ClearFields();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng chọn loại khách hàng cần sửa", "Thông báo");
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Sửa không thành công", "Thông báo");
                    System.Diagnostics.Debug.WriteLine(e);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập tên loại khách hàng", "Thông báo");
                textBoxTenLoaiKH.Focus();
            }
        }

        

        private void btnThem_Click(object sender, EventArgs e)
        {
            ThemLoaiKH();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Bạn có chắc muốn xóa loại khách hàng này", "Thông báo", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                XoaLoaiKH();
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            SuaLoaiKH();
        }

       

        private void dataGridViewLoaiKH_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //Lưu lại dòng dữ liệu vừa kích chọn
                DataGridViewRow row = this.dataGridViewLoaiKH.Rows[e.RowIndex];
                //Đưa dữ liệu vào textbox
             
                textBoxTenLoaiKH.Text = row.Cells[1].Value.ToString();

                //Không cho phép sửa trường STT
                //textBoxMaLoaiKH.Enabled = false;
            }
        }

        private void panelLeft_Paint(object sender, PaintEventArgs e)
        {

        }
    }

    

        
       

       

       
    }



