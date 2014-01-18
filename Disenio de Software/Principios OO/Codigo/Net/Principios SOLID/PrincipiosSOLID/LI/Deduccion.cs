using System;

namespace LibSPRReglas
{
	public class Deduccion
	{
		private decimal _deduccion = 10;


		public decimal CalcularDeduccion(decimal importe)
		{
			return (importe * _deduccion) / 100;
		}
	}
}

