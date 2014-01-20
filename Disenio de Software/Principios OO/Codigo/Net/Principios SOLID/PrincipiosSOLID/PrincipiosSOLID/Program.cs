using System;
using LibOCPControlador;
using LibOCPReglas;
using LibOCPModelo;

namespace PrincipiosSOLID
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine("Iniciando");
			Factura factura1 = new Factura();
			Factura factura2 = new Factura();

			DeduccionSimple deduccion = new DeduccionSimple (factura1);
			CalculadorFactura calculador1 = new CalculadorFactura(deduccion);
			factura1.importeFactura = 100;
			calculador1.CalcularTotal(factura1);

			Console.WriteLine(factura1.importeTotal);

			DeduccionProporcional deduccionp = new DeduccionProporcional (factura2);
			CalculadorFactura calculador2 = new CalculadorFactura(deduccionp);
			factura2.importeFactura = 200;
			calculador2.CalcularTotal(factura2);

			Console.WriteLine(factura2.importeTotal);

			DeduccionPorCliente deduccionc = new DeduccionPorCliente (factura2);
			CalculadorFactura calculador3 = new CalculadorFactura(deduccionc);
			factura2.importeFactura = 200;
			calculador3.CalcularTotal(factura2);

			Console.WriteLine(factura2.importeTotal);

		}
	}
}
