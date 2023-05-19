using IDGS904_tema1.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace IDGS904_tema1.Services
{
    public class GuardarService
    {
        public void GuardaArchivo(Maestros m)
        {
            var nombre = m.Nombre;
            var apaterno = m.Apaterno;
            var amaterno = m.Amaterno;
            var edad = m.Edad;
            var email = m.Emaii;

            //Environment.NewLine --> es un salto de línea
            var datos = nombre + ", " + apaterno + ", " + amaterno + ", " + edad + ", " + email + Environment.NewLine;

            //~ ayuda a identificar la carpeta que está dentro del proyecto
            var aricho = HttpContext.Current.Server.MapPath("~/App_Data/datos.txt");

            //Si el archivo existe, se sobre escribe, sino existe, lo crea
            //File.WriteAllText(aricho, datos);

            // si el archivo no existe, lo crea, añade la cadena de texto
            File.AppendAllText(aricho, datos);
        }
    }
}