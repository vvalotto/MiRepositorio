using System;
using DIP.EjemploSenial.Modelo;

namespace DIP.EjemploSenial.Adquisidor
{
	public class GestorAdquisidor
	{
		Adquisidor _adquisidor;

		public Adquisidor adquisidor {
			get {
				return _adquisidor;
			}
			set {
				_adquisidor = value;
			}
		}

		public GestorAdquisidor ()
		{
		}

		public void Adquirir(){
			this.adquisidor.LeerSenial();
		}

		public Senial Obtener(){
			return this.adquisidor.ObtenerSenialAdquirida ();
		}
	}
}

