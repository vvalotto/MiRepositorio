using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NoOCP
{
    public class EditorGrafico
    {
        public void DibujarForma (Forma f)
        {
            if (f._tipo == 1) 
                DibujarCirculo (f);
            else if (f._tipo == 2)
                DibujarCuadrado (f);
        }

        public void DibujarCirculo (Forma f)
        {
            Console.WriteLine ("Se dibuja un circulo");
        }

        public void DibujarCuadrado(Forma f)
        {
            Console.WriteLine("Se dibuja un cuadrado");
        }



    }
}
