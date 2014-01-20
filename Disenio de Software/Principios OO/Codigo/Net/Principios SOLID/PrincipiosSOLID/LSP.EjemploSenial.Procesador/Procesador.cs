using System;
using LSP.EjemploSenial.Modelo;

namespace LSP.EjemploSenial.Procesador
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

		public abstract void Procesar (Senial senAdquirida, Senial senProcesada);


	}

	/*Simula un proceso de cambio de escala*/
	public class ProcesadorSimple : Procesador
	{
		public ProcesadorSimple ():base()
		{
		}

		public override void Procesar (Senial senAdquirida, Senial senProcesada)
		{

			Console.WriteLine ();
			Console.WriteLine ("Procesando...");
			for (int i = 1; i <= senAdquirida.CantidadValores(); i++)
			{
				senProcesada.PonerValor ((decimal)senAdquirida.ObtenerValor (i - 1) * 2);
			}
			Console.WriteLine ("Fin proceso!");
		}
	}

	/*Simula un proceso de recorte */
	public class ProcesadorConUmbral : Procesador
	{
		public ProcesadorConUmbral ():base()
		{
		}


		public override void Procesar (Senial senAdquirida, Senial senProcesada)
		{
			Console.WriteLine ();
			Console.WriteLine ("Procesando...");
			for (int i = 1; i <= senAdquirida.CantidadValores(); i++)
			{
				if ((decimal)senAdquirida.ObtenerValor (i - 1) < 5) {
					_senialProcesada.PonerValor ((decimal)senAdquirida.ObtenerValor (i - 1) * 2);
				} else {
					senProcesada.PonerValor (0);
				}
			}
			Console.WriteLine ("Fin proceso!");
		}
	}

	/*Simula un proceso de Datos incremetales - Ejemplo para OCP*/
	public class ProcesadorDiferencial : Procesador
	{
		public ProcesadorDiferencial ():base()
		{
		}

		public override void Procesar (Senial senAdquirida, Senial senProcesada)
		{
			decimal _valor_anterior = 0;
			Console.WriteLine ();
			Console.WriteLine ("Procesando...");
			for (int i = 1; i <= senAdquirida.CantidadValores(); i++)
			{
				senProcesada.PonerValor ((decimal)senAdquirida.ObtenerValor (i - 1) - _valor_anterior);
				_valor_anterior = (decimal)senAdquirida.ObtenerValor (i - 1);
			}
			Console.WriteLine ("Fin proceso!");
		}
	}
}

