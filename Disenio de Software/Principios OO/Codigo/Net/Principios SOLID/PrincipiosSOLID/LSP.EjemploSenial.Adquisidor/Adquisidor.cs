using System;
using System.IO;
using LSP.EjemploSenial.ISenial;

namespace LSP.EjemploSenial.Adquisidor
{
	public abstract class Adquisidor
	{
		protected Senial _senial;

		public Adquisidor(Senial senial)
		{
			_senial = senial;
		}

		public Senial ObtenerSenialAdquirida()
		{
			return this._senial;
		}

		protected abstract decimal LeerDatoEntrada ();


		public abstract void LeerSenial ();

	}

	/*Adquisidor de datos desde el teclado*/
	public class AdquisidorSimple: Adquisidor
	{

		public AdquisidorSimple (Senial senial) : base (senial)
		{
		}

		protected override decimal LeerDatoEntrada()
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

		public override void LeerSenial()
		{
			int _nroMuestra = 10;

			Console.WriteLine ("Lectura de la Señal");
			for (int i = 1; i <= _nroMuestra; i++) 
			{
				this._senial.PonerValor (LeerDatoEntrada ());
				Console.WriteLine("Datos Ingresados:{0}", i.ToString());
			}

		}
	}

	/*Adquisidor de datos desde Archivo*/
	public class AdquisidorArchivo: Adquisidor
	{
		string _ubicacion;
		StreamReader _archivo;

		public string ubicacion {
			get {
				return _ubicacion;
			}
			set {
				_ubicacion = value;
			}
		}

		public AdquisidorArchivo (Senial senial) : base (senial)
		{
		}

		protected override decimal LeerDatoEntrada()
		{
			return 0;
		}

		public override void LeerSenial()
		{
			int _contador = 0;
			string _valor;
			decimal _dato;

			Console.WriteLine ("Lectura de la Señal");
			try
			{
				this._archivo= new System.IO.StreamReader(_ubicacion);
				while((_valor = _archivo.ReadLine()) != null)
				{
					if (decimal.TryParse (_valor, out _dato))
					{
						this._senial.PonerValor(_dato);
						_contador++;
						Console.WriteLine("Datos Ingresados:{0}", _contador.ToString());
					}
					else 
					{
						throw new System.InvalidOperationException("No son numeros");
					}
				}

			}
			catch (Exception e)
			{
				Console.WriteLine (e.Message);
			}
		}
	}


}

