using IDGS904_tema1.Models;
using IDGS904_tema1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS904_tema1.Controllers
{
    public class TraduccionController : Controller
    {
        // GET: Traduccion
        public ActionResult Save(Dictionary d)
        {
            var save = new SaveWords();
            save.SaveWord(d);

            var fille = new ReadWords();
            ViewBag.Dictio = fille.ReadWord();
            return View();
        }

        public ActionResult Dictio(Traduction t)
        {
            t.NewWord = t.Traduce();
            ViewBag.Trad = t.NewWord;
            return View();


        }
    }
}