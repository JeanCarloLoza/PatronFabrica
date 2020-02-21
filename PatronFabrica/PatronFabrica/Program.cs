using System;

namespace PatronFabrica
{
    class Program
    {
        static void Main(string[] args)
        {
            string cConcepto = "";
            string cImporte = "";
            string cModalidad = "";
            double dImporte = 0;
            bool lAutorizado = false;

            Console.WriteLine("Concepto del pedido");
            cConcepto=Console.ReadLine();
            Console.WriteLine("Importe del pedido");
            cImporte = Console.ReadLine();
            Console.WriteLine("Modalidad del pedido");
            cModalidad = Console.ReadLine();

            cModalidad = cModalidad.ToUpper();
            dImporte = double.Parse(cImporte);

            switch (cModalidad) {
                case "EFECTIVO":
                    cModalidad = "en efectivo";
                    lAutorizado = dImporte <= 5000;
                    break;
                case "TARJETA":
                    cModalidad = "con tarjeta";
                    lAutorizado = dImporte > 5000;
                    break;
                default:
                    throw new Exception("Concepto Erroneo");
                    break;
            }

            Console.WriteLine(string.Format(
                "Pedido {0} con importe de {1} {2} fue {3} ",
                cConcepto,cImporte,cModalidad, lAutorizado ? "autorizado" : "rechazado"));
        }
    }
}
