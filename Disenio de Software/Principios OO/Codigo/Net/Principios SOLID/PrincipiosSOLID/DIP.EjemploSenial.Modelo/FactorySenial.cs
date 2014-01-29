using System;

namespace DIP.EjemploSenial.Modelo
{
	public class FactorySenial
	{
		public FactorySenial ()
		{
		}
		static public Senial ObtenerSenial(string ssenial, int largo)
		{
			Senial opSenial = null;

			if (ssenial == "Basica") {
				opSenial = new SenialBasica ();
			} else if ( ssenial == "Pila") {
				opSenial = new SenialPila (largo);
			} else if (ssenial == "Cola") {
				opSenial = new SenialCola (largo);
			}

			return opSenial;
		}
	}
}

