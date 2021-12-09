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
        // GET: Tour
        public ActionResult Index()
        {
            List<dynamic> listResults = d_tour.GetListTour();

            //convert List<dynamic> sang json
            var objOld = JsonConvert.SerializeObject(listResults);
            //convert json sang List<NhanVienView>
            var obj = JsonConvert.DeserializeObject<List<TourView>>(objOld);

            ViewBag.listTemp = obj;

            return View();
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
            return Json(d_tour.SuaTour(objTour, maSoTour), JsonRequestBehavior.AllowGet);

        }

        [HttpPost]
        [Route("Delete")]
        public JsonResult Delete(int maSoTour)
        {
            return Json(d_tour.XoaTour(maSoTour), JsonRequestBehavior.AllowGet);

        }
    }
}