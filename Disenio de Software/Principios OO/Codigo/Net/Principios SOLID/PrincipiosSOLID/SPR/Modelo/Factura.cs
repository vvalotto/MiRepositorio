using System;

namespace SPR
{
	public class Factura
	{
		public Factura(){
		}

		//Atributos miembros de la clase
		private string _codigo;
		private DateTime _fechaEmision;
		private decimal _importeFactura;
		private decimal _importeIVA;
		private decimal _importeDeduccion;
		private decimal _importeTotal;
		private ushort _porcentajeDeduccion;


		//Propiedades de la clase (en este caso todos lo atributos son expuestos
		#region Propiedades
		public string codigo {
			get {
				return _codigo;
			}
			set {
				_codigo = value;
			}
		}

		public DateTime fechaEmision {
			get {
				return _fechaEmision;
			}
			set {
				_fechaEmision = value;
			}
		}

		public decimal importeFactura {
			get {
				return _importeFactura;
			}
			set {
				_importeFactura = value;
			}
		}

		public decimal importeIVA {
			get {
				return _importeIVA;
			}
			set {
				_importeIVA = value;
			}
		}

		public decimal importeDeduccion {
			get {
				return _importeDeduccion;
			}
			set {
				_importeDeduccion = value;
			}
		}

		public decimal importeTotal {
			get {
				return _importeTotal;
			}
			set {
				_importeTotal = value;
			}
		}

		public ushort porcentajeDeduccion {
			get {
				return _porcentajeDeduccion;
			}
			set {
				_porcentajeDeduccion = value;
			}
		}
		#endregion 

	}
}

