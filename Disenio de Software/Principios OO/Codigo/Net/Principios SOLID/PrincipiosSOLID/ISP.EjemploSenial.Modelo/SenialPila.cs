using System;
using System.Collections;
using System.Linq;
using System.Text;
using ISP.EjemploSenial.Utils;
using System.IO;


namespace ISP.EjemploSenial.Modelo
{
    public class SenialPila: Senial
    {
        int _tamanio;
        int _tope;

        string _nombreAuditor;

        public int tamanio
        {
            get
            {
                return _tamanio;
            }
            set
            {
                _tamanio = value;
            }
        }

        public SenialPila(int tamanio)
            : base()
        {
            _tamanio = tamanio;
            _tope = 0;
        }

        public override void PonerValor(decimal valor)
        {
            try
            {
                if (_tope != _tamanio)
                {
                    base.PonerValor(valor);
                    _tope++;
                }
                else
                {
                    throw new System.InvalidOperationException("No se puede poner mas datos");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public override decimal SacarValor()
        {
            decimal _valor = 0;

            try
            {
                if (_tope != 0)
                {
                    _valor = base.ObtenerValor(_tope - 1);
                    _valores.RemoveAt(_tope - 1);
                    _tope--;
                }
                else
                {
                    throw new System.InvalidOperationException("No hay nada para sacar");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return _valor;
        }

        public override int CantidadValores()
        {
            return this._valores.Count;
        }

    }
}
