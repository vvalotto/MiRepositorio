using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OCP_1
{
    class Triangulo : Forma
    {
        public double miBase, miAltura;
        //double miCentroX;
        //double miCentroY;

        public Triangulo(double ba, double al)
        {
            miBase = ba;
            miAltura = al;
        }

        public override void Dibujar()
        {
            double perimetro = miBase * miAltura;
            Console.WriteLine("{0}: {1}", this.ToString(), perimetro);
        }
    }
}
