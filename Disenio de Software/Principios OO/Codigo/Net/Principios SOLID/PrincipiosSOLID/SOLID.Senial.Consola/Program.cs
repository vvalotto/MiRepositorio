using System;
/*using SPR.EjemploSenial.Modelo;
using SPR.EjemploSenial.Adquisidor;
using SPR.EjemploSenial.Procesador;
using SPR.EjemploSenial.Visualizador;*/

/*using OCP.EjemploSenial.Modelo;
using OCP.EjemploSenial.Adquisidor;
using OCP.EjemploSenial.Procesador;
using OCP.EjemploSenial.Visualizador;
*/

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

			string _opcion = "99";
			/* Menu de Entrada */
			while (_opcion != "0") {
				Console.WriteLine ("Seleccion de demostraciones");
				Console.WriteLine ();
				Console.WriteLine ("> 1 . Ejemplo NO SRP");
				Console.WriteLine ("> 2 . Ejemplo SPR");
				Console.WriteLine ("> 3 . Ejemplo No OCP");
                Console.WriteLine ("> 4 . Ejemplo OCP");
				Console.WriteLine ("> 5. Ejemplo No LSP");
			

				Console.Write ("Seleccione una opcion:");
				_opcion = Console.ReadLine ();

				switch (_opcion) {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Ejmeplo NO SRP");
					    ProgramaNoSRP ejemNOSRP = new ProgramaNoSRP ();
					    ejemNOSRP.Ejecutar ();
					    break;
				case "2": 
						ProgramaSRP ejemSRP = new ProgramaSRP ();
						ejemSRP.Ejecutar ();
						break;
				case "3": 
						ProgramaNoOCP ejemNoOCP = new ProgramaNoOCP ();
						ejemNoOCP.Ejecutar ();
						break;
                case "4": 
						ProgramaOCP ejemOCP = new ProgramaOCP ();
						ejemOCP.Ejecutar ();
						break;
				case "5": 
					ProgramaNoLSP ejemNoLSP = new ProgramaNoLSP ();
						ejemNoLSP.Ejecutar ();
						break;

				}

			}



			/*OCP
			Senial senialAdquirida = new Senial ();
			Senial senialProcesada = new Senial ();
			AdquisidorSimple adquisidor = new AdquisidorSimple (senialAdquirida);
			ProcesadorDiferencial procesador = new ProcesadorDiferencial ();
			Visualizador visualizador = new Visualizador ();

			Console.WriteLine ("Iniciando");
			adquisidor.ubicacion = "/Users/vvalotto/Documents/Temp/datos.txt";
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


			Console.WriteLine ("Fin");
			Console.ReadLine ();

		}
	}
}
