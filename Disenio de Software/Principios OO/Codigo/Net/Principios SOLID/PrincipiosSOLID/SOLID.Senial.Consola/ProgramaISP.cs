using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ISP.EjemploSenial.Adquisidor;
using ISP.EjemploSenial.Modelo;
using ISP.EjemploSenial.Procesador;
using ISP.EjemploSenial.Repo;
using ISP.EjemploSenial.Visualizador;
using ISP.EjemploSenial.Utils;

namespace SOLID.Tratamiento.Consola
{
    class ProgramaISP
    {
        public ProgramaISP()
        {
        }

        public void Ejecutar()
        {

            /* Definicion de la señal a Adquirir */
            /*Caso 1*/
            /*SenialBasica senialAdquirida = new SenialBasica();*/

            /*Caso 2*/
            SenialPilaAT senialAdquirida = new SenialPilaAT(5);
            /*Caso 3*/
            /*SenialCola senialAdquirida = new SenialCola(5);*/
   
            senialAdquirida.descripcion = "Señal Inicial de la prueba - Señal Basica";
            senialAdquirida.Id = 101;
            senialAdquirida.IniAuditoria("c:\\Temp\\Auditor.log");
            senialAdquirida.IniTraza("c:\\Temp\\Logger.log", Nivel.ERROR);

            /* Definicion de la señal Procesda */
            /*Senial senialProcesada = new SenialBasica();*/
            /*Caso 2*/
            SenialPilaAT senialProcesada = new SenialPilaAT(5);
            senialProcesada.IniAuditoria("c:\\Temp\\Auditor.log");
            /*Caso 3*/
            /*SenialCola senialProcesada = new SenialCola(5);*/

            senialProcesada.descripcion = "Señal Procesada - Basica";
            senialProcesada.Id = 500;

            /*Definicion de los procesos invocrados */
            AdquisidorArchivo adquisidor = new AdquisidorArchivo(senialAdquirida);
            ProcesadorDiferencial procesador = new ProcesadorDiferencial();
            Visualizador visualizador = new Visualizador();

            /*Definición de los repositorios para guardar las señales */
            RepositorioArchivo repArchivo = new RepositorioArchivo("c:\\Temp");
            RepositorioXML repXML = new RepositorioXML("c:\\Temp");


            /* Proceso */
            Console.WriteLine("Iniciando Adquisicion");
            adquisidor.ubicacion = "c:\\Temp\\datos.txt";
            adquisidor.LeerSenial();
            Console.Write("Se han adquirido: {0} datos", senialAdquirida.CantidadValores().ToString());
            senialAdquirida.Trazar("Se adquirio la señal", Nivel.INFO);

            Console.WriteLine();

            Console.WriteLine("---->   Procesando la señal");
            procesador.Procesar(senialAdquirida, senialProcesada);
            Console.WriteLine("---->   Fin Proceso");
            senialAdquirida.Trazar("Se proceso la señal", Nivel.INFO);
            senialProcesada.Auditar("sistema", this.GetType().ToString(), "procesar");
            Console.WriteLine();

            Console.WriteLine("Mostrando Procesando la señal: ");
            Console.WriteLine("Señal Adquirida con fecha: {0}", senialAdquirida.fecha_adquisicion.ToString());
            visualizador.MostrarValores(senialAdquirida);
            Console.WriteLine("Señal Procesada");
            visualizador.MostrarValores(senialProcesada);
            senialAdquirida.Trazar("Se Mostro la señal", Nivel.INFO);
            senialProcesada.Auditar("sistema", this.GetType().ToString(), "Mostrar");

            Console.ReadLine();

            /* Manipulo la señal  */
            Console.Clear();
            Console.Write("Saco el dato: ");
            Console.WriteLine(senialAdquirida.SacarValor().ToString());
            Console.WriteLine("Quedan estos datos :");
            visualizador.MostrarValores(senialAdquirida);
            Console.WriteLine(senialAdquirida.CantidadValores().ToString());
            Console.ReadLine();

            /*Se guardan las señales */
            Console.Clear();
            Console.WriteLine("Guarda la Señal {0}", senialAdquirida.descripcion);
            repArchivo.Guardar(senialAdquirida);
            Console.WriteLine("--->");

            Senial senialLeida = repArchivo.Recuperar(101);
            Console.WriteLine("Señal Recuperada :");
            visualizador.MostrarValores(senialLeida);
            Console.WriteLine(senialLeida.CantidadValores().ToString());

            Console.ReadLine();

            Console.WriteLine("---->   Procesando la señal");
            procesador.Procesar(senialLeida, senialProcesada);
            Console.WriteLine("---->   Fin Proceso");

            Console.WriteLine("Mostrando Procesando la señal: ");
            Console.WriteLine("Señal Adquirida con fecha: {0}", senialAdquirida.fecha_adquisicion.ToString());
            visualizador.MostrarValores(senialAdquirida);
            Console.WriteLine("Señal Procesada");
            visualizador.MostrarValores(senialProcesada);

        }
    }
}
