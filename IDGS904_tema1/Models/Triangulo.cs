using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IDGS904_tema1.Models
{
    public class Triangulo
    {
        public double x1 { get; set; }
        public double y1 { get; set; }
        public double x2 { get; set; }
        public double y2 { get; set; }
        public double x3 { get; set; }
        public double y3 { get; set; }
        public string Res { get; set; }

        public bool IsorNot()
        {

            double area = (x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2)) / 2;
            return area > 0;

        }

        public string What()
        {
            string type = "";
            double ab1 = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            double ab = Math.Round(ab1, 1);
            double ac1 = Math.Sqrt(Math.Pow(x3 - x1, 2) + Math.Pow(y3 - y1, 2));
            double ac = Math.Round(ac1, 1);
            double bc1 = Math.Sqrt(Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2));
            double bc = Math.Round(bc1, 1);


            if (ab == ac && ab == bc)
            {
                type = "SÍ ES UN TRÍANGULO, ES UN EQUILATERO";

            }
            else if(ab == ac || ac == bc || bc == ab)
            {
                type = "SÍ ES UN TRÍANGULO, ES UN ESCALENO";
            }
            else
            {
                type = "SÍ ES UN TRÍANGULO, ES UN ISOCELES";
            }
            return type;
        }
    }

}