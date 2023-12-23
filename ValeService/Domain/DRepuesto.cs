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

        public DataTable MostrarRepuestos()
        {
            return repuestoDao.MostrarRepuestos();
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

        public DataTable BuscarRepuesto(string opcion, string valor)
        {
            return repuestoDao.BuscarRepuesto(opcion, valor);
        }
    }

}
