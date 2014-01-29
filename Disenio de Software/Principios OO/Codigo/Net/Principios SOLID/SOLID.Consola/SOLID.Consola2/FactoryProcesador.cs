using System;


namespace DIP.EjemploSenial.Procesador
{
	public class FactoryProcesador
	{
		public FactoryProcesador ()
		{
		}

		static public IProcesador ObtenerProcesador( string sprocesador)
		{
			IProcesador opProcesador = null;

			if (sprocesador == "Simple") {
				opProcesador = new ProcesadorSimple ();
				}
			else if (sprocesador == "Umbral") {
				opProcesador = new ProcesadorConUmbral ();
				}
			else if (sprocesador == "Diferencial") {
				opProcesador = new ProcesadorDiferencial ();
				}

			return opProcesador;

		}
	}
}

