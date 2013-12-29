using System;

namespace SPR
{
	public class Deduccion
	{
		private decimal _deduccion;

		public Deduccion(ushort porcentaje)
		{
			_deduccion = porcentaje;
		}

		public decimal CalcularDeduccion(decimal importe)
		{
			return (importe * _deduccion) / 100;
		}
	}
}

