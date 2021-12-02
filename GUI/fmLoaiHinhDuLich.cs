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
    public partial class fmLoaiHinhDuLich : Form
    {
        B_loaihinhdulich b_LoaiHinhDuLich = new B_loaihinhdulich();
        public fmLoaiHinhDuLich()
        {
            InitializeComponent();
            LoadLoaiHinhDuLich();

        }
        public void LoadLoaiHinhDuLich()
        {
            dataGridViewLoaiHinhDuLich.DataSource = b_LoaiHinhDuLich.GetListLoaiHinhDL();
            dataGridViewLoaiHinhDuLich.AutoGenerateColumns = false;
        }

        public void ClearFields()
        {
            textBoxTenLoaiHinhDuLich.Text = "";

        }
        public bool KiemTraTT()
        {
            if (String.IsNullOrEmpty(textBoxTenLoaiHinhDuLich.Text))
            {
                MessageBox.Show("Vui lòng nhập tên loại hình du lịch", "Thông báo");
                textBoxTenLoaiHinhDuLich.Focus();
                return false;
            }
            if (Regex.IsMatch(textBoxTenLoaiHinhDuLich.Text, @"[""!#$%&'()*+,-./:;<=>?@[\\\]^_`{|}~0-9]"))
            {
                MessageBox.Show("Tên loại hình du lịch không được có số và kí tự đặc biệt!", "Thông báo");
                textBoxTenLoaiHinhDuLich.Focus();
                return false;
            }
            return true;
        }
        public void ThemLoaiHinhDuLich1()
        {
            if (KiemTraTT())
            {
                try
                {
                    loaihinhdulich objLoaiHinhDuLich = new loaihinhdulich();
                    objLoaiHinhDuLich.tenLoaiHinhDuLich = textBoxTenLoaiHinhDuLich.Text;
                    objLoaiHinhDuLich.trangThai = 1;
                    if (b_LoaiHinhDuLich.ThemLoaiHinhDuLich(objLoaiHinhDuLich))
                    {
                        MessageBox.Show("Thêm loại hình du lịch thành công", "Thông báo");
                        LoadLoaiHinhDuLich();
                        ClearFields();

                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Thêm loại hình du lịch không thành công", "Thông báo");
                    System.Diagnostics.Debug.WriteLine(e);
                }
            }
        }
       

        public void XoaLoaiHinhDuLich()
        {
            
            if (dataGridViewLoaiHinhDuLich.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridViewLoaiHinhDuLich.SelectedRows)
                {
                    int maLoaiHinhDuLich = Convert.ToInt32(row.Cells[0].Value.ToString());
                    b_LoaiHinhDuLich.XoaLoaiHinhDuLich(maLoaiHinhDuLich);
                    LoadLoaiHinhDuLich();
                    MessageBox.Show("Xóa thành công", "Thông báo");
                    ClearFields();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn loại hình du lịch cần xóa", "Thông báo");
            }
        }
        



        private void btnThem_Click(object sender, EventArgs e)
        {
            ThemLoaiHinhDuLich1();
        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
       
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Bạn có chắc muốn xóa không?", "Xóa loại hình du lịch", MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                XoaLoaiHinhDuLich();
            }
        }

        private void fmLoaiHinhDuLich_Load(object sender, EventArgs e)
        {

        }
        public void TimKiemTenLoaiHinhDuLich()
        {

            if (!String.IsNullOrWhiteSpace(textBoxTimKiem.Text))
            {
                string searchValue = textBoxTimKiem.Text;
                dataGridViewLoaiHinhDuLich.DataSource = b_LoaiHinhDuLich.TimKiemTenLoaiHinhDuLich(searchValue);
            }
            else
            {
                LoadLoaiHinhDuLich();
            }

        }
        private void textBoxTimKiem_TextChanged(object sender, EventArgs e)
        {
            TimKiemTenLoaiHinhDuLich();
        }
    }
}
