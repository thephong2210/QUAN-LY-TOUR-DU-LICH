using BUS;
using DAO;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace WebAdmin.Controllers
{
    public class NhanVienController : Controller
    {
        D_nhanvien d_nhanvien = new D_nhanvien();
        // GET: nhanvien
        public ActionResult Index()
        {
            List<nhanvien> listResults = d_nhanvien.GetAllNhanVien();

            ViewBag.listTemp = listResults;

            return View();
        }

        [HttpGet]
        [Route("GetOneNhanVien")]
        public JsonResult GetOneNhanVien(int maNhanVien)
        {
            var getNhanVien = d_nhanvien.GetListDetailsNhanVien2(maNhanVien);
            return Json(getNhanVien, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        [Route("GetListNhanVien")]
        public JsonResult GetListNhanVien()
        {
            var getNhanVien = d_nhanvien.GetAllNhanVien();
            return Json(getNhanVien, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        [Route("Create")]
        public JsonResult Create(nhanvien objNhanVien)
        {
            
            return Json(d_nhanvien.ThemNhanVien(objNhanVien), JsonRequestBehavior.AllowGet);
            
        }

        [HttpPost]
        [Route("Update")]
        public JsonResult Update(nhanvien objNhanVien, int maNhanVien)
        {
            return Json(d_nhanvien.SuaNhanVien(objNhanVien, maNhanVien), JsonRequestBehavior.AllowGet);

        }

        [HttpPost]
        [Route("Delete")]
        public JsonResult Delete(int maNhanVien)
        {
            return Json(d_nhanvien.XoaNhanVien(maNhanVien), JsonRequestBehavior.AllowGet);

        }

    }
}