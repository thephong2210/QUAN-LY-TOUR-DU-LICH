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
        B_loaichiphi b_LoaiChiPhi = new B_loaichiphi();
        public fmLoaiChiPhi()
        {
            InitializeComponent();
            LoadLoaiChiPhi();

        }
        public void LoadLoaiChiPhi()
        {
            dataGridViewLoaiHinhDuLich.DataSource = b_LoaiChiPhi.GetListLoaiChiPhi();
        }

        public void ClearFields()
        {
            textBoxTenLoaiHinhDuLich.Text = "";

        }
        public bool KiemTraTT()
        {
            if (String.IsNullOrEmpty(textBoxTenLoaiHinhDuLich.Text))
            {
                MessageBox.Show("Vui lòng nhập tên loại", "Thông báo");
                textBoxTenLoaiHinhDuLich.Focus();
                return false;
            }
            if (Regex.IsMatch(textBoxTenLoaiHinhDuLich.Text, @"[""!#$%&'()*+,-./:;<=>?@[\\\]^_`{|}~0-9]"))
            {
                MessageBox.Show("Tên loại không được có số và kí tự đặc biệt!", "Thông báo");
                textBoxTenLoaiHinhDuLich.Focus();
                return false;
            }
            return true;
        }
        public void ThemLoaiChiPhi()
        {
            if (KiemTraTT())
            {
                try
                {
                    loaichiphi objLoai = new loaichiphi();
                    objLoai.tenLoaiChiPhi = textBoxTenLoaiHinhDuLich.Text;
                    objLoai.trangThai = 1;
                    if (b_LoaiChiPhi.ThemLoaiChiPhi(objLoai))
                    {
                        MessageBox.Show("Thêm loại chi phí thành công", "Thông báo");
                        LoadLoaiChiPhi();
                        ClearFields();

                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Thêm loại chi phí không thành công", "Thông báo");
                    System.Diagnostics.Debug.WriteLine(e);
                }
            }
        }
       

        public void XoaLoaiChiPhi()
        {
            
            if (dataGridViewLoaiHinhDuLich.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridViewLoaiHinhDuLich.SelectedRows)
                {
                    int maLoai = Convert.ToInt32(row.Cells[0].Value.ToString());
                    b_LoaiChiPhi.XoaLoaiChiPhi(maLoai);
                    LoadLoaiChiPhi();
                    MessageBox.Show("Xóa thành công", "Thông báo");
                    ClearFields();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn loại chi phí cần xóa", "Thông báo");
            }
        }
        



        private void btnThem_Click(object sender, EventArgs e)
        {
            ThemLoaiChiPhi();
        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
       
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Bạn có chắc muốn xóa không?", "Xóa loại hình du lịch", MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                XoaLoaiChiPhi();
            }
        }

        private void fmLoaiChiPhi_Load(object sender, EventArgs e)
        {

        }

        private void dataGridViewLoaiHinhDuLich_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {

        }

        private void dataGridViewLoaiHinhDuLich_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {

        }
    }
}
