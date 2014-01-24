using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ISP.EjemploSenial.Adquisidor;
using ISP.EjemploSenial.Modelo;
using ISP.EjemploSenial.Procesador;
using ISP.EjemploSenial.Repo;
using ISP.EjemploSenial.Visualizador;

namespace SOLID.Tratamiento.Consola
{
      class ProgramaNoISP
      {
        public ProgramaNoISP()
        {
        }

        public void Ejecutar()
        {

            /*Caso 1*/
            SenialBasica senialAdquirida = new SenialBasica();
            /*Caso 2*/
            /*SenialPila senialAdquirida = new SenialPila(5);*/
            /*Caso 3*/
            /*SenialCola senialAdquirida = new SenialCola(5);*/
            Senial senialProcesada = new SenialBasica();
            AdquisidorArchivo adquisidor = new AdquisidorArchivo(senialAdquirida);
            ProcesadorDiferencial procesador = new ProcesadorDiferencial();
            Visualizador visualizador = new Visualizador();
            
            Console.WriteLine("Iniciando Adquisicion");
            adquisidor.ubicacion = "c:/Temp/datos.txt";
            adquisidor.LeerSenial();

            Console.Write("Se han adquirido: {0} datos", senialAdquirida.CantidadValores().ToString());
            Console.WriteLine();

            procesador.Procesar(senialAdquirida, senialProcesada);

            Console.WriteLine("Señal Adquirida con fecha: {0}", senialAdquirida.fecha_adquisicion.ToString());
            visualizador.MostrarValores(senialAdquirida);
            Console.WriteLine("Señal Procesada");
            visualizador.MostrarValores(senialProcesada);

            Console.ReadLine();

            Console.Clear();
            Console.Write("Saco el dato: ");
            Console.WriteLine(senialAdquirida.SacarValor().ToString());
            Console.WriteLine("Quedan estos datos :");
            visualizador.MostrarValores(senialAdquirida);
            Console.WriteLine(senialAdquirida.CantidadValores().ToString());

        }
    }
}
