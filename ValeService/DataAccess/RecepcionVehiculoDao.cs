﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class RecepcionVehiculoDao : ConnectionToMySql
    {
        #region BUSCAR VEHICULO Y BUSCAR CLIENTE -------------------------------
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
        public DataTable BuscarCliente(string opcion, string valor)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand())
                {
                    command.Connection = connection;

                    // Construir la consulta dinámica según la opción seleccionada
                    string consulta = "SELECT * FROM Cliente WHERE ";
                    switch (opcion)
                    {
                        case "DNI":
                            consulta += "Cliente_DNI LIKE @valor;";
                            break;
                        case "Nombre_Apellido":
                            consulta += "Cliente_Nombre_Apellido LIKE @valor;";
                            break;
                        case "Contacto":
                            consulta += "Cliente_Contacto LIKE @valor;";
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

        #region MOSTRAR VEHICULOS Y CLIENTES EN COMBO BOX ----------------------
        public List<string> MostrarVehiculosCBX()
        {
            List<string> vehiculosList = new List<string>();

            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT Vehiculo_Placa FROM Vehiculo;";
                    command.CommandType = CommandType.Text;

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            vehiculosList.Add(reader["Vehiculo_Placa"].ToString());
                        }
                    }
                }
            }

            return vehiculosList;
        }

        public List<int> MostrarDNIClientesCBX()
        {
            List<int> clientesList = new List<int>();

            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT Cliente_DNI FROM Cliente;";
                    command.CommandType = CommandType.Text;

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            clientesList.Add(Convert.ToInt32(reader["Cliente_DNI"]));
                        }
                    }
                }
            }

            return clientesList;
        }

        #endregion
        public DataTable MostrarDatosRecepciones(int numeroHoja)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "MostrarDatosRecepciones";
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

        public void AddDatosRecepcion(int hojaNumero, DateTime fechaEntrada, decimal cuenta, string placaVehiculo, int clienteDNI)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "INSERT INTO" +
                        " RecepcionVehiculo " +
                        "(Hoja_Numero, RecepcionVehiculo_Fecha_Entrada, RecepcionVehiculo_Cuenta, Vehiculo_Placa, Cliente_DNI)" +
                        " VALUES " +
                        "(@HojaNumero, @FechaEntrada, @Cuenta, @PlacaVehiculo, @ClienteDNI);";
                    command.CommandType = CommandType.Text;

                    // Parámetros parametrizados
                    command.Parameters.AddWithValue("@HojaNumero", hojaNumero);
                    command.Parameters.AddWithValue("@FechaEntrada", fechaEntrada);
                    command.Parameters.AddWithValue("@Cuenta", cuenta);
                    command.Parameters.AddWithValue("@PlacaVehiculo", placaVehiculo);
                    command.Parameters.AddWithValue("@ClienteDNI", clienteDNI);

                    command.ExecuteNonQuery();
                }
            }
        }


        public void DeleteDatosRecepcion(int recepcionId)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "DELETE FROM" +
                        " RecepcionVehiculo " +
                        "WHERE" +
                        " RecepcionVehiculo_Id = @RecepcionId;";
                    command.CommandType = CommandType.Text;

                    // Parámetros parametrizados
                    command.Parameters.AddWithValue("@RecepcionId", recepcionId);

                    command.ExecuteNonQuery();
                }
            }
        }

        public void AsignarFechaSalida(int recepcionId, DateTime? fechaSalida)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "UPDATE RecepcionVehiculo SET RecepcionVehiculo_Fecha_Salida = @FechaSalida WHERE RecepcionVehiculo_Id = @RecepcionId;";
                    command.CommandType = CommandType.Text;

                    // Parámetros parametrizados
                    command.Parameters.AddWithValue("@RecepcionId", recepcionId);
                    command.Parameters.AddWithValue("@FechaSalida", (object)fechaSalida ?? DBNull.Value);

                    command.ExecuteNonQuery();
                }
            }
        }


        public DataTable BuscarRecepcion(string opcion, string valor)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand())
                {
                    command.Connection = connection;

                    // Construir la consulta dinámica según la opción seleccionada
                    string consulta = "SELECT * FROM RecepcionVehiculo WHERE ";
                    switch (opcion)
                    {
                        case "Recepcion_ID":
                            consulta += "RecepcionVehiculo_Id LIKE @valor;";
                            break;
                        case "Fecha_Entrada":
                            consulta += "RecepcionVehiculo_Fecha_Entrada LIKE @valor;";
                            break;
                        case "Fecha_Salida":
                            consulta += "RecepcionVehiculo_Fecha_Salida LIKE @valor;";
                            break;
                        case "Cuenta":
                            consulta += "RecepcionVehiculo_Cuenta LIKE @valor;";
                            break;
                        case "Placa_Vehiculo":
                            consulta += "Vehiculo_Placa LIKE @valor;";
                            break;
                        case "Cliente_DNI":
                            consulta += "Cliente_DNI LIKE @valor;";
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