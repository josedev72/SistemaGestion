using SistemaGestionEntities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionData
{
    public class ProductoVendidoData
    {
        private static string _connectionString = @"Server=JOSE-NOTEBOOK-D\SQLEXPRESS;Database=SistemaGestion;Trusted_Connection=True;";

        //Obtener ProductoVendido x id
        public static ProductoVendido ObtenerProductoVendido(int id)
        {
            ProductoVendido ProductoVendidoEncontrado = new ProductoVendido();
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    string query = "SELECT Id,IdProducto,Stock,IdVenta FROM ProductoVendido WHERE Id = @id";
                    
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);

                    command.Parameters.AddWithValue("@Id", id);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            ProductoVendidoEncontrado.Id = Convert.ToInt32(reader["Id"].ToString());
                            ProductoVendidoEncontrado.IdProducto = Convert.ToInt32(reader["IdProducto"].ToString());
                            ProductoVendidoEncontrado.Stock = Convert.ToDecimal(reader["Stock"].ToString());
                            ProductoVendidoEncontrado.IdVenta = Convert.ToDecimal(reader["IdVenta"].ToString());
                        }
                    }
                }
            }
            catch (Exception)
            {
                ProductoVendidoEncontrado = new ProductoVendido();
                Console.WriteLine("Error al obtener producto");
            }

            return ProductoVendidoEncontrado;
        }

        //Listar ProductoVendidos
        public static List<ProductoVendido> ListarProductosVendidos()
        {
            List<ProductoVendido> lista = new List<ProductoVendido>();

            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();

                    string query = "SELECT Id, IdProducto, Stock, IdVenta FROM ProductoVendido";
                    SqlCommand command = new SqlCommand(query, connection);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ProductoVendido ProductoVendido = new ProductoVendido();

                            ProductoVendido.Id = Convert.ToInt32(reader["Id"].ToString());
                            ProductoVendido.IdProducto = Convert.ToInt32(reader["IdProducto"].ToString());
                            ProductoVendido.Stock = Convert.ToDecimal(reader["Stock"].ToString());
                            ProductoVendido.IdVenta = Convert.ToDecimal(reader["IdVenta"].ToString());

                            lista.Add(ProductoVendido);
                        }
                    }
                }
            }
            catch (Exception)
            {
                lista = new List<ProductoVendido>();
                Console.WriteLine("Error al cargar listado");
            }

            return lista;
        }

        //Crear ProductoVendido
        public static void CrearProductoVendido(ProductoVendido ProductoVendido)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    string query = "INSERT INTO ProductoVendido (IdProducto, Stock, IdVenta) " +
                                   "VALUES (@IdProducto, @Stock, @IdVenta)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@IdProducto", ProductoVendido.IdProducto);
                        command.Parameters.AddWithValue("@Stock", ProductoVendido.Stock);
                        command.Parameters.AddWithValue("@IdVenta", ProductoVendido.IdVenta);

                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Error al crear producto vendido");
            }
        }

        //ModificarProductoVendido
        public static void ModificarProductoVendido(ProductoVendido ProductoVendidoEditar)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    string query = "Update ProductoVendido Set IdProducto = @IdProducto, Stock=@Stock, IdVenta=@IdVenta Where Id=@Id";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@IdProducto", ProductoVendidoEditar.IdProducto);
                        command.Parameters.AddWithValue("@Stock", ProductoVendidoEditar.Stock);
                        command.Parameters.AddWithValue("@IdVenta", ProductoVendidoEditar.IdVenta);
                        command.Parameters.AddWithValue("@Id", ProductoVendidoEditar.Id);

                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Error al modificar ProductoVendido");
            }
        }

        //EliminarProductoVendido
        public static void EliminarProductoVendidoId(int Id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    string query = "Delete From ProductoVendido Where Id=@Id";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Id", Id);

                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Error al eliminar ProductoVendido");
            }
        }
    }
}
