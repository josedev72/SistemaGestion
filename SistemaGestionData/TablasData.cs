//using SistemaGestionEntities;
using System.Data.SqlClient;

namespace SistemaGestionData
{
    public class TablasData
    {
        private static string _connectionString = CadenaCnx.ObtenerCadena();

        // Obtener tablas de mi bbdd
        public static List<string> GetTablas()
        {
            List<string> listaTablas = new List<string>();

            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();

                    string query = "SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE = 'BASE TABLE' AND TABLE_SCHEMA = 'dbo' AND TABLE_NAME NOT LIKE 'sys%' AND TABLE_NAME NOT LIKE 'MS%'";
                    SqlCommand command = new SqlCommand(query, connection);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {   
                            listaTablas.Add(reader[0].ToString());
                        }
                    }
                }
            }
            catch (Exception)
            {
                listaTablas = new List<string>();
                Console.WriteLine("Error al cargar listado de tablas");
            }

            return listaTablas;
        }

    }
}
