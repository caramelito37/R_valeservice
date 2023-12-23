using DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class DRecepcionVehiculo
    {
        RecepcionVehiculoDao recepcionVehiculoDao = new RecepcionVehiculoDao();

        #region BUSCAR VEHICULO Y CLIENTES
        public DataTable BuscarVehiculo(string opcion, string valor)
        {
            return recepcionVehiculoDao.BuscarVehiculo(opcion, valor);
        }
        public DataTable BuscarCliente(string opcion, string valor)
        {
            return recepcionVehiculoDao.BuscarCliente(opcion, valor);
        }
        #endregion

        #region MOSTRAR VEHICULOS COMBO BOX
        public List<string> MostrarVehiculosCBX()
        {
            return recepcionVehiculoDao.MostrarVehiculosCBX();
        }
        public List<int> MostrarDNIClientesCBX()
        {
            return recepcionVehiculoDao.MostrarDNIClientesCBX();
        }


        #endregion
        public DataTable MostrarRecepciones()
        {
            return recepcionVehiculoDao.MostrarRecepciones();
        }

        public void AgregarRecepcion(DateTime fechaEntrada, DateTime? fechaSalida, decimal cuenta, string placaVehiculo, int clienteDNI)
        {
            recepcionVehiculoDao.AgregarRecepcion(fechaEntrada, fechaSalida, cuenta, placaVehiculo, clienteDNI);
        }

        public void EliminarRecepcion(int recepcionId)
        {
            recepcionVehiculoDao.EliminarRecepcion(recepcionId);
        }

        public void EditarRecepcion(int recepcionId, DateTime fechaEntrada, DateTime? fechaSalida, decimal cuenta, string placaVehiculo, int clienteDNI)
        {
            recepcionVehiculoDao.EditarRecepcion(recepcionId, fechaEntrada, fechaSalida, cuenta, placaVehiculo, clienteDNI);
        }

        public DataTable BuscarRecepcion(string opcion, string valor)
        {
            return recepcionVehiculoDao.BuscarRecepcion(opcion, valor);
        }
    }
}
