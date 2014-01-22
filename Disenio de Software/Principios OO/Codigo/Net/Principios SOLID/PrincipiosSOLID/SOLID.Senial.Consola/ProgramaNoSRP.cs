using System;
using NoSPR.EjemploSenial;

namespace SOLID.Tratamiento.Consola
{

	public class ProgramaNoSRP
	{
		public ProgramaNoSRP ()
		{
		}

		public void Ejecutar()
		{
			/* No SPR */
			LectorSenial senial = new LectorSenial ();

			Console.WriteLine ("Iniciando");
			senial.LeerSenial ();
			senial.ProcesarSenial ();
			senial.MostrarSenial ();

			Console.ReadLine ();
		}
	}
}

