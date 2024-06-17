using Microsoft.AspNetCore.Mvc;

using SistemaGestionBussiness;
using SistemaGestionEntities;

namespace SistemaGestionWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : Controller
    {
        [HttpGet(Name = "GetUsuarios")]
        public IEnumerable<Usuario> GetUsuarios()
        {
            return UsuarioBussiness.ListarUsuarios().ToArray();
        }

        [HttpGet("{id}")]
        public IActionResult GetUsuarioByUrl(int id)
        {   //Expone en url el id
            Usuario usuario = UsuarioBussiness.ObtenerUsuario(id);
            return Ok(usuario);
        }

        [HttpDelete(Name = "DeleteUsuarioById")]
        public void DeleteUsuarioById([FromBody] int id)
        {
            UsuarioBussiness.EliminarUsuarioId(id);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteUsuario(int id)
        {
            try
            {
                UsuarioBussiness.EliminarUsuarioId(id);
                return NoContent(); // Retornar 204 No Content
            }
            catch (Exception ex)
            {
                // Aquí puedes registrar el error o devolver una respuesta de error más detallada
                return StatusCode(StatusCodes.Status500InternalServerError, "Error al eliminar el Usuario");
            }
        }

        [HttpPost(Name = "CreateUsuario")]
        public void CreateUsuario([FromBody] Usuario usuario)
        {
            UsuarioBussiness.CrearUsuario(usuario);
        }

        [HttpPut(Name = "UpdateUsuarioById")]
        public void UpdateUsuarioById([FromBody] Usuario usuario)
        {
            UsuarioBussiness.ModificarUsuario(usuario);
        }

    }
}
