using DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class DManoDeObra
    {
        private ManoDeObraDao manoDeObraDao = new ManoDeObraDao();

        public DataTable MostrarManoDeObra()
        {
            return manoDeObraDao.MostrarManoDeObra();
        }

        public DataTable MostrarManoDeObraHoja(int hojaNumero)
        {
            return manoDeObraDao.MostrarManoDeObraHoja(hojaNumero);
        }

        public void AgregarManoDeObra(int hojaNumero, int cantidad, decimal costo, int tiempo, int servicioId)
        {
            manoDeObraDao.AgregarManoDeObra(hojaNumero, cantidad, costo, tiempo, servicioId);
        }

        public void EliminarManoDeObra(int hojaNumero, int cantidad, decimal costo, int tiempo, int servicioId)
        {
            manoDeObraDao.EliminarManoDeObra(hojaNumero, cantidad, costo, tiempo, servicioId);
        }

        public void EditarManoDeObra(int hojaNumero, int cantidad, decimal costo, int tiempo, int servicioId)
        {
            manoDeObraDao.EditarManoDeObra(hojaNumero, cantidad, costo, tiempo, servicioId);
        }


        public DataTable BuscarManoDeObra(int hojaNumero, string opcion, string valor)
        {
            return manoDeObraDao.BuscarManoDeObra(hojaNumero, opcion, valor);
        }
    }

}
