using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace IDGS904_tema1.Services
{
    public class LeerService
    {
        public Array LeerArchivo()
        {
            Array datos = null;

            //ruta en donde se va a guardar
            var infoMaestro = HttpContext.Current.Server.MapPath("~/App_Data/datos.txt");

            //Si el dato existe, que lea todas la l
            if(File.Exists(infoMaestro))
            {
                datos = File.ReadAllLines(infoMaestro);
            }
            return datos;
        }
    }
}