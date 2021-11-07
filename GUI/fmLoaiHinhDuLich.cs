using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DAO;

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
                }catch(Exception e)
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
            if(dataGridViewLoaiHinhDuLich.SelectedRows.Count > 0)
            {
                foreach(DataGridViewRow row in dataGridViewLoaiHinhDuLich.SelectedRows)
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

        public void SuaLoaiHinhDuLich()
        {
            
            if (!String.IsNullOrEmpty(textBoxTenLoaiHinhDuLich.Text))
            {
                loaihinhdulich objLoaiHinhDuLich = new loaihinhdulich();
                objLoaiHinhDuLich.tenLoaiHinhDuLich = textBoxTenLoaiHinhDuLich.Text;
                try
                {
                    if (dataGridViewLoaiHinhDuLich.SelectedRows.Count > 0)
                    {
                        foreach (DataGridViewRow row in dataGridViewLoaiHinhDuLich.SelectedRows)
                        {
                            int maLoaiHinhDuLich = Convert.ToInt32(row.Cells[0].Value.ToString());
                            if (b_LoaiHinhDuLich.SuaLoaiHinhDuLich(objLoaiHinhDuLich, maLoaiHinhDuLich))
                            {
                                LoadLoaiHinhDuLich();
                                MessageBox.Show("Sửa thành công", "Thông báo");
                                ClearFields();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng chọn loại hình du lịch cần sửa", "Thông báo");
                    }
                    
                    

                }
                catch(Exception e)
                {
                    MessageBox.Show("Sửa không thành công", "Thông báo");
                    System.Diagnostics.Debug.WriteLine(e);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập tên loại hình du lịch", "Thông báo");
                textBoxTenLoaiHinhDuLich.Focus();
            }

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ThemLoaiHinhDuLich();
        }

        public void dataGridViewLoaiHinhDuLich_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //Lưu lại dòng dữ liệu vừa kích chọn
                DataGridViewRow row = this.dataGridViewLoaiHinhDuLich.Rows[e.RowIndex];
                //Đưa dữ liệu vào textbox
                
                textBoxTenLoaiHinhDuLich.Text = row.Cells[1].Value.ToString();
               
                //Không cho phép sửa trường STT
               // textBoxMaLoaiHinhDuLich.Enabled = false;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Bạn có chắc muốn xóa không?", "Xóa loại hình du lịch", MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                XoaLoaiHinhDuLich();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            SuaLoaiHinhDuLich();
        }
    }
}
