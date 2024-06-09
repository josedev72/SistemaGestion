using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionData
{
    internal class CadenaCnx
    {
        private static string _cnx = @"Server=JOSE-NOTEBOOK-D\SQLEXPRESS;Database=SistemaGestion;Trusted_Connection=True;";

        private CadenaCnx()
        {
            
        }

        public static string ObtenerCadena()
        {
            return _cnx;
        }

    }
}
