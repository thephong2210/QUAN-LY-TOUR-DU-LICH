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
        // GET: diadiem
        public ActionResult Index()
        {
            B_diadiemden b_diadiem = new B_diadiemden();
            List<diadiemden> listResults = b_diadiem.GetListDiaDiemDen();

            ViewBag.listTemp = listResults;

            return View();
        }


    }
}