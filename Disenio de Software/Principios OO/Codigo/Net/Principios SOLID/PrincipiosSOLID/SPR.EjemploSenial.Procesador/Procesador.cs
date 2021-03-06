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

		/* Se quiere agregar otro tipo de procesamiento, como metodo, pero se 
         * cambia la clase. Si bien por la separacion de intereses solo
         * se cambia el modulo del procesador sin impacto en el resto, si quiero usar
         * esta nuevo procesamiento tengo que cambiar el cliente, con la llamada la m�todo*/
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

