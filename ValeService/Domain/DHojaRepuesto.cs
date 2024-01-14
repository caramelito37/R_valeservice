using DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class DHojaRepuesto
    {
        private HojaRepuestoDao hojaRepuestosDao = new HojaRepuestoDao();

        public DataTable MostrarHojaRepuestos(int hojaNumero)
        {
            return hojaRepuestosDao.MostrarHojaRepuestos(hojaNumero);
        }

        public void AgregarHojaRepuestos(int cantidad, string descripcion, decimal costo, string marca, int repuestoId, int hojaNumero)
        {
            hojaRepuestosDao.AgregarHojaRepuestos(cantidad, descripcion, costo, marca, repuestoId, hojaNumero);
        }

        public void EliminarHojaRepuestos(int hojaNumero, int repuestoId)
        {
            hojaRepuestosDao.EliminarHojaRepuestos(hojaNumero, repuestoId);
        }

        public DataTable BuscarHojaRepuestos(string opcion, string valor)
        {
            return hojaRepuestosDao.BuscarHojaRepuestos(opcion, valor);
        }

        public List<int> ObtenerRepuestoIds()
        {
            return hojaRepuestosDao.ObtenerRepuestoIds();
        }
    }
}
