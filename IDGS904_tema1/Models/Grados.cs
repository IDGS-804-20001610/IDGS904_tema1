using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IDGS904_tema1.Models
{
    public class Grados
    {
        public double Grado { get; set; }

        public int Tipo { set; get; }

        public string Res { set; get; }

        public string Conver()
        {
            if(Tipo == 1)
            {
                return "From " + Convert.ToString(Grado) + "° Fahrenheit to " + 
                    Convert.ToString((Grado * 9 / 5) + 32) + "° Celsius";
            }
            else 
            {
                return "From " + Convert.ToString(Grado) + "° Celsius to " + 
                    Convert.ToString((Grado - 32) * 5 / 9) + "° Fahrenheit";
            }
        }
    }
}