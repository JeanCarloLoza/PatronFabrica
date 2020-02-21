using System;
using System.Collections.Generic;
using System.Text;

namespace PatronFabrica
{
    class ProcesadorPedido : IProcesarPedido
    {
        IFabrica fabrica;
        public ProcesadorPedido(IFabrica fabrica)
        {
            this.fabrica = fabrica;
        }
        public string procesar(string cConcepto, double dImporte)
        {
            
            ITipoPago tipopago = fabrica.generar();
            string texto = tipopago.obtenerTexto();
            bool lAutorizado = tipopago.validarAutorizacion(dImporte);

            return string.Format(
                "Pedido {0} con importe de {1} {2} fue {3} ",
                cConcepto, dImporte, texto, lAutorizado ? "autorizado" : "rechazado");
        }
    }
}
