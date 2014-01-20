using System;
using System.Collections;
using System.Reflection;

namespace SPR.EjemploSenial.Modelo
{
	public class Senial
	{
		private ArrayList _valores = new ArrayList();

		public void PonerValor(decimal valor){
			this._valores.Add (valor);
		}

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

}
