using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.Entity;
using System.Net;
using lalaweb.Models;


namespace lalaweb.Controllers
{
    
    public class HomeController : Controller
    {
        private CarStoreDataB db = new CarStoreDataB();
        public ActionResult Index()
        {
            return View();
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

        public ActionResult Car_List()
        {
            
        ViewBag.Message = "Your Car List.";

            return View(db.Cars.ToList());
        }

        public ActionResult Car_Info(int? id)
        {

            Car car = db.Cars.Find(id);

            return View(car);
        }

    }
}