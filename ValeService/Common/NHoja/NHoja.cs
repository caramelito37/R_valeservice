using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.NHoja
{
    public static class Configuracion
    {
        private static string numeroHoja;

        public static string NumeroHoja
        {
            get => numeroHoja;
            set
            {
                numeroHoja = value;
                NumeroHojaCambiado?.Invoke(value);
            }
        }

        public delegate void NumeroHojaCambiadoEventHandler(string nuevoNumeroHoja);
        public static event NumeroHojaCambiadoEventHandler NumeroHojaCambiado;
    }
}
