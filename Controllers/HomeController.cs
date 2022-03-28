using ProjectDotNet.DAO;
using ProjectDotNet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectDotNet.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<String> dsHang = Services.getAllHang();
            List<LaptopInfo> products = new List<LaptopInfo>();
            foreach (String hang in dsHang)
            {
                products.AddRange(Services.getTop4Product(hang));
            }
            ViewBag.dsHang = dsHang;
            return View(products);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}