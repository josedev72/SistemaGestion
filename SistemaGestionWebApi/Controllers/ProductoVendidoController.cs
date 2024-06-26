﻿using Microsoft.AspNetCore.Mvc;

using SistemaGestionBussiness;
using SistemaGestionData;
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

        [HttpDelete("{id}")]
        public IActionResult DeleteProductoVendido(int id)
        {
            try
            {
                ProductoVendidoBussiness.EliminarProductoVendidoId(id);
                return NoContent(); // Retornar 204 No Content
            }
            catch (Exception ex)
            {
                // Aquí puedes registrar el error o devolver una respuesta de error más detallada
                return StatusCode(StatusCodes.Status500InternalServerError, "Error al eliminar el Producto Vendido");
            }
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

        [HttpPut("{id}/{idProducto}/{stock}/{idVenta}", Name = "UpdateProductoVendidoByIdJs")]
        public void UpdateProductoVendidoByIdJs(int id, int idProducto, decimal stock, decimal idVenta)
        {
            var productoVendido = new ProductoVendido
            {
                Id = id,
                IdProducto = idProducto,
                Stock = stock,
                IdVenta = idVenta
            };

            ProductoVendidoBussiness.ModificarProductoVendido(productoVendido);
        }

    }
}
