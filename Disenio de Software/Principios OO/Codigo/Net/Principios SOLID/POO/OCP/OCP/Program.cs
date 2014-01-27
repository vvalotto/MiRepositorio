using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OCP
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Forma> ListaFormas = new List<Forma>();

            Cuadrado unCuadrado = new Cuadrado(1.2);
            ListaFormas.Add(unCuadrado);

            Circulo unCirculo = new Circulo(1.2);
            ListaFormas.Add(unCirculo);

            unCirculo = new Circulo(2.52);
            ListaFormas.Add(unCirculo);

            unCuadrado = new Cuadrado(3.1);
            ListaFormas.Add(unCuadrado);
            
         
            foreach (Forma miForma in ListaFormas)
            {
                miForma.Dibujar();
            }

            Console.ReadLine();

            
        }
    }
}
