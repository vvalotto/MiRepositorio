using System;
using CCP.EjemploSenial.Modelo;
using CCP.EjemploSenial.Utils;
using CCP.EjemploSenial.Datos;
using CCP.EjemploSenial.Dominio;
using CCP.EjemploSenial.IOConsola;

namespace SOLID.Consola
{
	public class ProgramaTratamientoSenial
	{
		public ProgramaTratamientoSenial ()
		{
		}

		public void Ejecutar() {


            LoggerConsola logger = new LoggerConsola();
            AuditorArchivo auditor = new AuditorArchivo();
            logger.IniTraza(Nivel.INFO);
            auditor.NombreArchivo = "C:\\Temp\\auditor.log";

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
			senialAdquirida = FactorySenial.ObtenerSenial("Pila", 10);
			senialProcesada = FactorySenial.ObtenerSenial("Basica", 0);
			/*Adquisidor*/
			adquisidor = FactoryAdquisidor.ObtenerAdquisidor ("Senoidal", senialAdquirida);
			/*Procesador*/
			procesador = FactoryProcesador.ObtenerProcesador ("Umbral");
			repositorio = FactoryDAO.ObtenerRepositorio("Texto", "C:\\Users\\Victor\\Documents\\GitHub\\Temp");
			/*Se crean los responsables de la entrada y salida de usuario*/
			var identificador = new Identificador ();
			var visualizador = new Visualizador ();
            logger.Trazar("Se prepararon los componentes", Nivel.INFO);
		
			/*Inicio del proceso pipeline*/
			/*Identifica las señales*/
			identificador.Ingresar (senialAdquirida, "Señal a Adquirir");
			identificador.Ingresar (senialProcesada, "Señal a Procesar");
            logger.Trazar(senialAdquirida.ToString(), Nivel.INFO);
            logger.Trazar(senialProcesada.ToString(), Nivel.INFO);
            auditor.Auditar("EjemploSenial", this.GetType(), "Adquirir");

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

