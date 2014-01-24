using System;
using System.Collections;
using System.Reflection;

namespace LSP.EjemploSenial.ISenial
{
	
    public interface ISenial
    {
		void PonerValor (decimal valor);

        int CantidadValores();

        decimal SacarValor ();

        decimal SacarValor(int indice);
    }        
    
    public abstract class Senial:ISenial
	{
		protected ArrayList _valores = new ArrayList();
		private DateTime _fecha_adquisicion;

		public DateTime fecha_adquisicion {
			get {
				return _fecha_adquisicion;
			}
		}

		public Senial ()
		{
			_fecha_adquisicion = DateTime.Now;
		}

	    public decimal ObtenerValor(int indice)
        {
			return (decimal)this._valores [indice];
		}

        public void Limpiar()
        {
            this._valores.Clear();
        }

        public virtual void PonerValor(decimal valor)
        {
            this._valores.Add(valor);
        }

        public virtual int CantidadValores()
        {
            if (this._valores == null)
            {
                return 0;
            }
            else
            {
                return this._valores.Count;
            }
        }

        public virtual decimal SacarValor(int indice)
        {
            decimal _valor = 0;
            try
            {
                if (this._valores.Count != 0){
                    _valor = this.ObtenerValor(indice);
                    this._valores.RemoveAt(indice);
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

        public virtual decimal SacarValor()
        {
            throw new NotImplementedException();
        }
    }

    public class SenialBasica : Senial
    {
        public SenialBasica(): base()
        {

        }
    }

	public class SenialPila : Senial
	{
		int _tamanio;
        int _tope;

		public int tamanio {
			get {
				return _tamanio;
			}
			set {
				_tamanio = value;
			}
		}

		public SenialPila(int tamanio):base()
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

		public override decimal SacarValor ()
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

		public override int CantidadValores ()
		{
			return this._valores.Count;
		}

	}

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
				_pfinal = 1;
			}

		public override void PonerValor(decimal valor)
			{
                try
                 {
					 base.PonerValor (valor);
					 if (_pfinal == _tamanio) {
						 _pfinal = 0;
					 } else {
						 _pfinal++;
					  }
                      _largo++;
                 }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

			}

		public decimal SacarValor ()
			{
				decimal _valor = 0;

				try{
					if (_largo != 0) {
						if (_pinicial == (_tamanio - 1)){
							_valor = base.ObtenerValor (_tamanio - 1 );
							_valores.RemoveAt (_tamanio - 1);
							_pinicial = 0;	
						}
						else{
							_valor = base.ObtenerValor (_pinicial);
							_valores.RemoveAt (_pinicial);
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
					Console.WriteLine (e.Message);
				}
				return _valor;
			}

        public override int CantidadValores()
        {
            if (_pfinal > _pinicial)
            {
                return _pfinal - _pinicial;
            }
            else
            {
                return _pfinal - _pinicial + _tamanio;
            }
        }

    }

}

