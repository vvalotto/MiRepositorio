using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OCP_1
{

    interface IForma
    {
        void Dibujar();
    }


    public class  Forma : IForma
    {
        public virtual void Dibujar()
        {
        }
    }
}
