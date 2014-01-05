using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SPR

{
    class Program
    {
        static void Main(string[] args)
        {
            Factura miFacturaA = new Factura();
            miFacturaA._importeFactura = 120.30M;
            miFacturaA.CalcularTotalA();
			Console.WriteLine("Total: " + miFacturaA._importeTotal);

			Factura miFacturaB = new Factura();
			miFacturaB._importeFactura = 150.30M;
			miFacturaB.CalcularTotalB ();
            Console.WriteLine("Total: " + miFacturaB._importeTotal);
            Console.ReadLine();


        }
    }
}
