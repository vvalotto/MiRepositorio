using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CCP.EjemploSenial.Utils
{
    public abstract class Logger:ITrazable
    {
        protected Dictionary<Nivel, int> Niveles = new Dictionary<Nivel, int>();
        protected Nivel _nivel; 

        public  Logger()
        {
            Niveles.Add(Nivel.INFO, 1);
            Niveles.Add(Nivel.WARN, 2);
            Niveles.Add(Nivel.ERROR, 3);
        }

        public virtual void IniTraza(Nivel nivel)
        {
            _nivel = nivel;
        }

        public abstract void Trazar(string mensaje, Nivel nivel);
 
    }
}
