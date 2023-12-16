using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using Common.Cache;
using Org.BouncyCastle.Asn1.X509;

namespace DataAccess
{
    public class UserDao : ConnectionToMySql
    {
        public bool Login(string user, string pass)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM Usuarios WHERE (NombreUsuario = @user AND Contraseña = @pass);";
                    command.Parameters.AddWithValue("@user", user);
                    command.Parameters.AddWithValue("@pass", pass);
                    command.CommandType = CommandType.Text;
                    MySqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())//Obtenemos los datos de la columna y asignamos a los campos de la Cache de Usuario
                        {
                            UserCache.NombreUsuario = reader.GetString(0);
                            UserCache.Contraseña = reader.GetString(1);
                            UserCache.Rol = reader.GetString(2);
                        }
                        return true; 
                    }
                    else
                        return false;
                }
            }
        }//CONSULTA QUE SE HACE AL INICIAR SESION PARA VERIFICAR Y VALIDAR LOS DATOS, TAMBIEN PARA ASISNAR EL TIPO DE USUARIO
        
        #region USUARIOS --- CONSULTAS PARA LOS BOTONES DEL FORMULARIO Y MOSTRAR REGISTROS 'CRUD' DE LA TABLA USUARIOS
        public DataTable MostrarUsuarios()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM Usuarios;";
                    command.CommandType = CommandType.Text;

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        DataTable resultTable = new DataTable();
                        resultTable.Load(reader);
                        return resultTable;
                    }
                }
            }
        }//CONSULTA PARA MOSTRAR USUARIOS EL EL DGV

        public bool UsuarioExiste(string user)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM Usuarios WHERE NombreUsuario = @user;";
                    command.Parameters.AddWithValue("@user", user);
                    command.CommandType = CommandType.Text;
                    MySqlDataReader reader = command.ExecuteReader();
                    return reader.HasRows;
                }
            }
        }//VERIFICAR SI EL USUARIO EXISTE ANTES DE AGREGAR, EDITAR O ELIMINAR

        public void AgregarUsuario(string nombreUsuario, string contraseña, string rol)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "INSERT INTO Usuarios (NombreUsuario, Contraseña, Rol) VALUES (@NombreUsuario, @Contraseña, @Rol);";
                    command.CommandType = CommandType.Text;

                    // Parámetros parametrizados
                    command.Parameters.AddWithValue("@NombreUsuario", nombreUsuario);
                    command.Parameters.AddWithValue("@Contraseña", contraseña);
                    command.Parameters.AddWithValue("@Rol", rol);

                    command.ExecuteNonQuery();
                }
            }
        }//CONSULTA PARAMETRIZADA PARA AGREGAR USUARIOS A LA BASE DE DATOS 

        public void EliminarUsuario(string nombreUsuario)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "DELETE FROM Usuarios WHERE NombreUsuario = @NombreUsuario;";
                    command.CommandType = CommandType.Text;

                    // Parámetros parametrizados
                    command.Parameters.AddWithValue("@NombreUsuario", nombreUsuario);

                    command.ExecuteNonQuery();
                }
            }
        }//CONSULTA PARAMETRIZADA PARA ELIMINAR USUARIOS DE LA BASE DE DATOS 

        public void EditarUsuario(string nombreUsuario, string nuevaContraseña, string nuevoRol)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "UPDATE Usuarios SET Contraseña = @NuevaContraseña, Rol = @NuevoRol WHERE NombreUsuario = @NombreUsuario;";
                    command.CommandType = CommandType.Text;

                    // Parámetros parametrizados
                    command.Parameters.AddWithValue("@NombreUsuario", nombreUsuario);
                    command.Parameters.AddWithValue("@NuevaContraseña", nuevaContraseña);
                    command.Parameters.AddWithValue("@NuevoRol", nuevoRol);

                    command.ExecuteNonQuery();
                }
            }
        }//CONSULTA PARAMETRIZADA PARA EDITAR DATOS DE  USUARIOS EN LA BASE DE DATOS 
        #endregion

    }
}
