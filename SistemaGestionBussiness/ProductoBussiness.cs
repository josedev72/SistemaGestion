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
        public static void CrearProducto(Producto p)
        {
            ProductoData.CrearProducto(p);
        }

        public static void ModificarProducto(Producto p)
        {
            ProductoData.ModificarProducto(p);
        }

        public static List<Producto> ListarProductos()
        {
            return ProductoData.ListarProductos();
        }

        public static Producto ObtenerProducto(int Id)
        {
            return ProductoData.ObtenerProducto(Id);
        }

        public static void EliminarProductoId(int id)
        {
            ProductoData.EliminarProductoId(id);
        }

        public static void EliminarUsuarioId(int id)
        {
            throw new NotImplementedException();
        }

        public static void EliminarVentaId(int id)
        {
            throw new NotImplementedException();
        }
    }
}
