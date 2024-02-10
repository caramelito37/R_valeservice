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

        public DataTable MostrarDatosManoObra(int numeroHoja)
        {
            return manoDeObraDao.MostrarDatosManoObra(numeroHoja);
        }

        public void AddDatosManoObra(int hojaNumero, int cantidad, decimal costo, int tiempo, int servicioId)
        {
            manoDeObraDao.AddDatosManoObra(hojaNumero, cantidad, costo, tiempo, servicioId);
        }

        public void DeleteDatosManoObra(int manoDeObraId)
        {
            manoDeObraDao.DeleteDatosManoObra(manoDeObraId);
        }

        public void EditDatosManoObra(int manoDeObraId, int cantidad, decimal costo, int tiempo)
        {
            manoDeObraDao.EditDatosManoObra(manoDeObraId, cantidad, costo, tiempo);
        }

        public DataTable BuscarManoDeObra(int hojaNumero, string opcion, string valor)
        {
            return manoDeObraDao.BuscarManoDeObra(hojaNumero, opcion, valor);
        }
    }

}
