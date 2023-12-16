using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Cache;
using DataAccess;

namespace Domain
{
    public class UserModel
    {
        UserDao userDao = new UserDao();

        public bool LoginUser(string user, string pass)
        {
            return userDao.Login(user, pass);
        }//INICIO DE SESION DE LA CAPA DATOS 
        public void AnyMethod()
        {
            if (UserCache.Rol == Positions.Administrador)
            {
                //codigo
            }
            if (UserCache.Rol == Positions.Usuario)
            {
                //codigo
            }
        }//ASIGNAR PRIVILEGIS DEPENDIENDO DE EL TIPO DE USUARIO
        public bool UsuarioExiste(string user)
        {
            return userDao.UsuarioExiste(user);
        }
        public DataTable MostrarUsuarios()
        {
            DataTable tabla = new DataTable();
            tabla = userDao.MostrarUsuarios();
            return tabla;
        }//MOSTRAR LOS DATOS EN EL DGV DE LA CAPA DE PRESENTACION

        public void AgregarUsuario(string nombreUsuario, string contraseña, string rol)
        {
            userDao.AgregarUsuario(nombreUsuario, contraseña, rol);
        }//AGREGAR USUARIOS 
        public void EliminarUsuario(string nombreUsuario)
        {
            userDao.EliminarUsuario(nombreUsuario);
        }//ELIMINAR USUARIOS 
        public void EditarUsuario(string nombreUsuario, string contraseña, string rol)
        {
            userDao.EditarUsuario(nombreUsuario, contraseña, rol);
        }//EDITAR USUARIOS
    }
}
