using BUS;
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
        // GET: doandulich
        public ActionResult Index()
        {
            B_doan b_doan = new B_doan();
            List<dynamic> listResults = b_doan.GetListDoan();

            //convert List<dynamic> sang json
            var objOld = JsonConvert.SerializeObject(listResults);
            //convert json sang List<NhanVienView>
            var obj = JsonConvert.DeserializeObject<List<DoanView>>(objOld);

            ViewBag.listTemp = obj;

            return View();
        }


    }
}