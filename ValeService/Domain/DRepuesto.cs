using DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class DRepuesto
    {
        private RepuestoDao repuestoDao = new RepuestoDao();

        public DataTable MostrarDatosRepuesto()
        {
            return repuestoDao.MostrarDatosRepuesto();
        }

        public void AgregarRepuesto(string descripcion)
        {
            repuestoDao.AgregarRepuesto(descripcion);
        }

        public void EliminarRepuesto(int repuestoId)
        {
            repuestoDao.EliminarRepuesto(repuestoId);
        }

        public void EditarRepuesto(int repuestoId, string descripcion)
        {
            repuestoDao.EditarRepuesto(repuestoId, descripcion);
        }

        public DataTable BuscarRepuestoDescripcion(string descripcionBusqueda)
        {
            return repuestoDao.BuscarRepuestoDescripcion(descripcionBusqueda);
        }

    }

}
