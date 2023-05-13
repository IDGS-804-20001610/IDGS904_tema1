using IDGS904_tema1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS904_tema1.Controllers
{
    public class DistanciaController : Controller
    {
        // GET: Distancia
        public RedirectToRouteResult Index(Distancia d)
        {
            
            d.Res = d.Distance();

            //TempData["x1"] = d.x1;
            //TempData["y1"] = d.x1;
            //TempData["x2"] = d.x1;
            //TempData["y2"] = d.x1;
            TempData["Res"] = d.Res;
            return RedirectToAction("Index2");
        }

        public ActionResult Index2()
        {
            string Res = "";
            if (TempData.ContainsKey("Res"))
            {
                Res = TempData["Res"] as string;
            }
            ViewBag.Res = Res;
            return View();
        }
    }
}