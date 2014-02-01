using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using REP.EjemploSenial.Modelo;

namespace REP.EjemploSenial.Procesador
{
    /*Simula un proceso de recorte */
    public class ProcesadorConUmbral : IProcesador
    {
        public ProcesadorConUmbral()
        {
        }


        public void Procesar(Senial senialAdquirida, Senial senialProcesada)
        {

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

        }
    }
}
