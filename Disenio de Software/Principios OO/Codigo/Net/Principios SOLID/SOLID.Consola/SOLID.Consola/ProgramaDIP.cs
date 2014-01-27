using System;
using DIP.EjemploSenial.Modelo;
using DIP.EjemploSenial.Adquisidor;
using DIP.EjemploSenial.Visualizador;
using DIP.EjemploSenial.Procesador;
using DIP.EjemploSenial.Identificador;

namespace SOLID.Consola
{
	public class ProgramaDIP
	{
		public ProgramaDIP ()
		{
		}

		public void Ejecutar() {

			/*Prepara la adquisicion*/
			/* Tipo de señales y procesador */
			var senialAdquirida = new SenialPila (5);
			var senialProcesada = new SenialCola (5);
			var procesador = new ProcesadorDiferencial ();
			var identificador = new Identificador ();


			/* Prepara la cadena de procesos */
			var gAdquisidor = new GestorAdquisidor ();
			var adquisidor = new AdquisidorSimple (senialAdquirida);
			gAdquisidor.adquisidor = adquisidor;
			var gProcesador = new GestorProcesador (procesador);
			var visualizador = new Visualizador ();

			/*Identifica las señales*/
			identificador.Ingresar (senialAdquirida, "Señal a Adquirir");
			identificador.Ingresar (senialProcesada, "Señal a Procesar");

			/*Ejecuta la cadena de procesos */
			Console.WriteLine ("1. Adquiere");
			gAdquisidor.Adquirir ();
			visualizador.MostrarValores (gAdquisidor.Obtener ());

			Console.WriteLine ("2. Procesa");
			gProcesador.Procesar (senialAdquirida, senialProcesada);
			visualizador.MostrarValores (senialProcesada);

		}
	}
}

