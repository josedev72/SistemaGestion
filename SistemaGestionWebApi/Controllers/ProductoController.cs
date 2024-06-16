using Microsoft.AspNetCore.Mvc;

using SistemaGestionBussiness;
using SistemaGestionData;

namespace SistemaGestionWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : Controller
    {
        [HttpGet(Name = "GetProductos")]
        public IEnumerable<Producto> GetProductos()
        {
            return ProductoBussiness.ListarProductos().ToArray();
        }

        [HttpGet("{id}")]
        public IActionResult GetProductoByUrl(int id)
        {   //Expone en url el id
            Producto producto = ProductoBussiness.ObtenerProducto(id);
            return Ok(producto);
        }

        [HttpDelete(Name = "DeleteProducto")]
        public void DeleteProducto([FromBody] int id)
        {
            ProductoBussiness.EliminarProductoId(id);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteProductoById(int id)
        {
            try
            {
                ProductoBussiness.EliminarProductoId(id);
                return NoContent(); // Retornar 204 No Content
            }
            catch (Exception ex)
            {
                // Aquí puedes registrar el error o devolver una respuesta de error más detallada
                return StatusCode(StatusCodes.Status500InternalServerError, "Error al eliminar el producto");
            }
        }

        [HttpPost(Name = "CreateProducto")]
        public void CreateProducto([FromBody] Producto producto)
        {
            ProductoBussiness.CrearProducto(producto);
        }

        [HttpPut(Name = "UpdateProducto")]
        public void UpdateProducto([FromBody] Producto producto)
        {
            ProductoBussiness.ModificarProducto(producto);
        }

        //[HttpPut("{id}")]
        //public IActionResult UpdateProductoById(int id)
        //{
        //    try
        //    {
        //        Producto productoEdit = ProductoBussiness.ObtenerProducto(id);
        //        ProductoBussiness.ModificarProducto(id);
        //        return NoContent(); // Retornar 204 No Content
        //    }
        //    catch (Exception ex)
        //    {
        //        // Aquí puedes registrar el error o devolver una respuesta de error más detallada
        //        return StatusCode(StatusCodes.Status500InternalServerError, "Error al eliminar el producto");
        //    }
        //}



    }
}
