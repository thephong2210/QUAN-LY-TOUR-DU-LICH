using DAO;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAdmin.Controllers
{
    public class TongQuanController : Controller
    {
        D_tour d_tour = new D_tour();
        D_doan d_doan = new D_doan();
        D_nhanvien d_nhanvien = new D_nhanvien();
        D_DangKy d_dangky = new D_DangKy();
        D_chiphi d_chiphi = new D_chiphi();
        D_KH d_KH = new D_KH();
        // GET: TongQuan
        public ActionResult Index()
        {
            //tổng số tour
            var countTour = d_tour.GetAllTour().Count();

            //tổng số tour mới trong tháng
            var countTourInMonth = d_tour.GetAllTour().Where<tour>(t => t.thoiGianBatDau.Month == DateTime.Now.Month 
                                                                        && t.thoiGianKetThuc.Month == DateTime.Now.Month
                                                                        && t.thoiGianBatDau.Year == DateTime.Now.Year
                                                                        && t.thoiGianKetThuc.Year == DateTime.Now.Year).Count();

            ViewBag.countTour = countTour;
            ViewBag.countTourInMonth = countTourInMonth;

            //-------------------------------------
            //tổng số đoàn
            var countDoan = d_doan.GetAllDoan().Count();

            //tổng số đoàn mới trong tháng
            var countDoanInMonth = d_doan.GetAllDoan().Where<doandulich>(t => t.thoiGianKhoiHanh.Month == DateTime.Now.Month 
                                                                        && t.thoiGianKetThuc.Month == DateTime.Now.Month
                                                                        && t.thoiGianKhoiHanh.Year == DateTime.Now.Year
                                                                        && t.thoiGianKetThuc.Year == DateTime.Now.Year).Count();

            ViewBag.countDoan = countDoan;
            ViewBag.countDoanInMonth = countDoanInMonth;

            //-------------------------------------
            //tổng số nhân viên
            var countKhachHang = d_KH.GetKhachHang().Count();

            ViewBag.countKhachHang = countKhachHang;

            //-------------------------------------
            //Tổng doanh thu = tổng giá tour khách đăng ký (tất cả đoàn) - tổng chi phí (tất cả đoàn)
            var tongTienDoanKhach = d_dangky.GetAllDangKy().Sum<dangky>(t=>t.giaTourDangKy);
            var tongChiPhiDoanKhach = d_chiphi.GetListChiPhi().Sum<chiphi>(t => t.tongChiPhi);
            var tongDoanhThu = tongTienDoanKhach - tongChiPhiDoanKhach;

            ViewBag.tongDoanhThu = tongDoanhThu;

            //-------------------------------------
            //tổng doanh thu trong tháng
            var tongTienDoanKhachThang = d_dangky.GetAllDangKy().Where<dangky>(t => t.ngayDangKy.Month == DateTime.Now.Month && t.ngayDangKy.Year == DateTime.Now.Year).Sum<dangky>(t => t.giaTourDangKy);
            //System.Diagnostics.Debug.WriteLine(tongTienDoanKhachThang); //debug
            var listDoanTrongThang = d_doan.GetAllDoan().Where<doandulich>(t => t.thoiGianKhoiHanh.Month == DateTime.Now.Month 
                                                                                && t.thoiGianKetThuc.Month == DateTime.Now.Month
                                                                                && t.thoiGianKhoiHanh.Year == DateTime.Now.Year
                                                                                && t.thoiGianKetThuc.Year == DateTime.Now.Year);
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

            ViewBag.tongDoanhThuThang = tongDoanhThuThang;

            


            return View();
        }


        [HttpGet]
        [Route("GetDoanhSoTheoThangCuaNam")]
        public JsonResult GetDoanhSoTheoThangCuaNam(int yearValue)
        {
            var get = d_dangky.GetDoanhSoMoiThangCuaNam(yearValue);

            return Json(get, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        [Route("GetAllChiPhi")]
        public JsonResult GetAllChiPhi()
        {
            var get = d_chiphi.GetListChiPhi();

            return Json(get, JsonRequestBehavior.AllowGet);
        }


        [HttpGet]
        [Route("TopTourDangKyNhieu")]
        public JsonResult TopTourDangKyNhieu(int topNumber)
        {
            var get = d_dangky.TopTourDangKyNhieu(topNumber);

            return Json(get, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        [Route("GetSoLuongDoan")]
        public JsonResult GetSoLuongDoan()
        {
            var get = d_dangky.GetSoLuongDoan();

            return Json(get, JsonRequestBehavior.AllowGet);
        }


        [HttpGet]
        [Route("GetDoanhSoDangKyAllTour")]
        public JsonResult GetDoanhSoDangKyAllTour(int numberLimit)
        {
            var get = d_dangky.GetDoanhSoDangKyAllTour(numberLimit);

            return Json(get, JsonRequestBehavior.AllowGet);
        }


        [HttpGet]
        [Route("GetChiPhiAllDoan")]
        public JsonResult GetChiPhiAllDoan()
        {
            var get = d_dangky.GetChiPhiAllDoan().GroupBy(t=>t.maSoTour)
                                                .Select(t=> new ChiPhiAllDoanModel {
                                                        maSoDoan = t.First().maSoDoan,
                                                        maSoTour = t.First().maSoTour,
                                                        totalChiPhi = t.Sum(c=>c.totalChiPhi)
                                                });

            return Json(get, JsonRequestBehavior.AllowGet);
        }


        [HttpGet]
        [Route("GetSoLanDiTourNhanVien")]
        public JsonResult GetSoLanDiTourNhanVien(int numberLimit)
        {
            var get = d_dangky.GetSoLanDiTourNhanVien(numberLimit);

            return Json(get, JsonRequestBehavior.AllowGet);
        }





    }
}