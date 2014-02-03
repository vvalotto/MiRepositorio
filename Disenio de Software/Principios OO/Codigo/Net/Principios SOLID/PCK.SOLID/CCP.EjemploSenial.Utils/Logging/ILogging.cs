using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCP.EjemploSenial.Utils
{

    public enum Nivel { INFO, WARN, ERROR };
    
    public interface ITrazable
    {

        void IniTraza(Nivel nivel);

        void Trazar(string mensaje, Nivel nivel);


    }
}
