using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OCP_1
{

    class Cuadrado : Forma
    {
        public double miLado;
        //double miCentroX;
        //double miCentroY;

        public Cuadrado(double la)
        {
            miLado = la;
        }

        public override void Dibujar()
        {
            double perimetro = miLado * 4;
            Console.WriteLine("Cuadrado: {0}", perimetro);
        }
    }
}
