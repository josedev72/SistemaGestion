using SistemaGestionData;
using SistemaGestionEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionBussiness
{
    public class UsuarioBussiness
    {

        public static List<Usuario> ListarUsuarios() 
        {
            return UsuarioData.ListarUsuarios();
        }

        public static void CrearUsuario(Usuario u)
        {
            UsuarioData.CrearUsuario(u);
        }

        public static void ModificarUsuario(Usuario u)
        {
            UsuarioData.ModificarUsuario(u);
        }

        public static Usuario ObtenerUsuario(int Id)
        {
            return UsuarioData.ObtenerUsuario(Id);
        }

        public static void EliminarUsuarioId(int id)
        {
            UsuarioData.EliminarUsuarioId(id);
        }




    }
}
