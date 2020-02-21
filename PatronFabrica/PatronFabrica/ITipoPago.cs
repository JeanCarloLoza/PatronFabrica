using System;
using System.Collections.Generic;
using System.Text;

namespace PatronFabrica
{
    interface ITipoPago
    {
        public string obtenerTexto();
        public bool validarAutorizacion(double monto);
    }
}
