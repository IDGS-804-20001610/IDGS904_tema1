using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;


namespace IDGS904_tema1.Models
{
    public class OperasBas
    {
        public double Num1 { get; set; }

        public double Num2 { get; set; }

        public int Ope { set; get; }

        public double Res { get; set; }

        public double Add()
        {
            return (Num1 + Num2);
        }
        public double Minus()
        {
            return (Num1 - Num2);
        }
        public double Multiply()
        {
            return (Num1 * Num2);
        }
        public double Divide()
        {
            return (Num1 / Num2);
        }

        public double Result()
        {
            double result = 0;
            if (Ope == 1)
            {
                result = Add();
            }
            if (Ope == 2)
            {
                result = Minus();
            }
            if (Ope == 3)
            {
                result = Multiply();
            }
            if (Ope == 4)
            {
                result = Divide();
            }
            return result;
        }
    }
}