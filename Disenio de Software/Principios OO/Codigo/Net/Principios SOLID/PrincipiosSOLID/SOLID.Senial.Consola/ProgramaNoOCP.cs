using System;
using SPR.EjemploSenial.Adquisidor;
using SPR.EjemploSenial.Procesador;
using SPR.EjemploSenial.Visualizador;
using SPR.EjemploSenial.Modelo;

namespace SOLID.Tratamiento.Consola
{
	public class ProgramaNoOCP
	{
		public ProgramaNoOCP ()
		{
		}

		public void Ejecutar(){

			/*No OCP*/

			Senial senialAdquirida = new Senial ();
			Senial senialProcesada = new Senial ();

			Adquisidor adquisidor = new Adquisidor (senialAdquirida);
			Procesador procesador = new Procesador ();
			Visualizador visualizador = new Visualizador ();

			/*	dquiere Señal */
			Console.WriteLine ("Iniciando");
			adquisidor.LeerSenial ();
			Console.WriteLine ("Se han adquirido:");
			Console.WriteLine (senialAdquirida.CantidadValores ().ToString());

			/*Procesa Señal: aqui tiene impacto ya debe cambiarse el metodo al que llama*/
			senialProcesada = procesador.Procesar (senialAdquirida);
			/*senialProcesada = procesador.ProcesarConUmbral (senialAdquirida);*/


			/*Muestra Señales*/
			Console.WriteLine ("Señal Adquirida");
			visualizador.MostrarValores (senialAdquirida);
			Console.WriteLine ("Señal Procesada");
			visualizador.MostrarValores (senialProcesada);

			Console.ReadLine ();
			}
		}

}

