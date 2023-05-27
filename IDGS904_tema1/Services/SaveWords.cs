using IDGS904_tema1.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Helpers;

namespace IDGS904_tema1.Services
{
    public class SaveWords
    {
        public void SaveWord(Dictionary t)
        {
            var spanish = t.Spanish;
            var english= t.English;

            var data = spanish + " " + english + Environment.NewLine;
            var file = HttpContext.Current.Server.MapPath("~/App_Data/traduction.txt");
            File.AppendAllText(file, data);
        }
    }
}