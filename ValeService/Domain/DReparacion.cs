using DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class DReparacion
    {
        private ReparacionDao reparacionDao = new ReparacionDao();

        public DataTable MostrarReparaciones()
        {
            return reparacionDao.MostrarReparaciones();
        }


        public void AgregarReparacion(string descripcion)
        {
            reparacionDao.AgregarReparacion(descripcion);
        }

        public void EliminarReparacion(int reparacionId)
        {
            reparacionDao.EliminarReparacion(reparacionId);
        }

        public void EditarReparacion(int reparacionId, string descripcion)
        {
            reparacionDao.EditarReparacion(reparacionId, descripcion);
        }

        public DataTable BuscarReparacion(string opcion, string valor)
        {
            return reparacionDao.BuscarReparacion(opcion, valor);
        }
    }

}
