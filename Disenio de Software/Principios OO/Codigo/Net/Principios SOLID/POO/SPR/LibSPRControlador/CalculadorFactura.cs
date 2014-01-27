using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LibSPRModelo;
using LibSPRReglas;

namespace LibSPRControlador

{
	public class CalculadorFactura
    {

		public CalculadorFactura(){
		}

		// Método que calcula el total de la factura
		public void CalcularTotal(Factura factura)
		{		

			#region Separando responsabilidades
			//1 . Calcular deducción (las deducciones pueden cambiar), no es propio de la factura
			//2 . Calcular el IVA (El iva puede cambiar), al aplicacion del IVA no es propio de la factura
			//3 . Calcular el importe total de la factura, responsabilidad propia de la factura

			// Calculamos la deducción
			Deduccion deduccion = new Deduccion();
			factura.importeDeduccion = deduccion.CalcularDeduccion(factura.importeFactura);

			// Calculamos el IVA
			IVA iva = new IVA();
			factura.importeIVA = iva.CalcularIVA(factura.importeFactura);

			// Calculamos el total
			factura.importeTotal = (factura.importeFactura - factura.importeDeduccion) + factura.importeIVA;
			#endregion

		}


    }

	

}
