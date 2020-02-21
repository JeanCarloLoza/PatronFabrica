using System;
using System.Collections.Generic;
using System.Text;

namespace PatronFabrica
{
    class TipoPagoTarjeta : ITipoPago
    {
        public string obtenerTexto()
        {
            return "en tarjeta";
        }

        public bool validarAutorizacion(double monto)
        {
            return monto > 5000;
        }
    }
}
