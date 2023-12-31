﻿using MySql.Data.MySqlClient;
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
        public DataTable MostrarHojaRepuestos()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM Hoja_Repuestos;";
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

        public void AgregarHojaRepuestos(int cantidad, string descripcion, decimal costo, string marca, int repuestoId, int hojaNumero)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "INSERT INTO Hoja_Repuestos (Hoja_Repuestos_Cantidad, Hoja_Repuestos_Descripcion, Hoja_Repuestos_Costo, Hoja_Repuestos_Marca, Repuesto_Id, Hoja_Numero) VALUES (@Cantidad, @Descripcion, @Costo, @Marca, @RepuestoId, @HojaNumero);";
                    command.CommandType = CommandType.Text;

                    // Parámetros parametrizados
                    command.Parameters.AddWithValue("@Cantidad", cantidad);
                    command.Parameters.AddWithValue("@Descripcion", descripcion);
                    command.Parameters.AddWithValue("@Costo", costo);
                    command.Parameters.AddWithValue("@Marca", marca);
                    command.Parameters.AddWithValue("@RepuestoId", repuestoId);
                    command.Parameters.AddWithValue("@HojaNumero", hojaNumero);

                    command.ExecuteNonQuery();
                }
            }
        }

        public void EliminarHojaRepuestos(int hojaNumero, int repuestoId)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "DELETE FROM Hoja_Repuestos WHERE Hoja_Numero = @HojaNumero AND Repuesto_Id = @RepuestoId;";
                    command.CommandType = CommandType.Text;

                    // Parámetros parametrizados
                    command.Parameters.AddWithValue("@HojaNumero", hojaNumero);
                    command.Parameters.AddWithValue("@RepuestoId", repuestoId);

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
