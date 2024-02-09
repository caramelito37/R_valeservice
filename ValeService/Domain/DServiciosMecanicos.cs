using DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class DServiciosMecanicos
    {
        private ServiciosMecanicosDao reparacionDao = new ServiciosMecanicosDao();

        public DataTable MostrarDatosServiciosMecanicos()
        {
            return reparacionDao.MostrarDatosServiciosMecanicos();
        }


        public void AgregarDatosServiciosMecanicos(string descripcion)
        {
            reparacionDao.AgregarDatosServiciosMecanicos(descripcion);
        }

        public void EliminarDatosServiciosMecanicos(int reparacionId)
        {
            reparacionDao.EliminarDatosServiciosMecanicos(reparacionId);
        }

        public void EditarReparacion(int reparacionId, string descripcion)
        {
            reparacionDao.EditarDatosServiciosMecanicos(reparacionId, descripcion);
        }

        public DataTable BuscarDatosServiciosMecanicos(string opcion, string valor)
        {
            return reparacionDao.BuscarDatosServiciosMecanicos(opcion, valor);
        }
    }

}
