using System;
using System.Collections.Generic;
using System.Configuration; 
using System.Data; 
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace segundoexamenprogra2encuentas
{
    public class clsencuesta
    {
        

        public static void Main(string[] args)
        {
            
            string connectionString = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;

            
            insertarnumeroencuestas(connectionString, "numeroencuestas", "nombre", "apellido", "fechadenacimiento", DateTime.Now, "nuevo@correo.com", "carropropio");

            
            listarnumeroencuestas(connectionString);
        }

        

        public static void insertarnumeroencuestas(string connectionString, int numeroencuestas, string nombre, string apellido, DateTime fechaNacimiento, string correoElectronico, string carroPropio)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = "INSERT INTO usuarios (numeroencuestas, nombre, apellido,fechanacimiento, correoelectronico, carropropio) VALUES (@nombrenumeroencuesta, @nombre, @apellido, @fechaNacimiento, @correoElectronico, @carroPropio)";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@numeroencuestas", numeroencuestas);
                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@apellido", apellido);
                    command.Parameters.AddWithValue("@fechaNacimiento", fechaNacimiento);
                    command.Parameters.AddWithValue("@correoElectronico", correoElectronico);
                    command.Parameters.AddWithValue("@carroPropio", carroPropio);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }

        public static void listarnumeroencuestas(string connectionString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = "SELECT numeroencuesta, nombre, apellido, fechanacimiento, correoelectronico, carropropio FROM usuarios";

                SqlCommand command = new SqlCommand(sql, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine($"numero de encuestas: {reader["numeroencuestas"]}, Nombre: {reader["nombre"]}, apellido: {reader["apellido"]}, Fecha de Nacimiento: {reader["fechanacimiento"]}, Correo Electrónico: {reader["correoelectronico"]}, Carro Propio: {reader["carropropio"]}");
                }

                reader.Close();
                connection.Close();
            }
        }
    }

}
