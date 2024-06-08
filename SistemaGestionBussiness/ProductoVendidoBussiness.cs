using SistemaGestionData;
using SistemaGestionEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionBussiness
{
    public class ProductoVendidoBussiness
    {

        public static void CrearProductoVendido(ProductoVendido pv)
        {
            ProductoVendidoData.CrearProductoVendido(pv);
        }

        public static void ModificarProductoVendido(ProductoVendido pv)
        {
            ProductoVendidoData.ModificarProductoVendido(pv);
        }

        public static List<ProductoVendido> ListarProductosVendidos()
        {
            return ProductoVendidoData.ListarProductosVendidos();
        }

        public static ProductoVendido ObtenerProductoVendido(int Id)
        {
            return ProductoVendidoData.ObtenerProductoVendido(Id);
        }

        public static void EliminarProductoVendidoId(int id)
        {
            ProductoVendidoData.EliminarProductoVendidoId(id);
        }

    }
}
