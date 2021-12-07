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
        // GET: khachhang
        public ActionResult Index()
        {
            B_KH b_KH = new B_KH();
            List<khachhang> listResults = b_KH.GetKhachHang();

            ViewBag.listTemp = listResults;

            return View();
        }


    }
}