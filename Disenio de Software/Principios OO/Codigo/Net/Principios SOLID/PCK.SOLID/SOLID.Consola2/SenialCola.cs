using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SOLID.Consola
{

    public class SenialCola : Senial
    {
        int _tamanio;
        int _pinicial;
        int _pfinal;
        int _largo;

        public SenialCola(int tamanio)
        {
            _tamanio = tamanio;
            _largo = 0;
            _pinicial = 0;
			_pfinal = 0;
        }

        public override void PonerValor(decimal valor)
        {
            try
            {
                base.PonerValor(valor);
                if (_pfinal == _tamanio)
                {
                    _pfinal = 0;
                }
                else
                {
                    _pfinal++;
                }
                _largo++;
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
                if (_largo != 0)
                {
                    if (_pinicial == (_tamanio - 1))
                    {
                        _valor = base.ObtenerValor(_tamanio - 1);
                        _valores.RemoveAt(_tamanio - 1);
                        _pinicial = 0;
                    }
                    else
                    {
                        _valor = base.ObtenerValor(_pinicial);
                        _valores.RemoveAt(_pinicial);
                        _pinicial++;
                    }
                    _largo--;
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
			/*if (_pfinal > _pinicial)
            {
                return _pfinal - _pinicial;
            }
            else
            {
                return _pfinal - _pinicial + _tamanio;
            }
            */
			return _largo;
        }

        public override void Limpiar()
        {
            base.Limpiar();
            _pfinal = 0;
            _pinicial = 0;
            _largo = 0;
        }
    }
}
