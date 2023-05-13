using IDGS904_tema1.Models;
using IDGS904_tema1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS904_tema1.Controllers
{
    public class NuevoController : Controller
    {
        // GET: Nuevo
        public ActionResult NuevaVista()
        {
            ViewBag.Nombre = "BCRH";
            return View();
        }

        public ActionResult Vista(string n1, string n2)
        {
            int res = Convert.ToInt32(n1) + Convert.ToInt32(n2);
            ViewBag.Res = Convert.ToString(res);
            return View();
        }

        public ActionResult Calcular(OperasBas op)
        {
            op.Res = op.Result();
            ViewBag.Res = op.Res;
            return View();

        }

        public ActionResult MuestraPulques()
        {
            var pulques = new ProductoService();
            var model = pulques.ObtenerProducto();

            return View(model);
        }
    }
}
