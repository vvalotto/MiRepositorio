///////////////////////////////////////////////////////////
//  Materia.cs
//  Implementation of the Class Materia
//  Generated by Enterprise Architect
//  Created on:      25-oct-2011 10:58:57 a.m.
//  Original author: Victor
///////////////////////////////////////////////////////////




namespace Entidades {
	public class Materia {

		private string _nombre;
		private string _fechaAprobacion;
		private float _evaluacion;

		public Materia(){

		}

		~Materia(){

		}

		public virtual void Dispose(){

		}

		public string Nombre{
			get;
			set;
		}

		public string FechaAprobacion{
			get;
			set;
		}

		public string Evaluacion{
			get;
			set;
		}

	}//end Materia

}//end namespace Entidades