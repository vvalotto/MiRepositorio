using System;
using DIP.EjemploSenial.Modelo;
using DIP.EjemploSenial.Adquisidor;
using DIP.EjemploSenial.Visualizador;
using DIP.EjemploSenial.Procesador;
using DIP.EjemploSenial.Identificador;
using DIP.EjemploSenial.Utils;
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
			Adquisidor adquisidor;
			IProcesador procesador;
            IRepositorio repositorio;
			Senial senialAdquirida;
			Senial senialProcesada;


			senialAdquirida = FactorySenial.ObtenerSenial("Pila", 5);
			senialProcesada = FactorySenial.ObtenerSenial("Basica", 0);
			adquisidor = FactoryAdquisidor.ObtenerAdquisidor ("Simple", senialAdquirida);
			procesador = FactoryProcesador.ObtenerProcesador ("Umbral");
            repositorio = FactoryDAO.ObtenerRepositorio("Texto", "C:\\Temp");
			var identificador = new Identificador ();
			var visualizador = new Visualizador ();

			/*Identifica las señales*/
			identificador.Ingresar (senialAdquirida, "Señal a Adquirir");
			identificador.Ingresar (senialProcesada, "Señal a Procesar");

			/*Ejecuta la cadena de procesos */
			Console.WriteLine ("1. Adquiere");
			adquisidor.LeerSenial ();
			visualizador.MostrarValores (adquisidor.ObtenerSenialAdquirida());

			Console.WriteLine ("2. Procesa");
			procesador.Procesar (senialAdquirida, senialProcesada);
			visualizador.MostrarValores (senialProcesada);

            /*Guarda Señal*/
            Console.WriteLine("3. Guarda");
            repositorio.Guardar(senialProcesada);
            visualizador.MostrarValores(repositorio.Recuperar(senialProcesada.Id));

		}
	}
}

