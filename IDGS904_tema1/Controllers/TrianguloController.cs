using IDGS904_tema1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS904_tema1.Controllers
{
    public class TrianguloController : Controller
    {
        // GET: Triangulo
        public ActionResult Form()
        {
            return View();
        }

        public RedirectToRouteResult Next(Triangulo t)
        {
            if (t.IsorNot() == true)
            {
                t.Res = t.What(); 
                
            }
            else
            {
                t.Res = "NO ES UN TRIÁNGULO";
            }

            TempData["Res"] = t.Res;
            return RedirectToAction("Result");
        }

        public ActionResult Result()
        {
            string Res = "";
            if (TempData.ContainsKey("Res"))
            {
                Res = TempData["Res"].ToString();
            }
            ViewBag.Res = Res;
            return View();
        }
    }
}