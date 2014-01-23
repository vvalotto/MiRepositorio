using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OCP.EjemploSenial.Modelo;

namespace OCP.EjemploSenial.Procesador
{
	/*Para OCP 
	 * Se refactoriza la clase de manera de extender otros tipos de 
	 * funciones procesamiento sin que impacte en los anteriores programas
	 * o que cambiando solo las clase de alto nivel se pueda "armar" la solucion */
    interface IProcesador
    {
        void Procesar(Senial senialAdquirida, Senial senialProcesada);
    }

    /*Simula un proceso de cambio de escala*/
    public class ProcesadorSimple : IProcesador
    {

        public ProcesadorSimple()
        {
        }

        public void Procesar(Senial senialAdquirida, Senial senialProcesada)
        {
            Console.WriteLine();
            Console.WriteLine("Procesando...");
            for (int i = 1; i <= senialAdquirida.CantidadValores(); i++)
            {
                senialProcesada.PonerValor((decimal)senialAdquirida.ObtenerValor(i - 1) * 2);
            }
            Console.WriteLine("Fin proceso!");
        }
    }

    /*Simula un proceso de recorte */
    public class ProcesadorConUmbral : IProcesador
    {
        public ProcesadorConUmbral()
        {
        }


        public void Procesar(Senial senialAdquirida, Senial senialProcesada)
        {
            Console.WriteLine();
            Console.WriteLine("Procesando...");
            for (int i = 1; i <= senialAdquirida.CantidadValores(); i++)
            {
                if ((decimal)senialAdquirida.ObtenerValor(i - 1) < 5)
                {
                    senialProcesada.PonerValor((decimal)senialAdquirida.ObtenerValor(i - 1) * 2);
                }
                else
                {
                    senialProcesada.PonerValor(0);
                }
            }
            Console.WriteLine("Fin proceso!");
        }
    }

    /*Simula un proceso de Datos incremetales - Ejemplo para OCP*/
    public class ProcesadorDiferencial : IProcesador
    {
        public ProcesadorDiferencial()
        {
        }

        public void Procesar(Senial senialAdquirida, Senial senialProcesada)
        {
            decimal _valor_anterior = 0;
            Console.WriteLine();
            Console.WriteLine("Procesando...");
            for (int i = 1; i <= senialAdquirida.CantidadValores(); i++)
            {
                senialProcesada.PonerValor((decimal)senialAdquirida.ObtenerValor(i - 1) - _valor_anterior);
                _valor_anterior = (decimal)senialAdquirida.ObtenerValor(i - 1);
            }
            Console.WriteLine("Fin proceso!");
        }
    }


}
