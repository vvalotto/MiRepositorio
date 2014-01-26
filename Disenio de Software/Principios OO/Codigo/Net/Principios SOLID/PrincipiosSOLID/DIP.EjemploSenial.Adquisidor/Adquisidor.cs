using System;
using System.IO;
using DIP.EjemploSenial.Modelo;

namespace DIP.EjemploSenial.Adquisidor
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

}

