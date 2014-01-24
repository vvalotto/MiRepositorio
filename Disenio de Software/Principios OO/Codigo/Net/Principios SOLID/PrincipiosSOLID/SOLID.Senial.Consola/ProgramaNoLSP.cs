using System;
using LSP.EjemploSenial.ISenial;
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

            /*Caso 1*/
            /*Senial senialAdquirida = new Senial();*/
            /*Caso 2*/
            SenialPila senialAdquirida = new SenialPila (5);
            /*Caso 3*/
            /*SenialCola senialAdquirida = new SenialCola(5);*/
			SenialBasica senialProcesada = new SenialBasica ();
			AdquisidorArchivo adquisidor = new AdquisidorArchivo (senialAdquirida);
			ProcesadorDiferencial procesador = new ProcesadorDiferencial ();
			Visualizador visualizador = new Visualizador ();

            Console.WriteLine ("Iniciando Adquisicion");
			adquisidor.ubicacion = "c:/Temp/datos.txt";
			adquisidor.LeerSenial ();

			Console.Write ("Se han adquirido: {0} datos", senialAdquirida.CantidadValores().ToString());
			Console.WriteLine ();

			procesador.Procesar (senialAdquirida, senialProcesada);

			Console.WriteLine ("Señal Adquirida con fecha: {0}", senialAdquirida.fecha_adquisicion.ToString());
			visualizador.MostrarValores (senialAdquirida);
			Console.WriteLine ("Señal Procesada");
			visualizador.MostrarValores (senialProcesada);

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

