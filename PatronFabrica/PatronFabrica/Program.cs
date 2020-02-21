using System;

namespace PatronFabrica
{
    class Program
    {
        static void Main(string[] args)
        {
            IFabrica fabrica;
            string cConcepto = "";
            string cImporte = "";
            string cModalidad = "";
            double dImporte = 0;
            string cRespuesta = "";

            Console.WriteLine("Concepto del pedido");
            cConcepto = Console.ReadLine();
            Console.WriteLine("Importe del pedido");
            cImporte = Console.ReadLine();
            Console.WriteLine("Modalidad del pedido");
            cModalidad = Console.ReadLine();

            cModalidad = cModalidad.ToUpper();
            dImporte = double.Parse(cImporte);

            switch (cModalidad)
            {
                case "EFECTIVO":
                    fabrica = new GeneradorEfectivo();
                    break;
                case "TARJETA":
                    fabrica = new GeneradorTarjeta();
                    break;
                default:
                    throw new Exception("Concepto Erroneo");
            }

            IProcesarPedido procesador = new ProcesadorPedido(fabrica);

            cRespuesta=procesador.procesar(cConcepto, dImporte);

            Console.WriteLine(cRespuesta);
        }
    }
}
