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
    public partial class fmLoaiChiPhi : Form
    {
        B_LoaiChiPhi b_loaiChiPhi = new B_LoaiChiPhi();
        private fmChiTietChiPhi fmCTChiPhi;
        public fmLoaiChiPhi(fmChiTietChiPhi fmCTChiPhi)
        {
            
            InitializeComponent();
            this.fmCTChiPhi = fmCTChiPhi;
            LoadDanhSachLoaiChiPhi();
        }
        public void LoadDanhSachLoaiChiPhi()

        {
            dataGridViewLoaiCP.DataSource = b_loaiChiPhi.GetLoaiChiPhi();
            dataGridViewLoaiCP.AutoGenerateColumns = false;
        }
        public void ClearFields()
        {
            textBoxTenLoaiCP.Text = "";

        }

        public bool KiemTraTT()
        {
            if (String.IsNullOrEmpty(textBoxTenLoaiCP.Text))
            {
                MessageBox.Show("Vui lòng nhập tên loại chi phí", "Thông báo");
                textBoxTenLoaiCP.Focus();
                return false;
            }
            if (Regex.IsMatch(textBoxTenLoaiCP.Text, @"[""!#$%&'()*+,-./:;<=>?@[\\\]^_`{|}~0-9]"))
            {
                MessageBox.Show("Tên loại không được có số và kí tự đặc biệt!", "Thông báo");
                textBoxTenLoaiCP.Focus();
                return false;
            }
            return true;
        }



        public void XoaLoaiChiPhi()
        {
            
            if (dataGridViewLoaiCP.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridViewLoaiCP.SelectedRows)
                {
                    int maLoaiChiPhi = Convert.ToInt32(row.Cells[0].Value.ToString());
                    b_loaiChiPhi.XoaLoaiChiPhi(maLoaiChiPhi);
                    LoadDanhSachLoaiChiPhi();
                    fmCTChiPhi.HienThiBangChiPhi();
                    fmCTChiPhi.LoadComboboxLoaiChiPhi();
                    MessageBox.Show("Xóa thành công", "Thông báo");
                    ClearFields();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn loại chi phí cần xóa", "Thông báo");
            }

        }


        public void ThemLoaiChiPhi()
        {
            if (KiemTraTT())
            {
                try
                {
                    loaichiphi objLoaiChiPhi= new loaichiphi();
                    objLoaiChiPhi.tenLoaiChiPhi = textBoxTenLoaiCP.Text;
                    objLoaiChiPhi.trangThai = 1;
                    if (b_loaiChiPhi.ThemLoaiChiPhi(objLoaiChiPhi))
                    {
                        LoadDanhSachLoaiChiPhi();
                        ClearFields();
                        fmCTChiPhi.HienThiBangChiPhi();
                        fmCTChiPhi.LoadComboboxLoaiChiPhi();
                        MessageBox.Show("Thêm thành công", "Thông báo");
                       
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Thêm loại chi phí không thành công", "Thông báo");
                    System.Diagnostics.Debug.WriteLine(e);
                }
            }

        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            ThemLoaiChiPhi();
        }

        private void btnXemChiTiet_Click(object sender, EventArgs e)
        {
      
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Bạn có chắc muốn xóa loại chi phí này?", "Thông báo", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                XoaLoaiChiPhi();
                fmCTChiPhi.HienThiBangChiPhi();
            }
        }
        public void TimKiemTenLoaiChiPhi()
        {

            if (!String.IsNullOrWhiteSpace(textBoxTimKiem.Text))
            {
                string searchValue = textBoxTimKiem.Text;
                dataGridViewLoaiCP.DataSource = b_loaiChiPhi.TimKiemTenLoaiChiPhi(searchValue);
            }
            else
            {
                LoadDanhSachLoaiChiPhi();
            }

        }
        private void textBoxTimKiem_TextChanged(object sender, EventArgs e)
        {
            TimKiemTenLoaiChiPhi();
        }
    }
}
