using DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class DCliente
    {
        ClienteDao clienteDao = new ClienteDao();
        public bool ClienteExiste(int dni)
        {
            return clienteDao.ClienteExiste(dni);
        }

        public DataTable MostrarClientes()
        {
            DataTable tabla = new DataTable();
            tabla = clienteDao.MostrarClientes();
            return tabla;
        }

        public void AgregarCliente(int dni, string nombreApellido, int contacto)
        {
            clienteDao.AgregarCliente(dni, nombreApellido, contacto);
        }

        public void EliminarCliente(int dni)
        {
            clienteDao.EliminarCliente(dni);
        }

        public void EditarCliente(int dni, string nuevoNombreApellido, int nuevoContacto)
        {
            clienteDao.EditarCliente(dni, nuevoNombreApellido, nuevoContacto);
        }
        public DataTable BuscarCliente(string opcion, string valor)
        {
            return clienteDao.BuscarCliente(opcion, valor);
        }
    }
}
