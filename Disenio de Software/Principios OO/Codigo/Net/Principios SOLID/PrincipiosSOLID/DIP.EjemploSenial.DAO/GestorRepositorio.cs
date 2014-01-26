using System;
using DIP.EjemploSenial.Modelo;

namespace DIP.EjemploSenial.DAO
{
	public class GestorRepositorio
	{

		IRepositorio repositorio = null;

		public GestorRepositorio (IRepositorio repositorio)
		{
			this.repositorio = repositorio;
		}

		public void Guardar (Senial senial)
		{
			repositorio.Guardar (senial);
		}
	
		public Senial Recuperar (object id)
		{
			return (repositorio.Recuperar (id));
		}

	}
}

