using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ISP.EjemploSenial.Modelo;

namespace ISP.EjemploSenial.Procesador
{
    /*Simula un proceso de Datos incremetales - Ejemplo para OCP*/
    public class ProcesadorDiferencial : IProcesador
    {
        public ProcesadorDiferencial()
        {
        }

        public void Procesar(Senial senialAdquirida, Senial senialProcesada)
        {
            decimal _valor_anterior = 0;
            for (int i = 1; i <= senialAdquirida.CantidadValores(); i++)
            {
                senialProcesada.PonerValor((decimal)senialAdquirida.ObtenerValor(i - 1) - _valor_anterior);
                _valor_anterior = (decimal)senialAdquirida.ObtenerValor(i - 1);
            }
        }
    }
}
