using System;
using DIP.EjemploSenial.Modelo;
using DIP.EjemploSenial.Adquisidor;
using DIP.EjemploSenial.Visualizador;

namespace SOLID.Tratamiento.Consola
{
	public class ProgramaDIP
	{
		public ProgramaDIP ()
		{
		}

		public void Ejecutar() {

			/*Prepara la adquisicion*/
			SenialPila senialAdquirida = new SenialPila (15);
			GestorAdquisidor gAdquisidor = new GestorAdquisidor ();
			Adquisidor adquisidor = new AdquisidorSimple (senialAdquirida);
			Visualizador visualizador = new Visualizador ();

			gAdquisidor.adquisidor = adquisidor;
			gAdquisidor.Adquirir ();
			visualizador.MostrarValores (gAdquisidor.Obtener ());
		}
	}
}

