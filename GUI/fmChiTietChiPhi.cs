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
    public partial class fmChiTietChiPhi : Form
    {
        D_chiphi DChiPhi = new D_chiphi();
        D_LoaiChiPhi DLoaiChiPhi = new D_LoaiChiPhi();

        public fmChiTietChiPhi(int maDoan, fmChitietDoan fmCTDoan) //gọi fmChiTietDoan để load tổng số chi phí
        {
            InitializeComponent();
            fmMain = fmCTDoan;
            this.maDoan = maDoan;

            HienThiBangChiPhi();
            LoadComboboxLoaiChiPhi();
            textBoxMaSoDoan.Text = maDoan.ToString();
        }

        private fmChitietDoan fmMain;
        public int maDoan { get; set; } //Set data

        public void HienThiBangChiPhi()
        {
            dataGridViewLoaiCP.DataSource = DChiPhi.GetListChiPhiMaDoanOnView(maDoan);
            dataGridViewLoaiCP.AutoGenerateColumns = false;

            dataGridViewLoaiCP.Columns["tongChiPhi"].DefaultCellStyle.Format = "#,##0";
        }

        // Hiển thị chi tiết
        public void LoadComboboxLoaiChiPhi()
        {
            comboBoxLoaiChiPhi.DataSource = DLoaiChiPhi.GetLoaiChiPhi();
            comboBoxLoaiChiPhi.DisplayMember = "tenLoaiChiPhi";
            comboBoxLoaiChiPhi.ValueMember = "maLoaiChiPhi";
            
        }

        public void ThemChiPhi()
        {
            if (!String.IsNullOrWhiteSpace(textBoxTongChiPhi.Text))
            {
                if (CheckTrungLoaiChiPhi())
                {
                    try
                    {
                        chiphi objChiPhi = new chiphi();

                        objChiPhi.tenChiPhi = comboBoxLoaiChiPhi.Text;
                        objChiPhi.tongChiPhi = Convert.ToDouble(textBoxTongChiPhi.Text);
                        objChiPhi.maSoDoan = maDoan;
                        objChiPhi.trangThai = 1;

                        if (DChiPhi.ThemChiPhi(objChiPhi))
                        {
                            HienThiBangChiPhi();
                            fmMain.LoadChiTietDoan();
                            MessageBox.Show("Thêm chi phí thành công!", "Thông báo");
                        }
                    }
                    catch (FormatException ex)
                    {
                        MessageBox.Show("Tổng chi phí chỉ được nhập số!", "Thông báo");
                        System.Diagnostics.Debug.WriteLine(ex);
                    }
                   
                }
                else
                {
                    MessageBox.Show("Loại chi phí này đã thêm rồi! Vui lòng thêm loại chi phí khác!", "Thông báo");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập tổng chi phí!","Thông báo");
            }
                
            
        }

        public bool CheckTrungLoaiChiPhi()
        {
            List<chiphi> listChiPhi = DChiPhi.GetListChiPhiWithMaDoan(maDoan);

            foreach (var item in listChiPhi)
            {
                if (comboBoxLoaiChiPhi.Text.Equals(item.tenChiPhi))
                {
                    return false;
                }
                
            }

            return true;
        }


        private void fmChiTietChiPhi_Load(object sender, EventArgs e)
        {
            HienThiBangChiPhi();
        }
        

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonThemKhachHang_Click(object sender, EventArgs e)
        {
            fmLoaiChiPhi fmLoaiCP = new fmLoaiChiPhi(this);
            fmLoaiCP.ShowDialog();
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {

        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            ThemChiPhi();
        }

        private void buttonSua_Click_1(object sender, EventArgs e)
        {
            if (dataGridViewLoaiCP.SelectedRows.Count != -1)
            {
                foreach (DataGridViewRow row in dataGridViewLoaiCP.SelectedRows)
                {
                    if (!String.Equals(row.Cells[0].Value.ToString(), "System.Windows.Forms.DataGridViewTextBoxColumn"))
                    {
                        string id = row.Cells[0].Value.ToString();

                        fmSuaChiPhi fmSCP = new fmSuaChiPhi(int.Parse(id), this, fmMain);
                        System.Diagnostics.Debug.WriteLine(int.Parse(id));

                        fmSCP.ShowDialog();

                    }
                   
                }
                
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng muốn sửa!", "Thông báo");
            }


        }

        public void XoaChiPhi()
        {
            if (dataGridViewLoaiCP.SelectedRows.Count != -1)
            {
                foreach (DataGridViewRow row in dataGridViewLoaiCP.SelectedRows)
                {
                    if (!String.Equals(row.Cells[0].Value.ToString(), "System.Windows.Forms.DataGridViewTextBoxColumn"))
                    {
                        int id = Convert.ToInt32(row.Cells[0].Value.ToString());

                        if (DChiPhi.XoaChiPhi(id))
                        {
                            HienThiBangChiPhi();
                            fmMain.LoadChiTietDoan();
                            MessageBox.Show("Xóa thành công!", "Thông báo");
                        }

                    }

                }

            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng muốn xóa!", "Thông báo");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Bạn có chắc muốn xóa không ?? :D", "Xác nhận xóa", MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                XoaChiPhi();
            }
                
        }

        private void textBoxTongChiPhi_Leave(object sender, EventArgs e)
        {
            

        }
    }

}
