using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace IDGS904_tema1.Services
{
    public class ReadWords
    {
        public Array ReadWord()
        {
            Array data = null;

            //ruta en donde se va a guardar
            var dictionary = HttpContext.Current.Server.MapPath("~/App_Data/traduction.txt");

            //Si el dato existe, que lea todas la l
            if (File.Exists(dictionary))
            {
                data = File.ReadAllLines(dictionary);
            }
            return data;
        }
    }
}