using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacturaNoOCP
{
    class Program
    {

        public char SeleccionarOpcion()
        {
            char _opcion;
            int x;

            Console.Clear();

            Console.WriteLine("1. Facturar");
            Console.WriteLine("2. Emitir");
            Console.WriteLine("3. Pagar");
            Console.WriteLine("0. Salir");
            Console.Write("-->");
            x = Console.Read();
            _opcion = Convert.ToChar(x);

            return _opcion;

        }


        static void Main(string[] args)
        {
            char _opcion  = ' ';
            Program p = new Program();

            
            Factura miFactura = new Factura();
            Console.WriteLine(miFactura.Estado);

            while ((_opcion.CompareTo('0') != 0))
            {
 
                Console.Read();
                _opcion = p.SeleccionarOpcion();

                switch (_opcion)
                {
                    case '1':
                        miFactura.Facturar();
                        break;
                    case '2':
                        miFactura.Emitir();
                        break;
                    case '3':
                        miFactura.Emitir();
                        break;
                    case '0':
                        break;
                    default:
                        Console.WriteLine("Opcion Invalida");
                        break;
                }
            }
            
            Console.ReadLine();
        }
    }
}
