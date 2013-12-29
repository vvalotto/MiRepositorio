using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacturaNoOCP
{
    public enum EstadoFactura
    {
        Creada,
        Facturada,
        Emitida,
        Pagada,
 //       Cancelada
    }


    public class Factura
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

        public Factura()
        {
            _estado = EstadoFactura.Creada;
        }

        public void Facturar()
        {
            switch (_estado)
            {
                case EstadoFactura.Creada:
                    Console.WriteLine("Pasa a Facturada");
                    _estado = EstadoFactura.Facturada;
                    break;
                case EstadoFactura.Facturada:
                    Console.WriteLine("Estado no permitido");
                    break;
                case EstadoFactura.Emitida:
                    Console.WriteLine("Estado no permitido");
                    break;
                case EstadoFactura.Pagada:
                    Console.WriteLine("Estado no permitido");
                    break;
                //case EstadoFactura.Cancelada:
                //    Console.WriteLine("Estado no permitido");
                //    break;
            }
        }

        public void Pagar()
        {
            switch (_estado)
            {
                case EstadoFactura.Creada:
                    Console.WriteLine("Estado no permitido");
                    break;
                case EstadoFactura.Facturada:
                    Console.WriteLine("Estado no permitido");
                    break;
                case EstadoFactura.Emitida:
                    Console.WriteLine("Factura Pagada");
                    _estado = EstadoFactura.Pagada;
                    break;
                case EstadoFactura.Pagada:
                    Console.WriteLine("Estado no permitido");
                    break;
                //case EstadoFactura.Cancelada:
                //    Console.WriteLine("Estado no permitido");
                //    break;
            }
        }

        public void Emitir()
        {
            switch (_estado)
            {
                case EstadoFactura.Creada:
                    Console.WriteLine("Estado no permitido");
                    break;
                case EstadoFactura.Facturada:
                    Console.WriteLine("Factura Emitida");
                    _estado = EstadoFactura.Emitida;
                    break;
                case EstadoFactura.Emitida:
                    Console.WriteLine("Estado no permitido");
                    break;
                case EstadoFactura.Pagada:
                    Console.WriteLine("Estado no permitido");
                    break;
                //case EstadoFactura.Cancelada:
                //    Console.WriteLine("Estado no permitido");
                //    break;
            }
        }

    }
}
