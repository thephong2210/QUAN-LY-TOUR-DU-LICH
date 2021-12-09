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
    public class DiaDiemController : Controller
    {
        //Địa điểm đến
        // GET: diadiem
        D_diadiemden d_diadiem = new D_diadiemden();
        public ActionResult Index()
        {
            List<diadiemden> listResults = d_diadiem.GetListDiaDiemDen();

            ViewBag.listTemp = listResults;

            return View();
        }

        [HttpGet]
        [Route("GetAllDiaDiemDen")]
        public JsonResult GetAllDiaDiemDen()
        {
            var getDDD = d_diadiem.GetListDiaDiemDen();
            return Json(getDDD, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        [Route("GetOneDiaDiemDen")]
        public JsonResult GetOneDiaDiemDen(int maDiaDiemDen)
        {
            var getDDD = d_diadiem.GetOneDiaDiemDen(maDiaDiemDen);
            return Json(getDDD, JsonRequestBehavior.AllowGet);
        }


        [HttpGet]
        [Route("GetDetailsDDTQ")]
        public JsonResult GetDetailsDDTQ(int maDiaDiemDen)
        {
            var getDDD = d_diadiem.GetListDetailsDiaDiemThamQuan(maDiaDiemDen);
            return Json(getDDD, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        [Route("CreateDDTQ")]
        public JsonResult CreateDDTQ(diadiemthamquan objDDTQ)
        {
            var getDDD = d_diadiem.ThemDiaDiemThamQuan(objDDTQ);
            return Json(getDDD, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        [Route("CreateDiaDiemTour")]
        public JsonResult CreateDiaDiemTour(diadiemtour objDDT)
        {
            var getDDD = d_diadiem.ThemDiaDiemTour(objDDT);
            return Json(getDDD, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        [Route("Create")]
        public JsonResult Create(diadiemden objDiaDiemDen)
        {

            return Json(d_diadiem.ThemDiaDiemDen(objDiaDiemDen), JsonRequestBehavior.AllowGet);

        }

        [HttpPost]
        [Route("Update")]
        public JsonResult Update(diadiemden objDiaDiemDen, int maDiaDiemDen)
        {
            return Json(d_diadiem.SuaDiaDiemDen(objDiaDiemDen, maDiaDiemDen), JsonRequestBehavior.AllowGet);

        }

        [HttpPost]
        [Route("Delete")]
        public JsonResult Delete(int maDiaDiemDen)
        {
            return Json(d_diadiem.XoaDiaDiemDen(maDiaDiemDen), JsonRequestBehavior.AllowGet);

        }


    }
}