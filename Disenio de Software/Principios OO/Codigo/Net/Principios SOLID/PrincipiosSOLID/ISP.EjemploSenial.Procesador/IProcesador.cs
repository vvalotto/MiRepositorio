using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ISP.EjemploSenial.Modelo;

namespace ISP.EjemploSenial.Procesador
{
    interface IProcesador
    {
        void Procesar(Senial senialAdquirida, Senial senialProcesada);
    }

}
