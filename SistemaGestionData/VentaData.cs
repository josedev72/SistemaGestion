using SistemaGestionEntities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionData
{
    public class VentaData
    {
        private static string _connectionString = CadenaCnx.ObtenerCadena();

        //Obtener Venta
        public static Venta ObtenerVenta(int id)
        {
            Venta VentaEncontrado = new Venta();
            try
            {
                using (var connection = new SqlConnection(_connectionString))
                {
                    string query = "SELECT Id, Comentarios, IdUsuario FROM Venta WHERE Id = @id";
                    
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);

                    command.Parameters.AddWithValue("Id", id);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            VentaEncontrado = new Venta();

                            VentaEncontrado.Id = Convert.ToInt32(reader["Id"]);
                            VentaEncontrado.Comentarios = reader["Comentarios"].ToString();
                            VentaEncontrado.IdUsuario = Convert.ToInt32(reader["IdUsuario"].ToString());
                        }
                    }
                }
            }
            catch (Exception)
            {
                VentaEncontrado = new Venta();
                Console.WriteLine("Error al obtener venta");
            }

            return VentaEncontrado;
        }

        //Listar Ventas
        public static List<Venta> ListarVentas()
        {
            List<Venta> lista = new List<Venta>();

            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    string query = "SELECT Id,Comentarios,IdUsuario FROM Venta";

                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Venta Venta = new Venta
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                Comentarios = reader["Comentarios"].ToString(),
                                IdUsuario = Convert.ToInt32(reader["IdUsuario"])
                            };
                            lista.Add(Venta);
                        }
                    }
                }
            }
            catch (Exception)
            {
                lista = new List<Venta>();
                Console.WriteLine("Error al cargar listado de ventas");
            }

            return lista;
        }

        //Crear Venta
        public static void CrearVenta(Venta Venta)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    string query = "INSERT INTO Venta (Comentarios,IdUsuario) " +
                                   "VALUES (@Comentarios, @IdUsuario)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Comentarios", Venta.Comentarios);
                        command.Parameters.AddWithValue("@IdUsuario", Venta.IdUsuario);

                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Error al crear venta");
            }
        }

        //Modificar Venta
        public static void ModificarVenta(Venta ventaEditar)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    string query = "Update Venta Set Comentarios = @Comentarios, IdUsuario=@IdUsuario Where Id=@Id";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Comentarios", ventaEditar.Comentarios);
                        command.Parameters.AddWithValue("@IdUsuario", ventaEditar.IdUsuario);
                        command.Parameters.AddWithValue("@Id", ventaEditar.Id);

                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Error al modificar Venta");
            }
        }

        //Eliminar Venta
        public static void EliminarVentaId(int Id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    string query = "Delete From Venta Where Id=@Id";

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
                Console.WriteLine("Error al eliminar Venta");
            }
        }
    }
}
