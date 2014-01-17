using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;

namespace OCP
{
    public interface Forma 
    {
        void Dibujar();
    }

    public class Cuadrado: Forma
    {
        double _lado;

        public Cuadrado (double lado)
        {
            _lado = lado;
        }


        public double Lado
        {
            get { return _lado;}
            set { _lado = value;}
        }

        public void Dibujar()
        {
            Console.WriteLine("Dibujo un Cuadrado de lado " + _lado);
        }


    }

    public class Circulo : Forma
    {
        double _radio;

        public Circulo (double radio)
        {
            _radio = radio;
        }


        public double Radio
        {
            get { return _radio; }
            set { _radio = value; }
        }


        public void Dibujar()
        {
            Console.WriteLine("Dibujo un Circulo de radio " + _radio);
        }

    }

 
}
