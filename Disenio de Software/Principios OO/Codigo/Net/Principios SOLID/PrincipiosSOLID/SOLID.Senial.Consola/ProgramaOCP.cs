using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OCP.EjemploSenial.Modelo;
using OCP.EjemploSenial.Adquisidor;
using OCP.EjemploSenial.Procesador;
using OCP.EjemploSenial.Visualizador;

namespace SOLID.Tratamiento.Consola
{
    class ProgramaOCP
    {
        public ProgramaOCP ()
		{
		}

        public void Ejecutar()
        {

            /*OCP*/
            Senial senialAdquirida = new Senial ();
            Senial senialProcesada = new Senial ();

            AdquisidorSimple adquisidor = new AdquisidorSimple (senialAdquirida);
            /*AdquisidorArchivo adquisidor = new AdquisidorArchivo(senialAdquirida);*/

            /*ProcesadorSimple procesador = new ProcesadorSimple();*/
            /*ProcesadorConUmbral procesador = new ProcesadorConUmbral*/

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
        }

    }
}
