using System;
using REP.EjemploSenial.Modelo;

namespace REP.EjemploSenial.Adquisidor
{
	public class FactoryAdquisidor
	{
		static public Adquisidor ObtenerAdquisidor( string sadquisidor,Senial senial )
		{
			Adquisidor opAdquisidor = null;

			if (sadquisidor == "Simple") {
				opAdquisidor = new AdquisidorSimple (senial);
			}
			else if (sadquisidor == "Senoidal") {
				opAdquisidor = new AdquisidorSenoidal (senial);
			}
			else if (sadquisidor == "Archivo") {
				opAdquisidor = new AdquisidorArchivo (senial);
			}

			return opAdquisidor;

		}
	}
}

