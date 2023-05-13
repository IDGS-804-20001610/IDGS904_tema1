using IDGS904_tema1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IDGS904_tema1.Services
{
    public class ProductoService
    {
        public List<Productos> ObtenerProducto()
        {
            var producto1 = new Productos()
            {
                Nombre = "Puelque1",
                Descripcion = "Frutos Rojos",
                Cantidad = 10,
                Produccion = new DateTime(2023, 11, 5)
            };

            var producto2 = new Productos()
            {
                Nombre = "Puelque2",
                Descripcion = "Mango Piña",
                Cantidad = 35,
                Produccion = new DateTime(2023, 6, 10)
            };

            return new List<Productos>{producto1, producto2};
        }
    }
}