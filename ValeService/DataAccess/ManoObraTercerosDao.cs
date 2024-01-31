using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class ManoObraTercerosDao : ConnectionToMySql
    {
        public DataTable MostrarDatosManoObraTerceros(int numeroHoja)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "MostrarDatosManoObraTerceros";
                    command.CommandType = CommandType.StoredProcedure;

                    // Agregar parámetro de entrada para el procedimiento almacenado
                    command.Parameters.AddWithValue("@numeroHoja", numeroHoja);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        DataTable resultTable = new DataTable();
                        resultTable.Load(reader);
                        return resultTable;
                    }
                }
            }
        }
        public void InsertarManoObraTerceros(int numeroHoja, string descripcion)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "INSERT INTO ManoDeObraTerceros (Hoja_Numero, ManoDeObraTerceros_Descripcion) VALUES (@numeroHoja, @descripcion)";
                    command.CommandType = CommandType.Text;

                    // Agregar parámetros para la consulta
                    command.Parameters.AddWithValue("@numeroHoja", numeroHoja);
                    command.Parameters.AddWithValue("@descripcion", descripcion);

                    // Ejecutar la consulta
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
