using System;
using System.Collections;

namespace LSP.EjemploSenial.ModeloAnt
{
	public class Senial
	{
		private ArrayList _valores = new ArrayList();
		/*Para OCP
		 * Se agrega un atributo 
		 */

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
