using DAO;
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
    public partial class fmSuaChiPhi : Form
    {
        D_chiphi dChiPhi = new D_chiphi();

        private int maChiPhiGet { get; set; }
        private fmChiTietChiPhi fmCTCPGet { get; set; }
        private fmChitietDoan fmCTDGet { get; set; }
        public fmSuaChiPhi(int maChiPhi, fmChiTietChiPhi fmCTCP, fmChitietDoan fmCTD)
        {
            InitializeComponent();

            this.maChiPhiGet = maChiPhi;
            this.fmCTCPGet = fmCTCP;
            this.fmCTDGet = fmCTD;
        }

        public void HienThiChiTiet()
        {
            textBoxMaChiPhi.Text = maChiPhiGet.ToString();

            comboBoxLoaiChiPhi.DataSource = dChiPhi.GetListChiPhiVoiMa(maChiPhiGet);
            comboBoxLoaiChiPhi.DisplayMember = "tenChiPhi";

            List<chiphi> listChiPhi = dChiPhi.GetListChiPhiVoiMa(maChiPhiGet);
            textBoxTongChiPhi.Text = listChiPhi[0].tongChiPhi.ToString();

        }

        public void SuaChiPhi()
        {
            if (!String.IsNullOrWhiteSpace(textBoxTongChiPhi.Text))
            {
                try
                {
                    chiphi objChiPhi = new chiphi();
                    objChiPhi.tongChiPhi = Convert.ToInt32(textBoxTongChiPhi.Text);

                    if (dChiPhi.SuaChiPhi(objChiPhi, maChiPhiGet))
                    {
                        fmCTCPGet.HienThiBangChiPhi();
                        fmCTDGet.LoadChiTietDoan();
                        MessageBox.Show("Sửa thành công!", "Thông báo");
                    }

                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Chi phí phải là số!", "Thông báo");
                    System.Diagnostics.Debug.WriteLine(ex);
                }

            }
            else
            {
                MessageBox.Show("Vui lòng nhập tổng chi phí!","Thông báo");
            }




        }

        private void fmSuaChiPhi_Load(object sender, EventArgs e)
        {
            HienThiChiTiet();
        }



        private void buttonSua_Click(object sender, EventArgs e)
        {

            SuaChiPhi();

        }
    }


}
