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
			senialAdquirida.descripcion = "Primera Señal";
			senialAdquirida.Id = 101;
            /*Caso 2*/
            /*SenialPila senialAdquirida = new SenialPila(5);*/
            /*Caso 3*/
            /*SenialCola senialAdquirida = new SenialCola(5);*/
            Senial senialProcesada = new SenialBasica();
			senialProcesada.descripcion = "Señal Procesada";
			senialProcesada.Id = 500;

            AdquisidorArchivo adquisidor = new AdquisidorArchivo(senialAdquirida);
            ProcesadorDiferencial procesador = new ProcesadorDiferencial();
            Visualizador visualizador = new Visualizador();

			RepositorioArchivo repArchivo = new RepositorioArchivo ("/Users/vvalotto/Documents/Temp");
			RepositorioXML repXML = new RepositorioXML ("/Users/vvalotto/Documents/Temp");

            Console.WriteLine("Iniciando Adquisicion");
			adquisidor.ubicacion = "/Users/vvalotto/Documents/Temp/datos.txt";
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
			Console.WriteLine(senialAdquirida.SacarValor(1).ToString());
            Console.WriteLine("Quedan estos datos :");
            visualizador.MostrarValores(senialAdquirida);
            Console.WriteLine(senialAdquirida.CantidadValores().ToString());

			Console.WriteLine ("Se guarda la señal");
			repXML.Guardar (senialAdquirida);
			repXML.Auditar (senialAdquirida, this.GetType ().ToString ());
			repArchivo.Guardar (senialProcesada);
			repArchivo.Auditar (senialProcesada, this.GetType ().ToString ());



        }
    }
}
