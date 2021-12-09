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
    public class LoaiHinhDuLichController : Controller
    {
        private D_loaihinhdulich d_Loaihinhdulich = new D_loaihinhdulich();
        // GET: loaihinhdulich
        public ActionResult Index()
        {
            List<loaihinhdulich> listResults = d_Loaihinhdulich.GetListLoaiHinhDL();

            ViewBag.listTemp = listResults;

            return View();
        }

        [HttpGet]
        [Route("GetAllLoaiHinhDuLich")]
        public JsonResult GetAllLoaiHinhDuLich()
        {
            var getKH = d_Loaihinhdulich.GetListLoaiHinhDL();
            return Json(getKH, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        [Route("GetOneLoaiHinhDuLich")]
        public JsonResult GetOneLoaiHinhDuLich(int maLHDL)
        {
            var getKH = d_Loaihinhdulich.GetOneLoaiHinhDL(maLHDL);
            return Json(getKH, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        [Route("Create")]
        public JsonResult Create(loaihinhdulich objLHDL)
        {

            return Json(d_Loaihinhdulich.ThemLoaiHinhDuLich(objLHDL), JsonRequestBehavior.AllowGet);

        }

        [HttpPost]
        [Route("Update")]
        public JsonResult Update(loaihinhdulich objLHDL, int maLHDL)
        {
            return Json(d_Loaihinhdulich.SuaLoaiHinhDuLich(objLHDL, maLHDL), JsonRequestBehavior.AllowGet);

        }

        [HttpPost]
        [Route("Delete")]
        public JsonResult Delete(int maLHDL)
        {
            return Json(d_Loaihinhdulich.XoaLoaiHinhDuLich(maLHDL), JsonRequestBehavior.AllowGet);

        }


    }
}