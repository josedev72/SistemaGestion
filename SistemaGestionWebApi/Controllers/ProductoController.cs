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



    }
}
