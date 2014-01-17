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

    class EstadosFacturaHelper
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

        public virtual void Facturar(EstadoFactura estado)
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

        public virtual void Pagar(EstadoFactura estado)
        {
            switch (estado)
            {
                case EstadoFactura.Emitida:
                    Console.WriteLine("Se Paga");
                    _estado = EstadoFactura.Pagada;
                    break;

                default:
                    Console.WriteLine("Estado no permitido");
                    break;
            }

        }

        public virtual void Cancelar(EstadoFactura estado)
        {
            switch (estado)
            {
                case EstadoFactura.Emitida:
                    Console.WriteLine("Se Cancela");
                    break;

                default:
                    Console.WriteLine("Estado no permitido");
                    break;
            }

        }

        public virtual void Emitir (EstadoFactura estado)
        {
            switch (estado)
            {
                case EstadoFactura.Facturada:
                    Console.WriteLine("Se Emite");
                    _estado = EstadoFactura.Emitida;
                    break;

                default:
                    Console.WriteLine("Estado no permitido");
                    break;
            }

        }

    }
}
