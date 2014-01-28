using System;
using DIP.EjemploSenial.Modelo;
using DIP.EjemploSenial.Adquisidor;
using DIP.EjemploSenial.Visualizador;
using DIP.EjemploSenial.Procesador;
using DIP.EjemploSenial.Identificador;
using DIP.EjemploSenial.DAO;

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
            var repArchivo = new RepositorioArchivo("c:\\Temp");



			/* Prepara la cadena de procesos */
			var gAdquisidor = new GestorAdquisidor ();
			var adquisidor = new AdquisidorSimple (senialAdquirida);
			gAdquisidor.adquisidor = adquisidor;
			var gProcesador = new GestorProcesador (procesador);
			var visualizador = new Visualizador ();
            var gRepositorio = new GestorRepositorio(repArchivo);

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

            /*Guarda las señales*/
            Console.WriteLine("3. Guarda");
            gRepositorio.Guardar(senialAdquirida);
            gRepositorio.Guardar(senialProcesada);

            var idsa = senialAdquirida.Id;
            var idsp = senialProcesada.Id;

            Console.WriteLine("4. Muestra los guardado");
            visualizador.MostrarValores(gRepositorio.Recuperar(idsa));
            visualizador.MostrarValores(gRepositorio.Recuperar(idsp));

		}
	}
}

