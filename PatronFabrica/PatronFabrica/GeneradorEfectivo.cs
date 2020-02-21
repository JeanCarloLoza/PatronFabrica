using System;
using System.Collections.Generic;
using System.Text;

namespace PatronFabrica
{
    class GeneradorEfectivo : IFabrica
    {
        public ITipoPago generar()
        {
            return new TipoPagoEfectivo();
        }
    }
}
