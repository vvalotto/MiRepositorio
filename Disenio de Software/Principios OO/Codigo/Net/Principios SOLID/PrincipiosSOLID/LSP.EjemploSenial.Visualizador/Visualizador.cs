using System;
using LSP.EjemploSenial.Modelo;

namespace LSP.EjemploSenial.Visualizador
{
	public class Visualizador
	{
		public Visualizador ()
		{
		}

		public void MostrarValores(Senial senial)
		{
			Console.WriteLine ();
			Console.WriteLine ("Esta es la Señal");
			for (int i = 1; i <= senial.CantidadValores(); i++) {
				Console.WriteLine ("Dato nro: {0} > {1}", i.ToString (), senial.ObtenerValor(i-1).ToString ());
			}
		}
	}
}

