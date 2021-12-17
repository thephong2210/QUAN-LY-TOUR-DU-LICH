using BUS;
using DAO;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAdmin.Controllers
{
    public class DoanDuLichController : Controller
    {
        D_doan d_doan = new D_doan();
        D_DangKy d_dangky = new D_DangKy();
        D_dangkynhanvien d_dangkynhanvien = new D_dangkynhanvien();
        D_chiphi d_chiphi = new D_chiphi();
        D_LoaiChiPhi d_loaichiphi = new D_LoaiChiPhi();
        // GET: doandulich
        public ActionResult Index()
        {
            
            List<dynamic> listResults = d_doan.GetListDoan();

            //convert List<dynamic> sang json
            var objOld = JsonConvert.SerializeObject(listResults);
            //convert json sang List<NhanVienView>
            var obj = JsonConvert.DeserializeObject<List<DoanView>>(objOld);

            ViewBag.listTemp = obj;

            return View();
        }

        [HttpGet]
        [Route("GetOneDoan")]
        public JsonResult GetOneDoan(int maSoDoan)
        {
            var getDoan = d_doan.GetOneDoan(maSoDoan);
            return Json(getDoan, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Details(int maSoDoan)
        {
            
            List<dynamic> listResults = d_doan.GetOneDoan2(maSoDoan);
            //convert List<dynamic> sang json
            var objOld = JsonConvert.SerializeObject(listResults);
            //convert json sang List<View>
            var obj = JsonConvert.DeserializeObject<List<DoanView>>(objOld);
            ViewBag.listTemp = obj;

            //chi tiết 1 đoàn (dùng get số lượng khách hàng, nhân viên của đoàn)
            var getDoan = d_doan.GetOneDoan(maSoDoan);
            ViewBag.listOneDoan = getDoan;

            //list khách hàng đăng ký
            var getListKHDK = d_doan.GetKhachHangOfDoan(maSoDoan);
            //convert List<dynamic> sang json
            var getListKHDKobjOld = JsonConvert.SerializeObject(getListKHDK);
            //convert json sang List<View>
            var getListKHDKobj = JsonConvert.DeserializeObject<List<KhachHangCuaDoanView>>(getListKHDKobjOld);
            ViewBag.listKHDK = getListKHDKobj;

            //list khách hàng đăng ký
            var getListNVDK = d_doan.GetNhanVienOfDoan(maSoDoan);
            //convert List<dynamic> sang json
            var getListNVDKobjOld = JsonConvert.SerializeObject(getListNVDK);
            //convert json sang List<View>
            var getListNVDKobj = JsonConvert.DeserializeObject<List<NhanVienCuaDoanView>>(getListNVDKobjOld);
            ViewBag.listNVDK = getListNVDKobj;


            return View();
        }


        [HttpPost]
        [Route("Create")]
        public JsonResult Create(doandulich objDoan)
        {

            return Json(d_doan.ThemDoan(objDoan), JsonRequestBehavior.AllowGet);

        }

        [HttpPost]
        [Route("Update")]
        public JsonResult Update(doandulich objDoan, int maSoDoan)
        {
            return Json(d_doan.SuaDoan(objDoan, maSoDoan), JsonRequestBehavior.AllowGet);

        }

        [HttpPost]
        [Route("Delete")]
        public JsonResult Delete(int maSoDoan)
        {
            return Json(d_doan.XoaDoan(maSoDoan), JsonRequestBehavior.AllowGet);

        }

        //chi phí
        [HttpGet]
        [Route("GetBangChiPhi")]
        public JsonResult GetBangChiPhi(int maSoDoan)
        {
            var getDoan = d_chiphi.GetListChiPhiWithMaDoan(maSoDoan);
            return Json(getDoan, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        [Route("GetListLoaiChiPhi")]
        public JsonResult GetListLoaiChiPhi()
        {
            var getDoan = d_loaichiphi.GetLoaiChiPhi(); 
            return Json(getDoan, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        [Route("CreateChiPhi")]
        public JsonResult CreateChiPhi(chiphi objChiPhi)
        {
            var getDoan = d_chiphi.ThemChiPhi(objChiPhi);
            return Json(getDoan, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        [Route("DeleteChiPhi")]
        public JsonResult DeleteChiPhi(int maChiPhi)
        {
            var getDoan = d_chiphi.XoaChiPhi(maChiPhi);
            return Json(getDoan, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        [Route("CreateLoaiChiPhi")]
        public JsonResult CreateLoaiChiPhi(loaichiphi objLoaiChiPhi)
        {
            var getDoan = d_loaichiphi.ThemLoaiChiPhi(objLoaiChiPhi);
            return Json(getDoan, JsonRequestBehavior.AllowGet);
        }

        //Dang ky khach hang
        [HttpPost]
        [Route("CreateDangKyKhachHang")]
        public JsonResult CreateDangKyKhachHang(dangky objDangKy)
        {
            var getDoan = d_dangky.ThemDangKy(objDangKy);
            return Json(getDoan, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        [Route("ThemSoLuongKhachHangDoan")]
        public JsonResult ThemSoLuongKhachHangDoan(doandulich objDoan, int maSoDoan)
        {
            var getDoan = d_doan.ThemSoLuongKhachHangDoan(objDoan, maSoDoan);
            return Json(getDoan, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        [Route("GiamSoLuongKhachHangDoan")]
        public JsonResult GiamSoLuongKhachHangDoan(doandulich objDoan, int maSoDoan)
        {
            var getDoan = d_doan.GiamSoLuongKhachHangDoan(objDoan, maSoDoan);
            return Json(getDoan, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        [Route("DeleteDangKyKH")]
        public JsonResult DeleteDangKyKH(int maDangKy)
        {
            var getDoan = d_dangky.XoaDangKy(maDangKy);
            return Json(getDoan, JsonRequestBehavior.AllowGet);
        }

        //Dang ky nhan vien
        [HttpGet]
        [Route("GetLatestDangKyNhanVien")]
        public JsonResult GetLatestDangKyNhanVien(int maNhanVien)
        {
            try {
                var getDoan = d_dangkynhanvien.GetLatestDangKyCuaNhanVien(maNhanVien).First();
                return Json(getDoan, JsonRequestBehavior.AllowGet);
            }
            catch(InvalidOperationException ex)
            {
                return null;
            }

        }

        [HttpPost]
        [Route("DeleteDangKyNV")]
        public JsonResult DeleteDangKyNV(int maDangKy)
        {
            var getDoan = d_dangkynhanvien.XoaDangKy(maDangKy);
            return Json(getDoan, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        [Route("CreateDangKyNhanVien")]
        public JsonResult CreateDangKyNhanVien(thamgiadoan objThamGiaDoan)
        {
            var getDoan = d_dangkynhanvien.ThemDangKy(objThamGiaDoan);
            return Json(getDoan, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        [Route("ThemSoLuongNhanVienDoan")]
        public JsonResult ThemSoLuongNhanVienDoan(doandulich objDoan, int maSoDoan)
        {
            var getDoan = d_doan.ThemSoLuongNhanVienDoan(objDoan, maSoDoan);
            return Json(getDoan, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        [Route("GiamSoLuongNhanVienDoan")]
        public JsonResult GiamSoLuongNhanVienDoan(doandulich objDoan, int maSoDoan)
        {
            var getDoan = d_doan.GiamSoLuongNhanVienDoan(objDoan, maSoDoan);
            return Json(getDoan, JsonRequestBehavior.AllowGet);
        }

    }
}