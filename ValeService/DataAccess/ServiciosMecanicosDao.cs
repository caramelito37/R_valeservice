using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class ServiciosMecanicosDao : ConnectionToMySql
    {
        public DataTable MostrarDatosServiciosMecanicos()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "MostrarServiciosMecanicos";
                    command.CommandType = CommandType.StoredProcedure;

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        DataTable resultTable = new DataTable();
                        resultTable.Load(reader);
                        return resultTable;
                    }
                }
            }
        }


        public void AgregarDatosServiciosMecanicos(string descripcion)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "INSERT INTO ServiciosMecanicos (ServiciosMecanicos_Descripcion) VALUES (@Descripcion);";
                    command.CommandType = CommandType.Text;

                    // Parámetros parametrizados
                    command.Parameters.AddWithValue("@Descripcion", descripcion);

                    command.ExecuteNonQuery();
                }
            }
        }

        public void EliminarDatosServiciosMecanicos(int reparacionId)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "DELETE FROM ServiciosMecanicos WHERE ServiciosMecanicos_Id = @ReparacionId;";
                    command.CommandType = CommandType.Text;

                    // Parámetros parametrizados
                    command.Parameters.AddWithValue("@ReparacionId", reparacionId);

                    command.ExecuteNonQuery();
                }
            }
        }

        public void EditarDatosServiciosMecanicos(int reparacionId, string descripcion)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "UPDATE ServiciosMecanicos SET ServiciosMecanicos_Descripcion = @Descripcion WHERE ServiciosMecanicos_Id = @ReparacionId;";
                    command.CommandType = CommandType.Text;

                    // Parámetros parametrizados
                    command.Parameters.AddWithValue("@ReparacionId", reparacionId);
                    command.Parameters.AddWithValue("@Descripcion", descripcion);

                    command.ExecuteNonQuery();
                }
            }
        }

        public DataTable BuscarDatosServiciosMecanicos(string opcion, string valor)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand())
                {
                    command.Connection = connection;

                    // Construir la consulta dinámica según la opción seleccionada
                    string consulta = "SELECT * FROM ServiciosMecanicos WHERE ";
                    switch (opcion)
                    {
                        case "Servicio_Nº":
                            consulta += "ServiciosMecanicos_Id LIKE @valor;";
                            break;
                        case "Descripcion":
                            consulta += "ServiciosMecanicos_Descripcion LIKE @valor;";
                            break;
                        default:
                            // Opción por defecto si la selección no es válida
                            return new DataTable();
                    }

                    command.CommandText = consulta;
                    // Usar el comodín '%' para realizar búsquedas parciales con el operador LIKE
                    command.Parameters.AddWithValue("@valor", "%" + valor + "%");
                    command.CommandType = CommandType.Text;

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        DataTable resultTable = new DataTable();
                        resultTable.Load(reader);
                        return resultTable;
                    }
                }
            }
        }
    }

}
