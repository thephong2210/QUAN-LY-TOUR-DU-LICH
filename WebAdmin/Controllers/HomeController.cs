using BUS;
using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAdmin.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            B_nhanvien b_NhanVien = new B_nhanvien();

            List<nhanvien> listNhanVien = b_NhanVien.GetAllNhanVien();

            foreach (var item in listNhanVien)
            {
                ViewBag.Message += item.tenNhanVien + " ";
            }
            

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}