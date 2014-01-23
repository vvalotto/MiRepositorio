using System;
using System.Collections;
using System.Reflection;

namespace LSP.EjemploSenial.Modelo
{
	public class Senial
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

		public void PonerValor(decimal valor){
			this._valores.Add (valor);
		}

		/*public void PonerValor(decimal valor){

			int _indice = 0;

			FieldInfo[] _miFieldInfo;
			Type _miTipo = typeof(Senial);
			_miFieldInfo = _miTipo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance| BindingFlags.Public);

			if (this.GetType ().Name == "SenialPila") {
				this._valores.Add (valor);
			} else if (this.GetType ().Name == "SenialCola") {
				for (int i = 0; i < _miFieldInfo.Length; i++) {
					if (_miFieldInfo [i].Name == "_ifinal") { 
						_indice = (int)_miFieldInfo [i].GetValue(null);
					}
				}
				this._valores.Insert (_indice, valor);
			}
		}
		*/

		public int CantidadValores ()
		{
			if (this._valores == null) {
				return 0;
			} else {
				return this._valores.Count;
			}
		}

		public decimal ObtenerValor(int indice){
			return (decimal)this._valores [indice];
		}

		public void Limpiar(){
			this._valores.Clear ();
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

		public SenialPila(int tamanio)
		{
			_tamanio = tamanio;
			_tope = 0;
		}

		public void AgregarValor(decimal valor)
		{
			this.PonerValor (valor);
			_tope++;
			Console.WriteLine(_tope.ToString());
		}

		public decimal SacarValor ()
		{
			decimal _valor = 0;

			try{
				if (_tope != 0) {
					_valor = base.ObtenerValor (_tope - 1);
					_valores.RemoveAt (_tope - 1);
					_tope--;
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

	}

	public class SenialCola : Senial
		{
			int _tamanio;
			int _pinicial;
			int _final;

			public SenialCola(int tamanio)
			{
				_tamanio = tamanio;
				_pinicial = 0;
				_final = 0;
			}

			public void AgregarValor(decimal valor)
			{

				if (_final != _pinicial) { 
					base.PonerValor (valor);
					if (_final == _tamanio) {
						_final = 0;
					} else {
						_final++;
					}
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
		}

}
