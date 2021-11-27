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
        public void ThemLoaiHinhDuLich()
        {
            if (!String.IsNullOrEmpty(textBoxTenLoaiHinhDuLich.Text))
            {
                try
                {
                    loaihinhdulich objLoaiHinhDuLich = new loaihinhdulich();
                    objLoaiHinhDuLich.tenLoaiHinhDuLich = textBoxTenLoaiHinhDuLich.Text;
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
            else
            {
                MessageBox.Show("Vui lòng nhập tên loại hình du lịch", "Thông báo");
                textBoxTenLoaiHinhDuLich.Focus();
            }
        }

        public void XoaLoaiHinhDuLich()
        {
            loaihinhdulich objLoaiHinhDuLich = new loaihinhdulich();
            if (dataGridViewLoaiHinhDuLich.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridViewLoaiHinhDuLich.SelectedRows)
                {
                    int maLoaiHinhDuLich = Convert.ToInt32(row.Cells[0].Value.ToString());
                    b_LoaiHinhDuLich.XoaLoaiHinhDuLich(objLoaiHinhDuLich, maLoaiHinhDuLich);
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
        public void XemChiTiet()
        {
            foreach (DataGridViewRow row in dataGridViewLoaiHinhDuLich.SelectedRows) // lấy row đã click
            {
                if (!String.Equals(row.Cells[0].Value.ToString(), "System.Windows.Forms.DataGridViewTextBoxColumn"))
                {
                    string maLoaiHinhDuLich = row.Cells[0].Value.ToString();

                    fmChiTietLoaiHinhDuLich formChiTietLoaiHinhDuLich = new fmChiTietLoaiHinhDuLich(int.Parse(maLoaiHinhDuLich), this);

                    formChiTietLoaiHinhDuLich.ShowDialog();

                }
            }
        }



        private void btnThem_Click(object sender, EventArgs e)
        {
            ThemLoaiHinhDuLich1();
        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            XemChiTiet();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Bạn có chắc muốn xóa không?", "Xóa loại hình du lịch", MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                XoaLoaiHinhDuLich();
            }
        }
    }
}
