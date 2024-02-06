using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace Domain
{

    public class DManoObraTerceros
    {
        private ManoObraTercerosDao manoObraTercerosDao = new ManoObraTercerosDao();

        public DataTable MostrarDatosManoObraTerceros(int numeroHoja)
        {
            return manoObraTercerosDao.MostrarDatosManoObraTerceros(numeroHoja);
        }
        public void AddManoObraTerceros(int numeroHoja, string descripcion)
        {
            manoObraTercerosDao.InsertarManoObraTerceros(numeroHoja, descripcion);
        }
        public void EditManoObraTerceros(int idManoObraTerceros, int numeroHoja, string nuevaDescripcion)
        {
            manoObraTercerosDao.EditManoObraTerceros(idManoObraTerceros, numeroHoja, nuevaDescripcion);
        }
        public void DeleteManoObraTerceros(int idManoObraTerceros)
        {
            manoObraTercerosDao.DeleteManoObraTerceros(idManoObraTerceros);
        }

    }
}
