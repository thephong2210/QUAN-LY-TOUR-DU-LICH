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
    public class KhachHangController : Controller
    {
        private D_KH d_khachhang = new D_KH();
        // GET: khachhang
        public ActionResult Index()
        {
            List<khachhang> listResults = d_khachhang.GetKhachHang();

            ViewBag.listTemp = listResults;

            return View();
        }

        [HttpGet]
        [Route("GetOneKhachHang")]
        public JsonResult GetOneKhachHang(int maKH)
        {
            var getKH = d_khachhang.GetListDetailsKhachHang2(maKH);
            return Json(getKH, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        [Route("GetListKhachHang")]
        public JsonResult GetListKhachHang()
        {
            var getKH = d_khachhang.GetListKhachHang();
            return Json(getKH, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        [Route("Create")]
        public JsonResult Create(khachhang objKH)
        {

            return Json(d_khachhang.ThemKhachHang(objKH), JsonRequestBehavior.AllowGet);

        }

        [HttpPost]
        [Route("Update")]
        public JsonResult Update(khachhang objKH, int maKH)
        {
            return Json(d_khachhang.SuaKhachHang(objKH, maKH), JsonRequestBehavior.AllowGet);

        }

        [HttpPost]
        [Route("Delete")]
        public JsonResult Delete(int maKH)
        {
            return Json(d_khachhang.XoaKhachHang(maKH), JsonRequestBehavior.AllowGet);

        }

    }
}