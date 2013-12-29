using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NoOCP
{
    class Program
    {
        static void Main(string[] args)
        {

            EditorGrafico miEditor = new EditorGrafico();
            
            miEditor.DibujarForma(new Circulo());

            Console.ReadLine();

        }
    }
}
