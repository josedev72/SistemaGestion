using SistemaGestionData;
using SistemaGestionEntities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionBussiness
{
    public class ProductoBussiness
    {
        public static List<Producto> ListarProductos()
        {
            return ProductoData.ListarProductos();
        }

        public static void CrearProducto(Producto p)
        {
            ProductoData.CrearProducto(p);
        }

        public static void ModificarProducto(Producto p)
        {
            ProductoData.ModificarProducto(p);
        }

        public static Producto ObtenerProducto(int Id)
        {
            return ProductoData.ObtenerProducto(Id);
        }

        public static void EliminarProductoId(int id)
        {
            ProductoData.EliminarProductoId(id);
        }

    }
}
