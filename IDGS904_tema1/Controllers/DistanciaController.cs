using IDGS904_tema1.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS904_tema1.Controllers
{
    public class DistanciaController : Controller
    {
        // GET: Distancia
        public ActionResult Index()
        {
            return View();
        }

        public RedirectToRouteResult Index2(Distancia d)
        {
            d.Res = d.Distance();
            TempData["Res"] = d.Res;
            return RedirectToAction("Index3");
        }

        public ActionResult Index3()
        {
            string Res = "";
            if (TempData.ContainsKey("Res"))
            {
                Res = TempData["Res"].ToString();
            }
            ViewBag.Res = Res;


            //ViewBag.Res =  (TempData.Peek("Res").ToString());
            return View();
        }
    }
}