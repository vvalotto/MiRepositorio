///////////////////////////////////////////////////////////
//  Alumno.cs
//  Implementation of the Class Alumno
//  Generated by Enterprise Architect
//  Created on:      25-oct-2011 10:58:57 a.m.
//  Original author: Victor
///////////////////////////////////////////////////////////




using Entidades;
namespace Entidades {
	public class Alumno {

		private string _nombre;
		private string _apellido;
		private string _legajo;
		public Desempenio m_Desempenio;

		public Alumno(){

		}

		~Alumno(){

		}

		public virtual void Dispose(){

		}

		public string Nombre{
			get;
			set;
		}

		public string Apellido{
			get;
			set;
		}

		public string Legajo{
			get;
			set;
		}

	}//end Alumno

}//end namespace Entidades