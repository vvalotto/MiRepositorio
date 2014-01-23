using System;
using LSP.EjemploSenial.Modelo;
using LSP.EjemploSenial.Adquisidor;
using LSP.EjemploSenial.Procesador;
using LSP.EjemploSenial.Visualizador;


namespace SOLID.Tratamiento.Consola
{
	public class ProgramaNoLSP
	{
		public ProgramaNoLSP ()
		{
		}

		public void Ejecutar(){

			SenialPila senialAdquirida = new SenialPila (5);
			Senial senialProcesada = new SenialCola (5);
			AdquisidorArchivo adquisidor = new AdquisidorArchivo (senialAdquirida);
			ProcesadorDiferencial procesador = new ProcesadorDiferencial ();
			Visualizador visualizador = new Visualizador ();

			Console.WriteLine ("Iniciando");
			adquisidor.ubicacion = "/Users/vvalotto/Documents/Temp/datos.txt";
			adquisidor.LeerSenial ();

			Console.WriteLine ("Se han adquirido:");
			Console.WriteLine (senialAdquirida.CantidadValores().ToString());

			/*procesador.Procesar (senialAdquirida, senialProcesada);

			Console.WriteLine ("Señal Adquirida con fecha: {0}", senialAdquirida.fecha_adquisicion.ToString());
			visualizador.MostrarValores (senialAdquirida);
			Console.WriteLine ("Señal Procesada");
			visualizador.MostrarValores (senialProcesada);*/

			Console.ReadLine ();

			Console.Clear ();
			Console.Write ("Saco el dato: ");
			Console.WriteLine(senialAdquirida.SacarValor().ToString());
			Console.WriteLine("Quedan estos datos :");
			visualizador.MostrarValores (senialAdquirida);
			Console.WriteLine (senialAdquirida.CantidadValores().ToString());
		}
	}
}

