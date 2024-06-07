using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionData
{
    public class Producto
    {
        public int Id { get; set; }
        public string Descripcion { get; set; } = string.Empty;  // Valor predeterminado
        public decimal Costo { get; set; } = 0;
        public decimal PrecioVenta { get; set; } = 0;
        public int Stock { get; set; } = 0;
        public int IdUsuario { get; set; }

        public Producto()
        {

        }

        public Producto(int id, string descripcion, decimal costo, decimal precioVenta, int stock, int idUsuario)
        {
            Id = id;
            Descripcion = descripcion;
            Costo = costo;
            PrecioVenta = precioVenta;
            Stock = stock;
            IdUsuario = idUsuario;
        }
    }
}
