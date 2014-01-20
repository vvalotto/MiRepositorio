using System;
using OCP.EjemploSenial.Modelo;

namespace OCP.EjemploSenial.AbstractProcesador
{

	/*Para OCP 
	 * Se refactoriza la clase de manera de extender otros tipos de 
	 * funciones procesamiento sin que impacte en los anteriores programas
	 * o que cambiando solo las clase de alto nivel se pueda "armar" la solucion */
	public abstract class Procesador
	{
		protected Senial _senialProcesada;
		public Procesador ()
		{
			_senialProcesada = new Senial ();
		}

		public abstract Senial Procesar (Senial senial);


	}

	/*Simula un proceso de cambio de escala*/
	public class ProcesadorSimple : Procesador
	{
		public ProcesadorSimple ():base()
		{
		}

		public override Senial Procesar(Senial senial)
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
	}

	/*Simula un proceso de recorte */
	public class ProcesadorConUmbral : Procesador
	{
		public ProcesadorConUmbral ():base()
		{
		}


		public override Senial Procesar(Senial senial)
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

	/*Simula un proceso de Datos incremetales - Ejemplo para OCP*/
	public class ProcesadorDiferencial : Procesador
	{
		public ProcesadorDiferencial ():base()
		{
		}

		public override Senial Procesar(Senial senial)
		{
			decimal _valor_anterior = 0;
			Console.WriteLine ();
			Console.WriteLine ("Procesando...");
			for (int i = 1; i <= senial.CantidadValores(); i++)
			{
				_senialProcesada.PonerValor ((decimal)senial.ObtenerValor (i - 1) - _valor_anterior);
				_valor_anterior = (decimal)senial.ObtenerValor (i - 1);
			}
			Console.WriteLine ("Fin proceso!");
			return _senialProcesada;
		}
	}
}

