using Microsoft.AspNetCore.Mvc;

using SistemaGestionBussiness;
using SistemaGestionEntities;

namespace SistemaGestionWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VentaController : Controller
    {
        [HttpGet(Name = "GetVentas")]
        public IEnumerable<Venta> GetVentas()
        {
            return VentaBussiness.ListarVentas().ToArray();
        }

        [HttpGet("{id}")]
        public IActionResult GetVentaByUrl(int id)
        {   //Expone en url el id
            Venta venta = VentaBussiness.ObtenerVenta(id);
            return Ok(venta);
        }

        [HttpDelete(Name = "DeleteVentaById")]
        public void DeleteVentaById([FromBody] int id)
        {
            VentaBussiness.EliminarVentaId(id);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteVenta(int id)
        {
            try
            {
                VentaBussiness.EliminarVentaId(id);
                return NoContent(); // Retornar 204 No Content
            }
            catch (Exception ex)
            {
                // Aquí puedes registrar el error o devolver una respuesta de error más detallada
                return StatusCode(StatusCodes.Status500InternalServerError, "Error al eliminar la Venta");
            }
        }

        [HttpPost(Name = "CreateVenta")]
        public void CreateVenta([FromBody] Venta venta)
        {
            VentaBussiness.CrearVenta(venta);
        }

        [HttpPut(Name = "UpdateVentaById")]
        public void UpdateVentaById([FromBody] Venta venta)
        {
            VentaBussiness.ModificarVenta(venta);
        }

    }
}
