using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP.EjemploSenial.Utils.ITtrazable
{

    public enum Nivel { INFO, WARN, ERROR };
    
    public class ITrazable
    {

        void Inicializar();

        void Trazar(string mensaje, Nivel nivel);


    }
}
