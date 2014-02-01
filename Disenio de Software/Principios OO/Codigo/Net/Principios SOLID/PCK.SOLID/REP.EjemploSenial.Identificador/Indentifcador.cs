using System;
using REP.EjemploSenial.Modelo;

namespace REP.EjemploSenial.Identificador
{
	public class Identificador
	{

		public void Ingresar(Senial senial, string titulo)
		{
			string o = "N";

			while (o != "S") {

				Console.Clear ();
				Console.WriteLine (titulo);

				Console.Write ("Identificador de la Señal (numero):");
				senial.Id = Convert.ToInt32 (Console.ReadLine ());

				Console.Write ("Descripcion de identificacion:");
				senial.descripcion = Console.ReadLine ();

				Console.Write ("Es correcto (S/N)?");
				o = Console.ReadLine().ToUpper();
			}

		}
	}
}
