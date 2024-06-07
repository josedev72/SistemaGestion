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
        private static string _connectionString = @"Server=JOSE-NOTEBOOK-D\SQLEXPRESS;Database=SistemaGestion;Trusted_Connection=True;";

        //ObtenerVenta
        public static Venta ObtenerVenta(int id)
        {
            Venta VentaEncontrado = new Venta();
            //.... Código
            try
            {
                using (var connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    // SELECT Id,Comentarios,IdUsuario FROM Venta

                    string query = "SELECT Id, Comentarios, IdUsuario FROM Venta WHERE Id = @id";
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
            }

            return VentaEncontrado;
        }

        //ListarVentas
        public static List<Venta> ListarVentas()
        {
            List<Venta> lista = new List<Venta>();
            //.... Código

            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();

                    string query = "SELECT Id,Comentarios,IdUsuario FROM Venta";
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
            }

            return lista;
        }

        //CrearVenta
        public static void CrearVenta(Venta Venta)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    //SELECT Id,Comentarios,IdUsuario FROM Venta
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
                throw;
            }
        }

        //ModificarVenta
        public static void ModificarVenta(Venta ventaEditar)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    //SELECT Id,Comentarios,IdUsuario FROM Venta
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
                throw;
            }
        }

        //EliminarVenta
        public static void EliminarVenta(int Id)
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
                throw;
            }
        }
    }
}
