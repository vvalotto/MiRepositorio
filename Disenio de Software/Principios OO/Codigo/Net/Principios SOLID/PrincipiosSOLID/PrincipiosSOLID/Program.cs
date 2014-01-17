using System;
using SPR;

namespace PrincipiosSOLID
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine("Iniciando");
			Factura factura = new Factura();
			CalculadorFactura calculador = new CalculadorFactura();

			factura.importeFactura = 100;
			calculador.CalcularTotal(factura);

			Console.WriteLine(factura.importeTotal);

		}
	}
}
