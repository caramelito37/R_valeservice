using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace Domain
{
    public class DHoja
    {
        private HojaDao hojaDao = new HojaDao();
        public DataTable MostrarDatosHoja()
        {
            return hojaDao.MostrarDatosHoja();
        }
        public int GenerarNumeroHoja()
        {
            return hojaDao.GenerarNumeroHoja();
        }

    }
}
