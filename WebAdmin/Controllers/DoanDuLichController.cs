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


    }
}