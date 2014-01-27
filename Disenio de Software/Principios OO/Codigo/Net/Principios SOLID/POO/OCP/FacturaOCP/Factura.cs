using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacturaOCP
{
    public class Factura
    {
            private EstadoFacturaBase _estadoFactura;
            public Factura()
            {
                _estadoFactura = new EstadoFacturaCreada();
            }
            public void Facturar()
            {
                _estadoFactura.Facturar();
               
            }
            public void Cancelar()
            {
                _estadoFactura.Cancelar();
            }
            public void Pagar()
            {
                _estadoFactura.Pagar();
            }
            public void Emitir()
            {
                _estadoFactura.Emitir();
            }
        }
    
}
