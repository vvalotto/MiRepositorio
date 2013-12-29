using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SPR

{
    class Factura
    {
        public string _codigo;
        public DateTime _fechaEmision;
        public decimal _importeFactura;
        public decimal _importeIVA;
        public decimal _importeDeduccion;
        public decimal _importeTotal;
        public ushort _porcentajeDeduccion;

        // Método que calcula el total de la factura
        public void CalcularTotalA()
        {

            #region Violando del SPR
            // Calculamos la deducción
            _importeDeduccion = (_importeFactura * _porcentajeDeduccion) / 100;
            // Calculamos el IVA
            _importeIVA = _importeFactura * 0.16m;
            // Calculamos el total
            _importeTotal = (_importeFactura - _importeDeduccion) + _importeIVA;
            #endregion


        }

		// Método que calcula el total de la factura
		public void CalcularTotalB()
		{
		

			#region Separando responsabilidades
			//1 . Calcular deducción (las deducciones pueden cambiar), no es propio de la factura
			//2 . Calcular el IVA (El iva puede cambiar), al aplicacion del IVA no es propio de la factura
			//3 . Calcular el importe total de la factura, responsabilidad propia de la factura

			// Calculamos la deducción
			Deduccion deduccion = new Deduccion(_porcentajeDeduccion);
			_importeDeduccion = deduccion.CalcularDeduccion(_importeFactura);

			// Calculamos el IVA
			IVA iva = new IVA();
			_importeIVA = iva.CalcularIVA(_importeFactura);

			// Calculamos el total
			_importeTotal = (_importeFactura - _importeDeduccion) + _importeIVA;
			#endregion

		}


    }
	
	

}
