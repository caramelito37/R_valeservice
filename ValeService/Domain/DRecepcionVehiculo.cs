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
        public DataTable MostrarDatosRecepciones(int numeroHoja)
        {
            return recepcionVehiculoDao.MostrarDatosRecepciones(numeroHoja);
        }

        public void AddDatosRecepcion(int hojaNumero, DateTime fechaEntrada, decimal cuenta, string placaVehiculo, int clienteDNI)
        {
            recepcionVehiculoDao.AddDatosRecepcion(hojaNumero, fechaEntrada , cuenta, placaVehiculo, clienteDNI);
        }

        public void DeleteDatosRecepcion(int recepcionId)
        {
            recepcionVehiculoDao.DeleteDatosRecepcion(recepcionId);
        }

        public void AsignarFechaSalida(int recepcionId, DateTime? fechaSalida)
        {
            recepcionVehiculoDao.AsignarFechaSalida(recepcionId, fechaSalida);
        }


        public DataTable BuscarRecepcion(string opcion, string valor)
        {
            return recepcionVehiculoDao.BuscarRecepcion(opcion, valor);
        }
    }
}
