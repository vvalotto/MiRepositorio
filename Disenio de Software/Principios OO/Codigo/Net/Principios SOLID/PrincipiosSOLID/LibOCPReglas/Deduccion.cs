using System;

namespace LibOCPReglas
{
	public class Deduccion
	{
		private decimal _deduccion = 10;
		private decimal _deduccion_vip = 20;


		public decimal CalcularDeduccion(decimal importe)
		{
			return (importe * _deduccion) / 100;
		}

		public decimal CalcularDeduccionProporcional(decimal importe)
		{
			if (importe > 100) {
				return (importe * _deduccion_vip) / 100;
			} else {
				return (importe * _deduccion) / 100;
			}
		}
	}



	public abstract class ADeduccion
	{
		public abstract decimal CalcularDeduccion (decimal importe);

	}

	public class DeduccionSimple:ADeduccion
	{
		private decimal _deduccion = 10;
		override public decimal CalcularDeduccion(decimal importe)
		{
			return (importe * _deduccion) / 100;
		}

	}

	public class DeduccionProporcional:ADeduccion
	{
		private decimal _deduccion = 10;
		private decimal _deduccion_vip = 20;

		override public decimal CalcularDeduccion(decimal importe)
		{
			if (importe > 100) {
				return (importe * _deduccion_vip) / 100;
			} else {
				return (importe * _deduccion) / 100;
			}
		}

	}


}

