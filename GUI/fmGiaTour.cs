using BUS;
using DAO;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class fmGiaTour : Form
    {
        B_giatour bGiaTour = new B_giatour();
        B_tour bTour = new B_tour();

        public fmGiaTour(int maSoTour, fmChiTietTour fmCTTour) // ??
        {
            InitializeComponent();
            fmMain = fmCTTour;
            this.maSoTour = maSoTour;

            HienThiChiTiet();
        }

        private fmChiTietTour fmMain;
        public int maSoTour { get; set; } //Set data sẽ lấy từ form quản lý tour

        // Hiển thị chi tiết 
        private void HienThiChiTiet()
        {
            textBoxMaTour.Text = maSoTour.ToString();

            dataGridViewGiaTour.DataSource = bGiaTour.GetGiaTourWithMaTour(maSoTour);
            dataGridViewGiaTour.AutoGenerateColumns = false;

            dataGridViewGiaTour.Columns["gia"].DefaultCellStyle.Format = "#,##0";
        }

        public void ThemGiaTour()
        {
            if (!String.IsNullOrWhiteSpace(textBoxGia.Text))
            {
                if (!String.IsNullOrWhiteSpace(textBoxGia.Text))
                {
                    try
                    {
                        giatour objGiaTour = new giatour();
                        objGiaTour.gia = Convert.ToDouble(textBoxGia.Text);
                        objGiaTour.maGiaTour = maSoTour;
                        objGiaTour.dieuKien = textBoxNoiDungGia.Text;
                        objGiaTour.ngayThem = DateTime.Parse(dateTimePickerNgay.Value.Date.ToString("yyyy-MM-dd hh:mm:ss.ss"));

                        if (bGiaTour.ThemGiaTour(objGiaTour))
                        {
                            fmMain.HienThiChiTietTour();
                            HienThiChiTiet();
                            ClearFields();
                            MessageBox.Show("Thêm thành công!", "Thông báo");
                        }
                        else
                        {
                            MessageBox.Show("Thêm KHÔNG thành công!", "Thông báo");
                        }
                    }
                    catch (FormatException ex)
                    {
                        MessageBox.Show("Giá tour phải là số!", "Thông báo");
                        System.Diagnostics.Debug.WriteLine(ex);
                    }
                    
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập nội dung giá!", "Thông báo");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập giá!", "Thông báo");
            }


        }

        public void ClearFields()
        {
            textBoxGia.Text = "";
            textBoxNoiDungGia.Text = "";
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonDong_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {

        }

        private void textBoxNhiemVu_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ThemGiaTour();
        }
        public void TimKiemGiaTour()
        {

            if (!String.IsNullOrWhiteSpace(textBoxTimKiem.Text))
            {
                string searchValue = textBoxTimKiem.Text;
                dataGridViewGiaTour.DataSource = bGiaTour.TimKiemGiaTour(searchValue);//tim theo dieu kien
            }
            else
            {
                HienThiChiTiet();
            }

        }
        private void textBoxTimKiem_TextChanged(object sender, EventArgs e)
        {
            TimKiemGiaTour();
        }

        private void fmGiaTour_Load(object sender, EventArgs e)
        {

        }

        public void ApDungGia()
        {
            if (dataGridViewGiaTour.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridViewGiaTour.SelectedRows)
                {
                    if (!String.Equals(row.Cells[0].Value.ToString(), "System.Windows.Forms.DataGridViewTextBoxColumn"))
                    {
                        int idGiaTour = Convert.ToInt32(row.Cells[0].Value.ToString());
                        int maSoTour = Convert.ToInt32(textBoxMaTour.Text);

                        tour objTour = new tour();
                        objTour.idGiaTour = idGiaTour;
                        

                        if (bTour.SuaGiaTour(objTour, maSoTour))
                        {
                            MessageBox.Show("Áp dụng giá thành công!", "Thông báo");
                        }
                        else
                        {
                            MessageBox.Show("Áp dụng giá KHÔNG thành công!", "Thông báo");
                        }

                    }

                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn giá muốn áp dụng!", "Thông báo");
            }
                
        }

        private void buttonApDungGia_Click(object sender, EventArgs e)
        {
            ApDungGia();
        }

        private void textBoxGia_Leave(object sender, EventArgs e)
        {
            try
            {
                textBoxGia.Text = string.Format("{0:#,##0}", double.Parse(textBoxGia.Text));
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Vui lòng chỉ nhập số vào ô giá!","Thông báo");
                System.Diagnostics.Debug.WriteLine(ex);
            }
            
        }
    }
}
