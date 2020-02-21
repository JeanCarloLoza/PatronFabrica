using System;
using System.Collections.Generic;
using System.Text;

namespace PatronFabrica
{
    class TipoPagoEfectivo : ITipoPago
    {
        public string obtenerTexto()
        {
            return "en efectivo";
        }

        public bool validarAutorizacion(double monto)
        {
            return monto <= 5000;
        }
    }
}
