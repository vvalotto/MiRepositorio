using System;
using System.Collections;
using System.Reflection;

namespace LSP.EjemploSenial.ModeloMejorado
{
	public abstract class SenialMejorada
	{
		protected ArrayList _valores = new ArrayList();
		private DateTime _fecha_adquisicion;

		public DateTime fecha_adquisicion {
			get {
				return _fecha_adquisicion;
			}
		}

		public SenialMejorada ()
		{
			_fecha_adquisicion = DateTime.Now;
		}

		public abstract void PonerValor (decimal valor);


		public abstract int CantidadValores ();


		public abstract decimal ObtenerValor (int indice);


		public abstract decimal SacarValor ();

	}

	public class SenialPila : SenialMejorada
	{
		int _tamanio;

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
		}

		public override void PonerValor(decimal valor)
		{
			this._valores.Add (valor);
			_tamanio++;

		}

		public override decimal SacarValor ()
		{
			decimal _valor = 0;

			try{
				if (_tamanio != 0) {
					_valor = base.ObtenerValor (_tamanio - 1);
					_valores.RemoveAt (_tamanio - 1);
					_tamanio--;
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

		public override decimal ObtenerValor (int indice)
		{
			throw new NotImplementedException ();
		}

		public override int CantidadValores ()
		{
			throw new NotImplementedException ();
		}


	}

	public class SenialCola : SenialMejorada
	{
		int _tamanio;
		int _pinicial;
		int _pfinal;

		public SenialCola(int tamanio):base()
		{
			_tamanio = tamanio;
			_pinicial = 0;
			_pfinal = 0;
		}

		public override void PonerValor(decimal valor)
		{
			try
			{
				if (_pfinal != _pinicial) 
				{ 
					base._valores.Insert (_pfinal, valor);
					if (_pfinal == _tamanio) {
						_pfinal = 0;
					} else {
						_pfinal++;
					}
				}
				else {
					throw new System.InvalidOperationException("No hay lugar para poner");
				}
			}
			catch (Exception e)
			{
				Console.WriteLine (e.Message);
			}

		}

		public decimal SacarValor ()
		{
			decimal _valor = 0;

			try{
				if (_tamanio != 0) {
					if (_pinicial == (_tamanio - 1)){
						_valor = base.ObtenerValor (_tamanio - 1 );
						_valores.RemoveAt (_tamanio - 1);
						_pinicial = 0;	
					}
					else{
						_valor = base.ObtenerValor (_pinicial);
						_valores.RemoveAt (_pinicial- 1);
						_pinicial++;
					}
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

		public override decimal ObtenerValor (int indice)
		{
			throw new NotImplementedException ();
		}

		public override int CantidadValores ()
		{
			throw new NotImplementedException ();
		}

	}


}
