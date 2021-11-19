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
    public partial class fmKhachHang : Form
    {
        B_KH b_KH = new B_KH();
        public fmKhachHang()
        {
            InitializeComponent();
            LoadDSKH();

        }

        public void LoadDSKH()
        {
            dataGridViewQuanLyKH.DataSource = b_KH.GetKhachHang();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
          
        }

        public void ClearField()
        {
            textBoxTenKH.Text = " ";
            textBoxCMND.Text = " ";
            textBoxDiaChi.Text = " ";
            textBoxSDT.Text = " ";
            textBoxQuocTich.Text = " ";
            radioButtonNam.Checked = false;
            radioButtonNu.Checked = false;

        }
        public void ThemKhachHang()
        {
            if (!String.IsNullOrEmpty(textBoxTenKH.Text))
            {
                if (!String.IsNullOrEmpty(textBoxCMND.Text))
                {
                    if (!String.IsNullOrEmpty(textBoxDiaChi.Text))
                    {
                        if (!String.IsNullOrEmpty(textBoxSDT.Text))
                        {
                            if (!String.IsNullOrEmpty(textBoxQuocTich.Text))
                            {
                                try
                                    {
                                        khachhang objKhachHang = new khachhang();
                                        objKhachHang.hoTenKhachHang = textBoxTenKH.Text;
                                        objKhachHang.soCMND = textBoxCMND.Text;
                                        objKhachHang.diaChi = textBoxDiaChi.Text;
                                        objKhachHang.gioiTinh = radioButtonNam.Text;
                                        objKhachHang.gioiTinh = radioButtonNu.Text;
                                        objKhachHang.SDT = textBoxSDT.Text;
                                        objKhachHang.quocTich = textBoxQuocTich.Text;
                                        

                                        if (b_KH.ThemKhachHang(objKhachHang))
                                        {
                                            MessageBox.Show("Thêm khách hàng thành công", "Thông báo");
                                            LoadDSKH();
                                            ClearField();
                                        }
                                    }
                                    catch (Exception e)
                                    {
                                        MessageBox.Show("Thêm khách hàng không thành công", "Thông báo");
                                        System.Diagnostics.Debug.WriteLine(e);
                                    }
                                }
                               
                            
                            else
                            {
                                      MessageBox.Show("Vui lòng nhập quốc tịch", "Thông báo");
                                      textBoxQuocTich.Focus();
                            }
                        }
                        else
                         {
                               MessageBox.Show("Vui lòng nhập SDT", "Thông báo");
                                textBoxSDT.Focus();
                         }
                    }
                     else
                      {
                                 MessageBox.Show("Vui lòng nhập địa chỉ", "Thông báo");
                                 textBoxDiaChi.Focus();
                     }
                }
                else
                {
                       MessageBox.Show("Vui lòng nhập CMND", "Thông báo");
                        textBoxCMND.Focus();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập tên khách hàng", "Thông báo");
                textBoxTenKH.Focus();
            }
        
        }

    public void XoaKhachHang()
        {
            khachhang objKhachHang = new khachhang();
            if (dataGridViewQuanLyKH.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridViewQuanLyKH.SelectedRows)
                {
                    int maKhachHang = Convert.ToInt32(row.Cells[0].Value.ToString());
                    b_KH.XoaKhachHang(objKhachHang, maKhachHang);
                    LoadDSKH();
                    MessageBox.Show("Xóa thành công", "Thông báo");
                    ClearField();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần xóa", "Thông báo");
            }
        }

       

        public void SuaKhachHang()
        {
            if (!String.IsNullOrEmpty(textBoxTenKH.Text))
            {
                if (!String.IsNullOrEmpty(textBoxCMND.Text))
                {
                    if (!String.IsNullOrEmpty(textBoxDiaChi.Text))
                    {
                        if (!String.IsNullOrEmpty(textBoxSDT.Text))
                        {
                            if (!String.IsNullOrEmpty(textBoxQuocTich.Text))
                            {
                                try
                                {
                                    khachhang objKhachHang = new khachhang();
                                    objKhachHang.hoTenKhachHang = textBoxTenKH.Text;
                                    objKhachHang.soCMND = textBoxCMND.Text;
                                    objKhachHang.diaChi = textBoxDiaChi.Text;
                                    objKhachHang.gioiTinh = radioButtonNam.Text;
                                    objKhachHang.gioiTinh = radioButtonNu.Text;
                                    objKhachHang.SDT = textBoxSDT.Text;
                                    objKhachHang.quocTich = textBoxQuocTich.Text;
                                    if (dataGridViewQuanLyKH.SelectedRows.Count > 0)
                                    {
                                        foreach(DataGridViewRow row in dataGridViewQuanLyKH.SelectedRows)
                                        {
                                            int maSoKhachHang = Convert.ToInt32(row.Cells[0].Value.ToString());
                                            if (b_KH.SuaKhachHang(objKhachHang, maSoKhachHang))
                                            {
                                                LoadDSKH();
                                                MessageBox.Show("Sửa thông tin khách hàng thành công", "Thông báo");
                                                ClearField();
                                            }
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Vui lòng chọn khách hàng cần sửa", "Thông báo");
                                    }

                                }catch(Exception e)
                                {
                                    MessageBox.Show("Sửa thông tin khách hàng không thành công", "Thông báo");
                                    System.Diagnostics.Debug.WriteLine(e);
                                }

                            }
                            else
                            {
                                MessageBox.Show("Vui lòng nhập quốc tịch");
                                textBoxQuocTich.Focus();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Vui lòng nhập sdt");
                            textBoxSDT.Focus();
                        }
                    }
                    else 
                    {
                        MessageBox.Show("Vui lòng nhập địa chỉ");
                        textBoxDiaChi.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập CMND");
                    textBoxCMND.Focus();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập tên khách hàng");
                textBoxTenKH.Focus();
            }
        }



        

        

       

       

        
           

        private void dataGridViewQuanLyKH_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
                if (e.RowIndex > 0)
                {
                    DataGridViewRow row = this.dataGridViewQuanLyKH.Rows[e.RowIndex];

                    textBoxTenKH.Text = row.Cells[1].Value.ToString();
                    textBoxCMND.Text = row.Cells[2].Value.ToString();
                    textBoxDiaChi.Text = row.Cells[3].Value.ToString();
                string GioiTinh;
                GioiTinh = dataGridViewQuanLyKH.CurrentRow.Cells[4].Value.ToString().Trim();
                if (GioiTinh == "Nam")
                { 
                    radioButtonNam.Checked = true; 
                }
                else if(GioiTinh == "Nữ")
                { 
                    radioButtonNu.Checked = true; 
                }

                textBoxSDT.Text = row.Cells[5].Value.ToString();
                textBoxQuocTich.Text = row.Cells[6].Value.ToString();
                }
        }

        private void buttonTaoMoi_Click_1(object sender, EventArgs e)
        {
            ThemKhachHang();
        }

        private void buttonXoa_Click_1(object sender, EventArgs e)
        {
             var confirmResult = MessageBox.Show("Bạn có muốn xóa khách hàng không", "Thông báo", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                XoaKhachHang();
            }
        }

        private void buttonXemChiTiet_Click(object sender, EventArgs e)
        {
            SuaKhachHang();
        }

        private void btnLoaiKhachHang_Click(object sender, EventArgs e)
        {
            fmLoaiKhachHang fmLoaiKH = new fmLoaiKhachHang();
            fmLoaiKH.ShowDialog();
        }
    }
    }

