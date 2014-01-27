using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LibOCPModelo;
using LibOCPReglas;

namespace LibOCPControlador

{
	public class CalculadorFactura
    {
		private ADeduccion deduccion;


		public CalculadorFactura(ADeduccion _deduccion)
		{
			deduccion = _deduccion;
		}

		// Método que calcula el total de la factura
		public void CalcularTotal(Factura factura)
		{		

			#region Separando responsabilidades
			//1 . Calcular deducción (las deducciones pueden cambiar), no es propio de la factura
			//2 . Calcular el IVA (El iva puede cambiar), al aplicacion del IVA no es propio de la factura
			//3 . Calcular el importe total de la factura, responsabilidad propia de la factura

			// Calculamos la deducción
			factura.importeDeduccion = deduccion.CalcularDeduccion();

			// Calculamos el IVA
			IVA iva = new IVA();
			factura.importeIVA = iva.CalcularIVA(factura.importeFactura);

			// Calculamos el total
			factura.importeTotal = (factura.importeFactura - factura.importeDeduccion) + factura.importeIVA;
			#endregion

		}

	}
 	

}
