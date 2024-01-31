using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class ManoDeObraDao : ConnectionToMySql
    {
        public DataTable MostrarDatosManoObra(int numeroHoja)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "MostrarDatosManoObra";
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



        public DataTable MostrarManoDeObraHoja(int hojaNumero)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM ManoDeObra WHERE Hoja_Numero = @HojaNumero;";
                    command.Parameters.AddWithValue("@HojaNumero", hojaNumero);
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

        public void AgregarManoDeObra(int hojaNumero, int cantidad, decimal costo, int tiempo, int servicioId)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "INSERT INTO ManoDeObra (Hoja_Numero, ManoDeObra_Cantidad, ManoDeObra_Costo, ManoDeObra_Tiempo, ServiciosMecanicos_Id) VALUES (@HojaNumero, @Cantidad, @Costo, @Tiempo, @ServicioId);";
                    command.Parameters.AddWithValue("@HojaNumero", hojaNumero);
                    command.Parameters.AddWithValue("@Cantidad", cantidad);
                    command.Parameters.AddWithValue("@Costo", costo);
                    command.Parameters.AddWithValue("@Tiempo", tiempo);
                    command.Parameters.AddWithValue("@ServicioId", servicioId);
                    command.CommandType = CommandType.Text;

                    command.ExecuteNonQuery();
                }
            }
        }

        public void EliminarManoDeObra(int hojaNumero, int cantidad, decimal costo, int tiempo, int servicioId)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "DELETE FROM ManoDeObra WHERE Hoja_Numero = @HojaNumero AND ManoDeObra_Cantidad = @Cantidad AND ManoDeObra_Costo = @Costo AND ManoDeObra_Tiempo = @Tiempo AND ServiciosMecanicos_Id = @ServicioId;";
                    command.Parameters.AddWithValue("@HojaNumero", hojaNumero);
                    command.Parameters.AddWithValue("@Cantidad", cantidad);
                    command.Parameters.AddWithValue("@Costo", costo);
                    command.Parameters.AddWithValue("@Tiempo", tiempo);
                    command.Parameters.AddWithValue("@ServicioId", servicioId);
                    command.CommandType = CommandType.Text;

                    command.ExecuteNonQuery();
                }
            }
        }


        public void EditarManoDeObra(int hojaNumero, int cantidad, decimal costo, int tiempo, int servicioId)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "UPDATE ManoDeObra SET ManoDeObra_Cantidad = @Cantidad, ManoDeObra_Costo = @Costo, ManoDeObra_Tiempo = @Tiempo WHERE Hoja_Numero = @HojaNumero AND ServiciosMecanicos_Id = @ServicioId;";
                    command.Parameters.AddWithValue("@HojaNumero", hojaNumero);
                    command.Parameters.AddWithValue("@Cantidad", cantidad);
                    command.Parameters.AddWithValue("@Costo", costo);
                    command.Parameters.AddWithValue("@Tiempo", tiempo);
                    command.Parameters.AddWithValue("@ServicioId", servicioId);
                    command.CommandType = CommandType.Text;

                    command.ExecuteNonQuery();
                }
            }
        }



        public DataTable BuscarManoDeObra(int hojaNumero, string opcion, string valor)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand())
                {
                    command.Connection = connection;

                    // Construir la consulta dinámica según la opción seleccionada
                    string consulta = "SELECT * FROM ManoDeObra WHERE Hoja_Numero = @HojaNumero AND ";
                    switch (opcion)
                    {
                        case "Cantidad":
                            consulta += "ManoDeObra_Cantidad = @valor;";
                            break;
                        case "Costo":
                            consulta += "ManoDeObra_Costo = @valor;";
                            break;
                        case "Tiempo":
                            consulta += "ManoDeObra_Tiempo LIKE @valor;";
                            break;
                        case "Servicio_Nº":
                            consulta += "ServiciosMecanicos_Id = @valor;";
                            break;
                        default:
                            // Opción por defecto si la selección no es válida
                            return new DataTable();
                    }

                    command.CommandText = consulta;
                    // Usar el comodín '%' para realizar búsquedas parciales con el operador LIKE
                    command.Parameters.AddWithValue("@HojaNumero", hojaNumero);
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
