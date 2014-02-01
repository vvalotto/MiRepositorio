using System;
using System.IO;
using REP.EjemploSenial.Modelo;

namespace REP.EjemploSenial.Adquisidor
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

