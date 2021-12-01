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
using BUS;
using DAO;


namespace GUI
{
    public partial class fmQLDoan : Form
    {
        B_doan b_Doan = new B_doan();
        B_tour bTour = new B_tour();
        D_doan d_Doan = new D_doan();
        B_chiphi b_chiphi = new B_chiphi();


        public fmQLDoan()
        {
            InitializeComponent();
            LoadDanhSachDoan();
            LoadComboBoxTour();
        }


        #region method

        public void LoadDanhSachDoan()
        {
            dataGridViewQuanLyDoan.DataSource = b_Doan.GetListDoan();

        }
        private void LoadComboBoxTour()
        {
            comboBoxTour.DataSource = bTour.GetListTour();
            comboBoxTour.DisplayMember = "tenGoiTour";
            comboBoxTour.ValueMember = "maSoTour";
        }

        public doandulich createDoan()
        {
            String tenDoan = textBoxTenDoan.Text;
            int maTour = (int)comboBoxTour.SelectedValue;// return ma tour
            DateTime ngayBatDau = DateTime.Parse(dateTimePickerNgayBatDau.Value.Date.ToString("yyyy-MM-dd hh:mm:ss.ss"));
            DateTime ngayKetThuc = DateTime.Parse(dateTimePickerNgayKetThuc.Value.Date.ToString("yyyy-MM-dd hh:mm:ss.ss"));
            String chiTiet = textBoxChiTiet.Text;
            doandulich objDoan = new doandulich();
            objDoan.tenGoiDoan = tenDoan;
            objDoan.maSoTour = maTour;
            objDoan.thoiGianKhoiHanh = ngayBatDau;
            objDoan.thoiGianKetThuc = ngayKetThuc;
            objDoan.soLuongKhachHang = 0;
            objDoan.SoLuongNhanVien = 0;
            objDoan.chiTiet = chiTiet;
            objDoan.trangThai = 1;
            return objDoan;
        }

        public void ThemDoan()
        {
            if (!String.IsNullOrWhiteSpace(textBoxTenDoan.Text))
            {
                if (listBoxChiPhi.Items.Count != 0)
                {
                    List<doandulich> listDoanAll = b_Doan.GetAllDoan();
                    b_Doan.ThemDoan(createDoan());

                    foreach (string item in listBoxChiPhi.Items)
                    {
                        chiphi objChiPhi = new chiphi();
                        string[] words = item.Split(';');

                        objChiPhi.tenChiPhi = words[0];
                        objChiPhi.tongChiPhi = Convert.ToDouble(words[1]);
                        objChiPhi.maSoDoan = GetMaxMaSoDoan(listDoanAll) + 1; //get maSoDoan new
                        objChiPhi.trangThai = 1;

                        if (b_chiphi.ThemLoaiChiPhi(objChiPhi))
                        {
                            System.Diagnostics.Debug.WriteLine("Thêm chi phí thành công!"); //debug write line

                        }
                    }


                    LoadDanhSachDoan();
                    MessageBox.Show("Thêm thành công!", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Vui lòng thêm ít nhất 1 chi phí!", "Thông báo");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập tên đoàn!", "Thông báo");
                textBoxTenDoan.Focus();
            }

        }

        public bool CheckTextChiPhi()
        {
            Regex regex = new Regex(@"[a-zA-Z][;][0-9]");

            if (regex.IsMatch(textBoxChiPhi.Text))
            {
                return true;
            }

            return false;
        }

        //Dùng cho chức năng thêm chi phí
        public int GetMaxMaSoDoan(List<doandulich> list)
        {
            if (list.Count == 0)
            {
                throw new InvalidOperationException("Empty list");
            }
            int maxMaSoDoann = 0;
            foreach (doandulich type in list)
            {
                if (type.maSoDoan > maxMaSoDoann)
                {
                    maxMaSoDoann = type.maSoDoan;
                }
            }
            return maxMaSoDoann;
        }

        public void XoaDoan()
        {


            if (dataGridViewQuanLyDoan.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridViewQuanLyDoan.SelectedRows)
                {
                    int maSoDoan = Convert.ToInt32(row.Cells[0].Value.ToString());
                    b_Doan.XoaDoan(maSoDoan);
                    LoadDanhSachDoan();
                    MessageBox.Show("Xóa thành công!", "Thông báo");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn đoàn muốn xóa!", "Thông báo");
            }
        }
        
        void XemChiTietDoan()
        {
            foreach (DataGridViewRow row in dataGridViewQuanLyDoan.SelectedRows)
            {
                String maDoan = row.Cells[0].Value.ToString();
                //_tourGroupNameLb.Text = row.Cells[1].Value.ToString();
                //_tourNameLb.Text = row.Cells[2].Value.ToString();
                //_departDateLb.Text = row.Cells[3].Value.ToString();
                //_returnDateLb.Text = row.Cells[4].Value.ToString();

                fmChitietDoan fmChitietDoan = new fmChitietDoan(int.Parse(maDoan), this);
                fmChitietDoan.ShowDialog();

            }
        }
        #endregion method
        #region event


        private void buttonXoa_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Bạn có chắc muốn xóa không ?? :D", "Thông báo", MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                XoaDoan();
            }
           
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            LoadDanhSachDoan();
        }

        private void buttonXemChiTiet_Click(object sender, EventArgs e)
        {
            XemChiTietDoan();
        }

        private void dataGridViewQuanLyDoan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void buttonTaoMoi_Click(object sender, EventArgs e)
        {
            ThemDoan();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBoxTenDoan_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
          
        }
        public void ThemChiPhiToListBox()
        {
            string tenChiPhi = textBoxChiPhi.Text;

            if (!String.IsNullOrWhiteSpace(tenChiPhi))
            {
                if (CheckTextChiPhi())
                {
                    if (listBoxChiPhi.Items.Contains(tenChiPhi))
                    {
                        MessageBox.Show("Chi phí này đã có trong danh sách! Mời nhập chi phí khác!", "Thông báo");
                    }
                    else
                    {
                        listBoxChiPhi.Items.Add(textBoxChiPhi.Text);
                        textBoxChiPhi.Text = "";
                        textBoxChiPhi.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Chi phí không đúng định dạng!\nĐịnh dạng đúng: (tên chi phí);(tổng chi phí)", "Thông báo");
                }
                
            }
            else
            {
                MessageBox.Show("Vui lòng nhập tên địa điểm tham quan!", "Thông báo");
            }
        }

        public void XoaItemListBox()
        {
            if (listBoxChiPhi.SelectedIndex != -1)
            {
                string removeItem = listBoxChiPhi.SelectedItem.ToString();
                listBoxChiPhi.Items.Remove(removeItem);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn địa điểm muốn xóa!", "Thông báo");
            }
        }

        public void XoaTatCaItemListBox()
        {
            if (listBoxChiPhi.Items.Count != 0)
            {
                var confirmResult = MessageBox.Show("Bạn có chắc muốn xóa tất cả không ?? :D", "Thông báo", MessageBoxButtons.YesNo);

                if (confirmResult == DialogResult.Yes)
                {
                    listBoxChiPhi.Items.Clear();
                }
            }
            else
            {
                MessageBox.Show("Danh sách trống!", "Thông báo");
            }
        }
        private void buttonThemDDTQ_Click(object sender, EventArgs e)
        {
            ThemChiPhiToListBox();
        }

        private void buttonXoaOne_Click(object sender, EventArgs e)
        {
            XoaItemListBox();
        }

        private void buttonXoaTatCa_Click(object sender, EventArgs e)
        {
            XoaTatCaItemListBox();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
    #endregion event
}
