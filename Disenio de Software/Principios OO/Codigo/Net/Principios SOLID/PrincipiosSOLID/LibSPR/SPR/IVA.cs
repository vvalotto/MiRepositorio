using System;

namespace SPR

{
	public class IVA
	{
	
		public readonly decimal _iva = 0.16m;

		public decimal CalcularIVA(decimal importe)
		{
			return importe * _iva;
		}
	}
}
