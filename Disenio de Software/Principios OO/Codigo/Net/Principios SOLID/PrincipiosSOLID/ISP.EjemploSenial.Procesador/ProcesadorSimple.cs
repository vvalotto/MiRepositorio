using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ISP.EjemploSenial.Modelo;

namespace ISP.EjemploSenial.Procesador
{
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

}
