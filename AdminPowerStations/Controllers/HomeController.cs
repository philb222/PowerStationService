using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AdminPowerStations.Helpers;
using AdminPowerStations.Models;

namespace AdminPowerStations.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View(new Home());
        }

        public ActionResult Populate()
        {
            DbFunctions.PopulateDB();

            return RedirectToAction("Index");
        }

        public ActionResult DeleteAllRows()
        {
            DbFunctions.DeleteAllRows();

            return RedirectToAction("Index");
        }
    }
}
