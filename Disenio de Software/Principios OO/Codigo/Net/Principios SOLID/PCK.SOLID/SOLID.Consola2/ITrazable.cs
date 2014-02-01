using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Consola
{

    public enum Nivel { INFO, WARN, ERROR };
    
    public interface ITrazable
    {

        void IniTraza(string alogger, Nivel nivel);

        void Trazar(string mensaje, Nivel nivel);


    }
}
