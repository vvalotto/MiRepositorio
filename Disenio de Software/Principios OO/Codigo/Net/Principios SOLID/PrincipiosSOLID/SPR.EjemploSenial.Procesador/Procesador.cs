using System;
using SPR.EjemploSenial.Modelo;

namespace SPR.EjemploSenial.Procesador
{
	public class Procesador
	{
		Senial _senialProcesada;
		public Procesador ()
		{
			_senialProcesada = new Senial ();
		}

		public Senial Procesar(Senial senial)
		{

			Console.WriteLine ();
			Console.WriteLine ("Procesando...");
			for (int i = 1; i <= senial.CantidadValores(); i++)
			{
				_senialProcesada.PonerValor ((decimal)senial.ObtenerValor (i - 1) * 2);
			}
			Console.WriteLine ("Fin proceso!");
			return _senialProcesada;
		}

		public Senial ProcesarConUmbral(Senial senial)
		{
			Console.WriteLine ();
			Console.WriteLine ("Procesando...");
			for (int i = 1; i <= senial.CantidadValores(); i++)
			{
				if ((decimal)senial.ObtenerValor (i - 1) < 5) {
					_senialProcesada.PonerValor ((decimal)senial.ObtenerValor (i - 1) * 2);
				} else {
					_senialProcesada.PonerValor (0);
				}
			}
			Console.WriteLine ("Fin proceso!");
			return _senialProcesada;
		}

	}
}

