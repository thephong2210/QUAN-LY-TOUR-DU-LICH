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
    public partial class fmChitietDoan : Form
    {
        D_doan d_Doan = new D_doan();
        public fmChitietDoan(int maDoan, fmQLDoan fmQLD)
        {
            InitializeComponent();
            LoadChiTietDoan(maDoan);


        }
        private void LoadChiTietDoan(int madoan)
        {
            var json = JsonConvert.SerializeObject(d_Doan.GetDoan(madoan));
            DataTable dataTableDetailsDoan = (DataTable)JsonConvert.DeserializeObject(json, (typeof(DataTable)));
            _tourGroupNameLb.Text = dataTableDetailsDoan.Rows[0][0].ToString();
            _tourNameLb.Text = dataTableDetailsDoan.Rows[0][1].ToString();
            _departDateLb.Text = dataTableDetailsDoan.Rows[0][2].ToString();
            _returnDateLb.Text = dataTableDetailsDoan.Rows[0][3].ToString();
            _chitietLb.Text = dataTableDetailsDoan.Rows[0][4].ToString();
            _passengerDgv.DataSource = d_Doan.GetKhachHangOfDoan(madoan);
            _employeeDgv.DataSource = d_Doan.GetNhanVienOfDoan(madoan);
        }

        private void _customerDetail_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đợi from đăng ký khách hàng", "Thông báo");

        }

        private void _customerDeleteBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đợi from đăng ký khách hàng", "Thông báo");

        }

        private void _employeeDetailBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đợi from tham gia đoàn của nhân viên", "Thông báo");
        }

        private void _employeeDeleteBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đợi from tham gia đoàn của nhân viên", "Thông báo");
        }
    }
}
