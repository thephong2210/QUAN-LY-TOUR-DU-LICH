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

        public fmChiTietChiPhi(int maDoan, fmChitietDoan fmCTDoan) // ??
        {
            InitializeComponent();
            fmMain = fmCTDoan;
            this.maDoan = maDoan;

            HienThiChiTietChiPhi();
        }

        private fmChitietDoan fmMain;
        public int maDoan { get; set; } //Set data sẽ lấy từ form quản lý tour

        // Hiển thị chi tiết nhân viết
        private void HienThiChiTietChiPhi()
        {
            List<chiphi> listChiPhi = DChiPhi.GetListLoaiChiPhiWithMaDoan(maDoan);

            //Hiển thị
            textBoxMaSoDoan.Text = maDoan.ToString();

            foreach (var item in listChiPhi)
            {
                listBoxChiPhi.Items.Add(item.tenChiPhi + ";" + item.tongChiPhi);
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



        // Sửa chi phí
        public void SuaChiPhi()
        {

            if (listBoxChiPhi.Items.Count != 0)
            {
                List<chiphi> listChiPhi = DChiPhi.GetListLoaiChiPhi();

                //Xóa chi phí cũ
                foreach (var item in listChiPhi)
                {
                    if (item.maSoDoan.Equals(maDoan))
                    {
                        DChiPhi.XoaLoaiChiPhi(item.maChiPhi);
                    }
                }


                //Thêm chi phí mới
                foreach (string item in listBoxChiPhi.Items)
                {
                    chiphi objChiPhi = new chiphi();
                    string[] words = item.Split(';');

                    objChiPhi.tenChiPhi = words[0];
                    objChiPhi.tongChiPhi = Convert.ToDouble(words[1]);
                    objChiPhi.maSoDoan = maDoan; //get maSoDoan new
                    objChiPhi.trangThai = 1;

                    if (DChiPhi.ThemLoaiChiPhi(objChiPhi))
                    {
                        System.Diagnostics.Debug.WriteLine("Thêm chi phí thành công!"); //debug write line

                    }
                }


                fmMain.LoadChiTietDoan(maDoan);
                MessageBox.Show("Sửa thành công!", "Thông báo");
            }
            else
            {
                MessageBox.Show("Vui lòng thêm ít nhất 1 chi phí!", "Thông báo");
            }
        }

        private void buttonThemDDTQ_Click(object sender, EventArgs e)
        {
            ThemChiPhiToListBox();
        }

        private void fmChiTietChiPhi_Load(object sender, EventArgs e)
        {
            //HienThiChiTietChiPhi();
        }

        private void buttonXoaOne_Click(object sender, EventArgs e)
        {
            XoaItemListBox();
        }

        private void buttonXoaTatCa_Click(object sender, EventArgs e)
        {
            XoaTatCaItemListBox();
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            SuaChiPhi();
        }

        private void buttonDong_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }

}
