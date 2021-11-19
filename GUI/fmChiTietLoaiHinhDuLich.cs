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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class fmChiTietLoaiHinhDuLich : Form
    {
        B_loaihinhdulich b_loaihinhdulich = new B_loaihinhdulich();
        public fmChiTietLoaiHinhDuLich(int maLoaiHinhDuLich, fmLoaiHinhDuLich fmLoaiHinhDL)
        {
            InitializeComponent();
            fmMain = fmLoaiHinhDL;
            this.maLoaiHinhDuLich = maLoaiHinhDuLich;

            HienThiChiTietLoaiHinhDulich();
        }



        private fmLoaiHinhDuLich fmMain;
        public int maLoaiHinhDuLich { get; set; }

        public void HienThiChiTietLoaiHinhDulich()
        {
            List<dynamic> listDetailsLoaiHinhDuLich = b_loaihinhdulich.GetListDetailsLoaiHinhDuLich(maLoaiHinhDuLich);

            //Convert List<dynamic> sang Datatable để dễ hiển thị chi tiết tour
            var json = JsonConvert.SerializeObject(listDetailsLoaiHinhDuLich);
            DataTable dataTableDetailsLoaiHinhDuLich = (DataTable)JsonConvert.DeserializeObject(json, (typeof(DataTable)));

            //Hiển thị
            textBoxMaLoaiHinhDulich.Text = maLoaiHinhDuLich.ToString();
            textBoxTenLoaiHinhDuLich.Text = dataTableDetailsLoaiHinhDuLich.Rows[0][1].ToString();

        }

        public bool KiemTraTT()
        {
            if (String.IsNullOrEmpty(textBoxTenLoaiHinhDuLich.Text))
            {
                MessageBox.Show("Vui lòng nhập tên loại hình du lịch", "Thông báo");
                textBoxTenLoaiHinhDuLich.Focus();
                return false;
            }
            return true;
        }
        public void SuaLoaiHinhDuLich()
        {
            if (KiemTraTT())
            {

                try
                {
                    loaihinhdulich objLoaiHinhDulich = new loaihinhdulich();
                    objLoaiHinhDulich.tenLoaiHinhDuLich = textBoxTenLoaiHinhDuLich.Text;
                    if (b_loaihinhdulich.SuaLoaiHinhDuLich(objLoaiHinhDulich, maLoaiHinhDuLich))
                    {
                        fmMain.LoadLoaiHinhDuLich();
                        MessageBox.Show("Sửa thông tin loại hình du lịch thành công", "Thông báo");

                    }

                }
                catch (Exception e)
                {
                    MessageBox.Show("Sửa thông tin loại du lịch không thành công", "Thông báo");
                    System.Diagnostics.Debug.WriteLine(e);
                }
            }
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            SuaLoaiHinhDuLich();
        }

        private void buttonDong_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
