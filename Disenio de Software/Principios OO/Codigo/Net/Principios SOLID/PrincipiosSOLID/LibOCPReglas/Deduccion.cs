using System;
using LibOCPModelo;

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
		protected Factura factura;

		public ADeduccion(Factura _factura)
		{
			factura = _factura;
		}

		public abstract decimal CalcularDeduccion ();

	}

	public class DeduccionSimple:ADeduccion
	{
		private decimal _deduccion = 10;

		public DeduccionSimple(Factura factura):base(factura)
		{
		}
	
	override public decimal CalcularDeduccion ()
		{

			return (factura.importeFactura * _deduccion) / 100;
		}

	}

	public class DeduccionProporcional:ADeduccion
	{
		private decimal _deduccion = 10;
		private decimal _deduccion_vip = 20;

		public DeduccionProporcional(Factura factura):base(factura)
		{
		}

		override public decimal CalcularDeduccion()
		{
			if (factura.importeFactura > 100) {
				return (factura.importeFactura * _deduccion_vip) / 100;
			} else {
				return (factura.importeFactura * _deduccion) / 100;
			}
		}

	}


	public class DeduccionPorCliente:ADeduccion
	{
		private decimal _deduccion = 10;
		private decimal _deduccion_vip = 50;

		public DeduccionPorCliente(Factura factura):base(factura)
		{
		}

		override public decimal CalcularDeduccion()
		{
			switch (factura.tCliente)
			{
			case TipoCliente.ClienteNormal:
				return ((factura.importeFactura * _deduccion) / 100);
				break;
			case TipoCliente.ClienteVIP:
				return ((factura.importeFactura * _deduccion_vip) / 100);
				break;
			default:
				return 0;
				break;
			}

		}

	}
}