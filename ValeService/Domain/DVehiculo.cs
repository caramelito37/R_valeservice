using DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class DVehiculo
    {
        VehiculoDao vehiculoDao = new VehiculoDao();

        public DataTable MostrarVehiculos()
        {
            DataTable tabla = new DataTable();
            tabla = vehiculoDao.MostrarVehiculos();
            return tabla;
        }

        public bool VehiculoExiste(string placa)
        {
            return vehiculoDao.VehiculoExiste(placa);
        }

        public void AgregarVehiculo(string placa, string marca, string modelo, DateTime año, int kilometraje)
        {
            vehiculoDao.AgregarVehiculo(placa, marca, modelo, año, kilometraje);
        }

        public void EliminarVehiculo(string placa)
        {
            vehiculoDao.EliminarVehiculo(placa);
        }

        public void EditarVehiculo(string placa, string nuevaMarca, string nuevoModelo, DateTime nuevoAño, int nuevoKilometraje)
        {
            vehiculoDao.EditarVehiculo(placa, nuevaMarca, nuevoModelo, nuevoAño, nuevoKilometraje);
        }
        public DataTable BuscarVehiculo(string opcion, string valor)
        {
            return vehiculoDao.BuscarVehiculo(opcion, valor);
        }

    }
}
