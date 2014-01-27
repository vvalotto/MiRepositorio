using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace OCP_1
{
    class Circulo : Forma
    {
        public double miRadio;
        //double miCentroX;
        //double miCentroY;

        public Circulo(double ra)
        {
            miRadio = ra;
        }
 
        public override void Dibujar()
        {
            double perimetro = 3.14 * Math.Pow(miRadio, 2);
            Console.WriteLine("Circulo {0}", perimetro);
        }
    }
}
