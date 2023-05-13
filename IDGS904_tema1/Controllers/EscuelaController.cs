using IDGS904_tema1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS904_tema1.Controllers
{
    public class EscuelaController : Controller
    {
        // GET: Escuela

        //ContentResult, ViewResult, ActionResult
        public ActionResult Index()
        {
            var pulque = new Productos()
            {
                Nombre = "Pulque1",
                Descripcion = "Strawberry",
                Cantidad = 10,
                Produccion = new DateTime(2021, 11, 2)
            };
            return Json(pulque, JsonRequestBehavior.AllowGet);
            //return View();
        }
        //Para redireccionar a...
        public RedirectResult Vista()
        {
            return Redirect("https://google.com.mx");
        }

        public RedirectToRouteResult Vista2()
        {
            TempData["Nombre"] = "Brenda";
            return RedirectToAction("Index2");
        }

        public ActionResult Index2()
        {
            ViewBag.Grupo = "IDGS904";
            ViewData["Materia"] = "DWI";

            string nombre = "";
            if(TempData.ContainsKey("Nombre"))
            {
                nombre = TempData["Nombre"] as string;
            }

            ViewBag.valor = nombre;
            return View();
        }
    }
}