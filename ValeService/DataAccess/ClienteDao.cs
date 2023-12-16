using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class ClienteDao : ConnectionToMySql
    {
        #region CLIENTES --- CONSULTAS PARA LOS BOTONES DEL FORMULARIO Y MOSTRAR REGISTROS 'CRUD' DE LA TABLA CLIENTES
        public DataTable MostrarClientes()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM Cliente;";
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

        public bool ClienteExiste(int dni)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM Cliente WHERE Cliente_DNI = @dni;";
                    command.Parameters.AddWithValue("@dni", dni);
                    command.CommandType = CommandType.Text;
                    MySqlDataReader reader = command.ExecuteReader();
                    return reader.HasRows;
                }
            }
        }

        public void AgregarCliente(int dni, string nombreApellido, int contacto)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "INSERT INTO Cliente (Cliente_DNI, Cliente_Nombre_Apellido, Cliente_Contacto) VALUES (@DNI, @NombreApellido, @Contacto);";
                    command.CommandType = CommandType.Text;

                    // Parámetros parametrizados
                    command.Parameters.AddWithValue("@DNI", dni);
                    command.Parameters.AddWithValue("@NombreApellido", nombreApellido);
                    command.Parameters.AddWithValue("@Contacto", contacto);

                    command.ExecuteNonQuery();
                }
            }
        }

        public void EliminarCliente(int dni)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "DELETE FROM Cliente WHERE Cliente_DNI = @DNI;";
                    command.CommandType = CommandType.Text;

                    // Parámetros parametrizados
                    command.Parameters.AddWithValue("@DNI", dni);

                    command.ExecuteNonQuery();
                }
            }
        }

        public void EditarCliente(int dni, string nuevoNombreApellido, int nuevoContacto)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "UPDATE Cliente SET Cliente_Nombre_Apellido = @NuevoNombreApellido, Cliente_Contacto = @NuevoContacto WHERE Cliente_DNI = @DNI;";
                    command.CommandType = CommandType.Text;

                    // Parámetros parametrizados
                    command.Parameters.AddWithValue("@DNI", dni);
                    command.Parameters.AddWithValue("@NuevoNombreApellido", nuevoNombreApellido);
                    command.Parameters.AddWithValue("@NuevoContacto", nuevoContacto);

                    command.ExecuteNonQuery();
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
    }
}
