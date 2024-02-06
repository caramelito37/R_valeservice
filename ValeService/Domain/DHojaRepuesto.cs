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

        public DataTable MostrarDatosHojaRepuestos(int hojaNumero)
        {
            return hojaRepuestosDao.MostrarDatosHojaRepuestos(hojaNumero);
        }

        public void AddDatosHojaRepuestos(int cantidad, decimal costo, string marca, int repuestoId, int hojaNumero)
        {
            hojaRepuestosDao.AddDatosHojaRepuestos(cantidad, costo, marca, repuestoId, hojaNumero);
        }

        public void EditDatosHojaRepuestos(int hojaRepuestosId, int cantidad, decimal costo, string marca, int repuestoId, int hojaNumero)
        {
            hojaRepuestosDao.EditDatosHojaRepuestos(hojaRepuestosId, cantidad, costo, marca, repuestoId, hojaNumero);
        }


        public void EliminarHojaRepuestos(int hojaNumero, int repuestoId, int cantidad, decimal costo, string marca)
        {
            hojaRepuestosDao.EliminarHojaRepuesto(hojaNumero, repuestoId, cantidad, costo, marca);
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
