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
        // GET: loaihinhdulich
        public ActionResult Index()
        {
            B_loaihinhdulich b_LHDL = new B_loaihinhdulich();
            List<loaihinhdulich> listResults = b_LHDL.GetListLoaiHinhDL();

            ViewBag.listTemp = listResults;

            return View();
        }


    }
}