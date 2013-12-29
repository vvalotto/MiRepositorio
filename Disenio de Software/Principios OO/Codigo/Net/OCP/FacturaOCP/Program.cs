using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace FacturaOCP
{
    static class Program
    {

        static void Main(string[] args)
        {
            Factura miFactura = new Factura();

            Console.WriteLine("Inicio");
            miFactura.Facturar();
            miFactura.Emitir();
            miFactura.Pagar();
            miFactura.Cancelar();

            Console.ReadLine();


        }
    }
}
