using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class RepuestoDao : ConnectionToMySql
    {
        public DataTable MostrarRepuestos()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM Repuesto;";
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
        public void AgregarRepuesto(string descripcion)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "INSERT INTO Repuesto (Repuesto_Descripcion) VALUES (@Descripcion);";
                    command.CommandType = CommandType.Text;

                    // Parámetros parametrizados
                    command.Parameters.AddWithValue("@Descripcion", descripcion);

                    command.ExecuteNonQuery();
                }
            }
        }

        public void EliminarRepuesto(int repuestoId)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "DELETE FROM Repuesto WHERE Repuesto_Id = @RepuestoId;";
                    command.CommandType = CommandType.Text;

                    // Parámetros parametrizados
                    command.Parameters.AddWithValue("@RepuestoId", repuestoId);

                    command.ExecuteNonQuery();
                }
            }
        }

        public void EditarRepuesto(int repuestoId, string descripcion)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "UPDATE Repuesto SET Repuesto_Descripcion = @Descripcion WHERE Repuesto_Id = @RepuestoId;";
                    command.CommandType = CommandType.Text;

                    // Parámetros parametrizados
                    command.Parameters.AddWithValue("@RepuestoId", repuestoId);
                    command.Parameters.AddWithValue("@Descripcion", descripcion);

                    command.ExecuteNonQuery();
                }
            }
        }

        public DataTable BuscarRepuesto(string opcion, string valor)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand())
                {
                    command.Connection = connection;

                    // Construir la consulta dinámica según la opción seleccionada
                    string consulta = "SELECT * FROM Repuesto WHERE ";
                    switch (opcion)
                    {
                        case "N°_Repuesto":
                            consulta += "Repuesto_Id LIKE @valor;";
                            break;
                        case "Descripcion":
                            consulta += "Repuesto_Descripcion LIKE @valor;";
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

