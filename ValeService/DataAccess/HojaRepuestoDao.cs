using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class HojaRepuestoDao : ConnectionToMySql
    {
        public DataTable MostrarDatosHojaRepuestos(int hojaNumero)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "MostrarDatosRepuestos";
                    command.CommandType = CommandType.StoredProcedure;

                    // Agregar parámetro de entrada para el procedimiento almacenado
                    command.Parameters.AddWithValue("@numeroHoja", hojaNumero);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        DataTable resultTable = new DataTable();
                        resultTable.Load(reader);
                        return resultTable;
                    }
                }
            }
        }



        public void AddDatosHojaRepuestos(int cantidad, decimal costo, string marca, int repuestoId, int hojaNumero)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "INSERT INTO " +
                        "Hoja_Repuestos " +
                        "(Hoja_Repuestos_Cantidad, Hoja_Repuestos_Marca, Hoja_Repuestos_Costo, Repuesto_Id, Hoja_Numero)" +
                        " VALUES " +
                        "(@Cantidad, @Marca, @Costo, @RepuestoId, @HojaNumero);";
                    command.CommandType = CommandType.Text;

                    // Parámetros parametrizados
                    command.Parameters.AddWithValue("@Cantidad", cantidad);
                    command.Parameters.AddWithValue("@Marca", marca); // Usar la columna de marca para descripción
                    command.Parameters.AddWithValue("@Costo", costo);
                    command.Parameters.AddWithValue("@RepuestoId", repuestoId);
                    command.Parameters.AddWithValue("@HojaNumero", hojaNumero);

                    command.ExecuteNonQuery();
                }
            }
        }

        public void EditDatosHojaRepuestos(int hojaRepuestosId, int cantidad, decimal costo, string marca, int repuestoId, int hojaNumero)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "UPDATE Hoja_Repuestos " +
                        "SET Hoja_Repuestos_Cantidad = @Cantidad, " +
                        "    Hoja_Repuestos_Marca = @Marca, " +
                        "    Hoja_Repuestos_Costo = @Costo, " +
                        "    Repuesto_Id = @RepuestoId, " +
                        "    Hoja_Numero = @HojaNumero " +
                        "WHERE Hoja_Repuestos_Id = @HojaRepuestosId;";
                    command.CommandType = CommandType.Text;

                    // Parameters
                    command.Parameters.AddWithValue("@HojaRepuestosId", hojaRepuestosId);
                    command.Parameters.AddWithValue("@Cantidad", cantidad);
                    command.Parameters.AddWithValue("@Marca", marca);
                    command.Parameters.AddWithValue("@Costo", costo);
                    command.Parameters.AddWithValue("@RepuestoId", repuestoId);
                    command.Parameters.AddWithValue("@HojaNumero", hojaNumero);

                    command.ExecuteNonQuery();
                }
            }
        }

        public void EliminarHojaRepuesto(int hojaNumero, int repuestoId, int cantidad, decimal costo, string marca)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "DELETE FROM Hoja_Repuestos " +
                                          "WHERE Hoja_Numero = @HojaNumero " +
                                          "AND Repuesto_Id = @RepuestoId " +
                                          "AND Hoja_Repuestos_Cantidad = @Cantidad " +
                                          "AND Hoja_Repuestos_Costo = @Costo " +
                                          "AND Hoja_Repuestos_Marca = @Marca;";
                    command.CommandType = CommandType.Text;

                    // Parámetros parametrizados
                    command.Parameters.AddWithValue("@HojaNumero", hojaNumero);
                    command.Parameters.AddWithValue("@RepuestoId", repuestoId);
                    command.Parameters.AddWithValue("@Cantidad", cantidad);
                    command.Parameters.AddWithValue("@Costo", costo);
                    command.Parameters.AddWithValue("@Marca", marca);

                    command.ExecuteNonQuery();
                }
            }
        }

        public DataTable BuscarHojaRepuestos(string opcion, string valor)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand())
                {
                    command.Connection = connection;

                    // Construir la consulta dinámica según la opción seleccionada
                    string consulta = "SELECT * FROM Hoja_Repuestos WHERE ";
                    switch (opcion)
                    {
                        case "Hoja_Numero":
                            consulta += "Hoja_Numero = @valor;";
                            break;
                        case "Repuesto_Id":
                            consulta += "Repuesto_Id = @valor;";
                            break;
                        default:
                            // Opción por defecto si la selección no es válida
                            return new DataTable();
                    }

                    command.CommandText = consulta;
                    command.Parameters.AddWithValue("@valor", valor);
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

        public List<int> ObtenerRepuestoIds()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT Repuesto_Id FROM Repuesto;";
                    command.CommandType = CommandType.Text;

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        List<int> repuestoIds = new List<int>();
                        while (reader.Read())
                        {
                            int repuestoId = reader.GetInt32("Repuesto_Id");
                            repuestoIds.Add(repuestoId);
                        }
                        return repuestoIds;
                    }
                }
            }
        }

    }
}
