using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacturaOCP
{
    enum EstadoFactura
    {
        Creada,
        Facturada,
        Emitida,
        Pagada,
    }
    
    public abstract class EstadoFacturaBase
    {

        private EstadoFactura _estado;

        public EstadoFactura Estado
        {
            get
            {
                return _estado;
            }

            set
            {
                _estado = value;
            }
        }

        public Factura _factura;
        public abstract void Facturar();
        public abstract void Pagar();
        public abstract void Cancelar();
        public abstract void Emitir();
    }

    public class EstadoFacturaCreada : EstadoFacturaBase
    {

        public override void Pagar()
        {
            Console.WriteLine("Estado Creada, no se puede pagar");
        }
        public override void Cancelar()
        {
            Console.WriteLine("Estado Creada, no se puede Cancelar");
        }
        public override void Facturar()
        {
            switch (estado)
            {
                case EstadoFactura.Creada:
                    Console.WriteLine("Se factura");
                    _estado = EstadoFactura.Facturada;
                    break;

                default:
                    Console.WriteLine("Estado no permitido");
                    break;
            }
        }
        public override void Emitir()
        {
            Console.WriteLine("Estado Creada, no se puede Emitir");
        }

    }
    
    public class EstadoFacturaHecha : EstadoFacturaBase
        {
            public override void Facturar()
            {
                throw new ApplicationException("Tarea ya finalizada");
            }
            public override void Pagar()
            {
                throw new ApplicationException("Imposible cancelar. Tarea finalizada");
            }
            public override void Cancelar()
            {
                throw new ApplicationException("Imposible posponer. Tarea finalizada");
            }

            public override void Emitir()
            {
                throw new NotImplementedException();
            }
        }
        
    public class EstadoFacturaImpresa : EstadoFacturaBase
        {
            public override void Facturar()
            {
                throw new ApplicationException("Imposible Facturar. Tarea cancelada");
            }
            public override void Pagar()
            {
                throw new ApplicationException("Tarea ya cancelada");
            }
            public override void Cancelar()
            {
                throw new ApplicationException("Imposible posponer. Tarea cancelada");
            }
            public override void Emitir()
            {
                throw new NotImplementedException();
            }
        }
 
}
