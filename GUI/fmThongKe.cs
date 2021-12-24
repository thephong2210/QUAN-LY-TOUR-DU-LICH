using DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class fmThongKe : Form
    {
        D_nhanvien d_nhanvien = new D_nhanvien();
        D_doan d_doan = new D_doan();
        D_tour d_tour= new D_tour();
        D_DangKy d_DangKy = new D_DangKy();
        D_chiphi d_chiphi = new D_chiphi();

        public fmThongKe()
        {
            InitializeComponent();
            ThongKe();

        }
 
        public void ThongKe()
        {
            labelThongKeNhanVien.Text = d_nhanvien.GetListNhanVien().Count.ToString();        
            labelThongKeDoanDuLich.Text = d_doan.GetListDoan().Count.ToString();
            labelThongKeTour.Text = d_tour.GetListTour().Count.ToString();

            int tongGiaTourDangKy = (int)(from DangKy in d_DangKy.GetAllDangKy() select DangKy.giaTourDangKy).Sum();
            int tongChiPhi = (int)(from ChiPhi in d_DangKy.GetAllChiPhi() select ChiPhi.tongChiPhi).Sum();

            labelThongKeDoanhThu.Text = String.Format("{0:n0}", tongGiaTourDangKy - tongChiPhi)  + " đ";

            var currentMonth = DateTime.Now.Month;
            var currentYear = DateTime.Now.Year;

            //------------------
            //tổng tour trong tháng hiện tại
            var countTourInMonth = d_tour.GetAllTour().Where<tour>(t => t.thoiGianBatDau.Month == currentMonth
                                                                       && t.thoiGianKetThuc.Month == currentMonth
                                                                       && t.thoiGianBatDau.Year == currentYear
                                                                       && t.thoiGianKetThuc.Year == currentYear).Count();
            
            labelDoanhSoMoi_Tour.Text = "+ " + countTourInMonth + " tháng này";

            //tổng số đoàn mới trong tháng
            var countDoanInMonth = d_doan.GetAllDoan().Where<doandulich>(t => t.thoiGianKhoiHanh.Month == currentMonth
                                                                        && t.thoiGianKetThuc.Month == currentMonth
                                                                        && t.thoiGianKhoiHanh.Year == currentYear
                                                                        && t.thoiGianKetThuc.Year == currentYear).Count();

            labelDoanhSoMoi_Doan.Text = "+ " + countDoanInMonth + " tháng này";

            //-------------------------------------
            //tổng doanh thu trong tháng
            var tongTienDoanKhachThang = d_DangKy.GetAllDangKy().Where<dangky>(t => t.ngayDangKy.Month == currentMonth && t.ngayDangKy.Year == currentYear).Sum<dangky>(t => t.giaTourDangKy);
            //System.Diagnostics.Debug.WriteLine(tongTienDoanKhachThang); //debug
            var listDoanTrongThang = d_doan.GetAllDoan().Where<doandulich>(t => t.thoiGianKhoiHanh.Month == currentMonth
                                                                                && t.thoiGianKetThuc.Month == currentMonth
                                                                                && t.thoiGianKhoiHanh.Year == currentYear
                                                                                && t.thoiGianKetThuc.Year == currentYear);
            List<chiphi> listChiPhi = d_chiphi.GetListChiPhi();
            double tongChiPhiDoanKhachThang = 0;

            foreach (var itemDoan in listDoanTrongThang)
            {
                foreach (var itemChiPhi in listChiPhi)
                {
                    if (itemDoan.maSoDoan == itemChiPhi.maSoDoan)
                    {
                        tongChiPhiDoanKhachThang += itemChiPhi.tongChiPhi;
                    }
                }

            }

            var tongDoanhThuThang = tongTienDoanKhachThang - tongChiPhiDoanKhachThang;

            labelDoanhSoMoi_DoanhThu.Text = "+" + String.Format("{0:n0}", tongDoanhThuThang) + "đ tháng này";


            BieuDoDoanhThuNam(currentYear);
            TopTourDangKyNhieuNhat();
            TopTourDoanhThuCaoNhat();
            TopNhanVienThamGia();
        }

        public void BieuDoDoanhThuNam(int yearValue)
        {
            double tongChiPhiThang1 = 0;
            double tongChiPhiThang2 = 0;
            double tongChiPhiThang3 = 0;
            double tongChiPhiThang4 = 0;
            double tongChiPhiThang5 = 0;
            double tongChiPhiThang6 = 0;
            double tongChiPhiThang7 = 0;
            double tongChiPhiThang8 = 0;
            double tongChiPhiThang9 = 0;
            double tongChiPhiThang10 = 0;
            double tongChiPhiThang11 = 0;
            double tongChiPhiThang12 = 0;

            double valueThang1 = 0;
            double valueThang2 = 0;
            double valueThang3 = 0;
            double valueThang4 = 0;
            double valueThang5 = 0;
            double valueThang6 = 0;
            double valueThang7 = 0;
            double valueThang8 = 0;
            double valueThang9 = 0;
            double valueThang10 = 0;
            double valueThang11 = 0;
            double valueThang12 = 0;

            var currentYear = DateTime.Now.Year;
            List<dynamic> listDoanhSoMoiThangCuaNam = d_DangKy.GetDoanhSoMoiThangCuaNam(yearValue);
            List<doandulich> listDoan = d_doan.GetAllDoan();
            List<chiphi> listChiPhi = d_chiphi.GetListChiPhi();

            foreach (var itemDoanhSo in listDoanhSoMoiThangCuaNam)
            {
                var monthAndYear = itemDoanhSo.GetType().GetProperty("MonthAndYear").GetValue(itemDoanhSo, null);
                var totalMonth = itemDoanhSo.GetType().GetProperty("Total").GetValue(itemDoanhSo, null);

                foreach (var itemDoan in listDoan)
                {
                    var maSoDoanInDoan = itemDoan.maSoDoan;
                    var yearDoan = itemDoan.thoiGianKhoiHanh.Year;
                    var monthDoan = itemDoan.thoiGianKhoiHanh.Month;

                    foreach (var itemChiPhi in listChiPhi)
                    {
                        var maSoDoanInChiPhi = itemChiPhi.maSoDoan;

                        if ((monthAndYear == (currentYear + "-1")) && (yearDoan == currentYear) && (monthDoan == 1))
                        {
                            if (maSoDoanInChiPhi == maSoDoanInDoan)
                            {
                                tongChiPhiThang1 += itemChiPhi.tongChiPhi;
                            }
                            valueThang1 = totalMonth - tongChiPhiThang1;
                        }

                        if ((monthAndYear == (currentYear + "-2")) && (yearDoan == currentYear) && (monthDoan == 2))
                        {
                            if (maSoDoanInChiPhi == maSoDoanInDoan)
                            {
                                tongChiPhiThang2 += itemChiPhi.tongChiPhi;
                            }
                            valueThang2 = totalMonth - tongChiPhiThang2;
                        }

                        if ((monthAndYear == (currentYear + "-3")) && (yearDoan == currentYear) && (monthDoan == 3))
                        {
                            if (maSoDoanInChiPhi == maSoDoanInDoan)
                            {
                                tongChiPhiThang3 += itemChiPhi.tongChiPhi;
                            }
                            valueThang3 = totalMonth - tongChiPhiThang3;
                        }

                        if ((monthAndYear == (currentYear + "-4")) && (yearDoan == currentYear) && (monthDoan == 4))
                        {
                            if (maSoDoanInChiPhi == maSoDoanInDoan)
                            {
                                tongChiPhiThang4 += itemChiPhi.tongChiPhi;
                            }
                            valueThang4 = totalMonth - tongChiPhiThang4;
                        }

                        if ((monthAndYear == (currentYear + "-5")) && (yearDoan == currentYear) && (monthDoan == 5))
                        {
                            if (maSoDoanInChiPhi == maSoDoanInDoan)
                            {
                                tongChiPhiThang5 += itemChiPhi.tongChiPhi;
                            }
                            valueThang5 = totalMonth - tongChiPhiThang5;
                        }

                        if ((monthAndYear == (currentYear + "-6")) && (yearDoan == currentYear) && (monthDoan == 6))
                        {
                            if (maSoDoanInChiPhi == maSoDoanInDoan)
                            {
                                tongChiPhiThang6 += itemChiPhi.tongChiPhi;
                            }
                            valueThang6 = totalMonth - tongChiPhiThang6;
                        }

                        if ((monthAndYear == (currentYear + "-7")) && (yearDoan == currentYear) && (monthDoan == 7))
                        {
                            if (maSoDoanInChiPhi == maSoDoanInDoan)
                            {
                                tongChiPhiThang7 += itemChiPhi.tongChiPhi;
                            }
                            valueThang7 = totalMonth - tongChiPhiThang7;
                        }

                        if ((monthAndYear == (currentYear + "-8")) && (yearDoan == currentYear) && (monthDoan == 8))
                        {
                            if (maSoDoanInChiPhi == maSoDoanInDoan)
                            {
                                tongChiPhiThang8 += itemChiPhi.tongChiPhi;
                            }
                            valueThang8 = totalMonth - tongChiPhiThang8;
                        }

                        if ((monthAndYear == (currentYear + "-9")) && (yearDoan == currentYear) && (monthDoan == 9))
                        {
                            if (maSoDoanInChiPhi == maSoDoanInDoan)
                            {
                                tongChiPhiThang9 += itemChiPhi.tongChiPhi;
                            }
                            valueThang9 = totalMonth - tongChiPhiThang9;
                        }

                        if ((monthAndYear == (currentYear + "-10")) && (yearDoan == currentYear) && (monthDoan == 10))
                        {
                            if (maSoDoanInChiPhi == maSoDoanInDoan)
                            {
                                tongChiPhiThang10 += itemChiPhi.tongChiPhi;
                            }
                            valueThang10 = totalMonth - tongChiPhiThang10;
                        }

                        if ((monthAndYear == (currentYear + "-11")) && (yearDoan == currentYear) && (monthDoan == 11))
                        {
                            if (maSoDoanInChiPhi == maSoDoanInDoan)
                            {
                                tongChiPhiThang11 += itemChiPhi.tongChiPhi;
                            }
                            valueThang11 = totalMonth - tongChiPhiThang11;
                        }

                        if ((monthAndYear == (currentYear + "-12")) && (yearDoan == currentYear) && (monthDoan == 12))
                        {
                            if (maSoDoanInChiPhi == maSoDoanInDoan)
                            {
                                tongChiPhiThang12 += itemChiPhi.tongChiPhi;
                            }
                            valueThang12 = totalMonth - tongChiPhiThang12;
                        }

                    }


                }


            }



            chartDoanhThuTheoThang.Series["Doanh thu"].Points.AddXY("Tháng 1", valueThang1);
            chartDoanhThuTheoThang.Series["Doanh thu"].Points.AddXY("Tháng 2", valueThang2);
            chartDoanhThuTheoThang.Series["Doanh thu"].Points.AddXY("Tháng 3", valueThang3);
            chartDoanhThuTheoThang.Series["Doanh thu"].Points.AddXY("Tháng 4", valueThang4);
            chartDoanhThuTheoThang.Series["Doanh thu"].Points.AddXY("Tháng 5", valueThang5);
            chartDoanhThuTheoThang.Series["Doanh thu"].Points.AddXY("Tháng 6", valueThang6);
            chartDoanhThuTheoThang.Series["Doanh thu"].Points.AddXY("Tháng 7", valueThang7);
            chartDoanhThuTheoThang.Series["Doanh thu"].Points.AddXY("Tháng 8", valueThang8);
            chartDoanhThuTheoThang.Series["Doanh thu"].Points.AddXY("Tháng 9", valueThang9);
            chartDoanhThuTheoThang.Series["Doanh thu"].Points.AddXY("Tháng 10", valueThang10);
            chartDoanhThuTheoThang.Series["Doanh thu"].Points.AddXY("Tháng 11", valueThang11);
            chartDoanhThuTheoThang.Series["Doanh thu"].Points.AddXY("Tháng 12", valueThang12);

            chartDoanhThuTheoThang.ChartAreas["ChartArea1"].AxisX.Interval = 1;

            chartDoanhThuTheoThang.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chartDoanhThuTheoThang.ChartAreas[0].AxisX.MinorGrid.Enabled = false;
            
        }

        public void TopTourDangKyNhieuNhat()
        {
            int numberLimit = 5;
            var listTopTourDangKyNhieu = d_DangKy.TopTourDangKyNhieu(numberLimit);
            var listGetSoLuongDoan = d_DangKy.GetSoLuongDoan();

            dataGridViewTopTourDangKyNhieu.AutoGenerateColumns = false;

            foreach (var itemTopTour in listTopTourDangKyNhieu)
            {
                var maSoTourTopTour = itemTopTour.GetType().GetProperty("maTour").GetValue(itemTopTour, null);
                var tenTour = itemTopTour.GetType().GetProperty("tenTour").GetValue(itemTopTour, null);
                var totalDangKy = itemTopTour.GetType().GetProperty("TotalDangKy").GetValue(itemTopTour, null);                

                foreach (var itemGetSLD in listGetSoLuongDoan)
                {
                    
                    var maSoTourDoan = itemGetSLD.GetType().GetProperty("maTour").GetValue(itemGetSLD, null);
                    var totalDoan = itemGetSLD.GetType().GetProperty("TotalDoan").GetValue(itemGetSLD, null);

                    if (maSoTourTopTour == maSoTourDoan)
                    {
                        dataGridViewTopTourDangKyNhieu.Rows.Add(maSoTourTopTour, tenTour, totalDoan, totalDangKy);
                    }

                }


            }
            
        }

        public void TopTourDoanhThuCaoNhat()
        {
            int numberLimit = 5;
            var listGetDoanhSoDangKyAllTour = d_DangKy.GetDoanhSoDangKyAllTour(numberLimit);
            var listGetChiPhiAllDoan = d_DangKy.GetChiPhiAllDoan();

            dataGridViewTopTourDoanhThu.AutoGenerateColumns = false;

            foreach (var itemDoanhSo in listGetDoanhSoDangKyAllTour)
            {
                var maSoTourDS = itemDoanhSo.GetType().GetProperty("maSoTour").GetValue(itemDoanhSo, null);
                var tenTourDS = itemDoanhSo.GetType().GetProperty("tenTour").GetValue(itemDoanhSo, null);
                var totalGiaVe = itemDoanhSo.GetType().GetProperty("totalGiaVe").GetValue(itemDoanhSo, null);
              
                foreach (var itemGetCP in listGetChiPhiAllDoan)
                {
                    var maSoTourChiPhi = itemGetCP.maSoTour;
                    var totalChiPhi = itemGetCP.totalChiPhi;

                    if (maSoTourDS == maSoTourChiPhi)
                    {
                        var totalDoanhThu = totalGiaVe - totalChiPhi;
                        dataGridViewTopTourDoanhThu.Rows.Add(maSoTourDS, tenTourDS, totalDoanhThu);
                    }
                  

                }


            }


        }

        public void TopNhanVienThamGia()
        {
            int numberLimit = 5;
            var listGetSoLanDiTourNhanVien = d_DangKy.GetSoLanDiTourNhanVien(numberLimit);
            
            dataGridViewTopNhanVienThamGia.AutoGenerateColumns = false;

            foreach (var itemSLNV in listGetSoLanDiTourNhanVien)
            {
                var maNhanVien = itemSLNV.GetType().GetProperty("maNhanVien").GetValue(itemSLNV, null);
                var tenNhanVien = itemSLNV.GetType().GetProperty("tenNhanVien").GetValue(itemSLNV, null);
                var soLanDiTour = itemSLNV.GetType().GetProperty("soLanDiTour").GetValue(itemSLNV, null);
                
                dataGridViewTopNhanVienThamGia.Rows.Add(maNhanVien, tenNhanVien, soLanDiTour);
                    
            }


        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void fmThongKe_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelThongKeTour_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
