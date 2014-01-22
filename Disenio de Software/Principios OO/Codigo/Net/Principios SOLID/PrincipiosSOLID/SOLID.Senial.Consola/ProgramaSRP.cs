using System;
using SPR.EjemploSenial.Adquisidor;
using SPR.EjemploSenial.Procesador;
using SPR.EjemploSenial.Visualizador;
using SPR.EjemploSenial.Modelo;

namespace SOLID.Tratamiento.Consola
{
	public class ProgramaSRP
	{
		public ProgramaSRP ()
		{
		}

		public void Ejecutar(){
			/*SPR*/

			Senial senialAdquirida = new Senial ();
			Senial senialProcesada = new Senial ();

			Adquisidor adquisidor = new Adquisidor (senialAdquirida);
			Procesador procesador = new Procesador ();
			Visualizador visualizador = new Visualizador ();

			/*Adquiere Señal*/
			Console.WriteLine ("Iniciando");
			adquisidor.LeerSenial ();
			Console.WriteLine ("Se han adquirido:");
			Console.WriteLine (senialAdquirida.CantidadValores ().ToString());

			/*Procesa Señal*/
			senialProcesada = procesador.Procesar (senialAdquirida);

			/*Muestra Señales*/
			Console.WriteLine ("Señal Adquirida");
			visualizador.MostrarValores (senialAdquirida);
			Console.WriteLine ("Señal Procesada");
			visualizador.MostrarValores (senialProcesada);

			Console.ReadLine ();
		}
	}
}

