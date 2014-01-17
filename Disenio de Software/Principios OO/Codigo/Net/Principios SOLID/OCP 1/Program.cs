using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OCP_1
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Forma> Formas = new List<Forma>();

            Cuadrado c1 = new Cuadrado(30);
            Circulo c2 = new Circulo(23);
            Triangulo c3 = new Triangulo(2, 5);

            Formas.Add(c1);
            Formas.Add(c2);
            Formas.Add(c3);

            foreach (Forma forma in Formas)
            {
                forma.Dibujar();
            }
            Console.ReadLine();
        }
    }
}
