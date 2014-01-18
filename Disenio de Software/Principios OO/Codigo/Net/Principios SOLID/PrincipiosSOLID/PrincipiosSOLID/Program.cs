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

			CalculadorFactura calculador1 = new CalculadorFactura(new DeduccionSimple());
			factura1.importeFactura = 100;
			calculador1.CalcularTotal(factura1);

			CalculadorFactura calculador2 = new CalculadorFactura(new DeduccionProporcional());
			factura2.importeFactura = 200;
			calculador2.CalcularTotal(factura2);
		
			Console.WriteLine(factura1.importeTotal);
			Console.WriteLine(factura2.importeTotal);

		}
	}
}
