using System;
using System.Collections.Generic;
using System.Text;

namespace PatronFabrica
{
    interface IProcesarPedido
    {
        public string procesar(string cConcepto, double dImporte);
    }
}
