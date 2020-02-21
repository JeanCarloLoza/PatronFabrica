using System;
using System.Collections.Generic;
using System.Text;

namespace PatronFabrica
{
    class GeneradorTarjeta : IFabrica
    {
        public ITipoPago generar()
        {
            return new TipoPagoTarjeta();
        }
    }
}
