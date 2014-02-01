using System;
using REP.EjemploSenial.Modelo;
using REP.EjemploSenial.Adquisidor;
using REP.EjemploSenial.Visualizador;
using REP.EjemploSenial.Procesador;
using REP.EjemploSenial.Identificador;
using REP.EjemploSenial.DAO;

namespace SOLID.Consola
{
	public class ProgramaTratamientoSenial
	{
		public ProgramaTratamientoSenial ()
		{
		}

		public void Ejecutar() {
	
			/*Prepara los componentes (objetos) que colaboran en el programa*/
			/* Tipo de señales, adquisidor, procesador y repositorio */
			Adquisidor adquisidor;
			IProcesador procesador;
            IRepositorio repositorio;
			Senial senialAdquirida;
			Senial senialProcesada;
		
			/*Se crean las instancias de los objetos */
			/*Se utiliza el patron Factory como responsable de la creacion de cada objeto*/
			/*Señales*/
			senialAdquirida = FactorySenial.ObtenerSenial("Pila", 5);
			senialProcesada = FactorySenial.ObtenerSenial("Basica", 0);
			/*Adquisidor*/
			adquisidor = FactoryAdquisidor.ObtenerAdquisidor ("Simple", senialAdquirida);
			/*Procesador*/
			procesador = FactoryProcesador.ObtenerProcesador ("Umbral");
			repositorio = FactoryDAO.ObtenerRepositorio("Texto", "/Users/vvalotto/Documents/Temp");
			/*Se crean los responsables de la entrada y salida de usuario*/
			var identificador = new Identificador ();
			var visualizador = new Visualizador ();

		
			/*Inicio del proceso pipeline*/
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

