using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NoLSP
{
    class Program
    {
        static void f(Rectangulo rect)
        {
            rect.Base = 34;
        }  

        static void Main(string[] args)
        {
    

            //Rectangulo miRect = new Rectangulo(1, 2);
            //miRect.Alto = 10;
            //miRect.Base = 2;

            //f(miRect);
            //Console.WriteLine("Base: {0}, Altura: {1}", miRect.Base, miRect.Alto);

            //Cuadrado miCuadrado = new Cuadrado();
            //miCuadrado.Alto = 2;
            //miCuadrado.Base = 1;
            //f(miCuadrado);

            //Console.WriteLine("Base: {0}, Altura: {1}", miCuadrado.Base, miCuadrado.Alto);
            //Console.ReadLine();

            Coche miCoche = new Coche("Citroen", "C4", 2000);
            Ciclomotor miMoto = new Ciclomotor("Yamaha", "2008", 450);
            Impuestos miImp = new Impuestos();

            miImp.CalcularImpuesto(miCoche);
            miImp.CalcularImpuesto(miMoto);

            Console.ReadLine();


        }
    }
}
