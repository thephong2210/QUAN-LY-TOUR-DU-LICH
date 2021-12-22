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
    public class TourController : Controller { 
    
        D_tour d_tour = new D_tour();
        D_giatour d_giatour = new D_giatour();
        D_diadiemden d_diadiem = new D_diadiemden();
        D_DangKy d_dangky = new D_DangKy();
        // GET: Tour
        public ActionResult Index()
        {
            List<dynamic> listResults = d_tour.GetListTour();

            //convert List<dynamic> sang json
            var objOld = JsonConvert.SerializeObject(listResults);
            //convert json sang List<NhanVienView>
            var obj = JsonConvert.DeserializeObject<List<TourView>>(objOld);

            ViewBag.listTemp = obj;

            //tổng chi phí
            var listChiPhiTour = d_dangky.GetChiPhiAllDoan();
            ViewBag.listChiPhiTour = listChiPhiTour;

            //tổng giá vé (doanh thu = tổng giá vé - tổng chi phí)
            var listGiaVeTour = d_dangky.GetDoanhSoDangKyAllTour();
            ViewBag.listGiaVeTour = listGiaVeTour;


            return View();
        }


        [HttpGet]
        [Route("GetAllTour")]
        public JsonResult GetAllTour()
        {
            var getTour = d_tour.GetAllTour();
            return Json(getTour, JsonRequestBehavior.AllowGet);
        }


        [HttpGet]
        [Route("GetOneTour")]
        public JsonResult GetOneTour(int maSoTour)
        {
            var getTour = d_tour.GetOneTour(maSoTour);
            return Json(getTour, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        [Route("GetTourLatest")]
        public JsonResult GetTourLatest()
        {
            var getTour = d_tour.GetAllTour().OrderByDescending(t=>t.maSoTour).First();
            return Json(getTour, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        [Route("Create")]
        public JsonResult Create(tour objTour)
        {

            return Json(d_tour.ThemTour(objTour), JsonRequestBehavior.AllowGet);

        }

        [HttpPost]
        [Route("Update")]
        public JsonResult Update(tour objTour, int maSoTour)
        {
            return Json(d_tour.SuaTour2(objTour, maSoTour), JsonRequestBehavior.AllowGet);

        }

        [HttpPost]
        [Route("Delete")]
        public JsonResult Delete(int maSoTour)
        {
            return Json(d_tour.XoaTour(maSoTour), JsonRequestBehavior.AllowGet);

        }

        //Giá tour
        [HttpGet]
        [Route("GetBangGiaTour")]
        public JsonResult GetBangGiaTour(int maSoTour)
        {
            var getGiaTour = d_giatour.GetGiaTourWithMaTour(maSoTour);
            return Json(getGiaTour, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        [Route("GetOneGiaTour")]
        public JsonResult GetOneGiaTour(int idGiaTour)
        {
            var getGiaTour = d_giatour.GetOneGiaTour(idGiaTour);
            return Json(getGiaTour, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        [Route("CreateGiaTour")]
        public JsonResult CreateGiaTour(giatour objGiaTour)
        {
            var getGiaTour = d_giatour.ThemGiaTour(objGiaTour);
            return Json(getGiaTour, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        [Route("UpdateGiaTour")]
        public JsonResult UpdateGiaTour(tour objTour, int maSoTour)
        {
            var getTour = d_tour.SuaGiaTour(objTour, maSoTour);
            return Json(getTour, JsonRequestBehavior.AllowGet);
        }

        //diadiemtour
        [HttpGet]
        [Route("GetDiaDiemTour")]
        public JsonResult GetDiaDiemTour(int maSoTour)
        {
            var get = d_diadiem.GetListOneDiaDiemTour(maSoTour);
            return Json(get, JsonRequestBehavior.AllowGet);
        }


    }
}