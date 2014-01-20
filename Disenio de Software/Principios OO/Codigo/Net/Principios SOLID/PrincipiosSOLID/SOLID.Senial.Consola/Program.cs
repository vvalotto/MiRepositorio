using System;
/*using SPR.EjemploSenial.Modelo;
using SPR.EjemploSenial.Adquisidor;
using SPR.EjemploSenial.Procesador;
using SPR.EjemploSenial.Visualizador;*/

using OCP.EjemploSenial.Modelo;
using OCP.EjemploSenial.Adquisidor;
using OCP.EjemploSenial.Procesador;
using OCP.EjemploSenial.Visualizador;

/*using LSP.EjemploSenial.Modelo;
using LSP.EjemploSenial.Adquisidor;
using LSP.EjemploSenial.Procesador;
using LSP.EjemploSenial.Visualizador;*/

namespace SOLID.Tratamiento.Consola
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			/* No SPR
			LectorSenial senial = new LectorSenial ();

			Console.WriteLine ("Iniciando");
			senial.LeerSenial ();
			senial.ProcesarSenial ();
			senial.MostrarSenial ();

			Console.ReadLine ();
			*/

			/*SPR
			Senial senialAdquirida = new Senial ();
			Senial senialProcesada = new Senial ();
			Adquisidor adquisidor = new Adquisidor (senialAdquirida);
			Procesador procesador = new Procesador ();
			Visualizador visualizador = new Visualizador ();

			Console.WriteLine ("Iniciando");
			adquisidor.LeerSenial ();

			Console.WriteLine ("Se han adquirido:");
			Console.WriteLine (senialAdquirida.CantidadValores ().ToString());

			senialProcesada = procesador.Procesar (senialAdquirida);

			Console.WriteLine ("Señal Adquirida");
			visualizador.MostrarValores (senialAdquirida);
			Console.WriteLine ("Señal Procesada");
			visualizador.MostrarValores (senialProcesada);

			Console.ReadLine ();
			*/



			/*OCP*/
			Senial senialAdquirida = new Senial ();
			Senial senialProcesada = new Senial ();
			AdquisidorSimple adquisidor = new AdquisidorSimple (senialAdquirida);
			ProcesadorDiferencial procesador = new ProcesadorDiferencial ();
			Visualizador visualizador = new Visualizador ();

			Console.WriteLine ("Iniciando");
			/*adquisidor.ubicacion = "/Users/vvalotto/Documents/Temp/datos.txt";*/
			adquisidor.LeerSenial ();

			Console.WriteLine ("Se han adquirido:");
			Console.WriteLine (senialAdquirida.CantidadValores ().ToString());

			procesador.Procesar (senialAdquirida, senialProcesada);

			Console.WriteLine ("Señal Adquirida con fecha: {0}", senialAdquirida.fecha_adquisicion.ToString());
			visualizador.MostrarValores (senialAdquirida);
			Console.WriteLine ("Señal Procesada");
			visualizador.MostrarValores (senialProcesada);

			Console.ReadLine ();
		    /*	Fin OCP*/

			/*SenialPila senialAdquirida = new SenialPila (5);
			Senial senialProcesada = new SenialCola (5);
			AdquisidorArchivo adquisidor = new AdquisidorArchivo (senialAdquirida);
			ProcesadorDiferencial procesador = new ProcesadorDiferencial ();
			Visualizador visualizador = new Visualizador ();

			Console.WriteLine ("Iniciando");
			adquisidor.ubicacion = "/Users/vvalotto/Documents/Temp/datos.txt";
			adquisidor.LeerSenial ();

			Console.WriteLine ("Se han adquirido:");
			Console.WriteLine (senialAdquirida.tamanio.ToString());

			procesador.Procesar (senialAdquirida, senialProcesada);

			Console.WriteLine ("Señal Adquirida con fecha: {0}", senialAdquirida.fecha_adquisicion.ToString());
			visualizador.MostrarValores (senialAdquirida);
			Console.WriteLine ("Señal Procesada");
			visualizador.MostrarValores (senialProcesada);

			Console.ReadLine ();
			Console.Clear ();
			Console.WriteLine(senialAdquirida.SacarValor().ToString());
			visualizador.MostrarValores (senialAdquirida);*/

		}
	}
}
