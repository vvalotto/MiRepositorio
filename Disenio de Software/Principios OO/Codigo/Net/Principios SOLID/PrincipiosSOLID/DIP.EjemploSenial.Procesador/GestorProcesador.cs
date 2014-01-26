using System;
using DIP.EjemploSenial.Modelo;

namespace DIP.EjemploSenial.Procesador
{
	public class GestorProcesador 
	{
		IProcesador _procesador = null;


		public GestorProcesador (IProcesador procesador)
		{
			this._procesador = procesador;
		}

		public void Procesar(Senial senAdquirida, Senial senProcesada)
		{
			try
			{
				_procesador.Procesar (senAdquirida, senProcesada);
			}
			catch (Exception e) {
				Console.WriteLine (e.Message);
			}
		}
	}
}

