using System;
using SPR.EjemploSenial.Modelo;

namespace SPR.EjemploSenial.Adquisidor
{
	public class Adquisidor
	{
		Senial _senial;

		public Adquisidor(Senial senial)
		{
			_senial = senial;
		}

		public Senial ObtenerSenialAdquirida()
		{
			return this._senial;
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
			int _nroMuestra = 5;

			Console.WriteLine ("Lectura de la Señal");
			for (int i = 1; i <= _nroMuestra; i++) 
			{
				this._senial.PonerValor (LeerDatoEntrada ());
				Console.WriteLine("Datos Ingresados:{0}", i.ToString());
			}

		}
	}
}

