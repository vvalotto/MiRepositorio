using System;
using System.Collections;

namespace NoSPR.EjemploSenial
{
	public class LectorSenial
	{
		private ArrayList _valores = new ArrayList();
		private ArrayList _valoresProcesados = new ArrayList();

		public LectorSenial ()
		{
		}

		private decimal LeerDatoEntrada()
		{
			string _datoEnt;
			decimal _dato;

			Console.Write ("Ingresar Dato:");
			_datoEnt = Console.ReadLine();
			while (!decimal.TryParse (_datoEnt, out _dato)) 
			{
				Console.WriteLine ("Dato mal ingresado, presione una tecla");
				Console.ReadKey ();
				Console.Clear ();
				Console.Write ("Ingresar Dato:");
				_datoEnt = Console.ReadLine ();

			}
			return _dato;

		}

		public void LeerSenial()
		{
			int _nroMuestra = 10;

			Console.WriteLine ("Lectura de la Señal");
			for (int i = 1; i <= _nroMuestra; i++) 
			{
				_valores.Add (LeerDatoEntrada ());
				Console.WriteLine("Datos Ingresados:{0}", i.ToString());
			}

		}

		public void ProcesarSenial()
		{
			int _nroMuestra = 10;

			Console.WriteLine ();
			Console.WriteLine ("Procesando...");
			for (int i = 1; i <= _nroMuestra; i++)
			{
				_valoresProcesados.Add ((decimal)_valores [i - 1] * 2);
			}
			Console.WriteLine ("Fin proceso!");
		}

		public void MostrarSenial()
		{
			int _nroMuestra = 10;
			Console.WriteLine ();
		    Console.WriteLine ("Esta es la Señal");
			for (int i = 1; i <= _nroMuestra; i++) {
				Console.WriteLine ("Dato nro: {0} > {1}", i.ToString (), _valoresProcesados [i-1].ToString ());
			}
		}

	}
}

