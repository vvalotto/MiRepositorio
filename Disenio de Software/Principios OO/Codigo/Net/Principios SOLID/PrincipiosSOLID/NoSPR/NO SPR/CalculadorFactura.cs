using System;

namespace NoSPR
{
	public class CalculadorFactura
	{
		public CalculadorFactura ()
		{
		}

		public void CalcularTotal(Factura factura)
		{

			#region Violando del SPR
			// Calculamos la deducción
			factura.importeDeduccion = (factura.importeFactura * factura.porcentajeDeduccion) / 100;
			// Calculamos el IVA
			factura.importeIVA = factura.importeFactura * 0.16m;
			// Calculamos el total
			factura.importeTotal = (factura.importeFactura - factura.importeDeduccion) + factura.importeIVA;
			#endregion


		}

	}
}

