using IDGS904_tema1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS904_tema1.Controllers
{
    public class GradosController : Controller
    {
        // GET: Grados
        public ActionResult Index()
        {
            return View();
        }

        public RedirectToRouteResult Index2(Grados g)
        {
            g.Res = g.Conver();
            TempData["Res"] = g.Res;
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