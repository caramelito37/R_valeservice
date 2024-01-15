using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Eventos
{
    public class EventosGlobales
    {
        // Delegado y evento para el cambio de número de hoja
        public delegate void NumeroHojaCambiadoEventHandler(string nuevoNumeroHoja);
        public static event NumeroHojaCambiadoEventHandler NumeroHojaCambiado;

        // Método para invocar el evento desde cualquier parte de la aplicación
        public static void InvocarNumeroHojaCambiado(string nuevoNumeroHoja)
        {
            NumeroHojaCambiado?.Invoke(nuevoNumeroHoja);
        }
    }
}
