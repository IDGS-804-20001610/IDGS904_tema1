using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Util;

namespace IDGS904_tema1.Models
{
    public class Traduction
    {
        public string Word { get; set; }
        public string NewWord { get; set; }
        public int Language { get; set; }

        public string Traduce()
        {
            string newwww = Word;
            //Creación e inicialización de una variable donde guardaremos la traducción
            string newW = "";
            //creación de una variable donde guardamos el path en el cual se encuentra el .txt
            var dictionary = HttpContext.Current.Server.MapPath("~/App_Data/traduction.txt");
            //creación de un arreglo el cual le damos el valor de lo que hay dentro del archivo .txt
            string[] lines = File.ReadAllLines(dictionary);

            //evaluación mediante una condiciónal if, "Si se escoge el radio button 2, se hara lo siguiente:"
            if (Language == 2)
            {
                //se crea una lista nueva
                List<string> word = new List<string>();
                //mediando un ciclo for en donde evaluamos linea por linea de todo el documento
                foreach (string line in lines)
                {
                    //se crea un arreglo llamado splitWord el cual le damos el valor de la línea en curso,
                    //mediante el .split(' ') partimos la línea cada que se encuentre un espaciado.
                    string[] splitWord = line.Split(' ');
                    //evaluamos mediante una condición, si la longitud del splitWord es igual o mayor a
                    //dos caracteres y el splitWord se encuentra en la primer columna será igual y es igual a la 
                    //palabra que queremos traducir se hará lo siguiente:
                    if(splitWord.Length >= 2 && splitWord[0].ToUpper() == newwww)
                    {
                        //en el arreglo que creamos anteriormente añadimos la palabra que se encuentre en la misma
                        //línea pero en la siguiente columna
                        word.Add(splitWord[1].ToUpper());
                        //regresamos la variable newN la cual le damos el valor de la línea pero en la siguiente
                        //columns
                        return  newW = splitWord[1].ToUpper();
                    }
                    else 
                    { 
                        newW = "NO EXISTE LA TRADUCCIÖN";
                    }
                }
            }
            else
            {
                List<string> word = new List<string>();
                foreach (string line in lines)
                {
                    string[] splitWord = line.Split(' ');
                    if (splitWord.Length >= 2 && splitWord[1].ToUpper() == newwww)
                    {
                        word.Add(splitWord[0].ToUpper());
                        return newW = splitWord[0].ToUpper();
                    }
                    else
                    {
                        newW = "NO EXISTE LA TRADUCCIÖN";
                    }
                }
            }

            return newW;
        }
    }
}