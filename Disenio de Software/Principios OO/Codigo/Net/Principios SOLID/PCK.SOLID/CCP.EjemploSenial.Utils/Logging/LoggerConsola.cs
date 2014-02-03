using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CCP.EjemploSenial.Utils
{
    public class LoggerConsola:Logger
    {
        public override void Trazar(string mensaje, Nivel nivel){;

        if (base.Niveles[nivel] <= base.Niveles[_nivel])
            {
            Console.WriteLine("---- Logger");
            Console.WriteLine(DateTime.Now.ToString());
            Console.WriteLine(nivel.ToString() + " - " + mensaje);

            }

        }
    }
}
