using SistemaGestionEntities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionData
{
    public class UsuarioData
    {
        private static string _connectionString = @"Server=JOSE-NOTEBOOK-D\SQLEXPRESS;Database=SistemaGestion;Trusted_Connection=True;";

        //ObtenerUsuario
        public static Usuario ObtenerUsuario(int id)
        {
            Usuario usuarioEncontrado = new Usuario();
            //.... Código
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();

                    string query = "SELECT Id, Nombre, Apellido, NombreUsuario, Contrasenia, Mail FROM Usuario WHERE Id = @id";
                    SqlCommand command = new SqlCommand(query, connection);

                    command.Parameters.AddWithValue("Id", id);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            usuarioEncontrado.Id = (int)reader["Id"];
                            usuarioEncontrado.Nombre = reader["Nombre"].ToString();
                            usuarioEncontrado.Apellido = reader["Apellido"].ToString();
                            usuarioEncontrado.NombreUsuario = reader["NombreUsuario"].ToString();
                            usuarioEncontrado.Contrasenia = reader["Contrasenia"].ToString();
                            usuarioEncontrado.Mail = reader["Mail"].ToString();
                        }
                    }
                }
            }
            catch (Exception)
            {
                usuarioEncontrado = new Usuario();
            }

            return usuarioEncontrado;
        }

        //ListarUsuarios
        public static List<Usuario> ListarUsuarios()
        {
            List<Usuario> lista = new List<Usuario>();
            //.... Código

            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();

                    string query = "SELECT Id, Nombre, Apellido, NombreUsuario, Contrasenia, Mail FROM Usuario";
                    SqlCommand command = new SqlCommand(query, connection);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Usuario usuario = new Usuario
                            {
                                Id = (int)reader["Id"],
                                Nombre = reader["Nombre"].ToString(),
                                Apellido = reader["Apellido"].ToString(),
                                NombreUsuario = reader["NombreUsuario"].ToString(),
                                Contrasenia = reader["Contrasenia"].ToString(),
                                Mail = reader["Mail"].ToString()
                            };
                            lista.Add(usuario);
                        }
                    }
                }
            }
            catch (Exception)
            {
                lista = new List<Usuario>();
            }

            return lista;
        }

        //CrearUsuario
        public static void CrearUsuario(Usuario usuario)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    string query = "INSERT INTO Usuario (Nombre, Apellido, NombreUsuario, Contrasenia, Mail) " +
                                   "VALUES (@Nombre, @Apellido, @NombreUsuario, @Contrasenia, @Mail)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Nombre", usuario.Nombre);
                        command.Parameters.AddWithValue("@Apellido", usuario.Apellido);
                        command.Parameters.AddWithValue("@NombreUsuario", usuario.NombreUsuario);
                        command.Parameters.AddWithValue("@Contrasenia", usuario.Contrasenia);
                        command.Parameters.AddWithValue("@Mail", usuario.Mail);

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

        //ModificarUsuario
        public static void ModificarUsuario(Usuario usuEditar)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    string query = "Update Usuario Set Nombre = @Nombre, Apellido=@Apellido, NombreUsuario=@NombreUsuario, Contrasenia=@Contrasenia, Mail=@Mail Where Id=@Id";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Nombre", usuEditar.Nombre);
                        command.Parameters.AddWithValue("@Apellido", usuEditar.Apellido);
                        command.Parameters.AddWithValue("@NombreUsuario", usuEditar.NombreUsuario);
                        command.Parameters.AddWithValue("@Contrasenia", usuEditar.Contrasenia);
                        command.Parameters.AddWithValue("@Mail", usuEditar.Mail);
                        command.Parameters.AddWithValue("@Id", usuEditar.Id);

                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Error al modificar usuario");
                throw;
            }
        }

        //EliminarUsuario
        public static void EliminarUsuario(int Id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    string query = "Delete From Usuario Where Id=@Id";

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
                Console.WriteLine("Error al eliminar usuario");
                throw;
            }
        }


    }
}
