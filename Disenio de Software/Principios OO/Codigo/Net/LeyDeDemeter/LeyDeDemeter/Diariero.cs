using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeyDeDemeter
{
    class Diariero
    {
                
        #region Metodos Publicos
        public void BuscaDeuda(Cliente cliente)
        {
            Console.WriteLine("Hola {0} ", cliente.Nombre);
            Console.WriteLine("El diariero golpea la puerta...");
            Console.ReadLine();
        }

        public void pidePago(Cliente cliente, float deuda)
        {

            Console.WriteLine("El diariero dice que son ${0} de deuda", deuda);

            #region EjemploIncorrecto
            //Cartera carteraCliente = cliente.MiCartera;

            //if (carteraCliente.Monto > deuda)
            //{
            //    carteraCliente.SacarDinero(deuda);
            //    Console.WriteLine("El diariero cobro los ${0} de deuda", deuda);
            //    Console.ReadLine();
            //}
            //if (cliente.MiCartera.Monto > deuda)
            //    {
            //        cliente.MiCartera.SacarDinero(deuda);
            //        Console.WriteLine("El diariero cobro los ${0} de deuda", deuda);
            //        Console.ReadLine();
            //    }
            //else
            //{
            //    Console.WriteLine("El diariero se va sin cobrar...");
            //    Console.ReadLine();
            //}
            #endregion

            float pago = cliente.Pagar(deuda);
            if (pago == deuda)
            {
                Console.WriteLine("El diariero cobro los ${0} de deuda", deuda);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("El diariero se va sin cobrar...");
                Console.ReadLine();
            }
        }

        #endregion
    }
}
