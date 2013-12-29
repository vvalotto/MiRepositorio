using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeyDeDemeter
{
    class Program
    {
        static void Main(string[] args)
        {
            //Diariero elDiariero = new Diariero();
            Cliente elCliente = new Cliente();
            //elCliente.Nombre = "juan";
            //elCliente.Apellido = "Perez";
                       
            //elDiariero.BuscaDeuda(elCliente);
            //elDiariero.pidePago(elCliente, 23);

            foreach (var item in elCliente.GetType().GetProperties())
            {
                Console.WriteLine("{0} - {1}", item.Name, item.PropertyType);
            }

            Console.ReadLine();
        }
    }
}
