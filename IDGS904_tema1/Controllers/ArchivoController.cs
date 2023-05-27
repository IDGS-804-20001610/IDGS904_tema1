using IDGS904_tema1.Models;
using IDGS904_tema1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS904_tema1.Controllers
{
    public class ArchivoController : Controller
    {
        // GET: Archivo
        public ActionResult Registrar()
        {
            return View();
        }

        // POST
        [HttpPost]
        public ActionResult Registrar(Maestros m)
        {
            var op1 = new GuardarService();
            op1.GuardaArchivo(m);
            return View();
        }

        public ActionResult LeerDatos()
        {
            var arch = new LeerService();

            ViewBag.Archivo = arch.LeerArchivo();

            return View();
        }
    }
}