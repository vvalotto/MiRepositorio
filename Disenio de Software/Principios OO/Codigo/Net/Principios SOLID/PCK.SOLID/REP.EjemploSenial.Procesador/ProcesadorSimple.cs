using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using REP.EjemploSenial.Modelo;

namespace REP.EjemploSenial.Procesador
{
    /*Simula un proceso de cambio de escala*/
    public class ProcesadorSimple : IProcesador
    {

        public ProcesadorSimple()
        {
        }

        public void Procesar(Senial senialAdquirida, Senial senialProcesada)
        {

            for (int i = 1; i <= senialAdquirida.CantidadValores(); i++)
            {
                senialProcesada.PonerValor((decimal)senialAdquirida.ObtenerValor(i - 1) * 2);
            }

        }
    }

}
