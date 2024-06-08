using SistemaGestionData;
using SistemaGestionEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionBussiness
{
    public class VentaBussiness
    {
        public static List<Venta> ListarVentas()
        {
            return VentaData.ListarVentas();
        }

        public static void CrearVenta(Venta v)
        {
            VentaData.CrearVenta(v);
        }

        public static void ModificarVenta(Venta v)
        {
            VentaData.ModificarVenta(v);
        }

        public static Venta ObtenerVenta(int Id)
        {
            return VentaData.ObtenerVenta(Id);
        }

        public static void EliminarVentaId(int id)
        {
            VentaData.EliminarVentaId(id);
        }
    }
}
