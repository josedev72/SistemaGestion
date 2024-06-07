using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionData
{
    public class ProductoData
    {
        

        private static string _connectionString = @"Server=JOSE-NOTEBOOK-D\SQLEXPRESS;Database=SistemaGestion;Trusted_Connection=True;";

        //ObtenerProducto
        public static Producto ObtenerProducto(int id)
        {
            Producto ProductoEncontrado = new Producto();
            //.... Código
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    //SELECT Id,Descripcion,Costo,PrecioVenta,Stock,IdUsuario FROM Producto

                    string query = "SELECT Id,Descripcion,Costo,PrecioVenta,Stock,IdUsuario FROM Producto WHERE Id = @id";
                    SqlCommand command = new SqlCommand(query, connection);

                    command.Parameters.AddWithValue("Id", id);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            ProductoEncontrado.Id = (int)reader["Id"];
                            ProductoEncontrado.Descripcion = reader["Descripcion"].ToString();
                            ProductoEncontrado.Costo = Convert.ToDecimal(reader["Costo"].ToString());
                            ProductoEncontrado.PrecioVenta = Convert.ToDecimal(reader["PrecioVenta"].ToString());
                            ProductoEncontrado.Stock = Convert.ToInt32(reader["Stock"].ToString());
                            ProductoEncontrado.IdUsuario = Convert.ToInt32(reader["IdUsuario"].ToString());
                        }
                    }
                }
            }
            catch (Exception)
            {
                ProductoEncontrado = new Producto();
            }

            return ProductoEncontrado;
        }

        //ListarProductos
        public static List<Producto> ListarProductos()
        {
            List<Producto> lista = new List<Producto>();
            //.... Código

            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();

                    string query = "SELECT Id,Descripcion,Costo,PrecioVenta,Stock,IdUsuario FROM Producto";
                    SqlCommand command = new SqlCommand(query, connection);
                    //using (SqlDataReader reader = command.ExecuteReader())
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Producto Producto = new Producto
                            {
                                Id = (int)reader["Id"],
                                Descripcion = reader["Descripcion"].ToString(),
                                Costo = Convert.ToDecimal(reader["Costo"].ToString()),
                                PrecioVenta = Convert.ToDecimal(reader["PrecioVenta"].ToString()),
                                Stock = Convert.ToInt32(reader["Stock"].ToString()),
                                IdUsuario = Convert.ToInt32(reader["IdUsuario"].ToString())
                            };
                            lista.Add(Producto);
                        }
                    }
                }
            }
            catch (Exception)
            {
                lista = new List<Producto>();
            }

            return lista;
        }

        //CrearProducto
        public static void CrearProducto(Producto Producto)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    string query = "INSERT INTO Producto (Descripcion,Costo,PrecioVenta,Stock,IdUsuario) " +
                                   "VALUES (@Descripcion, @Costo, @PrecioVenta,@Stock,@IdUsuario)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Descripcion", Producto.Descripcion);
                        command.Parameters.AddWithValue("@Costo", Producto.Costo);
                        command.Parameters.AddWithValue("@PrecioVenta", Producto.PrecioVenta);
                        command.Parameters.AddWithValue("@Stock", Producto.Stock);
                        command.Parameters.AddWithValue("@IdUsuario", Producto.IdUsuario);

                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        //ModificarProducto
        public static void ModificarProducto(Producto productoEditar)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    string query = "Update Producto Set Descripcion=@Descripcion, Costo=@Costo, PrecioVenta=@PrecioVenta, Stock=@Stock, IdUsuario=@IdUsuario Where Id=@Id";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Descripcion", productoEditar.Descripcion);
                        command.Parameters.AddWithValue("@Costo", productoEditar.Costo);
                        command.Parameters.AddWithValue("@PrecioVenta", productoEditar.PrecioVenta);
                        command.Parameters.AddWithValue("@Stock", productoEditar.Stock);
                        command.Parameters.AddWithValue("@IdUsuario", productoEditar.IdUsuario);
                        command.Parameters.AddWithValue("@Id", productoEditar.Id);

                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Error al modificar Producto");
                throw;
            }
        }

        //EliminarProducto
        public static void EliminarProductoId(int Id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    string query = "Delete From Producto Where Id=@Id";

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
                Console.WriteLine("Error al eliminar Producto");
                throw;
            }
        }

        
    }
}
