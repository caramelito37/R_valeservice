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
        public DataTable MostrarDatosRepuesto()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "MostrarDatosRepuesto";
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

        public DataTable BuscarRepuestoDescripcion(string descripcionBusqueda)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "BuscarRepuestoPorDescripcion";
                    command.CommandType = CommandType.StoredProcedure;

                    // Agregar el parámetro de entrada para la descripción de búsqueda
                    command.Parameters.AddWithValue("@descripcionBusqueda", descripcionBusqueda);

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

