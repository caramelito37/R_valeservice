using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class VehiculoDao : ConnectionToMySql
    {
        #region VEHICULOS --- CONSULTAS PARA LOS BOTONES DEL FORMULARIO Y MOSTRAR REGISTROS 'CRUD' DE LA TABLA VEHICULOS
        public DataTable MostrarDatosVehiculos()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "MostrarDatosVehiculo;";
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

        public bool VehiculoExiste(string placa)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM Vehiculo WHERE Vehiculo_Placa = @placa;";
                    command.Parameters.AddWithValue("@placa", placa);
                    command.CommandType = CommandType.Text;
                    MySqlDataReader reader = command.ExecuteReader();
                    return reader.HasRows;
                }
            }
        }

        public void AgregarVehiculo(string placa, string marca, string modelo, DateTime año, int kilometraje)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "INSERT INTO Vehiculo (Vehiculo_Placa, Vehiculo_Marca, Vehiculo_Modelo, Vehiculo_Año, Vehiculo_Kilometraje) VALUES (@Placa, @Marca, @Modelo, @Año, @Kilometraje);";
                    command.CommandType = CommandType.Text;

                    // Parámetros parametrizados
                    command.Parameters.AddWithValue("@Placa", placa);
                    command.Parameters.AddWithValue("@Marca", marca);
                    command.Parameters.AddWithValue("@Modelo", modelo);
                    command.Parameters.AddWithValue("@Año", año);
                    command.Parameters.AddWithValue("@Kilometraje", kilometraje);

                    command.ExecuteNonQuery();
                }
            }
        }

        public void EliminarVehiculo(string placa)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "DELETE FROM Vehiculo WHERE Vehiculo_Placa = @Placa;";
                    command.CommandType = CommandType.Text;

                    // Parámetros parametrizados
                    command.Parameters.AddWithValue("@Placa", placa);

                    command.ExecuteNonQuery();
                }
            }
        }

        public void EditarVehiculo(string placa, string nuevaMarca, string nuevoModelo, DateTime nuevoAño, int nuevoKilometraje)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "UPDATE Vehiculo SET Vehiculo_Marca = @NuevaMarca, Vehiculo_Modelo = @NuevoModelo, Vehiculo_Año = @NuevoAño, Vehiculo_Kilometraje = @NuevoKilometraje WHERE Vehiculo_Placa = @Placa;";
                    command.CommandType = CommandType.Text;

                    // Parámetros parametrizados
                    command.Parameters.AddWithValue("@Placa", placa);
                    command.Parameters.AddWithValue("@NuevaMarca", nuevaMarca);
                    command.Parameters.AddWithValue("@NuevoModelo", nuevoModelo);
                    command.Parameters.AddWithValue("@NuevoAño", nuevoAño);
                    command.Parameters.AddWithValue("@NuevoKilometraje", nuevoKilometraje);

                    command.ExecuteNonQuery();
                }
            }
        }
        public DataTable BuscarVehiculo(string opcion, string valor)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand())
                {
                    command.Connection = connection;

                    // Construir la consulta dinámica según la opción seleccionada
                    string consulta = "SELECT * FROM Vehiculo WHERE ";
                    switch (opcion)
                    {
                        case "Placa":
                            consulta += "Vehiculo_Placa LIKE @valor;";
                            break;
                        case "Marca":
                            consulta += "Vehiculo_Marca LIKE @valor;";
                            break;
                        case "Modelo":
                            consulta += "Vehiculo_Modelo LIKE @valor;";
                            break;
                        case "Año":
                            consulta += "Vehiculo_Año LIKE @valor;";
                            break;
                        case "Kilometraje":
                            consulta += "Vehiculo_Kilometraje LIKE @valor;";
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

        #endregion
    }
}
