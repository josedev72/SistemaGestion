using Microsoft.AspNetCore.Mvc;

using SistemaGestionBussiness;
using SistemaGestionEntities;

namespace SistemaGestionWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoVendidoController : Controller
    {
        [HttpGet(Name = "GetProductosVendidos")]
        public IEnumerable<ProductoVendido> GetProductosVendidos()
        {
            return ProductoVendidoBussiness.ListarProductosVendidos().ToArray();
        }

        [HttpGet("{id}")]
        public IActionResult GetProductoVendidoByUrl(int id)
        {   //Expone en url el id
            ProductoVendido productoVendido = ProductoVendidoBussiness.ObtenerProductoVendido(id);
            return Ok(productoVendido);
        }

        [HttpDelete(Name = "DeleteProductoVendidoById")]
        public void DeleteProductoVendidoById([FromBody] int id)
        {
            ProductoVendidoBussiness.EliminarProductoVendidoId(id);
        }

        [HttpPost(Name = "CreateProductoVendido")]
        public void CreateProductoVendido([FromBody] ProductoVendido productoVendido)
        {
            ProductoVendidoBussiness.CrearProductoVendido(productoVendido);
        }

        [HttpPut(Name = "UpdateProductoVendidoById")]
        public void UpdateProductoVendidoById([FromBody] ProductoVendido productoVendido)
        {
            ProductoVendidoBussiness.ModificarProductoVendido(productoVendido);
        }

    }
}
